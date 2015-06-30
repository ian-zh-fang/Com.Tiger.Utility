using System.Net;

namespace Com.Tiger.Utility.Http
{
    /// <summary>
    /// API to obtain the contents of the specified URL
    /// </summary>
    public interface IHttpClient
    {
        /// <summary>
        /// Execute and obtain the content information for the specified URL.
        /// </summary>
        /// <param name="url">Uniform Resource Locator.</param>
        /// <param name="parameters">Request for additional information parameters.</param>
        /// <returns>The content information for the specified URL.</returns>
        WebResponse exec(string url, params string[] parameters);
    }
}