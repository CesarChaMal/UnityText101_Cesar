using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Floor_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Registrando el piso sucio, encontraste un clip para el cabello.\n\n\r";
            story += "Presiona R para pararte de nuevo, o H para tomar el clip para el cabello.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_0_ES();
                MonoBehaviour.print("Change state from Floor to Corridor_0.");
            } else if (Input.GetKeyDown(KeyCode.H)) {
                context.state = new Corridor_1_ES();
                MonoBehaviour.print("Change state from Floor to Corridor_1.");
            }
        }
        public override string ToString()
        {
            return "floor";
        }
    }
}
