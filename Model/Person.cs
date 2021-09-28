using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Person
    {
        [Key]
        public int Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
    }
}