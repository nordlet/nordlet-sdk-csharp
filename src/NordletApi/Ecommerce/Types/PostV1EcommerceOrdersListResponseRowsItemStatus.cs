using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1EcommerceOrdersListResponseRowsItemStatus.PostV1EcommerceOrdersListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1EcommerceOrdersListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1EcommerceOrdersListResponseRowsItemStatus New = new(Values.New);

    public static readonly PostV1EcommerceOrdersListResponseRowsItemStatus Reserved = new(
        Values.Reserved
    );

    public static readonly PostV1EcommerceOrdersListResponseRowsItemStatus Fulfilled = new(
        Values.Fulfilled
    );

    public static readonly PostV1EcommerceOrdersListResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1EcommerceOrdersListResponseRowsItemStatus(string value)
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
    public static PostV1EcommerceOrdersListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1EcommerceOrdersListResponseRowsItemStatus(value);
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
        PostV1EcommerceOrdersListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1EcommerceOrdersListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1EcommerceOrdersListResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PostV1EcommerceOrdersListResponseRowsItemStatus(string value) =>
        new(value);

    internal class PostV1EcommerceOrdersListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1EcommerceOrdersListResponseRowsItemStatus>
    {
        public override PostV1EcommerceOrdersListResponseRowsItemStatus Read(
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
            return new PostV1EcommerceOrdersListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1EcommerceOrdersListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1EcommerceOrdersListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersListResponseRowsItemStatus value,
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

        public const string Reserved = "reserved";

        public const string Fulfilled = "fulfilled";

        public const string Cancelled = "cancelled";
    }
}
