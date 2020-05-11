using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace States
{
    public class Context
    {
        public Context(State state)
        {
            this.state = state;
            Console.WriteLine("Create object of context class with initial State.");
        }

        public State state { get; set; }

        /// <summary>
        /// State change request
        /// </summary>
        public void Request()
        {
            state.change(this);
        }
    }
}
