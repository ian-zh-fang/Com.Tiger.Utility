using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Com.Tiger.Utility.Http
{
    public sealed class HttpPost : HttpClientBase
    {
        /// <summary>
        /// Create an instance of System.Net.HttpWebRequest based on POST method.
        /// </summary>
        /// <param name="url">Uniform Resource Locator.</param>
        /// <param name="parameters">Request for additional information parameters.</param>
        /// <returns>An instance of System.Net.HttpWebRequest.</returns>
        protected override HttpWebRequest CreateRequest(string url, params string[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}