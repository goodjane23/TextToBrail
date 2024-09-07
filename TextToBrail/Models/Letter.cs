using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToBrail.Models;
public class Letter
{
    public string  Symbol { get; set; }
    public short[] Dots { get; }

    public Letter(short[] dots, char symbol)
    {
        Dots = dots;
        Symbol = symbol.ToString();
    }
}
