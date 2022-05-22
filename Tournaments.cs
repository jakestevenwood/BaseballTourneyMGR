using System;
using System.Collections.Generic;
using System.Text;

namespace JakobWood_PartB
{
    class Tournaments
    {
        public int tournyId;
        public string tournyName;
        public int[] teamsPlaying;

        public Tournaments (int tournyId, string tournyName, int[] teamsPlaying)
        {
            this.tournyName = tournyName;
            this.teamsPlaying = teamsPlaying;
        }

        public int getTournyId()
        {
            return tournyId;
        }
        public override string ToString()
        {
            return "|Tournament ID: " + tournyId + "|" + "\n|Tournament Name: " + tournyName + "|" + "\n|Teams Competing: " + teamsPlaying + "|";
        }
    }
}
