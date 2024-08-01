using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToBrail.Models;
public class Letter
{
    public short[] Dots { get; }

    public Letter(short[] dots)
    {
        Dots = dots;
    }
}
