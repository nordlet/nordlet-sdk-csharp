using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesRegisterResponsePaymentStatus.PostV1PurchasesInvoicesRegisterResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesRegisterResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesRegisterResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1PurchasesInvoicesRegisterResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1PurchasesInvoicesRegisterResponsePaymentStatus Paid = new(
        Values.Paid
    );

    public PostV1PurchasesInvoicesRegisterResponsePaymentStatus(string value)
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
    public static PostV1PurchasesInvoicesRegisterResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesRegisterResponsePaymentStatus(value);
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
        PostV1PurchasesInvoicesRegisterResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesRegisterResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PurchasesInvoicesRegisterResponsePaymentStatus value
    ) => value.Value;

    public static explicit operator PostV1PurchasesInvoicesRegisterResponsePaymentStatus(
        string value
    ) => new(value);

    internal class PostV1PurchasesInvoicesRegisterResponsePaymentStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesRegisterResponsePaymentStatus>
    {
        public override PostV1PurchasesInvoicesRegisterResponsePaymentStatus Read(
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
            return new PostV1PurchasesInvoicesRegisterResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesRegisterResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesRegisterResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesRegisterResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesRegisterResponsePaymentStatus value,
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
