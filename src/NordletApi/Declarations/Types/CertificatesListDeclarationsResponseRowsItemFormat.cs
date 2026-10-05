using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CertificatesListDeclarationsResponseRowsItemFormat.CertificatesListDeclarationsResponseRowsItemFormatSerializer)
)]
[Serializable]
public readonly record struct CertificatesListDeclarationsResponseRowsItemFormat : IStringEnum
{
    public static readonly CertificatesListDeclarationsResponseRowsItemFormat Pem = new(Values.Pem);

    public static readonly CertificatesListDeclarationsResponseRowsItemFormat PemKey = new(
        Values.PemKey
    );

    public static readonly CertificatesListDeclarationsResponseRowsItemFormat Pfx = new(Values.Pfx);

    public CertificatesListDeclarationsResponseRowsItemFormat(string value)
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
    public static CertificatesListDeclarationsResponseRowsItemFormat FromCustom(string value)
    {
        return new CertificatesListDeclarationsResponseRowsItemFormat(value);
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
        CertificatesListDeclarationsResponseRowsItemFormat value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CertificatesListDeclarationsResponseRowsItemFormat value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CertificatesListDeclarationsResponseRowsItemFormat value
    ) => value.Value;

    public static explicit operator CertificatesListDeclarationsResponseRowsItemFormat(
        string value
    ) => new(value);

    internal class CertificatesListDeclarationsResponseRowsItemFormatSerializer
        : JsonConverter<CertificatesListDeclarationsResponseRowsItemFormat>
    {
        public override CertificatesListDeclarationsResponseRowsItemFormat Read(
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
            return new CertificatesListDeclarationsResponseRowsItemFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CertificatesListDeclarationsResponseRowsItemFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CertificatesListDeclarationsResponseRowsItemFormat ReadAsPropertyName(
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
            return new CertificatesListDeclarationsResponseRowsItemFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CertificatesListDeclarationsResponseRowsItemFormat value,
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
