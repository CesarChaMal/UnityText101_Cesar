using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace States
{
    public class SpanishStateFactory : Language
    {
        public State state { get; set; }
        public State getState(String type)
        {
            switch (type)
            {
                case "cell":
                    state = new Cell_ES();
                    break;
                case "sheets_0":
                    state = new Sheets_0_ES();
                    break;
                case "mirror":
                    state = new Mirror_ES();
                    break;
                case "lock_0":
                    state = new Lock_0_ES();
                    break;
                case "cell_mirror":
                    state = new Cell_Mirror_ES();
                    break;
                case "sheets_1":
                    state = new Sheets_1_ES();
                    break;
                case "lock_1":
                    state = new Lock_1_ES();
                    break;
                case "closet_door":
                    state = new Closet_Door_ES();
                    break;
                case "in_closet":
                    state = new In_Closet_ES();
                    break;
                case "corridor_0":
                    state = new Corridor_0_ES();
                    break;
                case "corridor_1":
                    state = new Corridor_1_ES();
                    break;
                case "corridor_2":
                    state = new Corridor_2_ES();
                    break;
                case "corridor_3":
                    state = new Corridor_3_ES();
                    break;
                case "floor":
                    state = new Floor_ES();
                    break;
                case "courtyard":
                    state = new Courtyard_ES();
                    break;
                case "stairs_0":
                    state = new Stairs_0_ES();
                    break;
                case "stairs_1":
                    state = new Stairs_1_ES();
                    break;
                case "stairs_2":
                    state = new Stairs_2_ES();
                    break;
            }
            return state;
        }
    }
}
