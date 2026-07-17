using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationMembersAddRequestMethod.PostV1ConsolidationMembersAddRequestMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationMembersAddRequestMethod : IStringEnum
{
    public static readonly PostV1ConsolidationMembersAddRequestMethod Full = new(Values.Full);

    public static readonly PostV1ConsolidationMembersAddRequestMethod Proportional = new(
        Values.Proportional
    );

    public static readonly PostV1ConsolidationMembersAddRequestMethod Equity = new(Values.Equity);

    public PostV1ConsolidationMembersAddRequestMethod(string value)
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
    public static PostV1ConsolidationMembersAddRequestMethod FromCustom(string value)
    {
        return new PostV1ConsolidationMembersAddRequestMethod(value);
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
        PostV1ConsolidationMembersAddRequestMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationMembersAddRequestMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ConsolidationMembersAddRequestMethod value) =>
        value.Value;

    public static explicit operator PostV1ConsolidationMembersAddRequestMethod(string value) =>
        new(value);

    internal class PostV1ConsolidationMembersAddRequestMethodSerializer
        : JsonConverter<PostV1ConsolidationMembersAddRequestMethod>
    {
        public override PostV1ConsolidationMembersAddRequestMethod Read(
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
            return new PostV1ConsolidationMembersAddRequestMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationMembersAddRequestMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationMembersAddRequestMethod ReadAsPropertyName(
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
            return new PostV1ConsolidationMembersAddRequestMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationMembersAddRequestMethod value,
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
