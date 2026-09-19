using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entite
{
    public class Employe 
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public int Age { get; set; }
        public string Postion  { get; set; }

        public virtual Conpany Conpanys { get; set; };
    }
}
