using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(JobsCreateReportsRequestFormatsItem.JobsCreateReportsRequestFormatsItemSerializer)
)]
[Serializable]
public readonly record struct JobsCreateReportsRequestFormatsItem : IStringEnum
{
    public static readonly JobsCreateReportsRequestFormatsItem Json = new(Values.Json);

    public static readonly JobsCreateReportsRequestFormatsItem Xlsx = new(Values.Xlsx);

    public static readonly JobsCreateReportsRequestFormatsItem Pdf = new(Values.Pdf);

    public JobsCreateReportsRequestFormatsItem(string value)
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
    public static JobsCreateReportsRequestFormatsItem FromCustom(string value)
    {
        return new JobsCreateReportsRequestFormatsItem(value);
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

    public static bool operator ==(JobsCreateReportsRequestFormatsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsCreateReportsRequestFormatsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsCreateReportsRequestFormatsItem value) =>
        value.Value;

    public static explicit operator JobsCreateReportsRequestFormatsItem(string value) => new(value);

    internal class JobsCreateReportsRequestFormatsItemSerializer
        : JsonConverter<JobsCreateReportsRequestFormatsItem>
    {
        public override JobsCreateReportsRequestFormatsItem Read(
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
            return new JobsCreateReportsRequestFormatsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            JobsCreateReportsRequestFormatsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override JobsCreateReportsRequestFormatsItem ReadAsPropertyName(
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
            return new JobsCreateReportsRequestFormatsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            JobsCreateReportsRequestFormatsItem value,
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
