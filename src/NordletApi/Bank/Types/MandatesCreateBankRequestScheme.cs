using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesCreateBankRequestScheme.MandatesCreateBankRequestSchemeSerializer))]
[Serializable]
public readonly record struct MandatesCreateBankRequestScheme : IStringEnum
{
    public static readonly MandatesCreateBankRequestScheme Core = new(Values.Core);

    public static readonly MandatesCreateBankRequestScheme B2B = new(Values.B2B);

    public MandatesCreateBankRequestScheme(string value)
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
    public static MandatesCreateBankRequestScheme FromCustom(string value)
    {
        return new MandatesCreateBankRequestScheme(value);
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

    public static bool operator ==(MandatesCreateBankRequestScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCreateBankRequestScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCreateBankRequestScheme value) => value.Value;

    public static explicit operator MandatesCreateBankRequestScheme(string value) => new(value);

    internal class MandatesCreateBankRequestSchemeSerializer
        : JsonConverter<MandatesCreateBankRequestScheme>
    {
        public override MandatesCreateBankRequestScheme Read(
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
            return new MandatesCreateBankRequestScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCreateBankRequestScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCreateBankRequestScheme ReadAsPropertyName(
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
            return new MandatesCreateBankRequestScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCreateBankRequestScheme value,
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
