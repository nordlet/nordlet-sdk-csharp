using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesCreateBankResponseScheme.MandatesCreateBankResponseSchemeSerializer))]
[Serializable]
public readonly record struct MandatesCreateBankResponseScheme : IStringEnum
{
    public static readonly MandatesCreateBankResponseScheme Core = new(Values.Core);

    public static readonly MandatesCreateBankResponseScheme B2B = new(Values.B2B);

    public MandatesCreateBankResponseScheme(string value)
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
    public static MandatesCreateBankResponseScheme FromCustom(string value)
    {
        return new MandatesCreateBankResponseScheme(value);
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

    public static bool operator ==(MandatesCreateBankResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCreateBankResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCreateBankResponseScheme value) => value.Value;

    public static explicit operator MandatesCreateBankResponseScheme(string value) => new(value);

    internal class MandatesCreateBankResponseSchemeSerializer
        : JsonConverter<MandatesCreateBankResponseScheme>
    {
        public override MandatesCreateBankResponseScheme Read(
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
            return new MandatesCreateBankResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCreateBankResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCreateBankResponseScheme ReadAsPropertyName(
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
            return new MandatesCreateBankResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCreateBankResponseScheme value,
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
