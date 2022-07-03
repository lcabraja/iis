using API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            int PORT = 5000;
            DataContractSerializer serializer = new DataContractSerializer(typeof(Student));
            // POST
            HttpWebRequest post = WebRequest.CreateHttp($"http://localhost:{PORT}/api/Student");
            post.Method = "POST";
            post.ContentType = "application/xml";
            Student person = new Student
            {
                Name = "Ivan",
                Surname = "Goran Kovo",
                Grade = 2,
                Subject = "Monopoly"
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
            Console.WriteLine();
            // GET
            serializer = new DataContractSerializer(typeof(List<Student>));
            HttpWebRequest get = WebRequest.CreateHttp($"http://localhost:{PORT}/api/Student");
            get.Accept = "application/xml";
            get.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)get.GetResponse();
            Stream twitch = res.GetResponseStream();
            List<Student> peopl = (List<Student>)serializer.ReadObject(twitch);
            peopl.ForEach(Console.WriteLine);
        }
    }
    }
