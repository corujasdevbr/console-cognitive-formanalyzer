namespace Console.Cognitive.FormAnalyzer.Models
{
    public class ResultFormAnalyzer
    {
        public string Status { get; set; }
        public string CreatedDateTime { get; set; }
        public string LastUpdatedDateTime { get; set; }
        public AnalyzeResult AnalyzeResult { get; set; }
    }
}
