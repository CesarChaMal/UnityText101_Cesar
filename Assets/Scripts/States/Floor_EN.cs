using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Floor_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Rummagaing around on the dirty floor, you find a hairclip.\n\n\r";
            story += "Press R to Return to the standing, or H to take the Hairclip.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_0_EN();
                MonoBehaviour.print("Change state from Floor to Corridor_0.");
            } else if (Input.GetKeyDown(KeyCode.H)) {
                context.state = new Corridor_1_EN();
                MonoBehaviour.print("Change state from Floor to Corridor_1.");
            }
        }
        public override string ToString()
        {
            return "floor";
        }
    }
}
