using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class Teams
    {
        public int teamId;
        public string teamName;
        public int teamRegion;
        public int[] teamMembers;

        public Teams (int teamId, string teamName, int teamRegion, int[] teamMembers)
        {
            this.teamId = teamId;
            this.teamName = teamName;
            this.teamRegion = teamRegion;
            this.teamMembers = teamMembers;
        }
        public int getTeamId()
        {
            return teamId;
        }

        public override string ToString()
        {
            return "|Team ID: " + teamId + "|" + "\n|Team Name: " + teamName + "|" + "\n|Region: " + teamRegion + "|" + "\n" + "Team Members: " + teamMembers;
        }
    }
}
