/*
 * LogicMonitor API-Ingest Rest API
 *
 * LogicMonitor is a SaaS-based performance monitoring platform that provides full visibility into complex, hybrid infrastructures, offering granular performance monitoring and actionable data and insights. API-Ingest provides the entry point in the form of public rest APIs for ingesting metrics into LogicMonitor. For using this application users have to create LMAuth token using access id and key from santaba.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace LogicMonitor.DataSDK.Model
{
    /// <summary>
    /// RestDataSourceInstanceV1
    /// </summary>
    [DataContract(Name = "RestDataSourceInstanceV1")]
    public partial class RestDataSourceInstanceV1 : IEquatable<RestDataSourceInstanceV1>, IValidatableObject
    {
        public RestDataSourceInstanceV1()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestDataSourceInstanceV1" /> class.
        /// </summary>
        /// <param name="dataPoints">dataPoints.</param>
        /// <param name="instanceDescription">instanceDescription.</param>
        /// <param name="instanceDisplayName">instanceDisplayName.</param>
        /// <param name="instanceGroup">instanceGroup.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="instanceName">instanceName.</param>
        /// <param name="instanceProperties">instanceProperties.</param>
        /// <param name="instanceWildValue">instanceWildValue.</param>
        public RestDataSourceInstanceV1(List<RestDataPointV1> dataPoints = default(List<RestDataPointV1>), string instanceDescription = default(string), string instanceDisplayName = default(string), string instanceGroup = default(string), int instanceId = default(int), string instanceName = default(string), Dictionary<string, string> instanceProperties = default(Dictionary<string, string>), string instanceWildValue = default(string))
        {
            this.DataPoints = dataPoints;
            this.InstanceDescription = instanceDescription;
            this.InstanceDisplayName = instanceDisplayName;
            this.InstanceGroup = instanceGroup;
            this.InstanceId = instanceId;
            this.InstanceName = instanceName;
            this.InstanceProperties = instanceProperties;
            this.InstanceWildValue = instanceWildValue;
        }

        /// <summary>
        /// Gets or Sets DataPoints
        /// </summary>
        [DataMember(Name = "dataPoints", EmitDefaultValue = false)]
        public List<RestDataPointV1> DataPoints { get; set; }

        /// <summary>
        /// Gets or Sets InstanceDescription
        /// </summary>
        [DataMember(Name = "instanceDescription", EmitDefaultValue = false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// Gets or Sets InstanceDisplayName
        /// </summary>
        [DataMember(Name = "instanceDisplayName", EmitDefaultValue = false)]
        public string InstanceDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets InstanceGroup
        /// </summary>
        [DataMember(Name = "instanceGroup", EmitDefaultValue = false)]
        public string InstanceGroup { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", EmitDefaultValue = false)]
        public int InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets InstanceName
        /// </summary>
        [DataMember(Name = "instanceName", EmitDefaultValue = false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or Sets InstanceProperties
        /// </summary>
        [DataMember(Name = "instanceProperties", EmitDefaultValue = false)]
        public Dictionary<string, string> InstanceProperties { get; set; }

        /// <summary>
        /// Gets or Sets InstanceWildValue
        /// </summary>
        [DataMember(Name = "instanceWildValue", EmitDefaultValue = false)]
        public string InstanceWildValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestDataSourceInstanceV1 {\n");
            sb.Append("  DataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("  InstanceDescription: ").Append(InstanceDescription).Append("\n");
            sb.Append("  InstanceDisplayName: ").Append(InstanceDisplayName).Append("\n");
            sb.Append("  InstanceGroup: ").Append(InstanceGroup).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  InstanceProperties: ").Append(InstanceProperties).Append("\n");
            sb.Append("  InstanceWildValue: ").Append(InstanceWildValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestDataSourceInstanceV1);
        }

        /// <summary>
        /// Returns true if RestDataSourceInstanceV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of RestDataSourceInstanceV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestDataSourceInstanceV1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataPoints == input.DataPoints ||
                    this.DataPoints != null &&
                    input.DataPoints != null &&
                    this.DataPoints.SequenceEqual(input.DataPoints)
                ) && 
                (
                    this.InstanceDescription == input.InstanceDescription ||
                    (this.InstanceDescription != null &&
                    this.InstanceDescription.Equals(input.InstanceDescription))
                ) && 
                (
                    this.InstanceDisplayName == input.InstanceDisplayName ||
                    (this.InstanceDisplayName != null &&
                    this.InstanceDisplayName.Equals(input.InstanceDisplayName))
                ) && 
                (
                    this.InstanceGroup == input.InstanceGroup ||
                    (this.InstanceGroup != null &&
                    this.InstanceGroup.Equals(input.InstanceGroup))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    this.InstanceId.Equals(input.InstanceId)
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.InstanceProperties == input.InstanceProperties ||
                    this.InstanceProperties != null &&
                    input.InstanceProperties != null &&
                    this.InstanceProperties.SequenceEqual(input.InstanceProperties)
                ) && 
                (
                    this.InstanceWildValue == input.InstanceWildValue ||
                    (this.InstanceWildValue != null &&
                    this.InstanceWildValue.Equals(input.InstanceWildValue))
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
                if (this.DataPoints != null)
                    hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                if (this.InstanceDescription != null)
                    hashCode = hashCode * 59 + this.InstanceDescription.GetHashCode();
                if (this.InstanceDisplayName != null)
                    hashCode = hashCode * 59 + this.InstanceDisplayName.GetHashCode();
                if (this.InstanceGroup != null)
                    hashCode = hashCode * 59 + this.InstanceGroup.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceProperties != null)
                    hashCode = hashCode * 59 + this.InstanceProperties.GetHashCode();
                if (this.InstanceWildValue != null)
                    hashCode = hashCode * 59 + this.InstanceWildValue.GetHashCode();
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