using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind.DeReturnFactsSetDeclarationsResponseFactsContributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind
    : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind Cash =
        new(Values.Cash);

    public static readonly DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind InKind =
        new(Values.InKind);

    public DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind(string value)
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
    public static DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind FromCustom(
        string value
    )
    {
        return new DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind(value);
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
        DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsResponseFactsContributionsItemKindSerializer
        : JsonConverter<DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind>
    {
        public override DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind Read(
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
            return new DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsContributionsItemKind value,
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
        public const string Cash = "cash";

        public const string InKind = "in_kind";
    }
}
