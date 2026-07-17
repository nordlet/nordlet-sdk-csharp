using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerPeriodsLockResponseStatus.PostV1LedgerPeriodsLockResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerPeriodsLockResponseStatus : IStringEnum
{
    public static readonly PostV1LedgerPeriodsLockResponseStatus Open = new(Values.Open);

    public static readonly PostV1LedgerPeriodsLockResponseStatus Locked = new(Values.Locked);

    public PostV1LedgerPeriodsLockResponseStatus(string value)
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
    public static PostV1LedgerPeriodsLockResponseStatus FromCustom(string value)
    {
        return new PostV1LedgerPeriodsLockResponseStatus(value);
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

    public static bool operator ==(PostV1LedgerPeriodsLockResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LedgerPeriodsLockResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerPeriodsLockResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1LedgerPeriodsLockResponseStatus(string value) =>
        new(value);

    internal class PostV1LedgerPeriodsLockResponseStatusSerializer
        : JsonConverter<PostV1LedgerPeriodsLockResponseStatus>
    {
        public override PostV1LedgerPeriodsLockResponseStatus Read(
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
            return new PostV1LedgerPeriodsLockResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsLockResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerPeriodsLockResponseStatus ReadAsPropertyName(
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
            return new PostV1LedgerPeriodsLockResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsLockResponseStatus value,
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
        public const string Open = "open";

        public const string Locked = "locked";
    }
}
