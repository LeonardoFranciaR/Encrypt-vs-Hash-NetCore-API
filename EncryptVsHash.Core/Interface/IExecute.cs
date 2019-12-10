using EncryptVsHash.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EncryptVsHash.Core.Interface
{
    public interface IExecute
    {
        Task<ResponseForValue> Encrypt(string vValue);
        Task<ResponseForValue> Decrypt(string vValue);
        Task<ResponseForValue> HASHMD5(string vValue);
        Task<ResponseForValue> HASHSHA1(string vValue);
        Task<ResponseForValue> HASHSHA256(string vValue);
        Task<ResponseForValue> HASHSHA384(string vValue);
        Task<ResponseForValue> HASHSHA512(string vValue);
    }
}
