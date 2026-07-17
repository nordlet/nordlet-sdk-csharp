using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerPeriodsListResponseRowsItemStatus.PostV1LedgerPeriodsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerPeriodsListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1LedgerPeriodsListResponseRowsItemStatus Open = new(Values.Open);

    public static readonly PostV1LedgerPeriodsListResponseRowsItemStatus Locked = new(
        Values.Locked
    );

    public PostV1LedgerPeriodsListResponseRowsItemStatus(string value)
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
    public static PostV1LedgerPeriodsListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1LedgerPeriodsListResponseRowsItemStatus(value);
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
        PostV1LedgerPeriodsListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerPeriodsListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerPeriodsListResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PostV1LedgerPeriodsListResponseRowsItemStatus(string value) =>
        new(value);

    internal class PostV1LedgerPeriodsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1LedgerPeriodsListResponseRowsItemStatus>
    {
        public override PostV1LedgerPeriodsListResponseRowsItemStatus Read(
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
            return new PostV1LedgerPeriodsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerPeriodsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1LedgerPeriodsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsListResponseRowsItemStatus value,
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
