global using projekt_duben123;


Console.WriteLine("Generátor náhodných spellů");

List<Class2> seznamSpellu = new List<Class2>();
Class1 pomocneMetody = new Class1();
Class2 Class2 = new Class2();

string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("txt/spelltypes.txt");



while (true)
{
    Console.WriteLine("1. vygenerovat nový spell a přidat do Spellbooku");
    Console.WriteLine("2. zobrazit Spellbook");
    Console.WriteLine("3. smazat poslední záznam ve Spellbooku");
    Console.WriteLine("4. smazat celý Spellbook");
    Console.WriteLine("*. ukončit aplikaci");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Class2 novySpell = new Class2();
        novySpell.Name = pomocneMetody.VygenerujSpellname(poleForma, poleTypy);
        novySpell.ManaCost = pomocneMetody.VygenerujCislo(100);

        seznamSpellu.Add(novySpell);

        Console.Clear();
    }
    else if (input == "2")
    {
        foreach (var spell in seznamSpellu)
        {
            Console.WriteLine($"Spell: {spell.Name}    Mana: {spell.ManaCost}");

        }
    }
    else if (input == "3")
    {
        int indexPosledniho = seznamSpellu.Count - 1;

        Class2 posledni = seznamSpellu[indexPosledniho];
        seznamSpellu.Remove(posledni);

        Console.Clear();
    }
    else if (input == "4")
    {
        seznamSpellu.Clear();

        Console.Clear();
    }
    else if (input == "*")
    {
        break;
    }
}