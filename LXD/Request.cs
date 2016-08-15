﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXD
{
    public class Request : RestRequest
    {
        public Request(string resouce)
            : base(resouce)
        {
            JsonSerializer = new RestSharpSerializer();
        }

        public Request(string resouce, Method method)
            : base(resouce, method)
        {
            JsonSerializer = new RestSharpSerializer();
        }
    }
}