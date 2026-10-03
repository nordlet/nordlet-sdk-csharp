using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1OfficersUpdateRequestRole.PostV1OfficersUpdateRequestRoleSerializer))]
[Serializable]
public readonly record struct PostV1OfficersUpdateRequestRole : IStringEnum
{
    public static readonly PostV1OfficersUpdateRequestRole Director = new(Values.Director);

    public static readonly PostV1OfficersUpdateRequestRole ManagingDirector = new(
        Values.ManagingDirector
    );

    public static readonly PostV1OfficersUpdateRequestRole BoardMember = new(Values.BoardMember);

    public static readonly PostV1OfficersUpdateRequestRole BoardChair = new(Values.BoardChair);

    public static readonly PostV1OfficersUpdateRequestRole SupervisoryBoardMember = new(
        Values.SupervisoryBoardMember
    );

    public static readonly PostV1OfficersUpdateRequestRole Secretary = new(Values.Secretary);

    public static readonly PostV1OfficersUpdateRequestRole Representative = new(
        Values.Representative
    );

    public static readonly PostV1OfficersUpdateRequestRole Liquidator = new(Values.Liquidator);

    public PostV1OfficersUpdateRequestRole(string value)
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
    public static PostV1OfficersUpdateRequestRole FromCustom(string value)
    {
        return new PostV1OfficersUpdateRequestRole(value);
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

    public static bool operator ==(PostV1OfficersUpdateRequestRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1OfficersUpdateRequestRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1OfficersUpdateRequestRole value) => value.Value;

    public static explicit operator PostV1OfficersUpdateRequestRole(string value) => new(value);

    internal class PostV1OfficersUpdateRequestRoleSerializer
        : JsonConverter<PostV1OfficersUpdateRequestRole>
    {
        public override PostV1OfficersUpdateRequestRole Read(
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
            return new PostV1OfficersUpdateRequestRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1OfficersUpdateRequestRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1OfficersUpdateRequestRole ReadAsPropertyName(
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
            return new PostV1OfficersUpdateRequestRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1OfficersUpdateRequestRole value,
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
        public const string Director = "director";

        public const string ManagingDirector = "managing_director";

        public const string BoardMember = "board_member";

        public const string BoardChair = "board_chair";

        public const string SupervisoryBoardMember = "supervisory_board_member";

        public const string Secretary = "secretary";

        public const string Representative = "representative";

        public const string Liquidator = "liquidator";
    }
}
