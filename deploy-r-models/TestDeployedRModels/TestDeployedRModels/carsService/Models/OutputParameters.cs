// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestDeployedRModels.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class OutputParameters
    {
        /// <summary>
        /// Initializes a new instance of the OutputParameters class.
        /// </summary>
        public OutputParameters() { }

        /// <summary>
        /// Initializes a new instance of the OutputParameters class.
        /// </summary>
        public OutputParameters(double? answer = default(double?))
        {
            Answer = answer;
        }

        /// <summary>
        /// numeric
        /// </summary>
        [JsonProperty(PropertyName = "answer")]
        public double? Answer { get; set; }

    }
}
