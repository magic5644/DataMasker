using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DataMasker.Models
{
    /// <summary>
    /// DataGenerationConfig
    /// </summary>
    public class DataGenerationConfig
    {
        public static readonly DataGenerationConfig Default = new DataGenerationConfig();

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        public string Locale { get; set; }
    }
}
