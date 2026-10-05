using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesPaymentLinkSalesResponseSource.InvoicesPaymentLinkSalesResponseSourceSerializer)
)]
[Serializable]
public readonly record struct InvoicesPaymentLinkSalesResponseSource : IStringEnum
{
    public static readonly InvoicesPaymentLinkSalesResponseSource Template = new(Values.Template);

    public InvoicesPaymentLinkSalesResponseSource(string value)
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
    public static InvoicesPaymentLinkSalesResponseSource FromCustom(string value)
    {
        return new InvoicesPaymentLinkSalesResponseSource(value);
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

    public static bool operator ==(InvoicesPaymentLinkSalesResponseSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesPaymentLinkSalesResponseSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesPaymentLinkSalesResponseSource value) =>
        value.Value;

    public static explicit operator InvoicesPaymentLinkSalesResponseSource(string value) =>
        new(value);

    internal class InvoicesPaymentLinkSalesResponseSourceSerializer
        : JsonConverter<InvoicesPaymentLinkSalesResponseSource>
    {
        public override InvoicesPaymentLinkSalesResponseSource Read(
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
            return new InvoicesPaymentLinkSalesResponseSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesPaymentLinkSalesResponseSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesPaymentLinkSalesResponseSource ReadAsPropertyName(
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
            return new InvoicesPaymentLinkSalesResponseSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesPaymentLinkSalesResponseSource value,
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
        public const string Template = "template";
    }
}
