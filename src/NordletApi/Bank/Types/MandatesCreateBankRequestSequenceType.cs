using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesCreateBankRequestSequenceType.MandatesCreateBankRequestSequenceTypeSerializer)
)]
[Serializable]
public readonly record struct MandatesCreateBankRequestSequenceType : IStringEnum
{
    public static readonly MandatesCreateBankRequestSequenceType Recurrent = new(Values.Recurrent);

    public static readonly MandatesCreateBankRequestSequenceType OneOff = new(Values.OneOff);

    public MandatesCreateBankRequestSequenceType(string value)
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
    public static MandatesCreateBankRequestSequenceType FromCustom(string value)
    {
        return new MandatesCreateBankRequestSequenceType(value);
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

    public static bool operator ==(MandatesCreateBankRequestSequenceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCreateBankRequestSequenceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCreateBankRequestSequenceType value) =>
        value.Value;

    public static explicit operator MandatesCreateBankRequestSequenceType(string value) =>
        new(value);

    internal class MandatesCreateBankRequestSequenceTypeSerializer
        : JsonConverter<MandatesCreateBankRequestSequenceType>
    {
        public override MandatesCreateBankRequestSequenceType Read(
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
            return new MandatesCreateBankRequestSequenceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCreateBankRequestSequenceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCreateBankRequestSequenceType ReadAsPropertyName(
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
            return new MandatesCreateBankRequestSequenceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCreateBankRequestSequenceType value,
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
        public const string Recurrent = "recurrent";

        public const string OneOff = "one_off";
    }
}
