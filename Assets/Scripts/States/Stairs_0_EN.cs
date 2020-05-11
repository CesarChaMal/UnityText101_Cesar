using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Stairs_0_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You start walking up the stairs towards the outside light. ";
            story += "You realise it's not break time, and you'll be caught immediately. ";
            story += "You slither back down the stairs and reconsider.\n\n\r";
            story += "Press R to Return to the corridor.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_0_EN();
                MonoBehaviour.print("Change state from Stairs_0 to Corridor_0.");
            }
        }
        public override string ToString()
        {
            return "stairs_0";
        }
    }
}
