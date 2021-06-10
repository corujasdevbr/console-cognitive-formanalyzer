namespace Console.Cognitive.FormAnalyzer.Models
{
    public class Word
    {
        public int[] BoundingBox { get; set; }
        public string Text { get; set; }
        public float Confidence { get; set; }
    }
}