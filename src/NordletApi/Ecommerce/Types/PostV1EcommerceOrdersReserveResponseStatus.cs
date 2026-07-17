using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1EcommerceOrdersReserveResponseStatus.PostV1EcommerceOrdersReserveResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1EcommerceOrdersReserveResponseStatus : IStringEnum
{
    public static readonly PostV1EcommerceOrdersReserveResponseStatus New = new(Values.New);

    public static readonly PostV1EcommerceOrdersReserveResponseStatus Reserved = new(
        Values.Reserved
    );

    public static readonly PostV1EcommerceOrdersReserveResponseStatus Fulfilled = new(
        Values.Fulfilled
    );

    public static readonly PostV1EcommerceOrdersReserveResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1EcommerceOrdersReserveResponseStatus(string value)
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
    public static PostV1EcommerceOrdersReserveResponseStatus FromCustom(string value)
    {
        return new PostV1EcommerceOrdersReserveResponseStatus(value);
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
        PostV1EcommerceOrdersReserveResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1EcommerceOrdersReserveResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1EcommerceOrdersReserveResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1EcommerceOrdersReserveResponseStatus(string value) =>
        new(value);

    internal class PostV1EcommerceOrdersReserveResponseStatusSerializer
        : JsonConverter<PostV1EcommerceOrdersReserveResponseStatus>
    {
        public override PostV1EcommerceOrdersReserveResponseStatus Read(
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
            return new PostV1EcommerceOrdersReserveResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersReserveResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1EcommerceOrdersReserveResponseStatus ReadAsPropertyName(
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
            return new PostV1EcommerceOrdersReserveResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersReserveResponseStatus value,
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
