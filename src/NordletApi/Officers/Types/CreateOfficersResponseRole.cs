using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(CreateOfficersResponseRole.CreateOfficersResponseRoleSerializer))]
[Serializable]
public readonly record struct CreateOfficersResponseRole : IStringEnum
{
    public static readonly CreateOfficersResponseRole Director = new(Values.Director);

    public static readonly CreateOfficersResponseRole ManagingDirector = new(
        Values.ManagingDirector
    );

    public static readonly CreateOfficersResponseRole BoardMember = new(Values.BoardMember);

    public static readonly CreateOfficersResponseRole BoardChair = new(Values.BoardChair);

    public static readonly CreateOfficersResponseRole SupervisoryBoardMember = new(
        Values.SupervisoryBoardMember
    );

    public static readonly CreateOfficersResponseRole Secretary = new(Values.Secretary);

    public static readonly CreateOfficersResponseRole Representative = new(Values.Representative);

    public static readonly CreateOfficersResponseRole Liquidator = new(Values.Liquidator);

    public CreateOfficersResponseRole(string value)
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
    public static CreateOfficersResponseRole FromCustom(string value)
    {
        return new CreateOfficersResponseRole(value);
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

    public static bool operator ==(CreateOfficersResponseRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateOfficersResponseRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateOfficersResponseRole value) => value.Value;

    public static explicit operator CreateOfficersResponseRole(string value) => new(value);

    internal class CreateOfficersResponseRoleSerializer : JsonConverter<CreateOfficersResponseRole>
    {
        public override CreateOfficersResponseRole Read(
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
            return new CreateOfficersResponseRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateOfficersResponseRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateOfficersResponseRole ReadAsPropertyName(
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
            return new CreateOfficersResponseRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateOfficersResponseRole value,
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
