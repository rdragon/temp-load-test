using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoadTester.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncodeController : ControllerBase
    {
        [HttpGet]
        public string Get(int iterationCount = 16384, int blockSize = 8, int threadCount = 1, string password = "password")
        {
            var scrypt = new Scrypt.ScryptEncoder(iterationCount, blockSize, threadCount);

            return scrypt.Encode(password);
        }
    }
}
