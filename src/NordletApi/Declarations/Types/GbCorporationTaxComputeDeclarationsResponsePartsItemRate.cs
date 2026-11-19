using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbCorporationTaxComputeDeclarationsResponsePartsItemRate.GbCorporationTaxComputeDeclarationsResponsePartsItemRateSerializer)
)]
[Serializable]
public readonly record struct GbCorporationTaxComputeDeclarationsResponsePartsItemRate : IStringEnum
{
    public static readonly GbCorporationTaxComputeDeclarationsResponsePartsItemRate Main = new(
        Values.Main
    );

    public static readonly GbCorporationTaxComputeDeclarationsResponsePartsItemRate SmallProfits =
        new(Values.SmallProfits);

    public static readonly GbCorporationTaxComputeDeclarationsResponsePartsItemRate MarginalRelief =
        new(Values.MarginalRelief);

    public GbCorporationTaxComputeDeclarationsResponsePartsItemRate(string value)
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
    public static GbCorporationTaxComputeDeclarationsResponsePartsItemRate FromCustom(string value)
    {
        return new GbCorporationTaxComputeDeclarationsResponsePartsItemRate(value);
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
        GbCorporationTaxComputeDeclarationsResponsePartsItemRate value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbCorporationTaxComputeDeclarationsResponsePartsItemRate value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbCorporationTaxComputeDeclarationsResponsePartsItemRate value
    ) => value.Value;

    public static explicit operator GbCorporationTaxComputeDeclarationsResponsePartsItemRate(
        string value
    ) => new(value);

    internal class GbCorporationTaxComputeDeclarationsResponsePartsItemRateSerializer
        : JsonConverter<GbCorporationTaxComputeDeclarationsResponsePartsItemRate>
    {
        public override GbCorporationTaxComputeDeclarationsResponsePartsItemRate Read(
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
            return new GbCorporationTaxComputeDeclarationsResponsePartsItemRate(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbCorporationTaxComputeDeclarationsResponsePartsItemRate value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbCorporationTaxComputeDeclarationsResponsePartsItemRate ReadAsPropertyName(
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
            return new GbCorporationTaxComputeDeclarationsResponsePartsItemRate(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbCorporationTaxComputeDeclarationsResponsePartsItemRate value,
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
        public const string Main = "main";

        public const string SmallProfits = "small_profits";

        public const string MarginalRelief = "marginal_relief";
    }
}
