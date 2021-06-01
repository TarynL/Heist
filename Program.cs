using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");


            Console.Write("Please enter team members first name: ");
            string MemberFirstName = Console.ReadLine();
            Console.Write("Please enter team members last name: ");
            string MemberLastName = Console.ReadLine();
            Console.Write("Please enter skill level: ");
            int MemberSkillLevel = int.Parse(Console.ReadLine());
            Console.Write("Please enter a courage factor between 0.0-2.0: ");
            double MemberCourageFactor = double.Parse(Console.ReadLine());

            TeamMember Colten = new TeamMember()
            {
                FirstName = MemberFirstName,
                LastName = MemberLastName,
                SkillLevel = MemberSkillLevel,
                CourageFactor = MemberCourageFactor
            };
            TeamMember Laurel = new TeamMember()
            {
                FirstName = "Laurel",
                LastName = "Morrison",
                SkillLevel = 123,
                CourageFactor = 1.2
            };
            TeamMember Taryn = new TeamMember()
            {
                FirstName = "Taryn",
                LastName = "Lytle",
                SkillLevel = 675,
                CourageFactor = 1.9
            };


            Console.WriteLine($"Name: {Colten.FullName()} \nSkill Level: {Colten.SkillLevel} \nCourage Factor: {Colten.CourageFactor}");

            List<TeamMember> TeamMemberList = new List<TeamMember>();

            TeamMemberList.Add(Colten);
            TeamMemberList.Add(Laurel);
            TeamMemberList.Add(Taryn);

        }
    }
}
