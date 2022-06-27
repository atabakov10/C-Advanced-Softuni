using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;

        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Tipe = type;
            this.Rate = rate;
            this.Days = days;
        }

        public bool Hired { get; set; } = false;

        public int Days
        {
            get { return days; }
            set { days = value; }
        }


        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string Tipe
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Renovator: {this.Name}")
                .AppendLine($"--Specialty: {this.Tipe}")
                .AppendLine($"--Rate per day: {this.Rate} BGN");

            return sb.ToString();
        }


    }
}
