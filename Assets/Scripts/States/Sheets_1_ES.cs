using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Sheets_1_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Sostener un espejo en tus manos no hace que las sabanas ";
            story += "luzcan mejor\n\n\r";
            story += "Presiona R para Regresar a tu celda";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_Mirror_ES();
                MonoBehaviour.print("Change state from Sheets_1 to Cell_Mirror.");
            }
        }
        public override string ToString()
        {
            return "sheets_1";
        }
    }
}
