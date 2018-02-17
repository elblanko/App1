using System;
using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class Product
    {
        //Data anotations []
        [Key]
        public int ID               { get; set; }
        public string Description   { get; set; }
        public decimal Price        { get; set; }        
        public float Stock          { get; set; }
        public DateTime LastBuy     { get; set; }
    }
}