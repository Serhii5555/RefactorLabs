using System.Text;
using task5;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var editor = new TextEditor();
        var history = new History();

        editor.Write("Перша версія тексту.");
        history.Push(editor.Save());

        editor.Write("Друга версія тексту.");
        history.Push(editor.Save());

        editor.Write("Третя версія тексту.");
        Console.WriteLine("Поточний текст: " + editor.Read());

        editor.Restore(history.Pop());
        Console.WriteLine("Після першого Undo: " + editor.Read());

        editor.Restore(history.Pop());
        Console.WriteLine("Після другого Undo: " + editor.Read());
    }
}