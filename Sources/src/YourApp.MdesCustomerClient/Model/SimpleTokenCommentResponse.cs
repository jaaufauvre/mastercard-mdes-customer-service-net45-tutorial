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
    /// SimpleTokenCommentResponse
    /// </summary>
    [DataContract]
    public partial class SimpleTokenCommentResponse :  IEquatable<SimpleTokenCommentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleTokenCommentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimpleTokenCommentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleTokenCommentResponse" /> class.
        /// </summary>
        /// <param name="tokenUniqueReference">A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Length - 48 Characters (required).</param>
        /// <param name="commentId">Identifier of the comment added. Only present when comment text was provided in the request..</param>
        public SimpleTokenCommentResponse(string tokenUniqueReference = default(string), string commentId = default(string))
        {
            // to ensure "tokenUniqueReference" is required (not null)
            if (tokenUniqueReference == null)
            {
                throw new InvalidDataException("tokenUniqueReference is a required property for SimpleTokenCommentResponse and cannot be null");
            }
            else
            {
                this.TokenUniqueReference = tokenUniqueReference;
            }
            this.CommentId = commentId;
        }
        
        /// <summary>
        /// A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Length - 48 Characters
        /// </summary>
        /// <value>A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Length - 48 Characters</value>
        [DataMember(Name="TokenUniqueReference", EmitDefaultValue=false)]
        public string TokenUniqueReference { get; set; }

        /// <summary>
        /// Identifier of the comment added. Only present when comment text was provided in the request.
        /// </summary>
        /// <value>Identifier of the comment added. Only present when comment text was provided in the request.</value>
        [DataMember(Name="CommentId", EmitDefaultValue=false)]
        public string CommentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleTokenCommentResponse {\n");
            sb.Append("  TokenUniqueReference: ").Append(TokenUniqueReference).Append("\n");
            sb.Append("  CommentId: ").Append(CommentId).Append("\n");
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
            return this.Equals(input as SimpleTokenCommentResponse);
        }

        /// <summary>
        /// Returns true if SimpleTokenCommentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleTokenCommentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleTokenCommentResponse input)
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
                    this.CommentId == input.CommentId ||
                    (this.CommentId != null &&
                    this.CommentId.Equals(input.CommentId))
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
                if (this.CommentId != null)
                    hashCode = hashCode * 59 + this.CommentId.GetHashCode();
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
