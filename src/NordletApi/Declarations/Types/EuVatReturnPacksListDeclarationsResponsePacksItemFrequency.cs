using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuVatReturnPacksListDeclarationsResponsePacksItemFrequency.EuVatReturnPacksListDeclarationsResponsePacksItemFrequencySerializer)
)]
[Serializable]
public readonly record struct EuVatReturnPacksListDeclarationsResponsePacksItemFrequency
    : IStringEnum
{
    public static readonly EuVatReturnPacksListDeclarationsResponsePacksItemFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly EuVatReturnPacksListDeclarationsResponsePacksItemFrequency Quarterly =
        new(Values.Quarterly);

    public static readonly EuVatReturnPacksListDeclarationsResponsePacksItemFrequency Annual = new(
        Values.Annual
    );

    public EuVatReturnPacksListDeclarationsResponsePacksItemFrequency(string value)
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
    public static EuVatReturnPacksListDeclarationsResponsePacksItemFrequency FromCustom(
        string value
    )
    {
        return new EuVatReturnPacksListDeclarationsResponsePacksItemFrequency(value);
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
        EuVatReturnPacksListDeclarationsResponsePacksItemFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuVatReturnPacksListDeclarationsResponsePacksItemFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuVatReturnPacksListDeclarationsResponsePacksItemFrequency value
    ) => value.Value;

    public static explicit operator EuVatReturnPacksListDeclarationsResponsePacksItemFrequency(
        string value
    ) => new(value);

    internal class EuVatReturnPacksListDeclarationsResponsePacksItemFrequencySerializer
        : JsonConverter<EuVatReturnPacksListDeclarationsResponsePacksItemFrequency>
    {
        public override EuVatReturnPacksListDeclarationsResponsePacksItemFrequency Read(
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
            return new EuVatReturnPacksListDeclarationsResponsePacksItemFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuVatReturnPacksListDeclarationsResponsePacksItemFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuVatReturnPacksListDeclarationsResponsePacksItemFrequency ReadAsPropertyName(
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
            return new EuVatReturnPacksListDeclarationsResponsePacksItemFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuVatReturnPacksListDeclarationsResponsePacksItemFrequency value,
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
        public const string Monthly = "monthly";

        public const string Quarterly = "quarterly";

        public const string Annual = "annual";
    }
}
