using ParProgrammering_05;

var person = new Wizard("Harry Potter", "Gryffindor");
var shop = new MagicShop(person);

while (true)
{
    Console.Clear();
    Console.WriteLine(
        $"[1] Wizard info\n" +
        $"[2] Go to Magic store\n" +
        $"[3] Cast a spell\n" +
        $"[4] Create a new Wizard\n" +
        $"[5] Quit\n");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Clear();
            person.WizardInfo();
            break;
        case "2":
            Console.Clear();
            shop.Shop();
            break;
        case "3":
            Console.Clear();
            CastSpell.Spell();
            break;
        case "4":
            Console.Clear();
            person.CreateWizard(person);
            break;
        case "5":
            Environment.Exit(0);
            break;
    }
}