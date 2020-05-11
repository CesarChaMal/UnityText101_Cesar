using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_1_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Still in the corridor. Floor still dirty. Hairclip in hand. ";
            story += "Now what? You wonder if that lock on the closet would succumb to ";
            story += "to some lock-picking?\n\n\r";
            story += "P to Pick the lock, and S to climb the stairs";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.P)) {
                context.state = new In_Closet_EN();
                MonoBehaviour.print("Change state from Corridor_1 to In_Closet.");
            } else if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Stairs_1_EN();
                MonoBehaviour.print("Change state from Corridor_1 to Stairs_1.");
            }
        }
        public override string ToString()
        {
            return "corridor_1";
        }
    }
}
