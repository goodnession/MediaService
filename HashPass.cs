using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MediaService
{
    class HashPass
    {
        private string password;
        public string hash;

        public HashPass(string pass)
        {
            password = pass;
            PassToHash();
        }

        private void PassToHash()
        {
            byte[] tmpSource;
            byte[] tmpHash;
            //Create a byte array from source data
            tmpSource = ASCIIEncoding.ASCII.GetBytes(password);

            //Compute hash based on source data
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            hash = ByteArrayToString(tmpHash);
        }

        private string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
