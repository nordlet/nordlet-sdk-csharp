using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LvEmployeeNoticeGenerateDeclarationsRequestEndCode.LvEmployeeNoticeGenerateDeclarationsRequestEndCodeSerializer)
)]
[Serializable]
public readonly record struct LvEmployeeNoticeGenerateDeclarationsRequestEndCode : IStringEnum
{
    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEndCode TwentyOne = new(
        Values.TwentyOne
    );

    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEndCode TwentyTwo = new(
        Values.TwentyTwo
    );

    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEndCode TwentyThree = new(
        Values.TwentyThree
    );

    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEndCode TwentyFour = new(
        Values.TwentyFour
    );

    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEndCode TwentyFive = new(
        Values.TwentyFive
    );

    public static readonly LvEmployeeNoticeGenerateDeclarationsRequestEndCode TwentySix = new(
        Values.TwentySix
    );

    public LvEmployeeNoticeGenerateDeclarationsRequestEndCode(string value)
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
    public static LvEmployeeNoticeGenerateDeclarationsRequestEndCode FromCustom(string value)
    {
        return new LvEmployeeNoticeGenerateDeclarationsRequestEndCode(value);
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
        LvEmployeeNoticeGenerateDeclarationsRequestEndCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LvEmployeeNoticeGenerateDeclarationsRequestEndCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LvEmployeeNoticeGenerateDeclarationsRequestEndCode value
    ) => value.Value;

    public static explicit operator LvEmployeeNoticeGenerateDeclarationsRequestEndCode(
        string value
    ) => new(value);

    internal class LvEmployeeNoticeGenerateDeclarationsRequestEndCodeSerializer
        : JsonConverter<LvEmployeeNoticeGenerateDeclarationsRequestEndCode>
    {
        public override LvEmployeeNoticeGenerateDeclarationsRequestEndCode Read(
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
            return new LvEmployeeNoticeGenerateDeclarationsRequestEndCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LvEmployeeNoticeGenerateDeclarationsRequestEndCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LvEmployeeNoticeGenerateDeclarationsRequestEndCode ReadAsPropertyName(
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
            return new LvEmployeeNoticeGenerateDeclarationsRequestEndCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LvEmployeeNoticeGenerateDeclarationsRequestEndCode value,
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
        public const string TwentyOne = "21";

        public const string TwentyTwo = "22";

        public const string TwentyThree = "23";

        public const string TwentyFour = "24";

        public const string TwentyFive = "25";

        public const string TwentySix = "26";
    }
}
