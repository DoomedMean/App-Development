using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.Graphics.Printing;

namespace App.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; } = 1.9f;
        public string Price {  get; set; } = "-";
        public string Shop { get; set; } = "-";
        public string ImagePath { get; set; } = "Not Available";
    }
}
