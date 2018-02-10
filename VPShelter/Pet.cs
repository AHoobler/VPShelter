using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Pet : VirtualPet
    {
        // FIELDSpet types and diets
        private string dogType;
        private string dogDiet;

        private string toadType;
        private string toadDiet;

        private string owlType;
        private string owlDiet;

        private string catType;
        private string catDiet;

        //properties
        public string DogDiet 
        {
            get { return this.dogDiet; }
            set { this.dogDiet = value; }
        }

        public string ToadDiet
        {
            get { return this.toadDiet; }
            set { this.toadDiet = value; }
        }

        public string OwlDiet
        {
            get { return this.owlDiet; }
            set { this.owlDiet = value; }
        }

        public string CatDiet
        {
            get { return this.catDiet; }
            set { this.catDiet = value; }
        }

        public string DogType
        {
            get { return this.dogType; }
            set { this.dogType = value; }
        }

        public string ToadType
        {
            get { return this.toadType; }
            set { this.toadType = value; }
        }

                public string OwlType
        {
            get { return this.owlType; }
            set { this.owlType = value; }
        }

        public string CatType
        {
            get { return this.catType; }
            set { this.catType = value; }
        }



        //public Pet()
        //{
        //    // default
        //}

        //public Pet(string DogType, string DogDiet)
        //{
        //    this.dogDiet = DogDiet;
        //    this.dogType = DogType;
        //}



    }
}
