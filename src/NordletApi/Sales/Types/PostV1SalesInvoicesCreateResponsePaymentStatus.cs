using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesCreateResponsePaymentStatus.PostV1SalesInvoicesCreateResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesCreateResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1SalesInvoicesCreateResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1SalesInvoicesCreateResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1SalesInvoicesCreateResponsePaymentStatus Paid = new(Values.Paid);

    public PostV1SalesInvoicesCreateResponsePaymentStatus(string value)
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
    public static PostV1SalesInvoicesCreateResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1SalesInvoicesCreateResponsePaymentStatus(value);
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
        PostV1SalesInvoicesCreateResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesCreateResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesCreateResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesCreateResponsePaymentStatus(string value) =>
        new(value);

    internal class PostV1SalesInvoicesCreateResponsePaymentStatusSerializer
        : JsonConverter<PostV1SalesInvoicesCreateResponsePaymentStatus>
    {
        public override PostV1SalesInvoicesCreateResponsePaymentStatus Read(
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
            return new PostV1SalesInvoicesCreateResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesCreateResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesCreateResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1SalesInvoicesCreateResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesCreateResponsePaymentStatus value,
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
