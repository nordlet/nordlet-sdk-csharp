using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch.IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatchSerializer)
)]
[Serializable]
public readonly record struct IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch
    : IStringEnum
{
    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch Mirrored =
        new(Values.Mirrored);

    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch MatchedByNumber =
        new(Values.MatchedByNumber);

    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch Missing =
        new(Values.Missing);

    public IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch(string value)
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
    public static IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch FromCustom(
        string value
    )
    {
        return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch(value);
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
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch value
    ) => value.Value;

    public static explicit operator IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch(
        string value
    ) => new(value);

    internal class IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatchSerializer
        : JsonConverter<IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch>
    {
        public override IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch Read(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch ReadAsPropertyName(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch value,
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
        public const string Mirrored = "mirrored";

        public const string MatchedByNumber = "matched_by_number";

        public const string Missing = "missing";
    }
}
