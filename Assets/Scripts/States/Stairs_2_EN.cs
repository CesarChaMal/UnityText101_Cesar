using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Stairs_2_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You feel smug for picking the closet door open, and are still armed with ";
            story += "a hairclip (now badly bent). Even these achievements together don't give ";
            story += "you the courage to climb up the staris to your death!\n\n\r";
            story += "Press R to Return to the corridor.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_2_EN();
                MonoBehaviour.print("Change state from Stairs_2 to Corridor_2.");
            }
        }
        public override string ToString()
        {
            return "stairs_2";
        }
    }
}
