using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesContextAccountResponseProfileAccountsKeptBy.CompaniesContextAccountResponseProfileAccountsKeptBySerializer)
)]
[Serializable]
public readonly record struct CompaniesContextAccountResponseProfileAccountsKeptBy : IStringEnum
{
    public static readonly CompaniesContextAccountResponseProfileAccountsKeptBy Company = new(
        Values.Company
    );

    public static readonly CompaniesContextAccountResponseProfileAccountsKeptBy External = new(
        Values.External
    );

    public CompaniesContextAccountResponseProfileAccountsKeptBy(string value)
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
    public static CompaniesContextAccountResponseProfileAccountsKeptBy FromCustom(string value)
    {
        return new CompaniesContextAccountResponseProfileAccountsKeptBy(value);
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
        CompaniesContextAccountResponseProfileAccountsKeptBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesContextAccountResponseProfileAccountsKeptBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CompaniesContextAccountResponseProfileAccountsKeptBy value
    ) => value.Value;

    public static explicit operator CompaniesContextAccountResponseProfileAccountsKeptBy(
        string value
    ) => new(value);

    internal class CompaniesContextAccountResponseProfileAccountsKeptBySerializer
        : JsonConverter<CompaniesContextAccountResponseProfileAccountsKeptBy>
    {
        public override CompaniesContextAccountResponseProfileAccountsKeptBy Read(
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
            return new CompaniesContextAccountResponseProfileAccountsKeptBy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileAccountsKeptBy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesContextAccountResponseProfileAccountsKeptBy ReadAsPropertyName(
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
            return new CompaniesContextAccountResponseProfileAccountsKeptBy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileAccountsKeptBy value,
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
        public const string Company = "company";

        public const string External = "external";
    }
}
