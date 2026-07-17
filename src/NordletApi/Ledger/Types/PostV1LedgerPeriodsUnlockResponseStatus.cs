using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerPeriodsUnlockResponseStatus.PostV1LedgerPeriodsUnlockResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerPeriodsUnlockResponseStatus : IStringEnum
{
    public static readonly PostV1LedgerPeriodsUnlockResponseStatus Open = new(Values.Open);

    public static readonly PostV1LedgerPeriodsUnlockResponseStatus Locked = new(Values.Locked);

    public PostV1LedgerPeriodsUnlockResponseStatus(string value)
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
    public static PostV1LedgerPeriodsUnlockResponseStatus FromCustom(string value)
    {
        return new PostV1LedgerPeriodsUnlockResponseStatus(value);
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

    public static bool operator ==(PostV1LedgerPeriodsUnlockResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LedgerPeriodsUnlockResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerPeriodsUnlockResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1LedgerPeriodsUnlockResponseStatus(string value) =>
        new(value);

    internal class PostV1LedgerPeriodsUnlockResponseStatusSerializer
        : JsonConverter<PostV1LedgerPeriodsUnlockResponseStatus>
    {
        public override PostV1LedgerPeriodsUnlockResponseStatus Read(
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
            return new PostV1LedgerPeriodsUnlockResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsUnlockResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerPeriodsUnlockResponseStatus ReadAsPropertyName(
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
            return new PostV1LedgerPeriodsUnlockResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsUnlockResponseStatus value,
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
