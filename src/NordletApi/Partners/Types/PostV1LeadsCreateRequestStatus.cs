using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1LeadsCreateRequestStatus.PostV1LeadsCreateRequestStatusSerializer))]
[Serializable]
public readonly record struct PostV1LeadsCreateRequestStatus : IStringEnum
{
    public static readonly PostV1LeadsCreateRequestStatus New = new(Values.New);

    public static readonly PostV1LeadsCreateRequestStatus Contacted = new(Values.Contacted);

    public static readonly PostV1LeadsCreateRequestStatus Qualified = new(Values.Qualified);

    public static readonly PostV1LeadsCreateRequestStatus Lost = new(Values.Lost);

    public PostV1LeadsCreateRequestStatus(string value)
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
    public static PostV1LeadsCreateRequestStatus FromCustom(string value)
    {
        return new PostV1LeadsCreateRequestStatus(value);
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

    public static bool operator ==(PostV1LeadsCreateRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LeadsCreateRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LeadsCreateRequestStatus value) => value.Value;

    public static explicit operator PostV1LeadsCreateRequestStatus(string value) => new(value);

    internal class PostV1LeadsCreateRequestStatusSerializer
        : JsonConverter<PostV1LeadsCreateRequestStatus>
    {
        public override PostV1LeadsCreateRequestStatus Read(
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
            return new PostV1LeadsCreateRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LeadsCreateRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LeadsCreateRequestStatus ReadAsPropertyName(
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
            return new PostV1LeadsCreateRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LeadsCreateRequestStatus value,
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
