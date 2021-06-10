namespace Console.Cognitive.FormAnalyzer.Models
{
    public class Line
    {
        public int[] BoundingBox { get; set; }
        public string Text { get; set; }
        public Word[] Words { get; set; }
    }
}