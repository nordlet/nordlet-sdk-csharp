using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItTfrAccrualPostDeclarationsResponseRowsItemDestination.ItTfrAccrualPostDeclarationsResponseRowsItemDestinationSerializer)
)]
[Serializable]
public readonly record struct ItTfrAccrualPostDeclarationsResponseRowsItemDestination : IStringEnum
{
    public static readonly ItTfrAccrualPostDeclarationsResponseRowsItemDestination Azienda = new(
        Values.Azienda
    );

    public static readonly ItTfrAccrualPostDeclarationsResponseRowsItemDestination FondoTesoreria =
        new(Values.FondoTesoreria);

    public static readonly ItTfrAccrualPostDeclarationsResponseRowsItemDestination PrevidenzaComplementare =
        new(Values.PrevidenzaComplementare);

    public ItTfrAccrualPostDeclarationsResponseRowsItemDestination(string value)
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
    public static ItTfrAccrualPostDeclarationsResponseRowsItemDestination FromCustom(string value)
    {
        return new ItTfrAccrualPostDeclarationsResponseRowsItemDestination(value);
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
        ItTfrAccrualPostDeclarationsResponseRowsItemDestination value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ItTfrAccrualPostDeclarationsResponseRowsItemDestination value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ItTfrAccrualPostDeclarationsResponseRowsItemDestination value
    ) => value.Value;

    public static explicit operator ItTfrAccrualPostDeclarationsResponseRowsItemDestination(
        string value
    ) => new(value);

    internal class ItTfrAccrualPostDeclarationsResponseRowsItemDestinationSerializer
        : JsonConverter<ItTfrAccrualPostDeclarationsResponseRowsItemDestination>
    {
        public override ItTfrAccrualPostDeclarationsResponseRowsItemDestination Read(
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
            return new ItTfrAccrualPostDeclarationsResponseRowsItemDestination(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItTfrAccrualPostDeclarationsResponseRowsItemDestination value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItTfrAccrualPostDeclarationsResponseRowsItemDestination ReadAsPropertyName(
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
            return new ItTfrAccrualPostDeclarationsResponseRowsItemDestination(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItTfrAccrualPostDeclarationsResponseRowsItemDestination value,
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
        public const string Azienda = "azienda";

        public const string FondoTesoreria = "fondo-tesoreria";

        public const string PrevidenzaComplementare = "previdenza-complementare";
    }
}
