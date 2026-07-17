using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind.PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind Text = new(
        Values.Text
    );

    public static readonly PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind Secret = new(
        Values.Secret
    );

    public static readonly PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind Select = new(
        Values.Select
    );

    public PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind(string value)
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
    public static PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind(value);
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
        PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKindSerializer
        : JsonConverter<PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind>
    {
        public override PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind Read(
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
            return new PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsConfigsListResponseRowsItemFieldsItemKind value,
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
    }
}
