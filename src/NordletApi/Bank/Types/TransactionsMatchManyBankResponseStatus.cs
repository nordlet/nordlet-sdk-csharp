using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsMatchManyBankResponseStatus.TransactionsMatchManyBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct TransactionsMatchManyBankResponseStatus : IStringEnum
{
    public static readonly TransactionsMatchManyBankResponseStatus New = new(Values.New);

    public static readonly TransactionsMatchManyBankResponseStatus Matched = new(Values.Matched);

    public TransactionsMatchManyBankResponseStatus(string value)
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
    public static TransactionsMatchManyBankResponseStatus FromCustom(string value)
    {
        return new TransactionsMatchManyBankResponseStatus(value);
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

    public static bool operator ==(TransactionsMatchManyBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsMatchManyBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsMatchManyBankResponseStatus value) =>
        value.Value;

    public static explicit operator TransactionsMatchManyBankResponseStatus(string value) =>
        new(value);

    internal class TransactionsMatchManyBankResponseStatusSerializer
        : JsonConverter<TransactionsMatchManyBankResponseStatus>
    {
        public override TransactionsMatchManyBankResponseStatus Read(
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
            return new TransactionsMatchManyBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsMatchManyBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsMatchManyBankResponseStatus ReadAsPropertyName(
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
            return new TransactionsMatchManyBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsMatchManyBankResponseStatus value,
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
