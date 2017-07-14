using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_connect.co.il
{
    class CFormControl
    {
        public void waitTimeOut(int time)
        {
            FormText(" Waiting " + time.ToString() + "s");
            System.Threading.Thread.Sleep(1000);
        }

        public void FormText(string str)
        {
            try { Form1.Instance.TextStatus = str; } catch (Exception) { }
        }
    }
}
