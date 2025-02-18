// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The PiiEntitiesDocumentResult. </summary>
    internal partial class PiiEntitiesDocumentResult : DocumentResult
    {
        /// <summary> Initializes a new instance of PiiEntitiesDocumentResult. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="redactedText"/> or <paramref name="entities"/> is null. </exception>
        public PiiEntitiesDocumentResult(string id, IEnumerable<DocumentWarning> warnings, string redactedText, IEnumerable<Entity> entities) : base(id, warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(redactedText, nameof(redactedText));
            Argument.AssertNotNull(entities, nameof(entities));

            RedactedText = redactedText;
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of PiiEntitiesDocumentResult. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        internal PiiEntitiesDocumentResult(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, string redactedText, IList<Entity> entities) : base(id, warnings, statistics)
        {
            RedactedText = redactedText;
            Entities = entities;
        }

        /// <summary> Returns redacted text. </summary>
        public string RedactedText { get; set; }
        /// <summary> Recognized entities in the document. </summary>
        public IList<Entity> Entities { get; }
    }
}
