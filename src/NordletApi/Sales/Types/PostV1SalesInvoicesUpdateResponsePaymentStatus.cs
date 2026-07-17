using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesUpdateResponsePaymentStatus.PostV1SalesInvoicesUpdateResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesUpdateResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1SalesInvoicesUpdateResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1SalesInvoicesUpdateResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1SalesInvoicesUpdateResponsePaymentStatus Paid = new(Values.Paid);

    public PostV1SalesInvoicesUpdateResponsePaymentStatus(string value)
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
    public static PostV1SalesInvoicesUpdateResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1SalesInvoicesUpdateResponsePaymentStatus(value);
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
        PostV1SalesInvoicesUpdateResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesUpdateResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesUpdateResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesUpdateResponsePaymentStatus(string value) =>
        new(value);

    internal class PostV1SalesInvoicesUpdateResponsePaymentStatusSerializer
        : JsonConverter<PostV1SalesInvoicesUpdateResponsePaymentStatus>
    {
        public override PostV1SalesInvoicesUpdateResponsePaymentStatus Read(
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
            return new PostV1SalesInvoicesUpdateResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesUpdateResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesUpdateResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1SalesInvoicesUpdateResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesUpdateResponsePaymentStatus value,
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
