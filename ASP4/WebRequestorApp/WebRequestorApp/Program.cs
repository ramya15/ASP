﻿using System;
using System.IO;
using System.Net;
using System.Text;

namespace WebRequestorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest req = WebRequest.Create("https://www.microsoft.com");
            WebResponse resp = req.GetResponse();

            StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.ASCII);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
