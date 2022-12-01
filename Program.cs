﻿int level = 1;
int Health = 20;
bool dungeonKey = false;
bool searchDungChest = true;

(string Name, int Power) bareHands = ("Bare Hands", 1);
(string Name, int Power) extrodinaryStick = ("Extrordinary stick", 5);
(string Name, int Power) Sword = ("Sword", 3);
(string Name, int Power) strongSword = ("Strong Sword", 5);
(string Name, int Power) stinkySword = ("Stink Sword", 6);
(string Name, int Power) superSword = ("Super Sword", 10);
(string Name, int Power) cowSword = ("Cow Sword", 30);
(string Name, int Power) cursedSword = ("Cursed Sword", 50);
(string Name, int Power) CurrentWeapon = bareHands;
List<(string, int)> WeaponsInPossession = new List<(string, int)>();
WeaponsInPossession.Add(bareHands);

int wisdom = 1;
int LifePotion = 0;
int Attack = CurrentWeapon.Power + level;

int Coins = 0;
bool searchGobChest = true;
int MaxLife = 20;
int Experience = 0;
int xpNeeded = 0;
xpNeeded = xpNeeded + (100 * level);



//Logans Equiping program
//void Equip(){

    WeaponsInPossession.Add(Sword);
    string AskQuestion(string question)
    {
        string answer = "";
        Console.WriteLine(question);
        answer = Console.ReadLine();
        return answer;
    }

    void displayWeaponsEquiped()
    {
        int count = 1;
        TextTyping("Weapons:");
        foreach ((string equiped, int t) in WeaponsInPossession)
        {
            TextTyping($"{count}: {equiped} ({t} Power)");
            count++;
        }
    }


    void changeWeaponsEquiped()
    {
        bool choosing = true;
        while (choosing)
        {
            displayWeaponsEquiped();
            String choice = AskQuestion("What sword would you like to equip?");
            var swaptop = CurrentWeapon;
            CurrentWeapon = WeaponsInPossession[int.Parse(choice) - 1];
            WeaponsInPossession[int.Parse(choice) - 1] = swaptop;
            string done;
            TextTyping($"You are using the {CurrentWeapon.Name} \nAre you ready?<yes or no>");
        
            
            done = Console.ReadLine();
            if (done == "yes")
            {
                choosing = false;
            }

        }
    }


    //end of the equiping program
//}

/*void Equiping()
{
    TextTyping("Here are your weapons");
    foreach ( in WeaponsInPossession)
    {
        TextTyping($"{swords}");
    }
}*/


