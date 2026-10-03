using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection.PostV1DeclarationsPlVatUeGenerateResponseRowsItemSectionSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection : IStringEnum
{
    public static readonly PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection C = new(
        Values.C
    );

    public static readonly PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection D = new(
        Values.D
    );

    public static readonly PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection E = new(
        Values.E
    );

    public PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection(string value)
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
    public static PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection FromCustom(string value)
    {
        return new PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection(value);
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
        PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection(
        string value
    ) => new(value);

    internal class PostV1DeclarationsPlVatUeGenerateResponseRowsItemSectionSerializer
        : JsonConverter<PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection>
    {
        public override PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection Read(
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
            return new PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection ReadAsPropertyName(
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
            return new PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsPlVatUeGenerateResponseRowsItemSection value,
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
        public const string C = "C";

        public const string D = "D";

        public const string E = "E";
    }
}
