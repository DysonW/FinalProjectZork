//github test

int wisdom = 1;
int LifePotion = 0;
int Coins = 0;
bool dungeonKey = false;
bool searchDungChest = true;
bool Stick = false;
int level = 1;
bool searchGobChest = true;

void Village(){
    Console.WriteLine("You step into the village!! Because of the Evil Cow Man, the Village has been deserted.");
Console.WriteLine("You see the door to your house, as well as the shop that you know and love.\nThere is also a path to the East that will let you exit the village");
Console.WriteLine("What would you like to do?");
Console.ReadKey();
bool inVillage = true;
while(inVillage == true){
Console.WriteLine("<house, shop, east, search, inventory>");
string response = Console.ReadLine();
if(response == "house"){
Console.WriteLine("You make your way to you house and open the door");
Console.ReadKey();
inVillage = false;
House();
}

if (response == "shop"){
Console.WriteLine("You make your way to the deserted shop and open the door.");
Console.ReadKey();
inVillage = false;
Shop();
}

if(response == "east"){
Console.WriteLine("You make your way to the village gate, and go beyond.");
Console.ReadKey();
inVillage = false;
Clearing1();
}

if (response == "search"){
Console.WriteLine("As You look around the Village, You see a Tree along the North, and the weird Village Cat.");
Console.ReadKey();
bool searching = true;
Console.WriteLine("What would you like to search?");

while(searching){
Console.WriteLine("<tree or cat>");
string search = Console.ReadLine();
if(search == "tree"){
Console.WriteLine("You begin searching the tree");
Console.ReadKey();
CommonSearching();   
searching = false;
}
else if(search == "cat" ){
Console.WriteLine("You slowly approach the cat");
Console.ReadKey();
RareSearching();
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}
}
}

if (response == "inventory"){
Inventory();
}

else{
Console.WriteLine("What would you like to do?");
Console.ReadKey();
}


}
}

void Shop(){
Console.WriteLine("You have entered the Shop!");
Console.ReadKey();
Console.WriteLine("The shop has been stripped of it's wares since the time the Evil Cow Man has come, but it's still in good condition");
Console.WriteLine("There is the door to exit into the village, but it might be worth while to take a look around.");
bool inShop = true;
while(inShop == true){
Console.WriteLine("<exit, search, or inventory>");
string response = Console.ReadLine();
if(response == "exit"){
Console.WriteLine("You make your way to the door and exit to the village");
inShop = false;
Village();

}

if(response == "search"){
Console.WriteLine("As You look around the shop, You notice the counter, as well as the shelves");
Console.ReadKey();
bool searching = true;
Console.WriteLine("What would you like to search?");

while(searching){
Console.WriteLine("<counter or shelves>");
string search = Console.ReadLine();
if(search == "counter"){
Console.WriteLine("You walk to the counter and start searching around");
Console.ReadKey();
Console.WriteLine("As you are looking at the counter, you notice a suspicious piece of wood");
Console.WriteLine("Would you like to pull it?\n<yes or no>");
bool thinking = true;
while(thinking){
string think = Console.ReadLine();
if(think == "yes"){
    Console.WriteLine("You pull the lever and you hear the sound of scraping and a secret door opens");
    Console.WriteLine("You enter the passageway");
    thinking = false;
    Console.ReadKey();
    CowField();
    
}
else if(think == "no"){
Console.WriteLine("Whelp, there isn't anything else here, so good luck");
thinking = false;
}
else{
Console.WriteLine("Sorry, but I can't read that");
}
}
searching = false;
}
else if(search == "shelves" ){
Console.WriteLine("You start looking through the barren shelves");
Console.ReadKey();
UncommonSearching();   
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}

}
}

if(response == "inventory"){
Inventory();  
Console.WriteLine("still working on it");
Console.ReadKey();
}

else{
    Console.WriteLine("What would you like to do?");
Console.ReadKey();
}


}
}

void House(){
Console.WriteLine("You are in your house! what would you like to do?");
Console.WriteLine("There is a door that you can take, or you can take a look around your house, or look in your backpack.");
bool inHouse = true;
while(inHouse == true){
Console.WriteLine("<Door, search, inventory>");
string response = Console.ReadLine();
if(response == "door"){
Console.WriteLine("You move to the door and turn the handle, stepping out into a bright new world.");
Console.ReadKey();
inHouse = false;
Village();

}

if(response == "search"){
Console.WriteLine("As You look around your house, You see a chest on the northern wall, as well as the bed that you woke up in to your left.");
Console.ReadKey();
bool searching = true;
Console.WriteLine("What would you like to search?");

while(searching){
Console.WriteLine("<bed or chest>");
string search = Console.ReadLine();
if(search == "bed"){
Console.WriteLine("You look under the bed");
Console.ReadKey();
CommonSearching();
searching = false;
Console.ReadKey();
break;
}
else if(search == "chest" ){
Console.WriteLine("You slowly open the chest");
Console.ReadKey();
RareSearching();   
searching = false;
}

else{
Console.WriteLine("You can't search there");
}

}
}

if(response == "inventory"){
Inventory();  
}

else{

    Console.WriteLine("What would you like to do?");
Console.ReadKey();
}

}
}

