using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesListResponseRowsItemPaymentStatus.PostV1SalesInvoicesListResponseRowsItemPaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesListResponseRowsItemPaymentStatus : IStringEnum
{
    public static readonly PostV1SalesInvoicesListResponseRowsItemPaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1SalesInvoicesListResponseRowsItemPaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1SalesInvoicesListResponseRowsItemPaymentStatus Paid = new(
        Values.Paid
    );

    public PostV1SalesInvoicesListResponseRowsItemPaymentStatus(string value)
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
    public static PostV1SalesInvoicesListResponseRowsItemPaymentStatus FromCustom(string value)
    {
        return new PostV1SalesInvoicesListResponseRowsItemPaymentStatus(value);
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
        PostV1SalesInvoicesListResponseRowsItemPaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesListResponseRowsItemPaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesInvoicesListResponseRowsItemPaymentStatus value
    ) => value.Value;

    public static explicit operator PostV1SalesInvoicesListResponseRowsItemPaymentStatus(
        string value
    ) => new(value);

    internal class PostV1SalesInvoicesListResponseRowsItemPaymentStatusSerializer
        : JsonConverter<PostV1SalesInvoicesListResponseRowsItemPaymentStatus>
    {
        public override PostV1SalesInvoicesListResponseRowsItemPaymentStatus Read(
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
            return new PostV1SalesInvoicesListResponseRowsItemPaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesListResponseRowsItemPaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesListResponseRowsItemPaymentStatus ReadAsPropertyName(
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
            return new PostV1SalesInvoicesListResponseRowsItemPaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesListResponseRowsItemPaymentStatus value,
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
