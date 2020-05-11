using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class In_Closet_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Inside the closet you see a cleaner's uniform that looks about your size! ";
            story += "Seems like your day is looking-up.\n\n\r";
            story += "Press D to Dress up, or R to Return to the corridor";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_2_EN();
                MonoBehaviour.print("Change state from In_Closet to Corridor_2.");
            } else if (Input.GetKeyDown(KeyCode.D)) {
                context.state = new Corridor_3_EN();
                MonoBehaviour.print("Change state from In_Closet to Corridor_3.");
            }
        }
        public override string ToString()
        {
            return "in_closet";
        }
    }
}
