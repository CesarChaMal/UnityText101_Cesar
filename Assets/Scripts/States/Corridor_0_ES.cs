using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace States
{
    public class Corridor_0_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Estas fuera de tu celda, pero todavia con problemas.";
            story += "Te encuentras en el corredor, hay un closet and unas escaleras que llevan ";
            story += "al patio. Tambien hay varios desechos en el piso.\n\n\r";
            story += "Presiona C para ver el Closet, F para inspeccionar el piso, y S para Subir las escaleras";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.S)) {
                context.state = new Stairs_0_ES();
                MonoBehaviour.print("Change state from Corridor_0 to Stairs_0.");
            } else if (Input.GetKeyDown(KeyCode.F)) {
                context.state = new Floor_ES();
                MonoBehaviour.print("Change state from Corridor_0 to Floor.");
            } else if (Input.GetKeyDown(KeyCode.C)) {
                context.state = new Closet_Door_ES();
                MonoBehaviour.print("Change state from Corridor_0 to Closed_Door.");
            }
        }
        public override string ToString()
        {
            return "corridor_0";
        }
    }
}
