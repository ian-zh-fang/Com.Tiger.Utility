using System.Net;

namespace Com.Tiger.Utility.Http
{
    public abstract class HttpClientBase : IHttpClient
    {
        /// <summary>
        /// The name of the configuration information in the configuration file specified node
        /// </summary>
        private const string SECTIONNAME = "com.tiger.utility.Http";

        /// <summary>
        /// Initialize static variables.
        /// <para>Initialize static readonly variables.</para>
        /// </summary>
        static HttpClientBase()
        {

        }

        /// <summary>
        /// Execute and obtain the content information for the specified URL.
        /// </summary>
        /// <param name="url">Uniform Resource Locator.</param>
        /// <param name="parameters">Request for additional information parameters.</param>
        /// <returns>The content information for the specified URL.</returns>
        public virtual WebResponse exec(string url, params string[] parameters)
        {
            HttpWebRequest request = CreateRequest(url, parameters);
            WebResponse response = request.GetResponse();
            response.Dispose();
            return response;
        }

        /// <summary>
        /// Create an instance of System.Net.HttpWebRequest.
        /// </summary>
        /// <param name="url">Uniform Resource Locator.</param>
        /// <param name="parameters">Request for additional information parameters.</param>
        /// <returns>An instance of System.Net.HttpWebRequest.</returns>
        protected abstract HttpWebRequest CreateRequest(string url, params string[] parameters);
    }
}