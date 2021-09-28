using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Lecture
    {
        [Key]
        public int Ten { get; set; }
        public int GVGD { get; set; }
        public string SoTiet { get; set; }
    }
}