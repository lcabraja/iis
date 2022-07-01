using API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace szdgl
{
    class Program
    {
        private static HttpWebRequest CreateRequest(string subpath = "/Peoples", string contentType = "application/xml")
        {
            HttpWebRequest req = WebRequest.CreateHttp($"http://localhost:5001/api${subpath}");
            req.Accept = "application/xml";
            return req;
        }
        static void Main(string[] args)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Person>));
            // POST
            HttpWebRequest post = WebRequest.CreateHttp($"http://localhost:8000/api/Peoples");
            post.Method = "POST";
            post.ContentType = "application/xml";
            Person person = new Person
            {
                DateOfBirth = DateTime.Now.AddYears(-21),
                Name = "Ivan",
                Surname = "Horvat"
            };
            MemoryStream stream = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(stream);
            serializer.WriteObject(writer, person);
            writer.Close();
            byte[] data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(stream.ToArray()));
            Stream bodystream = post.GetRequestStream();
            bodystream.Write(data, 0, data.Length);
            bodystream.Close();
            HttpWebResponse postres = (HttpWebResponse)post.GetResponse();
            Console.WriteLine(postres.StatusCode);
            // GET
            //HttpWebRequest get = CreateRequest();
            //get.Method = "GET";
            //HttpWebResponse res = (HttpWebResponse)get.GetResponse();
            //Stream twitch = res.GetResponseStream();
            //List<Person> peopl = (List<Person>)serializer.ReadObject(twitch);
            //peopl.ForEach(Console.WriteLine);
        }
    }
}
