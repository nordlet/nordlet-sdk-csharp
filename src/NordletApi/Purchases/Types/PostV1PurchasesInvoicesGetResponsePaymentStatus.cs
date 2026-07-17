using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesGetResponsePaymentStatus.PostV1PurchasesInvoicesGetResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesGetResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesGetResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1PurchasesInvoicesGetResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1PurchasesInvoicesGetResponsePaymentStatus Paid = new(Values.Paid);

    public PostV1PurchasesInvoicesGetResponsePaymentStatus(string value)
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
    public static PostV1PurchasesInvoicesGetResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesGetResponsePaymentStatus(value);
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
        PostV1PurchasesInvoicesGetResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesGetResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesInvoicesGetResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesInvoicesGetResponsePaymentStatus(string value) =>
        new(value);

    internal class PostV1PurchasesInvoicesGetResponsePaymentStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesGetResponsePaymentStatus>
    {
        public override PostV1PurchasesInvoicesGetResponsePaymentStatus Read(
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
            return new PostV1PurchasesInvoicesGetResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesGetResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesGetResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesGetResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesGetResponsePaymentStatus value,
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
