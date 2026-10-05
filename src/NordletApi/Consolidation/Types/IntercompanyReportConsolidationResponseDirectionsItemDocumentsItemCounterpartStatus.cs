using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus.IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatusSerializer)
)]
[Serializable]
public readonly record struct IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus
    : IStringEnum
{
    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus Draft =
        new(Values.Draft);

    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus Registered =
        new(Values.Registered);

    public IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus(
        string value
    )
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
    public static IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus FromCustom(
        string value
    )
    {
        return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus(
            value
        );
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
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus value
    ) => value.Value;

    public static explicit operator IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus(
        string value
    ) => new(value);

    internal class IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatusSerializer
        : JsonConverter<IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus>
    {
        public override IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus Read(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus ReadAsPropertyName(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartStatus value,
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
        public const string Draft = "draft";

        public const string Registered = "registered";
    }
}
