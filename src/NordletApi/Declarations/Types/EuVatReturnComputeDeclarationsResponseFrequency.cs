using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuVatReturnComputeDeclarationsResponseFrequency.EuVatReturnComputeDeclarationsResponseFrequencySerializer)
)]
[Serializable]
public readonly record struct EuVatReturnComputeDeclarationsResponseFrequency : IStringEnum
{
    public static readonly EuVatReturnComputeDeclarationsResponseFrequency Monthly = new(
        Values.Monthly
    );

    public static readonly EuVatReturnComputeDeclarationsResponseFrequency Quarterly = new(
        Values.Quarterly
    );

    public static readonly EuVatReturnComputeDeclarationsResponseFrequency Annual = new(
        Values.Annual
    );

    public EuVatReturnComputeDeclarationsResponseFrequency(string value)
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
    public static EuVatReturnComputeDeclarationsResponseFrequency FromCustom(string value)
    {
        return new EuVatReturnComputeDeclarationsResponseFrequency(value);
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
        EuVatReturnComputeDeclarationsResponseFrequency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuVatReturnComputeDeclarationsResponseFrequency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EuVatReturnComputeDeclarationsResponseFrequency value) =>
        value.Value;

    public static explicit operator EuVatReturnComputeDeclarationsResponseFrequency(string value) =>
        new(value);

    internal class EuVatReturnComputeDeclarationsResponseFrequencySerializer
        : JsonConverter<EuVatReturnComputeDeclarationsResponseFrequency>
    {
        public override EuVatReturnComputeDeclarationsResponseFrequency Read(
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
            return new EuVatReturnComputeDeclarationsResponseFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuVatReturnComputeDeclarationsResponseFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuVatReturnComputeDeclarationsResponseFrequency ReadAsPropertyName(
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
            return new EuVatReturnComputeDeclarationsResponseFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuVatReturnComputeDeclarationsResponseFrequency value,
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
