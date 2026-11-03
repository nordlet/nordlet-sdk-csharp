using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FlatRateConfirmBillingResponseSite.FlatRateConfirmBillingResponseSiteSerializer)
)]
[Serializable]
public readonly record struct FlatRateConfirmBillingResponseSite : IStringEnum
{
    public static readonly FlatRateConfirmBillingResponseSite App = new(Values.App);

    public static readonly FlatRateConfirmBillingResponseSite Invoice = new(Values.Invoice);

    public FlatRateConfirmBillingResponseSite(string value)
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
    public static FlatRateConfirmBillingResponseSite FromCustom(string value)
    {
        return new FlatRateConfirmBillingResponseSite(value);
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

    public static bool operator ==(FlatRateConfirmBillingResponseSite value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FlatRateConfirmBillingResponseSite value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FlatRateConfirmBillingResponseSite value) => value.Value;

    public static explicit operator FlatRateConfirmBillingResponseSite(string value) => new(value);

    internal class FlatRateConfirmBillingResponseSiteSerializer
        : JsonConverter<FlatRateConfirmBillingResponseSite>
    {
        public override FlatRateConfirmBillingResponseSite Read(
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
            return new FlatRateConfirmBillingResponseSite(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FlatRateConfirmBillingResponseSite value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FlatRateConfirmBillingResponseSite ReadAsPropertyName(
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
            return new FlatRateConfirmBillingResponseSite(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FlatRateConfirmBillingResponseSite value,
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