void CowField(){
Console.WriteLine("As you exit the passageway, you are stunned to see a field full of cows just minding their own business.");
Console.WriteLine("You hate cows");
Console.WriteLine("There isn't much to do here other then fume in rage, you should return to the shop.");
bool inField = true;
while(inField){
Console.WriteLine("<Leave or inventory>");
string response = Console.ReadLine();
if(response == "leave"){
Console.WriteLine("You turn around and head back to the shop");
inField = false;
Shop();
}

if (response == "inventory"){
Inventory();
Console.ReadKey();
}

else{
Console.WriteLine("What would you like to do?");
Console.ReadKey();
}

}
}

void Clearing1(){
Console.WriteLine("You take the path and enter the clearing!\nAs you you look around, you see a path heading west, a path heading south, and a path heading east. You can also search the area ");
bool inClearing1 = true;
while(inClearing1){
Console.WriteLine("<east, west, south, search, or inventory>");
string response = Console.ReadLine();

if(response == "east"){
Console.WriteLine("You start heading east");
inClearing1 = false;
Console.ReadKey();
SusClearing();
}

if(response == "west"){
Console.WriteLine("You start heading towards the Village!");
inClearing1 = false;
Console.ReadKey();
Village();
}

if(response == "south"){
Console.WriteLine("You start heading South");
inClearing1 = false;
Console.ReadKey();
BarrenClearing();
}

if(response == "search"){
Console.WriteLine("As You look around the clearing, you see a few trees, and some rocks");
Console.ReadKey();
bool searching = true;
Console.WriteLine("What would you like to search?");

while(searching){
Console.WriteLine("<trees or rocks>");
string search = Console.ReadLine();
if(search == "trees"){
Console.WriteLine("You search the trees");
Console.ReadKey();
UncommonSearching();  
searching = false;
}
else if(search == "rocks" ){
Console.WriteLine("You search the rocks");
Console.ReadKey();
CommonSearching();   
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}
}
}

if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{

Console.WriteLine("What would you like to do?");
Console.ReadKey();
}
}
}

void SusClearing(){
Console.WriteLine("As you enter this clearing, you you notice it looks awfully suspicious.");
Console.WriteLine("You notice that it seems the trail ends here, but it is a sus clearing.");
bool inSusClearing = true;
while(inSusClearing == true){
Console.WriteLine("<west, search, or inventory>");
string response = Console.ReadLine();

if(response == "west"){
Console.WriteLine("You start heading back the way you came.");
inSusClearing = false;
Clearing1();

}

if(response == "search"){
Console.WriteLine("As You look around the Sus Clearing, you see a discover a sus chest.");
Console.ReadKey();
bool searching = true;
Console.WriteLine("Would you like to open the chest?");

while(searching){
Console.WriteLine("<yes or no>");
string search = Console.ReadLine();
if(search == "yes"){
Console.WriteLine("You open the chest!!");
Console.ReadKey();
CursedSearching();   
searching = false;
}
else if(search == "no" ){
Console.WriteLine("You don't open the chest");
Console.ReadKey();
Console.WriteLine("You don't know what you're missing.");
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}
}
}


if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{

Console.WriteLine("What would you like to do?");
Console.ReadKey();
}
}
}

void BarrenClearing(){
Console.WriteLine("You have entered the Barren clearing!");
Console.WriteLine("You look around you and see that this place is barren, but there are 4 places that you can go,\nNorth, South, East, and West");
bool inClearing2 = true;
while(inClearing2 == true){
    Console.WriteLine("What would you like to do?\n<north, south, east, west, search, or inventory>");
string response = Console.ReadLine();
if(response == "north"){
Console.WriteLine("You start heading on the Northern Path!");
inClearing2 = false;
Clearing1();

}
if(response == "south"){
Console.WriteLine("You start walking on the Southern Path!");
inClearing2 = false;
SouthernClearing();

}

if(response == "west"){
Console.WriteLine("You start walking on the Western Path!");
inClearing2 = false;
WonderfulClearing();

}

if(response == "east"){
Console.WriteLine("You start Heading to the East!");
inClearing2 = false;
Clearing6();

}

if(response == "search"){
Console.WriteLine("As You look around this area, you see about nothing.");
Console.ReadKey();
bool searching = true;
Console.WriteLine("What would you like to search?");

while(searching){
Console.WriteLine("<NOTHING or nothing>");
string search = Console.ReadLine();
if(search == "NOTHING"){
Console.WriteLine("You search the NOTHING!!");
Console.ReadKey();
UncommonSearching();  
searching = false;
}
else if(search == "nothing" ){
Console.WriteLine("You search the nothing!!");
Console.ReadKey();
CommonSearching();   
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}
}
}

if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{
    Console.WriteLine();
}

}
}

