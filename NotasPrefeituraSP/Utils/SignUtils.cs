using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NotasPrefeituraSP.Utils
{
    class SignUtils
    {
        /// <summary>
        /// Transform text in SHA1 hash and sign hash with RSA-SHA1
        /// </summary>
        /// <param name="text">Text to sign</param>
        /// <param name="key">Use private key of X509Certificate2</param>
        /// <returns>Byte array with text signed</returns>
        public static byte[] SignRSASHA1Text(string text, X509Certificate2 key)
        {
            return SignRSASHA1Text(text, (RSACryptoServiceProvider)key.PrivateKey);
        }

        /// <summary>
        /// Transform text in SHA1 hash and sign hash with RSA-SHA1
        /// </summary>
        /// <param name="text">Text to sign</param>
        /// <param name="key">Key to sign</param>
        /// <returns>Byte array with text signed</returns>
        public static byte[] SignRSASHA1Text(string text, RSACryptoServiceProvider key)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] textBytes = Encoding.Unicode.GetBytes(text);
            byte[] sha1Bytes = sha1.ComputeHash(textBytes);

            return key.SignHash(sha1Bytes, CryptoConfig.MapNameToOID("SHA1"));
        }
    }
}
