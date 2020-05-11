using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_0_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You're out of your cell, but not out of trouble.";
            story += "You are in the corridor, there's a closet and some stairs leading to ";
            story += "the courtyard. There's also various detritus on the floor.\n\n\r";
            story += "Press C to view the Closet, F to inspect the Floor, and S to climb the stairs";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Stairs_0_EN();
                MonoBehaviour.print("Change state from Corridor_0 to Stairs_0.");
            } else if (Input.GetKeyDown(KeyCode.F)) {
                context.state = new Floor_EN();
                MonoBehaviour.print("Change state from Corridor_0 to Floor.");
            } else if (Input.GetKeyDown(KeyCode.C)) {
                context.state = new Closet_Door_EN();
                MonoBehaviour.print("Change state from Corridor_0 to Closed_Door.");
            }
        }
        public override string ToString()
        {
            return "corridor_0";
        }
    }
}
