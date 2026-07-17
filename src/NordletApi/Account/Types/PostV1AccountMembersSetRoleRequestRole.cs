using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountMembersSetRoleRequestRole.PostV1AccountMembersSetRoleRequestRoleSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountMembersSetRoleRequestRole : IStringEnum
{
    public static readonly PostV1AccountMembersSetRoleRequestRole Admin = new(Values.Admin);

    public static readonly PostV1AccountMembersSetRoleRequestRole Accountant = new(
        Values.Accountant
    );

    public static readonly PostV1AccountMembersSetRoleRequestRole Manager = new(Values.Manager);

    public static readonly PostV1AccountMembersSetRoleRequestRole Developer = new(Values.Developer);

    public static readonly PostV1AccountMembersSetRoleRequestRole Viewer = new(Values.Viewer);

    public PostV1AccountMembersSetRoleRequestRole(string value)
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
    public static PostV1AccountMembersSetRoleRequestRole FromCustom(string value)
    {
        return new PostV1AccountMembersSetRoleRequestRole(value);
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

    public static bool operator ==(PostV1AccountMembersSetRoleRequestRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AccountMembersSetRoleRequestRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountMembersSetRoleRequestRole value) =>
        value.Value;

    public static explicit operator PostV1AccountMembersSetRoleRequestRole(string value) =>
        new(value);

    internal class PostV1AccountMembersSetRoleRequestRoleSerializer
        : JsonConverter<PostV1AccountMembersSetRoleRequestRole>
    {
        public override PostV1AccountMembersSetRoleRequestRole Read(
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
            return new PostV1AccountMembersSetRoleRequestRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountMembersSetRoleRequestRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountMembersSetRoleRequestRole ReadAsPropertyName(
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
            return new PostV1AccountMembersSetRoleRequestRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountMembersSetRoleRequestRole value,
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
        public const string Admin = "admin";

        public const string Accountant = "accountant";

        public const string Manager = "manager";

        public const string Developer = "developer";

        public const string Viewer = "viewer";
    }
}
