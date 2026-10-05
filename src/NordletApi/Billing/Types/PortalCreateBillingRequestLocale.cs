using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PortalCreateBillingRequestLocale.PortalCreateBillingRequestLocaleSerializer))]
[Serializable]
public readonly record struct PortalCreateBillingRequestLocale : IStringEnum
{
    public static readonly PortalCreateBillingRequestLocale En = new(Values.En);

    public static readonly PortalCreateBillingRequestLocale Lt = new(Values.Lt);

    public static readonly PortalCreateBillingRequestLocale De = new(Values.De);

    public PortalCreateBillingRequestLocale(string value)
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
    public static PortalCreateBillingRequestLocale FromCustom(string value)
    {
        return new PortalCreateBillingRequestLocale(value);
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

    public static bool operator ==(PortalCreateBillingRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PortalCreateBillingRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PortalCreateBillingRequestLocale value) => value.Value;

    public static explicit operator PortalCreateBillingRequestLocale(string value) => new(value);

    internal class PortalCreateBillingRequestLocaleSerializer
        : JsonConverter<PortalCreateBillingRequestLocale>
    {
        public override PortalCreateBillingRequestLocale Read(
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
            return new PortalCreateBillingRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PortalCreateBillingRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PortalCreateBillingRequestLocale ReadAsPropertyName(
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
            return new PortalCreateBillingRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PortalCreateBillingRequestLocale value,
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
        public const string En = "en";

        public const string Lt = "lt";

        public const string De = "de";
    }
}
