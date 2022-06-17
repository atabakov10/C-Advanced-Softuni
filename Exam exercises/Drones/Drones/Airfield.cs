using System.Collections.Generic;

namespace Drones
{
    public class Airfield
    {
        //private List<Drone> drones;
        //private string name;
        //private int capacity;
        //private double landingStrip;
        //private int range;
        //private string brand;


        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public Dictionary<string, Drone> drones;
        public int Count => this.drones.Count;
        public string Brand { get; set; }
        public int Range { get; private set; }
        public string AddDrone(Drone drone)
        {
            if (Capacity < Count + 1)
            {
                return "Airfield is full.";
            }
            else if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone";
            } 
            drones.Add(drone.Name, drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
        public bool RemoveDrone(string name)
        {
            return drones.Remove(name);
        }
        public int RemoveDroneByBrand(string brand)
        {
            var dronesCount = 0;
            
        
           foreach (var drone in drones)
           {
                if (drone.Value.Brand == brand)
                {
                    drones.Remove(drone.Key);
                    dronesCount++;
                }
           }
            return dronesCount;
        }
        public Drone FlyDrone(string name)
        {
            if (drones.ContainsKey(name))
            {
                drones[name].Availabe
            }

            return null;
        }



    }
}
