int level = 1;
int Health = 50;
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
    string? answer = "";
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
        string? done;
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
        if (response == "skeleton")
        {
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
                string? search = Console.ReadLine();
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
                string? search = Console.ReadLine();
                if (search == "counter")
                {
                    TextTyping("You walk to the counter and start searching around");
                    Console.ReadKey();
                    TextTyping("As you are looking at the counter, you notice a suspicious piece of wood");
                    TextTyping("Would you like to pull it?\n<yes or no>");
                    bool thinking = true;
                    while (thinking)
                    {
                        string? think = Console.ReadLine();
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
                string? search = Console.ReadLine();
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
                string? search = Console.ReadLine();
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
                string? search = Console.ReadLine();
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
            TextTyping("As You look around this area, you see about nothing.");
            Console.ReadKey();
            bool searching = true;
            TextTyping("What would you like to search?");

            while (searching)
            {
                TextTyping("<NOTHING or nothing>");
                string? search = Console.ReadLine();
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
                string? search = Console.ReadLine();
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

void dungeonEntrance()
{
    TextTyping("You walk down the scary path, and you come face to face with the evil cow mans lair.\n the smell of grass and manure lingers in the air.\n You can feel your wifes presence, you must enter the dungeon to save her");
    TextTyping("You look around the area, there are a few thing laying around but all you can see is a large door");
    bool running = true;
    while (running)
    {
        TextTyping("what would you like to do?\n <Door, Run, search, inventory>");
        string? choice = Console.ReadLine();
        if (choice == "door")
        {
            //bean
            TextTyping("You walk towards the door, you are filled with determination\n As you walk to the door you notice a small key hole");
            if (dungeonKey == true)
            {
                TextTyping("");
            }
        }
        if (choice == "run")
        {
            TextTyping("You run away from the door screaming in fear");
            running = false;
            WonderfulClearing();
        }
        if (choice == "search")
        {
            TextTyping("You look around for something to search.\n you see a rock and a milk jug.");
            TextTyping("what would you like to search\n <rock, jug>");
            choice = Console.ReadLine();
            if (choice == "rock")
                TextTyping("yup that is a rock");
            if (choice == "jug")
                TextTyping("you approach the jug\nits just an empty milk jug");

        }
        if (choice == "inventory")
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
                string? search = Console.ReadLine();
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
                string? search = Console.ReadLine();
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
                string? answer = Console.ReadLine();

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
                string? answer = Console.ReadLine();

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
    GoblinCombat();
    TextTyping("You have defeated all of the goblins!!");
    TextTyping("You took care of the goblins milling around, but the rest must be on a hunting trip.");
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

                string? answer = Console.ReadLine();
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
                    TextTyping("a stinky sword!!!");
                    TextTyping("It looks a little grody, but a sword is a sword, and it is better then nothing");
                    WeaponsInPossession.Add(stinkySword);
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
    List<int> GobLife = new List<int>();
    Random Number = new Random();
    int NumMonster = Number.Next(1, 6);
    int[] GoblinLife = new int[NumMonster];
    //Giving the Goblins Life
    for (int y = 0; y < GoblinLife.Length; y++)
    {
        Random Life = new Random();
        int GobHealth = Life.Next(2, 6);
        GoblinLife[y] = GobHealth;
        GobLife.Add(GoblinLife[y]);
    }
    Console.WriteLine($"You enter the Village and see {NumMonster} Goblins!!");
    Rounds();

    void Rounds()
    {
        if (GobLife.Count == 0)
        {
            TextTyping("You have defeated all of the goblins, Congratulations!");
            GoblinCamp();
            
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
        TextTyping("Player's Turn");
        TextTyping("What would you like to do?");
        bool Responding = true;
        while (Responding)
        {
            TextTyping("<attack, run>");
            string? response = Console.ReadLine();
            if (response == "run")
            {
                Running();
                Responding = false;
            }
            if (response == "attack")
            {
                TextTyping("Which Goblin would you like to attack?");
                int x;
                //Displaying all of the goblins/Monsters
                for (x = 0; x < GobLife.Count; x++)
                {
                    if (GobLife[x] <= 0)
                    TextTyping("Dead");
                    else
                        TextTyping($"Goblin {x + 1}, {GobLife[x]} Life left ");
                }
                var Y = Console.ReadLine();
                int GobPicked = Convert.ToInt32(Y);


                if (GobPicked > 0 && GobPicked < GobLife.Count + 1)
                {

                    if (GobPicked <= GobLife.Count && GobPicked >= 0)
                    {
                        TextTyping("Which type of attack?");
                        bool answering = true;


                        while (answering == true)
                        {
                            TextTyping("<heavy, medium, light>");
                            string? answer = Console.ReadLine();
                            if (answer == "heavy")
                            {
                                TextTyping("You strike the goblin with a heavy attack!!");
                                speed = speed + 5;
                                PlayerDamage = Attack + 5;
                                TextTyping($"{PlayerDamage} Dmg {speed} Spd");
                                answering = false;

                            }
                            if (answer == "light")
                            {
                                TextTyping("You strike the Goblin with a Light Attack");
                                speed = speed + 1;
                                PlayerDamage = Attack;
                                TextTyping($"{PlayerDamage} Dmg {speed} Spd");
                                answering = false;
                            }
                            if (answer == "medium")
                            {
                                TextTyping("You strike the Goblin with a Medium Attack!");
                                speed = speed + 2;
                                PlayerDamage = Attack + 2;
                                TextTyping($"{PlayerDamage} Dmg {speed} Spd");
                                answering = false;
                            }
                            else
                            {
                                TextTyping("I can't read that.");
                            }

                        }
                        GobLife[GobPicked] = GobLife[GobPicked] - PlayerDamage;
                        if (GobLife[GobPicked] <= 0)
                        {
                            TextTyping("You have killed a goblin!!");
                            GobLife.Remove(GobPicked);
                        }
                        if (GobLife[GobPicked] > 0)
                        {
                            TextTyping("The Goblin shudders from the strength of your blow, but is still standing");
                        }

                    }
                }


                else
                {
                    Console.WriteLine("You smack the tree really hard.");
                    Console.ReadKey();
                }

                Responding = false;

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
        for (int x = 0; x < GobLife.Count; x++)
        {
            if (GobLife[x] <= 0)
            {
                Console.Write("");
            }
            else
            {
                Random DMG = new Random();
                int GobDamage1 = DMG.Next(1, 5) + 1;
                GobDamage = GobDamage1 + GobDamage;
                Console.WriteLine($"Single Goblin Damage: {GobDamage1}");
                Console.WriteLine($"Total Damage: {GobDamage}");
            }
        }
        GobSpeed = GobSpeed + 3;
        Console.ReadLine();
        Console.WriteLine($"Goblin Damage {GobDamage}");
        Console.ReadLine();
        Health = Health - GobDamage;
        Console.WriteLine($"You have {Health} Life left");
        if (Health <= 0)
        {
            Console.WriteLine("You have Died, Thank you for playiing");
            System.Environment.Exit(0);
        }
    }

    void Running()
    {
        Console.WriteLine("You Start running away!! (You Coward)");
        if (speed < GobSpeed - 3)
        {
            Console.WriteLine("You get away safely!!");
            House();
        }
        else
        {
            Console.WriteLine("You couldn't get away!!");
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

void skeleyTalk()
{
    TextTyping("You walk toward the skeleton, hoping to hear his kind words");
    int skeRageMeter = 0;
    while (skeRageMeter != 3)
    {
        TextTyping("(1) Hello! \n(2) How are the wife and kids? \n(3) Whats the afterlife like? \n(4) Welp, sleep well");
        int response = Int32.Parse(Console.ReadLine());
        switch (response)
        {
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

Console.Clear();
TextTyping("Welcome to the Land of Spud!!\nYour Name is Jimbo, and your wife has been stolen!!!!\nYou must rescue her from the Evil Cow Man!!!!");
House();
