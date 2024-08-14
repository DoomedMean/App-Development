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
        public double Price {  get; set; } = 0;
        public string Shop { get; set; } = "-";        
    }
}
