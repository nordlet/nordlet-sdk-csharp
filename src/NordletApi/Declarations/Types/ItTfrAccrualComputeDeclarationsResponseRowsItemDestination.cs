using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItTfrAccrualComputeDeclarationsResponseRowsItemDestination.ItTfrAccrualComputeDeclarationsResponseRowsItemDestinationSerializer)
)]
[Serializable]
public readonly record struct ItTfrAccrualComputeDeclarationsResponseRowsItemDestination
    : IStringEnum
{
    public static readonly ItTfrAccrualComputeDeclarationsResponseRowsItemDestination Azienda = new(
        Values.Azienda
    );

    public static readonly ItTfrAccrualComputeDeclarationsResponseRowsItemDestination FondoTesoreria =
        new(Values.FondoTesoreria);

    public static readonly ItTfrAccrualComputeDeclarationsResponseRowsItemDestination PrevidenzaComplementare =
        new(Values.PrevidenzaComplementare);

    public ItTfrAccrualComputeDeclarationsResponseRowsItemDestination(string value)
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
    public static ItTfrAccrualComputeDeclarationsResponseRowsItemDestination FromCustom(
        string value
    )
    {
        return new ItTfrAccrualComputeDeclarationsResponseRowsItemDestination(value);
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
        ItTfrAccrualComputeDeclarationsResponseRowsItemDestination value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ItTfrAccrualComputeDeclarationsResponseRowsItemDestination value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ItTfrAccrualComputeDeclarationsResponseRowsItemDestination value
    ) => value.Value;

    public static explicit operator ItTfrAccrualComputeDeclarationsResponseRowsItemDestination(
        string value
    ) => new(value);

    internal class ItTfrAccrualComputeDeclarationsResponseRowsItemDestinationSerializer
        : JsonConverter<ItTfrAccrualComputeDeclarationsResponseRowsItemDestination>
    {
        public override ItTfrAccrualComputeDeclarationsResponseRowsItemDestination Read(
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
            return new ItTfrAccrualComputeDeclarationsResponseRowsItemDestination(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItTfrAccrualComputeDeclarationsResponseRowsItemDestination value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItTfrAccrualComputeDeclarationsResponseRowsItemDestination ReadAsPropertyName(
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
            return new ItTfrAccrualComputeDeclarationsResponseRowsItemDestination(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItTfrAccrualComputeDeclarationsResponseRowsItemDestination value,
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
