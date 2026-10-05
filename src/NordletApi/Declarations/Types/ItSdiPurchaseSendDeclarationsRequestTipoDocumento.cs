using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItSdiPurchaseSendDeclarationsRequestTipoDocumento.ItSdiPurchaseSendDeclarationsRequestTipoDocumentoSerializer)
)]
[Serializable]
public readonly record struct ItSdiPurchaseSendDeclarationsRequestTipoDocumento : IStringEnum
{
    public static readonly ItSdiPurchaseSendDeclarationsRequestTipoDocumento Td16 = new(
        Values.Td16
    );

    public static readonly ItSdiPurchaseSendDeclarationsRequestTipoDocumento Td17 = new(
        Values.Td17
    );

    public static readonly ItSdiPurchaseSendDeclarationsRequestTipoDocumento Td18 = new(
        Values.Td18
    );

    public static readonly ItSdiPurchaseSendDeclarationsRequestTipoDocumento Td19 = new(
        Values.Td19
    );

    public ItSdiPurchaseSendDeclarationsRequestTipoDocumento(string value)
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
    public static ItSdiPurchaseSendDeclarationsRequestTipoDocumento FromCustom(string value)
    {
        return new ItSdiPurchaseSendDeclarationsRequestTipoDocumento(value);
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
        ItSdiPurchaseSendDeclarationsRequestTipoDocumento value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ItSdiPurchaseSendDeclarationsRequestTipoDocumento value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ItSdiPurchaseSendDeclarationsRequestTipoDocumento value
    ) => value.Value;

    public static explicit operator ItSdiPurchaseSendDeclarationsRequestTipoDocumento(
        string value
    ) => new(value);

    internal class ItSdiPurchaseSendDeclarationsRequestTipoDocumentoSerializer
        : JsonConverter<ItSdiPurchaseSendDeclarationsRequestTipoDocumento>
    {
        public override ItSdiPurchaseSendDeclarationsRequestTipoDocumento Read(
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
            return new ItSdiPurchaseSendDeclarationsRequestTipoDocumento(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItSdiPurchaseSendDeclarationsRequestTipoDocumento value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItSdiPurchaseSendDeclarationsRequestTipoDocumento ReadAsPropertyName(
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
            return new ItSdiPurchaseSendDeclarationsRequestTipoDocumento(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItSdiPurchaseSendDeclarationsRequestTipoDocumento value,
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
        public const string Td16 = "TD16";

        public const string Td17 = "TD17";

        public const string Td18 = "TD18";

        public const string Td19 = "TD19";
    }
}
