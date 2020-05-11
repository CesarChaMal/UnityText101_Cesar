using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace States
{
    public class EnglishStateFactory : Language
    {
        public State state { get; set; }
        public State getState(String type)
        {
            switch (type) {
                case "cell":
                    state = new Cell_EN();
                    break;
                case "sheets_0":
                    state = new Sheets_0_EN();
                    break;
                case "mirror":
                    state = new Mirror_EN();
                    break;
                case "lock_0":
                    state = new Lock_0_EN();
                    break;
                case "cell_mirror":
                    state = new Cell_Mirror_EN();
                    break;
                case "sheets_1":
                    state = new Sheets_1_EN();
                    break;
                case "lock_1":
                    state = new Lock_1_EN();
                    break;
                case "closet_door":
                    state = new Closet_Door_EN();
                    break;
                case "in_closet":
                    state = new In_Closet_EN();
                    break;
                case "corridor_0":
                    state = new Corridor_0_EN();
                    break;
                case "corridor_1":
                    state = new Corridor_1_EN();
                    break;
                case "corridor_2":
                    state = new Corridor_2_EN();
                    break;
                case "corridor_3":
                    state = new Corridor_3_EN();
                    break;
                case "floor":
                    state = new Floor_EN();
                    break;
                case "courtyard":
                    state = new Courtyard_EN();
                    break;
                case "stairs_0":
                    state = new Stairs_0_EN();
                    break;
                case "stairs_1":
                    state = new Stairs_1_EN();
                    break;
                case "stairs_2":
                    state = new Stairs_2_EN();
                    break;
            }
            return state;
        }
    }
}
