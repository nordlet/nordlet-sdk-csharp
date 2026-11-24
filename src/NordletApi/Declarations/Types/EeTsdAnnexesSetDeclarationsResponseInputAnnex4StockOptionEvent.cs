using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent.EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEventSerializer)
)]
[Serializable]
public readonly record struct EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent
    : IStringEnum
{
    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent Sale =
        new(Values.Sale);

    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent Exercise =
        new(Values.Exercise);

    public EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent(string value)
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
    public static EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent FromCustom(
        string value
    )
    {
        return new EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent(value);
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
        EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent value
    ) => value.Value;

    public static explicit operator EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent(
        string value
    ) => new(value);

    internal class EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEventSerializer
        : JsonConverter<EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent>
    {
        public override EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent Read(
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
            return new EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent ReadAsPropertyName(
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
            return new EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsResponseInputAnnex4StockOptionEvent value,
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
