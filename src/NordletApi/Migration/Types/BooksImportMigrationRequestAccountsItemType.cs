using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BooksImportMigrationRequestAccountsItemType.BooksImportMigrationRequestAccountsItemTypeSerializer)
)]
[Serializable]
public readonly record struct BooksImportMigrationRequestAccountsItemType : IStringEnum
{
    public static readonly BooksImportMigrationRequestAccountsItemType Asset = new(Values.Asset);

    public static readonly BooksImportMigrationRequestAccountsItemType Liability = new(
        Values.Liability
    );

    public static readonly BooksImportMigrationRequestAccountsItemType Equity = new(Values.Equity);

    public static readonly BooksImportMigrationRequestAccountsItemType Income = new(Values.Income);

    public static readonly BooksImportMigrationRequestAccountsItemType Expense = new(
        Values.Expense
    );

    public BooksImportMigrationRequestAccountsItemType(string value)
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
    public static BooksImportMigrationRequestAccountsItemType FromCustom(string value)
    {
        return new BooksImportMigrationRequestAccountsItemType(value);
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
        BooksImportMigrationRequestAccountsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BooksImportMigrationRequestAccountsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BooksImportMigrationRequestAccountsItemType value) =>
        value.Value;

    public static explicit operator BooksImportMigrationRequestAccountsItemType(string value) =>
        new(value);

    internal class BooksImportMigrationRequestAccountsItemTypeSerializer
        : JsonConverter<BooksImportMigrationRequestAccountsItemType>
    {
        public override BooksImportMigrationRequestAccountsItemType Read(
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
            return new BooksImportMigrationRequestAccountsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BooksImportMigrationRequestAccountsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BooksImportMigrationRequestAccountsItemType ReadAsPropertyName(
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
            return new BooksImportMigrationRequestAccountsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BooksImportMigrationRequestAccountsItemType value,
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
        public const string Asset = "asset";

        public const string Liability = "liability";

        public const string Equity = "equity";

        public const string Income = "income";

        public const string Expense = "expense";
    }
}
