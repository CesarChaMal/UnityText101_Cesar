using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class In_Closet_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Dentro del closet ves un uniforme del personal de limpieza que parece de tu talla! ";
            story += "Parece que tu suerte va mejorando.\n\n\r";
            story += "Presiona D para ponertelo, o R para regresar al corredor";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_2_ES();
                MonoBehaviour.print("Change state from In_Closet to Corridor_2.");
            } else if (Input.GetKeyDown(KeyCode.D)) {
                context.state = new Corridor_3_ES();
                MonoBehaviour.print("Change state from In_Closet to Corridor_3.");
            }
        }
        public override string ToString()
        {
            return "in_closet";
        }
    }
}
