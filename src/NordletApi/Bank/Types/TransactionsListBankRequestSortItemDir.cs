using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsListBankRequestSortItemDir.TransactionsListBankRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct TransactionsListBankRequestSortItemDir : IStringEnum
{
    public static readonly TransactionsListBankRequestSortItemDir Asc = new(Values.Asc);

    public static readonly TransactionsListBankRequestSortItemDir Desc = new(Values.Desc);

    public TransactionsListBankRequestSortItemDir(string value)
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
    public static TransactionsListBankRequestSortItemDir FromCustom(string value)
    {
        return new TransactionsListBankRequestSortItemDir(value);
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

    public static bool operator ==(TransactionsListBankRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsListBankRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsListBankRequestSortItemDir value) =>
        value.Value;

    public static explicit operator TransactionsListBankRequestSortItemDir(string value) =>
        new(value);

    internal class TransactionsListBankRequestSortItemDirSerializer
        : JsonConverter<TransactionsListBankRequestSortItemDir>
    {
        public override TransactionsListBankRequestSortItemDir Read(
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
            return new TransactionsListBankRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsListBankRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsListBankRequestSortItemDir ReadAsPropertyName(
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
            return new TransactionsListBankRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsListBankRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
