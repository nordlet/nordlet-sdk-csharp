using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesContextAccountResponseProfileStatus.CompaniesContextAccountResponseProfileStatusSerializer)
)]
[Serializable]
public readonly record struct CompaniesContextAccountResponseProfileStatus : IStringEnum
{
    public static readonly CompaniesContextAccountResponseProfileStatus Active = new(Values.Active);

    public static readonly CompaniesContextAccountResponseProfileStatus Archived = new(
        Values.Archived
    );

    public static readonly CompaniesContextAccountResponseProfileStatus Deleted = new(
        Values.Deleted
    );

    public CompaniesContextAccountResponseProfileStatus(string value)
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
    public static CompaniesContextAccountResponseProfileStatus FromCustom(string value)
    {
        return new CompaniesContextAccountResponseProfileStatus(value);
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
        CompaniesContextAccountResponseProfileStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesContextAccountResponseProfileStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesContextAccountResponseProfileStatus value) =>
        value.Value;

    public static explicit operator CompaniesContextAccountResponseProfileStatus(string value) =>
        new(value);

    internal class CompaniesContextAccountResponseProfileStatusSerializer
        : JsonConverter<CompaniesContextAccountResponseProfileStatus>
    {
        public override CompaniesContextAccountResponseProfileStatus Read(
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
            return new CompaniesContextAccountResponseProfileStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesContextAccountResponseProfileStatus ReadAsPropertyName(
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
            return new CompaniesContextAccountResponseProfileStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileStatus value,
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
