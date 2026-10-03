using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesEinvoiceSendResponseStatus.PostV1SalesInvoicesEinvoiceSendResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesEinvoiceSendResponseStatus : IStringEnum
{
    public static readonly PostV1SalesInvoicesEinvoiceSendResponseStatus Sent = new(Values.Sent);

    public static readonly PostV1SalesInvoicesEinvoiceSendResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1SalesInvoicesEinvoiceSendResponseStatus Rejected = new(
        Values.Rejected
    );

    public PostV1SalesInvoicesEinvoiceSendResponseStatus(string value)
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
    public static PostV1SalesInvoicesEinvoiceSendResponseStatus FromCustom(string value)
    {
        return new PostV1SalesInvoicesEinvoiceSendResponseStatus(value);
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
        PostV1SalesInvoicesEinvoiceSendResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesEinvoiceSendResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesEinvoiceSendResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesEinvoiceSendResponseStatus(string value) =>
        new(value);

    internal class PostV1SalesInvoicesEinvoiceSendResponseStatusSerializer
        : JsonConverter<PostV1SalesInvoicesEinvoiceSendResponseStatus>
    {
        public override PostV1SalesInvoicesEinvoiceSendResponseStatus Read(
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
            return new PostV1SalesInvoicesEinvoiceSendResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesEinvoiceSendResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesEinvoiceSendResponseStatus ReadAsPropertyName(
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
            return new PostV1SalesInvoicesEinvoiceSendResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesEinvoiceSendResponseStatus value,
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
        public const string Sent = "sent";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
