using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Lock_0_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Este es una de esas cerraduras con clave. Tu no tienes idea cual es la ";
            story += "combinacion. Tu deseas de alguna forma alcanzar a ver donde se encontraban las huellas ";
            story += "sucias, quiza eso ayude.\n\n\r";
            story += "Presiona R para Regresar a descansar a tu celda";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_ES();
                MonoBehaviour.print("Change state from Lock_0 to Cell.");
            }
        }
        public override string ToString()
        {
            return "lock_0";
        }
    }
}
