using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class TeamMembers
    {
        public string memName;
        public int memId;
        public int onTeamId = -1;
        public int memPosition;

        public TeamMembers(string memName, int memId, int onTeamId, int memPosition)
        {
            this.memName = memName;
            this.memId = memId;
            this.onTeamId = onTeamId;
            this.memPosition = memPosition;
        }

        public int getMemId()
        {
            return memId;
        }
        public override string ToString()
        {
            return "|Player ID: " + memId + "|" + "\n|Player Name: " + memName + "|" + "\n|Team ID: " + onTeamId + "|" + "\n|Position: " + memPosition + "|";
        }
    }
}