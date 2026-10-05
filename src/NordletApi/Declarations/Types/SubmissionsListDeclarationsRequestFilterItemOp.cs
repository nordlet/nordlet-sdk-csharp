using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsListDeclarationsRequestFilterItemOp.SubmissionsListDeclarationsRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct SubmissionsListDeclarationsRequestFilterItemOp : IStringEnum
{
    public static readonly SubmissionsListDeclarationsRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly SubmissionsListDeclarationsRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly SubmissionsListDeclarationsRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly SubmissionsListDeclarationsRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly SubmissionsListDeclarationsRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly SubmissionsListDeclarationsRequestFilterItemOp In = new(Values.In);

    public SubmissionsListDeclarationsRequestFilterItemOp(string value)
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
    public static SubmissionsListDeclarationsRequestFilterItemOp FromCustom(string value)
    {
        return new SubmissionsListDeclarationsRequestFilterItemOp(value);
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
        SubmissionsListDeclarationsRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsListDeclarationsRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsListDeclarationsRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator SubmissionsListDeclarationsRequestFilterItemOp(string value) =>
        new(value);

    internal class SubmissionsListDeclarationsRequestFilterItemOpSerializer
        : JsonConverter<SubmissionsListDeclarationsRequestFilterItemOp>
    {
        public override SubmissionsListDeclarationsRequestFilterItemOp Read(
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
            return new SubmissionsListDeclarationsRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsListDeclarationsRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsListDeclarationsRequestFilterItemOp ReadAsPropertyName(
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
            return new SubmissionsListDeclarationsRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsListDeclarationsRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
