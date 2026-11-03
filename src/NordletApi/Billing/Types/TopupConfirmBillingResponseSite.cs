using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(TopupConfirmBillingResponseSite.TopupConfirmBillingResponseSiteSerializer))]
[Serializable]
public readonly record struct TopupConfirmBillingResponseSite : IStringEnum
{
    public static readonly TopupConfirmBillingResponseSite App = new(Values.App);

    public static readonly TopupConfirmBillingResponseSite Invoice = new(Values.Invoice);

    public TopupConfirmBillingResponseSite(string value)
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
    public static TopupConfirmBillingResponseSite FromCustom(string value)
    {
        return new TopupConfirmBillingResponseSite(value);
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

    public static bool operator ==(TopupConfirmBillingResponseSite value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TopupConfirmBillingResponseSite value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TopupConfirmBillingResponseSite value) => value.Value;

    public static explicit operator TopupConfirmBillingResponseSite(string value) => new(value);

    internal class TopupConfirmBillingResponseSiteSerializer
        : JsonConverter<TopupConfirmBillingResponseSite>
    {
        public override TopupConfirmBillingResponseSite Read(
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
            return new TopupConfirmBillingResponseSite(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponseSite value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TopupConfirmBillingResponseSite ReadAsPropertyName(
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
            return new TopupConfirmBillingResponseSite(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TopupConfirmBillingResponseSite value,
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
        public const string App = "app";

        public const string Invoice = "invoice";
    }
}
