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
    /// TokenStatusHistoryRequest
    /// </summary>
    [DataContract]
    public partial class TokenStatusHistoryRequest :  IEquatable<TokenStatusHistoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenStatusHistoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenStatusHistoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenStatusHistoryRequest" /> class.
        /// </summary>
        /// <param name="tokenUniqueReference">A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Length - 48 Characters (required).</param>
        /// <param name="auditInfo">auditInfo.</param>
        public TokenStatusHistoryRequest(string tokenUniqueReference = default(string), AuditInfo auditInfo = default(AuditInfo))
        {
            // to ensure "tokenUniqueReference" is required (not null)
            if (tokenUniqueReference == null)
            {
                throw new InvalidDataException("tokenUniqueReference is a required property for TokenStatusHistoryRequest and cannot be null");
            }
            else
            {
                this.TokenUniqueReference = tokenUniqueReference;
            }
            this.AuditInfo = auditInfo;
        }
        
        /// <summary>
        /// A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Length - 48 Characters
        /// </summary>
        /// <value>A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Length - 48 Characters</value>
        [DataMember(Name="TokenUniqueReference", EmitDefaultValue=false)]
        public string TokenUniqueReference { get; set; }

        /// <summary>
        /// Gets or Sets AuditInfo
        /// </summary>
        [DataMember(Name="AuditInfo", EmitDefaultValue=false)]
        public AuditInfo AuditInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenStatusHistoryRequest {\n");
            sb.Append("  TokenUniqueReference: ").Append(TokenUniqueReference).Append("\n");
            sb.Append("  AuditInfo: ").Append(AuditInfo).Append("\n");
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
            return this.Equals(input as TokenStatusHistoryRequest);
        }

        /// <summary>
        /// Returns true if TokenStatusHistoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenStatusHistoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenStatusHistoryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenUniqueReference == input.TokenUniqueReference ||
                    (this.TokenUniqueReference != null &&
                    this.TokenUniqueReference.Equals(input.TokenUniqueReference))
                ) && 
                (
                    this.AuditInfo == input.AuditInfo ||
                    (this.AuditInfo != null &&
                    this.AuditInfo.Equals(input.AuditInfo))
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
                if (this.TokenUniqueReference != null)
                    hashCode = hashCode * 59 + this.TokenUniqueReference.GetHashCode();
                if (this.AuditInfo != null)
                    hashCode = hashCode * 59 + this.AuditInfo.GetHashCode();
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
