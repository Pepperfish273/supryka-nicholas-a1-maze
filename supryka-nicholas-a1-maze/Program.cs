// It's 1 AM and I am tired. First section is setting variables for later use
Console.WriteLine("What is your name?");
string playerName = Console.ReadLine();
Console.WriteLine("Please insert gold count.");
int goldCount = int.Parse(Console.ReadLine());
Console.WriteLine("Please insert health.");
int playerHealth = int.Parse(Console.ReadLine());
Console.WriteLine("------------------\nYou awaken in a dimly lit hallway intersection, with three pathways.\nDo you go left, right or forward?");
string firstSplit = Console.ReadLine();
// The first decision
if (firstSplit == "left")
{
    Console.WriteLine("You decide the left path is the best choice.\nAfter entering the room, you see a \"wall\".\nDo you try to go through the wall, or walk away?");
    string fakeWall = Console.ReadLine();
    if (fakeWall == "go through wall" && playerHealth >= 3)
    {
        Console.WriteLine("You walk through the \"wall\". It hurts, but you are through, and in a room with a golden figure.\nDo you take it?");
        string goldFigure = Console.ReadLine();
        if (goldFigure == "take it")
        {
            Console.WriteLine($"The figure was on a pressure plate and sets off a explosion trap when you lift it.\n{playerName}, you have died.");
        }
        else
        {
            Console.WriteLine($"You overcome the greed to take the figure and find an exit out of the maze!\n{playerName}, you have escaped!");
        }
    }
    else
    {
        Console.WriteLine("You walk away, but the walls begin to close in around you!\nDo you try to hold them open, or try and run out of the room?");
        string closingWalls = Console.ReadLine();
        if (closingWalls == "hold open")
        {
            Console.WriteLine($"You find a nearby stick and attempt to hold the walls open.\nIt worked! A secret door opens from one of the walls that leads outside. {playerName}, you have escaped!");
        }
        else
        {
            Console.WriteLine($"The walls close in too fast, and you get crushed.\n{playerName}, you have died.");
        }
    }
}
else if (firstSplit == "right")
{
    Console.WriteLine("You think that the right path is correct.\nWhen you enter the room, you see a door on your left and right. Which do you choose?");
    string twoDoors = Console.ReadLine();
    if (twoDoors == "left")
    {
        Console.WriteLine($"You walk through the left door and fall into a pit of lava.\n{playerName}, you have died.");
    }
    else
    {
        Console.WriteLine("You walk through the right door. Inside the room there is a goblin.\nDo you fight him or try to barter with him?");
        string goblinMeet = Console.ReadLine();
        if (goblinMeet == "barter" && goldCount >= 10)
        {
            Console.WriteLine($"The goblin gives you a map in exchange for your remaining gold.\nYou have no more gold, but at least you found a way out.\n{playerName}, you have escaped!");
        }
        else if (goblinMeet == "barter" && goldCount < 10)
        {
            Console.WriteLine($"The goblin isn't interested in trading and you wander the maze forever.\n{playerName}, you are stuck in the maze forever.");
        }
        else
        {
            Console.WriteLine($"The goblin prepares to fight and knocks you out in one hit.\n{playerName}, you have died");
        }
    }
}
else if (firstSplit == "forward")
{
    Console.WriteLine("You pick the path forward and find a long hallway.\nIt seems suspicious. Do you run through or throw a rock just to check?");
    string spikeHall = Console.ReadLine();
    if (spikeHall == "throw rock")
    {
        Console.WriteLine("You throw a rock and your suspicions are right! A bunch of spikes pop out of the ground and you now can walk around them.");
        Console.WriteLine("The hallway leads into a room with a sleeping giant. Do you sneak around it or try to hit it with a rock?");
        string giantFight = Console.ReadLine();
        if (giantFight == "sneak")
        {
            Console.WriteLine($"You try to sneak around the giant, but it crushes you when it rolls over.\n{playerName}, you have died.");
        }
        else
        {
            Console.WriteLine($"You throw a rock and it confuses the giant! The giant stumbles and reveals a trapdoor under it.\n{playerName}, you have escaped!");
        }
    }
    else
    {
        Console.WriteLine($"You try to run through the hall, but get skewered by spikes popping out of the ground.\n{playerName}, you have died.");
    }
}
else
{
    Console.WriteLine($"You can't make up your mind and get crushed by a suprise boulder. \n{playerName}, you have died");
}

Console.ReadLine();