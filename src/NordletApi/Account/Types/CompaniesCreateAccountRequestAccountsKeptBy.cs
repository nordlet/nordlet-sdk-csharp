using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesCreateAccountRequestAccountsKeptBy.CompaniesCreateAccountRequestAccountsKeptBySerializer)
)]
[Serializable]
public readonly record struct CompaniesCreateAccountRequestAccountsKeptBy : IStringEnum
{
    public static readonly CompaniesCreateAccountRequestAccountsKeptBy Company = new(
        Values.Company
    );

    public static readonly CompaniesCreateAccountRequestAccountsKeptBy External = new(
        Values.External
    );

    public CompaniesCreateAccountRequestAccountsKeptBy(string value)
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
    public static CompaniesCreateAccountRequestAccountsKeptBy FromCustom(string value)
    {
        return new CompaniesCreateAccountRequestAccountsKeptBy(value);
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
        CompaniesCreateAccountRequestAccountsKeptBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesCreateAccountRequestAccountsKeptBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesCreateAccountRequestAccountsKeptBy value) =>
        value.Value;

    public static explicit operator CompaniesCreateAccountRequestAccountsKeptBy(string value) =>
        new(value);

    internal class CompaniesCreateAccountRequestAccountsKeptBySerializer
        : JsonConverter<CompaniesCreateAccountRequestAccountsKeptBy>
    {
        public override CompaniesCreateAccountRequestAccountsKeptBy Read(
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
            return new CompaniesCreateAccountRequestAccountsKeptBy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestAccountsKeptBy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesCreateAccountRequestAccountsKeptBy ReadAsPropertyName(
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
            return new CompaniesCreateAccountRequestAccountsKeptBy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestAccountsKeptBy value,
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
