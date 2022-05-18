using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPTest.Models
{
    internal class ResponseResult
    {
        private string _code;
        private string _message;

        public ResponseResult(string code, string message)
        {
            _code = code;
            _message = message;

        }

        public string Code { get => _code; set => _code = value; }
        public string Message { get => _message; set => _message = value; }
    }
}
