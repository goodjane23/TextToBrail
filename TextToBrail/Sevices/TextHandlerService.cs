using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToBrail.Sevices;
public class TextHandlerService
{
    private static TextHandlerService instance;

    public static TextHandlerService GetInstance()
    {
        if (instance == null)
            instance = new TextHandlerService();
        return instance;
    }

    private static string text;
    public delegate void TextHandler(string text);
    public static event TextHandler? Notify;
    public static string NewText
    {
        get => text;
        set { text = value; Notify?.Invoke(text); }
    }
}
