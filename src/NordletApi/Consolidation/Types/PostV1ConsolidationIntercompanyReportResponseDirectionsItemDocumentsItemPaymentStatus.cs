using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus.PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus
    : IStringEnum
{
    public static readonly PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus Unpaid =
        new(Values.Unpaid);

    public static readonly PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus Partial =
        new(Values.Partial);

    public static readonly PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus Paid =
        new(Values.Paid);

    public PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus(
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
    public static PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus FromCustom(
        string value
    )
    {
        return new PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus(
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
        PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus(
        string value
    ) => new(value);

    internal class PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatusSerializer
        : JsonConverter<PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus>
    {
        public override PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus Read(
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
            return new PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus ReadAsPropertyName(
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
            return new PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus value,
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
