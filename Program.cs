using System;
using System.IO;

namespace JakobWood_PartB
{
    class Program
    {
        public static BaseballTournyController baseball = new BaseballTournyController(72, 8, 5);
        public static void teamsMenu()
        {
            Console.Clear();
            Console.WriteLine("----  Teams Menu  ----\n\nPlease Select An Option:\n\n");
            Console.WriteLine("1: View Teams List\n2: Add New Team\n3: Delete Existing Team\n4: Exit");
            int option = invalidOptionSub();
            while (option != 4)
            {
                if (option == 1)
                {
                    getTeamInfo();
                }
                if (option == 2)
                {
                    addTeam();
                }
                if (option == 3)
                {
                    delTeam();
                }
            }
            if (option == 4)
            {
                menu();
            }
        }
        public static void getTeamInfo()
        {
            Console.Clear();
            int teamId = 0;
            Console.WriteLine(baseball.getTeamInfo(teamId));
            Console.WriteLine("\n\nPress Any Key to Exit.");
            Console.ReadKey();
            menu();
        }
        public static void addTeam()
        {
            string teamName;
            int teamRegion;
            int[] teamMembers;
            int numTeams = baseball.teamMan.getNumTeams();
            int teamId;
            Console.Clear();
            Console.WriteLine("<-----------Add New Team---------->\n\n");
            Console.WriteLine("Enter the Team's Name:");
            teamName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter the Team's Region as a Number:\n[1=ON, 2=AB, 3=BC, 4=MB, 5=NS, 6=NB, 7=QC, 8=SK]");
            teamRegion = Convert.ToInt32(Console.ReadLine());
            teamId = numTeams++;
            teamMembers = null;
            if (baseball.addTeam(teamId, teamName, teamRegion, teamMembers))
            {
                Console.WriteLine("Team Added!");
            }
            else
            {
                Console.WriteLine("Failed to Add Team.");
            }
            Console.WriteLine("Press Any Key to Return.");
            Console.ReadKey();
            menu();
        }
        public static void delTeam()
        {
            int numTeams = baseball.teamMan.getNumTeams();
            int teamId = numTeams;
            Console.Clear();
            Console.WriteLine(baseball.getTeamInfo(teamId));
            Console.WriteLine("\n\nPlease Enter Which Team to Delete:");
            teamId = Convert.ToInt32(Console.ReadLine());
            if (baseball.delTeam(teamId))
            {
                Console.WriteLine("Team Deleted!");
            }
            else
            {
                Console.WriteLine("Failed to Delete Team.");
            }
            Console.WriteLine("Press Any Key to Return.");
            Console.ReadKey();
            menu();
        }

        public static void playersMenu()
        {
            Console.Clear();
            Console.WriteLine("----  Players Menu  ----\n\nPlease Select An Option:\n\n");
            Console.WriteLine("1: View Players List\n2: Add New Player\n3: Delete Existing Player\n4: Exit");
            int option = invalidOptionSub();
            while (option != 4)
            {
                if (option == 1)
                {
                    getPlayerInfo();
                }
                if (option == 2)
                {
                    addPlayer();
                }
                if (option == 3)
                {
                    delPlayer();
                }
            }
            if (option == 4)
            {
                menu();
            }
        }
        public static void getPlayerInfo()
        {
            Console.Clear();
            int memId = 0;
            Console.WriteLine(baseball.getMemInfo(memId));
            Console.WriteLine("\n\nPress Any Key to Exit.");
            Console.ReadKey();
            menu();
        }
        public static void addPlayer()
        {
            string memName;
            int memPosition;
            int numMems = baseball.teamMemMan.getNumMem();
            int memId;
            int onTeamId;
            Console.Clear();
            Console.WriteLine("<-----------Add New Player---------->\n\n");
            Console.WriteLine("Enter the Player's Name:");
            memName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Player's Team ID: [If No Teams Registered, Enter -1]");
            onTeamId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Player's Position as a Number:\n[1=Catcher, 2=Pitcher, 3=FirstBase, 4=SecondBase, 5=ThirdBase, 6=Shortstop, 7=RightField, 8=LeftField, 9=CenterField]");
            memPosition = Convert.ToInt32(Console.ReadLine());
            memId = numMems++;
            if (baseball.addMem(memName, memId, onTeamId, memPosition))
            {
                Console.WriteLine("Player Added!");
            }
            else
            {
                Console.WriteLine("Failed to Add Player.");
            }
            Console.WriteLine("Press Any Key to Return.");
            Console.ReadKey();
            menu();
        }
        public static void delPlayer()
        {
            int numMems = baseball.teamMemMan.getNumMem();
            int memId = numMems;
            Console.Clear();
            Console.WriteLine(baseball.getMemInfo(memId));
            Console.WriteLine("\n\nPlease Enter Which Player to Delete:");
            memId = Convert.ToInt32(Console.ReadLine());
            if (baseball.delMem(memId))
            {
                Console.WriteLine("Player Deleted!");
            }
            else
            {
                Console.WriteLine("Failed to Delete Player.");
            }
            Console.WriteLine("Press Any Key to Return.");
            Console.ReadKey();
            menu();
        }

