using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit.EeTsdAnnexesGetDeclarationsResponseInputAnnex5LimitSerializer)
)]
[Serializable]
public readonly record struct EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit : IStringEnum
{
    public static readonly EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit SocialTax = new(
        Values.SocialTax
    );

    public static readonly EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit Profit = new(
        Values.Profit
    );

    public EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit(string value)
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
    public static EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit FromCustom(string value)
    {
        return new EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit(value);
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
        EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit value
    ) => value.Value;

    public static explicit operator EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit(
        string value
    ) => new(value);

    internal class EeTsdAnnexesGetDeclarationsResponseInputAnnex5LimitSerializer
        : JsonConverter<EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit>
    {
        public override EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit Read(
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
            return new EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit ReadAsPropertyName(
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
            return new EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeTsdAnnexesGetDeclarationsResponseInputAnnex5Limit value,
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
