using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JurnalModul7
{
    class GlossaryItem103082400038
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossDiv
        {
            public GlossList GlossList { get; set; }
        }

        public class Glossary
        {
            public GlossDiv GlossDiv { get; set; }
        }

        public class Root
        {
            public Glossary glossary { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_3_103082400038.json");

            Root data = JsonSerializer.Deserialize<Root>(json);

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("GlossEntry:");
            Console.WriteLine("ID: " + entry.ID);
            Console.WriteLine("Term: " + entry.GlossTerm);
            Console.WriteLine("Acronym: " + entry.Acronym);
            Console.WriteLine("Abbrev: " + entry.Abbrev);
            Console.WriteLine("Definisi: " + entry.GlossDef.para);

            Console.WriteLine("See Also:");
            foreach (var item in entry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}
