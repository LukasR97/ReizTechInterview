using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizInterview.KasNors
{
    internal class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Item(int id, string title)
        {
            Id = id;
            Title = title;  
        }
    }
}
