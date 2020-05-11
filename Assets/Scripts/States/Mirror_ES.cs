using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Mirror_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "El viejo espejo sucio en la pared parece flojo.";
            story += "\n\n\r";
            story += "Presiona T para tomar el espejo, o R para regresar a tu celda";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_ES();
                MonoBehaviour.print("Change state from Mirror to Cell.");
            } else if (Input.GetKeyDown(KeyCode.T)) {
                context.state = new Cell_Mirror_ES();
                MonoBehaviour.print("Change state from Mirror to Cell_Mirror.");
            }
        }
        public override string ToString()
        {
            return "mirror";
        }
    }
}
