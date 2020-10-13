using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp112.classes
{
    class Donor
    {
        public int Donor_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Blood_Group { get; set; }
        public int Age { get; set; }
        public DateTime Last_Donated { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string  Address { get; set; }
        public DateTime Added_Date { get; set; }
        public string Image { get; set; }
        public int Added_By { get; set; }
    }
}
