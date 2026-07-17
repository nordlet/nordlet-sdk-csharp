using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesApplyAdvanceResponseType.PostV1SalesInvoicesApplyAdvanceResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesApplyAdvanceResponseType : IStringEnum
{
    public static readonly PostV1SalesInvoicesApplyAdvanceResponseType Invoice = new(
        Values.Invoice
    );

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseType CreditNote = new(
        Values.CreditNote
    );

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseType Proforma = new(
        Values.Proforma
    );

    public static readonly PostV1SalesInvoicesApplyAdvanceResponseType Advance = new(
        Values.Advance
    );

    public PostV1SalesInvoicesApplyAdvanceResponseType(string value)
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
    public static PostV1SalesInvoicesApplyAdvanceResponseType FromCustom(string value)
    {
        return new PostV1SalesInvoicesApplyAdvanceResponseType(value);
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
        PostV1SalesInvoicesApplyAdvanceResponseType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesApplyAdvanceResponseType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesApplyAdvanceResponseType value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesApplyAdvanceResponseType(string value) =>
        new(value);

    internal class PostV1SalesInvoicesApplyAdvanceResponseTypeSerializer
        : JsonConverter<PostV1SalesInvoicesApplyAdvanceResponseType>
    {
        public override PostV1SalesInvoicesApplyAdvanceResponseType Read(
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
            return new PostV1SalesInvoicesApplyAdvanceResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesApplyAdvanceResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesApplyAdvanceResponseType ReadAsPropertyName(
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
            return new PostV1SalesInvoicesApplyAdvanceResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesApplyAdvanceResponseType value,
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

        public const string Proforma = "proforma";

        public const string Advance = "advance";
    }
}
