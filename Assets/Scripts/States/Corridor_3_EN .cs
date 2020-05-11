using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_3_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You're standing back in the corridor, now convincingly dressed as a cleaner. ";
            story += "You strongly consider the run for freedom.\n\n\r";
            story += "Press S to take the Stairs, or U to Undress";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Courtyard_EN();
                MonoBehaviour.print("Change state from Corridor_3 to Courtyard.");
            } else if (Input.GetKeyDown(KeyCode.U)) {
                context.state = new In_Closet_EN();
                MonoBehaviour.print("Change state from Corridor_0 to In_Closet.");
            }
        }
        public override string ToString()
        {
            return "corridor_3";
        }
    }
}
