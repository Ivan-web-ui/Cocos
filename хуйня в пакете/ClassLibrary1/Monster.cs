using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardFoodWaseaten { get; set; }
        public int RewardBugs {  get; set; }

        public Moster(int id, string name, int maximumDamage, int rewardfoodWaseaten, int rewardBugs, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardFoodWaseaten = rewardfoodWaseaten;
            RewardBugs = rewardBugs;
        }
    }
}
