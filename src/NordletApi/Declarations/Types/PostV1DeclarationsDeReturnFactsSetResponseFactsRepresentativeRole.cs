using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole.PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRoleSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole
    : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole Agent =
        new(Values.Agent);

    public static readonly PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole ReceivingAgent =
        new(Values.ReceivingAgent);

    public PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole(string value)
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
    public static PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole(value);
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
        PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRoleSerializer
        : JsonConverter<PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole>
    {
        public override PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole Read(
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
            return new PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetResponseFactsRepresentativeRole value,
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
        public const string Agent = "agent";

        public const string ReceivingAgent = "receiving_agent";
    }
}
