using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingAccountGetResponseStatus.PostV1BillingAccountGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingAccountGetResponseStatus : IStringEnum
{
    public static readonly PostV1BillingAccountGetResponseStatus Trial = new(Values.Trial);

    public static readonly PostV1BillingAccountGetResponseStatus Active = new(Values.Active);

    public static readonly PostV1BillingAccountGetResponseStatus Suspended = new(Values.Suspended);

    public PostV1BillingAccountGetResponseStatus(string value)
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
    public static PostV1BillingAccountGetResponseStatus FromCustom(string value)
    {
        return new PostV1BillingAccountGetResponseStatus(value);
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

    public static bool operator ==(PostV1BillingAccountGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BillingAccountGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BillingAccountGetResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1BillingAccountGetResponseStatus(string value) =>
        new(value);

    internal class PostV1BillingAccountGetResponseStatusSerializer
        : JsonConverter<PostV1BillingAccountGetResponseStatus>
    {
        public override PostV1BillingAccountGetResponseStatus Read(
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
            return new PostV1BillingAccountGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingAccountGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingAccountGetResponseStatus ReadAsPropertyName(
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
            return new PostV1BillingAccountGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingAccountGetResponseStatus value,
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
        public const string Trial = "trial";

        public const string Active = "active";

        public const string Suspended = "suspended";
    }
}
