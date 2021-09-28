using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Employee
    {
        [Key]
        public int Ten { get; set; }
        public int Tuoi { get; set; }
        public string Phong { get; set; }
    }
}