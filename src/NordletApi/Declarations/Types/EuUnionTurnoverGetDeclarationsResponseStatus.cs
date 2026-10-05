using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuUnionTurnoverGetDeclarationsResponseStatus.EuUnionTurnoverGetDeclarationsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct EuUnionTurnoverGetDeclarationsResponseStatus : IStringEnum
{
    public static readonly EuUnionTurnoverGetDeclarationsResponseStatus Below = new(Values.Below);

    public static readonly EuUnionTurnoverGetDeclarationsResponseStatus Approaching = new(
        Values.Approaching
    );

    public static readonly EuUnionTurnoverGetDeclarationsResponseStatus Exceeded = new(
        Values.Exceeded
    );

    public static readonly EuUnionTurnoverGetDeclarationsResponseStatus NotApplicable = new(
        Values.NotApplicable
    );

    public EuUnionTurnoverGetDeclarationsResponseStatus(string value)
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
    public static EuUnionTurnoverGetDeclarationsResponseStatus FromCustom(string value)
    {
        return new EuUnionTurnoverGetDeclarationsResponseStatus(value);
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
        EuUnionTurnoverGetDeclarationsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuUnionTurnoverGetDeclarationsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EuUnionTurnoverGetDeclarationsResponseStatus value) =>
        value.Value;

    public static explicit operator EuUnionTurnoverGetDeclarationsResponseStatus(string value) =>
        new(value);

    internal class EuUnionTurnoverGetDeclarationsResponseStatusSerializer
        : JsonConverter<EuUnionTurnoverGetDeclarationsResponseStatus>
    {
        public override EuUnionTurnoverGetDeclarationsResponseStatus Read(
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
            return new EuUnionTurnoverGetDeclarationsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuUnionTurnoverGetDeclarationsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuUnionTurnoverGetDeclarationsResponseStatus ReadAsPropertyName(
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
            return new EuUnionTurnoverGetDeclarationsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuUnionTurnoverGetDeclarationsResponseStatus value,
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

        public const string NotApplicable = "not_applicable";
    }
}
