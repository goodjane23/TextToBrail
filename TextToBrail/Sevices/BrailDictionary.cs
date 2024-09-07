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
        //----------------
        { 'а', new short[]{ 1,0,0,0,0,0 } },
        { 'б', new short[]{ 1,1,0,0,0,0 } },
        { 'в', new short[]{ 0,1,0,1,1,1 } },
        { 'г', new short[]{ 1,1,0,1,1,0 } },
        { 'д', new short[]{ 1,0,0,1,1,0 } },
        { 'е', new short[]{ 1,0,0,0,1,0 } },
        { 'ё', new short[]{ 1,0,0,0,0,1 } },
        { 'з', new short[]{ 0,1,0,1,1,0 } },
        { 'ж', new short[]{ 1,0,1,0,1,1 } },
        { 'и', new short[]{ 0,1,0,1,0,0 } },
        { 'й', new short[]{ 1,1,1,1,0,1 } },
        { 'к', new short[]{ 1,0,1,0,0,0 } },
        { 'л', new short[]{ 1,1,1,0,0,0 } },
        { 'м', new short[]{ 1,0,1,1,0,0 } },
        { 'н', new short[]{ 1,0,1,1,1,0 } },
        { 'о', new short[]{ 1,0,1,0,1,0 } },
        { 'п', new short[]{ 1,1,1,1,0,0 } },
        { 'р', new short[]{ 1,1,1,0,1,0 } },
        { 'с', new short[]{ 0,1,1,1,0,0 } },
        { 'т', new short[]{ 0,1,1,1,1,0 } },
        { 'у', new short[]{ 1,0,1,0,0,1 } },
        { 'ф', new short[]{ 1,1,0,1,0,0 } },
        { 'х', new short[]{ 1,1,0,0,1,1 } },
        { 'ц', new short[]{ 1,0,0,1,0,0 } },
        { 'ч', new short[]{ 1,1,1,1,1,0 } },
        { 'ш', new short[]{ 1,0,0,0,1,1 } },
        { 'щ', new short[]{ 1,0,1,1,0,1 } },
        { 'э', new short[]{ 0,1,0,1,0,1 } },
        { 'ю', new short[]{ 1,1,0,0,1,1 } },
        { 'я', new short[]{ 1,1,0,1,0,1 } },
        { 'ъ', new short[]{ 1,1,1,0,1,1 } },
        { 'ы', new short[]{ 0,1,1,1,0,1 } },
        { 'ь', new short[]{ 0,1,1,1,1,1 } },        
        { '.', new short[]{ 0,1,0,0,1,1 } },
        { ',', new short[]{ 0,1,0,0,0,0 } },
        { '!', new short[]{ 0,1,1,0,1,0 } },
        { '?', new short[]{ 0,1,0,0,0,1 } },
        { '-', new short[]{ 0,0,1,0,0,1 } },
        { ':', new short[]{ 0,1,0,0,1,0 } },
        { ' ', new short[]{ 0,0,0,0,0,0 } },
    };
}
