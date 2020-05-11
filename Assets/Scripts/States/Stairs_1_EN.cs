using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Stairs_1_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Unfortunately weilding a puny hairclip hasn't given you the ";
            story += "confidence to walk out into a courtyard surrounded by armed guards!\n\n\r";
            story += "Press R to Retreat down the stairs.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_1_EN();
                MonoBehaviour.print("Change state from Stairs_1 to Corridor_1.");
            }
        }
        public override string ToString()
        {
            return "stairs_1";
        }
    }
}
