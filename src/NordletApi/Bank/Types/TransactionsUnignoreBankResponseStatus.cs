using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsUnignoreBankResponseStatus.TransactionsUnignoreBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct TransactionsUnignoreBankResponseStatus : IStringEnum
{
    public static readonly TransactionsUnignoreBankResponseStatus New = new(Values.New);

    public static readonly TransactionsUnignoreBankResponseStatus Matched = new(Values.Matched);

    public static readonly TransactionsUnignoreBankResponseStatus Ignored = new(Values.Ignored);

    public TransactionsUnignoreBankResponseStatus(string value)
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
    public static TransactionsUnignoreBankResponseStatus FromCustom(string value)
    {
        return new TransactionsUnignoreBankResponseStatus(value);
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

    public static bool operator ==(TransactionsUnignoreBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsUnignoreBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsUnignoreBankResponseStatus value) =>
        value.Value;

    public static explicit operator TransactionsUnignoreBankResponseStatus(string value) =>
        new(value);

    internal class TransactionsUnignoreBankResponseStatusSerializer
        : JsonConverter<TransactionsUnignoreBankResponseStatus>
    {
        public override TransactionsUnignoreBankResponseStatus Read(
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
            return new TransactionsUnignoreBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsUnignoreBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsUnignoreBankResponseStatus ReadAsPropertyName(
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
            return new TransactionsUnignoreBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsUnignoreBankResponseStatus value,
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

        public const string Ignored = "ignored";
    }
}
