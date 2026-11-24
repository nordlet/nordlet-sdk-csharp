using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeTsdAnnexesSetDeclarationsRequestAnnex5Limit.EeTsdAnnexesSetDeclarationsRequestAnnex5LimitSerializer)
)]
[Serializable]
public readonly record struct EeTsdAnnexesSetDeclarationsRequestAnnex5Limit : IStringEnum
{
    public static readonly EeTsdAnnexesSetDeclarationsRequestAnnex5Limit SocialTax = new(
        Values.SocialTax
    );

    public static readonly EeTsdAnnexesSetDeclarationsRequestAnnex5Limit Profit = new(
        Values.Profit
    );

    public EeTsdAnnexesSetDeclarationsRequestAnnex5Limit(string value)
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
    public static EeTsdAnnexesSetDeclarationsRequestAnnex5Limit FromCustom(string value)
    {
        return new EeTsdAnnexesSetDeclarationsRequestAnnex5Limit(value);
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
        EeTsdAnnexesSetDeclarationsRequestAnnex5Limit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeTsdAnnexesSetDeclarationsRequestAnnex5Limit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EeTsdAnnexesSetDeclarationsRequestAnnex5Limit value) =>
        value.Value;

    public static explicit operator EeTsdAnnexesSetDeclarationsRequestAnnex5Limit(string value) =>
        new(value);

    internal class EeTsdAnnexesSetDeclarationsRequestAnnex5LimitSerializer
        : JsonConverter<EeTsdAnnexesSetDeclarationsRequestAnnex5Limit>
    {
        public override EeTsdAnnexesSetDeclarationsRequestAnnex5Limit Read(
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
            return new EeTsdAnnexesSetDeclarationsRequestAnnex5Limit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsRequestAnnex5Limit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeTsdAnnexesSetDeclarationsRequestAnnex5Limit ReadAsPropertyName(
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
            return new EeTsdAnnexesSetDeclarationsRequestAnnex5Limit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsRequestAnnex5Limit value,
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
        public const string SocialTax = "socialTax";

        public const string Profit = "profit";
    }
}
