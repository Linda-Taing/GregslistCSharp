using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregslistCSharp.Models;

public class House
{
    public int Id { get; set; }
    public int Room { get; set; }
    public double Bathroom { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    public string ImgUrl { get; set; }
    public string Color { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }

}
