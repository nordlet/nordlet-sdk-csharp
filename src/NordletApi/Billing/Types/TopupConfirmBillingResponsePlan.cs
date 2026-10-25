using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(TopupConfirmBillingResponsePlan.TopupConfirmBillingResponsePlanSerializer))]
[Serializable]
public readonly record struct TopupConfirmBillingResponsePlan : IStringEnum
{
    public static readonly TopupConfirmBillingResponsePlan Starter = new(Values.Starter);

    public static readonly TopupConfirmBillingResponsePlan Business = new(Values.Business);

    public static readonly TopupConfirmBillingResponsePlan Scale = new(Values.Scale);

    public static readonly TopupConfirmBillingResponsePlan Invoicing = new(Values.Invoicing);

    public TopupConfirmBillingResponsePlan(string value)
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
    public static TopupConfirmBillingResponsePlan FromCustom(string value)
    {
        return new TopupConfirmBillingResponsePlan(value);
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

    public static bool operator ==(TopupConfirmBillingResponsePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TopupConfirmBillingResponsePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TopupConfirmBillingResponsePlan value) => value.Value;

    public static explicit operator TopupConfirmBillingResponsePlan(string value) => new(value);

    internal class TopupConfirmBillingResponsePlanSerializer
        : JsonConverter<TopupConfirmBillingResponsePlan>
    {
        public override TopupConfirmBillingResponsePlan Read(
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
            return new TopupConfirmBillingResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TopupConfirmBillingResponsePlan ReadAsPropertyName(
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
            return new TopupConfirmBillingResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponsePlan value,
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
