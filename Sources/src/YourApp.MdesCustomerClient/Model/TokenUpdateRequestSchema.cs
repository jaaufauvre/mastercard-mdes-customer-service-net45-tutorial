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
    /// TokenUpdateRequestSchema
    /// </summary>
    [DataContract]
    public partial class TokenUpdateRequestSchema :  IEquatable<TokenUpdateRequestSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUpdateRequestSchema" /> class.
        /// </summary>
        /// <param name="tokenUpdateRequest">tokenUpdateRequest.</param>
        public TokenUpdateRequestSchema(TokenUpdateRequest tokenUpdateRequest = default(TokenUpdateRequest))
        {
            this.TokenUpdateRequest = tokenUpdateRequest;
        }
        
        /// <summary>
        /// Gets or Sets TokenUpdateRequest
        /// </summary>
        [DataMember(Name="TokenUpdateRequest", EmitDefaultValue=false)]
        public TokenUpdateRequest TokenUpdateRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenUpdateRequestSchema {\n");
            sb.Append("  TokenUpdateRequest: ").Append(TokenUpdateRequest).Append("\n");
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
            return this.Equals(input as TokenUpdateRequestSchema);
        }

        /// <summary>
        /// Returns true if TokenUpdateRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenUpdateRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenUpdateRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenUpdateRequest == input.TokenUpdateRequest ||
                    (this.TokenUpdateRequest != null &&
                    this.TokenUpdateRequest.Equals(input.TokenUpdateRequest))
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
                if (this.TokenUpdateRequest != null)
                    hashCode = hashCode * 59 + this.TokenUpdateRequest.GetHashCode();
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