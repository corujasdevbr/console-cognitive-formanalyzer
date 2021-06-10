using System.Collections.Generic;

namespace Console.Cognitive.FormAnalyzer.Models
{
    public class AnalyzeResult
    {
        public string Version { get; set; }
        public ReadResult[] ReadResults { get; set; }
    }
}