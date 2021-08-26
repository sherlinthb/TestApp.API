using System;

namespace TestApp.API.Models
{
    public class Info
    {
        public int Id {get;set;}
        public string category {get;set;}
        public string label {get;set;}
        public string information {get;set;} 

        public DateTime DateTimeCreated {get;set;}
        public DateTime DateTimeChanged {get;set;}

    }
}