using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind.DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKindSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind
    : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind Dividends =
        new(Values.Dividends);

    public static readonly DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind Other =
        new(Values.Other);

    public DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind(string value)
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
    public static DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind FromCustom(
        string value
    )
    {
        return new DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind(value);
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
        DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKindSerializer
        : JsonConverter<DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind>
    {
        public override DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind Read(
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
            return new DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItemKind value,
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
        public const string Dividends = "dividends";

        public const string Other = "other";
    }
}
