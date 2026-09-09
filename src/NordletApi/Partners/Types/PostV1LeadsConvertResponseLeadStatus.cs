using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LeadsConvertResponseLeadStatus.PostV1LeadsConvertResponseLeadStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1LeadsConvertResponseLeadStatus : IStringEnum
{
    public static readonly PostV1LeadsConvertResponseLeadStatus New = new(Values.New);

    public static readonly PostV1LeadsConvertResponseLeadStatus Contacted = new(Values.Contacted);

    public static readonly PostV1LeadsConvertResponseLeadStatus Qualified = new(Values.Qualified);

    public static readonly PostV1LeadsConvertResponseLeadStatus Lost = new(Values.Lost);

    public static readonly PostV1LeadsConvertResponseLeadStatus Converted = new(Values.Converted);

    public PostV1LeadsConvertResponseLeadStatus(string value)
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
    public static PostV1LeadsConvertResponseLeadStatus FromCustom(string value)
    {
        return new PostV1LeadsConvertResponseLeadStatus(value);
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

    public static bool operator ==(PostV1LeadsConvertResponseLeadStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LeadsConvertResponseLeadStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LeadsConvertResponseLeadStatus value) =>
        value.Value;

    public static explicit operator PostV1LeadsConvertResponseLeadStatus(string value) =>
        new(value);

    internal class PostV1LeadsConvertResponseLeadStatusSerializer
        : JsonConverter<PostV1LeadsConvertResponseLeadStatus>
    {
        public override PostV1LeadsConvertResponseLeadStatus Read(
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
            return new PostV1LeadsConvertResponseLeadStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LeadsConvertResponseLeadStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LeadsConvertResponseLeadStatus ReadAsPropertyName(
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
            return new PostV1LeadsConvertResponseLeadStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LeadsConvertResponseLeadStatus value,
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
        public const string New = "new";

        public const string Contacted = "contacted";

        public const string Qualified = "qualified";

        public const string Lost = "lost";

        public const string Converted = "converted";
    }
}
