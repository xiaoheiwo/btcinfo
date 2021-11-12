using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace btcinfo
{
    class btcAPI
    {
        public static string GETinfo(String coin)
        {

            try
            {
                String URL = "https://api3.binance.com/api/v3/ticker/price?symbol="+coin;
                HttpWebRequest Myrq = (HttpWebRequest)WebRequest.Create(URL);
                Myrq.Method = "GET";
                Myrq.Timeout = 3000;
                HttpWebResponse Myrp = (HttpWebResponse)Myrq.GetResponse();
                if (Myrp.StatusCode != HttpStatusCode.OK)
                {
                    return null;
                }
                String html;
                using (StreamReader sr = new StreamReader(Myrp.GetResponseStream()))
                {
                    html = sr.ReadToEnd();
                }

                return html;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("请求出错：" + ex.Message);
                return null;
            }


        }
    }

}
