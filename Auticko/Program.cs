using Auticko;

bool cyklus = true;
AUTO auto = new AUTO();
while (cyklus == true)
{
    Console.WriteLine("Co chceš dělat se svím autíčkem?");
    Console.WriteLine("1.Natankovat\n2.Podívat se na stav paliva\n3.Jed\n4.Konec");
    int volba = Convert.ToInt32(Console.ReadLine());
    switch(volba)
    {
        case 1:
            auto.natankuj();
            break;
        case 2:
            auto.stav_paliva();
            break;
        case 3:
            auto.jed();
            break;
        case 4:
            cyklus = false;
            return;
    }
}