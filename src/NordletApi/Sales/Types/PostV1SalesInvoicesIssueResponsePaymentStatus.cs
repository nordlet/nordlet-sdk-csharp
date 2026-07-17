using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesIssueResponsePaymentStatus.PostV1SalesInvoicesIssueResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesIssueResponsePaymentStatus : IStringEnum
{
    public static readonly PostV1SalesInvoicesIssueResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly PostV1SalesInvoicesIssueResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly PostV1SalesInvoicesIssueResponsePaymentStatus Paid = new(Values.Paid);

    public PostV1SalesInvoicesIssueResponsePaymentStatus(string value)
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
    public static PostV1SalesInvoicesIssueResponsePaymentStatus FromCustom(string value)
    {
        return new PostV1SalesInvoicesIssueResponsePaymentStatus(value);
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
        PostV1SalesInvoicesIssueResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesIssueResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesIssueResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesIssueResponsePaymentStatus(string value) =>
        new(value);

    internal class PostV1SalesInvoicesIssueResponsePaymentStatusSerializer
        : JsonConverter<PostV1SalesInvoicesIssueResponsePaymentStatus>
    {
        public override PostV1SalesInvoicesIssueResponsePaymentStatus Read(
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
            return new PostV1SalesInvoicesIssueResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesIssueResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesIssueResponsePaymentStatus ReadAsPropertyName(
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
            return new PostV1SalesInvoicesIssueResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesIssueResponsePaymentStatus value,
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
