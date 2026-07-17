using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn.PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOnSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn
    : IStringEnum
{
    public static readonly PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn Code =
        new(Values.Code);

    public static readonly PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn VatCode =
        new(Values.VatCode);

    public PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn FromCustom(
        string value
    )
    {
        return new PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn(
        string value
    ) => new(value);

    internal class PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOnSerializer
        : JsonConverter<PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn>
    {
        public override PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportResponseIntercompanyCandidatesItemMatchedOn value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Code = "code";

        public const string VatCode = "vatCode";
    }
}
