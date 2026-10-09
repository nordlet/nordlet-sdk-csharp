using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ExpenseReportsListCashRequestSortItemDir.ExpenseReportsListCashRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ExpenseReportsListCashRequestSortItemDir : IStringEnum
{
    public static readonly ExpenseReportsListCashRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ExpenseReportsListCashRequestSortItemDir Desc = new(Values.Desc);

    public ExpenseReportsListCashRequestSortItemDir(string value)
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
    public static ExpenseReportsListCashRequestSortItemDir FromCustom(string value)
    {
        return new ExpenseReportsListCashRequestSortItemDir(value);
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
        ExpenseReportsListCashRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ExpenseReportsListCashRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ExpenseReportsListCashRequestSortItemDir value) =>
        value.Value;

    public static explicit operator ExpenseReportsListCashRequestSortItemDir(string value) =>
        new(value);

    internal class ExpenseReportsListCashRequestSortItemDirSerializer
        : JsonConverter<ExpenseReportsListCashRequestSortItemDir>
    {
        public override ExpenseReportsListCashRequestSortItemDir Read(
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
            return new ExpenseReportsListCashRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExpenseReportsListCashRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ExpenseReportsListCashRequestSortItemDir ReadAsPropertyName(
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
            return new ExpenseReportsListCashRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ExpenseReportsListCashRequestSortItemDir value,
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
