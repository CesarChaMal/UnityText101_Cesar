using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_2_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "De regreso en el corredor, habiendo rechazado having vestirte como personal de limpieza.\n\n\r";
            story += "Presiona C para volver a visitar el closet, y S para subir las escaleras";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.C)) {
                context.state = new In_Closet_ES();
                MonoBehaviour.print("Change state from Corridor_2 to In_Closet.");
            } else if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Stairs_2_ES();
                MonoBehaviour.print("Change state from Corridor_2 to Stairs_2.");
            }
        }
        public override string ToString()
        {
            return "corridor_2";
        }
    }
}
