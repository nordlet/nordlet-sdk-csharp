using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesUpdateAccountResponseAccountsKeptBy.CompaniesUpdateAccountResponseAccountsKeptBySerializer)
)]
[Serializable]
public readonly record struct CompaniesUpdateAccountResponseAccountsKeptBy : IStringEnum
{
    public static readonly CompaniesUpdateAccountResponseAccountsKeptBy Company = new(
        Values.Company
    );

    public static readonly CompaniesUpdateAccountResponseAccountsKeptBy External = new(
        Values.External
    );

    public CompaniesUpdateAccountResponseAccountsKeptBy(string value)
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
    public static CompaniesUpdateAccountResponseAccountsKeptBy FromCustom(string value)
    {
        return new CompaniesUpdateAccountResponseAccountsKeptBy(value);
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
        CompaniesUpdateAccountResponseAccountsKeptBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesUpdateAccountResponseAccountsKeptBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesUpdateAccountResponseAccountsKeptBy value) =>
        value.Value;

    public static explicit operator CompaniesUpdateAccountResponseAccountsKeptBy(string value) =>
        new(value);

    internal class CompaniesUpdateAccountResponseAccountsKeptBySerializer
        : JsonConverter<CompaniesUpdateAccountResponseAccountsKeptBy>
    {
        public override CompaniesUpdateAccountResponseAccountsKeptBy Read(
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
            return new CompaniesUpdateAccountResponseAccountsKeptBy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountResponseAccountsKeptBy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesUpdateAccountResponseAccountsKeptBy ReadAsPropertyName(
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
            return new CompaniesUpdateAccountResponseAccountsKeptBy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountResponseAccountsKeptBy value,
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
