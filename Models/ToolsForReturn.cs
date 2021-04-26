using System;

namespace desafio01.Models
{
    public class ToolsForReturn
    {
        public Guid Id { get; set; }
        public string Link { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string[] Tags { get; set; }
    }
}