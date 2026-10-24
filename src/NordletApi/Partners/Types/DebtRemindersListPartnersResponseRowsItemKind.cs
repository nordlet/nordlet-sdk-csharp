using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DebtRemindersListPartnersResponseRowsItemKind.DebtRemindersListPartnersResponseRowsItemKindSerializer)
)]
[Serializable]
public readonly record struct DebtRemindersListPartnersResponseRowsItemKind : IStringEnum
{
    public static readonly DebtRemindersListPartnersResponseRowsItemKind BeforeDue = new(
        Values.BeforeDue
    );

    public static readonly DebtRemindersListPartnersResponseRowsItemKind Overdue = new(
        Values.Overdue
    );

    public DebtRemindersListPartnersResponseRowsItemKind(string value)
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
    public static DebtRemindersListPartnersResponseRowsItemKind FromCustom(string value)
    {
        return new DebtRemindersListPartnersResponseRowsItemKind(value);
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
        DebtRemindersListPartnersResponseRowsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DebtRemindersListPartnersResponseRowsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DebtRemindersListPartnersResponseRowsItemKind value) =>
        value.Value;

    public static explicit operator DebtRemindersListPartnersResponseRowsItemKind(string value) =>
        new(value);

    internal class DebtRemindersListPartnersResponseRowsItemKindSerializer
        : JsonConverter<DebtRemindersListPartnersResponseRowsItemKind>
    {
        public override DebtRemindersListPartnersResponseRowsItemKind Read(
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
            return new DebtRemindersListPartnersResponseRowsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DebtRemindersListPartnersResponseRowsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DebtRemindersListPartnersResponseRowsItemKind ReadAsPropertyName(
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
            return new DebtRemindersListPartnersResponseRowsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DebtRemindersListPartnersResponseRowsItemKind value,
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
        public const string BeforeDue = "before_due";

        public const string Overdue = "overdue";
    }
}
