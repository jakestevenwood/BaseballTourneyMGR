using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class TournManager
    {
        private Tournaments[] tournaments;
        private int numTournys;
        private int maxTournys;

        public TournManager(int maxTournys)
        {
            this.maxTournys = maxTournys;
            numTournys = 0;
            tournaments = new Tournaments[maxTournys];
        }

        public int getNumTournys()
        {
            return numTournys;
        }
        public string getTournyName(int tournyId)
        {
            return tournaments[tournyId].tournyName;
        }

        public int[] getTeamsPlaying(int tournyId)
        {
            return tournaments[tournyId].teamsPlaying;
        }

        public bool addTourny(int tournyId, string tournyName, int[] teamsPlaying)
        {
            if (numTournys < maxTournys)
            {
                tournaments[numTournys] = new Tournaments(tournyId, tournyName, teamsPlaying);
                numTournys++;
                return true;
            }
            return false;
        }

        public int searchTournys(int tournyId)
        {
            if (numTournys > 0)
            {
                for (int i = 0; i < numTournys; i++)
                {
                    if (tournaments[i].getTournyId() == tournyId)
                    {
                        return i;
                    }
                }
            }
            else
            {
                return -1;
            }
            return tournyId;
        }

        public string getTournyInfo(int tournyId)
        {
            string success = "-End of List-";
            string failure = "Tournament Does Not Exist";
            int result = searchTournys(tournyId);
            if (result != -1)
            {
                for (int i = 0; i < numTournys; i++)
                {
                    Console.WriteLine(tournaments[i].ToString());
                    Console.WriteLine("\n");
                }
                return success;
            }
            else
            {
                return failure;
            }
        }

        public bool delTourny(int tournyId)
        {
            int search = searchTournys(tournyId);
            if (search == -1)
            {
                return false;
            }
            tournaments[search] = tournaments[numTournys - 1];
            numTournys--;
            return true;
        }
    }
}

