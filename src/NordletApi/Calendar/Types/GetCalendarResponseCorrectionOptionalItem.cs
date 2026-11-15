using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GetCalendarResponseCorrectionOptionalItem.GetCalendarResponseCorrectionOptionalItemSerializer)
)]
[Serializable]
public readonly record struct GetCalendarResponseCorrectionOptionalItem : IStringEnum
{
    public static readonly GetCalendarResponseCorrectionOptionalItem Reason = new(Values.Reason);

    public static readonly GetCalendarResponseCorrectionOptionalItem ReasonCode = new(
        Values.ReasonCode
    );

    public static readonly GetCalendarResponseCorrectionOptionalItem AuthorityReference = new(
        Values.AuthorityReference
    );

    public static readonly GetCalendarResponseCorrectionOptionalItem DiscoveredOn = new(
        Values.DiscoveredOn
    );

    public GetCalendarResponseCorrectionOptionalItem(string value)
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
    public static GetCalendarResponseCorrectionOptionalItem FromCustom(string value)
    {
        return new GetCalendarResponseCorrectionOptionalItem(value);
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
        GetCalendarResponseCorrectionOptionalItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetCalendarResponseCorrectionOptionalItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetCalendarResponseCorrectionOptionalItem value) =>
        value.Value;

    public static explicit operator GetCalendarResponseCorrectionOptionalItem(string value) =>
        new(value);

    internal class GetCalendarResponseCorrectionOptionalItemSerializer
        : JsonConverter<GetCalendarResponseCorrectionOptionalItem>
    {
        public override GetCalendarResponseCorrectionOptionalItem Read(
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
            return new GetCalendarResponseCorrectionOptionalItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCalendarResponseCorrectionOptionalItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCalendarResponseCorrectionOptionalItem ReadAsPropertyName(
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
            return new GetCalendarResponseCorrectionOptionalItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCalendarResponseCorrectionOptionalItem value,
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
        public const string Reason = "reason";

        public const string ReasonCode = "reasonCode";

        public const string AuthorityReference = "authorityReference";

        public const string DiscoveredOn = "discoveredOn";
    }
}
