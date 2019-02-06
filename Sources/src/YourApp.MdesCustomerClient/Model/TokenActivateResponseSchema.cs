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
    /// TokenActivateResponseSchema
    /// </summary>
    [DataContract]
    public partial class TokenActivateResponseSchema :  IEquatable<TokenActivateResponseSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenActivateResponseSchema" /> class.
        /// </summary>
        /// <param name="tokenActivateResponse">tokenActivateResponse.</param>
        public TokenActivateResponseSchema(SimpleTokenResponse tokenActivateResponse = default(SimpleTokenResponse))
        {
            this.TokenActivateResponse = tokenActivateResponse;
        }
        
        /// <summary>
        /// Gets or Sets TokenActivateResponse
        /// </summary>
        [DataMember(Name="TokenActivateResponse", EmitDefaultValue=false)]
        public SimpleTokenResponse TokenActivateResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenActivateResponseSchema {\n");
            sb.Append("  TokenActivateResponse: ").Append(TokenActivateResponse).Append("\n");
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
            return this.Equals(input as TokenActivateResponseSchema);
        }

        /// <summary>
        /// Returns true if TokenActivateResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenActivateResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenActivateResponseSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenActivateResponse == input.TokenActivateResponse ||
                    (this.TokenActivateResponse != null &&
                    this.TokenActivateResponse.Equals(input.TokenActivateResponse))
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
                if (this.TokenActivateResponse != null)
                    hashCode = hashCode * 59 + this.TokenActivateResponse.GetHashCode();
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