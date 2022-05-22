using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class TeamManager
    {
        private Teams[] teams;
        private int numTeams;
        private int maxTeams;

        public TeamManager(int maxTeams)
        {
            this.maxTeams = maxTeams;
            numTeams = 0;
            teams = new Teams[maxTeams];
        }

        public int getNumTeams()
        {
            return numTeams;
        }

        public string getTeamName(int teamId)
        {
            return teams[teamId].teamName;
        }

        public int getTeamRegion(int teamId)
        {
            return teams[teamId].teamRegion;
        }

        public int[] GetTeamMembers(int teamId)
        {
            return teams[teamId].teamMembers;
        }

        public bool addTeam(int teamId, string teamName, int teamRegion, int[] teamMembers)
        {
            if (numTeams < maxTeams)
            {
                teams[numTeams] = new Teams(teamId, teamName, teamRegion, teamMembers);
                numTeams++;
                return true;
            }
            return false;
        }

        public int searchTeams(int teamId)
        {
            if (numTeams > 0)
            {
                for (int i = 0; i < numTeams; i++)
                {
                    if (teams[i].getTeamId() == teamId)
                    {
                        return i;
                    }
                }
            }
            else
            {
                return -1;
            }
            return teamId;
        }

        public string getTeamInfo(int teamId)
        {
            string success = "-End of List-";
            string failure = "Team Does Not Exist";
            int result = searchTeams(teamId);
            if (result != -1)
            {
                Console.WriteLine("Region Key:\n[1=ON, 2=AB, 3=BC, 4=MB, 5=NS, 6=NB, 7=QC, 8=SK]\n\n");
                for (int i = 0; i < numTeams; i++)
                {
                    Console.WriteLine(teams[i].ToString());
                    Console.WriteLine("\n");
                }
                return success;
            }
            else
            {
                return failure;
            }
        }

        public bool delTeam(int teamId)
        {
            int search = searchTeams(teamId);
            if (search == -1)
            {
                return false;
            }
            teams[search] = teams[numTeams - 1];
            numTeams--;
            return true;
        }
    }
}
