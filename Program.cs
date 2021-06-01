using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            bool NameCheck = true;
            int BankDifficultyLevel = 100;
            int TeamSkillLevel = 0;

            List<TeamMember> TeamMemberList = new List<TeamMember>();

            while (NameCheck)
            {
                Console.Write("Please enter team members first name: ");
                string MemberFirstName = Console.ReadLine();
                if (MemberFirstName == "")
                {
                    Console.WriteLine("Team is complete!");
                    break;
                }
                else
                {
                    NameCheck = true;
                }
                Console.Write("Please enter team members last name: ");
                string MemberLastName = Console.ReadLine();
                Console.Write("Please enter skill level: ");
                int MemberSkillLevel = int.Parse(Console.ReadLine());
                Console.Write("Please enter a courage factor between 0.0-2.0: ");
                double MemberCourageFactor = double.Parse(Console.ReadLine());

                TeamMember newMember = new TeamMember()
                {
                    FirstName = MemberFirstName,
                    LastName = MemberLastName,
                    SkillLevel = MemberSkillLevel,
                    CourageFactor = MemberCourageFactor
                };

                TeamMemberList.Add(newMember);
                Console.WriteLine($"Name: {newMember.FullName()} \nSkill Level: {newMember.SkillLevel} \nCourage Factor: {newMember.CourageFactor}");
            }


            TeamMember Laurel = new TeamMember()
            {
                FirstName = "Laurel",
                LastName = "Morrison",
                SkillLevel = 25,
                CourageFactor = 1.9
            };
            TeamMember Taryn = new TeamMember()
            {
                FirstName = "Taryn",
                LastName = "Lytle",
                SkillLevel = 15,
                CourageFactor = 1.9
            };
            TeamMember Colten = new TeamMember()
            {
                FirstName = "Colten",
                LastName = "Mayberry",
                SkillLevel = 25,
                CourageFactor = 2.0
            };

            TeamMemberList.Add(Laurel);
            TeamMemberList.Add(Taryn);
            TeamMemberList.Add(Colten);


            foreach (TeamMember member in TeamMemberList)
            {
                TeamSkillLevel += member.SkillLevel;
            }

            if (TeamSkillLevel >= BankDifficultyLevel)
            {
                Console.WriteLine("We are rich!");
            }
            else
            {
                Console.WriteLine("We are poor!");
            }

            Console.WriteLine($"The teams skill level is {TeamSkillLevel}");

            Console.WriteLine($"There are {TeamMemberList.Count} members on the team!");



        }
    }
}
