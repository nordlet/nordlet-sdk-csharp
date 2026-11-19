using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesCreateBankResponseAccountType.MandatesCreateBankResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct MandatesCreateBankResponseAccountType : IStringEnum
{
    public static readonly MandatesCreateBankResponseAccountType Checking = new(Values.Checking);

    public static readonly MandatesCreateBankResponseAccountType Savings = new(Values.Savings);

    public MandatesCreateBankResponseAccountType(string value)
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
    public static MandatesCreateBankResponseAccountType FromCustom(string value)
    {
        return new MandatesCreateBankResponseAccountType(value);
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

    public static bool operator ==(MandatesCreateBankResponseAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCreateBankResponseAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCreateBankResponseAccountType value) =>
        value.Value;

    public static explicit operator MandatesCreateBankResponseAccountType(string value) =>
        new(value);

    internal class MandatesCreateBankResponseAccountTypeSerializer
        : JsonConverter<MandatesCreateBankResponseAccountType>
    {
        public override MandatesCreateBankResponseAccountType Read(
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
            return new MandatesCreateBankResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCreateBankResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCreateBankResponseAccountType ReadAsPropertyName(
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
            return new MandatesCreateBankResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCreateBankResponseAccountType value,
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
