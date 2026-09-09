using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1LeadsUpdateResponseStatus.PostV1LeadsUpdateResponseStatusSerializer))]
[Serializable]
public readonly record struct PostV1LeadsUpdateResponseStatus : IStringEnum
{
    public static readonly PostV1LeadsUpdateResponseStatus New = new(Values.New);

    public static readonly PostV1LeadsUpdateResponseStatus Contacted = new(Values.Contacted);

    public static readonly PostV1LeadsUpdateResponseStatus Qualified = new(Values.Qualified);

    public static readonly PostV1LeadsUpdateResponseStatus Lost = new(Values.Lost);

    public static readonly PostV1LeadsUpdateResponseStatus Converted = new(Values.Converted);

    public PostV1LeadsUpdateResponseStatus(string value)
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
    public static PostV1LeadsUpdateResponseStatus FromCustom(string value)
    {
        return new PostV1LeadsUpdateResponseStatus(value);
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

    public static bool operator ==(PostV1LeadsUpdateResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LeadsUpdateResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LeadsUpdateResponseStatus value) => value.Value;

    public static explicit operator PostV1LeadsUpdateResponseStatus(string value) => new(value);

    internal class PostV1LeadsUpdateResponseStatusSerializer
        : JsonConverter<PostV1LeadsUpdateResponseStatus>
    {
        public override PostV1LeadsUpdateResponseStatus Read(
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
            return new PostV1LeadsUpdateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LeadsUpdateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LeadsUpdateResponseStatus ReadAsPropertyName(
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
            return new PostV1LeadsUpdateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LeadsUpdateResponseStatus value,
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
