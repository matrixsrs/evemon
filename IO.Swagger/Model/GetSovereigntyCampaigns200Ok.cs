/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetSovereigntyCampaigns200Ok :  IEquatable<GetSovereigntyCampaigns200Ok>, IValidatableObject
    {
        /// <summary>
        /// Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \&quot;Defense Events\&quot;, station_freeport as \&quot;Freeport Events\&quot;. 
        /// </summary>
        /// <value>Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \&quot;Defense Events\&quot;, station_freeport as \&quot;Freeport Events\&quot;. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum Tcudefense for "tcu_defense"
            /// </summary>
            [EnumMember(Value = "tcu_defense")]
            Tcudefense,
            
            /// <summary>
            /// Enum Ihubdefense for "ihub_defense"
            /// </summary>
            [EnumMember(Value = "ihub_defense")]
            Ihubdefense,
            
            /// <summary>
            /// Enum Stationdefense for "station_defense"
            /// </summary>
            [EnumMember(Value = "station_defense")]
            Stationdefense,
            
            /// <summary>
            /// Enum Stationfreeport for "station_freeport"
            /// </summary>
            [EnumMember(Value = "station_freeport")]
            Stationfreeport
        }

        /// <summary>
        /// Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \&quot;Defense Events\&quot;, station_freeport as \&quot;Freeport Events\&quot;. 
        /// </summary>
        /// <value>Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \&quot;Defense Events\&quot;, station_freeport as \&quot;Freeport Events\&quot;. </value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSovereigntyCampaigns200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSovereigntyCampaigns200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSovereigntyCampaigns200Ok" /> class.
        /// </summary>
        /// <param name="AttackersScore">Score for all attacking parties, only present in Defense Events. .</param>
        /// <param name="CampaignId">Unique ID for this campaign. (required).</param>
        /// <param name="ConstellationId">The constellation in which the campaign will take place.  (required).</param>
        /// <param name="DefenderId">Defending alliance, only present in Defense Events .</param>
        /// <param name="DefenderScore">Score for the defending alliance, only present in Defense Events. .</param>
        /// <param name="EventType">Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \&quot;Defense Events\&quot;, station_freeport as \&quot;Freeport Events\&quot;.  (required).</param>
        /// <param name="Participants">Alliance participating and their respective scores, only present in Freeport Events. .</param>
        /// <param name="SolarSystemId">The solar system the structure is located in.  (required).</param>
        /// <param name="StartTime">Time the event is scheduled to start.  (required).</param>
        /// <param name="StructureId">The structure item ID that is related to this campaign.  (required).</param>
        public GetSovereigntyCampaigns200Ok(float? AttackersScore = default(float?), int? CampaignId = default(int?), int? ConstellationId = default(int?), int? DefenderId = default(int?), float? DefenderScore = default(float?), EventTypeEnum? EventType = default(EventTypeEnum?), List<GetSovereigntyCampaignsParticipant> Participants = default(List<GetSovereigntyCampaignsParticipant>), int? SolarSystemId = default(int?), DateTime? StartTime = default(DateTime?), long? StructureId = default(long?))
        {
            // to ensure "CampaignId" is required (not null)
            if (CampaignId == null)
            {
                throw new InvalidDataException("CampaignId is a required property for GetSovereigntyCampaigns200Ok and cannot be null");
            }
            else
            {
                this.CampaignId = CampaignId;
            }
            // to ensure "ConstellationId" is required (not null)
            if (ConstellationId == null)
            {
                throw new InvalidDataException("ConstellationId is a required property for GetSovereigntyCampaigns200Ok and cannot be null");
            }
            else
            {
                this.ConstellationId = ConstellationId;
            }
            // to ensure "EventType" is required (not null)
            if (EventType == null)
            {
                throw new InvalidDataException("EventType is a required property for GetSovereigntyCampaigns200Ok and cannot be null");
            }
            else
            {
                this.EventType = EventType;
            }
            // to ensure "SolarSystemId" is required (not null)
            if (SolarSystemId == null)
            {
                throw new InvalidDataException("SolarSystemId is a required property for GetSovereigntyCampaigns200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = SolarSystemId;
            }
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
            {
                throw new InvalidDataException("StartTime is a required property for GetSovereigntyCampaigns200Ok and cannot be null");
            }
            else
            {
                this.StartTime = StartTime;
            }
            // to ensure "StructureId" is required (not null)
            if (StructureId == null)
            {
                throw new InvalidDataException("StructureId is a required property for GetSovereigntyCampaigns200Ok and cannot be null");
            }
            else
            {
                this.StructureId = StructureId;
            }
            this.AttackersScore = AttackersScore;
            this.DefenderId = DefenderId;
            this.DefenderScore = DefenderScore;
            this.Participants = Participants;
        }
        
        /// <summary>
        /// Score for all attacking parties, only present in Defense Events. 
        /// </summary>
        /// <value>Score for all attacking parties, only present in Defense Events. </value>
        [DataMember(Name="attackers_score", EmitDefaultValue=false)]
        public float? AttackersScore { get; set; }

        /// <summary>
        /// Unique ID for this campaign.
        /// </summary>
        /// <value>Unique ID for this campaign.</value>
        [DataMember(Name="campaign_id", EmitDefaultValue=false)]
        public int? CampaignId { get; set; }

        /// <summary>
        /// The constellation in which the campaign will take place. 
        /// </summary>
        /// <value>The constellation in which the campaign will take place. </value>
        [DataMember(Name="constellation_id", EmitDefaultValue=false)]
        public int? ConstellationId { get; set; }

        /// <summary>
        /// Defending alliance, only present in Defense Events 
        /// </summary>
        /// <value>Defending alliance, only present in Defense Events </value>
        [DataMember(Name="defender_id", EmitDefaultValue=false)]
        public int? DefenderId { get; set; }

        /// <summary>
        /// Score for the defending alliance, only present in Defense Events. 
        /// </summary>
        /// <value>Score for the defending alliance, only present in Defense Events. </value>
        [DataMember(Name="defender_score", EmitDefaultValue=false)]
        public float? DefenderScore { get; set; }


        /// <summary>
        /// Alliance participating and their respective scores, only present in Freeport Events. 
        /// </summary>
        /// <value>Alliance participating and their respective scores, only present in Freeport Events. </value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<GetSovereigntyCampaignsParticipant> Participants { get; set; }

        /// <summary>
        /// The solar system the structure is located in. 
        /// </summary>
        /// <value>The solar system the structure is located in. </value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// Time the event is scheduled to start. 
        /// </summary>
        /// <value>Time the event is scheduled to start. </value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The structure item ID that is related to this campaign. 
        /// </summary>
        /// <value>The structure item ID that is related to this campaign. </value>
        [DataMember(Name="structure_id", EmitDefaultValue=false)]
        public long? StructureId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSovereigntyCampaigns200Ok {\n");
            sb.Append("  AttackersScore: ").Append(AttackersScore).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
            sb.Append("  DefenderId: ").Append(DefenderId).Append("\n");
            sb.Append("  DefenderScore: ").Append(DefenderScore).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StructureId: ").Append(StructureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GetSovereigntyCampaigns200Ok);
        }

        /// <summary>
        /// Returns true if GetSovereigntyCampaigns200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSovereigntyCampaigns200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSovereigntyCampaigns200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttackersScore == input.AttackersScore ||
                    (this.AttackersScore != null &&
                    this.AttackersScore.Equals(input.AttackersScore))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.ConstellationId == input.ConstellationId ||
                    (this.ConstellationId != null &&
                    this.ConstellationId.Equals(input.ConstellationId))
                ) && 
                (
                    this.DefenderId == input.DefenderId ||
                    (this.DefenderId != null &&
                    this.DefenderId.Equals(input.DefenderId))
                ) && 
                (
                    this.DefenderScore == input.DefenderScore ||
                    (this.DefenderScore != null &&
                    this.DefenderScore.Equals(input.DefenderScore))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Participants == input.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(input.Participants)
                ) && 
                (
                    this.SolarSystemId == input.SolarSystemId ||
                    (this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(input.SolarSystemId))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StructureId == input.StructureId ||
                    (this.StructureId != null &&
                    this.StructureId.Equals(input.StructureId))
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
                if (this.AttackersScore != null)
                    hashCode = hashCode * 59 + this.AttackersScore.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.ConstellationId != null)
                    hashCode = hashCode * 59 + this.ConstellationId.GetHashCode();
                if (this.DefenderId != null)
                    hashCode = hashCode * 59 + this.DefenderId.GetHashCode();
                if (this.DefenderScore != null)
                    hashCode = hashCode * 59 + this.DefenderScore.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.SolarSystemId != null)
                    hashCode = hashCode * 59 + this.SolarSystemId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StructureId != null)
                    hashCode = hashCode * 59 + this.StructureId.GetHashCode();
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
