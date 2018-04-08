using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    static class Yeti 
    {

    }
    static class Level1
    {
        static bool brushbroken = false;
        static bool chest1opened = false;
        public static void Room1()
        {
            Console.WriteLine("---Level 1: Temple Heights---");
            look:
            Console.WriteLine("You are in a small stone room. There are great statues of stone in the middle. There is a door to the north.");
        top:
            string command = Console.ReadLine();
            if (command.Contains("north"))
            {
                Room21();
                goto top;
            }
            else if (command.Contains("exit"))
            {
                Amphisar.acre11();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            } else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            } 
        }
        public static void Room21()
        {
        look:
            Console.WriteLine("You are in a long stone room. There is a door to the south and north");
        DungeonMonsters();
        top:
            string command = Console.ReadLine();
            if (command.Contains("north"))
            {
                Room31();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Room1();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room31()
        {
        look:
            Console.WriteLine("You are in a small stone room. There is a door to the south, north, east, and west.");
        top:
            string command = Console.ReadLine();
            if (command.Contains("north"))
            {
                Room41();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Room21();
                goto top;
            }
            else if (command.Contains("east"))
            {
                Room32();
                goto top;
            }
            else if (command.Contains("west"))
            {
                Room30();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room30()
        {
        look:
            Console.WriteLine("You are in a long stone room. There are great statues of stone in the middle. There is a door to the east. There is a chest in the center.");
        top:
            string command = Console.ReadLine();
            if (command.Contains("east"))
            {
                Room31();
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("chest"))
            {
                if (!chest1opened) 
                {
                Stat.Weapons.Add("machete");
                Console.WriteLine("You got a machete! Use it to chop trough the thick brush!");
                chest1opened = true;
                }
                else
                {
                    Console.WriteLine("It's opened");
                }
                
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room32()
        {
        look:
            Console.WriteLine("You are in a long stone room. There are great statues of stone in the middle. There is a door to the west.");
        top:
            string command = Console.ReadLine();
            if (command.Contains("west"))
            {
                Room31();
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room41()
        {
            string brush;
            if(brushbroken){
            brush = "The brush was cut through.";
            } else 
            {
            brush = "There is thick brush ahead";
            }
        look:
            Console.WriteLine("You are in a long stone room. {0} There is a door to the north and south.",brush);
        top:
            string command = Console.ReadLine();
            if (command.Contains("south"))
            {
                Room31();
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("north"))
            {
                if (brushbroken)
                {
                    Room51();
                }
                else 
                {
                    Console.WriteLine("The brush is too thick");
                }
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else if (command.Contains("cut") || command.Contains("machete") || command.Contains("brush"))
            {
                if (Stat.Weapons.Contains("machete"))
                { 
                    Console.WriteLine("You cut through the brush!");
                    brushbroken = true;
                }
                else 
                {
                    Console.WriteLine("You can't clear the brush without a machete!");
                }
                
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room51()
        {
        look:
        Console.WriteLine("You are in a large stone room.");
        top:
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Boom!");
        Console.WriteLine("????: You thought you could come here to defeat me? FOOL! Let's rumble!");
        Console.WriteLine("A level 10 Ooze Boss!");
        Stat.Monster = "Ooze Boos";
        Stat.mcopper = 500;
        Stat.monsterlevel = 10;
        Stat.msilver = 150;
        Stat.mgold = 75;
        Stat.exp = 150;
        Stat.monsterHealth = 1000;
        Stat.combat();
        Console.WriteLine("");
        Console.Write("Ooze Boss: NOOO! IT CAAN'T BEE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE");
        System.Threading.Thread.Sleep(200);
        Console.Write("EE!");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
        Console.WriteLine("You walk into the next room.");
        System.Threading.Thread.Sleep(200);
        Console.Write("There is a treasure on a pedistal: A power glove.");
        Stat.Inventory.Add("power glove");
        System.Threading.Thread.Sleep(200);
        Console.Write("You walk out of the dungeon");
        System.Threading.Thread.Sleep(200);
        Stat.Level1Completed = true;
        Amphisar.acre11();
        }
        public static void DungeonMonsters()
        {
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} Shadow Ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "Shadow Ooze";
                    Stat.mcopper = 10;
                    Stat.msilver = 7;
                    Stat.mgold = 5;
                    Stat.exp = 25;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("A level {0} shadow troll appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "shadow troll";
                    Stat.mcopper = 5;
                    Stat.msilver = 3;
                    Stat.mgold = 2;
                    Stat.exp = 10;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} Dungeon Ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "Dungeon Ooze";
                    Stat.mcopper = 7;
                    Stat.msilver = 4;
                    Stat.mgold = 3;
                    Stat.exp = 15;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} shadow viper appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "shadow viper";
                    Stat.mcopper = 3;
                    Stat.msilver = 1;
                    Stat.mgold = 0;
                    Stat.exp = 5;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
     
    }
    static class Level2
    {
        static bool key1used;
        static bool key2used;
        static bool key3used;
        static bool keyinroom20;
        static bool boarinroom20 = true;
        static bool keyinroom2;
        static bool boarinroom2 = true;
        static bool keyinroom22;
        static bool boarinroom22 = true;
        static bool keyinroom23;
        static bool boarinroom23 = true;
        static bool brushbroken = false;
        static bool chest1opened = false;
        public static void Room1()
        {
            Console.WriteLine("---Level 2: Jungle Ruins---");
        look:
            Console.WriteLine("You are in a small mossy stone room. There are great statues of stone in the middle. There is a door to the north.");
        top:
            string command = Console.ReadLine();
            if (command.Contains("north"))
            {
                Room21();
                goto top;
            }
            else if (command.Contains("exit"))
            {
                Amphisar.acre17();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("There is no door that way");
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room2()
        {
        look:
            Console.WriteLine("You are in a mossy stone room. There are great statues of stone in the middle. There is a door to the east.");
            if (keyinroom2)
            {
                Console.WriteLine("There is a key on the floor");
            }
            if (boarinroom2)
            {
                Console.WriteLine("A jungle boar appears! He looks angry!");
                Stat.Monster = "jungle boar";
                Stat.mcopper = 50;
                Stat.monsterlevel = 15;
                Stat.msilver = 25;
                Stat.mgold = 10;
                Stat.exp = 100;
                Stat.monsterHealth = 750;
                Stat.combat();
                keyinroom2 = true;
                boarinroom2 = false;
                Console.WriteLine("A key has dropped from the boar's carcas.");
            }
        top:
            string command = Console.ReadLine();
            if (command.Contains("east"))
            {
                Room20();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("key"))
            {
                if (keyinroom2)
                {
                    Stat.Inventory.Add("Jungle Key");
                    Console.WriteLine("You got a jungle key!");
                    keyinroom2 = false;
                }
                else
                {
                    Console.WriteLine("There is no key!");
                }

                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room20()
        {
        look:
        Console.WriteLine("You are in a mossy stone room. There are great statues of stone in the middle. There is a door to the east and west.");
        if (keyinroom20) 
        {
            Console.WriteLine("There is a key on the floor");
        }
        if (boarinroom20)
        {
            Console.WriteLine("A jungle boar appears! He looks angry!");
            Stat.Monster = "jungle boar";
            Stat.mcopper = 50;
            Stat.monsterlevel = 15;
            Stat.msilver = 25;
            Stat.mgold = 10;
            Stat.exp = 100;
            Stat.monsterHealth = 750;
            Stat.combat();
            keyinroom20 = true;
            boarinroom20 = false;
            Console.WriteLine("A key has dropped from the boar's carcas.");
        }
        top:
            string command = Console.ReadLine();
            if (command.Contains("east"))
            {
                Room21();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Room2();
                goto top;
            }
            else if (command.Contains("key"))
            {
                if (keyinroom20)
                {
                    Stat.Inventory.Add("Jungle Key");
                    Console.WriteLine("You got a jungle key!");
                    keyinroom20 = false;
                }
                else
                {
                    Console.WriteLine("There is no key!");
                }

                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room21()
        {
        look:
            Console.WriteLine("You are in a mossy stone room. There is a door to the south, north, east, and west.");
        if (!key1used) 
        {
            Console.WriteLine("The north door is locked.");
        }
            DungeonMonsters();
        top:
            string command = Console.ReadLine();
            if (command.Contains("north"))
            {
                if (key1used)
                {
                    Room31();
                }
                else 
                {
                    Console.WriteLine("The door is locked.");
                }
                goto top;
            }
            else if (command.Contains("south"))
            {
                Room1();
                goto top;
            }
            else if (command.Contains("west"))
            {
                Room20();
                goto top;
            }
            else if (command.Contains("east"))
            {
                Room22();
                goto top;
            }
            else if (command.Contains("unlock") || command.Contains("lock") || command.Contains("key")) 
            {
                if (!key1used)
                {
                    if (Stat.Inventory.Contains("Jungle Key"))
                    {
                        Console.WriteLine("The door became unlocked!");
                        Stat.Inventory.Remove("Jungle Key");
                        key1used = true;
                        goto top;
                    }
                    else
                    {
                        Console.WriteLine("You need a key to do that!");
                        goto top;
                    }
                }
                else
                {
                    Console.WriteLine("The door is already unlocked!");
                    goto top;
                }
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room31()
        {
        look:
            Console.WriteLine("You are in a small mossy stone room. There is a door to the south and north.");
            if (!key2used)
            {
                Console.WriteLine("The north door is locked.");
            }
            DungeonMonsters();
        top:
            string command = Console.ReadLine();
            if (command.Contains("north"))
            {
                if (key2used)
                {
                    Room41();
                }
                else
                {
                    Console.WriteLine("The door is locked.");
                }
                goto top;
            }
            else if (command.Contains("south"))
            {
                Room21();
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("run"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("unlock") || command.Contains("lock") || command.Contains("key"))
            {
                if (!key2used)
                {
                    if (Stat.Inventory.Contains("Jungle Key"))
                    {
                        Console.WriteLine("The door became unlocked!");
                        Stat.Inventory.Remove("Jungle Key");
                        key2used = true;
                        goto top;
                    }
                    else
                    {
                        Console.WriteLine("You need a key to do that!");
                        goto top;
                    }
                }
                else
                {
                    Console.WriteLine("The door is already unlocked!");
                    goto top;
                }
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room22()
        {
        look:
            Console.WriteLine("You are in a mossy stone room. There are great statues of stone in the middle. There is a door to the east.");
            if (keyinroom22)
            {
                Console.WriteLine("There is a key on the floor");
            }
            if (boarinroom22)
            {
                Console.WriteLine("A jungle boar appears! He looks angry!");
                Stat.Monster = "jungle boar";
                Stat.mcopper = 50;
                Stat.monsterlevel = 15;
                Stat.msilver = 25;
                Stat.mgold = 10;
                Stat.exp = 100;
                Stat.monsterHealth = 750;
                Stat.combat();
                keyinroom22 = true;
                boarinroom22 = false;
                Console.WriteLine("A key has dropped from the boar's carcas.");
            }
        top:
            string command = Console.ReadLine();
            if (command.Contains("east"))
            {
                Room23();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Room21();
                goto top;
            }
            else if (command.Contains("key"))
            {
                if (keyinroom22)
                {
                    Stat.Inventory.Add("Jungle Key");
                    Console.WriteLine("You got a jungle key!");
                    keyinroom22 = false;
                }
                else
                {
                    Console.WriteLine("There is no key!");
                }

                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room23()
        {
        look:
            Console.WriteLine("You are in a mossy stone room. There are great statues of stone in the middle. There is a door to the east and west.");
            if (keyinroom23)
            {
                Console.WriteLine("There is a key on the floor");
            }
            if (boarinroom23)
            {
                Console.WriteLine("A jungle boar appears! He looks angry!");
                Stat.Monster = "jungle boar";
                Stat.mcopper = 50;
                Stat.monsterlevel = 15;
                Stat.msilver = 25;
                Stat.mgold = 10;
                Stat.exp = 100;
                Stat.monsterHealth = 750;
                Stat.combat();
                keyinroom23 = true;
                boarinroom23 = false;
                Console.WriteLine("A key has dropped from the boar's carcas.");
            }
        top:
            string command = Console.ReadLine();
            if (command.Contains("east"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("There is no door that way!");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Room22();
                goto top;
            }
            else if (command.Contains("key"))
            {
                if (keyinroom20)
                {
                    Stat.Inventory.Add("Jungle Key");
                    Console.WriteLine("You got a jungle key!");
                    keyinroom23 = false;
                }
                else
                {
                    Console.WriteLine("There is no key!");
                }

                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room41()
        {
        look:
            Console.WriteLine("You are in a long stone room. {0} There is a door to the north and south.");
            if (!key3used)
            {
                Console.WriteLine("The north door is locked.");
            }
            DungeonMonsters();
        top:
            string command = Console.ReadLine();
            if (command.Contains("south"))
            {
                Room31();
                goto top;
            }
            else if (command.Contains("north"))
            {
                if (key3used)
                {
                    Room51();
                }
                else
                {
                    Console.WriteLine("The door is locked!");
                }
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee") || command.Contains("run"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else if (command.Contains("unlock") || command.Contains("key") || command.Contains("door"))
            {
                if (!key3used)
                {
                    if (Stat.Weapons.Contains("jungle key"))
                    {
                        Console.WriteLine("The door became unlocked!");
                        key3used = true;
                    }
                    else
                    {
                        Console.WriteLine("You need a key to open the door!");
                    }
                }
                else
                {
                    Console.WriteLine("The door is already unlocked!");
                }
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void Room51()
        {
        look:
            Console.WriteLine("You are in a large mossy stone room.");
        top:
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Boom!");
            Console.WriteLine("????: Get out or I will kill you...!");
            Console.WriteLine("A level 20 Vine Boss!");
            Stat.Monster = "Vine Boss";
            Stat.mcopper = 500;
            Stat.monsterlevel = 20;
            Stat.msilver = 150;
            Stat.mgold = 75;
            Stat.exp = 150;
            Stat.monsterHealth = 250;
            Stat.combat();
            Console.WriteLine("");
            Console.Write("Vine Boss: NOO! I'VE BEEN DEEEE");
            System.Threading.Thread.Sleep(200);
            Console.Write("FEEE");
            System.Threading.Thread.Sleep(200);
            Console.Write("EE");
            System.Threading.Thread.Sleep(200);
            Console.Write("AA");
            System.Threading.Thread.Sleep(200);
            Console.Write("AA");
            System.Threading.Thread.Sleep(200);
            Console.Write("TE");
            System.Threading.Thread.Sleep(200);
            Console.Write("EED!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("You walk into the next room.");
            System.Threading.Thread.Sleep(200);
            Console.Write("There is a treasure on a pedistal: flippers.");
            Stat.Inventory.Add("flippers");
            System.Threading.Thread.Sleep(200);
            Console.Write("You walk out of the dungeon");
            System.Threading.Thread.Sleep(200);
            Stat.Level1Completed = true;
            Amphisar.acre17();
        }
        public static void DungeonMonsters()
        {
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} Shadow Ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "Shadow Ooze";
                    Stat.mcopper = 10;
                    Stat.msilver = 7;
                    Stat.mgold = 5;
                    Stat.exp = 25;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("A level {0} shadow troll appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "shadow troll";
                    Stat.mcopper = 5;
                    Stat.msilver = 3;
                    Stat.mgold = 2;
                    Stat.exp = 10;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} Dungeon Ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "Dungeon Ooze";
                    Stat.mcopper = 7;
                    Stat.msilver = 4;
                    Stat.mgold = 3;
                    Stat.exp = 15;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} shadow viper appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "shadow viper";
                    Stat.mcopper = 3;
                    Stat.msilver = 1;
                    Stat.mgold = 0;
                    Stat.exp = 5;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                default:
                    break;
            }
        }

    }
    static class Dungeon
    {
        static bool chest = false;
        static string command;
        static bool northDoor = false;
        static bool southDoor = false;
        static bool westDoor = false;
        static bool eastDoor = false;
        static bool exitDoor = false;
        static bool unopened = true;
        static string northexit = "";
        static string southexit = "";
        static string westexit = "";
        static string eastexit = "";
        static string exitexit = "";
        static string chestinRoom = "";

        public static void GenerateRoom()
        {
            northDoor = false;
            southDoor = false;
            westDoor = false;
            eastDoor = false;
            exitDoor = false;
            string northexit = "";
            string southexit = "";
            string westexit = "";
            string eastexit = "";
            string exitexit = "";
            string chestinRoom = "";
            regenerate:
            Random randDoor = new Random();
            int doorNum = randDoor.Next(4);
            switch (doorNum)
            {
                case 1:
                    Random doorWall = new Random();
                    int doorDirection = doorWall.Next(4);
                    switch (doorDirection)
                    {
                        case 1:
                            northDoor = true;
                            southDoor = false;
                            westDoor = false;
                            eastDoor = false;
                            break;
                        case 2:
                            northDoor = false;
                            southDoor = true;
                            westDoor = false;
                            eastDoor = false;
                            break;
                        case 3:
                            northDoor = false;
                            southDoor = false;
                            westDoor = true;
                            eastDoor = false;
                            break;
                        case 4:
                            northDoor = false;
                            southDoor = false;
                            westDoor = false;
                            eastDoor = true;
                            break;
                        default:
                            exitDoor = true;
                            break;
                    }
                    break;
                case 2:
                    doorWall = new Random();
                    doorDirection = doorWall.Next(6);
                    switch (doorDirection)
                    {
                        case 1:
                            northDoor = true;
                            southDoor = true;
                            westDoor = false;
                            eastDoor = false;
                            break;
                        case 2:
                            northDoor = true;
                            southDoor = false;
                            westDoor = true;
                            eastDoor = false;
                            break;
                        case 3:
                            northDoor = true;
                            southDoor = false;
                            westDoor = false;
                            eastDoor = true;
                            break;
                        case 4:
                            northDoor = false;
                            southDoor = true;
                            westDoor = true;
                            eastDoor = false;
                            break;
                        case 5:
                            northDoor = false;
                            southDoor = true;
                            westDoor = false;
                            eastDoor = true;
                            break;
                        case 6:
                            northDoor = false;
                            southDoor = false;
                            westDoor = true;
                            eastDoor = true;
                            break;
                        default:
                            exitDoor = true;
                            break;
                    }
                    break;
                case 3:
                    doorWall = new Random();
                    doorDirection = doorWall.Next(4);
                    switch (doorDirection)
                    {
                        case 1:
                            northDoor = true;
                            southDoor = true;
                            westDoor = true;
                            eastDoor = false;
                            break;
                        case 2:
                            northDoor = true;
                            southDoor = false;
                            westDoor = true;
                            eastDoor = true;
                            break;
                        case 3:
                            northDoor = true;
                            southDoor = true;
                            westDoor = false;
                            eastDoor = true;
                            break;
                        case 4:
                            northDoor = true;
                            southDoor = true;
                            westDoor = true;
                            eastDoor = false;
                            break;
                        default:
                            exitDoor = true;
                            break;
                    }
                    break;
                case 4:
                    northDoor = true;
                    southDoor = true;
                    westDoor = true;
                    eastDoor = true;
                    break;
                default:
                    exitDoor = true;
                    break;
            }
            Random exitDungeon = new Random();
            int exit = exitDungeon.Next(20);
            if (exit == 5)
            {
                exitDoor = true;
            }
            if (northDoor == true)
            {
                northexit = " There is a door to the north.";
            }
            if (southDoor == true)
            {
                southexit = " There is a door to the south.";
            }
            if (westDoor == true)
            {
                westexit = " There is a door to the west.";
            }
            if (eastDoor == true)
            {
                eastexit = " There is a door to the east.";
            }
            if (exitDoor == true)
            {
                exitexit = " There is an exit to the dungeon! Type exit to leave.";
            }

            Random treasure = new Random();
            int treasureChest = treasure.Next(5);
            if (treasureChest == 2)
            {
                chestinRoom = " There is a chest in the room.";
                chest = true;
                unopened = true;
            }
            if (northDoor == false & southDoor == false & eastDoor == false & westDoor == false & exitDoor == false)
            {
                goto regenerate;
            }
            Console.WriteLine("You are in a square cobblestone room.{0}{1}{2}{3}{4}{5}", northexit, southexit, westexit, eastexit, chestinRoom, exitexit);
            Dungeon.CommandDungeon();
        }
        private static void CommandDungeon()
        {
            DungeonMonsters();
            top:
            string command = Console.ReadLine();
             if(command.Contains("north"))
                {
                    if (northDoor)
                    {
                        Dungeon.GenerateRoom();
                    }
                    else
                    {
                        Console.WriteLine("There is no door that way!");
                    }
                    goto top;
                } else if(command.Contains("south"))
                {
                    if (southDoor) {
                        Dungeon.GenerateRoom();
                    }
                    else
                    {
                        Console.WriteLine("There is no door that way!");
                    }
                    goto top;

                } else if(command.Contains("east"))
                {
                    if (eastDoor)
                    {
                        Dungeon.GenerateRoom();
                    }
                    else
                    {
                        Console.WriteLine("There is no door that way!");
                    }
                    goto top;
                } else if(command.Contains("west"))
                {
                    if (westDoor) {
                        Dungeon.GenerateRoom();
                    }
                    else
                    {
                        Console.WriteLine("There is no door that way!");
                    }
                    goto top;
                }
             else if (command.Contains("exit"))
             {
                 if (exitDoor)
                 {
                     Amphisar.DungeonRun();
                 }
                 else
                 {
                     Console.WriteLine("There is no door that way!");
                 }
                 goto top;
             }
             else if (command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                }
                else if (command.Contains("flee") || command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                }
             else if (command.Contains("inventory"))
             {
                 Stat.Items();
                 goto top;
             }
             else if (command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                }
             else if (command.Contains("chest"))
             {
                 if (chest & unopened) 
                 {
                     Dungeon.OpenChest();
                     unopened = false;
                     goto top;

                 }
                 else
                 {
                     Console.WriteLine("There is no chest here.");
                     goto top;
                 }
             }
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        private static void OpenChest() 
        {
            Random Chest = new Random();
            int treasure = Chest.Next(20);
            switch (treasure) 
            {
                case 1:
                    Console.WriteLine("You got health potion!");
                    Stat.Inventory.Add("health potion");
                    break;
                case 2:
                    Console.WriteLine("You got 50 XP!");
                    Stat.exp = Stat.exp + 50;
                    break;
                case 3:
                    Console.WriteLine("You got 10 gold!");
                    Stat.gold = Stat.gold + 10;
                    break;
                case 4:
                    Console.WriteLine("You got 35 gold");
                    Stat.gold = Stat.gold + 35;
                    break;
                case 5:
                    Console.WriteLine("You got 76 copper");
                    Stat.copper = Stat.copper + 76;
                    break;
                case 6:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 7:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 8:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 9:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 10:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 11:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 12:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 13:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 14:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                case 15:
                    Console.WriteLine("You got health potion");
                    Stat.Inventory.Add("health potion");
                    break;
                default:
                    Console.WriteLine("There was nothing inside.");
                    break;
            }
            return;
        }
        public static void DungeonMonsters()
         {
             Random Monsterspawn = new Random();
             int Mob = Monsterspawn.Next(10);
             Random mlvl = new Random();
             Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
             Random LIF = new Random();
             Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
             switch (Mob)
             {
                 case 1:
                     Console.WriteLine("A level {0} Shadow Ooze appears and attacks!", Stat.monsterlevel);
                     Stat.Monster = "Shadow Ooze";
                     Stat.mcopper = 10;
                     Stat.msilver = 7;
                     Stat.mgold = 5;
                     Stat.exp = 25;
                     Stat.combat();
                     if (Stat.fleeing)
                     {
                         Stat.fleeing = false;
                         return;
                     }
                     break;
                 case 2:
                     Console.WriteLine("A level {0} shadow troll appears and attacks!", Stat.monsterlevel);
                     Stat.Monster = "shadow troll";
                     Stat.mcopper = 5;
                     Stat.msilver = 3;
                     Stat.mgold = 2;
                     Stat.exp = 10;
                     Stat.combat();
                     if (Stat.fleeing)
                     {
                         Stat.fleeing = false;
                         return;
                     }
                     break;
                 case 3:
                     Console.WriteLine("A level {0} Dungeon Ooze appears and attacks!", Stat.monsterlevel);
                     Stat.Monster = "Dungeon Ooze";
                     Stat.mcopper = 7;
                     Stat.msilver = 4;
                     Stat.mgold = 3;
                     Stat.exp = 15;
                     Stat.combat();
                     if (Stat.fleeing)
                     {
                         Stat.fleeing = false;
                         return;
                     }
                     break;
                 case 4:
                     Console.WriteLine("A level {0} shadow viper appears and attacks!", Stat.monsterlevel);
                     Stat.Monster = "shadow viper";
                     Stat.mcopper = 3;
                     Stat.msilver = 1;
                     Stat.mgold = 0;
                     Stat.exp = 5;
                     Stat.combat();
                     if (Stat.fleeing)
                     {
                         Stat.fleeing = false;
                         return;
                     }
                     break;
                 default:
                     break;
             }
         }
        
    }
    static class Stat
    {
        public static bool Level1Completed;
        public static List<string> Inventory = new List<string>();
        public static List<string> Weapons = new List<string>();
        public static List<string> Books = new List<string>();
        public static List<string> Fish = new List<string>();
        public static List<string> Achievements = new List<string>();
        public static string name;
        public static int copper;
        public static int silver;
        public static int gold;
        public static string Monster;
        public static int STR;
        public static int DMG;
        public static int monsterlevel;
        public static int monsterHealth;
        public static int mcopper;
        public static int msilver;
        public static int mgold;
        public static int exp;
        public static int XPTillLevelUp;
        public static int nogo;
        public static int Atk;
        public static bool fleeing;
        public static bool openedchest;
        public static int wealthy;
        public static int kinggoldfishdefeated;
        public static int megayuleoozedefeated;
        public static bool wonthegame;
        public static int maxplayerHealth;
        public static int playerHealth;
        public static int playerLevel;
        public static int playerXP;
        public static void stats()
        {
            Console.WriteLine("Health: {0} ----- Level: {1} ----- XP: {2}",playerHealth, playerLevel, playerXP);
            return;
        }
        public static void help()
        {
            Console.WriteLine("");
            Console.WriteLine("-=-=-=-Help-=-=-=-");
            Console.WriteLine("Movements:");
            Console.WriteLine("Go north = move 1 space north");
            Console.WriteLine("Go south = move 1 space south");
            Console.WriteLine("Go east  = move 1 space east");
            Console.WriteLine("Go west  = move 1 space west");
            Console.WriteLine("Go inside = move inside the structure");
            Console.WriteLine("");
            Console.WriteLine("Combat:");
            Console.WriteLine("attack with (item) = Uses (item) in battle");
            Console.WriteLine("attack = attacks a foe");
            Console.WriteLine("flee = run from battle");
            Console.WriteLine("");
            Console.WriteLine("Inventory:");
            Console.WriteLine("drop (item) = drops the specified item");
            Console.WriteLine("drop = prompts you for an item to drop");
            Console.WriteLine("use (item) = uses the item specified");
            Console.WriteLine("");
            Console.WriteLine("Other commands:");
            Console.WriteLine("Take (item) = takes an item if on the ground");
	    Console.WriteLine("save = saves your game");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            return;
        }
        public static void save()
        {
            string savefolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            try
            {
                using (StreamWriter savefile = new StreamWriter(savefolder + @"\Lulatech\TheLandofAmphisar\Saves\Savegame.txt"))
                {
                    savefile.WriteLine(name.ToString());
                    foreach (string item in Inventory)
                    {
                        savefile.WriteLine(item);
                    }
                    savefile.WriteLine("");
                    foreach (string item in Weapons)
                    {
                        savefile.WriteLine(item);
                    }
                    savefile.WriteLine("");
                    foreach (string item in Fish)
                    {
                        savefile.WriteLine(item);
                    }
                    savefile.WriteLine("");
                    foreach (string item in Books)
                    {
                        savefile.WriteLine(item);
                    }
                    savefile.WriteLine("");
                    savefile.WriteLine(maxplayerHealth.ToString());
                    savefile.WriteLine(playerHealth.ToString());
                    savefile.WriteLine(playerXP.ToString());
                    savefile.WriteLine(playerLevel.ToString());
                    savefile.WriteLine(copper.ToString());
                    savefile.WriteLine(silver.ToString());
                    savefile.WriteLine(gold.ToString());
                    savefile.WriteLine(XPTillLevelUp.ToString());
                    savefile.WriteLine(nogo.ToString());
                    savefile.WriteLine(openedchest.ToString());
                    Console.WriteLine("Done saving!");
                    return;

                }
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Error: game is not installed on this system!");
                return;
            }
        }
        public static void Items()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("--Inventory--");
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("---Weapons---");
            foreach (string item in Weapons)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("-----Fish-----");
            foreach (string item in Fish)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("----Books----");
            foreach (string item in Books)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("----Wealth----");
            Console.WriteLine("Copper: {0}", copper);
            Console.WriteLine("Silver: {0}", silver);
            Console.WriteLine("Gold: {0}", gold);
            Console.WriteLine("");
            invcommands();
            return;
        }
        private static void invcommands()
        {
            Console.WriteLine("");
            Console.WriteLine("What do you want to do? or type achievements to view your achievements. or type exit to exit the inventory menu.");
            string invcommand = Console.ReadLine().ToLower();
            if (invcommand == "drop")
            {
                Console.WriteLine("drop what?");
                string itemtodrop = Console.ReadLine().ToLower();
                if (Inventory.Contains(itemtodrop))
                {
                    Inventory.Remove(itemtodrop);
                    Console.WriteLine("dropped");
                    invcommands();
                }
                else if (Weapons.Contains(itemtodrop))
                {
                    Weapons.Remove(itemtodrop);
                    Console.WriteLine("dropped");
                    invcommands();
                } else
                {
                    Console.WriteLine("You don't have the {0}", itemtodrop);
                    invcommands();
                }
            }
            else if (invcommand.Contains("drop"))
            {
                string itemtodrop = invcommand.Replace("drop ", "");
                if (Inventory.Contains(itemtodrop))
                {
                    Inventory.Remove(itemtodrop);
                    Console.WriteLine("dropped");
                    invcommands();
                }
                else
                {
                    Console.WriteLine("You don't have the {0}", itemtodrop);
                    invcommands();
                }
            }
            else if(invcommand.Contains("use")) 
            {
                string itemtouse = invcommand.Replace("use ", "");
                if (Inventory.Contains(itemtouse))
                {
                    switch (itemtouse)
                    {
                        case "health potion":
                            Console.WriteLine("You drink the potion and restore 10 life");
                            playerHealth = playerHealth + 10;
                            if (playerHealth > maxplayerHealth) 
                            {
                                playerHealth = maxplayerHealth;
                            }
                            Inventory.Remove("health potion");
                            invcommands();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You don't have the {0}", invcommand);
                    invcommands();
                }
            }
            else if (invcommand == "achievements")
            {
                Console.Clear();
                Console.WriteLine("------Achievements------");
                if (kinggoldfishdefeated == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("King Goldfish - Defeat a King Goldfish");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("King Goldfish - defeated {0} times", kinggoldfishdefeated);
                }
                if (megayuleoozedefeated == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Mega Yule Ooze - Defeat a Mega Yule Ooze");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Mega Yule Ooze - defeated {0} times", megayuleoozedefeated);
                }
                if (wealthy == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Wealthy - Get 100 copper, silver, and gold pieces");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wealthy - You are rich!");
                }
                if (!wonthegame)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Hero of Amphisar - Beat the game");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Hero of Amphisar!");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Items();
            }
            else if (invcommand == "exit")
            {
                return;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", invcommand);
                invcommands();
            }
        }
        public static void combat()
        {
            switch (Monster)
            {
                case "forest ooze":
                    DMG = 4 * monsterlevel;
                    break;
                case "rock ooze":
                    DMG = 4 * monsterlevel;
                    break;
                case "grassland ooze":
                    DMG = 4 * monsterlevel;
                    break;
                case "water ooze":
                    DMG = 4 * monsterlevel;
                    break;
                case "goat":
                    DMG = 2 * monsterlevel;
                    break;
                case "wolf":
                    DMG = 3 * monsterlevel;
                    break;
                case "troll":
                    DMG = 5 * monsterlevel;
                    break;
                case "orc":
                    DMG = 4 * monsterlevel;
                    break;
                case "bear":
                    DMG = 5 * monsterlevel;
                    break;
                case "snake":
                    DMG = 1 * monsterlevel;
                    break;
                case "piranah":
                    DMG = 3 * monsterlevel;
                    break;
                case "goldfish":
                    DMG = 0;
                    break;
            }
            Random dmg = new Random();
            int Damage = dmg.Next(DMG);
            Console.WriteLine("The {0} attacks and deals {1} damage!", Monster, Damage);
            playerHealth = playerHealth - Damage;
            if (playerHealth <= 0)
            {
                Console.ReadKey();
                GameOver();
            }
            else
            {
            combatpt2();
            }
            if (fleeing)
            {
                return;
            }
        }
        public static void GameOver()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Game Over".PadLeft(1002, ' '));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The Shadow Mage has sent the land into darkness. Amphisar has fallen.".PadLeft(75, ' '));
            Console.ReadKey();
            Environment.Exit(0);
        }
        public static void combatpt2()
        {
            string combatcommand = Console.ReadLine();

            if (combatcommand == "attack")
            {
                if (Weapons.Count == 0)
                {
                    STR = 2;
                }
                else
                {
                Console.WriteLine("With what?");
                string weapon = Console.ReadLine().ToLower();
                if (Weapons.Contains(weapon.ToLower()))
                {
                    switch (weapon.ToLower())
                    {
                        case "sword":
                            STR = 25;
                            break;
                        case "axe":
                            STR = 10;
                            break;
                        case "stick":
                            STR = 4;
                            break;
                    }    
                }
                else if (Inventory.Contains(weapon.ToLower()))
                {
                    Console.WriteLine("You can't attack with that!");
                    combatpt2();
                }
                else
                {
                    Console.WriteLine("You don't have the {0}", weapon);
                    combatpt2();
                }
                }
               
                Random Strength = new Random();
                Atk = Strength.Next(STR) * (playerLevel + 1);
                monsterHealth = monsterHealth - Atk;
            }
            else if (combatcommand.Contains("attack with"))
            {
                string itemtoattack = combatcommand.Replace("attack with ", "");
                if (Weapons.Contains(itemtoattack))
                {
                    switch (itemtoattack)
                    {
                        case "sword":
                            STR = 25;
                            break;
                        case "axe":
                            STR = 10;
                            break;
                        case "stick":
                            STR = 4;
                            break;
                    }
                    Random Strength = new Random();
                    Atk = Strength.Next(STR) * (playerLevel + 1);
                    monsterHealth = monsterHealth - Atk;
                }
                else
                {
                    Console.WriteLine("You don't have the {0}", itemtoattack);
                    combatpt2();
                }
            }
            else if (combatcommand == "flee")
            {
                Random fleechance = new Random();
                int doyouflee = fleechance.Next(3);
                switch(doyouflee)
                {
                    case 2: 
                        Console.WriteLine("You ran from the {0}.", Monster);
                        fleeing = true;
                        break;
                    default:
                        Console.WriteLine("You can't run!");
                        combat();
                        break;
                }
		        
            }
            else
            {
                Console.WriteLine("You can't {0} during a battle!", combatcommand);
                combat();
            }
            if (fleeing)
            {
                
                return;
            }
            else if (monsterHealth <= 0)
            {
                Console.WriteLine("You dealt {0} damage to the {1}", Atk, Monster);
                Console.WriteLine("The {0} has been defeated", Monster);
		if(Monster.Contains("legendary"))
		{
		    switch(Monster)
		    {
			case "legendary king goldfish":
                kinggoldfishdefeated = kinggoldfishdefeated + 1;
                break;
            case "legendary mega yule ooze":
                megayuleoozedefeated = megayuleoozedefeated + 1;
                break;
			
		    }
		
		}
                Random rawXP = new Random();
                int XP = rawXP.Next(exp) * monsterlevel;
                Console.WriteLine("You earned {0} XP", XP);
                playerXP = playerXP + XP;
		        XPTillLevelUp = XPTillLevelUp - XP;
                if (XPTillLevelUp <= 0)
                {
                    LevelUp();
                }
                Random moneys = new Random(); 
                Random drops = new Random();
                int monsterdrop = drops.Next(25);
                if (monsterdrop <= 5)
                {
                    int droppedcopper = moneys.Next(mcopper * monsterlevel);
                    Console.WriteLine("You got {0} copper from the {1}", droppedcopper, Monster);
                    copper = copper + droppedcopper;
                    return;
                }
                else if (monsterdrop <= 7)
                {
                    int droppedsilver = moneys.Next(msilver * monsterlevel);
                    Console.WriteLine("You got {0} silver from the {1}", droppedsilver, Monster);
                    silver = silver + droppedsilver;
                    return;
                }
                else if (monsterdrop == 8)
                {
                    int droppedgold = moneys.Next(mgold * monsterlevel);
                    Console.WriteLine("You got {0} gold from the {1}", droppedgold, Monster);
                    gold = gold + droppedgold;
                    return;
                }
                if (copper >= 100 && silver >= 100 && gold >= 100)
                {
                    wealthy = 1;
                }
                
                    
            }
            else
            {
                Console.WriteLine("You dealt {0} damage to the {1}", Atk, Monster);
                combat();
            }
            
        }
        private static void LevelUp()
        {
            playerLevel = playerLevel + 1;
            XPTillLevelUp = XPTillLevelUp + (playerLevel * 100);
            Console.WriteLine("You are now level {0}", playerLevel);
            Random extralife = new Random();
            maxplayerHealth = maxplayerHealth + extralife.Next(5);
            playerHealth = maxplayerHealth;
            Console.WriteLine("Your maxhealth is now {0}",playerHealth);
        }
    }
    static class Book 
    {
        public static void fishjournal()
        {
            Console.Clear();
            Console.WriteLine("{0}'s fishing journal");
            string page1a = "Salmon - small fish that are common in rivers";

            return;
        }

    }
    static class Amphisar
   {
        static bool boulderscrushed;
        static string command;
        static void Main(string[] args)
        {
            Console.Title = "The Land of Amphisar: Rise of the Shadow Mage";
            Console.WriteLine("Beta V.0.5.4");
            Console.WriteLine("Welcome, Press any key to contunue.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Would you like to create a new character, or continue an old one?");
            string continueornaw = Console.ReadLine().ToLower();
            if (continueornaw == "continue")
            {
                try
                {
                string savefolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                using (StreamReader savefile = new StreamReader(savefolder + @"\Lulatech\TheLandofAmphisar\Saves\Savegame.txt"))
                {
                    Stat.name = savefile.ReadLine();
                    bool openinginventory = true;
                    while (openinginventory == true)
                    {
                        string item = savefile.ReadLine();
                        if (item != "")
                        {
                            Stat.Inventory.Add(item);
                        }
                        else
                        {
                            openinginventory = false;
                        }
                    }
                    bool openingweapons = true;
                    while (openingweapons == true)
                    {
                        string item = savefile.ReadLine();
                        if (item != "")
                        {
                            Stat.Weapons.Add(item);
                        }
                        else
                        {
                            openingweapons = false;
                        }
                    }
                    bool openingfish = true;
                    while (openingfish == true)
                    {
                        string item = savefile.ReadLine();
                        if (item != "")
                        {
                            Stat.Fish.Add(item);
                        }
                        else
                        {
                            openingfish = false;
                        }
                    }
                    bool openingbooks = true;
                    while (openingbooks == true)
                    {
                        string item = savefile.ReadLine();
                        if (item != "")
                        {
                            Stat.Books.Add(item);
                        }
                        else
                        {
                            openingweapons = false;
                        }
                    }
                    
                    Stat.maxplayerHealth = Convert.ToInt32(savefile.ReadLine());
                    Stat.playerHealth = Convert.ToInt32(savefile.ReadLine());
                    Stat.playerXP = Convert.ToInt32(savefile.ReadLine());
                    Stat.playerLevel = Convert.ToInt32(savefile.ReadLine());
                    Stat.copper = Convert.ToInt32(savefile.ReadLine());
                    Stat.silver = Convert.ToInt32(savefile.ReadLine());
                    Stat.gold = Convert.ToInt32(savefile.ReadLine());
                    Stat.XPTillLevelUp = Convert.ToInt32(savefile.ReadLine());
                    Stat.nogo = Convert.ToInt32(savefile.ReadLine());
                    Stat.openedchest = Convert.ToBoolean(savefile.ReadLine());
                    Console.WriteLine("Welcome back, {0}", Stat.name);
                    acre33();
                }
            } catch(DirectoryNotFoundException){
                Console.WriteLine("Error: game is not installed on this system!");
            }
            }
            else
            { 
            Console.WriteLine("Enter your name:");
            Stat.name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("{0}, press any key to enter the land of Amphisar", Stat.name);
            Console.ReadKey();
            Stat.maxplayerHealth = 20;
            Stat.playerLevel = 1;
            Stat.playerHealth = 20;
            Stat.XPTillLevelUp = 50;
            Console.Clear();
            acre33();

            }
           
        
        }
        public static void acre11()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("There is a temple here atop the high mountains.");
            command11();
        }
        private static void command11()
        {
            top:
            command = Console.ReadLine().ToLower();
                if(command.Contains("west"))
                {
                    Console.WriteLine("The mountians are impassible to the west.");
                    goto top;
                } else if(command.Contains("east"))
                {
                    acre12();
                } else if(command.Contains("south"))
                {
                    acre21();
                } else if(command.Contains("north"))
                {
                    Console.WriteLine("The mountians are impassible to the north.");
                    goto top;
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                }
                else if (command.Contains("fish"))
                {
                    Console.WriteLine("There is no water here!");
                    goto top;
                }
                else if (command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                }
                else if (command.Contains("temple") || command.Contains("inside") || command.Contains("dungeon"))
                {
                    Level1.Room1();
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }  
        static void acre12()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a mountainous area.");
            command12();
        }
        private static void command12()
        {
            MountainMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    if (Stat.Inventory.Contains("climbing gear"))
                    {
                        acre11();
                    }
                    else
                    {
                        Console.WriteLine("There is a temple in the distance, but it is too dangerous to go without climbing gear.");
                        goto top;
                    }
                } else if(command.Contains("east"))
                {
                    acre13();
                } else if(command.Contains("south"))
                {
                    acre22();
                } else if(command.Contains("north"))
                {
                    Console.WriteLine("The mountians are impassible to the north.");
                    goto top;
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                }
                else if (command.Contains("fish"))
                {
                    Console.WriteLine("There is no water here!");
                    goto top;
                }
                else if (command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre13()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a forest. There is a small shop here.");
            command13();
        }
        private static void command13()
        {
            ForestMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre12();
                } else if(command.Contains("east"))
                {
                    acre14();
                } else if(command.Contains("south"))
                {
                    acre22();
                } else if(command.Contains("north"))
                {
                    Console.WriteLine("The forest is too dense to travel any further north.");
                    goto top;
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                }
                else if (command.Contains("fish"))
                {
                    Console.WriteLine("There is no water here!");
                    goto top;
                }
                else if (command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("inside"))
		{
		    Shop13();
		} else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        private static void Shop13()
        {
            Console.WriteLine("There is a health potion for 25 copper pieces.");
            Console.WriteLine("There is climbing gear for 15 gold pieces.");
            Console.WriteLine("There is a silver piece for 10 copper pieces.");
            Console.WriteLine("There is a gold piece for 10 silver pieces");
            Console.WriteLine("");
            Console.WriteLine("Shopkeeper: What would you like? Or type exit to leave my shop.");
            string buy = Console.ReadLine();
            switch (buy)
            {
                case "health potion":
                    if (Stat.copper >= 25)
                    {
                        Console.WriteLine("Here you go! A sword! That will be 25 copper pieces");
                        Stat.copper = Stat.copper - 100;
                        Stat.Inventory.Add("health potion");
                        Shop13();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop13();
                    }
                    break;
                case "climbing gear":
                    if (Stat.gold > 15)
                    {
                        Console.WriteLine("Here you go! Climbing gear! That will be 15 gold pieces");
                        Stat.gold = Stat.gold - 15;
                        Stat.Inventory.Add("climbing gear");
                        Shop13();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop13();
                    }
                    break;
                case "silver":
                    if (Stat.copper > 10)
                    {
                        Console.WriteLine("1 silver piece for 10 copper!");
                        Stat.copper = Stat.copper - 10;
                        Stat.silver = Stat.silver + 1;
                        Shop13();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop13();
                    }
                    break;
                case "gold":
                    if (Stat.silver > 10)
                    {
                        Console.WriteLine("1 gold piece for 10 silver!");
                        Stat.silver = Stat.silver - 10;
                        Stat.gold = Stat.gold + 1;
                        Shop13();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop13();
                    }
                    break;
                case "exit":
                    acre13();
                    break;
                default:
                    Console.WriteLine("I don't have a {0} in stock!", buy);
                    Shop13();
                    break;
                
            }
        }
        static void acre14()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("There is a river.");
            command14();
        }
        private static void command14()
        {
            RiverMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre13();
                } else if(command.Contains("east"))
                {
		    Console.WriteLine("You find a safe way to ford the river");
                    acre15();
                } else if(command.Contains("south"))
                {
                    acre24();
                } else if(command.Contains("north"))
                {
                    Console.WriteLine("The forest is too dense to travel any further north.");
                    goto top;
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                }
                else if (command.Contains("fish"))
                {
                    Console.WriteLine("There is no water here!");
                    goto top;
                }
                else if (command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre15()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("After fording the river, you see a fishing shack");
            command15();
        }
	    private static void command15()
	{
	top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre14();
                } else if(command.Contains("east"))
                {
                    acre16();
                    goto top;
                } else if(command.Contains("south"))
                {
                    Console.WriteLine("The river is too deep to ford safely.");
                    goto top;
                } else if(command.Contains("north"))
                {
                    Console.WriteLine("The forest is too dense to travel any further north.");
                    goto top;
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                }
                else if (command.Contains("fish"))
                {
                    fish();
                    goto top;
                }
                else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        private static void fish()
        {
            if (Stat.Inventory.Contains("fishing rod"))
            {
                Random fishy = new Random();
                int fishtocatch = fishy.Next(10);
                string fish = "nothing";
                switch (fishtocatch)
                {
                    case 1:
                        fish = "nothing";
                        break;
                    case 2:
                        fish = "salmon";
                        break;
                    case 3:
                        fish = "salmon";
                        break;
                    case 4:
                        fish = "salmon";
                        break;
                    case 5:
                        fish = "nothing";
                        break;
                    case 6:
                        fish = "piranha";
                        break;
                    case 7:
                        fish = "goldfish";
                        break;
                    case 8:
                        fish = "nothing";
                        break;
                    case 9:
                        fish = "nothing";
                        break;
                    case 10:
                        fish = "nothing";
                        break;
                }
                Console.WriteLine("You caught a {0}!", fish);
                if (fish == "nothing")
                {
                    return;
                }
                else
                {
                    Stat.Fish.Add(fish);

                    return;
                }
            }
            else
            {
                Console.WriteLine("You need a fishing rod for that!");
                return;
            }
        }
	    private static void shop15()
	{
        if (!Stat.Books.Contains("fishing journal"))
        {	
	        Console.WriteLine("Shopkeeper: Hello! Welcome to my fishing hut! This is your first time, so here you go! Your own fish journal! You can read it to see all the fish you've caught!");
            Stat.Books.Add("fishing journal");
	    }
	    Console.WriteLine("There is a fishing rod 5 gold pieces.");
            Console.WriteLine("There is a silver piece for 10 copper pieces.");
            Console.WriteLine("There is a gold piece for 10 silver pieces");
            Console.WriteLine("");
            Console.WriteLine("Shopkeeper: What would you like? or type sell to sell me some fish. Or type exit to leave my shop.");
            string shop = Console.ReadLine().ToLower();
            switch (shop)
            {
		case "sell":
		    Console.WriteLine("Let's see what you have for me...");
            if (Stat.Fish.Contains("salmon"))
            {
			Console.WriteLine("I'll buy a salmon for 10 copper");
            }
            if (Stat.Fish.Contains("goldfish"))
            {
			Console.WriteLine("I'll buy a goldfish for 10 copper");
		    }
            if (Stat.Fish.Contains("piranha"))
            {
			Console.WriteLine("I'll buy a piranha for 15 copper");
            }
            sell:
            Console.WriteLine("What do you want to sell? or type exit to exit the sell menu.");
            string sell = Console.ReadLine();
            switch (sell)
            {
                case "goldfish":
                    if (Stat.Fish.Contains("goldfish"))
                    {
                        Stat.Fish.Remove("goldfish");
                        Stat.copper = Stat.copper + 20;
                        Console.WriteLine("Thank you!");
                        goto sell;
                    }
                    else
                    {
                        Console.WriteLine("You have none!");
                        goto sell;
                    }
                    break;
                case "salmon":
                    if (Stat.Fish.Contains("salmon"))
                    {
                        Stat.Fish.Remove("salmon");
                        Stat.copper = Stat.copper + 10;
                        Console.WriteLine("Thank you!");
                        goto sell;
                    }
                    else
                    {
                        Console.WriteLine("You have none!");
                        goto sell;
                    }
                    break;
                case "piranha":
                    if (Stat.Fish.Contains("piranha"))
                    {
                        Stat.Fish.Remove("piranha");
                        Stat.copper = Stat.copper + 20;
                        Console.WriteLine("Thank you!");
                        goto sell;
                    }
                    else
                    {
                        Console.WriteLine("You have none!");
                        goto sell;
                    }
                    break;
                case "exit":
                    shop15();
                    break;
                default:
                    Console.WriteLine("I don't know what that is, but I don't want it!");
                    goto sell;
                    break;
            } 
		    break;
                case "fishing rod":
            if (Stat.gold >= 5)
                    {
                        Console.WriteLine("Here you go! A Fishing Rod! That will be 5 gold pieces");
                        Stat.gold = Stat.gold - 5;
                        Stat.Inventory.Add("fishing rod");
                        shop15();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        shop15();
                    }
                    break;
                case "silver":
                    if (Stat.copper > 10)
                    {
                        Console.WriteLine("1 silver piece for 10 copper!");
                        Stat.copper = Stat.copper - 10;
                        Stat.silver = Stat.silver + 1;
                        shop15();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        shop15();
                    }
                    break;
                case "gold":
                    if (Stat.silver > 10)
                    {
                        Console.WriteLine("1 gold piece for 10 silver!");
                        Stat.silver = Stat.silver - 10;
                        Stat.gold = Stat.gold + 1;
                        shop15();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        shop15();
                    }
                    break;
                case "exit":
                    command15();
                    break;
                
            }
	}
        static void acre16()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a dense forest");
            command16();
        }
        private static void command16()
        {
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                acre15();
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("The forest is too dense to travel any further east. You have to go around.");
                goto top;
            }
            else if (command.Contains("south"))
            {
                acre26();
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("The forest is too dense to travel any further north.");
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else if (command.Contains("fish"))
            {
                Console.WriteLine("Theres no water here!");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        public static void acre17()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a jungle. A temple stands before you.");
            command16();
        }
        private static void command17()
        {
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                Console.WriteLine("The forest-jungle is too dense to travel any further west.");
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("The jungle is too dense to travel any further east.");
                goto top;
            }
            else if (command.Contains("south"))
            {
                acre27();
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("The jungle is too dense to travel any further north.");
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("temple") || command.Contains("inside") || command.Contains("dungeon"))
            {
                Level2.Room1();
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else if (command.Contains("fish"))
            {
                Console.WriteLine("Theres no water here!");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }

        static void acre21()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("Rugged mountains lay before you.");
            command21();
        }
        private static void command21()
        {
            MountainMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    Console.WriteLine("The mountains are impassible to the west");
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre22();
                } else if(command.Contains("south"))
                {
                    acre31();
                } else if(command.Contains("north"))
                {
                    if (Stat.Inventory.Contains("climbing gear"))
                    {
                        acre11();
                    }
                    else
                    {
                        Console.WriteLine("There is a temple in the distance, but it is too dangerous to go without climbing gear.");
                        goto top;
                    }
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre22()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a mountainous area");
            command22();
        }
        private static void command22()
        {
            MountainMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre21();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre23();
                } else if(command.Contains("south"))
                {
                    acre32();
                } else if(command.Contains("north"))
                {
                    acre12();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre23()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("There is a large tree in the middle of the forest.");
            command23();

        }
        private static void command23()
        {
            ForestMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre22();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre24();
                } else if(command.Contains("south"))
                {
                    acre33();
                } else if(command.Contains("north"))
                {
                    acre13();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("climb"))
                {
                    commandtree();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        private static void commandtree()
        {
            Console.WriteLine("You are up a tree.");
            if (!Stat.Inventory.Contains("egg"))
            {
                Console.WriteLine("There is an egg in a nest");
            }
            command = Console.ReadLine();
            switch (command)
            {
                case "take egg":
                    if (!Stat.Inventory.Contains("egg"))
                    {
                        Console.WriteLine("Taken.");
                        Stat.Inventory.Add("egg");
                    }
                    else
                    {
                        Console.WriteLine("There is no egg here");
                    }
                    
                    commandtree();
                    break;
                case "take nest":
                    Console.WriteLine("Why do you want a nest?");
                    commandtree();
                    break;
                case "jump":
                    acre23();
                    break;
                case "climb down":
                    acre23();
                    break;
                case "inventory":
                    Stat.Items();
                    commandtree();
                    break;
                default:
                    Console.WriteLine("I don't know what {0} means", command);
                    commandtree();
                    break;
            }
        }
        static void acre24()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are at the edge of the forest. There is a river to the east.");
            command24();
        }
        private static void command24()
        {
            MountainMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre23();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre25();
                } else if(command.Contains("south"))
                {
                    acre34();
                } else if(command.Contains("north"))
                {
                    acre14();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre25()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are near a river.");
            command25();
        }
        private static void command25()
        {
            RiverMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre24();
		    goto top;
                } else if(command.Contains("east"))
                {
                    Console.WriteLine("The forest is too dense to travel any further east");
		    goto top;
                } else if(command.Contains("south"))
                {
                    acre35();
                } else if(command.Contains("north"))
                {
                    Console.WriteLine("The river is too deep to ford safely.");
		    goto top;
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre26()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in the shadow forest");
            command26();
        }
        private static void command26()
        {
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                acre26();
            }
            else if (command.Contains("east"))
            {
                acre26();
                goto top;
            }
            else if (command.Contains("south"))
            {
                acre26();
                goto top;
            }
            else if (command.Contains("north"))
            {
                acre16();
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else if (command.Contains("fish"))
            {
                Console.WriteLine("Theres no water here!");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre27()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a jungle. Large boulders stand before you.");
            if (boulderscrushed)
            {
                Console.Write(" The boulders have been crushed.");
            }
            command27();
        }
        private static void command27()
        {
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                Console.WriteLine("the jungle is too dense to pass through to the west.");
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("the jungle is too dense to pass through to the east.");
                goto top;
            }
            else if (command.Contains("south"))
            {
                acre37();
                goto top;
            }
            else if (command.Contains("north"))
            {
                if (boulderscrushed)
                {
                    acre16();
                }
                else
                {
                    Console.WriteLine("You can't get past the boulders.");
                }
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else if (command.Contains("break") || command.Contains("pickaxe") || command.Contains("destroy"))
            {
                if (Stat.Inventory.Contains("pickaxe"))
                {
                    boulderscrushed = true;
                    Console.WriteLine("Cou crush the boulders with your pickaxe");
                }
                else
                {
                    Console.WriteLine("You need a pickaxe to break the boulders.");
                }
                
                goto top;
            }
            else if (command.Contains("fish"))
            {
                Console.WriteLine("Theres no water here!");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }

        static void acre31()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are on a mountain");
            command31();
        }
        private static void command31()
        {
            MountainMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    Console.WriteLine("The mountains are impassible to the west.");
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre32();
                } else if(command.Contains("south"))
                {
                    acre41();
                } else if(command.Contains("north"))
                {
                    acre21();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre32()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are near a mountain in a forest");
            command32();
        }
        private static void command32()
        {
            ForestMonsters();
	    top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre31();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre33();
                } else if(command.Contains("south"))
                {
                    acre42();
                } else if(command.Contains("north"))
                {
                    acre22();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre33()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a forest clearing.");
            if (!Stat.Inventory.Contains("stick"))
            {
                Console.WriteLine("There is a sturdy stick in the dirt.");
            }

            command33();
        }
        private static void command33()
        {
            ForestMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre32();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre34();
                } else if(command.Contains("south"))
                {
                    acre43();
                } else if(command.Contains("north"))
                {
                    acre23();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    if(command.Contains("stick")){
                        Stat.Weapons.Add("stick");
			Console.WriteLine("taken.");
		    }
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre34()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("Forest.");
            command34();
        }
        private static void command34()
        {
            ForestMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre33();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre35();
                } else if(command.Contains("south"))
                {
                    if (Stat.Inventory.Contains("flippers"))
                    {
                        acre44();
                    }
                    else
                    {
                        Console.WriteLine("You can't swim without flippers!");
                    }
                    goto top;
                } else if(command.Contains("north"))
                {
                    acre24();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre35()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are at the edge of a forest. There is a river to the north of you that runs south into a lake.");
            if (Stat.Level1Completed)
            {
                Console.Write("A bridge has been built going east.");
            }
            command35();
        }
        private static void command35()
        {
            ForestMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre34();
		    goto top;
                } else if(command.Contains("east"))
                {
                    if (Stat.Level1Completed)
                    {
                        acre36();
                    }
		    goto top;
                } else if(command.Contains("south"))
                {
                    if (Stat.Inventory.Contains("flippers"))
                    {
                        acre45();
                    }
                    else
                    {
                        Console.WriteLine("You can't swim without flippers!");
                    }
                    goto top;
                } else if(command.Contains("north"))
                {
                    acre25();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre36()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a village. There is a river to the east and a lake to the south. There is a bridge");
            command36();
        }
        private static void command36()
        {
            ForestMonsters();
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                acre35();
                goto top;
            }
            else if (command.Contains("east"))
            {
                if (Stat.Level1Completed)
                {
                    acre37();
                }
                goto top;
            }
            else if (command.Contains("south"))
            {
                if (Stat.Inventory.Contains("flippers"))
                {
                    acre46();
                }
                else
                {
                    Console.WriteLine("You can't swim without flippers!");
                }
                goto top;
            }
            else if (command.Contains("north"))
            {
                Console.WriteLine("The forest is too dense to go any further north!");
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre37()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a village. There are three buildings: A shop, a house, and a town center. There is someone outside.");
            command37();
        }
        private static void command37()
        {
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                acre35();
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("The forest is too dense to go any further east.");
                goto top;
            }
            else if (command.Contains("south"))
            {
                acre47();
            }
            else if (command.Contains("north"))
            {
                acre27();
                goto top;
            }
            else if (command.Contains("shop"))
            {
                Shop37();
            }
            else if (command.Contains("house"))
                House37();
            else if (command.Contains("town") || command.Contains("center"))
                TownCenter37();
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            if (command.Contains("talk") || command.Contains("say") || command.Contains("person"))
            {
                Random talk = new Random();
                int speech = talk.Next(5);
                switch (speech)
                {
                    case 1:
                        Console.WriteLine("Ampharian: Hello. I live here.");
                        break;
                    case 2:
                        Console.WriteLine("Ampharian: The old man has a pickaxe he doesn't want.");
                        break;
                    case 3:
                        Console.WriteLine("Ampharian: The Shadow Mage has really corrupted the world, but our little town remains untouched.");
                        break;
                    case 4:
                        Console.WriteLine("Ampharian: In the shop you can buy a lantern, needed for night and cave travels.");
                        break;
                    case 5:
                        Console.WriteLine("Ampharian: Have you ever been outside of Amphisar? I haven't!");
                        break;
                }
                
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        private static void TownCenter37()
        {
            Console.WriteLine("You are in the town center building. There is someone in the building. Type exit to exit.");
        town:
            command = Console.ReadLine();
            if (command.Contains("talk") || command.Contains("say") || command.Contains("person"))
            {
                Console.WriteLine("Ampharian: Hello. This is the town center.");
                goto town;
            }
            else if (command.Contains("exit") || command.Contains("leave"))
            {
                acre37();
            }
            else
            {
                Console.WriteLine("You can't do that in the town center!");
            }
            goto town;
        }
        private static void House37()
        {
            Console.WriteLine("You are in a small house. There is someone in the house. type exit to exit.");
        house:
            command = Console.ReadLine();
            if (command.Contains("talk") || command.Contains("say") || command.Contains("person"))
            {
                if (!Stat.Inventory.Contains("pickaxe"))
                {
                    Console.WriteLine("Ampharian: I used to be a miner, but now i don't need this.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You got the pickaxe.");
                    Stat.Inventory.Add("pickaxe");
                    goto house;
                }
                else
                {
                    Console.WriteLine("Ampharian: I used that pickaxe to crush boulders in the jungle!");
                }
                goto house;
            }
            else if (command.Contains("exit") || command.Contains("leave"))
            {
                acre37();
            }
            else if (command.Contains("kill") || command.Contains("fight"))
            {
                Console.WriteLine("Why would you do that to the old man?");
                goto house;
            }
            else
            {
                Console.WriteLine("You can't do that in the house!");
            }
            goto house;
        }
        private static void Shop37()
        {
            Console.WriteLine("There is a health potion for 25 copper pieces.");
            Console.WriteLine("There is a sword for 15 gold pieces.");
            Console.WriteLine("There is a silver piece for 10 copper pieces.");
            Console.WriteLine("There is a gold piece for 10 silver pieces");
            Console.WriteLine("");
            Console.WriteLine("Shopkeeper: What would you like? Or type exit to leave my shop.");
            string buy = Console.ReadLine();
            switch (buy)
            {
                case "health potion":
                    if (Stat.copper >= 25)
                    {
                        Console.WriteLine("Here you go! A health potion! That will be 25 copper pieces");
                        Stat.copper = Stat.copper - 100;
                        Stat.Inventory.Add("health potion");
                        Shop37();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop37();
                    }
                    break;
                case "sword":
                    if (Stat.gold > 15)
                    {
                        Console.WriteLine("Here you go! A sword! That will be 15 gold pieces");
                        Stat.gold = Stat.gold - 15;
                        Stat.Weapons.Add("sword");
                        Shop13();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop37();
                    }
                    break;
                case "silver":
                    if (Stat.copper > 10)
                    {
                        Console.WriteLine("1 silver piece for 10 copper!");
                        Stat.copper = Stat.copper - 10;
                        Stat.silver = Stat.silver + 1;
                        Shop37();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop37();
                    }
                    break;
                case "gold":
                    if (Stat.silver > 10)
                    {
                        Console.WriteLine("1 gold piece for 10 silver!");
                        Stat.silver = Stat.silver - 10;
                        Stat.gold = Stat.gold + 1;
                        Shop37();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for that!");
                        Shop37();
                    }
                    break;
                case "exit":
                    acre37();
                    break;

            }
        }

        static void acre41()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a flat area");
            command41();
        }
        private static void command41()
        {
            PlainsMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    Console.WriteLine("the mountains are impassible to the west");
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre42();
                } else if(command.Contains("south"))
                {
                    Console.WriteLine("The rocks are too large to pass through");
                    Stat.nogo = Stat.nogo + 1;
                    if (Stat.nogo == 5)
                    {
		        acre51();
		    }
		    goto top;
                } else if(command.Contains("north"))
                {
                    acre31();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre42()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a flat area.");
            command42();
        }
        private static void command42()
        {
            PlainsMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre41();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre43();
                } else if(command.Contains("south"))
                {
                    Console.WriteLine("you can't go that way");
		    goto top;
                } else if(command.Contains("north"))
                {
                    acre32();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre43()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a flat area.");
            command43();
        }
        private static void command43()
        {
            PlainsMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre42();
		    goto top;
                } else if(command.Contains("east"))
                {
                    if (Stat.Inventory.Contains("flippers"))
                    {
                        acre44();
                    }
                    else
                    {
                        Console.WriteLine("You can't swim without flippers!");
                    }
                    goto top;
                } else if(command.Contains("south"))
                {
                    Console.WriteLine("you can't go that way");
		    goto top;
                } else if(command.Contains("north"))
                {
                    acre33();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre44()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a lake.");
            command44();
        }
        private static void command44()
        {
            PlainsMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre43();
		    goto top;
                } else if(command.Contains("east"))
                {
                    acre45();
                } else if(command.Contains("south"))
                {
                    Console.WriteLine("you can't go that way");
		    goto top;
                } else if(command.Contains("north"))
                {
                    acre34();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre45()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a lake.");
            command45();
        }
        private static void command45()
        {
            PlainsMonsters();
            top:
            command = Console.ReadLine();
                if(command.Contains("west"))
                {
                    acre44();
		    goto top;
                } else if(command.Contains("east"))
                {
                    Console.WriteLine("The icy tundra is impossible to pass to the east");
		    goto top;
                } else if(command.Contains("south"))
                {
                    Console.WriteLine("you can't go that way");
		    goto top;
                } else if(command.Contains("north"))
                {
                    acre35();
                } else if(command.Contains("inventory"))
                {
                    Stat.Items();
		    goto top;
                } else if(command.Contains("attack"))
                {
                    Console.WriteLine("you aren't in danger!");
                    goto top;
                } else if(command.Contains("flee"))
                {
                    Console.WriteLine("There is nothing to run from!");
                    goto top;
                } else if(command.Contains("inside"))
                {
                    shop15();
                } else if(command.Contains("save"))
                {
                    Stat.save();
                    goto top;
                } else if(command.Contains("help"))
                {
                    Stat.help();
                    goto top;
                } else if(command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
                {
                    Console.WriteLine("There is nothing here to take");
                    goto top;
                } else
                {
                    Console.WriteLine("I don't know what {0} means",command);
                    goto top;
                } 
            }
        static void acre46()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a lake.");
            command46();
        }
        private static void command46()
        {
            ForestMonsters();
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                Console.WriteLine("You can't go there");
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("You can't go there");
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("You can't go there");
            }
            else if (command.Contains("north"))
            {
                acre36();
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre47()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a village. There are three buildings: A shop, a house, and a town center");
            command47();
        }
        private static void command47()
        {
            ForestMonsters();
        top:
            command = Console.ReadLine();
            if (command.Contains("south"))
            {
                if (Stat.Inventory.Contains("flippers"))
                {
                    acre57();
                }
                else
                {
                    Console.WriteLine("You can't swim!");
                }
                goto top;
            }
            else if (command.Contains("east"))
            {
                Console.WriteLine("The river is too deep to ford safely!");
                goto top;
            }
            else if (command.Contains("west"))
            {
                Console.WriteLine("The forest is too dense to pass through");
            }
            else if (command.Contains("north"))
            {
                acre37();
                goto top;
            }
            else if (command.Contains("house"))
            {
                Console.WriteLine("You are in a small house. There is someone in the house.");
            house:
                command = Console.ReadLine();
                if (command.Contains("talk") || command.Contains("say") || command.Contains("person"))
                {
                    Console.WriteLine("Ampharian: I used to be a miner, but now i don't need this.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You got the pickaxe.");
                    Stat.Inventory.Add("pickaxe");
                    goto house;
                }
                else if (command.Contains("exit") || command.Contains("leave"))
                {
                    goto top;
                }
                else
                {
                    Console.WriteLine("You can't do that in the house!");
                }
                goto house;
            }
            else if (command.Contains("town center"))
            {
                Console.WriteLine("You are in the town center. There is someone in the house.");
            house:
                command = Console.ReadLine();
                if (command.Contains("talk") || command.Contains("say") || command.Contains("person"))
                {
                    Console.WriteLine("Ampharian: .");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You got the pickaxe.");
                    Stat.Inventory.Add("pickaxe");
                    goto house;
                }
                else if (command.Contains("exit") || command.Contains("leave"))
                {
                    goto top;
                }
                else
                {
                    Console.WriteLine("You can't do that in the house!");
                }
                goto house;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre51()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a cave. There is a chest. There is a dungeon entrance");
            if (Stat.openedchest)
            {
                Console.WriteLine("The chest is opened");
            }
            commandcave();
        }
        static void acre52() 
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a rocky area.");
            command52();
        }
        private static void command52()
        {
            PlainsMonsters();
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                Console.WriteLine("The large mountain makes it impossible to go west");
                goto top;
            }
            else if (command.Contains("east"))
            {
                acre53();
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("you can't go that way");
                goto top;
            }
            else if (command.Contains("north"))
            {
                acre42();
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("inside"))
            {
                shop15();
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre53() 
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are in a rocky area. There is a lake to the east.");
            command53();
        }
        private static void command53()
        {
            PlainsMonsters();
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                acre52();
                goto top;
            }
            else if (command.Contains("east"))
            {
                if (Stat.Inventory.Contains("flippers"))
                {
                    acre54();
                }
                else 
                {
                    Console.WriteLine("You can't swim without flippers!");
                }
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("you can't go that way");
                goto top;
            }
            else if (command.Contains("north"))
            {
                acre43();
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("inside"))
            {
                shop15();
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("fish"))
            {
                fish();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre54()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are swimming in the lake.");
        }
        private static void command54()
        {
            RiverMonsters();
        top:
            command = Console.ReadLine();
            if (command.Contains("west"))
            {
                acre53();
                goto top;
            }
            else if (command.Contains("east"))
            {
                if (Stat.Inventory.Contains("flippers"))
                {
                    acre55();
                }
                else
                {
                    Console.WriteLine("You can't swim without flippers!");
                }
                goto top;
            }
            else if (command.Contains("south"))
            {
                Console.WriteLine("you can't go that way");
                goto top;
            }
            else if (command.Contains("north"))
            {
                acre44();
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                goto top;
            }
            else if (command.Contains("attack"))
            {
                Console.WriteLine("you aren't in danger!");
                goto top;
            }
            else if (command.Contains("flee"))
            {
                Console.WriteLine("There is nothing to run from!");
                goto top;
            }
            else if (command.Contains("inside"))
            {
                shop15();
            }
            else if (command.Contains("save"))
            {
                Stat.save();
                goto top;
            }
            else if (command.Contains("help"))
            {
                Stat.help();
                goto top;
            }
            else if (command.Contains("fish"))
            {
                fish();
                goto top;
            }
            else if (command.Contains("take") || command.Contains("grab") || command.Contains("pick up"))
            {
                Console.WriteLine("There is nothing here to take");
                goto top;
            }
            else
            {
                Console.WriteLine("I don't know what {0} means", command);
                goto top;
            }
        }
        static void acre55()
        {
            Console.WriteLine("");
            Stat.stats();
            Console.WriteLine("You are on an island in the middle of the lake. There is a temple here.");
            //command55();
        }
        static void acre56()
        {
 
        }
        static void acre57()
        {

        }
        static void commandcave() 
        {
            string command = Console.ReadLine().ToLower();
            if (command.Contains("chest"))
            {
                if (Stat.openedchest == false)
                {
                    Stat.openedchest = true;
                    Console.WriteLine("You open the chest.");
                    Console.WriteLine("There is a health potion");
                    Console.WriteLine("There is a health potion");
                    Console.WriteLine("There is an axe");
                    Console.WriteLine("There is a fishing rod");
                    Console.WriteLine("There is 100 gold");
                    Stat.gold = Stat.gold + 100;
                    Stat.Inventory.Add("health potion");
                    Stat.Inventory.Add("health potion");
                    Stat.Inventory.Add("fishing rod");
                    Stat.Weapons.Add("axe");
                    commandcave();
                }
                else
                {
                    Console.WriteLine("It is already opened.");
                    commandcave();
                }
            }
            else if (command.Contains("north"))
            {
                acre41();
            }
            else if (command.Contains("inventory"))
            {
                Stat.Items();
                commandcave();
            }
            else if (command.Contains("dungeon"))
            {
                Dungeon.GenerateRoom();
                commandcave();
            }
            else
            {
                Console.WriteLine("You can't do that in the cave!!!");
                commandcave();
            }
        }
        public static void DungeonRun()
        {
            Console.WriteLine("You exit the dungeon.");
            acre51();
        }

        static void ForestMonsters()
        {
            if (DateTime.Now.Date.Equals(12.25))
            {
                HolidayMonsters();
                return;
            }
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(10);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} forest ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "forest ooze";
                    Stat.mcopper = 10;
                    Stat.msilver = 7;
                    Stat.mgold = 5;
                    Stat.exp = 25;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("A level {0} wolf appears and growls at you!", Stat.monsterlevel);
                    Stat.Monster = "wolf";
                    Stat.mcopper = 5;
                    Stat.msilver = 3;
                    Stat.mgold = 2;
                    Stat.exp = 10;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} bear appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "bear";
                    Stat.mcopper = 7;
                    Stat.msilver = 4;
                    Stat.mgold = 3;
                    Stat.exp = 15;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} snake appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "snake";
                    Stat.mcopper = 3;
                    Stat.msilver = 1;
                    Stat.mgold = 0;
                    Stat.exp = 5;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                default:
                    return;
                    break;
            }
        }
        static void MountainMonsters()
        {
            if (DateTime.Now.Date.Equals(12.25))
            {
                HolidayMonsters();
                return;
            } Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} goat appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "goat";
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("A level {0} troll appears and growls at you!", Stat.monsterlevel);
                    Stat.Monster = "troll";
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} rock ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "rock ooze";
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} snake appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "snake";
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
            }
        }
        static void RiverMonsters()
        {
            if (DateTime.Now.Date.Equals(12.25))
            {
                HolidayMonsters();
                return;
            }
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} piranah appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "piranah";
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
		    Random megaspawn = new Random();
		    int bossspawn = megaspawn.Next(100);
		    if(bossspawn == 10){
			Console.WriteLine("A legendary king goldfish appears and attacks!");
            Stat.Monster = "legendary king goldfish";
            Stat.mcopper = 50;
            Stat.msilver = 30;
            Stat.mgold = 25;
            Stat.exp = 100;
            Stat.DMG = 1;
            Stat.combat();
            if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
		    }
            Stat.monsterHealth = Stat.monsterHealth + 50;
            Console.WriteLine("A level {0} goldfish appears and growls at you!", Stat.monsterlevel);
            Stat.Monster = "goldfish";
            Stat.combat();
            if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} water ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "water ooze";
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
            }
        }
        static void PlainsMonsters()
        {
if(DateTime.Now.Date.Equals(12.25))
{
HolidayMonsters();
return;
}
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} grassland ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "grassland ooze";
                    Stat.mcopper = 10;
                    Stat.msilver = 7;
                    Stat.mgold = 5;
                    Stat.exp = 25;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("A level {0} troll appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "troll";
                    Stat.mcopper = 5;
                    Stat.msilver = 3;
                    Stat.mgold = 2;
                    Stat.exp = 10;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} Orc appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "orc";
                    Stat.mcopper = 7;
                    Stat.msilver = 4;
                    Stat.mgold = 3;
                    Stat.exp = 15;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} snake appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "snake";
                    Stat.mcopper = 3;
                    Stat.msilver = 1;
                    Stat.mgold = 0;
                    Stat.exp = 5;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
        static void TempleMonsters()
        {
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
                    Console.WriteLine("A level {0} shadow ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "shadow ooze";
                    Stat.mcopper = 10;
                    Stat.msilver = 7;
                    Stat.mgold = 5;
                    Stat.exp = 25;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("A level {0} troll appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "troll";
                    Stat.mcopper = 5;
                    Stat.msilver = 3;
                    Stat.mgold = 2;
                    Stat.exp = 10;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} Orc appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "orc";
                    Stat.mcopper = 7;
                    Stat.msilver = 4;
                    Stat.mgold = 3;
                    Stat.exp = 15;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} shadow viper appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "shadow viper";
                    Stat.mcopper = 3;
                    Stat.msilver = 1;
                    Stat.mgold = 0;
                    Stat.exp = 5;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
        static void HolidayMonsters()
        {
            Random Monsterspawn = new Random();
            int Mob = Monsterspawn.Next(10);
            Random mlvl = new Random();
            Stat.monsterlevel = Stat.playerLevel + mlvl.Next(3);
            Random LIF = new Random();
            Stat.monsterHealth = Stat.monsterlevel * LIF.Next(5);
            switch (Mob)
            {
                case 1:
		    Random megaspawn = new Random();
		    int bossspawn = megaspawn.Next(25);
		    if(bossspawn == 10){
			Console.WriteLine("A legendary mega yule ooze appears and attacks!");
            Stat.Monster = "legendary mega yule ooze";
            Stat.mcopper = 50;
            Stat.msilver = 30;
            Stat.mgold = 25;
            Stat.exp = 100;
            Stat.DMG = 4;
            Stat.monsterHealth = Stat.monsterHealth + 50;
            Stat.combat();
            if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
		    }
            Console.WriteLine("A level {0} yule ooze appears and attacks!", Stat.monsterlevel);
            Stat.Monster = "mega yule ooze";
            Stat.mcopper = 10;
            Stat.msilver = 7;
            Stat.mgold = 5;
                    Stat.exp = 25;
                    Stat.DMG = 4;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("A level {0} present hound appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "present hound";
                    Stat.mcopper = 5;
                    Stat.msilver = 3;
                    Stat.mgold = 2;
                    Stat.exp = 10;
                    Stat.DMG = 3;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("A level {0} fruitcake ooze appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "fruitcake ooze";
                    Stat.mcopper = 7;
                    Stat.msilver = 4;
                    Stat.mgold = 3;
                    Stat.exp = 15;
                    Stat.DMG = 5;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("A level {0} snowball orc appears and attacks!", Stat.monsterlevel);
                    Stat.Monster = "snowball orc";
                    Stat.mcopper = 3;
                    Stat.msilver = 1;
                    Stat.mgold = 0;
                    Stat.exp = 5;
                    Stat.DMG = 3;
                    Stat.combat();
                    if (Stat.fleeing)
                    {
                        Stat.fleeing = false;
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
        
    }
}