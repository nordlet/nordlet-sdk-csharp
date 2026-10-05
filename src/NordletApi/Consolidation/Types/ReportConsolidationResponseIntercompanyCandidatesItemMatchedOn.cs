using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn.ReportConsolidationResponseIntercompanyCandidatesItemMatchedOnSerializer)
)]
[Serializable]
public readonly record struct ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn
    : IStringEnum
{
    public static readonly ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn Code =
        new(Values.Code);

    public static readonly ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn VatCode =
        new(Values.VatCode);

    public ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn(string value)
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
    public static ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn FromCustom(
        string value
    )
    {
        return new ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn(value);
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
        ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn value
    ) => value.Value;

    public static explicit operator ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn(
        string value
    ) => new(value);

    internal class ReportConsolidationResponseIntercompanyCandidatesItemMatchedOnSerializer
        : JsonConverter<ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn>
    {
        public override ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn Read(
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
            return new ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn ReadAsPropertyName(
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
            return new ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportConsolidationResponseIntercompanyCandidatesItemMatchedOn value,
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
