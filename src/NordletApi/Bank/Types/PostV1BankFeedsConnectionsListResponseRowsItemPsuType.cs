using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsListResponseRowsItemPsuType.PostV1BankFeedsConnectionsListResponseRowsItemPsuTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsListResponseRowsItemPsuType : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemPsuType Business = new(
        Values.Business
    );

    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemPsuType Personal = new(
        Values.Personal
    );

    public PostV1BankFeedsConnectionsListResponseRowsItemPsuType(string value)
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
    public static PostV1BankFeedsConnectionsListResponseRowsItemPsuType FromCustom(string value)
    {
        return new PostV1BankFeedsConnectionsListResponseRowsItemPsuType(value);
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
        PostV1BankFeedsConnectionsListResponseRowsItemPsuType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsListResponseRowsItemPsuType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsConnectionsListResponseRowsItemPsuType value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsConnectionsListResponseRowsItemPsuType(
        string value
    ) => new(value);

    internal class PostV1BankFeedsConnectionsListResponseRowsItemPsuTypeSerializer
        : JsonConverter<PostV1BankFeedsConnectionsListResponseRowsItemPsuType>
    {
        public override PostV1BankFeedsConnectionsListResponseRowsItemPsuType Read(
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
            return new PostV1BankFeedsConnectionsListResponseRowsItemPsuType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsListResponseRowsItemPsuType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsListResponseRowsItemPsuType ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsListResponseRowsItemPsuType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsListResponseRowsItemPsuType value,
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
        public const string Business = "business";

        public const string Personal = "personal";
    }
}
