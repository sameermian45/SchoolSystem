using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_SchoolSystem.Classes.HelperClasses
{
    public  class JsonResponce
    {
       
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }
        public Object ObjectData { get; set; }
        public IEnumerable<Object> ListObjectData { get; set; }
        public IEnumerable<Object> ListObjectData1 { get; set; }
    }
}