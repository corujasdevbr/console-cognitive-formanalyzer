using System.Collections.Generic;

namespace Console.Cognitive.FormAnalyzer.Models
{
    public class ReadResult
    {
        public int Page { get; set; }
        public int Angle { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Unit { get; set; }
        public string Language { get; set; }
        public Line[] Lines { get; set; }
    }
}