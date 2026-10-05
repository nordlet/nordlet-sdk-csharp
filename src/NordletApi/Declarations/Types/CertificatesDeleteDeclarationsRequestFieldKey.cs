using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CertificatesDeleteDeclarationsRequestFieldKey.CertificatesDeleteDeclarationsRequestFieldKeySerializer)
)]
[Serializable]
public readonly record struct CertificatesDeleteDeclarationsRequestFieldKey : IStringEnum
{
    public static readonly CertificatesDeleteDeclarationsRequestFieldKey Certificate = new(
        Values.Certificate
    );

    public static readonly CertificatesDeleteDeclarationsRequestFieldKey PrivateKey = new(
        Values.PrivateKey
    );

    public CertificatesDeleteDeclarationsRequestFieldKey(string value)
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
    public static CertificatesDeleteDeclarationsRequestFieldKey FromCustom(string value)
    {
        return new CertificatesDeleteDeclarationsRequestFieldKey(value);
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
        CertificatesDeleteDeclarationsRequestFieldKey value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CertificatesDeleteDeclarationsRequestFieldKey value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CertificatesDeleteDeclarationsRequestFieldKey value) =>
        value.Value;

    public static explicit operator CertificatesDeleteDeclarationsRequestFieldKey(string value) =>
        new(value);

    internal class CertificatesDeleteDeclarationsRequestFieldKeySerializer
        : JsonConverter<CertificatesDeleteDeclarationsRequestFieldKey>
    {
        public override CertificatesDeleteDeclarationsRequestFieldKey Read(
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
            return new CertificatesDeleteDeclarationsRequestFieldKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CertificatesDeleteDeclarationsRequestFieldKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CertificatesDeleteDeclarationsRequestFieldKey ReadAsPropertyName(
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
            return new CertificatesDeleteDeclarationsRequestFieldKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CertificatesDeleteDeclarationsRequestFieldKey value,
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
        public const string Certificate = "certificate";

        public const string PrivateKey = "privateKey";
    }
}
