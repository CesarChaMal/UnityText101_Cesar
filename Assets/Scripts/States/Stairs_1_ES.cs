using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Stairs_1_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Desafortunadamente llevar un clip para cabello no te ha dado la confianza ";
            story += "para pasar por el patio que se encuentra rodeado de guardias armados!\n\n\r";
            story += "Presiona R para regresar por las escaleras.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_1_ES();
                MonoBehaviour.print("Change state from Stairs_1 to Corridor_1.");
            }
        }
        public override string ToString()
        {
            return "stairs_1";
        }
    }
}
