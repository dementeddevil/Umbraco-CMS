﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace Umbraco.Web.WebApi
{
    /// <summary>
    /// This will format the JSON output for use with AngularJs's approach to JSON Vulnerability attacks
    /// </summary>
    /// <remarks>
    /// See: http://docs.angularjs.org/api/ng.$http (Security considerations)
    /// </remarks>
    public class AngularJsonMediaTypeFormatter : JsonMediaTypeFormatter
    {

        public const string XsrfPrefix = ")]}',\n";

        /// <summary>
        /// This will prepend the special chars to the stream output that angular will strip
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="writeStream"></param>
        /// <param name="content"></param>
        /// <param name="transportContext"></param>
        /// <returns></returns>
        public override async Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            if (writeStream == null) throw new ArgumentNullException(nameof(writeStream));

            var effectiveEncoding = SelectCharacterEncoding(content == null ? null : content.Headers);

            using (var streamWriter = new StreamWriter(writeStream, effectiveEncoding, 
                //we are only writing a few chars so we don't need to allocate a large buffer
                128, 
                //this is important! We don't want to close the stream, the base class is in charge of stream management, we just want to write to it.
                leaveOpen:true))
            {
                //write the special encoding for angular json to the start
                // (see: http://docs.angularjs.org/api/ng.$http)
                streamWriter.Write(XsrfPrefix);
                streamWriter.Flush();
                await base.WriteToStreamAsync(type, value, writeStream, content, transportContext);
            }
        }

    }
}
