using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;


namespace QLicense
{
    public class LicenseHandler
    {
        
        public static string GetHardwareID()
        {
            return HardwareInfo.GenerateDeviceId();
        }

        public static string GenerateLicenseBASE64String(string licenseObjectXMLString, string certFilePath, string certFilePwd)
        {
            //Command for creating the certificate
            //>> makecert -r -pe -sk "LIC_XML_SIGN_KEY" -n "CN=DummyDocAuto" -$ commercial -cy authority -sky signature -ss my -sr currentuser
            //Then export the cert with private key from key store with password above
            //Also export another cert with only public key
            XmlDocument _licenseObject = new XmlDocument();
            _licenseObject.LoadXml(licenseObjectXMLString);


            //Get RSA key from certificate
            X509Certificate2 cert = new X509Certificate2(certFilePath, certFilePwd);

            RSACryptoServiceProvider rsaKey = (RSACryptoServiceProvider)cert.PrivateKey;

            //Sign the XML
            SignXML(_licenseObject, rsaKey);

            //Convert the signed XML into BASE64 string            
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(_licenseObject.OuterXml));
        }


        public static string GetLicenseObjectXMLFromBASE64String(string licenseObject, string certFilePath)
        {
            try
            {
                //Get RSA key from certificate
                X509Certificate2 cert = new X509Certificate2(certFilePath);
                RSACryptoServiceProvider rsaKey = (RSACryptoServiceProvider)cert.PublicKey.Key;

                XmlDocument xmlDoc = new XmlDocument();

                // Load an XML file into the XmlDocument object.
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.LoadXml(Encoding.UTF8.GetString(Convert.FromBase64String(licenseObject)));

                // Verify the signature of the signed XML.            
                if (VerifyXml(xmlDoc, rsaKey))
                {
                    XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");
                    xmlDoc.DocumentElement.RemoveChild(nodeList[0]);

                    return xmlDoc.OuterXml;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }


        }

        // Sign an XML file. 
        // This document cannot be verified unless the verifying 
        // code has the key with which it was signed.
        private static void SignXML(XmlDocument xmlDoc, RSA Key)
        {
            // Check arguments.
            if (xmlDoc == null)
                throw new ArgumentException("xmlDoc");
            if (Key == null)
                throw new ArgumentException("Key");

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = Key;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            // Add an enveloped transformation to the reference.
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

        }

        // Verify the signature of an XML file against an asymmetric 
        // algorithm and return the result.
        private static Boolean VerifyXml(XmlDocument Doc, RSA Key)
        {
            // Check arguments.
            if (Doc == null)
                throw new ArgumentException("Doc");
            if (Key == null)
                throw new ArgumentException("Key");

            // Create a new SignedXml object and pass it
            // the XML document class.
            SignedXml signedXml = new SignedXml(Doc);

            // Find the "Signature" node and create a new
            // XmlNodeList object.
            XmlNodeList nodeList = Doc.GetElementsByTagName("Signature");

            // Throw an exception if no signature was found.
            if (nodeList.Count <= 0)
            {
                throw new CryptographicException("Verification failed: No Signature was found in the document.");
            }

            // This example only supports one signature for
            // the entire XML document.  Throw an exception 
            // if more than one signature was found.
            if (nodeList.Count >= 2)
            {
                throw new CryptographicException("Verification failed: More that one signature was found for the document.");
            }

            // Load the first <signature> node.  
            signedXml.LoadXml((XmlElement)nodeList[0]);

            // Check the signature and return the result.
            return signedXml.CheckSignature(Key);
        }

        public static bool ValidateHardwareID(string hardwareId)
        {
            return HardwareInfo.ValidateDeviceID(hardwareId);
        }
    }

}
