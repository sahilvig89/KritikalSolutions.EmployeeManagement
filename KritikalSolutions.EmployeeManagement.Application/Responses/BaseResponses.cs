using System.Collections.Generic;

namespace KritikalSolutions.EmployeeManagement.Application.Responses
{
    public class BaseResponses
    {
        public BaseResponses()
        {
            this.Success = true;
        }
        public BaseResponses(string message)
        {
            Success = true;
            Message = message;
        }
        public BaseResponses(string message, bool success)
        {
            Success = success;
            Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> ValidationErrors { get; set; }
    }
}
