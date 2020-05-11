using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_3_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Te encuentras atras en el corredor, ahora convincentemente vestido como personal de limpieza. ";
            story += "Consideras fuertemente correr por tu libertad.\n\n\r";
            story += "Presiona S para tomar las escaleras, o U para quitarte el uniforme de personal de limpieza";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Courtyard_ES();
                MonoBehaviour.print("Change state from Corridor_3 to Courtyard.");
            } else if (Input.GetKeyDown(KeyCode.U)) {
                context.state = new In_Closet_ES();
                MonoBehaviour.print("Change state from Corridor_0 to In_Closet.");
            }
        }
        public override string ToString()
        {
            return "corridor_3";
        }
    }
}
