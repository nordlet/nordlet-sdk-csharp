using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1EcommerceOrdersCreateResponseStatus.PostV1EcommerceOrdersCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1EcommerceOrdersCreateResponseStatus : IStringEnum
{
    public static readonly PostV1EcommerceOrdersCreateResponseStatus New = new(Values.New);

    public static readonly PostV1EcommerceOrdersCreateResponseStatus Reserved = new(
        Values.Reserved
    );

    public static readonly PostV1EcommerceOrdersCreateResponseStatus Fulfilled = new(
        Values.Fulfilled
    );

    public static readonly PostV1EcommerceOrdersCreateResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1EcommerceOrdersCreateResponseStatus(string value)
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
    public static PostV1EcommerceOrdersCreateResponseStatus FromCustom(string value)
    {
        return new PostV1EcommerceOrdersCreateResponseStatus(value);
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
        PostV1EcommerceOrdersCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1EcommerceOrdersCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1EcommerceOrdersCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1EcommerceOrdersCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1EcommerceOrdersCreateResponseStatusSerializer
        : JsonConverter<PostV1EcommerceOrdersCreateResponseStatus>
    {
        public override PostV1EcommerceOrdersCreateResponseStatus Read(
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
            return new PostV1EcommerceOrdersCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1EcommerceOrdersCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1EcommerceOrdersCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersCreateResponseStatus value,
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
