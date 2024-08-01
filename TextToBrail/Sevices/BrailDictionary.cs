using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToBrail.Sevices;
public class BrailDictionary
{
    public static Dictionary<char, short[]> BrailLanguage => brailLanguage;

    static Dictionary<char, short[]> brailLanguage = new Dictionary<char, short[]>()
    {
        //                  1 2 3 4 5 6
        { 'a', new short[]{ 1,0,0,0,0,0} },
        { 'b', new short[]{ 1,1,0,0,0,0} },
        { 'c', new short[]{ 1,0,0,1,0,0} },
        { 'd', new short[]{ 1,0,0,1,1,0} },
        { 'e', new short[]{ 1,0,0,0,1,0} },
        { 'f', new short[]{ 1,1,0,1,0,0} },
        { 'g', new short[]{ 1,1,0,1,1,0} },
        { 'h', new short[]{ 1,1,0,0,1,0} },
        { 'i', new short[]{ 0,1,0,1,0,0} },
        { 'j', new short[]{ 0,1,0,1,1,0} },
        { 'k', new short[]{ 1,0,1,0,0,0} },
        { 'l', new short[]{ 1,1,1,0,0,0} },
        { 'm', new short[]{ 1,0,1,1,0,0} },
        { 'n', new short[]{ 1,0,1,1,1,0} },
        { 'o', new short[]{ 1,0,1,0,1,0} },
        { 'p', new short[]{ 1,1,1,1,0,0} },
        { 'q', new short[]{ 1,1,1,1,1,0} },
        { 'r', new short[]{ 1,1,1,0,1,0} },
        { 's', new short[]{ 0,1,1,1,0,0} },
        { 't', new short[]{ 0,1,1,1,1,0} },
        { 'u', new short[]{ 1,0,1,0,0,1} },
        { 'v', new short[]{ 1,1,1,0,0,1} },
        { 'w', new short[]{ 0,1,0,1,1,1} },
        { 'x', new short[]{ 1,0,1,1,0,1} },
        { 'y', new short[]{ 1,0,1,1,1,1} },
        { 'z', new short[]{ 1,0,1,0,1,1} },
    };
}
