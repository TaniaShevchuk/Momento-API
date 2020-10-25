namespace App.Domain
{
    public class AppResponse
    {
        private ErrorLevel errorLevel = ErrorLevel.None;
        private ErrorType errorType = ErrorType.None;

        public bool Success { get; set; }
        public string Message { get; set; }

        public ErrorLevel ErrorCode
        {
            get => errorLevel == ErrorLevel.None && !Success && !string.IsNullOrWhiteSpace(Message)
                ? errorLevel = ErrorLevel.High
                : errorLevel;
            set => errorLevel = value;
        }

        public ErrorType ErrorType
        {
            get => errorType == ErrorType.None && !Success && !string.IsNullOrWhiteSpace(Message)
                ? ErrorType.None
                : errorType;
            set => errorType = value;

        }

        public AppResponse() { }

        public AppResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }

    public class AppResponse<T>
    {
        private ErrorLevel errorLevel = ErrorLevel.None;
        private ErrorType errorType = ErrorType.None;

        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }

        public ErrorLevel ErrorLevel
        {
            get => errorLevel == ErrorLevel.None && !Success && !string.IsNullOrWhiteSpace(Message)
                ? ErrorLevel.High
                : errorLevel;
            set => errorLevel = value;
        }

        public ErrorType ErrorType
        {
            get => errorType == ErrorType.None && !Success && !string.IsNullOrWhiteSpace(Message)
                ? ErrorType.Exception
                : ErrorType.None;
            set => errorType = value;
        }

        public AppResponse() {}

        public AppResponse(bool success)
        {
            Success = success;
        }

        public AppResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public AppResponse(bool success, T result)
        {
            Success = success;
            Result = result;
        }

        public AppResponse(bool success, T result, string message)
        {
            Success = success;
            Result = result;
            Message = message;
        }
    }

    public enum ErrorLevel
    {
        None,
        High
    }
    
    public enum ErrorType
    {
        None, 
        Exception,
        Validation
    }
}
