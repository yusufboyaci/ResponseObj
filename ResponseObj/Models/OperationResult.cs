namespace ResponseObj.Models
{
    public enum OperationResultType
    {
        Success = 1,
        Fail = 2,
        Warning = 3,
    }
    public class OperationResult
    {
        public OperationResultType ResultType { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
