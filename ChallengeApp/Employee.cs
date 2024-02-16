using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    internal class Employee
    {
        public List<int> grades = new List<int>();

       
        public string Name {  get; private set; }
        public string SecoundName {  get; private set; }
        public int Age {  get; private set; }
        public int Result 
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public Employee(string Name, string SecoundName, int Age)
        {
            this.Name = Name;
            this.SecoundName = SecoundName;
            this.Age = Age;
            
        }
        public void AddGrade(int grades)
        {
            if(grades > 0 && grades <= 10) 
            {
                this.grades.Add(grades);
            }
            else
            {
                Console.WriteLine("Ocena niedopuszczona");
            }
        }
    }
}
