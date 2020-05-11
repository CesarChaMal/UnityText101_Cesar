using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Sheets_0_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Tu no puedes creer que duermes en estas cosas. Seguramente es ";
            story += "tiempo de que alguien las cambie. Los placeres de la vida en prision ";
            story += "Yo supongo!\n\n\r";
            story += "Presiona R para Regresar a descansar a tu celda";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_ES();
                MonoBehaviour.print("Change state from Sheets_0 to Cell.");
            }
        }
        public override string ToString()
        {
            return "sheets_0";
        }
    }
}
