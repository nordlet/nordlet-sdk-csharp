using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountsListLedgerRequestSortItemDir.AccountsListLedgerRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct AccountsListLedgerRequestSortItemDir : IStringEnum
{
    public static readonly AccountsListLedgerRequestSortItemDir Asc = new(Values.Asc);

    public static readonly AccountsListLedgerRequestSortItemDir Desc = new(Values.Desc);

    public AccountsListLedgerRequestSortItemDir(string value)
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
    public static AccountsListLedgerRequestSortItemDir FromCustom(string value)
    {
        return new AccountsListLedgerRequestSortItemDir(value);
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

    public static bool operator ==(AccountsListLedgerRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListLedgerRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListLedgerRequestSortItemDir value) =>
        value.Value;

    public static explicit operator AccountsListLedgerRequestSortItemDir(string value) =>
        new(value);

    internal class AccountsListLedgerRequestSortItemDirSerializer
        : JsonConverter<AccountsListLedgerRequestSortItemDir>
    {
        public override AccountsListLedgerRequestSortItemDir Read(
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
            return new AccountsListLedgerRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsListLedgerRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsListLedgerRequestSortItemDir ReadAsPropertyName(
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
            return new AccountsListLedgerRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsListLedgerRequestSortItemDir value,
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
