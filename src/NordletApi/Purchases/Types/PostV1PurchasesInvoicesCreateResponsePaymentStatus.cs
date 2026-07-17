using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesCreateResponsePaymentStatus.PostV1PurchasesInvoicesCreateResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesCreateResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesCreateResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1PurchasesInvoicesCreateResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1PurchasesInvoicesCreateResponsePaymentStatus Paid = new(
        Values.Paid
    );

    public PostV1PurchasesInvoicesCreateResponsePaymentStatus(string value)
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
    public static PostV1PurchasesInvoicesCreateResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesCreateResponsePaymentStatus(value);
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
        PostV1PurchasesInvoicesCreateResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesCreateResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PurchasesInvoicesCreateResponsePaymentStatus value
    ) => value.Value;

    public static explicit operator PostV1PurchasesInvoicesCreateResponsePaymentStatus(
        string value
    ) => new(value);

    internal class PostV1PurchasesInvoicesCreateResponsePaymentStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesCreateResponsePaymentStatus>
    {
        public override PostV1PurchasesInvoicesCreateResponsePaymentStatus Read(
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
            return new PostV1PurchasesInvoicesCreateResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesCreateResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesCreateResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesCreateResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesCreateResponsePaymentStatus value,
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
        public const string Unpaid = "unpaid";

        public const string Partial = "partial";

        public const string Paid = "paid";
    }
}
