using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrEmployeesFieldsResponseFieldsItemKind.PostV1HrEmployeesFieldsResponseFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1HrEmployeesFieldsResponseFieldsItemKind : IStringEnum
{
    public static readonly PostV1HrEmployeesFieldsResponseFieldsItemKind Text = new(Values.Text);

    public static readonly PostV1HrEmployeesFieldsResponseFieldsItemKind Select = new(
        Values.Select
    );

    public static readonly PostV1HrEmployeesFieldsResponseFieldsItemKind Date = new(Values.Date);

    public PostV1HrEmployeesFieldsResponseFieldsItemKind(string value)
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
    public static PostV1HrEmployeesFieldsResponseFieldsItemKind FromCustom(string value)
    {
        return new PostV1HrEmployeesFieldsResponseFieldsItemKind(value);
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
        PostV1HrEmployeesFieldsResponseFieldsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrEmployeesFieldsResponseFieldsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrEmployeesFieldsResponseFieldsItemKind value) =>
        value.Value;

    public static explicit operator PostV1HrEmployeesFieldsResponseFieldsItemKind(string value) =>
        new(value);

    internal class PostV1HrEmployeesFieldsResponseFieldsItemKindSerializer
        : JsonConverter<PostV1HrEmployeesFieldsResponseFieldsItemKind>
    {
        public override PostV1HrEmployeesFieldsResponseFieldsItemKind Read(
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
            return new PostV1HrEmployeesFieldsResponseFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrEmployeesFieldsResponseFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrEmployeesFieldsResponseFieldsItemKind ReadAsPropertyName(
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
            return new PostV1HrEmployeesFieldsResponseFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrEmployeesFieldsResponseFieldsItemKind value,
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
        public const string Text = "text";

        public const string Select = "select";

        public const string Date = "date";
    }
}
