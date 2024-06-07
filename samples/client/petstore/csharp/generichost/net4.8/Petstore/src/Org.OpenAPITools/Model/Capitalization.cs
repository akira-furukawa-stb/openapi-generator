// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
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
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Capitalization
    /// </summary>
    public partial class Capitalization : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capitalization" /> class.
        /// </summary>
        /// <param name="aTTNAME">Name of the pet </param>
        /// <param name="capitalCamel">capitalCamel</param>
        /// <param name="capitalSnake">capitalSnake</param>
        /// <param name="sCAETHFlowPoints">sCAETHFlowPoints</param>
        /// <param name="smallCamel">smallCamel</param>
        /// <param name="smallSnake">smallSnake</param>
        [JsonConstructor]
        public Capitalization(Option<string> aTTNAME = default, Option<string> capitalCamel = default, Option<string> capitalSnake = default, Option<string> sCAETHFlowPoints = default, Option<string> smallCamel = default, Option<string> smallSnake = default)
        {
            ATT_NAMEOption = aTTNAME;
            CapitalCamelOption = capitalCamel;
            CapitalSnakeOption = capitalSnake;
            SCAETHFlowPointsOption = sCAETHFlowPoints;
            SmallCamelOption = smallCamel;
            SmallSnakeOption = smallSnake;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ATT_NAME
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ATT_NAMEOption { get; private set; }

        /// <summary>
        /// Name of the pet 
        /// </summary>
        /// <value>Name of the pet </value>
        [JsonPropertyName("ATT_NAME")]
        public string ATT_NAME { get { return this.ATT_NAMEOption; } set { this.ATT_NAMEOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CapitalCamel
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CapitalCamelOption { get; private set; }

        /// <summary>
        /// Gets or Sets CapitalCamel
        /// </summary>
        [JsonPropertyName("CapitalCamel")]
        public string CapitalCamel { get { return this.CapitalCamelOption; } set { this.CapitalCamelOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CapitalSnake
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CapitalSnakeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CapitalSnake
        /// </summary>
        [JsonPropertyName("Capital_Snake")]
        public string CapitalSnake { get { return this.CapitalSnakeOption; } set { this.CapitalSnakeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of SCAETHFlowPoints
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> SCAETHFlowPointsOption { get; private set; }

        /// <summary>
        /// Gets or Sets SCAETHFlowPoints
        /// </summary>
        [JsonPropertyName("SCA_ETH_Flow_Points")]
        public string SCAETHFlowPoints { get { return this.SCAETHFlowPointsOption; } set { this.SCAETHFlowPointsOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of SmallCamel
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> SmallCamelOption { get; private set; }

        /// <summary>
        /// Gets or Sets SmallCamel
        /// </summary>
        [JsonPropertyName("smallCamel")]
        public string SmallCamel { get { return this.SmallCamelOption; } set { this.SmallCamelOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of SmallSnake
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> SmallSnakeOption { get; private set; }

        /// <summary>
        /// Gets or Sets SmallSnake
        /// </summary>
        [JsonPropertyName("small_Snake")]
        public string SmallSnake { get { return this.SmallSnakeOption; } set { this.SmallSnakeOption = new Option<string>(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Capitalization {\n");
            sb.Append("  ATT_NAME: ").Append(ATT_NAME).Append("\n");
            sb.Append("  CapitalCamel: ").Append(CapitalCamel).Append("\n");
            sb.Append("  CapitalSnake: ").Append(CapitalSnake).Append("\n");
            sb.Append("  SCAETHFlowPoints: ").Append(SCAETHFlowPoints).Append("\n");
            sb.Append("  SmallCamel: ").Append(SmallCamel).Append("\n");
            sb.Append("  SmallSnake: ").Append(SmallSnake).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="Capitalization" />
    /// </summary>
    public class CapitalizationJsonConverter : JsonConverter<Capitalization>
    {
        /// <summary>
        /// Deserializes json to <see cref="Capitalization" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Capitalization Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> aTTNAME = default;
            Option<string> capitalCamel = default;
            Option<string> capitalSnake = default;
            Option<string> sCAETHFlowPoints = default;
            Option<string> smallCamel = default;
            Option<string> smallSnake = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "ATT_NAME":
                            aTTNAME = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "CapitalCamel":
                            capitalCamel = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "Capital_Snake":
                            capitalSnake = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "SCA_ETH_Flow_Points":
                            sCAETHFlowPoints = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "smallCamel":
                            smallCamel = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "small_Snake":
                            smallSnake = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (aTTNAME.IsSet && aTTNAME.Value == null)
                throw new ArgumentNullException(nameof(aTTNAME), "Property is not nullable for class Capitalization.");

            if (capitalCamel.IsSet && capitalCamel.Value == null)
                throw new ArgumentNullException(nameof(capitalCamel), "Property is not nullable for class Capitalization.");

            if (capitalSnake.IsSet && capitalSnake.Value == null)
                throw new ArgumentNullException(nameof(capitalSnake), "Property is not nullable for class Capitalization.");

            if (sCAETHFlowPoints.IsSet && sCAETHFlowPoints.Value == null)
                throw new ArgumentNullException(nameof(sCAETHFlowPoints), "Property is not nullable for class Capitalization.");

            if (smallCamel.IsSet && smallCamel.Value == null)
                throw new ArgumentNullException(nameof(smallCamel), "Property is not nullable for class Capitalization.");

            if (smallSnake.IsSet && smallSnake.Value == null)
                throw new ArgumentNullException(nameof(smallSnake), "Property is not nullable for class Capitalization.");

            return new Capitalization(aTTNAME, capitalCamel, capitalSnake, sCAETHFlowPoints, smallCamel, smallSnake);
        }

        /// <summary>
        /// Serializes a <see cref="Capitalization" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="capitalization"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Capitalization capitalization, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, capitalization, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Capitalization" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="capitalization"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, Capitalization capitalization, JsonSerializerOptions jsonSerializerOptions)
        {
            if (capitalization.ATT_NAMEOption.IsSet && capitalization.ATT_NAME == null)
                throw new ArgumentNullException(nameof(capitalization.ATT_NAME), "Property is required for class Capitalization.");

            if (capitalization.CapitalCamelOption.IsSet && capitalization.CapitalCamel == null)
                throw new ArgumentNullException(nameof(capitalization.CapitalCamel), "Property is required for class Capitalization.");

            if (capitalization.CapitalSnakeOption.IsSet && capitalization.CapitalSnake == null)
                throw new ArgumentNullException(nameof(capitalization.CapitalSnake), "Property is required for class Capitalization.");

            if (capitalization.SCAETHFlowPointsOption.IsSet && capitalization.SCAETHFlowPoints == null)
                throw new ArgumentNullException(nameof(capitalization.SCAETHFlowPoints), "Property is required for class Capitalization.");

            if (capitalization.SmallCamelOption.IsSet && capitalization.SmallCamel == null)
                throw new ArgumentNullException(nameof(capitalization.SmallCamel), "Property is required for class Capitalization.");

            if (capitalization.SmallSnakeOption.IsSet && capitalization.SmallSnake == null)
                throw new ArgumentNullException(nameof(capitalization.SmallSnake), "Property is required for class Capitalization.");

            if (capitalization.ATT_NAMEOption.IsSet)
                writer.WriteString("ATT_NAME", capitalization.ATT_NAME);

            if (capitalization.CapitalCamelOption.IsSet)
                writer.WriteString("CapitalCamel", capitalization.CapitalCamel);

            if (capitalization.CapitalSnakeOption.IsSet)
                writer.WriteString("Capital_Snake", capitalization.CapitalSnake);

            if (capitalization.SCAETHFlowPointsOption.IsSet)
                writer.WriteString("SCA_ETH_Flow_Points", capitalization.SCAETHFlowPoints);

            if (capitalization.SmallCamelOption.IsSet)
                writer.WriteString("smallCamel", capitalization.SmallCamel);

            if (capitalization.SmallSnakeOption.IsSet)
                writer.WriteString("small_Snake", capitalization.SmallSnake);
        }
    }
}
