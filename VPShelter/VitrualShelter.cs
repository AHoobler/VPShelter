using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VitrualShelter
    {
        //store lists of the pets and employees
        public List<Manager> AllManagers { get; set; }
        public List<Volunteer> AllVolunteers { get; set; }
        public List<VirtualPet> AllPets { get; set; }
    }
}
