using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CertificatesDeleteDeclarationsResponseRowsItemHealth.CertificatesDeleteDeclarationsResponseRowsItemHealthSerializer)
)]
[Serializable]
public readonly record struct CertificatesDeleteDeclarationsResponseRowsItemHealth : IStringEnum
{
    public static readonly CertificatesDeleteDeclarationsResponseRowsItemHealth Ok = new(Values.Ok);

    public static readonly CertificatesDeleteDeclarationsResponseRowsItemHealth Expiring = new(
        Values.Expiring
    );

    public static readonly CertificatesDeleteDeclarationsResponseRowsItemHealth Expired = new(
        Values.Expired
    );

    public static readonly CertificatesDeleteDeclarationsResponseRowsItemHealth Unknown = new(
        Values.Unknown
    );

    public CertificatesDeleteDeclarationsResponseRowsItemHealth(string value)
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
    public static CertificatesDeleteDeclarationsResponseRowsItemHealth FromCustom(string value)
    {
        return new CertificatesDeleteDeclarationsResponseRowsItemHealth(value);
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
        CertificatesDeleteDeclarationsResponseRowsItemHealth value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CertificatesDeleteDeclarationsResponseRowsItemHealth value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CertificatesDeleteDeclarationsResponseRowsItemHealth value
    ) => value.Value;

    public static explicit operator CertificatesDeleteDeclarationsResponseRowsItemHealth(
        string value
    ) => new(value);

    internal class CertificatesDeleteDeclarationsResponseRowsItemHealthSerializer
        : JsonConverter<CertificatesDeleteDeclarationsResponseRowsItemHealth>
    {
        public override CertificatesDeleteDeclarationsResponseRowsItemHealth Read(
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
            return new CertificatesDeleteDeclarationsResponseRowsItemHealth(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CertificatesDeleteDeclarationsResponseRowsItemHealth value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CertificatesDeleteDeclarationsResponseRowsItemHealth ReadAsPropertyName(
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
            return new CertificatesDeleteDeclarationsResponseRowsItemHealth(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CertificatesDeleteDeclarationsResponseRowsItemHealth value,
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
