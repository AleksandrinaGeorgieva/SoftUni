using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Town
    {
        public string name { get; set; }
        public int seats { get; set; }
        public List<Student> students { get; set; }

        public int groupsCount { get; set; }

        public List<Group> groups { get; set; }

        public void GenerateGroups()
        {
            groupsCount = (int)Math.Ceiling((double)students.Count / seats);
            students = students
                .OrderBy(x => x.registrationDate)
                .ThenBy(x => x.name)
                .ThenBy(x => x.email)
                .ToList();
            groups = new List<Group>();
            for (int i = 0; i < groupsCount; i++)
            {
                var st = students
                    .Skip(i * seats)
                    .Take(seats)
                    .Select(x => x.email)
                    .ToList();
                var group = new Group
                {
                    memberEmails = st
                };
                groups.Add(group);
            }
        }
    }
}
