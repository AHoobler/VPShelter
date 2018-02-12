using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        private string name;
        private string description;
        private int isHungry;
        private int isBored;
        private int isThirsty;
        private int isAngry;


        //NEW PROPERTIES
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }


        //OLD PROPERTIES
        public int IsHungry

        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public int IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public int IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public int IsAngry
        {
            get { return this.isAngry; }
            set { this.isAngry = value; }
        }



        // NEW CONSTRUCTORS
        public VirtualPet()
        {
            // defualt 
        }
         

        //name and description only
        public VirtualPet(string name, string description)
        {
            this.description = description;
            this.name = name;
        }

        //name description and attributes

        public VirtualPet(string name, string description, int isBored, int isHungry, int isThirsty)
        {
            this.name = name;
            this.description = description;
            this.isBored = isBored;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
        }



    }

}
