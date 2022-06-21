using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Views.Message
{
    public interface OnMessageItemClick
    {
        void Click(string id , string sender, string title, string message);
    }
}
