using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsRecordBankResponseStatus.TransactionsRecordBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct TransactionsRecordBankResponseStatus : IStringEnum
{
    public static readonly TransactionsRecordBankResponseStatus New = new(Values.New);

    public static readonly TransactionsRecordBankResponseStatus Matched = new(Values.Matched);

    public TransactionsRecordBankResponseStatus(string value)
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
    public static TransactionsRecordBankResponseStatus FromCustom(string value)
    {
        return new TransactionsRecordBankResponseStatus(value);
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

    public static bool operator ==(TransactionsRecordBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsRecordBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsRecordBankResponseStatus value) =>
        value.Value;

    public static explicit operator TransactionsRecordBankResponseStatus(string value) =>
        new(value);

    internal class TransactionsRecordBankResponseStatusSerializer
        : JsonConverter<TransactionsRecordBankResponseStatus>
    {
        public override TransactionsRecordBankResponseStatus Read(
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
            return new TransactionsRecordBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsRecordBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsRecordBankResponseStatus ReadAsPropertyName(
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
            return new TransactionsRecordBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsRecordBankResponseStatus value,
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
        public const string New = "new";

        public const string Matched = "matched";
    }
}
