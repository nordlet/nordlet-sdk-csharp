using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ConfigsListDeclarationsResponseRowsItemFieldsItemKind.ConfigsListDeclarationsResponseRowsItemFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct ConfigsListDeclarationsResponseRowsItemFieldsItemKind : IStringEnum
{
    public static readonly ConfigsListDeclarationsResponseRowsItemFieldsItemKind Text = new(
        Values.Text
    );

    public static readonly ConfigsListDeclarationsResponseRowsItemFieldsItemKind Secret = new(
        Values.Secret
    );

    public static readonly ConfigsListDeclarationsResponseRowsItemFieldsItemKind Select = new(
        Values.Select
    );

    public static readonly ConfigsListDeclarationsResponseRowsItemFieldsItemKind Url = new(
        Values.Url
    );

    public static readonly ConfigsListDeclarationsResponseRowsItemFieldsItemKind Certificate = new(
        Values.Certificate
    );

    public ConfigsListDeclarationsResponseRowsItemFieldsItemKind(string value)
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
    public static ConfigsListDeclarationsResponseRowsItemFieldsItemKind FromCustom(string value)
    {
        return new ConfigsListDeclarationsResponseRowsItemFieldsItemKind(value);
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
        ConfigsListDeclarationsResponseRowsItemFieldsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ConfigsListDeclarationsResponseRowsItemFieldsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ConfigsListDeclarationsResponseRowsItemFieldsItemKind value
    ) => value.Value;

    public static explicit operator ConfigsListDeclarationsResponseRowsItemFieldsItemKind(
        string value
    ) => new(value);

    internal class ConfigsListDeclarationsResponseRowsItemFieldsItemKindSerializer
        : JsonConverter<ConfigsListDeclarationsResponseRowsItemFieldsItemKind>
    {
        public override ConfigsListDeclarationsResponseRowsItemFieldsItemKind Read(
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
            return new ConfigsListDeclarationsResponseRowsItemFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConfigsListDeclarationsResponseRowsItemFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConfigsListDeclarationsResponseRowsItemFieldsItemKind ReadAsPropertyName(
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
            return new ConfigsListDeclarationsResponseRowsItemFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConfigsListDeclarationsResponseRowsItemFieldsItemKind value,
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
        public const string Text = "text";

        public const string Secret = "secret";

        public const string Select = "select";

        public const string Url = "url";

        public const string Certificate = "certificate";
    }
}
