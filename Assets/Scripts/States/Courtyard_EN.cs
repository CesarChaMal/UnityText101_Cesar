using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Courtyard_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You walk through the courtyard dressed as a cleaner. ";
            story += "The guard tips his hat at you as you waltz past, claiming ";
            story += "your freedom. You heart races as you walk into the sunset.\n\n\r";
            story += "Press P to Play again.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.P)) {
                context.state = new Cell_EN();
                MonoBehaviour.print("Change state from Courtyard to Cell.");
            }
        }
        public override string ToString()
        {
            return "courtyard";
        }
    }
}
