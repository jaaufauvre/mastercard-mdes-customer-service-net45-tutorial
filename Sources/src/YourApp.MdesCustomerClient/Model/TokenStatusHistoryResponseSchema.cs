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
    /// TokenStatusHistoryResponseSchema
    /// </summary>
    [DataContract]
    public partial class TokenStatusHistoryResponseSchema :  IEquatable<TokenStatusHistoryResponseSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenStatusHistoryResponseSchema" /> class.
        /// </summary>
        /// <param name="tokenStatusHistoryResponse">tokenStatusHistoryResponse.</param>
        public TokenStatusHistoryResponseSchema(TokenStatusHistoryResponse tokenStatusHistoryResponse = default(TokenStatusHistoryResponse))
        {
            this.TokenStatusHistoryResponse = tokenStatusHistoryResponse;
        }
        
        /// <summary>
        /// Gets or Sets TokenStatusHistoryResponse
        /// </summary>
        [DataMember(Name="TokenStatusHistoryResponse", EmitDefaultValue=false)]
        public TokenStatusHistoryResponse TokenStatusHistoryResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenStatusHistoryResponseSchema {\n");
            sb.Append("  TokenStatusHistoryResponse: ").Append(TokenStatusHistoryResponse).Append("\n");
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
            return this.Equals(input as TokenStatusHistoryResponseSchema);
        }

        /// <summary>
        /// Returns true if TokenStatusHistoryResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenStatusHistoryResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenStatusHistoryResponseSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenStatusHistoryResponse == input.TokenStatusHistoryResponse ||
                    (this.TokenStatusHistoryResponse != null &&
                    this.TokenStatusHistoryResponse.Equals(input.TokenStatusHistoryResponse))
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
                if (this.TokenStatusHistoryResponse != null)
                    hashCode = hashCode * 59 + this.TokenStatusHistoryResponse.GetHashCode();
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