using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsJobsCreateRequestFormatsItem.PostV1ReportsJobsCreateRequestFormatsItemSerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsJobsCreateRequestFormatsItem : IStringEnum
{
    public static readonly PostV1ReportsJobsCreateRequestFormatsItem Json = new(Values.Json);

    public static readonly PostV1ReportsJobsCreateRequestFormatsItem Xlsx = new(Values.Xlsx);

    public static readonly PostV1ReportsJobsCreateRequestFormatsItem Pdf = new(Values.Pdf);

    public PostV1ReportsJobsCreateRequestFormatsItem(string value)
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
    public static PostV1ReportsJobsCreateRequestFormatsItem FromCustom(string value)
    {
        return new PostV1ReportsJobsCreateRequestFormatsItem(value);
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
        PostV1ReportsJobsCreateRequestFormatsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReportsJobsCreateRequestFormatsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsJobsCreateRequestFormatsItem value) =>
        value.Value;

    public static explicit operator PostV1ReportsJobsCreateRequestFormatsItem(string value) =>
        new(value);

    internal class PostV1ReportsJobsCreateRequestFormatsItemSerializer
        : JsonConverter<PostV1ReportsJobsCreateRequestFormatsItem>
    {
        public override PostV1ReportsJobsCreateRequestFormatsItem Read(
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
            return new PostV1ReportsJobsCreateRequestFormatsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsJobsCreateRequestFormatsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsJobsCreateRequestFormatsItem ReadAsPropertyName(
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
            return new PostV1ReportsJobsCreateRequestFormatsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsJobsCreateRequestFormatsItem value,
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
        public const string Json = "json";

        public const string Xlsx = "xlsx";

        public const string Pdf = "pdf";
    }
}
