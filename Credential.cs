using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class Credential
    {
        private int index;
        private int founded;
        private int noOfEmployees;
        private string organizationID;
        private string name;
        private string website;
        private string country;
        private string description;
        private string industry;


        public int Index { get => index; set => index = value; }
        public string OrganizationID { get => organizationID; set => organizationID = value; }
        public string Name { get => name; set => name = value; }
        public string Website { get => website; set => website = value; }
        public string Country { get => country; set => country = value; }
        public string Description { get => description; set => description = value; }
        public string Industry { get => industry; set => industry = value; }
        public int Founded { get => founded; set => founded = value; }
        public int NoOfEmployees { get => noOfEmployees; set => noOfEmployees = value; }
        

        public Credential(int index, int founded, int noOfEmployees, string organizationID, string name, string website, string country, string description, string industry)
        {
            this.Index = index;
            this.Founded = founded;
            this.NoOfEmployees = noOfEmployees;
            this.OrganizationID = organizationID;
            this.Name = name;
            this.Website = website;
            this.Country = country;
            this.Description = description;
            this.Industry = industry;
        }

    }
}
