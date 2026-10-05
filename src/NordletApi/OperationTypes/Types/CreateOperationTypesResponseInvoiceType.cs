using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreateOperationTypesResponseInvoiceType.CreateOperationTypesResponseInvoiceTypeSerializer)
)]
[Serializable]
public readonly record struct CreateOperationTypesResponseInvoiceType : IStringEnum
{
    public static readonly CreateOperationTypesResponseInvoiceType Invoice = new(Values.Invoice);

    public static readonly CreateOperationTypesResponseInvoiceType CreditNote = new(
        Values.CreditNote
    );

    public static readonly CreateOperationTypesResponseInvoiceType Proforma = new(Values.Proforma);

    public static readonly CreateOperationTypesResponseInvoiceType Advance = new(Values.Advance);

    public CreateOperationTypesResponseInvoiceType(string value)
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
    public static CreateOperationTypesResponseInvoiceType FromCustom(string value)
    {
        return new CreateOperationTypesResponseInvoiceType(value);
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

    public static bool operator ==(CreateOperationTypesResponseInvoiceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateOperationTypesResponseInvoiceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateOperationTypesResponseInvoiceType value) =>
        value.Value;

    public static explicit operator CreateOperationTypesResponseInvoiceType(string value) =>
        new(value);

    internal class CreateOperationTypesResponseInvoiceTypeSerializer
        : JsonConverter<CreateOperationTypesResponseInvoiceType>
    {
        public override CreateOperationTypesResponseInvoiceType Read(
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
            return new CreateOperationTypesResponseInvoiceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateOperationTypesResponseInvoiceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateOperationTypesResponseInvoiceType ReadAsPropertyName(
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
            return new CreateOperationTypesResponseInvoiceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateOperationTypesResponseInvoiceType value,
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
