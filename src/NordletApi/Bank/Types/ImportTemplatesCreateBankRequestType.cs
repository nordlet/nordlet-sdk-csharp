using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ImportTemplatesCreateBankRequestType.ImportTemplatesCreateBankRequestTypeSerializer)
)]
[Serializable]
public readonly record struct ImportTemplatesCreateBankRequestType : IStringEnum
{
    public static readonly ImportTemplatesCreateBankRequestType Stripe = new(Values.Stripe);

    public static readonly ImportTemplatesCreateBankRequestType Iso20022 = new(Values.Iso20022);

    public static readonly ImportTemplatesCreateBankRequestType BankConnection = new(
        Values.BankConnection
    );

    public ImportTemplatesCreateBankRequestType(string value)
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
    public static ImportTemplatesCreateBankRequestType FromCustom(string value)
    {
        return new ImportTemplatesCreateBankRequestType(value);
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

    public static bool operator ==(ImportTemplatesCreateBankRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ImportTemplatesCreateBankRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ImportTemplatesCreateBankRequestType value) =>
        value.Value;

    public static explicit operator ImportTemplatesCreateBankRequestType(string value) =>
        new(value);

    internal class ImportTemplatesCreateBankRequestTypeSerializer
        : JsonConverter<ImportTemplatesCreateBankRequestType>
    {
        public override ImportTemplatesCreateBankRequestType Read(
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
            return new ImportTemplatesCreateBankRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ImportTemplatesCreateBankRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ImportTemplatesCreateBankRequestType ReadAsPropertyName(
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
            return new ImportTemplatesCreateBankRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ImportTemplatesCreateBankRequestType value,
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
        public const string Stripe = "stripe";

        public const string Iso20022 = "iso20022";

        public const string BankConnection = "bank_connection";
    }
}
