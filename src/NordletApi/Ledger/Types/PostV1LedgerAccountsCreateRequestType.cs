using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerAccountsCreateRequestType.PostV1LedgerAccountsCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerAccountsCreateRequestType : IStringEnum
{
    public static readonly PostV1LedgerAccountsCreateRequestType Asset = new(Values.Asset);

    public static readonly PostV1LedgerAccountsCreateRequestType Liability = new(Values.Liability);

    public static readonly PostV1LedgerAccountsCreateRequestType Equity = new(Values.Equity);

    public static readonly PostV1LedgerAccountsCreateRequestType Income = new(Values.Income);

    public static readonly PostV1LedgerAccountsCreateRequestType Expense = new(Values.Expense);

    public PostV1LedgerAccountsCreateRequestType(string value)
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
    public static PostV1LedgerAccountsCreateRequestType FromCustom(string value)
    {
        return new PostV1LedgerAccountsCreateRequestType(value);
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

    public static bool operator ==(PostV1LedgerAccountsCreateRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LedgerAccountsCreateRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerAccountsCreateRequestType value) =>
        value.Value;

    public static explicit operator PostV1LedgerAccountsCreateRequestType(string value) =>
        new(value);

    internal class PostV1LedgerAccountsCreateRequestTypeSerializer
        : JsonConverter<PostV1LedgerAccountsCreateRequestType>
    {
        public override PostV1LedgerAccountsCreateRequestType Read(
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
            return new PostV1LedgerAccountsCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerAccountsCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerAccountsCreateRequestType ReadAsPropertyName(
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
            return new PostV1LedgerAccountsCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerAccountsCreateRequestType value,
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
