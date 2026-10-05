using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UsageListBillingResponseRowsItemMetric.UsageListBillingResponseRowsItemMetricSerializer)
)]
[Serializable]
public readonly record struct UsageListBillingResponseRowsItemMetric : IStringEnum
{
    public static readonly UsageListBillingResponseRowsItemMetric ApiRequest = new(
        Values.ApiRequest
    );

    public static readonly UsageListBillingResponseRowsItemMetric OcrPage = new(Values.OcrPage);

    public static readonly UsageListBillingResponseRowsItemMetric FileStorageBytes = new(
        Values.FileStorageBytes
    );

    public static readonly UsageListBillingResponseRowsItemMetric DatabaseBytes = new(
        Values.DatabaseBytes
    );

    public UsageListBillingResponseRowsItemMetric(string value)
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
    public static UsageListBillingResponseRowsItemMetric FromCustom(string value)
    {
        return new UsageListBillingResponseRowsItemMetric(value);
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

    public static bool operator ==(UsageListBillingResponseRowsItemMetric value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsageListBillingResponseRowsItemMetric value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsageListBillingResponseRowsItemMetric value) =>
        value.Value;

    public static explicit operator UsageListBillingResponseRowsItemMetric(string value) =>
        new(value);

    internal class UsageListBillingResponseRowsItemMetricSerializer
        : JsonConverter<UsageListBillingResponseRowsItemMetric>
    {
        public override UsageListBillingResponseRowsItemMetric Read(
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
            return new UsageListBillingResponseRowsItemMetric(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UsageListBillingResponseRowsItemMetric value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UsageListBillingResponseRowsItemMetric ReadAsPropertyName(
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
            return new UsageListBillingResponseRowsItemMetric(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UsageListBillingResponseRowsItemMetric value,
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
        public const string ApiRequest = "api_request";

        public const string OcrPage = "ocr_page";

        public const string FileStorageBytes = "file_storage_bytes";

        public const string DatabaseBytes = "database_bytes";
    }
}
