using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingUsageListResponseRowsItemMetric.PostV1BillingUsageListResponseRowsItemMetricSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingUsageListResponseRowsItemMetric : IStringEnum
{
    public static readonly PostV1BillingUsageListResponseRowsItemMetric ApiRequest = new(
        Values.ApiRequest
    );

    public static readonly PostV1BillingUsageListResponseRowsItemMetric OcrPage = new(
        Values.OcrPage
    );

    public static readonly PostV1BillingUsageListResponseRowsItemMetric FileStorageBytes = new(
        Values.FileStorageBytes
    );

    public static readonly PostV1BillingUsageListResponseRowsItemMetric DatabaseBytes = new(
        Values.DatabaseBytes
    );

    public PostV1BillingUsageListResponseRowsItemMetric(string value)
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
    public static PostV1BillingUsageListResponseRowsItemMetric FromCustom(string value)
    {
        return new PostV1BillingUsageListResponseRowsItemMetric(value);
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
        PostV1BillingUsageListResponseRowsItemMetric value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BillingUsageListResponseRowsItemMetric value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BillingUsageListResponseRowsItemMetric value) =>
        value.Value;

    public static explicit operator PostV1BillingUsageListResponseRowsItemMetric(string value) =>
        new(value);

    internal class PostV1BillingUsageListResponseRowsItemMetricSerializer
        : JsonConverter<PostV1BillingUsageListResponseRowsItemMetric>
    {
        public override PostV1BillingUsageListResponseRowsItemMetric Read(
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
            return new PostV1BillingUsageListResponseRowsItemMetric(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingUsageListResponseRowsItemMetric value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingUsageListResponseRowsItemMetric ReadAsPropertyName(
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
            return new PostV1BillingUsageListResponseRowsItemMetric(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingUsageListResponseRowsItemMetric value,
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
