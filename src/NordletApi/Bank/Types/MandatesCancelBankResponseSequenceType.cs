using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesCancelBankResponseSequenceType.MandatesCancelBankResponseSequenceTypeSerializer)
)]
[Serializable]
public readonly record struct MandatesCancelBankResponseSequenceType : IStringEnum
{
    public static readonly MandatesCancelBankResponseSequenceType Recurrent = new(Values.Recurrent);

    public static readonly MandatesCancelBankResponseSequenceType OneOff = new(Values.OneOff);

    public MandatesCancelBankResponseSequenceType(string value)
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
    public static MandatesCancelBankResponseSequenceType FromCustom(string value)
    {
        return new MandatesCancelBankResponseSequenceType(value);
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

    public static bool operator ==(MandatesCancelBankResponseSequenceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCancelBankResponseSequenceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCancelBankResponseSequenceType value) =>
        value.Value;

    public static explicit operator MandatesCancelBankResponseSequenceType(string value) =>
        new(value);

    internal class MandatesCancelBankResponseSequenceTypeSerializer
        : JsonConverter<MandatesCancelBankResponseSequenceType>
    {
        public override MandatesCancelBankResponseSequenceType Read(
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
            return new MandatesCancelBankResponseSequenceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCancelBankResponseSequenceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCancelBankResponseSequenceType ReadAsPropertyName(
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
            return new MandatesCancelBankResponseSequenceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCancelBankResponseSequenceType value,
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
