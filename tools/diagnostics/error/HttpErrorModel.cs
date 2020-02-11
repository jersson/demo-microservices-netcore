namespace demo_microservices_netcore.Diagnostics
{
    class HttpErrorModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public string Type { get; set; }

    }
}