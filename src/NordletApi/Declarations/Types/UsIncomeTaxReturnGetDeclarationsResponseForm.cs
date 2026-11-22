using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UsIncomeTaxReturnGetDeclarationsResponseForm.UsIncomeTaxReturnGetDeclarationsResponseFormSerializer)
)]
[Serializable]
public readonly record struct UsIncomeTaxReturnGetDeclarationsResponseForm : IStringEnum
{
    public static readonly UsIncomeTaxReturnGetDeclarationsResponseForm OneThousandSixtyFive = new(
        Values.OneThousandSixtyFive
    );

    public static readonly UsIncomeTaxReturnGetDeclarationsResponseForm OneThousandOneHundredTwenty =
        new(Values.OneThousandOneHundredTwenty);

    public static readonly UsIncomeTaxReturnGetDeclarationsResponseForm OneThousandOneHundredTwentyS =
        new(Values.OneThousandOneHundredTwentyS);

    public UsIncomeTaxReturnGetDeclarationsResponseForm(string value)
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
    public static UsIncomeTaxReturnGetDeclarationsResponseForm FromCustom(string value)
    {
        return new UsIncomeTaxReturnGetDeclarationsResponseForm(value);
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
        UsIncomeTaxReturnGetDeclarationsResponseForm value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UsIncomeTaxReturnGetDeclarationsResponseForm value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UsIncomeTaxReturnGetDeclarationsResponseForm value) =>
        value.Value;

    public static explicit operator UsIncomeTaxReturnGetDeclarationsResponseForm(string value) =>
        new(value);

    internal class UsIncomeTaxReturnGetDeclarationsResponseFormSerializer
        : JsonConverter<UsIncomeTaxReturnGetDeclarationsResponseForm>
    {
        public override UsIncomeTaxReturnGetDeclarationsResponseForm Read(
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
            return new UsIncomeTaxReturnGetDeclarationsResponseForm(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UsIncomeTaxReturnGetDeclarationsResponseForm value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UsIncomeTaxReturnGetDeclarationsResponseForm ReadAsPropertyName(
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
            return new UsIncomeTaxReturnGetDeclarationsResponseForm(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UsIncomeTaxReturnGetDeclarationsResponseForm value,
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
        public const string OneThousandSixtyFive = "1065";

        public const string OneThousandOneHundredTwenty = "1120";

        public const string OneThousandOneHundredTwentyS = "1120-S";
    }
}
