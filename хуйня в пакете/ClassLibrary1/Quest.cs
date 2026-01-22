using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Quest
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description {  get; set; }
        public int RewardFoodWaseaten {  get; set; }
        public int RewardBugs {  get; set; }

        public Quest(int id, string name, string description, int rewardFoodWaseaten,int rewardBugs)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardFoodWaseaten = rewardFoodWaseaten;
            RewardBugs = rewardBugs;
        }
    }
}
