using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_1_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Todavia en el corredor. El suelo sigue sucio. Tienes un clip para el pelo en tus manos. ";
            story += "Ahora que? Te preguntas si esa cerradura en el closet puede ser vencida usando ";
            story += "un alambre?\n\n\r";
            story += "P para forzar la cerradura, y S para subir las escaleras";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.P)) {
                context.state = new In_Closet_ES();
                MonoBehaviour.print("Change state from Corridor_1 to In_Closet.");
            } else if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Stairs_1_ES();
                MonoBehaviour.print("Change state from Corridor_1 to Stairs_1.");
            }
        }
        public override string ToString()
        {
            return "corridor_1";
        }
    }
}
