using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsIgnoreBankResponseStatus.TransactionsIgnoreBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct TransactionsIgnoreBankResponseStatus : IStringEnum
{
    public static readonly TransactionsIgnoreBankResponseStatus New = new(Values.New);

    public static readonly TransactionsIgnoreBankResponseStatus Matched = new(Values.Matched);

    public static readonly TransactionsIgnoreBankResponseStatus Ignored = new(Values.Ignored);

    public TransactionsIgnoreBankResponseStatus(string value)
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
    public static TransactionsIgnoreBankResponseStatus FromCustom(string value)
    {
        return new TransactionsIgnoreBankResponseStatus(value);
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

    public static bool operator ==(TransactionsIgnoreBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsIgnoreBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsIgnoreBankResponseStatus value) =>
        value.Value;

    public static explicit operator TransactionsIgnoreBankResponseStatus(string value) =>
        new(value);

    internal class TransactionsIgnoreBankResponseStatusSerializer
        : JsonConverter<TransactionsIgnoreBankResponseStatus>
    {
        public override TransactionsIgnoreBankResponseStatus Read(
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
            return new TransactionsIgnoreBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsIgnoreBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsIgnoreBankResponseStatus ReadAsPropertyName(
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
            return new TransactionsIgnoreBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsIgnoreBankResponseStatus value,
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
