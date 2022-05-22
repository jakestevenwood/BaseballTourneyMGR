using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class BaseballTournyController
    {
        public TeamMemManager teamMemMan;
        public TeamManager teamMan;
        public TournManager tournMan;

        public BaseballTournyController (int maxMem, int maxTeams, int maxTournys)
        {
            teamMemMan = new TeamMemManager(maxMem);
            teamMan = new TeamManager(maxTeams);
            tournMan = new TournManager(maxTournys);
        }

        public bool addMem(string memName, int memId, int onTeamId, int memPosition)
        {
            return teamMemMan.addMember(memName, memId, onTeamId, memPosition);
        }

        public bool delMem(int memId)
        {
            return teamMemMan.delMember(memId);
        }

        public string getMemInfo(int memId)
        {
            return teamMemMan.getMemInfo(memId);
        }

        public bool addTeam(int teamId, string teamName, int teamRegion, int[] teamMembers)
        {
            return teamMan.addTeam(teamId, teamName, teamRegion, teamMembers);
        }

        public bool delTeam(int teamId)
        {
            return teamMan.delTeam(teamId);
        }

        public string getTeamInfo(int teamId)
        {
            return teamMan.getTeamInfo(teamId);
        }

        public bool addTourny(int tournyId, string tournyName, int[] teamsPlaying)
        {
            return tournMan.addTourny(tournyId, tournyName, teamsPlaying);
        }

        public bool delTourny(int tournyId)
        {
            return tournMan.delTourny(tournyId);
        }

        public string getTournyInfo(int tournyId)
        {
            return tournMan.getTournyInfo(tournyId);
        }
    }
}
