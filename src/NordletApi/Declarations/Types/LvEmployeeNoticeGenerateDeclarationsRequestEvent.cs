using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LvEmployeeNoticeGenerateDeclarationsRequestEvent.LvEmployeeNoticeGenerateDeclarationsRequestEventSerializer)
)]
[Serializable]
public readonly record struct LvEmployeeNoticeGenerateDeclarationsRequestEvent : IStringEnum
{
    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEvent Start = new(
        Values.Start
    );

    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEvent End = new(Values.End);

    public LvEmployeeNoticeGenerateDeclarationsRequestEvent(string value)
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
    public static LvEmployeeNoticeGenerateDeclarationsRequestEvent FromCustom(string value)
    {
        return new LvEmployeeNoticeGenerateDeclarationsRequestEvent(value);
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
        LvEmployeeNoticeGenerateDeclarationsRequestEvent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LvEmployeeNoticeGenerateDeclarationsRequestEvent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LvEmployeeNoticeGenerateDeclarationsRequestEvent value
    ) => value.Value;

    public static explicit operator LvEmployeeNoticeGenerateDeclarationsRequestEvent(
        string value
    ) => new(value);

    internal class LvEmployeeNoticeGenerateDeclarationsRequestEventSerializer
        : JsonConverter<LvEmployeeNoticeGenerateDeclarationsRequestEvent>
    {
        public override LvEmployeeNoticeGenerateDeclarationsRequestEvent Read(
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
            return new LvEmployeeNoticeGenerateDeclarationsRequestEvent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LvEmployeeNoticeGenerateDeclarationsRequestEvent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LvEmployeeNoticeGenerateDeclarationsRequestEvent ReadAsPropertyName(
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
            return new LvEmployeeNoticeGenerateDeclarationsRequestEvent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LvEmployeeNoticeGenerateDeclarationsRequestEvent value,
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
        public const string Start = "start";

        public const string End = "end";
    }
}
