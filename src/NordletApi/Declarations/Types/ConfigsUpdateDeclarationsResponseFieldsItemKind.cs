using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ConfigsUpdateDeclarationsResponseFieldsItemKind.ConfigsUpdateDeclarationsResponseFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct ConfigsUpdateDeclarationsResponseFieldsItemKind : IStringEnum
{
    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemKind Text = new(Values.Text);

    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemKind Secret = new(
        Values.Secret
    );

    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemKind Select = new(
        Values.Select
    );

    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemKind Url = new(Values.Url);

    public static readonly ConfigsUpdateDeclarationsResponseFieldsItemKind Certificate = new(
        Values.Certificate
    );

    public ConfigsUpdateDeclarationsResponseFieldsItemKind(string value)
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
    public static ConfigsUpdateDeclarationsResponseFieldsItemKind FromCustom(string value)
    {
        return new ConfigsUpdateDeclarationsResponseFieldsItemKind(value);
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
        ConfigsUpdateDeclarationsResponseFieldsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ConfigsUpdateDeclarationsResponseFieldsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ConfigsUpdateDeclarationsResponseFieldsItemKind value) =>
        value.Value;

    public static explicit operator ConfigsUpdateDeclarationsResponseFieldsItemKind(string value) =>
        new(value);

    internal class ConfigsUpdateDeclarationsResponseFieldsItemKindSerializer
        : JsonConverter<ConfigsUpdateDeclarationsResponseFieldsItemKind>
    {
        public override ConfigsUpdateDeclarationsResponseFieldsItemKind Read(
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
            return new ConfigsUpdateDeclarationsResponseFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConfigsUpdateDeclarationsResponseFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConfigsUpdateDeclarationsResponseFieldsItemKind ReadAsPropertyName(
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
            return new ConfigsUpdateDeclarationsResponseFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConfigsUpdateDeclarationsResponseFieldsItemKind value,
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
