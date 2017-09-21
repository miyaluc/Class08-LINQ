﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab08_miya
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            using (StreamReader sr = File.OpenText("data.json"))
            {
                data = File.ReadAllLines("data.json")[0]; 
            }

            Console.WriteLine("Hello World!");

            RootObject AllAccessPass = JsonConvert.DeserializeObject<RootObject>(data);


            //Properties neighborhood = new Properties();
        }
        
    }
    public class Geometry
    {
        public string type
        {
            get; set;
        }
        public List<double> coordinates
        {
            get; set;
        }
    }

    public class Properties
    {
        public string zip
        {
            get; set;
        }
        public string city
        {
            get; set;
        }
        public string state
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public string borough
        {
            get; set;
        }
        public string neighborhood
        {
            get; set;
        }
        public string county
        {
            get; set;
        }
    }

    public class Feature
    {
        public string type
        {
            get; set;
        }
        public Geometry geometry
        {
            get; set;
        }
        public Properties properties
        {
            get; set;
        }
    }

    public class RootObject
    {
        public string type
        {
            get; set;
        }
        public List<Feature> features
        {
            get; set;
        }
    }
}
