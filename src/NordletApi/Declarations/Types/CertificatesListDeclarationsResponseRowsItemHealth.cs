using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CertificatesListDeclarationsResponseRowsItemHealth.CertificatesListDeclarationsResponseRowsItemHealthSerializer)
)]
[Serializable]
public readonly record struct CertificatesListDeclarationsResponseRowsItemHealth : IStringEnum
{
    public static readonly CertificatesListDeclarationsResponseRowsItemHealth Ok = new(Values.Ok);

    public static readonly CertificatesListDeclarationsResponseRowsItemHealth Expiring = new(
        Values.Expiring
    );

    public static readonly CertificatesListDeclarationsResponseRowsItemHealth Expired = new(
        Values.Expired
    );

    public static readonly CertificatesListDeclarationsResponseRowsItemHealth Unknown = new(
        Values.Unknown
    );

    public CertificatesListDeclarationsResponseRowsItemHealth(string value)
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
    public static CertificatesListDeclarationsResponseRowsItemHealth FromCustom(string value)
    {
        return new CertificatesListDeclarationsResponseRowsItemHealth(value);
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
        CertificatesListDeclarationsResponseRowsItemHealth value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CertificatesListDeclarationsResponseRowsItemHealth value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CertificatesListDeclarationsResponseRowsItemHealth value
    ) => value.Value;

    public static explicit operator CertificatesListDeclarationsResponseRowsItemHealth(
        string value
    ) => new(value);

    internal class CertificatesListDeclarationsResponseRowsItemHealthSerializer
        : JsonConverter<CertificatesListDeclarationsResponseRowsItemHealth>
    {
        public override CertificatesListDeclarationsResponseRowsItemHealth Read(
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
            return new CertificatesListDeclarationsResponseRowsItemHealth(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CertificatesListDeclarationsResponseRowsItemHealth value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CertificatesListDeclarationsResponseRowsItemHealth ReadAsPropertyName(
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
            return new CertificatesListDeclarationsResponseRowsItemHealth(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CertificatesListDeclarationsResponseRowsItemHealth value,
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
        public const string Ok = "ok";

        public const string Expiring = "expiring";

        public const string Expired = "expired";

        public const string Unknown = "unknown";
    }
}
