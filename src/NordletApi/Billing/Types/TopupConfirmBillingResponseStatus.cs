using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TopupConfirmBillingResponseStatus.TopupConfirmBillingResponseStatusSerializer)
)]
[Serializable]
public readonly record struct TopupConfirmBillingResponseStatus : IStringEnum
{
    public static readonly TopupConfirmBillingResponseStatus Trial = new(Values.Trial);

    public static readonly TopupConfirmBillingResponseStatus Active = new(Values.Active);

    public static readonly TopupConfirmBillingResponseStatus Suspended = new(Values.Suspended);

    public TopupConfirmBillingResponseStatus(string value)
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
    public static TopupConfirmBillingResponseStatus FromCustom(string value)
    {
        return new TopupConfirmBillingResponseStatus(value);
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

    public static bool operator ==(TopupConfirmBillingResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TopupConfirmBillingResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TopupConfirmBillingResponseStatus value) => value.Value;

    public static explicit operator TopupConfirmBillingResponseStatus(string value) => new(value);

    internal class TopupConfirmBillingResponseStatusSerializer
        : JsonConverter<TopupConfirmBillingResponseStatus>
    {
        public override TopupConfirmBillingResponseStatus Read(
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
            return new TopupConfirmBillingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TopupConfirmBillingResponseStatus ReadAsPropertyName(
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
            return new TopupConfirmBillingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponseStatus value,
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
