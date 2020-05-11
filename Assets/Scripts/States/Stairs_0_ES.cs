using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Stairs_0_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Empiezas a subir las escaleres hacia la luz exterior. ";
            story += "Te das cuenta que no es la hora de descanso, y podrias ser descubierto inmediatamente. ";
            story += "Te regresas por las escalares y reconsideras.\n\n\r";
            story += "Presiona R para regresar al corredor.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_0_ES();
                MonoBehaviour.print("Change state from Stairs_0 to Corridor_0.");
            }
        }
        public override string ToString()
        {
            return "stairs_0";
        }
    }
}
