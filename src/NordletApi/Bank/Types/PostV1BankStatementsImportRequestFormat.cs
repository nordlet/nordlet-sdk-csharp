using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankStatementsImportRequestFormat.PostV1BankStatementsImportRequestFormatSerializer)
)]
[Serializable]
public readonly record struct PostV1BankStatementsImportRequestFormat : IStringEnum
{
    public static readonly PostV1BankStatementsImportRequestFormat Camt053 = new(Values.Camt053);

    public static readonly PostV1BankStatementsImportRequestFormat Mt940 = new(Values.Mt940);

    public static readonly PostV1BankStatementsImportRequestFormat StripeCsv = new(
        Values.StripeCsv
    );

    public PostV1BankStatementsImportRequestFormat(string value)
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
    public static PostV1BankStatementsImportRequestFormat FromCustom(string value)
    {
        return new PostV1BankStatementsImportRequestFormat(value);
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

    public static bool operator ==(PostV1BankStatementsImportRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankStatementsImportRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankStatementsImportRequestFormat value) =>
        value.Value;

    public static explicit operator PostV1BankStatementsImportRequestFormat(string value) =>
        new(value);

    internal class PostV1BankStatementsImportRequestFormatSerializer
        : JsonConverter<PostV1BankStatementsImportRequestFormat>
    {
        public override PostV1BankStatementsImportRequestFormat Read(
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
            return new PostV1BankStatementsImportRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankStatementsImportRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankStatementsImportRequestFormat ReadAsPropertyName(
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
            return new PostV1BankStatementsImportRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankStatementsImportRequestFormat value,
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
        public const string Camt053 = "camt053";

        public const string Mt940 = "mt940";

        public const string StripeCsv = "stripe-csv";
    }
}
