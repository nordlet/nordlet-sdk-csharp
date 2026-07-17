using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationMembersAddResponseMethod.PostV1ConsolidationMembersAddResponseMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationMembersAddResponseMethod : IStringEnum
{
    public static readonly PostV1ConsolidationMembersAddResponseMethod Full = new(Values.Full);

    public static readonly PostV1ConsolidationMembersAddResponseMethod Proportional = new(
        Values.Proportional
    );

    public static readonly PostV1ConsolidationMembersAddResponseMethod Equity = new(Values.Equity);

    public PostV1ConsolidationMembersAddResponseMethod(string value)
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
    public static PostV1ConsolidationMembersAddResponseMethod FromCustom(string value)
    {
        return new PostV1ConsolidationMembersAddResponseMethod(value);
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
        PostV1ConsolidationMembersAddResponseMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationMembersAddResponseMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ConsolidationMembersAddResponseMethod value) =>
        value.Value;

    public static explicit operator PostV1ConsolidationMembersAddResponseMethod(string value) =>
        new(value);

    internal class PostV1ConsolidationMembersAddResponseMethodSerializer
        : JsonConverter<PostV1ConsolidationMembersAddResponseMethod>
    {
        public override PostV1ConsolidationMembersAddResponseMethod Read(
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
            return new PostV1ConsolidationMembersAddResponseMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationMembersAddResponseMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationMembersAddResponseMethod ReadAsPropertyName(
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
            return new PostV1ConsolidationMembersAddResponseMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationMembersAddResponseMethod value,
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
