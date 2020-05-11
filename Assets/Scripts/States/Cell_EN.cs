using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Cell_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You are in a prison cell, and you want to escape. There are ";
            story += "some dirty sheets on the bed, a mirror on the wall, and the door ";
            story += "is locked from the outside.\n\n\r";
            story += "Press S to view Sheets, or M to view Mirror, or L to view Lock";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Sheets_0_EN();
                MonoBehaviour.print("Change state from Cell to Sheets_0.");
            } else if (Input.GetKeyDown(KeyCode.M)) {
                context.state = new Mirror_EN();
                MonoBehaviour.print("Change state from Cell to Mirror.");
            } else if (Input.GetKeyDown(KeyCode.L)) {
                context.state = new Lock_0_EN();
                MonoBehaviour.print("Change state from Cell to Lock_0.");
            }
        }
        public override string ToString()
        {
            return "cell";
        }
    }
}
