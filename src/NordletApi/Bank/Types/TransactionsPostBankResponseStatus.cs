using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsPostBankResponseStatus.TransactionsPostBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct TransactionsPostBankResponseStatus : IStringEnum
{
    public static readonly TransactionsPostBankResponseStatus New = new(Values.New);

    public static readonly TransactionsPostBankResponseStatus Matched = new(Values.Matched);

    public static readonly TransactionsPostBankResponseStatus Ignored = new(Values.Ignored);

    public TransactionsPostBankResponseStatus(string value)
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
    public static TransactionsPostBankResponseStatus FromCustom(string value)
    {
        return new TransactionsPostBankResponseStatus(value);
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

    public static bool operator ==(TransactionsPostBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsPostBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsPostBankResponseStatus value) => value.Value;

    public static explicit operator TransactionsPostBankResponseStatus(string value) => new(value);

    internal class TransactionsPostBankResponseStatusSerializer
        : JsonConverter<TransactionsPostBankResponseStatus>
    {
        public override TransactionsPostBankResponseStatus Read(
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
            return new TransactionsPostBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsPostBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsPostBankResponseStatus ReadAsPropertyName(
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
            return new TransactionsPostBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsPostBankResponseStatus value,
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
