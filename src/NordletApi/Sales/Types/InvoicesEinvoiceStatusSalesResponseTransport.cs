using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesEinvoiceStatusSalesResponseTransport.InvoicesEinvoiceStatusSalesResponseTransportSerializer)
)]
[Serializable]
public readonly record struct InvoicesEinvoiceStatusSalesResponseTransport : IStringEnum
{
    public static readonly InvoicesEinvoiceStatusSalesResponseTransport Bridge = new(Values.Bridge);

    public static readonly InvoicesEinvoiceStatusSalesResponseTransport Direct = new(Values.Direct);

    public InvoicesEinvoiceStatusSalesResponseTransport(string value)
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
    public static InvoicesEinvoiceStatusSalesResponseTransport FromCustom(string value)
    {
        return new InvoicesEinvoiceStatusSalesResponseTransport(value);
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
        InvoicesEinvoiceStatusSalesResponseTransport value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesEinvoiceStatusSalesResponseTransport value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesEinvoiceStatusSalesResponseTransport value) =>
        value.Value;

    public static explicit operator InvoicesEinvoiceStatusSalesResponseTransport(string value) =>
        new(value);

    internal class InvoicesEinvoiceStatusSalesResponseTransportSerializer
        : JsonConverter<InvoicesEinvoiceStatusSalesResponseTransport>
    {
        public override InvoicesEinvoiceStatusSalesResponseTransport Read(
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
            return new InvoicesEinvoiceStatusSalesResponseTransport(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesEinvoiceStatusSalesResponseTransport value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesEinvoiceStatusSalesResponseTransport ReadAsPropertyName(
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
            return new InvoicesEinvoiceStatusSalesResponseTransport(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesEinvoiceStatusSalesResponseTransport value,
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
