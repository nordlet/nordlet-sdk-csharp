using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReceiptsListPosRequestFilterItemOp.ReceiptsListPosRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct ReceiptsListPosRequestFilterItemOp : IStringEnum
{
    public static readonly ReceiptsListPosRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly ReceiptsListPosRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly ReceiptsListPosRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly ReceiptsListPosRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly ReceiptsListPosRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly ReceiptsListPosRequestFilterItemOp In = new(Values.In);

    public ReceiptsListPosRequestFilterItemOp(string value)
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
    public static ReceiptsListPosRequestFilterItemOp FromCustom(string value)
    {
        return new ReceiptsListPosRequestFilterItemOp(value);
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

    public static bool operator ==(ReceiptsListPosRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReceiptsListPosRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReceiptsListPosRequestFilterItemOp value) => value.Value;

    public static explicit operator ReceiptsListPosRequestFilterItemOp(string value) => new(value);

    internal class ReceiptsListPosRequestFilterItemOpSerializer
        : JsonConverter<ReceiptsListPosRequestFilterItemOp>
    {
        public override ReceiptsListPosRequestFilterItemOp Read(
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
            return new ReceiptsListPosRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReceiptsListPosRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReceiptsListPosRequestFilterItemOp ReadAsPropertyName(
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
            return new ReceiptsListPosRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReceiptsListPosRequestFilterItemOp value,
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
