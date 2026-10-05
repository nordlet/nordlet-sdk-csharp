using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesCancelBankResponseScheme.MandatesCancelBankResponseSchemeSerializer))]
[Serializable]
public readonly record struct MandatesCancelBankResponseScheme : IStringEnum
{
    public static readonly MandatesCancelBankResponseScheme Core = new(Values.Core);

    public static readonly MandatesCancelBankResponseScheme B2B = new(Values.B2B);

    public MandatesCancelBankResponseScheme(string value)
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
    public static MandatesCancelBankResponseScheme FromCustom(string value)
    {
        return new MandatesCancelBankResponseScheme(value);
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

    public static bool operator ==(MandatesCancelBankResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCancelBankResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCancelBankResponseScheme value) => value.Value;

    public static explicit operator MandatesCancelBankResponseScheme(string value) => new(value);

    internal class MandatesCancelBankResponseSchemeSerializer
        : JsonConverter<MandatesCancelBankResponseScheme>
    {
        public override MandatesCancelBankResponseScheme Read(
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
            return new MandatesCancelBankResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCancelBankResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCancelBankResponseScheme ReadAsPropertyName(
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
            return new MandatesCancelBankResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCancelBankResponseScheme value,
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
        public const string Core = "CORE";

        public const string B2B = "B2B";
    }
}
