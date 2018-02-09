using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Pet : VirtualPet
    {
        private string pType;
        private string pDiet;

        public string PDiet //UPPERCASE
        {
            get { return this.pDiet; }
            set { this.pDiet = value; }
        }

        public Pet()
        {
            // default
        }

        public Pet(string pType, string pDiet)
        {
            this.pDiet = pDiet;
            this.pType = pType;
        }
    }
}