void WonderfulClearing(){
Console.WriteLine("You have entered this Wonderful Clearing!!");
Console.WriteLine("There are so many things to do at this clearing that it's impossible to do them all, so we narrowed it down for ya.\nThere is a path to the east, a path to the west, and a path to the North.\nOr You can look around this wonderful clearing");
bool inClearing3 = true;
Console.WriteLine("What would you like to do today?");
while(inClearing3 == true){
Console.WriteLine("<east, west, north, search, inventory");
string response = Console.ReadLine();

if(response == "west"){
Console.WriteLine("You start heading down the Western Path.");
inClearing3 = false;
Clearing4();

}

if(response == "east"){
Console.WriteLine("You start Going Eaeasst.");
inClearing3 = false;
BarrenClearing();

}

if(response == "north"){
Console.WriteLine("You start going to the North.");
inClearing3 = false;
CowLookOut();

}

if(response == "south"){
Console.WriteLine("You start heading South!!");
inClearing3 = false;
//DungeonEntrance();
}

if(response == "search"){
Console.WriteLine("As You look around this wonderful clearing, you are dazzled by how wonderful it is. Everyting is soo wonderful that you feel that if you search it, it will ruin it.... that is, everythhing except that rock over there, it's just too ugly for this wonderful clearing.");
Console.ReadKey();
bool searching = true;
Console.WriteLine("Would you like to search the Rock?");

while(searching){
Console.WriteLine("<yes or no>");
string search = Console.ReadLine();
if(search == "yes"){
Console.WriteLine("You search the Rock!!");
Console.ReadKey();
CursedSearching();   
searching = false;
}
else if(search == "no" ){
Console.WriteLine("Coward, You don't search the rock");
Console.ReadKey();
Console.WriteLine("You don't know what you're missing.");
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}
}
}

if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{

Console.WriteLine("What would you like to do?");
Console.ReadKey();
}
}
}

void Clearing4(){
Console.WriteLine("You have entered the normal Clearing!!");
Console.WriteLine("It's a pretty normal clearing, with  not much to do, but there is still stuff to do. Maybe it would be worth while to take a look around.");
bool inClearing4 = true;
Console.WriteLine("What would you like to do today?");
while(inClearing4){
Console.WriteLine("<east, south, search, inventory");
string response = Console.ReadLine();
if(response == "east"){
    Console.WriteLine("You start heading east");
    inClearing4 = false;
    WonderfulClearing();
}

if(response == "south"){
Console.WriteLine("You start heading south!");
inClearing4 = false;
AngryClearing();
}
if(response == "search"){
    Console.WriteLine("You have decided to Search this pretty normal clearing. As you take a look around, you see that there is not much to search except the grass itself. there area few pebbles here and there too, but you don't think that there could be anything hiding there");
    Console.ReadKey();
bool searching = true;
Console.WriteLine("Would you like to search the grass or the pebbles?");

while(searching){
Console.WriteLine("<grass or pebbles>");
string search = Console.ReadLine();
if(search == "grass"){
Console.WriteLine("You search the grass!!");
Console.ReadKey();
searching = false;
CommonSearching();   
}
else if(search == "pebbles" ){
Console.WriteLine("You search the pebbles!!");
Console.ReadKey();
searching = false;
RareSearching();     
}

else{
Console.WriteLine("You can't search there!");
}
}
}

if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{
Console.WriteLine("What would you like to do?");
Console.ReadKey();
}
}
}

