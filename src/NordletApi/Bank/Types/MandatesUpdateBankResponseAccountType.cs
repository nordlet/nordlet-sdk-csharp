using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesUpdateBankResponseAccountType.MandatesUpdateBankResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct MandatesUpdateBankResponseAccountType : IStringEnum
{
    public static readonly MandatesUpdateBankResponseAccountType Checking = new(Values.Checking);

    public static readonly MandatesUpdateBankResponseAccountType Savings = new(Values.Savings);

    public MandatesUpdateBankResponseAccountType(string value)
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
    public static MandatesUpdateBankResponseAccountType FromCustom(string value)
    {
        return new MandatesUpdateBankResponseAccountType(value);
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

    public static bool operator ==(MandatesUpdateBankResponseAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesUpdateBankResponseAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesUpdateBankResponseAccountType value) =>
        value.Value;

    public static explicit operator MandatesUpdateBankResponseAccountType(string value) =>
        new(value);

    internal class MandatesUpdateBankResponseAccountTypeSerializer
        : JsonConverter<MandatesUpdateBankResponseAccountType>
    {
        public override MandatesUpdateBankResponseAccountType Read(
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
            return new MandatesUpdateBankResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesUpdateBankResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesUpdateBankResponseAccountType ReadAsPropertyName(
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
            return new MandatesUpdateBankResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesUpdateBankResponseAccountType value,
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
        public const string Checking = "checking";

        public const string Savings = "savings";
    }
}
