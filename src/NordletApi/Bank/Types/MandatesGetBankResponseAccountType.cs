using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesGetBankResponseAccountType.MandatesGetBankResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct MandatesGetBankResponseAccountType : IStringEnum
{
    public static readonly MandatesGetBankResponseAccountType Checking = new(Values.Checking);

    public static readonly MandatesGetBankResponseAccountType Savings = new(Values.Savings);

    public MandatesGetBankResponseAccountType(string value)
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
    public static MandatesGetBankResponseAccountType FromCustom(string value)
    {
        return new MandatesGetBankResponseAccountType(value);
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

    public static bool operator ==(MandatesGetBankResponseAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesGetBankResponseAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesGetBankResponseAccountType value) => value.Value;

    public static explicit operator MandatesGetBankResponseAccountType(string value) => new(value);

    internal class MandatesGetBankResponseAccountTypeSerializer
        : JsonConverter<MandatesGetBankResponseAccountType>
    {
        public override MandatesGetBankResponseAccountType Read(
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
            return new MandatesGetBankResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesGetBankResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesGetBankResponseAccountType ReadAsPropertyName(
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
            return new MandatesGetBankResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesGetBankResponseAccountType value,
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
