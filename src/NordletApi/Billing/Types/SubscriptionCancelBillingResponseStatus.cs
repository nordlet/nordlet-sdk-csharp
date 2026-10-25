using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionCancelBillingResponseStatus.SubscriptionCancelBillingResponseStatusSerializer)
)]
[Serializable]
public readonly record struct SubscriptionCancelBillingResponseStatus : IStringEnum
{
    public static readonly SubscriptionCancelBillingResponseStatus Trial = new(Values.Trial);

    public static readonly SubscriptionCancelBillingResponseStatus Active = new(Values.Active);

    public static readonly SubscriptionCancelBillingResponseStatus Suspended = new(
        Values.Suspended
    );

    public SubscriptionCancelBillingResponseStatus(string value)
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
    public static SubscriptionCancelBillingResponseStatus FromCustom(string value)
    {
        return new SubscriptionCancelBillingResponseStatus(value);
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

    public static bool operator ==(SubscriptionCancelBillingResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SubscriptionCancelBillingResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SubscriptionCancelBillingResponseStatus value) =>
        value.Value;

    public static explicit operator SubscriptionCancelBillingResponseStatus(string value) =>
        new(value);

    internal class SubscriptionCancelBillingResponseStatusSerializer
        : JsonConverter<SubscriptionCancelBillingResponseStatus>
    {
        public override SubscriptionCancelBillingResponseStatus Read(
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
            return new SubscriptionCancelBillingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionCancelBillingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionCancelBillingResponseStatus ReadAsPropertyName(
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
            return new SubscriptionCancelBillingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionCancelBillingResponseStatus value,
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
