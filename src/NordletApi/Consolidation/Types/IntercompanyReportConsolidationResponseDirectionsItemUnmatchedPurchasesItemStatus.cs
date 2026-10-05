using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus.IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatusSerializer)
)]
[Serializable]
public readonly record struct IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus
    : IStringEnum
{
    public static readonly IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus Draft =
        new(Values.Draft);

    public static readonly IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus Registered =
        new(Values.Registered);

    public IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus(
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
    public static IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus FromCustom(
        string value
    )
    {
        return new IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus(
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
        IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus value
    ) => value.Value;

    public static explicit operator IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus(
        string value
    ) => new(value);

    internal class IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatusSerializer
        : JsonConverter<IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus>
    {
        public override IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus Read(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus ReadAsPropertyName(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItemStatus value,
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
