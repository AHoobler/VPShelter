using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Pet : VirtualPet
    {
        private string petType;
        private string dogDiet;

        public string PDiet //UPPERCASE
        {
            get { return this.dogDiet; }
            set { this.dogDiet = value; }
        }

        public Pet()
        {
            // default
        }

        public Pet(string pType, string pDiet)
        {
            this.dogDiet = pDiet;
            this.petType = pType;
        }

    }
}