void AngryClearing(){
Console.WriteLine("You have entered this clearing, and as you do, you feel a rage come over you. You are mad.");
Console.WriteLine("You see a path going back to the north, but that's about it.");
bool inClearing = true;
while(inClearing){
Console.WriteLine("<north, search, inventory>");
string response = Console.ReadLine();
if(response == "north"){
    Console.WriteLine("You start heading back North!");
inClearing = false;
Clearing4();
}

if (response == "search"){
Console.WriteLine("You have decided to Search this angry clearing. As you take a look around, you see that there is a chest.");
    Console.ReadKey();
bool searching = true;
Console.WriteLine("Would you like to open the chest?");

while(searching){
Console.WriteLine("<yes or no>");
string search = Console.ReadLine();
if(search == "yes"){
Console.WriteLine("You slowly open the chest!!");
Console.ReadKey();
searching = false;
CursedSearching();   
}
else if(search == "no" ){
Console.WriteLine("You don't open the chest.");
Console.WriteLine("Are you Scared");
Console.ReadKey();
Console.WriteLine("Whelp, good luck!");
searching = false;
}

else{
Console.WriteLine("You can't search there!");
}
}
}

if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{
Console.WriteLine("What would you like to do?");
Console.ReadKey();
}

}
}

void CowLookOut(){
Console.WriteLine("You have climbed a hill following the path, and you find yourself overlooking a field of Cows.");
Console.WriteLine("To your dismay, that's about all that there is to do here");
bool inCowLookout = true;
while(inCowLookout){
Console.WriteLine("<south or inventory>");
string response = Console.ReadLine();
if(response == "south"){
Console.WriteLine("You start heading back the way that you came, away from thw cows");
inCowLookout = false;
WonderfulClearing();
}

if(response == "inventory"){
    Inventory();
    Console.ReadKey();
}

else{
Console.WriteLine("What would you like to do?");
Console.ReadKey();
}
}
}

void SouthernClearing(){
Console.WriteLine("You have entered the southern clearing!");
Console.WriteLine("As you look around, you see that this is the end of the trail here, but maybe you should take a look around.");
bool inSouthClear = true;
Console.WriteLine("What would you like to do?");
while(inSouthClear){
Console.WriteLine("<north, search, or inventory>");
string response = Console.ReadLine();
if(response == "north"){
Console.WriteLine("You start heading North!");
inSouthClear = false;
BarrenClearing();
}

if(response == "search"){
Console.WriteLine("As you look around the clearing, there seems to be a chest that can be opened, as well as some trees around.");
bool searching = true;
while(searching){
Console.WriteLine("<chest or trees>");
string answer = Console.ReadLine();

if(answer == "chest" && searchDungChest == false){
Console.WriteLine("You have alread searched there!!\nTough Luck Mate");
Console.ReadKey();
searching = false;
}

if(answer == "chest" && searchDungChest == true){
Console.WriteLine("You make your way over to the chest and open it!!");
searching = false;
searchDungChest = false;
dungeonKey = true;
Console.WriteLine("You have found a key!!!\n it is very intricate, and is probably important.");
}

if(answer == "trees"){
Console.WriteLine("You begin to make your way to the trees!!");
CommonSearching();
searching = false;
}

else{
    Console.WriteLine();
}
}
}

if(response == "inventory"){
Inventory();
}

else{
Console.WriteLine("What would you like to do?");
}
}
}

void Clearing6(){
Console.WriteLine("You have entered this clearing!!");
Console.ReadKey();
Console.WriteLine("As you take a quick look around this clearing, it seems that the path goes south, as well as west. You can also search around a bit if you'd like.");
bool inClearing6 = true;
Console.WriteLine("What would you like to do?");
while(inClearing6){
Console.WriteLine("<south, west, search, or inventory");
string response = Console.ReadLine();
if(response == "south"){
Console.WriteLine("You begin heading south!!");
inClearing6 = false;
GoblinClearing();
}
if(response == "west"){
Console.WriteLine("You begin heading west!!");
inClearing6 = false;
BarrenClearing();
}

if(response == "search"){
Console.WriteLine("As you look around the clearing, there isn't much here, but you do see a pile of rocks.");
bool searching = true;
Console.WriteLine("Would you like to search the rocks?");
while(searching){
Console.WriteLine("<yes or no>");
string answer = Console.ReadLine();

if(answer == "yes"){
Console.WriteLine("You search the rocks!!");
searching = false;
CommonSearching();
}

if(answer == "no"){
Console.WriteLine("You don't search the rocks!!");
searching = false;
}
else{
    Console.WriteLine();
}
}
}
if(response == "inventory"){
Inventory();
}

else{
    Console.WriteLine("What would you like to do?");
}
}
}

