using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Cell_Mirror_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You are in your cell, and you STILL want to escape! There are ";
            story += "some dirty sheets on the bed, a mark where there mirror was, ";
            story += "and the pesky door is still there, and firmly locked!\n\n\r";
            story += "Press S to view Sheets, or L to view Lock";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Sheets_1_EN();
                MonoBehaviour.print("Change state from Cell_Mirror to Sheets_1.");
            } else if (Input.GetKeyDown(KeyCode.T)) {
                context.state = new Mirror_EN();
                MonoBehaviour.print("Change state from Cell_Mirror to Mirror.");
            } else if (Input.GetKeyDown(KeyCode.L)) {
                context.state = new Lock_1_EN();
                MonoBehaviour.print("Change state from Cell_Mirror to Lock_1.");
            }
        }
        public override string ToString()
        {
            return "cell_mirror";
        }
    }
}
