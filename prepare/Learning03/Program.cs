using System;

class Program
{
    static void Main(string[] args)
    {
        Player neymar = new Player("Neymar jr.", 10, "Forward");
        Player kobe = new Player("Kobe Bryant", 24);
        kobe.SetPosition("Shooting Guard");
       
       Console.WriteLine(kobe.Display());
       Team awesomeSauce = new Team("Awesome Sauce");
       awesomeSauce.AddPlayer(kobe);
       awesomeSauce.AddPlayer(neymar);
        awesomeSauce.AddLoss();
       awesomeSauce.AddWin();
       awesomeSauce.DisplayRoster();

    }
}