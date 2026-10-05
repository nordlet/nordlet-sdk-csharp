using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesUpdateBankResponseScheme.MandatesUpdateBankResponseSchemeSerializer))]
[Serializable]
public readonly record struct MandatesUpdateBankResponseScheme : IStringEnum
{
    public static readonly MandatesUpdateBankResponseScheme Core = new(Values.Core);

    public static readonly MandatesUpdateBankResponseScheme B2B = new(Values.B2B);

    public MandatesUpdateBankResponseScheme(string value)
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
    public static MandatesUpdateBankResponseScheme FromCustom(string value)
    {
        return new MandatesUpdateBankResponseScheme(value);
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

    public static bool operator ==(MandatesUpdateBankResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesUpdateBankResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesUpdateBankResponseScheme value) => value.Value;

    public static explicit operator MandatesUpdateBankResponseScheme(string value) => new(value);

    internal class MandatesUpdateBankResponseSchemeSerializer
        : JsonConverter<MandatesUpdateBankResponseScheme>
    {
        public override MandatesUpdateBankResponseScheme Read(
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
            return new MandatesUpdateBankResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesUpdateBankResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesUpdateBankResponseScheme ReadAsPropertyName(
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
            return new MandatesUpdateBankResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesUpdateBankResponseScheme value,
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
