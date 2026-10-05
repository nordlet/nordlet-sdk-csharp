using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtIvazCancelDeclarationsRequestEntriesItemReason.LtIvazCancelDeclarationsRequestEntriesItemReasonSerializer)
)]
[Serializable]
public readonly record struct LtIvazCancelDeclarationsRequestEntriesItemReason : IStringEnum
{
    public static readonly LtIvazCancelDeclarationsRequestEntriesItemReason One = new(Values.One);

    public static readonly LtIvazCancelDeclarationsRequestEntriesItemReason Two = new(Values.Two);

    public static readonly LtIvazCancelDeclarationsRequestEntriesItemReason Three = new(
        Values.Three
    );

    public static readonly LtIvazCancelDeclarationsRequestEntriesItemReason Four = new(Values.Four);

    public static readonly LtIvazCancelDeclarationsRequestEntriesItemReason Five = new(Values.Five);

    public static readonly LtIvazCancelDeclarationsRequestEntriesItemReason Six = new(Values.Six);

    public LtIvazCancelDeclarationsRequestEntriesItemReason(string value)
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
    public static LtIvazCancelDeclarationsRequestEntriesItemReason FromCustom(string value)
    {
        return new LtIvazCancelDeclarationsRequestEntriesItemReason(value);
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
        LtIvazCancelDeclarationsRequestEntriesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtIvazCancelDeclarationsRequestEntriesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LtIvazCancelDeclarationsRequestEntriesItemReason value
    ) => value.Value;

    public static explicit operator LtIvazCancelDeclarationsRequestEntriesItemReason(
        string value
    ) => new(value);

    internal class LtIvazCancelDeclarationsRequestEntriesItemReasonSerializer
        : JsonConverter<LtIvazCancelDeclarationsRequestEntriesItemReason>
    {
        public override LtIvazCancelDeclarationsRequestEntriesItemReason Read(
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
            return new LtIvazCancelDeclarationsRequestEntriesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtIvazCancelDeclarationsRequestEntriesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtIvazCancelDeclarationsRequestEntriesItemReason ReadAsPropertyName(
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
            return new LtIvazCancelDeclarationsRequestEntriesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtIvazCancelDeclarationsRequestEntriesItemReason value,
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
        public const string One = "1";

        public const string Two = "2";

        public const string Three = "3";

        public const string Four = "4";

        public const string Five = "5";

        public const string Six = "6";
    }
}
