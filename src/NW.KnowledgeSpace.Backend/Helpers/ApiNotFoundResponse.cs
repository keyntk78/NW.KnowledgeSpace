namespace NW.KnowledgeSpace.Backend.Helpers
{
    public class ApiNotFoundResponse : ApiResponse
    {
        public ApiNotFoundResponse(string message)
            : base(404, message)
        {
        }
    }
}
