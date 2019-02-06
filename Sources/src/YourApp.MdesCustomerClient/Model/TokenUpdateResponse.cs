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
    /// TokenUpdateResponse
    /// </summary>
    [DataContract]
    public partial class TokenUpdateResponse :  IEquatable<TokenUpdateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUpdateResponse" /> class.
        /// </summary>
        /// <param name="tokens">tokens.</param>
        public TokenUpdateResponse(TokenUpdateTokens tokens = default(TokenUpdateTokens))
        {
            this.Tokens = tokens;
        }
        
        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="Tokens", EmitDefaultValue=false)]
        public TokenUpdateTokens Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenUpdateResponse {\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(input as TokenUpdateResponse);
        }

        /// <summary>
        /// Returns true if TokenUpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenUpdateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tokens == input.Tokens ||
                    (this.Tokens != null &&
                    this.Tokens.Equals(input.Tokens))
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
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
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