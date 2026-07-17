using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsVatDetailRequestSide.PostV1ReportsVatDetailRequestSideSerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsVatDetailRequestSide : IStringEnum
{
    public static readonly PostV1ReportsVatDetailRequestSide Sales = new(Values.Sales);

    public static readonly PostV1ReportsVatDetailRequestSide Purchases = new(Values.Purchases);

    public PostV1ReportsVatDetailRequestSide(string value)
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
    public static PostV1ReportsVatDetailRequestSide FromCustom(string value)
    {
        return new PostV1ReportsVatDetailRequestSide(value);
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

    public static bool operator ==(PostV1ReportsVatDetailRequestSide value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ReportsVatDetailRequestSide value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsVatDetailRequestSide value) => value.Value;

    public static explicit operator PostV1ReportsVatDetailRequestSide(string value) => new(value);

    internal class PostV1ReportsVatDetailRequestSideSerializer
        : JsonConverter<PostV1ReportsVatDetailRequestSide>
    {
        public override PostV1ReportsVatDetailRequestSide Read(
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
            return new PostV1ReportsVatDetailRequestSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsVatDetailRequestSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsVatDetailRequestSide ReadAsPropertyName(
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
            return new PostV1ReportsVatDetailRequestSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsVatDetailRequestSide value,
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
