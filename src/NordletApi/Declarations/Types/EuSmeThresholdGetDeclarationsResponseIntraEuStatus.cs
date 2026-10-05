using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuSmeThresholdGetDeclarationsResponseIntraEuStatus.EuSmeThresholdGetDeclarationsResponseIntraEuStatusSerializer)
)]
[Serializable]
public readonly record struct EuSmeThresholdGetDeclarationsResponseIntraEuStatus : IStringEnum
{
    public static readonly EuSmeThresholdGetDeclarationsResponseIntraEuStatus Below = new(
        Values.Below
    );

    public static readonly EuSmeThresholdGetDeclarationsResponseIntraEuStatus Approaching = new(
        Values.Approaching
    );

    public static readonly EuSmeThresholdGetDeclarationsResponseIntraEuStatus Exceeded = new(
        Values.Exceeded
    );

    public EuSmeThresholdGetDeclarationsResponseIntraEuStatus(string value)
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
    public static EuSmeThresholdGetDeclarationsResponseIntraEuStatus FromCustom(string value)
    {
        return new EuSmeThresholdGetDeclarationsResponseIntraEuStatus(value);
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
        EuSmeThresholdGetDeclarationsResponseIntraEuStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuSmeThresholdGetDeclarationsResponseIntraEuStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuSmeThresholdGetDeclarationsResponseIntraEuStatus value
    ) => value.Value;

    public static explicit operator EuSmeThresholdGetDeclarationsResponseIntraEuStatus(
        string value
    ) => new(value);

    internal class EuSmeThresholdGetDeclarationsResponseIntraEuStatusSerializer
        : JsonConverter<EuSmeThresholdGetDeclarationsResponseIntraEuStatus>
    {
        public override EuSmeThresholdGetDeclarationsResponseIntraEuStatus Read(
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
            return new EuSmeThresholdGetDeclarationsResponseIntraEuStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuSmeThresholdGetDeclarationsResponseIntraEuStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuSmeThresholdGetDeclarationsResponseIntraEuStatus ReadAsPropertyName(
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
            return new EuSmeThresholdGetDeclarationsResponseIntraEuStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuSmeThresholdGetDeclarationsResponseIntraEuStatus value,
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
        public const string Below = "below";

        public const string Approaching = "approaching";

        public const string Exceeded = "exceeded";
    }
}
