using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesContextAccountResponseFilingsItemMissingSettingsOperation.CompaniesContextAccountResponseFilingsItemMissingSettingsOperationSerializer)
)]
[Serializable]
public readonly record struct CompaniesContextAccountResponseFilingsItemMissingSettingsOperation
    : IStringEnum
{
    public static readonly CompaniesContextAccountResponseFilingsItemMissingSettingsOperation DeclarationsConfigsUpdate =
        new(Values.DeclarationsConfigsUpdate);

    public CompaniesContextAccountResponseFilingsItemMissingSettingsOperation(string value)
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
    public static CompaniesContextAccountResponseFilingsItemMissingSettingsOperation FromCustom(
        string value
    )
    {
        return new CompaniesContextAccountResponseFilingsItemMissingSettingsOperation(value);
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
        CompaniesContextAccountResponseFilingsItemMissingSettingsOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesContextAccountResponseFilingsItemMissingSettingsOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CompaniesContextAccountResponseFilingsItemMissingSettingsOperation value
    ) => value.Value;

    public static explicit operator CompaniesContextAccountResponseFilingsItemMissingSettingsOperation(
        string value
    ) => new(value);

    internal class CompaniesContextAccountResponseFilingsItemMissingSettingsOperationSerializer
        : JsonConverter<CompaniesContextAccountResponseFilingsItemMissingSettingsOperation>
    {
        public override CompaniesContextAccountResponseFilingsItemMissingSettingsOperation Read(
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
            return new CompaniesContextAccountResponseFilingsItemMissingSettingsOperation(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseFilingsItemMissingSettingsOperation value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesContextAccountResponseFilingsItemMissingSettingsOperation ReadAsPropertyName(
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
            return new CompaniesContextAccountResponseFilingsItemMissingSettingsOperation(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseFilingsItemMissingSettingsOperation value,
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
        public const string DeclarationsConfigsUpdate = "declarations/configs/update";
    }
}
