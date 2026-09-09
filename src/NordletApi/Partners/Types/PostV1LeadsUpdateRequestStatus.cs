using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1LeadsUpdateRequestStatus.PostV1LeadsUpdateRequestStatusSerializer))]
[Serializable]
public readonly record struct PostV1LeadsUpdateRequestStatus : IStringEnum
{
    public static readonly PostV1LeadsUpdateRequestStatus New = new(Values.New);

    public static readonly PostV1LeadsUpdateRequestStatus Contacted = new(Values.Contacted);

    public static readonly PostV1LeadsUpdateRequestStatus Qualified = new(Values.Qualified);

    public static readonly PostV1LeadsUpdateRequestStatus Lost = new(Values.Lost);

    public PostV1LeadsUpdateRequestStatus(string value)
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
    public static PostV1LeadsUpdateRequestStatus FromCustom(string value)
    {
        return new PostV1LeadsUpdateRequestStatus(value);
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

    public static bool operator ==(PostV1LeadsUpdateRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LeadsUpdateRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LeadsUpdateRequestStatus value) => value.Value;

    public static explicit operator PostV1LeadsUpdateRequestStatus(string value) => new(value);

    internal class PostV1LeadsUpdateRequestStatusSerializer
        : JsonConverter<PostV1LeadsUpdateRequestStatus>
    {
        public override PostV1LeadsUpdateRequestStatus Read(
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
            return new PostV1LeadsUpdateRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LeadsUpdateRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LeadsUpdateRequestStatus ReadAsPropertyName(
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
            return new PostV1LeadsUpdateRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LeadsUpdateRequestStatus value,
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
    }
}
