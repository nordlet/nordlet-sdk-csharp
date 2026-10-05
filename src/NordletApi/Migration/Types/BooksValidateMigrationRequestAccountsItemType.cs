using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BooksValidateMigrationRequestAccountsItemType.BooksValidateMigrationRequestAccountsItemTypeSerializer)
)]
[Serializable]
public readonly record struct BooksValidateMigrationRequestAccountsItemType : IStringEnum
{
    public static readonly BooksValidateMigrationRequestAccountsItemType Asset = new(Values.Asset);

    public static readonly BooksValidateMigrationRequestAccountsItemType Liability = new(
        Values.Liability
    );

    public static readonly BooksValidateMigrationRequestAccountsItemType Equity = new(
        Values.Equity
    );

    public static readonly BooksValidateMigrationRequestAccountsItemType Income = new(
        Values.Income
    );

    public static readonly BooksValidateMigrationRequestAccountsItemType Expense = new(
        Values.Expense
    );

    public BooksValidateMigrationRequestAccountsItemType(string value)
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
    public static BooksValidateMigrationRequestAccountsItemType FromCustom(string value)
    {
        return new BooksValidateMigrationRequestAccountsItemType(value);
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
        BooksValidateMigrationRequestAccountsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BooksValidateMigrationRequestAccountsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BooksValidateMigrationRequestAccountsItemType value) =>
        value.Value;

    public static explicit operator BooksValidateMigrationRequestAccountsItemType(string value) =>
        new(value);

    internal class BooksValidateMigrationRequestAccountsItemTypeSerializer
        : JsonConverter<BooksValidateMigrationRequestAccountsItemType>
    {
        public override BooksValidateMigrationRequestAccountsItemType Read(
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
            return new BooksValidateMigrationRequestAccountsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BooksValidateMigrationRequestAccountsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BooksValidateMigrationRequestAccountsItemType ReadAsPropertyName(
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
            return new BooksValidateMigrationRequestAccountsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BooksValidateMigrationRequestAccountsItemType value,
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
