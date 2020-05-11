using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Lock_1_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Cuidadosamente colocas el espejo a traves de las barras, y lo giras ";
            story += "asi podras ver la cerradura. Tu puedes obtener las huellas de alrededor ";
            story += "de los botones. Presiona los botones sucios, y oiras un click.\n\n\r";
            story += "Presiona O para Abrir, or R para Regresar a tu celda";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R))
            {
                context.state = new Cell_Mirror_ES();
                MonoBehaviour.print("Change state from Lock_1 to Cell_Mirror.");
            }
            else if (Input.GetKeyDown(KeyCode.O))
            {
                context.state = new Corridor_0_ES();
                MonoBehaviour.print("Change state from Lock_1 to Corridor_0.");
            }
        }
        public override string ToString()
        {
            return "lock_1";
        }
    }
}
