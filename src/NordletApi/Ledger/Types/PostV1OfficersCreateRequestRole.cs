using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1OfficersCreateRequestRole.PostV1OfficersCreateRequestRoleSerializer))]
[Serializable]
public readonly record struct PostV1OfficersCreateRequestRole : IStringEnum
{
    public static readonly PostV1OfficersCreateRequestRole Director = new(Values.Director);

    public static readonly PostV1OfficersCreateRequestRole ManagingDirector = new(
        Values.ManagingDirector
    );

    public static readonly PostV1OfficersCreateRequestRole BoardMember = new(Values.BoardMember);

    public static readonly PostV1OfficersCreateRequestRole BoardChair = new(Values.BoardChair);

    public static readonly PostV1OfficersCreateRequestRole SupervisoryBoardMember = new(
        Values.SupervisoryBoardMember
    );

    public static readonly PostV1OfficersCreateRequestRole Secretary = new(Values.Secretary);

    public static readonly PostV1OfficersCreateRequestRole Representative = new(
        Values.Representative
    );

    public static readonly PostV1OfficersCreateRequestRole Liquidator = new(Values.Liquidator);

    public PostV1OfficersCreateRequestRole(string value)
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
    public static PostV1OfficersCreateRequestRole FromCustom(string value)
    {
        return new PostV1OfficersCreateRequestRole(value);
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

    public static bool operator ==(PostV1OfficersCreateRequestRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1OfficersCreateRequestRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1OfficersCreateRequestRole value) => value.Value;

    public static explicit operator PostV1OfficersCreateRequestRole(string value) => new(value);

    internal class PostV1OfficersCreateRequestRoleSerializer
        : JsonConverter<PostV1OfficersCreateRequestRole>
    {
        public override PostV1OfficersCreateRequestRole Read(
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
            return new PostV1OfficersCreateRequestRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1OfficersCreateRequestRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1OfficersCreateRequestRole ReadAsPropertyName(
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
            return new PostV1OfficersCreateRequestRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1OfficersCreateRequestRole value,
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
