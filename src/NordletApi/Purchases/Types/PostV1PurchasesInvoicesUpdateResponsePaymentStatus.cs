using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesUpdateResponsePaymentStatus.PostV1PurchasesInvoicesUpdateResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesUpdateResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesUpdateResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1PurchasesInvoicesUpdateResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1PurchasesInvoicesUpdateResponsePaymentStatus Paid = new(
        Values.Paid
    );

    public PostV1PurchasesInvoicesUpdateResponsePaymentStatus(string value)
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
    public static PostV1PurchasesInvoicesUpdateResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesUpdateResponsePaymentStatus(value);
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
        PostV1PurchasesInvoicesUpdateResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesUpdateResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PurchasesInvoicesUpdateResponsePaymentStatus value
    ) => value.Value;

    public static explicit operator PostV1PurchasesInvoicesUpdateResponsePaymentStatus(
        string value
    ) => new(value);

    internal class PostV1PurchasesInvoicesUpdateResponsePaymentStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesUpdateResponsePaymentStatus>
    {
        public override PostV1PurchasesInvoicesUpdateResponsePaymentStatus Read(
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
            return new PostV1PurchasesInvoicesUpdateResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesUpdateResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesUpdateResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesUpdateResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesUpdateResponsePaymentStatus value,
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
