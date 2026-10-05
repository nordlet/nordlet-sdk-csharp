using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesGetBankResponseScheme.MandatesGetBankResponseSchemeSerializer))]
[Serializable]
public readonly record struct MandatesGetBankResponseScheme : IStringEnum
{
    public static readonly MandatesGetBankResponseScheme Core = new(Values.Core);

    public static readonly MandatesGetBankResponseScheme B2B = new(Values.B2B);

    public MandatesGetBankResponseScheme(string value)
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
    public static MandatesGetBankResponseScheme FromCustom(string value)
    {
        return new MandatesGetBankResponseScheme(value);
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

    public static bool operator ==(MandatesGetBankResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesGetBankResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesGetBankResponseScheme value) => value.Value;

    public static explicit operator MandatesGetBankResponseScheme(string value) => new(value);

    internal class MandatesGetBankResponseSchemeSerializer
        : JsonConverter<MandatesGetBankResponseScheme>
    {
        public override MandatesGetBankResponseScheme Read(
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
            return new MandatesGetBankResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesGetBankResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesGetBankResponseScheme ReadAsPropertyName(
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
            return new MandatesGetBankResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesGetBankResponseScheme value,
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
