// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Source source = new Source("None were with Him","url");
// Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holland","Because Jesus.....",source);
// Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();
quoteboard.AddQuote(holland);
quoteboard.FindQuotesByAuthor("holland");

Menu _menu = new Menu(quoteboard);
_menu.Display();