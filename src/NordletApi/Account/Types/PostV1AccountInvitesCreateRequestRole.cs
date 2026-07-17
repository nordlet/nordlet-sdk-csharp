using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountInvitesCreateRequestRole.PostV1AccountInvitesCreateRequestRoleSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountInvitesCreateRequestRole : IStringEnum
{
    public static readonly PostV1AccountInvitesCreateRequestRole Admin = new(Values.Admin);

    public static readonly PostV1AccountInvitesCreateRequestRole Accountant = new(
        Values.Accountant
    );

    public static readonly PostV1AccountInvitesCreateRequestRole Manager = new(Values.Manager);

    public static readonly PostV1AccountInvitesCreateRequestRole Developer = new(Values.Developer);

    public static readonly PostV1AccountInvitesCreateRequestRole Viewer = new(Values.Viewer);

    public PostV1AccountInvitesCreateRequestRole(string value)
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
    public static PostV1AccountInvitesCreateRequestRole FromCustom(string value)
    {
        return new PostV1AccountInvitesCreateRequestRole(value);
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

    public static bool operator ==(PostV1AccountInvitesCreateRequestRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AccountInvitesCreateRequestRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountInvitesCreateRequestRole value) =>
        value.Value;

    public static explicit operator PostV1AccountInvitesCreateRequestRole(string value) =>
        new(value);

    internal class PostV1AccountInvitesCreateRequestRoleSerializer
        : JsonConverter<PostV1AccountInvitesCreateRequestRole>
    {
        public override PostV1AccountInvitesCreateRequestRole Read(
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
            return new PostV1AccountInvitesCreateRequestRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountInvitesCreateRequestRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountInvitesCreateRequestRole ReadAsPropertyName(
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
            return new PostV1AccountInvitesCreateRequestRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountInvitesCreateRequestRole value,
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
