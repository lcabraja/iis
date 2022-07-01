using System;
using System.Net;
using System.Xml;
using System.IO;

namespace IIS_Exercise_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*HttpWebRequest request = WebRequest.CreateHttp("https://api.hnb.hr/tecajn/v2?valuta=EUR&format=xml");
             HttpWebResponse response = (HttpWebResponse)request.GetResponse();
             Stream data = response.GetResponseStream();
             XmlDocument document = new XmlDocument();
             document.Load(data);
             //document.Save(Console.Out);
             //document.Save("tecaj.xml");*/

            /*XmlNodeList kupovni = document.GetElementsByTagName("kupovni_tecaj");
            Console.WriteLine(kupovni[0].InnerText);

            XmlNodeList srednji = document.GetElementsByTagName("srednji_tecaj");
            Console.WriteLine(srednji[0].InnerText);

            XmlNodeList prodajni = document.GetElementsByTagName("prodajni_tecaj");
            Console.WriteLine(prodajni[0].InnerText);*/

            Console.WriteLine("Molim datum od (YYYY-MM-DD): ");
            string datefrom = Console.ReadLine();

            //Console.WriteLine("Molim datum do (YYYY-MM-DD): ");
            //string dateto = Console.ReadLine();

            Console.WriteLine("Molim valutu (EUR, USD): ");
            string currency = Console.ReadLine();

            HttpWebRequest request = WebRequest.CreateHttp($"https://api.hnb.hr/tecajn/v2?datum-primjene={datefrom}&format=xml");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream data = response.GetResponseStream();
            XmlDocument document = new XmlDocument();
            document.Load(data);

            XmlNodeList EUR = document.SelectNodes($"/tecajna_lista/item[valuta = \"{currency}\"]");

            foreach (XmlNode x in EUR)
            {
                Console.WriteLine(x["datum_primjene"].InnerText + " " + x["srednji_tecaj"].InnerText);
            }
        }
    }
}
