using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Player : LivingCreature
    {
        public int Bags { get; set; }
        public int FoodWaseaten { get; set; }
        public int Level { get; set; }

        public Player(int currentHitPoints, int maxHitPoints, int bags, int foodWaseaten, int level)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Bags = bags;
            FoodWaseaten = foodWaseaten;
            Level = level;
        }
    }
}
