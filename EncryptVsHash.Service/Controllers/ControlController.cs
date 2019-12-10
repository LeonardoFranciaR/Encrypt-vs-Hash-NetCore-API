using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncryptVsHash.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EncryptVsHash.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlController : ControllerBase
    {
        private readonly IExecute _execute;

        public ControlController(IExecute execute)
        {
            _execute = execute;
        }

        //Encrypt 
        [HttpGet, Route("GetEncrypt")]
        public async Task<IActionResult> GetEncrypt(string vValue)
        {
            return Ok(await _execute.Encrypt(vValue));
        }

        //Decrypt 
        [HttpGet, Route("GetDecrypt")]
        public async Task<IActionResult> GetDecrypt(string vValue)
        {
            return Ok(await _execute.Decrypt(vValue));
        }

        //MD5 HASH
        [HttpGet, Route("GetHashMD5")]
        public async Task<IActionResult> GetHashMD5(string vValue)
        {
            return Ok(await _execute.HASHMD5(vValue));
        }

        //SHA1 HASH
        [HttpGet, Route("GetHashSHA1")]
        public async Task<IActionResult> GetHashSHA1(string vValue)
        {
            return Ok(await _execute.HASHSHA1(vValue));
        }

        //SHA256 HASH
        [HttpGet, Route("GetHashSHA256")]
        public async Task<IActionResult> GetHashSHA256(string vValue)
        {
            return Ok(await _execute.HASHSHA256(vValue));
        }

        //SHA384 HASH
        [HttpGet, Route("GetHashSHA384")]
        public async Task<IActionResult> GetHashSHA384(string vValue)
        {
            return Ok(await _execute.HASHSHA384(vValue));
        }

        //SHA512 HASH
        [HttpGet, Route("GetHashSHA512")]
        public async Task<IActionResult> GetHashSHA512(string vValue)
        {
            return Ok(await _execute.HASHSHA512(vValue));
        }

    }
}
