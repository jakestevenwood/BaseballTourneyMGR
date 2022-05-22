using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class TeamMemManager
    {
        private TeamMembers[] teamMembers;
        private int numMembers;
        private int maxMembers;

        public TeamMemManager(int maxMem)
        {
            maxMembers = maxMem = 9;
            numMembers = 0;
            teamMembers = new TeamMembers[maxMembers];
        }

        public int getNumMem()
        {
            return numMembers;
        }

        public string getMemName(int memId)
        {
            return teamMembers[memId].memName;
        }

        public int getOnTeamId(int memId)
        {
            return teamMembers[memId].onTeamId;
        }

        public int getPosition(int memId)
        {
            return teamMembers[memId].memPosition;
        }


        public bool addMember(string memName, int memId, int onTeamId, int memPosition)
        {
            if (numMembers<maxMembers)
            {
                teamMembers[numMembers] = new TeamMembers(memName, memId, onTeamId, memPosition);
                numMembers++;
                return true;
            }
            return false;
        }

        public int searchMem(int memId)
        {
            if (numMembers>0)
            {
                for (int i=0; i<numMembers; i++)
                {
                    if (teamMembers[i].getMemId() == memId)
                    {
                        return i;
                    }
                }
            }
            else
            {
                return -1;
            }
            return memId;
        }

        public string getMemInfo(int memId)
        {
            string success = "-End of List-";
            string failure = "Team Member Does Not Exist";
            int result = searchMem(memId);
            if (result!=-1)
            {
                Console.WriteLine("Position Key:\n[1=Catcher, 2=Pitcher, 3=FirstBase, 4=SecondBase, 5=ThirdBase, 6=Shortstop, 7=RightField, 8=LeftField, 9=CenterField]\n\n");
                for (int i=0; i<numMembers; i++)
                {
                    Console.WriteLine(teamMembers[i].ToString());
                    Console.WriteLine("\n");
                }
                return success;
            }
            else
            {
                return failure;
            }
        }

        public bool delMember(int memId)
        {
            int search = searchMem(memId);
            if (search == -1)
            {
                return false;
            }
            teamMembers[search] = teamMembers[numMembers - 1];
            numMembers--;
            return true;
        }

        public void addPlayertoTeam(int memId, int teamId)
        {
            teamMembers[memId].onTeamId = teamId;
        }
    }
}
