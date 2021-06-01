using System;

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



        }
    }
}
