using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Closet_Door_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You are looking at a closet door, unfortunately it's locked. ";
            story += "Maybe you could find something around to help enourage it open?\n\n\r";
            story += "Press R to Return to the corridor";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_0_EN();
                MonoBehaviour.print("Change state from Closet_Door to Corridor_0.");
            }
        }
        public override string ToString()
        {
            return "closet_door";
        }
    }
}
