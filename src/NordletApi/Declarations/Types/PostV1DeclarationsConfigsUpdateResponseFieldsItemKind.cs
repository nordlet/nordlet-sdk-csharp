using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsConfigsUpdateResponseFieldsItemKind.PostV1DeclarationsConfigsUpdateResponseFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsConfigsUpdateResponseFieldsItemKind : IStringEnum
{
    public static readonly PostV1DeclarationsConfigsUpdateResponseFieldsItemKind Text = new(
        Values.Text
    );

    public static readonly PostV1DeclarationsConfigsUpdateResponseFieldsItemKind Secret = new(
        Values.Secret
    );

    public static readonly PostV1DeclarationsConfigsUpdateResponseFieldsItemKind Select = new(
        Values.Select
    );

    public PostV1DeclarationsConfigsUpdateResponseFieldsItemKind(string value)
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
    public static PostV1DeclarationsConfigsUpdateResponseFieldsItemKind FromCustom(string value)
    {
        return new PostV1DeclarationsConfigsUpdateResponseFieldsItemKind(value);
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
        PostV1DeclarationsConfigsUpdateResponseFieldsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsConfigsUpdateResponseFieldsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsConfigsUpdateResponseFieldsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsConfigsUpdateResponseFieldsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsConfigsUpdateResponseFieldsItemKindSerializer
        : JsonConverter<PostV1DeclarationsConfigsUpdateResponseFieldsItemKind>
    {
        public override PostV1DeclarationsConfigsUpdateResponseFieldsItemKind Read(
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
            return new PostV1DeclarationsConfigsUpdateResponseFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsConfigsUpdateResponseFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsConfigsUpdateResponseFieldsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsConfigsUpdateResponseFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsConfigsUpdateResponseFieldsItemKind value,
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
