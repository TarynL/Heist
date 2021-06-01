using System;

namespace Heist
{
    public class TeamMember
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SkillLevel { get; set; }

        public double CourageFactor { get; set; }

        public string FullName()
        {
            return ($"{FirstName} {LastName}");
        }


    }
}