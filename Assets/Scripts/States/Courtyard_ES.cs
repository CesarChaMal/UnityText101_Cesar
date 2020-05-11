using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Courtyard_ES : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Caminas a traves del patio vestido como personal de limpieza. ";
            story += "El guarda te saluda mientras pasas cerca de el, Aclamando ";
            story += "tu libertad. Tu corazon se acelera mientras caminas hacia el amanecer.\n\n\r";
            story += "Presiona P para jugar de nuevo.";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.P)) {
                context.state = new Cell_ES();
                MonoBehaviour.print("Change state from Courtyard to Cell.");
            }
        }
        public override string ToString()
        {
            return "courtyard";
        }
    }
}
