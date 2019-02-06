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
    /// Suspenders
    /// </summary>
    [DataContract]
    public partial class Suspenders :  IEquatable<Suspenders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Suspenders" /> class.
        /// </summary>
        /// <param name="suspender">Suspender(s) of the token when the token current status is SUSPENDED. Conditional field, only present when token mapping is suspended. Valid values:&lt;br /&gt;    \&quot;I\&quot; - The issuer has requested token suspension.&lt;br /&gt;    \&quot;W\&quot; - Token Requestor (including Wallet Provider) has requested token suspension.&lt;br /&gt;    \&quot;C\&quot; - The cardholder has requested token suspension.&lt;br /&gt;    \&quot;P\&quot; - The Mobile PIN Validation service has requested token suspension. Occurs when the cardholder has entered their Mobile PIN incorrectly too many times whilst performing a transaction.&lt;br /&gt;    \&quot;M\&quot; - The Mobile PIN Change Validation service has requested token suspension. Occurs when the cardholder has entered their Mobile PIN incorrectly too many times whilst changing their mobile pin..</param>
        public Suspenders(List<string> suspender = default(List<string>))
        {
            this.Suspender = suspender;
        }
        
        /// <summary>
        /// Suspender(s) of the token when the token current status is SUSPENDED. Conditional field, only present when token mapping is suspended. Valid values:&lt;br /&gt;    \&quot;I\&quot; - The issuer has requested token suspension.&lt;br /&gt;    \&quot;W\&quot; - Token Requestor (including Wallet Provider) has requested token suspension.&lt;br /&gt;    \&quot;C\&quot; - The cardholder has requested token suspension.&lt;br /&gt;    \&quot;P\&quot; - The Mobile PIN Validation service has requested token suspension. Occurs when the cardholder has entered their Mobile PIN incorrectly too many times whilst performing a transaction.&lt;br /&gt;    \&quot;M\&quot; - The Mobile PIN Change Validation service has requested token suspension. Occurs when the cardholder has entered their Mobile PIN incorrectly too many times whilst changing their mobile pin.
        /// </summary>
        /// <value>Suspender(s) of the token when the token current status is SUSPENDED. Conditional field, only present when token mapping is suspended. Valid values:&lt;br /&gt;    \&quot;I\&quot; - The issuer has requested token suspension.&lt;br /&gt;    \&quot;W\&quot; - Token Requestor (including Wallet Provider) has requested token suspension.&lt;br /&gt;    \&quot;C\&quot; - The cardholder has requested token suspension.&lt;br /&gt;    \&quot;P\&quot; - The Mobile PIN Validation service has requested token suspension. Occurs when the cardholder has entered their Mobile PIN incorrectly too many times whilst performing a transaction.&lt;br /&gt;    \&quot;M\&quot; - The Mobile PIN Change Validation service has requested token suspension. Occurs when the cardholder has entered their Mobile PIN incorrectly too many times whilst changing their mobile pin.</value>
        [DataMember(Name="Suspender", EmitDefaultValue=false)]
        public List<string> Suspender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Suspenders {\n");
            sb.Append("  Suspender: ").Append(Suspender).Append("\n");
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
            return this.Equals(input as Suspenders);
        }

        /// <summary>
        /// Returns true if Suspenders instances are equal
        /// </summary>
        /// <param name="input">Instance of Suspenders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Suspenders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Suspender == input.Suspender ||
                    this.Suspender != null &&
                    this.Suspender.SequenceEqual(input.Suspender)
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
                if (this.Suspender != null)
                    hashCode = hashCode * 59 + this.Suspender.GetHashCode();
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