void Village()
{
    TextTyping("You step into the village!! Because of the Evil Cow Man, the Village has been deserted.\nYou see the door to your house, as well as the shop that you know and love, and a burning skeleton\nThere is also a path to the East that will let you exit the village\nWhat would you like to do?");
    Console.ReadKey();
    bool inVillage = true;
    while (inVillage == true)
    {
        TextTyping("<house, shop, skeleton, east, search, inventory>");
        string? response = Console.ReadLine();
        if (response == "house")
        {
            TextTyping("You make your way to you house and open the door");
            Console.ReadKey();
            inVillage = false;
            House();
        }


        if (response == "shop")
        {
            TextTyping("You make your way to the deserted shop and open the door.");
            Console.ReadKey();
            inVillage = false;
            Shop();
        }

        if (response == "east")
        {
            TextTyping("You make your way to the village gate, and go beyond.");
            Console.ReadKey();
            inVillage = false;
            Clearing1();
        }
        if (response== "skeleton"){
            skeleyTalk();
        }
        if (response == "search")
        {
            TextTyping("As You look around the Village, You see a Tree along the North, and the weird Village Cat.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("What would you like to search?");

            while (searching)
            {
                TextTyping("<tree or cat>");
                string search = Console.ReadLine();
                if (search == "tree")
                {
                    TextTyping("You begin searching the tree");
                    Console.ReadKey();
                    CommonSearching();
                    searching = false;
                }
                else if (search == "cat")
                {
                    TextTyping("You slowly approach the cat");
                    Console.ReadKey();
                    RareSearching();
                    searching = false;
                }

                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }

        if (response == "inventory")
        {
            Inventory();
        }

        else
        {
            TextTyping("What would you like to do?");
            Console.ReadKey();
        }


    }
}

void Shop()
{
    TextTyping("You have entered the Shop!");
    Console.ReadKey();
    TextTyping("The shop has been stripped of it's wares since the time the Evil Cow Man has come, but it's still in good condition");
    TextTyping("There is the door to exit into the village, but it might be worth while to take a look around.");
    bool inShop = true;
    while (inShop == true)
    {
        TextTyping("<exit, search, or inventory>");
        string? response = Console.ReadLine();
        if (response == "exit")
        {
            TextTyping("You make your way to the door and exit to the village");
            inShop = false;
            Village();

        }

        if (response == "search")
        {
            TextTyping("As You look around the shop, You notice the counter, as well as the shelves");
            Console.ReadKey();
            bool searching = true;
            TextTyping("What would you like to search?");

            while (searching)
            {
                TextTyping("<counter or shelves>");
                string search = Console.ReadLine();
                if (search == "counter")
                {
                    TextTyping("You walk to the counter and start searching around");
                    Console.ReadKey();
                    TextTyping("As you are looking at the counter, you notice a suspicious piece of wood");
                    TextTyping("Would you like to pull it?\n<yes or no>");
                    bool thinking = true;
                    while (thinking)
                    {
                        string think = Console.ReadLine();
                        if (think == "yes")
                        {
                            TextTyping("You pull the lever and you hear the sound of scraping and a secret door opens");
                            TextTyping("You enter the passageway");
                            thinking = false;
                            Console.ReadKey();
                            CowField();

                        }
                        else if (think == "no")
                        {
                            TextTyping("Whelp, there isn't anything else here, so good luck");
                            thinking = false;
                        }
                        else
                        {
                            TextTyping("Sorry, but I can't read that");
                        }
                    }
                    searching = false;
                }
                else if (search == "shelves")
                {
                    TextTyping("You start looking through the barren shelves");
                    Console.ReadKey();
                    UncommonSearching();
                    searching = false;
                }

                else
                {
                    TextTyping("You can't search there!");
                }

            }
        }

        if (response == "inventory")
        {
            Inventory();
            TextTyping("still working on it");
            Console.ReadKey();
        }

        else
        {
            TextTyping("What would you like to do?");
            Console.ReadKey();
        }


    }
}

void House()
{
    TextTyping("You are in your house! what would you like to do?");
    TextTyping("There is a door that you can take, or you can take a look around your house, or look in your backpack.");
    bool inHouse = true;
    while (inHouse == true)
    {
        TextTyping("<Door, search, inventory>");
        string? response = Console.ReadLine();
        if (response == "door")
        {
            TextTyping("You move to the door and turn the handle, stepping out into a bright new world.");
            Console.ReadKey();
            inHouse = false;
            Village();

        }

        if (response == "search")
        {
            TextTyping("As You look around your house, You see a chest on the northern wall, as well as the bed that you woke up in to your left.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("What would you like to search?");

            while (searching)
            {
                TextTyping("<bed or chest>");
                string search = Console.ReadLine();
                if (search == "bed")
                {
                    TextTyping("You look under the bed");
                    Console.ReadKey();
                    CommonSearching();
                    searching = false;
                    Console.ReadKey();
                    break;
                }
                else if (search == "chest")
                {
                    TextTyping("You slowly open the chest");
                    Console.ReadKey();
                    TextTyping("You have found the Sword!!");
                    WeaponsInPossession.Add(Sword);
                    searching = false;
                }

                else
                {
                    TextTyping("You can't search there");
                }

            }
        }

        if (response == "inventory")
        {
            Inventory();
        }

        else
        {


            TextTyping("What would you like to do?");
            Console.ReadKey();
        }


    }
}

void CowField()
{
    TextTyping("As you exit the passageway, you are stunned to see a field full of cows just minding their own business.");
    TextTyping("You hate cows");
    TextTyping("There isn't much to do here other then fume in rage, you should return to the shop.");
    bool inField = true;
    while (inField)
    {
        TextTyping("<Leave or inventory>");
        string? response = Console.ReadLine();
        if (response == "leave")
        {
            TextTyping("You turn around and head back to the shop");
            inField = false;
            Shop();
        }

        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {
            TextTyping("What would you like to do?");
            Console.ReadKey();
        }

    }
}

void Clearing1()
{
    TextTyping("You take the path and enter the clearing!\nAs you you look around, you see a path heading west, a path heading south, and a path heading east. You can also search the area ");
    bool inClearing1 = true;
    while (inClearing1)
    {
        TextTyping("<east, west, south, search, or inventory>");
        string? response = Console.ReadLine();

        if (response == "east")
        {
            TextTyping("You start heading east");
            inClearing1 = false;
            Console.ReadKey();
            SusClearing();
        }

        if (response == "west")
        {
            TextTyping("You start heading towards the Village!");
            inClearing1 = false;
            Console.ReadKey();
            Village();
        }

        if (response == "south")
        {
            TextTyping("You start heading South");
            inClearing1 = false;
            Console.ReadKey();
            BarrenClearing();
        }

        if (response == "search")
        {
            TextTyping("As You look around the clearing, you see a few trees, and some rocks");
            Console.ReadKey();
            bool searching = true;
            TextTyping("What would you like to search?");

            while (searching)
            {
                TextTyping("<trees or rocks>");
                string search = Console.ReadLine();
                if (search == "trees")
                {
                    TextTyping("You search the trees");
                    Console.ReadKey();
                    UncommonSearching();
                    searching = false;
                }
                else if (search == "rocks")
                {
                    TextTyping("You search the rocks");
                    Console.ReadKey();
                    CommonSearching();
                    searching = false;
                }

                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }

        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {

            TextTyping("What would you like to do?");
            Console.ReadKey();
        }
    }
}

void SusClearing()
{
    TextTyping("As you enter this clearing, you you notice it looks awfully suspicious.");
    TextTyping("You notice that it seems the trail ends here, but it is a sus clearing.");
    bool inSusClearing = true;
    while (inSusClearing == true)
    {
        TextTyping("<west, search, or inventory>");
        string? response = Console.ReadLine();

        if (response == "west")
        {
            TextTyping("You start heading back the way you came.");
            inSusClearing = false;
            Clearing1();

        }

        if (response == "search")
        {
            TextTyping("As You look around the Sus Clearing, you see a discover a sus chest.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("Would you like to open the chest?");

            while (searching)
            {
                TextTyping("<yes or no>");
                string search = Console.ReadLine();
                if (search == "yes")
                {
                    TextTyping("You open the chest!!");
                    Console.ReadKey();
                    CursedSearching();
                    searching = false;
                }
                else if (search == "no")
                {
                    TextTyping("You don't open the chest");
                    Console.ReadKey();
                    TextTyping("You don't know what you're missing.");
                    searching = false;
                }

                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }


        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {

            TextTyping("What would you like to do?");
            Console.ReadKey();
        }
    }
}

void BarrenClearing()
{
    TextTyping("You have entered the Barren clearing!");
    TextTyping("You look around you and see that this place is barren, but there are 4 places that you can go,\nNorth, South, East, and West");
    bool inClearing2 = true;
    while (inClearing2 == true)
    {
        TextTyping("What would you like to do?\n<north, south, east, west, search, or inventory>");
        string? response = Console.ReadLine();
        if (response == "north")
        {
            TextTyping("You start heading on the Northern Path!");
            inClearing2 = false;
            Clearing1();

        }
        if (response == "south")
        {
            TextTyping("You start walking on the Southern Path!");
            inClearing2 = false;
            SouthernClearing();

        }

        if (response == "west")
        {
            TextTyping("You start walking on the Western Path!");
            inClearing2 = false;
            WonderfulClearing();

        }

        if (response == "east")
        {
            TextTyping("You start Heading to the East!");
            inClearing2 = false;
            Clearing6();

        }

        if (response == "search")
        {
            TextTyping("As You look around this area, you see about nothing except a lumpy rock.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("What would you like to search?");

            while (searching)
            {
                TextTyping("<NOTHING, nothing, rock>");
                string search = Console.ReadLine();
                if (search == "NOTHING")
                {
                    TextTyping("You search the NOTHING!!");
                    Console.ReadKey();
                    UncommonSearching();
                    searching = false;
                }
                else if (search == "nothing")
                {
                    TextTyping("You search the nothing!!");
                    Console.ReadKey();
                    CommonSearching();
                    searching = false;
                }
                else if (search=="rock"){
                    gobGob();
                }
                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }

        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {
            Console.WriteLine();
        }

    }
}

void WonderfulClearing()
{
    TextTyping("You have entered this Wonderful Clearing!!");
    TextTyping("There are so many things to do at this clearing that it's impossible to do them all, so we narrowed it down for ya.\nThere is a path to the east, a path to the west, a path to the North, and a scary path to the south.\nOr You can look around this wonderful clearing");
    bool inClearing3 = true;
    TextTyping("What would you like to do today?");
    while (inClearing3 == true)
    {
        TextTyping("<east, west, north, south, search, inventory");
        string? response = Console.ReadLine();

        if (response == "west")
        {
            TextTyping("You start heading down the Western Path.");
            inClearing3 = false;
            Clearing4();

        }

        if (response == "east")
        {
            TextTyping("You start Going Eaeasst.");
            inClearing3 = false;
            BarrenClearing();

        }

        if (response == "north")
        {
            TextTyping("You start going to the North.");
            inClearing3 = false;
            CowLookOut();

        }

        if (response == "south")
        {
            TextTyping("You start heading South!!");
            inClearing3 = false;
            dungeonEntrance();
        }

        if (response == "search")
        {
            TextTyping("As You look around this wonderful clearing, you are dazzled by how wonderful it is. Everyting is soo wonderful that you feel that if you search it, it will ruin it.... that is, everythhing except that rock over there, it's just too ugly for this wonderful clearing.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("Would you like to search the Rock?");

            while (searching)
            {
                TextTyping("<yes or no>");
                string search = Console.ReadLine();
                if (search == "yes")
                {
                    TextTyping("You search the Rock!!");
                    Console.ReadKey();
                    CursedSearching();
                    searching = false;
                }
                else if (search == "no")
                {
                    TextTyping("Coward, You don't search the rock");
                    Console.ReadKey();
                    TextTyping("You don't know what you're missing.");
                    searching = false;
                }

                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }

        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {

            TextTyping("What would you like to do?");
            Console.ReadKey();
        }
    }
}

void dungeonEntrance(){
    TextTyping("You walk down the scary path, and you come face to face with the evil cow mans lair.\n the smell of grass and manure lingers in the air.\n You can feel your wifes presence, you must enter the dungeon to save her");
    TextTyping("You look around the area, there are a few thing laying around but all you can see is a large door");
    bool running = true;
    while (running){
    TextTyping("what would you like to do?\n <Door, Run, search, inventory>");
    string choice = Console.ReadLine();
    if (choice=="door"){
    //bean
    TextTyping("You walk towards the door, you are filled with determination\n As you walk to the door you notice a small key hole");
    if (dungeonKey==true){
        TextTyping("");
    }
    }
    if (choice=="run"){
        TextTyping("You run away from the door screaming in fear");
        running= false;
        WonderfulClearing();
    }
    if (choice == "search"){
        TextTyping("You look around for something to search.\n you see a rock and a milk jug.");
        TextTyping("what would you like to search\n <rock, jug>");
        choice = Console.ReadLine();
        if (choice == "rock")
        TextTyping("yup that is a rock");
        if (choice == "jug")
        TextTyping("you approach the jug\nits just an empty milk jug");

    }
    if (choice=="inventory")
    Inventory();
    }
}

void Clearing4()
{
    TextTyping("You have entered the normal Clearing!!");
    TextTyping("It's a pretty normal clearing, with  not much to do, but there is still stuff to do. Maybe it would be worth while to take a look around.");
    bool inClearing4 = true;
    TextTyping("What would you like to do today?");
    while (inClearing4)
    {
        TextTyping("<east, south, search, inventory");
        string? response = Console.ReadLine();
        if (response == "east")
        {
            TextTyping("You start heading east");
            inClearing4 = false;
            WonderfulClearing();
        }

        if (response == "south")
        {
            TextTyping("You start heading south!");
            inClearing4 = false;
            AngryClearing();
        }
        if (response == "search")
        {
            TextTyping("You have decided to Search this pretty normal clearing. As you take a look around, you see that there is not much to search except the grass itself. there area few pebbles here and there too, but you don't think that there could be anything hiding there");
            Console.ReadKey();
            bool searching = true;
            TextTyping("Would you like to search the grass or the pebbles?");

            while (searching)
            {
                TextTyping("<grass or pebbles>");
                string search = Console.ReadLine();
                if (search == "grass")
                {
                    TextTyping("You search the grass!!");
                    Console.ReadKey();
                    searching = false;
                    CommonSearching();
                }
                else if (search == "pebbles")
                {
                    TextTyping("You search the pebbles!!");
                    Console.ReadKey();
                    searching = false;
                    RareSearching();
                }

                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }


        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {
            TextTyping("What would you like to do?");
            Console.ReadKey();
        }
    }
}

void AngryClearing()
{
    TextTyping("You have entered this clearing, and as you do, you feel a rage come over you. You are mad.");
    TextTyping("You see a path going back to the north, but that's about it.");
    bool inClearing = true;
    while (inClearing)
    {
        TextTyping("<north, search, inventory>");
        string? response = Console.ReadLine();
        if (response == "north")
        {
            TextTyping("You start heading back North!");
            inClearing = false;
            Clearing4();
        }

        if (response == "search")
        {
            TextTyping("You have decided to Search this angry clearing. As you take a look around, you see that there is a chest.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("Would you like to open the chest?");

            while (searching)
            {
                TextTyping("<yes or no>");
                string search = Console.ReadLine();
                if (search == "yes")
                {
                    TextTyping("You slowly open the chest!!");
                    Console.ReadKey();
                    searching = false;
                    CursedSearching();
                }
                else if (search == "no")
                {
                    TextTyping("You don't open the chest.");
                    TextTyping("Are you Scared");
                    Console.ReadKey();
                    TextTyping("Whelp, good luck!");
                    searching = false;
                }


                else
                {
                    TextTyping("You can't search there!");
                }
            }
        }

        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {
            TextTyping("What would you like to do?");
            Console.ReadKey();
        }

    }
}

void CowLookOut()
{
    TextTyping("You have climbed a hill following the path, and you find yourself overlooking a field of Cows.");
    TextTyping("To your dismay, that's about all that there is to do here");
    bool inCowLookout = true;
    while (inCowLookout)
    {
        TextTyping("<south or inventory>");
        string? response = Console.ReadLine();
        if (response == "south")
        {
            TextTyping("You start heading back the way that you came, away from thw cows");
            inCowLookout = false;
            WonderfulClearing();
        }

        if (response == "inventory")
        {
            Inventory();
            Console.ReadKey();
        }

        else
        {
            TextTyping("What would you like to do?");
            Console.ReadKey();
        }
    }
}

void SouthernClearing()
{
    TextTyping("You have entered the southern clearing!");
    TextTyping("As you look around, you see that this is the end of the trail here, but maybe you should take a look around.");
    bool inSouthClear = true;
    TextTyping("What would you like to do?");
    while (inSouthClear)
    {
        TextTyping("<north, search, or inventory>");
        string? response = Console.ReadLine();
        if (response == "north")
        {
            TextTyping("You start heading North!");
            inSouthClear = false;
            BarrenClearing();
        }

        if (response == "search")
        {
            TextTyping("As you look around the clearing, there seems to be a chest that can be opened, as well as some trees around.");
            bool searching = true;
            while (searching)
            {
                TextTyping("<chest or trees>");
                string answer = Console.ReadLine();

                if (answer == "chest" && searchDungChest == false)
                {
                    TextTyping("You have alread searched there!!\nTough Luck Mate");
                    Console.ReadKey();
                    searching = false;
                }

                if (answer == "chest" && searchDungChest == true)
                {
                    TextTyping("You make your way over to the chest and open it!!");
                    searching = false;
                    searchDungChest = false;
                    dungeonKey = true;
                    TextTyping("You have found a key!!!\n it is very intricate, and is probably important.");
                }

                if (answer == "trees")
                {
                    TextTyping("You begin to make your way to the trees!!");
                    CommonSearching();
                    searching = false;
                }

                else
                {
                    Console.WriteLine();
                }
            }
        }

        if (response == "inventory")
        {
            Inventory();
        }

        else
        {
            TextTyping("What would you like to do?");
        }
    }
}

void Clearing6()
{
    TextTyping("You keep going and reach the top of a hill, it was a harsh climb !!");
    Console.ReadKey();
    TextTyping("As you take a quick look around, it seems that the path goes south, as well as west. You can also search around a bit if you'd like.");
    bool inClearing6 = true;
    TextTyping("What would you like to do?");
    while (inClearing6)
    {
        TextTyping("<south, west, search, or inventory");
        string? response = Console.ReadLine();
        if (response == "south")
        {
            TextTyping("You begin heading south!!");
            inClearing6 = false;
            GoblinClearing();
        }
        if (response == "west")
        {
            TextTyping("You begin heading west!!");
            inClearing6 = false;
            BarrenClearing();
        }

        if (response == "search")
        {
            TextTyping("As you look around the clearing, there isn't much here, but you do see a pile of rocks.");
            bool searching = true;
            TextTyping("Would you like to search the rocks?");
            while (searching)
            {
                TextTyping("<yes or no>");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    TextTyping("You search the rocks!!");
                    searching = false;
                    CommonSearching();
                }

                if (answer == "no")
                {
                    TextTyping("You don't search the rocks!!");
                    searching = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        if (response == "inventory")
        {
            Inventory();
        }

        else
        {
            TextTyping("What would you like to do?");
        }
    }
}

void GoblinClearing()
{
    TextTyping("You enter this clearing and see that there looks like there is a camp full of Goblins on the other side of this area. ");
    TextTyping("You see that there is also a path going to the North, but you should get ready for a battle.");
    bool inGobClear = true;
    while (inGobClear)
    {
        TextTyping("<north, fight, or inventory>");
        string? response = Console.ReadLine();
        if (response == "north")
        {
            TextTyping("You start heading North!!");
            inGobClear = false;
            Clearing6();
        }

        if (response == "fight")
        {
            TextTyping("You head over to the Goblin Camp, weapon drawn.");
            inGobClear = false;
            GoblinCamp();
        }

        if (response == "inventory")
        {
            Inventory();
        }
        else
        {
            TextTyping("What would you like to do??");
        }
    }
}

void GoblinCamp()
{
    TextTyping("You have entered the Camp!!");
    TextTyping("There seems to be only a few goblins Milling around, the rest must be on a hunting trip.");
    GoblinCombat();
    Console.ReadKey();
    TextTyping("You have defeated the Goblins, but more will be here shortly");
    TextTyping("There is the Path that heads North out of this clearing, but you should take a look around.");
    bool InGoblinCamp = true;
    while (InGoblinCamp)
    {
        TextTyping("<north, search, or inventory>");
        string? response = Console.ReadLine();
        if (response == "north")
        {
            TextTyping("You start heading to the North");
            Clearing6();
        }

        if (response == "search")
        {
            TextTyping("As you take a look around, you see that there is a chest, as well as the little huts that you may search.");
            bool searching = true;
            TextTyping("What would you like to search");

            while (searching)
            {
                TextTyping("<chest or huts>");

                string answer = Console.ReadLine();
                if (answer == "chest" && searchGobChest == false)
                {
                    TextTyping("You open the chest and find...");
                    Console.ReadKey();
                    TextTyping("NOTHING!!!");
                    searching = false;
                }
                if (answer == "chest" && searchGobChest == true)
                {
                    TextTyping("You open the chest and find...");
                    Console.ReadKey();
                    TextTyping("Some Goblin Armor!!!");
                    TextTyping("It looks a little grody, but armor is armor, and it is better then nothing");
                    searching = false;
                    searchGobChest = false;
                }
                if (answer == "huts")
                {
                    TextTyping("You start seraching the gross goblin Huts");
                    searching = false;
                    RareSearching();
                }
                else
                {
                    TextTyping("What would you like to search?");
                }
            }
        }
    }
}

void GoblinCombat()
{
    int speed = 1;
    int GobSpeed = 1;
    int GobDamage = 0;
    int PlayerDamage = 0;



    Random Number = new Random();
    int NumMonster = Number.Next(2, 4);
    int[] GoblinLife = new int[NumMonster];
    for (int y = 0; y < GoblinLife.Length; y++)
    {
        Random Life = new Random();
        int GobHealth = Life.Next(2, 6);
        GoblinLife[y] = GobHealth;
    }
    TextTyping($"{NumMonster} Goblins charge you!!");
    Rounds();

    void Rounds()
    {
        if (GoblinLife[0] <= 0 && GoblinLife[1] <= 0 && GoblinLife[2] <= 0)
        {
            TextTyping("You have defeated all of the goblins, Congratulations!");
            System.Environment.Exit(0);
        }
        if (Health <= 0)
        {
            TextTyping("You have died!!\nThank you for playing :)");
            System.Environment.Exit(0);

        }
        if (speed < GobSpeed)
        {
            PlayerTurn();
            GoblinTurn();
            Rounds();
        }
        if (speed > GobSpeed)
        {
            GoblinTurn();
            PlayerTurn();
            Rounds();
        }
        else
        {
            PlayerTurn();
            GoblinTurn();
            Rounds();
        }
    }

    void PlayerTurn()
    {
        Console.WriteLine("Player's Turn");
        TextTyping("What would you like to do?");
        Console.WriteLine("<attack, run>");
        string? response = Console.ReadLine();
        bool Responding = true;
        while (Responding)
        {
            if (response == "run")
                Running();
            Responding = false;
            if (response == "attack")
            {
                TextTyping("Which Goblin would you like to attack?");
                int x;
                for (x = 0; x < GoblinLife.Length; x++)
                {
                    if (GoblinLife[x] <= 0)
                        Console.WriteLine("Dead");
                    else
                        Console.WriteLine($"Goblin {x + 1}, {GoblinLife[x]} Life left ");
                }
                response = Console.ReadLine();
                int Y = int.Parse(response);
                for (int z = 0; z < GoblinLife.Length; z++)
                {
                    if (response == $"{z}")
                    {
                        Attacking();
                        GoblinLife[z] = GoblinLife[z] - PlayerDamage;
                        Console.WriteLine("");
                        Responding = false;
                    }

                    else if (Y > GoblinLife.Length)
                    {
                        TextTyping("You can't attack the tree");
                    }
                }
            }
            else
            {
                Console.WriteLine("I can't read that");
            }
        }
    }
    void GoblinTurn()
    {
        Console.WriteLine("Goblins Turn");
        GobDamage = 0;
        for (int x = 1; x <= NumMonster; x++)
        {
            Random DMG = new Random();
            int GobDamage1 = DMG.Next(1, 5);
            GobDamage = GobDamage1 + GobDamage;
        }
        GobSpeed = GobSpeed + 3;
        TextTyping($"You have taken {GobDamage} Damage!!");
        Console.ReadLine();
        Health = Health - GobDamage;
        Console.WriteLine($"You have {Health} Life left");
    }

    void Attacking()
    {
        Console.WriteLine("Which type of attack?");
        bool answering = true;
        while (answering == true)
        {
            Console.WriteLine("<heavy, medium, light>");
            string answer = Console.ReadLine();
            if (answer == "heavy")
            {
                TextTyping("You strike the goblin with a heavy attack!!");
                speed = speed + 5;
                PlayerDamage = Attack + 5;
                TextTyping($"{PlayerDamage} Dmg");
                answering = false;

            }
            if (answer == "light")
            {
                TextTyping("You strike the Goblin with a Light Attack");
                speed = speed + 1;
                PlayerDamage = Attack;
                Console.Write($"{PlayerDamage} Dmg");
                answering = false;
            }
            if (answer == "medium")
            {
                TextTyping("You strike the Goblin with a Medium Attack!");
                speed = speed + 2;
                PlayerDamage = Attack + 2;
                TextTyping($"{PlayerDamage} Dmg");
                answering = false;
            }
            else
            {
                Console.WriteLine("");
            }

        }

    }

    void Running()
    {
        TextTyping("You Start running away!! (You Coward)");
        if (speed < GobSpeed - 3)
        {
            TextTyping("You get away safely!!");
            Clearing6();
        }
        else
        {
            TextTyping("You couldn't get away!!");
        }
    }

}

void CommonSearching()
{
    Random search = new Random();
    int item = search.Next(0, 10);
    int searchScore = item + wisdom;
    if (searchScore >= 5 && searchScore <= 9)
    {
        Console.WriteLine(searchScore);
        TextTyping("You have found a Life Potion!!!");
        LifePotion++;
    }

    if (searchScore == 10)
    {
        TextTyping("You found an extrordinary stick! :)");
        WeaponsInPossession.Add(extrodinaryStick);

    }


    else if (searchScore >= 0 && searchScore <= 4)
    {
        TextTyping("You Found Nothing!!");
    }


}

void UncommonSearching()
{
    Random search = new Random();
    int item = search.Next(0, 20);
    int searchScore = item + wisdom;
    if (searchScore >= 5 && searchScore <= 9)
    {
        Console.WriteLine(searchScore);
        TextTyping("You have found a Life Potion!!!");
        LifePotion++;
    }

    if (searchScore == 10)
    {
        TextTyping("You found an extrordinary stick! :)");
    }


    else if (searchScore >= 0 && searchScore <= 4)
    {
        TextTyping("You Found Nothing!!");
    }


}

void RareSearching()
{
    Random search = new Random();
    int item = search.Next(0, 50);
    int searchScore = item + wisdom;
    if (searchScore >= 5 && searchScore <= 9)
    {
        Console.WriteLine(searchScore);
        TextTyping("You have found a Life Potion!!!");
        LifePotion++;
    }

    if (searchScore == 10)
    {
        TextTyping("You found a Super Sword! :)");
        WeaponsInPossession.Add(superSword);
    }


    else if (searchScore >= 0 && searchScore <= 4)
    {
        TextTyping("You Found Nothing!!");
    }


}

void CursedSearching()
{
    Random search = new Random();
    int item = search.Next(0, 10);
    int searchScore = item + wisdom;
    if (searchScore >= 5 && searchScore <= 9)
    {
        Console.WriteLine(searchScore);
        TextTyping("You have found the cursed apple!!!");
        LifePotion++;
    }

    if (searchScore == 10)
    {
        TextTyping("You found The Cursed Sword! :)");
        WeaponsInPossession.Add(cursedSword);
    }


    else if (searchScore >= 0 && searchScore <= 4)
    {
        TextTyping("You Found Nothing!!");
    }


}

void Inventory()
{
    TextTyping($"Life Potions: {LifePotion}");
    displayWeaponsEquiped();
     TextTyping("Would you like to change your weapon?\n<yes or no>");
    string? response = Console.ReadLine();
    if (response == "yes")
    {
        changeWeaponsEquiped();
    }
     else if (response == "no")
        TextTyping("Sounds Good");
    else
    {
        TextTyping("I'm sorry, I can't read that");
    }
    TextTyping("Would you like to see your stats?\n<yes or no>");
    response = Console.ReadLine();
    if (response == "yes")
    {
        TextTyping($"Attack: {Attack}");
        TextTyping($"Hit Points: {Health}/{MaxLife}");
        //TextTyping($"Experience Point: {Experience}/{xpNeeded}");
        TextTyping($"Weapon: {CurrentWeapon.Name}");
        Console.ReadLine();
        /*
        TextTyping("Would you like to change your weapon?\n<y or n>");
        response = Console.ReadLine();
        if (response == "y")
            //Equiping();
        if (response == "n")
            TextTyping("Okay, lets get a move on then.");
        else
        {
            TextTyping("Sorry, can't read that");
        }*/
    }
    else if (response == "no")
        TextTyping("Sounds Good");
    else
    {
        TextTyping("I'm sorry, I can't read that");
    }

}


void TextTyping(string Sentence)
{
    foreach (var character in Sentence)
    {
        Console.Write(character);
        Thread.Sleep(10);
    }
    Console.WriteLine();
        Console.Beep();


}

void skeleyTalk(){
    TextTyping("You walk toward the skeleton, hoping to hear his kind words");
    int skeRageMeter = 0;
    while (skeRageMeter!=3){
        TextTyping("(1) Hello! \n(2) How are the wife and kids? \n(3) Whats the afterlife like? \n(4) Welp, sleep well");
        int response = Int32.Parse(Console.ReadLine());
        switch (response){
            case 4:
            Village();
            break;
            default:
            TextTyping("...");
            skeRageMeter++;
            break;
        }
    }
    TextTyping("UGH DO YOU EVER QUIT! All I want is to peacfully rot in to nothing, BUT NOO THATS NOT POSSIBLE. Some good for nothing squire wants to know how my wife and kids are, there dead thanks for pouring salt onto that wound for me.");
    TextTyping("What do i have to do to get rid of you, i have nothing, im just a pile of bones! Hm..I got it! Here, its a cursed apple, I dont know what its used for but take it and get out of my sight!");
    // add cusrsed apple     

    }

void gobGob(){
    TextTyping("you approach the lumpy rock");
    TextTyping("It smells really bad, and seems to be breathing");
    TextTyping("what would you like to do?\n <run, touch>");
    string iguess = Console.ReadLine();
    if (iguess== "run"){
        TextTyping("you turn to run, but the rock stands up and looks towards you");
    }
    if (iguess == "touch"){
        TextTyping("you reach out to touch the rock, you are suprised to see that the rock... touched you first");
    }
    TextTyping("HI. ME AM ARE GOB GOB. WELCOM TO MY CLERING.");
    TextTyping("WOULD YOU LIK A LARD?/n (he holds out a bucket of lard, you politly push it back)");
    bool gobtalk = true;
    while (gobtalk){
        Console.WriteLine("(1) What are you?/n(2) Have you seen my wife?/n(3) why lard?/n(4) Gud buy??");
        int respond = int.Parse(Console.ReadLine());
        switch (respond){
            case 1:
            TextTyping("I am a GOB GOB.");
            break;
            case 2:
            TextTyping("yes");
            break;
            case 3:
            TextTyping(@"Lard has always been an important cooking and baking staple in cultures where pork is an important dietary item, with pig fat often being as valuable a product as pork.[6]

During the 19th century, lard was used similarly to butter in North America and many European nations.[7] Lard remained about as popular as butter in the early 20th century and was widely used as a substitute for butter during World War II. As a readily available by-product of modern pork production, lard had been cheaper than most vegetable oils, and it was common in many people's diet until the industrial revolution made vegetable oils more common and more affordable. Vegetable shortenings were developed in the early 1900s, which made it possible to use vegetable-based fats in baking and in other uses where solid fats were called for. Upton Sinclair's novel The Jungle, though fictional, portrayed men falling into rendering vats and being sold as lard, and it generated negative publicity.

By the late 20th century lard began to be considered less healthy than vegetable oils (such as olive and sunflower oil) because of its high content of saturated fatty acids and cholesterol. However, despite its reputation, lard has less saturated fat, more unsaturated fat and less cholesterol than an equal amount of butter by weight.[2] Unhydrogenated lard contains no transfats. It has also been regarded as a 'poverty food'.[6]

Many restaurants in the western nations have eliminated the use of lard in their kitchens because of the health-related dietary restrictions of many of their customers,[citation needed] and religious pork-based dietary restrictions such as Kashrut and Halal mean that some bakers substitute beef tallow for lard.[citation needed]

In the 1990s and early 2000s, however, chefs and bakers rediscovered lard's unique culinary values, leading to a partial rehabilitation of this fat among 'foodies'. Negative publicity about the transfat content of the partially hydrogenated vegetable oils in vegetable shortening has partially driven this trend. Chef and food writer Rick Bayless is a prominent proponent of the virtues of lard for certain types of cooking.[8][9][10][11]

It is also again becoming popular in the United Kingdom among aficionados of traditional British cuisine. This led to a 'lard crisis' in late 2004.[12][13]");
            break;
            case 4:
            TextTyping("*munch* by");
            break;
            default:
            TextTyping("*BELCH*");
            break;
        }

    }

}




Console.Clear();
TextTyping("Welcome to the Land of Spud!!\nYour Name is Jimbo, and your wife has been stolen!!!!\nYou must rescue her from the Evil Cow Man!!!!");
House();





