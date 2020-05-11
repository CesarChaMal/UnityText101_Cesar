using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Cell_Mirror_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Te encuentras en tu celda, y TODAVIA quieres escapar! Se encuentran ";
            story += "unas sucias cobijas en la cama, una marca donse se encontraba el espejo, ";
            story += "y la molesta puerta sigue alli, firmemente cerrada!\n\n\r";
            story += "Presiona S para ver las cobijas, o L para ver la cerrdadura";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Sheets_1_ES();
                MonoBehaviour.print("Change state from Cell_Mirror to Sheets_1.");
            } else if (Input.GetKeyDown(KeyCode.T)) {
                context.state = new Mirror_ES();
                MonoBehaviour.print("Change state from Cell_Mirror to Mirror.");
            } else if (Input.GetKeyDown(KeyCode.L)) {
                context.state = new Lock_1_ES();
                MonoBehaviour.print("Change state from Cell_Mirror to Lock_1.");
            }
        }
        public override string ToString()
        {
            return "cell_mirror";
        }
    }
}
