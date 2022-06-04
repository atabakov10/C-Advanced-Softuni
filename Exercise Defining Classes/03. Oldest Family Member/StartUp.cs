using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Program
    {
        public static void Main()
        {
            int membersCount = int.Parse(Console.ReadLine());
            Family members = new Family();

            for (int i = 0; i < membersCount; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);

                members.AddMember(person);
            }

            List<Person> peopleMoreThan30Years = members.GetMembersMoreThan30();

            foreach (var person in peopleMoreThan30Years)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}