        public static void tournyMenu()
        {
            Console.Clear();
            Console.WriteLine("----  Tournaments Menu  ----\n\nPlease Select An Option:\n\n");
            Console.WriteLine("1: View Tournaments List\n2: Add New Tournament\n3: Delete Existing Tournament\n4: Exit");
            int option = invalidOptionSub();
            while (option != 4)
            {
                if (option == 1)
                {
                    getTournyInfo();
                }
                if (option == 2)
                {
                    addTourny();
                }
                if (option == 3)
                {
                    delTourny();
                }
            }
            if (option == 4)
            {
                menu();
            }
        }
        public static void getTournyInfo()
        {
            Console.Clear();
            int tournyId = 0;
            Console.WriteLine(baseball.getTournyInfo(tournyId));
            Console.WriteLine("\n\nPress Any Key to Exit.");
            Console.ReadKey();
            menu();
        }
        public static void addTourny()
        {
            string tournyName;
            int numTournys = baseball.tournMan.getNumTournys();
            int tournyId=numTournys;
            int[] teamsPlaying = { 0 };
            char option;
            Console.Clear();
            Console.WriteLine("<-----------Add New Tournament (Match)---------->\n\n");
            Console.WriteLine("Enter the Player's Name:");
            tournyName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter the First Competing Team's ID:");
            teamsPlaying[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Competing Team's ID:");
            teamsPlaying[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would You Like to Add More Teams? Please Enter 'y' or 'n' ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y')
            {
                Console.WriteLine("Please Enter the Third Competing Team's ID:");
                teamsPlaying[2] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Would You Like to Add More Teams? Please Enter 'y' or 'n' ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y')
            {
                Console.WriteLine("Please Enter the Fourth Competing Team's ID:");
                teamsPlaying[3] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Would You Like to Add More Teams? Please Enter 'y' or 'n' ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y')
            {
                Console.WriteLine("Please Enter the Fifth Competing Team's ID:");
                teamsPlaying[4] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Would You Like to Add More Teams? Please Enter 'y' or 'n' ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y')
            {
                Console.WriteLine("Please Enter the Sixth Competing Team's ID:");
                teamsPlaying[5] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Would You Like to Add More Teams? Please Enter 'y' or 'n' ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y')
            {
                Console.WriteLine("Please Enter the Seventh Competing Team's ID:");
                teamsPlaying[6] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Would You Like to Add More Teams? Please Enter 'y' or 'n' ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y')
            {
                Console.WriteLine("Please Enter the Eighth Competing Team's ID:");
                teamsPlaying[7] = Convert.ToInt32(Console.ReadLine());
            }
            tournyId = numTournys++;
            if (baseball.addTourny(tournyId, tournyName, teamsPlaying))
            {
                Console.WriteLine("Match Added Added!");
            }
            else
            {
                Console.WriteLine("Failed to Add Match.");
            }
            Console.WriteLine("Press Any Key to Return.");
            Console.ReadKey();
            menu();
        }
        public static void delTourny()
        {
            int numTournys = baseball.tournMan.getNumTournys();
            int tournyId = numTournys;
            Console.Clear();
            Console.WriteLine(baseball.getTournyInfo(tournyId));
            Console.WriteLine("\n\nPlease Enter Which Match to Delete:");
            tournyId = Convert.ToInt32(Console.ReadLine());
            if (baseball.delTourny(tournyId))
            {
                Console.WriteLine("Tournament Deleted!");
            }
            else
            {
                Console.WriteLine("Failed to Delete Tournament.");
            }
            Console.WriteLine("Press Any Key to Return.");
            Console.ReadKey();
            menu();
        }
        public static void registerPlayerstoTeamsMenu()
        {
            int memId;
            int teamId;
            
            Console.WriteLine("Please Enter the Player ID You Want to Assign to a Team:");
            memId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Team ID You Want to Assign to Player Number:" + memId);
            teamId = Convert.ToInt32(Console.ReadLine());
            if (baseball.teamMemMan.searchMem(memId)==-1 || baseball.teamMan.searchTeams(teamId) == -1)
            {
                Console.WriteLine("Player OR Team Doesn't Exist. Failed to Register.");
                Console.ReadKey();
                menu();
            }
            else
            {

                if (baseball.teamMemMan.searchMem(memId) != -1 && baseball.teamMan.searchTeams(teamId) != -1)
                {
                    baseball.teamMemMan.addPlayertoTeam(memId, teamId);
                    Console.WriteLine("Player Registered!");
                }
                else
                {
                    Console.WriteLine("Player OR Team Doesn't Exist. Failed to Register.");
                }
                Console.WriteLine("Press Any Key to Return.");
                Console.ReadKey();
                menu();
            }
        }
        public static int invalidOptionSub()
        {
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || (option < 1 || option > 4))
            {
                Console.WriteLine("Please Select a Valid Option: ");
                option = invalidOptionSub();
                menu();
            }
            return option;
        }
        public static int invalidOptionMain()
        {
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || (option < 1 || option > 5))
            {
                Console.WriteLine("Please Select a Valid Option: ");
                option = invalidOptionMain();
                menu();
            }
            return option;
        }
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("----  Welcome to The Baseball Tournament Registration Manager  ----\n\nPlease Select An Option:\n\n");
            Console.WriteLine("1: Teams Menu\n2: Players Menu\n3: Add Players to Teams\n4: Tournament Menu\n5: Exit");
            int option = invalidOptionMain();
            while (option != 5)
            {
                if (option == 1)
                {
                    teamsMenu();
                }
                if (option == 2)
                {
                    playersMenu();
                }
                if (option == 3)
                {
                    registerPlayerstoTeamsMenu();
                }
                if (option == 4)
                {
                    tournyMenu();
                }
            }
            if (option == 5)
                return;
        }
        static void Main(string[] args)
        {
            int numTeams = baseball.teamMan.getNumTeams();
            int numMems = baseball.teamMemMan.getNumMem();
            int numTournys = baseball.tournMan.getNumTournys();
            menu();
            try
            {
                StreamWriter sw = new StreamWriter("C:\\competitionteams.dat");
                sw.WriteLine("Teams Data\n\n");
                for (int i = 0; i <= numTeams; i++)
                {
                    sw.WriteLine(baseball.teamMan.getTeamInfo(i) + "\n");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Saving Teams Data");
            }
            try
            {
                StreamWriter sw = new StreamWriter("C:\\competitionplayers.dat");
                sw.WriteLine("Players Data\n\n");
                for (int i = 0; i <= numTeams; i++)
                {
                    sw.WriteLine(baseball.teamMemMan.getMemInfo(i) + "\n");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Saving Players Data");
            }
            try
            {
                StreamWriter sw = new StreamWriter("C:\\competitiontournaments.dat");
                sw.WriteLine("Tournaments Data\n\n");
                for (int i = 0; i <= numTeams; i++)
                {
                    sw.WriteLine(baseball.tournMan.getTournyInfo(i) + "\n");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Saving Tournaments Data");
            }
            Console.WriteLine("Thank You. Press Any Key To Exit");
            Console.ReadKey();
            Environment.Exit(-1);
        }
    }
}
