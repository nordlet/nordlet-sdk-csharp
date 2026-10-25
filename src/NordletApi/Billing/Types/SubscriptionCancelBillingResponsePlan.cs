using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionCancelBillingResponsePlan.SubscriptionCancelBillingResponsePlanSerializer)
)]
[Serializable]
public readonly record struct SubscriptionCancelBillingResponsePlan : IStringEnum
{
    public static readonly SubscriptionCancelBillingResponsePlan Starter = new(Values.Starter);

    public static readonly SubscriptionCancelBillingResponsePlan Business = new(Values.Business);

    public static readonly SubscriptionCancelBillingResponsePlan Scale = new(Values.Scale);

    public static readonly SubscriptionCancelBillingResponsePlan Invoicing = new(Values.Invoicing);

    public SubscriptionCancelBillingResponsePlan(string value)
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
    public static SubscriptionCancelBillingResponsePlan FromCustom(string value)
    {
        return new SubscriptionCancelBillingResponsePlan(value);
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

    public static bool operator ==(SubscriptionCancelBillingResponsePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SubscriptionCancelBillingResponsePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SubscriptionCancelBillingResponsePlan value) =>
        value.Value;

    public static explicit operator SubscriptionCancelBillingResponsePlan(string value) =>
        new(value);

    internal class SubscriptionCancelBillingResponsePlanSerializer
        : JsonConverter<SubscriptionCancelBillingResponsePlan>
    {
        public override SubscriptionCancelBillingResponsePlan Read(
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
            return new SubscriptionCancelBillingResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionCancelBillingResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionCancelBillingResponsePlan ReadAsPropertyName(
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
            return new SubscriptionCancelBillingResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionCancelBillingResponsePlan value,
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
        public const string Starter = "starter";

        public const string Business = "business";

        public const string Scale = "scale";

        public const string Invoicing = "invoicing";
    }
}
