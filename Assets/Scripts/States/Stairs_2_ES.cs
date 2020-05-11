using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Stairs_2_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Te sientes confiado por haber abierto la puerta del closet, y estas todavia armado con ";
            story += "un clip para el cabello (ahora mal doblado). Incluso esos logros juntos no te ";
            story += "dan el coraje para subir las escaleres a tu muerte segura!\n\n\r";
            story += "Presiona R para Regresar al corredor.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Corridor_2_ES();
                MonoBehaviour.print("Change state from Stairs_2 to Corridor_2.");
            }
        }
        public override string ToString()
        {
            return "stairs_2";
        }
    }
}
