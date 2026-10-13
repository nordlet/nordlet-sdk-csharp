using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TopupConfirmBillingResponseAccountType.TopupConfirmBillingResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct TopupConfirmBillingResponseAccountType : IStringEnum
{
    public static readonly TopupConfirmBillingResponseAccountType FlatRate = new(Values.FlatRate);

    public static readonly TopupConfirmBillingResponseAccountType PerRequest = new(
        Values.PerRequest
    );

    public TopupConfirmBillingResponseAccountType(string value)
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
    public static TopupConfirmBillingResponseAccountType FromCustom(string value)
    {
        return new TopupConfirmBillingResponseAccountType(value);
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

    public static bool operator ==(TopupConfirmBillingResponseAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TopupConfirmBillingResponseAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TopupConfirmBillingResponseAccountType value) =>
        value.Value;

    public static explicit operator TopupConfirmBillingResponseAccountType(string value) =>
        new(value);

    internal class TopupConfirmBillingResponseAccountTypeSerializer
        : JsonConverter<TopupConfirmBillingResponseAccountType>
    {
        public override TopupConfirmBillingResponseAccountType Read(
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
            return new TopupConfirmBillingResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TopupConfirmBillingResponseAccountType ReadAsPropertyName(
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
            return new TopupConfirmBillingResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponseAccountType value,
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
