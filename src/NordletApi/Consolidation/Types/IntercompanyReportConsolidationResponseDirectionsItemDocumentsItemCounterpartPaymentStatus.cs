using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus.IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatusSerializer)
)]
[Serializable]
public readonly record struct IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus
    : IStringEnum
{
    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus Unpaid =
        new(Values.Unpaid);

    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus Partial =
        new(Values.Partial);

    public static readonly IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus Paid =
        new(Values.Paid);

    public IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus(
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
    public static IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus FromCustom(
        string value
    )
    {
        return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus(
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
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus value
    ) => value.Value;

    public static explicit operator IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus(
        string value
    ) => new(value);

    internal class IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatusSerializer
        : JsonConverter<IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus>
    {
        public override IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus Read(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus ReadAsPropertyName(
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
            return new IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpartPaymentStatus value,
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
        public const string Unpaid = "unpaid";

        public const string Partial = "partial";

        public const string Paid = "paid";
    }
}
