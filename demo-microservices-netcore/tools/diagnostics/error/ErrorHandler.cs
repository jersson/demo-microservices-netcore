namespace demo_microservices_netcore.Diagnostics
{
    class ErrorHandler
    {
        private System.Exception _errorInformation;
        public readonly int StatusCode;

        public ErrorHandler(int statusCode, System.Exception errorInformation){
            StatusCode = statusCode;
            _errorInformation = errorInformation;
        }
            public string ConsoleResponse()
            {
                var message = string.Format("Status:{0}, Message:{1}, StackTrace:{2}", StatusCode, _errorInformation.Message, _errorInformation.StackTrace); 

                return message;
            }

            public HttpErrorModel HttpResponse()
            {
                var httpError = new HttpErrorModel {StatusCode = StatusCode, Message = "Internal error", Type = "Internal"};
               
                return httpError;
            }
        }
}