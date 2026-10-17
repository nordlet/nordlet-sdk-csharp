using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ConfigsUpdateDeclarationsResponseFieldsItemCompanyField.ConfigsUpdateDeclarationsResponseFieldsItemCompanyFieldSerializer)
)]
[Serializable]
public readonly record struct ConfigsUpdateDeclarationsResponseFieldsItemCompanyField : IStringEnum
{
    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemCompanyField Code = new(
        Values.Code
    );

    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemCompanyField VatCode = new(
        Values.VatCode
    );

    public ConfigsUpdateDeclarationsResponseFieldsItemCompanyField(string value)
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
    public static ConfigsUpdateDeclarationsResponseFieldsItemCompanyField FromCustom(string value)
    {
        return new ConfigsUpdateDeclarationsResponseFieldsItemCompanyField(value);
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
        ConfigsUpdateDeclarationsResponseFieldsItemCompanyField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ConfigsUpdateDeclarationsResponseFieldsItemCompanyField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ConfigsUpdateDeclarationsResponseFieldsItemCompanyField value
    ) => value.Value;

    public static explicit operator ConfigsUpdateDeclarationsResponseFieldsItemCompanyField(
        string value
    ) => new(value);

    internal class ConfigsUpdateDeclarationsResponseFieldsItemCompanyFieldSerializer
        : JsonConverter<ConfigsUpdateDeclarationsResponseFieldsItemCompanyField>
    {
        public override ConfigsUpdateDeclarationsResponseFieldsItemCompanyField Read(
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
            return new ConfigsUpdateDeclarationsResponseFieldsItemCompanyField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConfigsUpdateDeclarationsResponseFieldsItemCompanyField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConfigsUpdateDeclarationsResponseFieldsItemCompanyField ReadAsPropertyName(
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
            return new ConfigsUpdateDeclarationsResponseFieldsItemCompanyField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConfigsUpdateDeclarationsResponseFieldsItemCompanyField value,
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
        public const string Code = "code";

        public const string VatCode = "vatCode";
    }
}
