/* 
 * MDES Customer Service
 *
 * This API provides our Issuer partners with resources to help resolve consumer queries about payment accounts enabled through our digitization platform.
 *
 * OpenAPI spec version: 2.0.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YourApp.MdesCustomerClient.Client.OpenAPIDateConverter;

namespace YourApp.MdesCustomerClient.Model
{
    /// <summary>
    /// Error
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="source">Unique identifier that attempts to define the field in error when available.  If a specific field can&#39;t be identified, \&quot;System\&quot; will be returned..</param>
        /// <param name="reasonCode">Indicator that identifies the reason for the error..</param>
        /// <param name="errorCode">An identifier that represents additional detail for the reason of the error..</param>
        /// <param name="description">A textual description of the error that is appropriate for logging and may communicate additional details related to the reason code..</param>
        /// <param name="recoverable">An indicator stating whether it is reasonable to retry a failed request..</param>
        public Error(string source = default(string), string reasonCode = default(string), string errorCode = default(string), string description = default(string), string recoverable = default(string))
        {
            this.Source = source;
            this.ReasonCode = reasonCode;
            this.ErrorCode = errorCode;
            this.Description = description;
            this.Recoverable = recoverable;
        }
        
        /// <summary>
        /// Unique identifier that attempts to define the field in error when available.  If a specific field can&#39;t be identified, \&quot;System\&quot; will be returned.
        /// </summary>
        /// <value>Unique identifier that attempts to define the field in error when available.  If a specific field can&#39;t be identified, \&quot;System\&quot; will be returned.</value>
        [DataMember(Name="Source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Indicator that identifies the reason for the error.
        /// </summary>
        /// <value>Indicator that identifies the reason for the error.</value>
        [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// An identifier that represents additional detail for the reason of the error.
        /// </summary>
        /// <value>An identifier that represents additional detail for the reason of the error.</value>
        [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A textual description of the error that is appropriate for logging and may communicate additional details related to the reason code.
        /// </summary>
        /// <value>A textual description of the error that is appropriate for logging and may communicate additional details related to the reason code.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An indicator stating whether it is reasonable to retry a failed request.
        /// </summary>
        /// <value>An indicator stating whether it is reasonable to retry a failed request.</value>
        [DataMember(Name="Recoverable", EmitDefaultValue=false)]
        public string Recoverable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Recoverable: ").Append(Recoverable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Recoverable == input.Recoverable ||
                    (this.Recoverable != null &&
                    this.Recoverable.Equals(input.Recoverable))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Recoverable != null)
                    hashCode = hashCode * 59 + this.Recoverable.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
