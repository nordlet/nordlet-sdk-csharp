using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1MigrationBooksImportRequestAccountsItemType.PostV1MigrationBooksImportRequestAccountsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1MigrationBooksImportRequestAccountsItemType : IStringEnum
{
    public static readonly PostV1MigrationBooksImportRequestAccountsItemType Asset = new(
        Values.Asset
    );

    public static readonly PostV1MigrationBooksImportRequestAccountsItemType Liability = new(
        Values.Liability
    );

    public static readonly PostV1MigrationBooksImportRequestAccountsItemType Equity = new(
        Values.Equity
    );

    public static readonly PostV1MigrationBooksImportRequestAccountsItemType Income = new(
        Values.Income
    );

    public static readonly PostV1MigrationBooksImportRequestAccountsItemType Expense = new(
        Values.Expense
    );

    public PostV1MigrationBooksImportRequestAccountsItemType(string value)
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
    public static PostV1MigrationBooksImportRequestAccountsItemType FromCustom(string value)
    {
        return new PostV1MigrationBooksImportRequestAccountsItemType(value);
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
        PostV1MigrationBooksImportRequestAccountsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1MigrationBooksImportRequestAccountsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1MigrationBooksImportRequestAccountsItemType value
    ) => value.Value;

    public static explicit operator PostV1MigrationBooksImportRequestAccountsItemType(
        string value
    ) => new(value);

    internal class PostV1MigrationBooksImportRequestAccountsItemTypeSerializer
        : JsonConverter<PostV1MigrationBooksImportRequestAccountsItemType>
    {
        public override PostV1MigrationBooksImportRequestAccountsItemType Read(
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
            return new PostV1MigrationBooksImportRequestAccountsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1MigrationBooksImportRequestAccountsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1MigrationBooksImportRequestAccountsItemType ReadAsPropertyName(
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
            return new PostV1MigrationBooksImportRequestAccountsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1MigrationBooksImportRequestAccountsItemType value,
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
