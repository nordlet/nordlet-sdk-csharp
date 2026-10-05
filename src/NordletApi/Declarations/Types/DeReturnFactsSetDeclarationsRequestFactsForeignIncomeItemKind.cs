using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind.DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKindSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind
    : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind Dividends =
        new(Values.Dividends);

    public static readonly DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind Other =
        new(Values.Other);

    public DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind(string value)
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
    public static DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind FromCustom(
        string value
    )
    {
        return new DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind(value);
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
        DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKindSerializer
        : JsonConverter<DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind>
    {
        public override DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind Read(
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
            return new DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsRequestFactsForeignIncomeItemKind value,
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
