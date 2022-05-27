using ProniaWeb.Models;
using System.Collections.Generic;

namespace ProniaWeb.HomeVM
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
