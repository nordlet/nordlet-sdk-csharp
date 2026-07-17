using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1EcommerceOrdersGetResponseStatus.PostV1EcommerceOrdersGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1EcommerceOrdersGetResponseStatus : IStringEnum
{
    public static readonly PostV1EcommerceOrdersGetResponseStatus New = new(Values.New);

    public static readonly PostV1EcommerceOrdersGetResponseStatus Reserved = new(Values.Reserved);

    public static readonly PostV1EcommerceOrdersGetResponseStatus Fulfilled = new(Values.Fulfilled);

    public static readonly PostV1EcommerceOrdersGetResponseStatus Cancelled = new(Values.Cancelled);

    public PostV1EcommerceOrdersGetResponseStatus(string value)
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
    public static PostV1EcommerceOrdersGetResponseStatus FromCustom(string value)
    {
        return new PostV1EcommerceOrdersGetResponseStatus(value);
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

    public static bool operator ==(PostV1EcommerceOrdersGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1EcommerceOrdersGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1EcommerceOrdersGetResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1EcommerceOrdersGetResponseStatus(string value) =>
        new(value);

    internal class PostV1EcommerceOrdersGetResponseStatusSerializer
        : JsonConverter<PostV1EcommerceOrdersGetResponseStatus>
    {
        public override PostV1EcommerceOrdersGetResponseStatus Read(
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
            return new PostV1EcommerceOrdersGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1EcommerceOrdersGetResponseStatus ReadAsPropertyName(
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
            return new PostV1EcommerceOrdersGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersGetResponseStatus value,
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
