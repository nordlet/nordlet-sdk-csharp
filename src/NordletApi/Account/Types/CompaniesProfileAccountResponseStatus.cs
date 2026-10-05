using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesProfileAccountResponseStatus.CompaniesProfileAccountResponseStatusSerializer)
)]
[Serializable]
public readonly record struct CompaniesProfileAccountResponseStatus : IStringEnum
{
    public static readonly CompaniesProfileAccountResponseStatus Active = new(Values.Active);

    public static readonly CompaniesProfileAccountResponseStatus Archived = new(Values.Archived);

    public static readonly CompaniesProfileAccountResponseStatus Deleted = new(Values.Deleted);

    public CompaniesProfileAccountResponseStatus(string value)
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
    public static CompaniesProfileAccountResponseStatus FromCustom(string value)
    {
        return new CompaniesProfileAccountResponseStatus(value);
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

    public static bool operator ==(CompaniesProfileAccountResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CompaniesProfileAccountResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesProfileAccountResponseStatus value) =>
        value.Value;

    public static explicit operator CompaniesProfileAccountResponseStatus(string value) =>
        new(value);

    internal class CompaniesProfileAccountResponseStatusSerializer
        : JsonConverter<CompaniesProfileAccountResponseStatus>
    {
        public override CompaniesProfileAccountResponseStatus Read(
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
            return new CompaniesProfileAccountResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesProfileAccountResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesProfileAccountResponseStatus ReadAsPropertyName(
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
            return new CompaniesProfileAccountResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesProfileAccountResponseStatus value,
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
        public const string Active = "active";

        public const string Archived = "archived";

        public const string Deleted = "deleted";
    }
}
