using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MembersSetRoleAccountRequestRole.MembersSetRoleAccountRequestRoleSerializer))]
[Serializable]
public readonly record struct MembersSetRoleAccountRequestRole : IStringEnum
{
    public static readonly MembersSetRoleAccountRequestRole Admin = new(Values.Admin);

    public static readonly MembersSetRoleAccountRequestRole Accountant = new(Values.Accountant);

    public static readonly MembersSetRoleAccountRequestRole Manager = new(Values.Manager);

    public static readonly MembersSetRoleAccountRequestRole Developer = new(Values.Developer);

    public static readonly MembersSetRoleAccountRequestRole Viewer = new(Values.Viewer);

    public MembersSetRoleAccountRequestRole(string value)
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
    public static MembersSetRoleAccountRequestRole FromCustom(string value)
    {
        return new MembersSetRoleAccountRequestRole(value);
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

    public static bool operator ==(MembersSetRoleAccountRequestRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MembersSetRoleAccountRequestRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MembersSetRoleAccountRequestRole value) => value.Value;

    public static explicit operator MembersSetRoleAccountRequestRole(string value) => new(value);

    internal class MembersSetRoleAccountRequestRoleSerializer
        : JsonConverter<MembersSetRoleAccountRequestRole>
    {
        public override MembersSetRoleAccountRequestRole Read(
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
            return new MembersSetRoleAccountRequestRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MembersSetRoleAccountRequestRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MembersSetRoleAccountRequestRole ReadAsPropertyName(
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
            return new MembersSetRoleAccountRequestRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MembersSetRoleAccountRequestRole value,
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
