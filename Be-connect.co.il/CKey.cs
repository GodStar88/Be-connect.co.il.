using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Be_connect.co.il
{
    class CKey
    {
        public bool keyCheck()
        {
            WebRequest request = null;
            WebResponse response = null;
            Stream resStream = null;
            StreamReader resReader = null;
            Boolean programRun = false;
            try
            {
                string uristring = "http://venusgod.eu.pn/check.html";
                request = WebRequest.Create(uristring.Trim());
                response = request.GetResponse();
                resStream = response.GetResponseStream();
                resReader = new StreamReader(resStream);
                string resstring = resReader.ReadToEnd();
                string keyString = "Be=true";
                if (resstring.Contains(keyString))
                {
                    programRun = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (resReader != null) resReader.Close();
                if (response != null) response.Close();
            }
            System.Threading.Thread.Sleep(2000);
            return programRun;
        }
    }
}
