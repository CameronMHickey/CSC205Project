using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Project
{
    public class Enemy
    {
      public int health, attack;
      public Enemy()
      {
          health = 0;
          attack = 0;
      }
      public Enemy(int health, int attack)
      {
            this.health = health;
            this.attack = attack;
      }
     public class Wolf : Enemy
      {
            public Wolf()
            {
                health = 3;
                attack = 1;
            }
      }
      public class Bear : Enemy
      {
            public Bear()
            {
                health = 8;
                attack = 2;
            }



        }




    }
}
