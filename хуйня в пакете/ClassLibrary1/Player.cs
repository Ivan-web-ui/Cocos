using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Player
    {
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public int Bags { get; set; }
        public int FoodWaseaten { get; set; }
        public int Level { get; set; }

        public Player(int currentHitPoints, int maxHitPoints, int bags, int foodWaseaten, int level)
        {
            currentHitPoints = CurrentHitPoints;
            maxHitPoints = MaxHitPoints;
            bags = Bags;
            foodWaseaten = FoodWaseaten;
            level = Level;
        }
    }
}
