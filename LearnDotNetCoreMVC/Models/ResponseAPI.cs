using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCoreMVC.Models
{
    public class ResponseAPI
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public Object Data { get; set; }
    }
}
