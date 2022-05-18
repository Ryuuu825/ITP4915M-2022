using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPTest.Models
{
    internal class ErrorMsg
    {
        private string message;
        private string errorCode;

        public string Message { get => message; set => message = value; }
        public string ErrorCode { get => errorCode; set => errorCode = value; }
    }
}
