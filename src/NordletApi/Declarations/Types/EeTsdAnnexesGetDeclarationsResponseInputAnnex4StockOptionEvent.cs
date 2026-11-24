using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent.EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEventSerializer)
)]
[Serializable]
public readonly record struct EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent
    : IStringEnum
{
    public static readonly EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent Sale =
        new(Values.Sale);

    public static readonly EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent Exercise =
        new(Values.Exercise);

    public EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent(string value)
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
    public static EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent FromCustom(
        string value
    )
    {
        return new EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent(value);
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
        EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent value
    ) => value.Value;

    public static explicit operator EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent(
        string value
    ) => new(value);

    internal class EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEventSerializer
        : JsonConverter<EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent>
    {
        public override EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent Read(
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
            return new EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent ReadAsPropertyName(
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
            return new EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeTsdAnnexesGetDeclarationsResponseInputAnnex4StockOptionEvent value,
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
        public const string Sale = "sale";

        public const string Exercise = "exercise";
    }
}
