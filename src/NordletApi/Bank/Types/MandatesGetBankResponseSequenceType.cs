using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesGetBankResponseSequenceType.MandatesGetBankResponseSequenceTypeSerializer)
)]
[Serializable]
public readonly record struct MandatesGetBankResponseSequenceType : IStringEnum
{
    public static readonly MandatesGetBankResponseSequenceType Recurrent = new(Values.Recurrent);

    public static readonly MandatesGetBankResponseSequenceType OneOff = new(Values.OneOff);

    public MandatesGetBankResponseSequenceType(string value)
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
    public static MandatesGetBankResponseSequenceType FromCustom(string value)
    {
        return new MandatesGetBankResponseSequenceType(value);
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

    public static bool operator ==(MandatesGetBankResponseSequenceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesGetBankResponseSequenceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesGetBankResponseSequenceType value) =>
        value.Value;

    public static explicit operator MandatesGetBankResponseSequenceType(string value) => new(value);

    internal class MandatesGetBankResponseSequenceTypeSerializer
        : JsonConverter<MandatesGetBankResponseSequenceType>
    {
        public override MandatesGetBankResponseSequenceType Read(
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
            return new MandatesGetBankResponseSequenceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesGetBankResponseSequenceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesGetBankResponseSequenceType ReadAsPropertyName(
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
            return new MandatesGetBankResponseSequenceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesGetBankResponseSequenceType value,
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
