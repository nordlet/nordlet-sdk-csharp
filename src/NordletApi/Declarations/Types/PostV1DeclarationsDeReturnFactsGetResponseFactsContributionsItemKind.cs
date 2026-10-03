using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind.PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind Cash =
        new(Values.Cash);

    public static readonly PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind InKind =
        new(Values.InKind);

    public PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind(string value)
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
    public static PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind(value);
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
        PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKindSerializer
        : JsonConverter<PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind>
    {
        public override PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind Read(
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
            return new PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsGetResponseFactsContributionsItemKind value,
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
        public const string Cash = "cash";

        public const string InKind = "in_kind";
    }
}
