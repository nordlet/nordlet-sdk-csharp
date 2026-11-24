using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent.EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEventSerializer)
)]
[Serializable]
public readonly record struct EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent : IStringEnum
{
    public static readonly EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent Sale = new(
        Values.Sale
    );

    public static readonly EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent Exercise = new(
        Values.Exercise
    );

    public EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent(string value)
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
    public static EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent FromCustom(string value)
    {
        return new EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent(value);
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
        EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent value
    ) => value.Value;

    public static explicit operator EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent(
        string value
    ) => new(value);

    internal class EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEventSerializer
        : JsonConverter<EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent>
    {
        public override EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent Read(
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
            return new EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent ReadAsPropertyName(
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
            return new EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsRequestAnnex4StockOptionEvent value,
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
