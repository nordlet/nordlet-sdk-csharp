using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsVatSummaryRequestSide.PostV1ReportsVatSummaryRequestSideSerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsVatSummaryRequestSide : IStringEnum
{
    public static readonly PostV1ReportsVatSummaryRequestSide Sales = new(Values.Sales);

    public static readonly PostV1ReportsVatSummaryRequestSide Purchases = new(Values.Purchases);

    public PostV1ReportsVatSummaryRequestSide(string value)
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
    public static PostV1ReportsVatSummaryRequestSide FromCustom(string value)
    {
        return new PostV1ReportsVatSummaryRequestSide(value);
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

    public static bool operator ==(PostV1ReportsVatSummaryRequestSide value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ReportsVatSummaryRequestSide value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsVatSummaryRequestSide value) => value.Value;

    public static explicit operator PostV1ReportsVatSummaryRequestSide(string value) => new(value);

    internal class PostV1ReportsVatSummaryRequestSideSerializer
        : JsonConverter<PostV1ReportsVatSummaryRequestSide>
    {
        public override PostV1ReportsVatSummaryRequestSide Read(
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
            return new PostV1ReportsVatSummaryRequestSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsVatSummaryRequestSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsVatSummaryRequestSide ReadAsPropertyName(
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
            return new PostV1ReportsVatSummaryRequestSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsVatSummaryRequestSide value,
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
        public const string Sales = "sales";

        public const string Purchases = "purchases";
    }
}
