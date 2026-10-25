using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionCancelBillingResponseAccountType.SubscriptionCancelBillingResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct SubscriptionCancelBillingResponseAccountType : IStringEnum
{
    public static readonly SubscriptionCancelBillingResponseAccountType FlatRate = new(
        Values.FlatRate
    );

    public static readonly SubscriptionCancelBillingResponseAccountType PerRequest = new(
        Values.PerRequest
    );

    public SubscriptionCancelBillingResponseAccountType(string value)
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
    public static SubscriptionCancelBillingResponseAccountType FromCustom(string value)
    {
        return new SubscriptionCancelBillingResponseAccountType(value);
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
        SubscriptionCancelBillingResponseAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubscriptionCancelBillingResponseAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubscriptionCancelBillingResponseAccountType value) =>
        value.Value;

    public static explicit operator SubscriptionCancelBillingResponseAccountType(string value) =>
        new(value);

    internal class SubscriptionCancelBillingResponseAccountTypeSerializer
        : JsonConverter<SubscriptionCancelBillingResponseAccountType>
    {
        public override SubscriptionCancelBillingResponseAccountType Read(
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
            return new SubscriptionCancelBillingResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionCancelBillingResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionCancelBillingResponseAccountType ReadAsPropertyName(
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
            return new SubscriptionCancelBillingResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionCancelBillingResponseAccountType value,
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
        public const string FlatRate = "flat_rate";

        public const string PerRequest = "per_request";
    }
}
