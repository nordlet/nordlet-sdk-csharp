using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationGroupsGetResponseMembersItemMethod.PostV1ConsolidationGroupsGetResponseMembersItemMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationGroupsGetResponseMembersItemMethod : IStringEnum
{
    public static readonly PostV1ConsolidationGroupsGetResponseMembersItemMethod Full = new(
        Values.Full
    );

    public static readonly PostV1ConsolidationGroupsGetResponseMembersItemMethod Proportional = new(
        Values.Proportional
    );

    public static readonly PostV1ConsolidationGroupsGetResponseMembersItemMethod Equity = new(
        Values.Equity
    );

    public PostV1ConsolidationGroupsGetResponseMembersItemMethod(string value)
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
    public static PostV1ConsolidationGroupsGetResponseMembersItemMethod FromCustom(string value)
    {
        return new PostV1ConsolidationGroupsGetResponseMembersItemMethod(value);
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
        PostV1ConsolidationGroupsGetResponseMembersItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationGroupsGetResponseMembersItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationGroupsGetResponseMembersItemMethod value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationGroupsGetResponseMembersItemMethod(
        string value
    ) => new(value);

    internal class PostV1ConsolidationGroupsGetResponseMembersItemMethodSerializer
        : JsonConverter<PostV1ConsolidationGroupsGetResponseMembersItemMethod>
    {
        public override PostV1ConsolidationGroupsGetResponseMembersItemMethod Read(
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
            return new PostV1ConsolidationGroupsGetResponseMembersItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationGroupsGetResponseMembersItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationGroupsGetResponseMembersItemMethod ReadAsPropertyName(
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
            return new PostV1ConsolidationGroupsGetResponseMembersItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationGroupsGetResponseMembersItemMethod value,
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
        public const string Full = "full";

        public const string Proportional = "proportional";

        public const string Equity = "equity";
    }
}
