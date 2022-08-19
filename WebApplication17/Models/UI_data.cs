using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class Class1
    {
        public DateTime Release_Date { get; set; }
        public string Producer { get; set; }
        public List<string> Actors { get; set; }
        public string Movie_Name { get; set; }


        public Class1(string Movie_Name,DateTime Release_Date,string Producer,List<string> Actors)
        {
            this.Movie_Name = Movie_Name;
            this.Release_Date = Release_Date;
            this.Producer = Producer;
            this.Actors = Actors;
        }

        public Class1()
        {
        }
    }
}