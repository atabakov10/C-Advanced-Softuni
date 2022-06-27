using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> renovators;

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>();
        }
        
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count => this.renovators.Count;

        public string Tipe { get; set; }
        public double Rate { get; set; }
        public bool Hired { get; set; } = false;

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Tipe))
            {
                return "Invalid renovator's information.";
            }
            if (NeededRenovators < Count + 1)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";

        }
        public bool RemoveRenovator(string name)
        { 
            if (Name.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int remove = renovators.RemoveAll(r => r.Tipe == type);
            var counter = 0;
            for (int i = 0; i < remove; i++)
            {
                return remove;
            }        
            return 0;
        }
        public Renovator HireRenovator(string name)
        {
            var hiredNames = renovators.FindAll(renovators => renovators.Name == name);
            if (hiredNames.Count > 0)
            {
               
                foreach (var renovator in hiredNames)
                { 
                    renovator.Hired = true;
                    return renovator;
                }
            }
            return null;

        }
        public List<Renovator> PayRenovators(int days)
        {
            var payRenovators = renovators.FindAll(x => x.Days >= days);
            return payRenovators;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators)
            {
                if (renovator.Hired == false)
                {

                    sb.AppendLine($"-Renovator: {renovator.Name}")
                        .AppendLine($"--Specialty: {renovator.Tipe}")
                        .AppendLine($"--Rate per day: {renovator.Rate}");
                    //return sb.ToString();
                }
               

                      
            }
            
            return sb.ToString();
        }
            
            
    }
}