void GoblinClearing(){
Console.WriteLine("You enter this clearing and see that there looks like there is a camp full of Goblins on the other side of this area. ");
Console.WriteLine("You see that there is also a path going to the North, but you should get ready for a battle.");
bool inGobClear = true;
while(inGobClear){
    Console.WriteLine("<north, fight, or inventory>");
string response = Console.ReadLine();
    if(response == "north"){
        Console.WriteLine("You start heading North!!");
        inGobClear = false;
        Clearing6();
    }

    if(response == "fight"){
        Console.WriteLine("You head over to the Goblin Camp, weapon drawn.");
        inGobClear = false;
        GoblinCamp();
    }

    if(response == "inventory"){
        Inventory();
    }
    else{
        Console.WriteLine("What would you like to do??");
    }
}
}

void GoblinCamp(){
    Console.WriteLine("You have entered the Camp!!");
    Console.WriteLine("There seems to be only a few goblins Milling around, the rest must be on a hunting trip.");
    //GoblinCombat(6);
    Console.ReadKey();
    Console.WriteLine("You have defeated the Goblins, but more will be here shortly");
    Console.WriteLine("There is the Path that heads North out of this clearing, but you should take a look around.");
    bool InGoblinCamp = true;
    while(InGoblinCamp){
        Console.WriteLine("<north, search, or inventory>");
        string response = Console.ReadLine();
        if(response == "north"){
            Console.WriteLine("You start heading to the North");
            Clearing6();
        }
        
        if(response == "search"){
            Console.WriteLine("As you take a look around, you see that there is a chest, as well as the little huts that you may search.");
            bool searching = true;
            Console.WriteLine("What would you like to search");
            
            while(searching){
                Console.WriteLine("<chest or huts>");

                string answer = Console.ReadLine();
                if(answer == "chest" && searchGobChest == false){
                    Console.WriteLine("You open the chest and find...");
                    Console.ReadKey();
                    Console.WriteLine("NOTHING!!!");
                    searching = false;
                }
                if(answer == "chest" && searchGobChest == true){
                    Console.WriteLine("You open the chest and find...");
                    Console.ReadKey();
                    Console.WriteLine("Some Goblin Armor!!!");
                    Console.WriteLine("It looks a little grody, but armor is armor, and it is better then nothing");
                    searching = false;
                    searchGobChest = false;
                }
                if(answer == "huts"){
                    Console.WriteLine("You start seraching the gross goblin Huts");
                    searching = false;
                    RareSearching();
                }
                else{
                    Console.WriteLine("What would you like to search?");
                }
            }
        }
    }
}



void CommonSearching(){
Random search = new Random();
int item = search.Next(0,10);
int searchScore = item + wisdom;
if(searchScore >= 5 && searchScore <= 9){
Console.WriteLine(searchScore);
Console.WriteLine("You have found a Life Potion!!!");
LifePotion++;
}

if(searchScore == 10){
Console.WriteLine("You found an extrordinary stick! :)");
Stick = true;
}


else if(searchScore >= 0 && searchScore <= 4){
Console.WriteLine("You Found Nothing!!");
}


}

void UncommonSearching(){
Random search = new Random();
int item = search.Next(0,20);
int searchScore = item + wisdom;
if(searchScore >= 5 && searchScore <= 9){
Console.WriteLine(searchScore);
Console.WriteLine("You have found a Life Potion!!!");
LifePotion++;
}

if(searchScore == 10){
Console.WriteLine("You found an extrordinary stick! :)");
Stick = true;
}


else if(searchScore >= 0 && searchScore <= 4){
Console.WriteLine("You Found Nothing!!");
}


}

void RareSearching(){
Random search = new Random();
int item = search.Next(0,50);
int searchScore = item + wisdom;
if(searchScore >= 5 && searchScore <= 9){
Console.WriteLine(searchScore);
Console.WriteLine("You have found a Life Potion!!!");
LifePotion++;
}

if(searchScore == 10){
Console.WriteLine("You found an Super Sword! :)");
Stick = true;
}


else if(searchScore >= 0 && searchScore <= 4){
Console.WriteLine("You Found Nothing!!");
}


}

void CursedSearching(){
Random search = new Random();
int item = search.Next(0,10);
int searchScore = item + wisdom;
if(searchScore >= 5 && searchScore <= 9){
Console.WriteLine(searchScore);
Console.WriteLine("You have found the cursed apple!!!");
LifePotion++;
}

if(searchScore == 10){
Console.WriteLine("You found The Cursed Sword! :)");
Stick = true;
}


else if(searchScore >= 0 && searchScore <= 4){
Console.WriteLine("You Found Nothing!!");
}


}

void Inventory(){
Console.WriteLine($"Life Potions: {LifePotion}");
}



Console.Clear();
Console.WriteLine("Welcome to the Land of Spud!!\nYour Name is Jimbo, and your wife has been stolen!!!!\nYou must rescue her from the Evil Cow Man!!!!");
House();




