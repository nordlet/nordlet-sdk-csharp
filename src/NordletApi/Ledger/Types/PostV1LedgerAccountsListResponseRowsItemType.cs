using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerAccountsListResponseRowsItemType.PostV1LedgerAccountsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerAccountsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1LedgerAccountsListResponseRowsItemType Asset = new(Values.Asset);

    public static readonly PostV1LedgerAccountsListResponseRowsItemType Liability = new(
        Values.Liability
    );

    public static readonly PostV1LedgerAccountsListResponseRowsItemType Equity = new(Values.Equity);

    public static readonly PostV1LedgerAccountsListResponseRowsItemType Income = new(Values.Income);

    public static readonly PostV1LedgerAccountsListResponseRowsItemType Expense = new(
        Values.Expense
    );

    public PostV1LedgerAccountsListResponseRowsItemType(string value)
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
    public static PostV1LedgerAccountsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1LedgerAccountsListResponseRowsItemType(value);
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
        PostV1LedgerAccountsListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerAccountsListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerAccountsListResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1LedgerAccountsListResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1LedgerAccountsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1LedgerAccountsListResponseRowsItemType>
    {
        public override PostV1LedgerAccountsListResponseRowsItemType Read(
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
            return new PostV1LedgerAccountsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerAccountsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerAccountsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1LedgerAccountsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerAccountsListResponseRowsItemType value,
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
