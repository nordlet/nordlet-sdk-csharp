using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuVatRatesSetOverridesReferenceResponseSource.EuVatRatesSetOverridesReferenceResponseSourceSerializer)
)]
[Serializable]
public readonly record struct EuVatRatesSetOverridesReferenceResponseSource : IStringEnum
{
    public static readonly EuVatRatesSetOverridesReferenceResponseSource Default = new(
        Values.Default
    );

    public static readonly EuVatRatesSetOverridesReferenceResponseSource Company = new(
        Values.Company
    );

    public EuVatRatesSetOverridesReferenceResponseSource(string value)
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
    public static EuVatRatesSetOverridesReferenceResponseSource FromCustom(string value)
    {
        return new EuVatRatesSetOverridesReferenceResponseSource(value);
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
        EuVatRatesSetOverridesReferenceResponseSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuVatRatesSetOverridesReferenceResponseSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EuVatRatesSetOverridesReferenceResponseSource value) =>
        value.Value;

    public static explicit operator EuVatRatesSetOverridesReferenceResponseSource(string value) =>
        new(value);

    internal class EuVatRatesSetOverridesReferenceResponseSourceSerializer
        : JsonConverter<EuVatRatesSetOverridesReferenceResponseSource>
    {
        public override EuVatRatesSetOverridesReferenceResponseSource Read(
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
            return new EuVatRatesSetOverridesReferenceResponseSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuVatRatesSetOverridesReferenceResponseSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuVatRatesSetOverridesReferenceResponseSource ReadAsPropertyName(
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
            return new EuVatRatesSetOverridesReferenceResponseSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuVatRatesSetOverridesReferenceResponseSource value,
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
        public const string Default = "default";

        public const string Company = "company";
    }
}
