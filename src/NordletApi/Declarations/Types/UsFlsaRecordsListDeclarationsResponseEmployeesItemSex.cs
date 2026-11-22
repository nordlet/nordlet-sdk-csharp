using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UsFlsaRecordsListDeclarationsResponseEmployeesItemSex.UsFlsaRecordsListDeclarationsResponseEmployeesItemSexSerializer)
)]
[Serializable]
public readonly record struct UsFlsaRecordsListDeclarationsResponseEmployeesItemSex : IStringEnum
{
    public static readonly UsFlsaRecordsListDeclarationsResponseEmployeesItemSex M = new(Values.M);

    public static readonly UsFlsaRecordsListDeclarationsResponseEmployeesItemSex F = new(Values.F);

    public UsFlsaRecordsListDeclarationsResponseEmployeesItemSex(string value)
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
    public static UsFlsaRecordsListDeclarationsResponseEmployeesItemSex FromCustom(string value)
    {
        return new UsFlsaRecordsListDeclarationsResponseEmployeesItemSex(value);
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
        UsFlsaRecordsListDeclarationsResponseEmployeesItemSex value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UsFlsaRecordsListDeclarationsResponseEmployeesItemSex value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UsFlsaRecordsListDeclarationsResponseEmployeesItemSex value
    ) => value.Value;

    public static explicit operator UsFlsaRecordsListDeclarationsResponseEmployeesItemSex(
        string value
    ) => new(value);

    internal class UsFlsaRecordsListDeclarationsResponseEmployeesItemSexSerializer
        : JsonConverter<UsFlsaRecordsListDeclarationsResponseEmployeesItemSex>
    {
        public override UsFlsaRecordsListDeclarationsResponseEmployeesItemSex Read(
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
            return new UsFlsaRecordsListDeclarationsResponseEmployeesItemSex(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UsFlsaRecordsListDeclarationsResponseEmployeesItemSex value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UsFlsaRecordsListDeclarationsResponseEmployeesItemSex ReadAsPropertyName(
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
            return new UsFlsaRecordsListDeclarationsResponseEmployeesItemSex(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UsFlsaRecordsListDeclarationsResponseEmployeesItemSex value,
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
        public const string M = "M";

        public const string F = "F";
    }
}
