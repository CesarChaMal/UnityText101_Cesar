using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Cell_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Tu estas en una celda de una prision, y quieres escapar. Se encuentran ";
            story += "unas sabanas sucias en la cama, un espejo en la pared, y la puerta ";
            story += "esta cerrada con seguro desde el interior.\n\n\r";
            story += "Presiona S para ver las sabanas, o M para ver el espejo, o L para ver la cerradura";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Sheets_0_ES();
                MonoBehaviour.print("Change state from Cell to Sheets_0.");
            } else if (Input.GetKeyDown(KeyCode.M)) {
                context.state = new Mirror_ES();
                MonoBehaviour.print("Change state from Cell to Mirror.");
            } else if (Input.GetKeyDown(KeyCode.L)) {
                context.state = new Lock_0_ES();
                MonoBehaviour.print("Change state from Cell to Lock_0.");
            }
        }
        public override string ToString()
        {
            return "cell";
        }
    }
}
