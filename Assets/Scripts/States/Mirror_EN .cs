using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Mirror_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "The dirty old mirror on the wall seems loose.";
            story += "\n\n\r";
            story += "Press T to take the mirror, or R to return to cell";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_EN();
                MonoBehaviour.print("Change state from Mirror to Cell.");
            } else if (Input.GetKeyDown(KeyCode.T)) {
                context.state = new Cell_Mirror_EN();
                MonoBehaviour.print("Change state from Mirror to Cell_Mirror.");
            }
        }
        public override string ToString()
        {
            return "mirror";
        }
    }
}
