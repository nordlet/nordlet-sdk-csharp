using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MeAccountResponseBillingAccountType.MeAccountResponseBillingAccountTypeSerializer)
)]
[Serializable]
public readonly record struct MeAccountResponseBillingAccountType : IStringEnum
{
    public static readonly MeAccountResponseBillingAccountType FlatRate = new(Values.FlatRate);

    public static readonly MeAccountResponseBillingAccountType PerRequest = new(Values.PerRequest);

    public MeAccountResponseBillingAccountType(string value)
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
    public static MeAccountResponseBillingAccountType FromCustom(string value)
    {
        return new MeAccountResponseBillingAccountType(value);
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

    public static bool operator ==(MeAccountResponseBillingAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MeAccountResponseBillingAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MeAccountResponseBillingAccountType value) =>
        value.Value;

    public static explicit operator MeAccountResponseBillingAccountType(string value) => new(value);

    internal class MeAccountResponseBillingAccountTypeSerializer
        : JsonConverter<MeAccountResponseBillingAccountType>
    {
        public override MeAccountResponseBillingAccountType Read(
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
            return new MeAccountResponseBillingAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MeAccountResponseBillingAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MeAccountResponseBillingAccountType ReadAsPropertyName(
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
            return new MeAccountResponseBillingAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MeAccountResponseBillingAccountType value,
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
