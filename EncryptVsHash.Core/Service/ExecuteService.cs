using EncryptVsHash.Core.Entities;
using EncryptVsHash.Core.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptVsHash.Core.Service
{
    public class ExecuteService : IExecute
    {
        public ExecuteService() { }

        public async Task<ResponseForValue> Encrypt(string vValue)
        {
            string resultEncrypt;
            byte[] encryted = Encoding.Unicode.GetBytes(vValue);
            resultEncrypt = Convert.ToBase64String(encryted);
            var responseForValue = new ResponseForValue { vValueString = resultEncrypt, dDateTime = DateTime.Now };
            return responseForValue;
        }

        public async Task<ResponseForValue> Decrypt(string vValue)
        {
            string resultDecrypt;
            byte[] decryted = Convert.FromBase64String(vValue);
            resultDecrypt = Encoding.Unicode.GetString(decryted);
            var responseForValue = new ResponseForValue { vValueString = resultDecrypt, dDateTime = DateTime.Now };
            return responseForValue;
        }

        public async Task<ResponseForValue> HASHMD5(string vValue)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(vValue);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
            }
            var responseForValue = new ResponseForValue { vValueString = (sb.ToString()), dDateTime = DateTime.Now };
            return responseForValue;
        }

        public async Task<ResponseForValue> HASHSHA1(string vValue)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(vValue);
            byte[] hash = sha1.ComputeHash(inputBytes);
            var responseForValue = new ResponseForValue { vValueString = (Convert.ToBase64String(hash)), dDateTime = DateTime.Now };
            return responseForValue;
        }

        public async Task<ResponseForValue> HASHSHA256(string vValue)
        {
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(vValue));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            var responseForValue = new ResponseForValue { vValueString = (sb.ToString()), dDateTime = DateTime.Now };
            return responseForValue;
        }

        public async Task<ResponseForValue> HASHSHA384(string vValue)
        {
            string hash;
            using (SHA384 sha384Hash = SHA384.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(vValue);
                byte[] hashBytes = sha384Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
            var responseForValue = new ResponseForValue { vValueString = hash, dDateTime = DateTime.Now };
            return responseForValue;
        }

        public async Task<ResponseForValue> HASHSHA512(string vValue)
        {
            string responseHash = null;
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] byteValue = UE.GetBytes(vValue);
            SHA512Managed hashString = new SHA512Managed();
            string encodeData = Convert.ToBase64String(byteValue);
            hashValue = hashString.ComputeHash(UE.GetBytes(encodeData));
            foreach (byte x in hashValue)
            {
                responseHash += string.Format("{0:x2}", x);
            }
            var responseForValue = new ResponseForValue { vValueString = responseHash, dDateTime = DateTime.Now };
            return responseForValue;
        }
    }
}
