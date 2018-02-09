﻿using System;
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

        public string Desciption
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
            //
        }
         
        public VirtualPet(string name, string description)
        {
            this.description = description;
            this.name = name;
        }

        // Add angry??
        public VirtualPet(int isBored, int isHungry, int isThirsty)
        {
            this.isBored = isBored;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
        }



    }

}