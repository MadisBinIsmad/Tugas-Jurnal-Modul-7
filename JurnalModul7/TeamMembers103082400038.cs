using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace JurnalModul7
{
    class TeamMembers103082400038
    {
        public class Member
        {
            public long nim { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
        }

        public class Root
        {
            public List<Member> members { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_2_103082400038.json");

            Root data = JsonSerializer.Deserialize<Root>(json);

            Console.WriteLine("Team member list:");

            foreach (var m in data.members)
            {
                Console.WriteLine(
                    m.nim + " " +
                    m.firstName + " " + m.lastName +
                    " (" + m.age + " " + m.gender + ")"
                );
            }
        }
    }
}
