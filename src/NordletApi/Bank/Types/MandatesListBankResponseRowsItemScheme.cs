using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesListBankResponseRowsItemScheme.MandatesListBankResponseRowsItemSchemeSerializer)
)]
[Serializable]
public readonly record struct MandatesListBankResponseRowsItemScheme : IStringEnum
{
    public static readonly MandatesListBankResponseRowsItemScheme Core = new(Values.Core);

    public static readonly MandatesListBankResponseRowsItemScheme B2B = new(Values.B2B);

    public MandatesListBankResponseRowsItemScheme(string value)
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
    public static MandatesListBankResponseRowsItemScheme FromCustom(string value)
    {
        return new MandatesListBankResponseRowsItemScheme(value);
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

    public static bool operator ==(MandatesListBankResponseRowsItemScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesListBankResponseRowsItemScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesListBankResponseRowsItemScheme value) =>
        value.Value;

    public static explicit operator MandatesListBankResponseRowsItemScheme(string value) =>
        new(value);

    internal class MandatesListBankResponseRowsItemSchemeSerializer
        : JsonConverter<MandatesListBankResponseRowsItemScheme>
    {
        public override MandatesListBankResponseRowsItemScheme Read(
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
            return new MandatesListBankResponseRowsItemScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesListBankResponseRowsItemScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesListBankResponseRowsItemScheme ReadAsPropertyName(
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
            return new MandatesListBankResponseRowsItemScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesListBankResponseRowsItemScheme value,
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
