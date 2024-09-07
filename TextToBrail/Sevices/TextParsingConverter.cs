using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TextToBrail.Models;

namespace TextToBrail.Sevices
{
    static class TextParsingConverter
    {
        public static async Task<IEnumerable<Letter>> ConvertTextAsync(string text)
        {
            return await Task.Run(() =>
            {
                var convertedText = new List<Letter>();
                foreach (var letter in text)
                {
                    BrailDictionary.BrailLanguage.TryGetValue(letter, out var value);
                    var l = new Letter(value, letter);
                    if (l.Dots is null)
                    {
                        var res = MessageBox.Show($"Символ {letter} не найден. продолжить?","Внимание", MessageBoxButton.YesNo);
                        if (res is MessageBoxResult.No)
                        {
                            throw new Exception();
                        }
                    }
                    convertedText.Add(l);
                }
                return convertedText;
            }
            );
            
        }
    }
}
