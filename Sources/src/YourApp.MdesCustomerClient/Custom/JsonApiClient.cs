using RestSharp;

namespace YourApp.MdesCustomerClient.Client
{
    /// <summary>
    /// Extends the generated ApiClient class.
    /// </summary>
    public partial class ApiClient
    {
        /// <summary>
        /// Adds "Format=JSON" to the RestSharp request so that the service accepts and returns JSON instead of XML.
        /// </summary>
        partial void InterceptRequest(IRestRequest request) => request.AddQueryParameter("Format", "JSON");
    }
}
