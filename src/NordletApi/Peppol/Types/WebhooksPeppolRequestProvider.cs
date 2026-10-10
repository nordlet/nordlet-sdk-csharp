using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(WebhooksPeppolRequestProvider.WebhooksPeppolRequestProviderSerializer))]
[Serializable]
public readonly record struct WebhooksPeppolRequestProvider : IStringEnum
{
    public static readonly WebhooksPeppolRequestProvider Recommand = new(Values.Recommand);

    public static readonly WebhooksPeppolRequestProvider Storecove = new(Values.Storecove);

    public static readonly WebhooksPeppolRequestProvider EInvoiceBe = new(Values.EInvoiceBe);

    public WebhooksPeppolRequestProvider(string value)
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
    public static WebhooksPeppolRequestProvider FromCustom(string value)
    {
        return new WebhooksPeppolRequestProvider(value);
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

    public static bool operator ==(WebhooksPeppolRequestProvider value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebhooksPeppolRequestProvider value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksPeppolRequestProvider value) => value.Value;

    public static explicit operator WebhooksPeppolRequestProvider(string value) => new(value);

    internal class WebhooksPeppolRequestProviderSerializer
        : JsonConverter<WebhooksPeppolRequestProvider>
    {
        public override WebhooksPeppolRequestProvider Read(
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
            return new WebhooksPeppolRequestProvider(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WebhooksPeppolRequestProvider value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WebhooksPeppolRequestProvider ReadAsPropertyName(
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
            return new WebhooksPeppolRequestProvider(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WebhooksPeppolRequestProvider value,
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
        public const string Recommand = "recommand";

        public const string Storecove = "storecove";

        public const string EInvoiceBe = "e-invoice-be";
    }
}
