using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreateOperationTypesRequestInvoiceType.CreateOperationTypesRequestInvoiceTypeSerializer)
)]
[Serializable]
public readonly record struct CreateOperationTypesRequestInvoiceType : IStringEnum
{
    public static readonly CreateOperationTypesRequestInvoiceType Invoice = new(Values.Invoice);

    public static readonly CreateOperationTypesRequestInvoiceType CreditNote = new(
        Values.CreditNote
    );

    public static readonly CreateOperationTypesRequestInvoiceType Proforma = new(Values.Proforma);

    public static readonly CreateOperationTypesRequestInvoiceType Advance = new(Values.Advance);

    public CreateOperationTypesRequestInvoiceType(string value)
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
    public static CreateOperationTypesRequestInvoiceType FromCustom(string value)
    {
        return new CreateOperationTypesRequestInvoiceType(value);
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

    public static bool operator ==(CreateOperationTypesRequestInvoiceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateOperationTypesRequestInvoiceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateOperationTypesRequestInvoiceType value) =>
        value.Value;

    public static explicit operator CreateOperationTypesRequestInvoiceType(string value) =>
        new(value);

    internal class CreateOperationTypesRequestInvoiceTypeSerializer
        : JsonConverter<CreateOperationTypesRequestInvoiceType>
    {
        public override CreateOperationTypesRequestInvoiceType Read(
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
            return new CreateOperationTypesRequestInvoiceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateOperationTypesRequestInvoiceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateOperationTypesRequestInvoiceType ReadAsPropertyName(
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
            return new CreateOperationTypesRequestInvoiceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateOperationTypesRequestInvoiceType value,
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
        public const string Invoice = "invoice";

        public const string CreditNote = "credit_note";

        public const string Proforma = "proforma";

        public const string Advance = "advance";
    }
}
