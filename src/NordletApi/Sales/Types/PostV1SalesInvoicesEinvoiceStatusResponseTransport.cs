using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesEinvoiceStatusResponseTransport.PostV1SalesInvoicesEinvoiceStatusResponseTransportSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesEinvoiceStatusResponseTransport : IStringEnum
{
    public static readonly PostV1SalesInvoicesEinvoiceStatusResponseTransport Bridge = new(
        Values.Bridge
    );

    public static readonly PostV1SalesInvoicesEinvoiceStatusResponseTransport Direct = new(
        Values.Direct
    );

    public PostV1SalesInvoicesEinvoiceStatusResponseTransport(string value)
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
    public static PostV1SalesInvoicesEinvoiceStatusResponseTransport FromCustom(string value)
    {
        return new PostV1SalesInvoicesEinvoiceStatusResponseTransport(value);
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
        PostV1SalesInvoicesEinvoiceStatusResponseTransport value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesEinvoiceStatusResponseTransport value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesInvoicesEinvoiceStatusResponseTransport value
    ) => value.Value;

    public static explicit operator PostV1SalesInvoicesEinvoiceStatusResponseTransport(
        string value
    ) => new(value);

    internal class PostV1SalesInvoicesEinvoiceStatusResponseTransportSerializer
        : JsonConverter<PostV1SalesInvoicesEinvoiceStatusResponseTransport>
    {
        public override PostV1SalesInvoicesEinvoiceStatusResponseTransport Read(
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
            return new PostV1SalesInvoicesEinvoiceStatusResponseTransport(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesEinvoiceStatusResponseTransport value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesEinvoiceStatusResponseTransport ReadAsPropertyName(
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
            return new PostV1SalesInvoicesEinvoiceStatusResponseTransport(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesEinvoiceStatusResponseTransport value,
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
