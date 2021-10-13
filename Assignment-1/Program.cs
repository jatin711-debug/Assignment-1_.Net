using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        private static List<BaseballPlayer> baseBallList = new List<BaseballPlayer>(50)
            { new BaseballPlayer("Shaw",21,"CA",2,21,122) };

        private static List<BasketballPlayer> basketBallList = new List<BasketballPlayer>(50)
            { new BasketballPlayer("Maw", 11, "India", 2, 12, 122) };

        private static List<HockeyPlayer> hockeyList = new List<HockeyPlayer>(50) 
            { new HockeyPlayer("Joseff", 0, "US", 54, 45, 23) };

        static int hockeyCount = 1;
        static int basketCount = 11;
        static int baseCount = 21;

        //Player Search

        private static void searchForPlayer()
        {
            Console.WriteLine("Enter Player:\n");
            string res = Console.ReadLine();
            foreach(HockeyPlayer obj in hockeyList)
            {
                if (obj.PlayerName.Contains(res))
                {
                    Console.WriteLine(obj);
                }
            }
            foreach (BaseballPlayer obj in baseBallList)
            {
                if (obj.PlayerName.Contains(res))
                {
                    Console.WriteLine(obj);
                }
            }
            foreach (BasketballPlayer obj in basketBallList)
            {
                if (obj.PlayerName.Contains(res))
                {
                    Console.WriteLine(obj);
                }
            }

            DisplayMenu();
        }


        //add methods

        public static void addToBaseballList(int key,ref BaseballPlayer obj)
        {
            baseBallList.Insert(key,obj);
        }

        public static void addToHockeyList(int key,ref HockeyPlayer obj)
        {
            hockeyList.Insert(key, obj);
        }

        public static void addToBasketList(int key ,ref BasketballPlayer obj)
        {
            basketBallList.Insert(key, obj);
        }

        // Show Methods

        public static void showHockeyList()
        {
            Console.WriteLine("Hockey Players :\n");

            Console.WriteLine("PlayerId\t PlayerName\t TeamName \tGames Played\t Assist\t Goals\t Points\n");
            foreach (var data in hockeyList)
            {
                Console.WriteLine($"{data.PlayerId}\t \t{data.PlayerName}\t \t{data.TeamName}\t \t{data.GamesPlayed}\t \t{data.Assist} \t{data.Goals} \t{data.GetPoints()}\n");
            }
        }


        public static void showbasketBallList()
        {
            Console.WriteLine("BasketBall Players :\n");
            Console.WriteLine("PlayerId\t PlayerName\t TeamName \tGames Played\t FieldGoals\t ThreePointers\t Points\n");
            foreach (var data in basketBallList)
            {
                Console.WriteLine($"{data.PlayerId}\t \t{data.PlayerName}\t \t{data.TeamName}\t \t{data.GamesPlayed}\t \t{data.FieldGoals}\t \t{data.ThreePointer}\t \t{data.GetPoints()}\n");
            }
        }

        public static void showBaseBallList()
        {
            Console.WriteLine("BaseBall Players :\n");
            Console.WriteLine("PlayerId\t PlayerName\t TeamName \tGamesPlayed\t Runs\t HomeRuns\t Points\n");
            foreach (var data in baseBallList)
            {
                Console.WriteLine($"{data.PlayerId}\t\t {data.PlayerName}\t\t {data.TeamName}\t \t{data.GamesPlayed}\t\t {data.Runs}\t\t {data.HomeRuns}\t {data.GetPoints()} \n");
            }
        }

        //Delete Options Methods

        private static void DeleteHockeyPlayer()
        {
            showHockeyList();
            Console.WriteLine("Enter ID:");
            int res = int.Parse(Console.ReadLine());
            hockeyList.RemoveAt(res);
            showHockeyList();
            DisplayMenu();
        }

        private static void DeleteBaseBallPlayer()
        {
            showBaseBallList();
            Console.WriteLine("Enter ID:");
            int res = int.Parse(Console.ReadLine());
            baseBallList.RemoveAt(res-21);
            showBaseBallList();
            DisplayMenu();
        }

        private static void DeleteBasketBallPlayer()
        {
            showbasketBallList();
            Console.WriteLine("Enter ID:");
            int res = int.Parse(Console.ReadLine());
            basketBallList.RemoveAt(res - 11);
            showbasketBallList();
            DisplayMenu();
        }


        //Edit Options


        private static void EditHockeyPlayer()
        {
            showHockeyList();
            Console.WriteLine("Enter Player ID->");
            int res = int.Parse(Console.ReadLine());
            hockeyList.RemoveAt(res);
            AddHockeyPlayer(res);
        }

        private static void EditBaseBallPlayer()
        {
            showBaseBallList();
            Console.WriteLine("Enter Player ID->");
            int res = int.Parse(Console.ReadLine());
            baseBallList.RemoveAt(res - 21);
            AddBaseBallPlayer(res);
        }

        private static void EditBasketBallPlayer()
        {
            showbasketBallList();
            Console.WriteLine("Enter Player ID->");
            int res = int.Parse(Console.ReadLine());
            basketBallList.RemoveAt(res - 11);
            AddBasketBallPlayer(res);
        }

        //Add Player Methods

        public static void AddHockeyPlayer(int key)
        {
            hockeyList.RemoveAt(key);
            HockeyPlayer hockeyPlayer;
            string PlayerName;
            int PlayerId;
            string TeamName;
            int GamesPlayed;
            int Assist;
            int Goals;
            

            try
            {
                Console.WriteLine("Enter Player Name:");
                PlayerName = Console.ReadLine();
                PlayerId = key;
                Console.WriteLine("\nEnter Team name:");
                TeamName = Console.ReadLine();
                Console.WriteLine("\nGames Played");
                GamesPlayed = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAssist");
                Assist = int.Parse(Console.ReadLine());
                Console.WriteLine("\nGoals");
                Goals = int.Parse(Console.ReadLine());

                hockeyPlayer = new HockeyPlayer(PlayerName, PlayerId, TeamName, GamesPlayed, Assist, Goals);
                addToHockeyList(key,ref hockeyPlayer);
                Console.WriteLine("\n1 Player Updated:");
                showHockeyList();
                DisplayMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Vaild Input");
                AddHockeyPlayer();
            }
        }

        public static void AddHockeyPlayer()
        {
            
            HockeyPlayer hockeyPlayer;
            string PlayerName;
            int PlayerId;
            string TeamName;
            int GamesPlayed;
            int Assist;
            int Goals;

            try
            {
                
                Console.WriteLine("Enter Player Name:");
                PlayerName = Console.ReadLine();
                
                Console.WriteLine("\nEnter Team name:");
                TeamName = Console.ReadLine();
                Console.WriteLine("\nGames Played");
                GamesPlayed = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAssist");
                Assist = int.Parse(Console.ReadLine());
                Console.WriteLine("\nGoals");
                Goals = int.Parse(Console.ReadLine());
                PlayerId = hockeyCount;
                hockeyCount = hockeyCount + 1;

                hockeyPlayer = new HockeyPlayer(PlayerName, PlayerId, TeamName, GamesPlayed, Assist, Goals);
                addToHockeyList(PlayerId,ref hockeyPlayer);
                Console.WriteLine("\n1 Player Updated:");
                showHockeyList();
                DisplayMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Vaild Input");
                AddHockeyPlayer();
            }
        }

        public static void AddBasketBallPlayer()
        {
            BasketballPlayer basketballPlayer;
            string PlayerName;
            int PlayerId;
            string TeamName;
            int GamesPlayed;
            int FieldGoals;
            int ThreePointer;

            try
            {
                Console.WriteLine("Enter Player Name:");
                PlayerName = Console.ReadLine();
                Console.WriteLine("\nEnter Team name:");
                TeamName = Console.ReadLine();
                Console.WriteLine("\nGames Played");
                GamesPlayed = int.Parse(Console.ReadLine());
                Console.WriteLine("\nFieldGoals");
                FieldGoals = int.Parse(Console.ReadLine());
                Console.WriteLine("\nThreePointerS");
                ThreePointer = int.Parse(Console.ReadLine());
                PlayerId = ++basketCount;
              

                basketballPlayer = new BasketballPlayer(PlayerName, PlayerId, TeamName, GamesPlayed, FieldGoals, ThreePointer);
                basketBallList.Add(basketballPlayer);
                Console.WriteLine("\n1 Player Updated:");
                basketCount = basketCount++;
                showbasketBallList();
                DisplayMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Vaild Input");
                AddBasketBallPlayer();
            }
        }

        public static void AddBasketBallPlayer(int key)
        {
            BasketballPlayer basketballPlayer;
            string PlayerName;
            int PlayerId;
            string TeamName;
            int GamesPlayed;
            int FieldGoals;
            int ThreePointer;

            try
            {
                int duplicateKey = (key - 11);
                Console.WriteLine("Enter Player Name:");
                PlayerName = Console.ReadLine();
                PlayerId = key;
                Console.WriteLine("\nEnter Team name:");
                TeamName = Console.ReadLine();
                Console.WriteLine("\nGames Played");
                GamesPlayed = int.Parse(Console.ReadLine());
                Console.WriteLine("\nFieldGoals");
                FieldGoals = int.Parse(Console.ReadLine());
                Console.WriteLine("\nThreePointerS");
                ThreePointer = int.Parse(Console.ReadLine());

                basketballPlayer = new BasketballPlayer(PlayerName, PlayerId, TeamName, GamesPlayed, FieldGoals, ThreePointer);
                addToBasketList(duplicateKey, ref basketballPlayer);
                Console.WriteLine("\n1 Player Updated:"); 
                showbasketBallList();
                DisplayMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Vaild Input");
                AddBasketBallPlayer();
            }
        }

        public static void AddBaseBallPlayer()
        {
            BaseballPlayer baseballPlayer;
            string PlayerName;
            int PlayerId;
            string TeamName;
            int GamesPlayed;
            int Runs;
            int HomeRuns;

            try
            {
                Console.WriteLine("Enter Player Name:");
                PlayerName = Console.ReadLine();
                Console.WriteLine("\nEnter Team name:");
                TeamName = Console.ReadLine();
                Console.WriteLine("\nGames Played");
                GamesPlayed = int.Parse(Console.ReadLine());
                Console.WriteLine("\nRuns");
                Runs = int.Parse(Console.ReadLine());
                Console.WriteLine("\nHomeRuns");
                HomeRuns = int.Parse(Console.ReadLine());

                PlayerId = ++baseCount;

                baseballPlayer = new BaseballPlayer(PlayerName, PlayerId, TeamName, GamesPlayed, Runs, HomeRuns);
                baseBallList.Add(baseballPlayer);
                Console.WriteLine("\n1 Player Updated:");
                showBaseBallList();
                baseCount = baseCount++;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Vaild Input");
                AddBaseBallPlayer();
            }
            finally
            {
                DisplayMenu();
            }
        }

        public static void AddBaseBallPlayer(int key)
        {
            BaseballPlayer baseballPlayer;
            string PlayerName;
            int PlayerId;
            string TeamName;
            int GamesPlayed;
            int Runs;
            int HomeRuns;

            try
            {
                int duplicate = key;
                Console.WriteLine("Enter Player Name:");
                PlayerName = Console.ReadLine();
                PlayerId = key;
                duplicate = (key - 21);
                Console.WriteLine("\nEnter Team name:");
                TeamName = Console.ReadLine();
                Console.WriteLine("\nGames Played");
                GamesPlayed = int.Parse(Console.ReadLine());
                Console.WriteLine("\nRuns");
                Runs = int.Parse(Console.ReadLine());
                Console.WriteLine("\nHomeRuns");
                HomeRuns = int.Parse(Console.ReadLine());

                baseballPlayer = new BaseballPlayer(PlayerName, PlayerId, TeamName, GamesPlayed, Runs, HomeRuns);
                addToBaseballList(duplicate,ref baseballPlayer);
                Console.WriteLine("\n1 Player Updated:");
                showBaseBallList();
                DisplayMenu();
            }

            catch (Exception e)
            {
                Console.WriteLine("Please Enter Vaild Input");
                AddBaseBallPlayer();
            }
        }



        //Options 


        private static void showAddPlayerOptions()
        {
            int result = 0;
            Console.WriteLine("Enter From Below Option\n");
            Console.WriteLine("1. Add A Hockey Player\n");
            Console.WriteLine("2. Add A BaseBall Player\n");
            Console.WriteLine("3. Add A BasketBall Player\n");
            Console.WriteLine("4. back To Menu\n");
            Console.WriteLine("Enter A Value: ->");

            try
            {
                result = int.Parse(Console.ReadLine());
                if (result < 1 || result > 3)
                {
                    throw new ArgumentException();
                }
                switch (result)
                {
                    case 1:
                        {
                            AddHockeyPlayer();
                            break;
                        }
                    case 2:
                        {
                            AddBaseBallPlayer();
                            break;
                        }
                    case 3:
                        {
                            AddBasketBallPlayer();
                            break;
                        }
                    case 4:
                        DisplayMenu();
                        break;
                    default: break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter A valid Input..\n");
                showAddPlayerOptions();
            }

        }

        private static void showDeletePlayerOptions()
        {
            int result = 0;
            Console.WriteLine("Enter From Below Option\n");
            Console.WriteLine("1. Delete A Hockey Player\n");
            Console.WriteLine("2. Delete A BaseBall Player\n");
            Console.WriteLine("3. Delete A BasketBall Player\n");
            Console.WriteLine("4. Delete To Menu\n");
            Console.WriteLine("Enter A Value: ->");

            try
            {
                result = int.Parse(Console.ReadLine());
                if (result < 1 || result > 3)
                {
                    throw new ArgumentException();
                }
                switch (result)
                {
                    case 1:
                        {
                            DeleteHockeyPlayer();
                            break;
                        }
                    case 2:
                        {
                            DeleteBaseBallPlayer();
                            break;
                        }
                    case 3:
                        {
                            DeleteBasketBallPlayer();
                            break;
                        }
                    case 4:
                        DisplayMenu();
                        break;
                    default: break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter A valid Input..\n");
                showAddPlayerOptions();
            }

        }

        private static void showEditPlayerOptions()
        {
            int result = 0;
            Console.WriteLine("Enter From Below Option\n");
            Console.WriteLine("1. Edit A Hockey Player\n");
            Console.WriteLine("2. Edit A BaseBall Player\n");
            Console.WriteLine("3. Edit A BasketBall Player\n");
            Console.WriteLine("4. back To Menu\n");
            Console.WriteLine("Enter A Value: ->");

            try
            {
                result = int.Parse(Console.ReadLine());
                if (result < 1 || result > 3)
                {
                    throw new ArgumentException();
                }
                switch (result)
                {
                    case 1:
                        {
                            EditHockeyPlayer();
                            break;
                        }
                    case 2:
                        {
                            EditBaseBallPlayer();
                            break;
                        }
                    case 3:
                        {
                            EditBasketBallPlayer();
                            break;
                        }
                    case 4:
                        DisplayMenu();
                        break;

                    default: throw new ArgumentException();
                 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter A valid Input..\n");
                showEditPlayerOptions();
            }
        }

        private static void showViewPlayerOptions()
        {
            showBaseBallList();
            showbasketBallList();
            showHockeyList();
            DisplayMenu();
        }


        //for Handling userInput

        private static void UserInput(int value)
        {
            switch (value)
            {
                case 1:
                    {
                        showAddPlayerOptions();
                    }
                    break;
                case 2:
                    {
                        showEditPlayerOptions();
                        break;
                    }
                case 3:
                    {
                        showDeletePlayerOptions();
                        break;
                    }
                case 4:
                    {
                        showViewPlayerOptions();
                        break;
                    }
                case 5:
                    {
                        searchForPlayer();
                        break;
                    }

                default:
                    DisplayMenu();
                    break;
            }
        }

        //Basic Diaplay Menu

        private static void DisplayMenu()
        {
            Console.WriteLine("\t \t Assignment 1 By Jatin Mahajan\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine("1: Add A Player");
            Console.WriteLine("2: Edit A Player");
            Console.WriteLine("3: Delete A Player");
            Console.WriteLine("4: View Players");
            Console.WriteLine("5: Search A Player");
            Console.WriteLine("0: Exit From Program \n");
            Console.WriteLine("Enter Your Choice -> ");

            try
            {
                int res = int.Parse(Console.ReadLine());

                if (res > 5 || res < 0)
                {
                    throw new ArgumentException();
                }
                else if (res == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    UserInput(res);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter a Valid Input. try again ...|\n");
                DisplayMenu();
            }
        }

        static void Main(string[] args)
        {
            Program.DisplayMenu();
        }
    }
}
