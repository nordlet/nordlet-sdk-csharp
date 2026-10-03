using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesEinvoiceSendResponseTransport.PostV1SalesInvoicesEinvoiceSendResponseTransportSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesEinvoiceSendResponseTransport : IStringEnum
{
    public static readonly PostV1SalesInvoicesEinvoiceSendResponseTransport Bridge = new(
        Values.Bridge
    );

    public static readonly PostV1SalesInvoicesEinvoiceSendResponseTransport Direct = new(
        Values.Direct
    );

    public PostV1SalesInvoicesEinvoiceSendResponseTransport(string value)
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
    public static PostV1SalesInvoicesEinvoiceSendResponseTransport FromCustom(string value)
    {
        return new PostV1SalesInvoicesEinvoiceSendResponseTransport(value);
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
        PostV1SalesInvoicesEinvoiceSendResponseTransport value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesEinvoiceSendResponseTransport value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesInvoicesEinvoiceSendResponseTransport value
    ) => value.Value;

    public static explicit operator PostV1SalesInvoicesEinvoiceSendResponseTransport(
        string value
    ) => new(value);

    internal class PostV1SalesInvoicesEinvoiceSendResponseTransportSerializer
        : JsonConverter<PostV1SalesInvoicesEinvoiceSendResponseTransport>
    {
        public override PostV1SalesInvoicesEinvoiceSendResponseTransport Read(
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
            return new PostV1SalesInvoicesEinvoiceSendResponseTransport(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesEinvoiceSendResponseTransport value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesEinvoiceSendResponseTransport ReadAsPropertyName(
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
            return new PostV1SalesInvoicesEinvoiceSendResponseTransport(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesEinvoiceSendResponseTransport value,
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
        public const string Bridge = "bridge";

        public const string Direct = "direct";
    }
}
