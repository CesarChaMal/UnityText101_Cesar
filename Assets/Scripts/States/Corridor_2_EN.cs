using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_2_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Back in the corridor, having declined to dress-up as a cleaner.\n\n\r";
            story += "Press C to revisit the Closet, and S to climb the stairs";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.C)) {
                context.state = new In_Closet_EN();
                MonoBehaviour.print("Change state from Corridor_2 to In_Closet.");
            } else if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Stairs_2_EN();
                MonoBehaviour.print("Change state from Corridor_2 to Stairs_2.");
            }
        }
        public override string ToString()
        {
            return "corridor_2";
        }
    }
}
