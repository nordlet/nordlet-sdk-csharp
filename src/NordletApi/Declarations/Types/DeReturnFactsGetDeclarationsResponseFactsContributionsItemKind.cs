using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind.DeReturnFactsGetDeclarationsResponseFactsContributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind
    : IStringEnum
{
    public static readonly DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind Cash =
        new(Values.Cash);

    public static readonly DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind InKind =
        new(Values.InKind);

    public DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind(string value)
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
    public static DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind FromCustom(
        string value
    )
    {
        return new DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind(value);
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
        DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind value
    ) => value.Value;

    public static explicit operator DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind(
        string value
    ) => new(value);

    internal class DeReturnFactsGetDeclarationsResponseFactsContributionsItemKindSerializer
        : JsonConverter<DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind>
    {
        public override DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind Read(
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
            return new DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind ReadAsPropertyName(
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
            return new DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsGetDeclarationsResponseFactsContributionsItemKind value,
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
