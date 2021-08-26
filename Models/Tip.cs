using System;

namespace TestApp.API.Models
{
    public class Tip
    {
        public int tipId {get;set;}
        public string tipCategory {get;set;}
        public string tipLabel {get;set;}
        public string tipInfo {get;set;} 

        public DateTime tipDateTimeCreated {get;set;}
        public DateTime tipDateTimeChanged {get;set;}
    }
}