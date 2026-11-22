using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP45GetDeclarationsResponseEmployeeGender.GbP45GetDeclarationsResponseEmployeeGenderSerializer)
)]
[Serializable]
public readonly record struct GbP45GetDeclarationsResponseEmployeeGender : IStringEnum
{
    public static readonly GbP45GetDeclarationsResponseEmployeeGender M = new(Values.M);

    public static readonly GbP45GetDeclarationsResponseEmployeeGender F = new(Values.F);

    public GbP45GetDeclarationsResponseEmployeeGender(string value)
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
    public static GbP45GetDeclarationsResponseEmployeeGender FromCustom(string value)
    {
        return new GbP45GetDeclarationsResponseEmployeeGender(value);
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
        GbP45GetDeclarationsResponseEmployeeGender value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP45GetDeclarationsResponseEmployeeGender value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GbP45GetDeclarationsResponseEmployeeGender value) =>
        value.Value;

    public static explicit operator GbP45GetDeclarationsResponseEmployeeGender(string value) =>
        new(value);

    internal class GbP45GetDeclarationsResponseEmployeeGenderSerializer
        : JsonConverter<GbP45GetDeclarationsResponseEmployeeGender>
    {
        public override GbP45GetDeclarationsResponseEmployeeGender Read(
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
            return new GbP45GetDeclarationsResponseEmployeeGender(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP45GetDeclarationsResponseEmployeeGender value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP45GetDeclarationsResponseEmployeeGender ReadAsPropertyName(
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
            return new GbP45GetDeclarationsResponseEmployeeGender(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP45GetDeclarationsResponseEmployeeGender value,
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
