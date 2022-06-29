using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Project
{
    public class Items
    {
        public string itemName = "";
        public int value;
        public Items() 
        {
            itemName = "";
            value = 0;
        }
        public Items(string itemName, int value)
        {
            this.itemName = itemName;
            this.value = value;
        }
        public class Weapons : Items
        {
         Dictionary<string, int> WepList =
                new Dictionary<string, int>();
           
            

        }

         
        



      //{

        //            < "Branch":1 , "Sword" : 5, "Claymore" : 10, "Bandage" : 2, "Medkit" : 10, "Helmet": 1, "Chestplate" : 1, "Plate Legs" : 1, "Boots" : 1, "Gauntlets" : 1 > ;
      //}


    }
}
