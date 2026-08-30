using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1MigrationBooksValidateRequestAccountsItemType.PostV1MigrationBooksValidateRequestAccountsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1MigrationBooksValidateRequestAccountsItemType : IStringEnum
{
    public static readonly PostV1MigrationBooksValidateRequestAccountsItemType Asset = new(
        Values.Asset
    );

    public static readonly PostV1MigrationBooksValidateRequestAccountsItemType Liability = new(
        Values.Liability
    );

    public static readonly PostV1MigrationBooksValidateRequestAccountsItemType Equity = new(
        Values.Equity
    );

    public static readonly PostV1MigrationBooksValidateRequestAccountsItemType Income = new(
        Values.Income
    );

    public static readonly PostV1MigrationBooksValidateRequestAccountsItemType Expense = new(
        Values.Expense
    );

    public PostV1MigrationBooksValidateRequestAccountsItemType(string value)
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
    public static PostV1MigrationBooksValidateRequestAccountsItemType FromCustom(string value)
    {
        return new PostV1MigrationBooksValidateRequestAccountsItemType(value);
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
        PostV1MigrationBooksValidateRequestAccountsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1MigrationBooksValidateRequestAccountsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1MigrationBooksValidateRequestAccountsItemType value
    ) => value.Value;

    public static explicit operator PostV1MigrationBooksValidateRequestAccountsItemType(
        string value
    ) => new(value);

    internal class PostV1MigrationBooksValidateRequestAccountsItemTypeSerializer
        : JsonConverter<PostV1MigrationBooksValidateRequestAccountsItemType>
    {
        public override PostV1MigrationBooksValidateRequestAccountsItemType Read(
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
            return new PostV1MigrationBooksValidateRequestAccountsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1MigrationBooksValidateRequestAccountsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1MigrationBooksValidateRequestAccountsItemType ReadAsPropertyName(
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
            return new PostV1MigrationBooksValidateRequestAccountsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1MigrationBooksValidateRequestAccountsItemType value,
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
