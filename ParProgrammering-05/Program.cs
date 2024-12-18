/*
1) Harry Pottah🥳l33t haxx0r
Du skal starte med å lage en harrypotter character klasse med egenskaper som navn, house, inventory (ex wand eller pet)
Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle,rotte eller en katt. 
De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav. For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
Trylleformler: 
vingardium leviosa (får en fjær til å fly)
hokus pokus (fyrer av fyrverkerier)
*/
using ParProgrammering_05;

var person = new Wizard("Harry Potter", "Gryffindor");
var shop = new MagicShop(person);

while (true)
{
    Console.WriteLine(
        $"[1] Wizzard info\n" +
        $"[2] Go to Magic store\n" +
        $"[3] Cast a spell\n" +
        $"[4] Create a new Wizzard\n" +
        $"[5] Quit\n");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            person.WizardInfo();
            break;
        case "2":
            shop.Shop();
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
    }
}