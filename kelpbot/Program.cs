using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace kelpbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;
            time = 0;
            Console.WriteLine("Current Date & Time {0}", DateTime.Now);
            Console.ReadLine();
            
            string sURL;
            sURL = "https://splatoon2.ink/data/schedules.json";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            wrGETURL.Proxy = WebProxy.GetDefaultProxy();

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    Console.WriteLine("{0}:{1}", i, sLine);
            }
            Console.ReadLine();


        }

    }
}
