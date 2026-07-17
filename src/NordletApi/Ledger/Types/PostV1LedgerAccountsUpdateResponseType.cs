using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerAccountsUpdateResponseType.PostV1LedgerAccountsUpdateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerAccountsUpdateResponseType : IStringEnum
{
    public static readonly PostV1LedgerAccountsUpdateResponseType Asset = new(Values.Asset);

    public static readonly PostV1LedgerAccountsUpdateResponseType Liability = new(Values.Liability);

    public static readonly PostV1LedgerAccountsUpdateResponseType Equity = new(Values.Equity);

    public static readonly PostV1LedgerAccountsUpdateResponseType Income = new(Values.Income);

    public static readonly PostV1LedgerAccountsUpdateResponseType Expense = new(Values.Expense);

    public PostV1LedgerAccountsUpdateResponseType(string value)
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
    public static PostV1LedgerAccountsUpdateResponseType FromCustom(string value)
    {
        return new PostV1LedgerAccountsUpdateResponseType(value);
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

    public static bool operator ==(PostV1LedgerAccountsUpdateResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LedgerAccountsUpdateResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerAccountsUpdateResponseType value) =>
        value.Value;

    public static explicit operator PostV1LedgerAccountsUpdateResponseType(string value) =>
        new(value);

    internal class PostV1LedgerAccountsUpdateResponseTypeSerializer
        : JsonConverter<PostV1LedgerAccountsUpdateResponseType>
    {
        public override PostV1LedgerAccountsUpdateResponseType Read(
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
            return new PostV1LedgerAccountsUpdateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerAccountsUpdateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerAccountsUpdateResponseType ReadAsPropertyName(
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
            return new PostV1LedgerAccountsUpdateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerAccountsUpdateResponseType value,
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
