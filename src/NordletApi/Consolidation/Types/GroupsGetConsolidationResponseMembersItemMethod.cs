using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GroupsGetConsolidationResponseMembersItemMethod.GroupsGetConsolidationResponseMembersItemMethodSerializer)
)]
[Serializable]
public readonly record struct GroupsGetConsolidationResponseMembersItemMethod : IStringEnum
{
    public static readonly GroupsGetConsolidationResponseMembersItemMethod Full = new(Values.Full);

    public static readonly GroupsGetConsolidationResponseMembersItemMethod Proportional = new(
        Values.Proportional
    );

    public static readonly GroupsGetConsolidationResponseMembersItemMethod Equity = new(
        Values.Equity
    );

    public GroupsGetConsolidationResponseMembersItemMethod(string value)
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
    public static GroupsGetConsolidationResponseMembersItemMethod FromCustom(string value)
    {
        return new GroupsGetConsolidationResponseMembersItemMethod(value);
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
        GroupsGetConsolidationResponseMembersItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GroupsGetConsolidationResponseMembersItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GroupsGetConsolidationResponseMembersItemMethod value) =>
        value.Value;

    public static explicit operator GroupsGetConsolidationResponseMembersItemMethod(string value) =>
        new(value);

    internal class GroupsGetConsolidationResponseMembersItemMethodSerializer
        : JsonConverter<GroupsGetConsolidationResponseMembersItemMethod>
    {
        public override GroupsGetConsolidationResponseMembersItemMethod Read(
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
            return new GroupsGetConsolidationResponseMembersItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GroupsGetConsolidationResponseMembersItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GroupsGetConsolidationResponseMembersItemMethod ReadAsPropertyName(
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
            return new GroupsGetConsolidationResponseMembersItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GroupsGetConsolidationResponseMembersItemMethod value,
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
