using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesUpdateResponseType.PostV1PurchasesInvoicesUpdateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesUpdateResponseType : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesUpdateResponseType Invoice = new(Values.Invoice);

    public static readonly PostV1PurchasesInvoicesUpdateResponseType CreditNote = new(
        Values.CreditNote
    );

    public PostV1PurchasesInvoicesUpdateResponseType(string value)
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
    public static PostV1PurchasesInvoicesUpdateResponseType FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesUpdateResponseType(value);
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
        PostV1PurchasesInvoicesUpdateResponseType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesUpdateResponseType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesInvoicesUpdateResponseType value) =>
        value.Value;

    public static explicit operator PostV1PurchasesInvoicesUpdateResponseType(string value) =>
        new(value);

    internal class PostV1PurchasesInvoicesUpdateResponseTypeSerializer
        : JsonConverter<PostV1PurchasesInvoicesUpdateResponseType>
    {
        public override PostV1PurchasesInvoicesUpdateResponseType Read(
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
            return new PostV1PurchasesInvoicesUpdateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesUpdateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesUpdateResponseType ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesUpdateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesUpdateResponseType value,
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
        public const string Invoice = "invoice";

        public const string CreditNote = "credit_note";
    }
}
