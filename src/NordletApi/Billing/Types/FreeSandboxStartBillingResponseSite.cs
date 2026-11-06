using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FreeSandboxStartBillingResponseSite.FreeSandboxStartBillingResponseSiteSerializer)
)]
[Serializable]
public readonly record struct FreeSandboxStartBillingResponseSite : IStringEnum
{
    public static readonly FreeSandboxStartBillingResponseSite App = new(Values.App);

    public static readonly FreeSandboxStartBillingResponseSite Invoice = new(Values.Invoice);

    public FreeSandboxStartBillingResponseSite(string value)
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
    public static FreeSandboxStartBillingResponseSite FromCustom(string value)
    {
        return new FreeSandboxStartBillingResponseSite(value);
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

    public static bool operator ==(FreeSandboxStartBillingResponseSite value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FreeSandboxStartBillingResponseSite value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FreeSandboxStartBillingResponseSite value) =>
        value.Value;

    public static explicit operator FreeSandboxStartBillingResponseSite(string value) => new(value);

    internal class FreeSandboxStartBillingResponseSiteSerializer
        : JsonConverter<FreeSandboxStartBillingResponseSite>
    {
        public override FreeSandboxStartBillingResponseSite Read(
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
            return new FreeSandboxStartBillingResponseSite(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FreeSandboxStartBillingResponseSite value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FreeSandboxStartBillingResponseSite ReadAsPropertyName(
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
            return new FreeSandboxStartBillingResponseSite(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FreeSandboxStartBillingResponseSite value,
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
