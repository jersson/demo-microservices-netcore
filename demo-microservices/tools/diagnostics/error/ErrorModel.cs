namespace demo_microservices_netcore.Diagnostics
{
    class ErrorModel
    {
        public int StatusCode { get; set; }
        
        public string Message { get; set; }

        public string StackTrace {get;set;}

    }
}