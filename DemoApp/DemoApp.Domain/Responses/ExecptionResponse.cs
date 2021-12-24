namespace DemoApp.Domain.Responses
{
    public class ExecptionResponse
    {
        public string? ConsolidatedErrorMessage { get; set; }
        public List<KeyValuePair<string, string[]>> ErrorMessages { get; set; } = new ();

    }
}
