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
    /// TokenStatusHistoryRequestSchema
    /// </summary>
    [DataContract]
    public partial class TokenStatusHistoryRequestSchema :  IEquatable<TokenStatusHistoryRequestSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenStatusHistoryRequestSchema" /> class.
        /// </summary>
        /// <param name="tokenStatusHistoryRequest">tokenStatusHistoryRequest.</param>
        public TokenStatusHistoryRequestSchema(TokenStatusHistoryRequest tokenStatusHistoryRequest = default(TokenStatusHistoryRequest))
        {
            this.TokenStatusHistoryRequest = tokenStatusHistoryRequest;
        }
        
        /// <summary>
        /// Gets or Sets TokenStatusHistoryRequest
        /// </summary>
        [DataMember(Name="TokenStatusHistoryRequest", EmitDefaultValue=false)]
        public TokenStatusHistoryRequest TokenStatusHistoryRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenStatusHistoryRequestSchema {\n");
            sb.Append("  TokenStatusHistoryRequest: ").Append(TokenStatusHistoryRequest).Append("\n");
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
            return this.Equals(input as TokenStatusHistoryRequestSchema);
        }

        /// <summary>
        /// Returns true if TokenStatusHistoryRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenStatusHistoryRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenStatusHistoryRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenStatusHistoryRequest == input.TokenStatusHistoryRequest ||
                    (this.TokenStatusHistoryRequest != null &&
                    this.TokenStatusHistoryRequest.Equals(input.TokenStatusHistoryRequest))
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
                if (this.TokenStatusHistoryRequest != null)
                    hashCode = hashCode * 59 + this.TokenStatusHistoryRequest.GetHashCode();
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
