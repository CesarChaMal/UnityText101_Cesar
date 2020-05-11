using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Closet_Door_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Estas mirando a la puerta del closet, desafortunadamente tiene seguro. ";
            story += "Quiza puedas encontrar algo alrededor que te ayude a abrirla?\n\n\r";
            story += "Presiona R para Regresar al corredor";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_0_ES();
                MonoBehaviour.print("Change state from Closet_Door to Corridor_0.");
            }
        }
        public override string ToString()
        {
            return "closet_door";
        }
    }
}
