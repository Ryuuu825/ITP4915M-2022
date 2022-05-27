using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.CustomizeEvent
{
    internal class ErrorValueChecked
    {
        public class CustomValueChecked : EventArgs
        {
            private bool isError;
            public CustomValueChecked(bool er)
            {
                this.isError = er;
            }
            public bool IsError
            {
                get { return this.isError; }
            }
        }

        public delegate void CustomCheckHandler(object sender, CustomValueChecked e);
        public event CustomCheckHandler CustomPrintEvent;

        public void ErrorChecked (bool er)
        {
            CustomValueChecked e = new CustomValueChecked(er);
            CustomPrintEvent(this, e);
        }
    }
}
