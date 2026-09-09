using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale.PostV1PartnersDebtRemindersPreviewResponseRowsItemLocaleSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale : IStringEnum
{
    public static readonly PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale Lt = new(
        Values.Lt
    );

    public static readonly PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale En = new(
        Values.En
    );

    public static readonly PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale Ru = new(
        Values.Ru
    );

    public PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale(string value)
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
    public static PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale FromCustom(string value)
    {
        return new PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale(value);
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
        PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale value
    ) => value.Value;

    public static explicit operator PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale(
        string value
    ) => new(value);

    internal class PostV1PartnersDebtRemindersPreviewResponseRowsItemLocaleSerializer
        : JsonConverter<PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale>
    {
        public override PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale Read(
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
            return new PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale ReadAsPropertyName(
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
            return new PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersDebtRemindersPreviewResponseRowsItemLocale value,
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
        public const string Lt = "lt";

        public const string En = "en";

        public const string Ru = "ru";
    }
}
