using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CertificatesDeleteDeclarationsResponseRowsItemFormat.CertificatesDeleteDeclarationsResponseRowsItemFormatSerializer)
)]
[Serializable]
public readonly record struct CertificatesDeleteDeclarationsResponseRowsItemFormat : IStringEnum
{
    public static readonly CertificatesDeleteDeclarationsResponseRowsItemFormat Pem = new(
        Values.Pem
    );

    public static readonly CertificatesDeleteDeclarationsResponseRowsItemFormat PemKey = new(
        Values.PemKey
    );

    public static readonly CertificatesDeleteDeclarationsResponseRowsItemFormat Pfx = new(
        Values.Pfx
    );

    public CertificatesDeleteDeclarationsResponseRowsItemFormat(string value)
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
    public static CertificatesDeleteDeclarationsResponseRowsItemFormat FromCustom(string value)
    {
        return new CertificatesDeleteDeclarationsResponseRowsItemFormat(value);
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
        CertificatesDeleteDeclarationsResponseRowsItemFormat value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CertificatesDeleteDeclarationsResponseRowsItemFormat value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CertificatesDeleteDeclarationsResponseRowsItemFormat value
    ) => value.Value;

    public static explicit operator CertificatesDeleteDeclarationsResponseRowsItemFormat(
        string value
    ) => new(value);

    internal class CertificatesDeleteDeclarationsResponseRowsItemFormatSerializer
        : JsonConverter<CertificatesDeleteDeclarationsResponseRowsItemFormat>
    {
        public override CertificatesDeleteDeclarationsResponseRowsItemFormat Read(
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
            return new CertificatesDeleteDeclarationsResponseRowsItemFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CertificatesDeleteDeclarationsResponseRowsItemFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CertificatesDeleteDeclarationsResponseRowsItemFormat ReadAsPropertyName(
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
            return new CertificatesDeleteDeclarationsResponseRowsItemFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CertificatesDeleteDeclarationsResponseRowsItemFormat value,
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
        public const string Pem = "pem";

        public const string PemKey = "pem-key";

        public const string Pfx = "pfx";
    }
}
