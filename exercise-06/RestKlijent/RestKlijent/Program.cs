using System;
using System.Net;
using System.Runtime.Serialization;
using System.IO;
using System.Collections.Generic;

namespace RestKlijent
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest zahtjev = WebRequest.CreateHttp("http://localhost:5000/api/Osoba");
            zahtjev.Accept = "application/xml";
            HttpWebResponse odgovor = (HttpWebResponse)zahtjev.GetResponse();
            Stream podaci = odgovor.GetResponseStream();

            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Osoba>));
            List<Osoba> popis = (List<Osoba>)serializer.ReadObject(podaci);

            foreach(Osoba x in popis)
            {
                Console.WriteLine("Ime: {0}\nPrezime: {1}\nDatum rođenja: {2}\n",x.Ime,x.Prezime,x.DatumRodenja.ToShortDateString());
            }
        }
    }
}
