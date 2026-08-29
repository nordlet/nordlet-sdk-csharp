using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountMeResponseBillingStatus.PostV1AccountMeResponseBillingStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountMeResponseBillingStatus : IStringEnum
{
    public static readonly PostV1AccountMeResponseBillingStatus Trial = new(Values.Trial);

    public static readonly PostV1AccountMeResponseBillingStatus Active = new(Values.Active);

    public static readonly PostV1AccountMeResponseBillingStatus Suspended = new(Values.Suspended);

    public PostV1AccountMeResponseBillingStatus(string value)
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
    public static PostV1AccountMeResponseBillingStatus FromCustom(string value)
    {
        return new PostV1AccountMeResponseBillingStatus(value);
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

    public static bool operator ==(PostV1AccountMeResponseBillingStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AccountMeResponseBillingStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountMeResponseBillingStatus value) =>
        value.Value;

    public static explicit operator PostV1AccountMeResponseBillingStatus(string value) =>
        new(value);

    internal class PostV1AccountMeResponseBillingStatusSerializer
        : JsonConverter<PostV1AccountMeResponseBillingStatus>
    {
        public override PostV1AccountMeResponseBillingStatus Read(
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
            return new PostV1AccountMeResponseBillingStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountMeResponseBillingStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountMeResponseBillingStatus ReadAsPropertyName(
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
            return new PostV1AccountMeResponseBillingStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountMeResponseBillingStatus value,
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
