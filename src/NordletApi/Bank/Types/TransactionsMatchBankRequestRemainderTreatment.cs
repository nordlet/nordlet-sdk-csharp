using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsMatchBankRequestRemainderTreatment.TransactionsMatchBankRequestRemainderTreatmentSerializer)
)]
[Serializable]
public readonly record struct TransactionsMatchBankRequestRemainderTreatment : IStringEnum
{
    public static readonly TransactionsMatchBankRequestRemainderTreatment Advance = new(
        Values.Advance
    );

    public static readonly TransactionsMatchBankRequestRemainderTreatment LeaveOpen = new(
        Values.LeaveOpen
    );

    public static readonly TransactionsMatchBankRequestRemainderTreatment WriteOff = new(
        Values.WriteOff
    );

    public TransactionsMatchBankRequestRemainderTreatment(string value)
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
    public static TransactionsMatchBankRequestRemainderTreatment FromCustom(string value)
    {
        return new TransactionsMatchBankRequestRemainderTreatment(value);
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

    public static bool operator ==(
        TransactionsMatchBankRequestRemainderTreatment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TransactionsMatchBankRequestRemainderTreatment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsMatchBankRequestRemainderTreatment value) =>
        value.Value;

    public static explicit operator TransactionsMatchBankRequestRemainderTreatment(string value) =>
        new(value);

    internal class TransactionsMatchBankRequestRemainderTreatmentSerializer
        : JsonConverter<TransactionsMatchBankRequestRemainderTreatment>
    {
        public override TransactionsMatchBankRequestRemainderTreatment Read(
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
            return new TransactionsMatchBankRequestRemainderTreatment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsMatchBankRequestRemainderTreatment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsMatchBankRequestRemainderTreatment ReadAsPropertyName(
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
            return new TransactionsMatchBankRequestRemainderTreatment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsMatchBankRequestRemainderTreatment value,
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
        public const string Advance = "advance";

        public const string LeaveOpen = "leave_open";

        public const string WriteOff = "write_off";
    }
}
