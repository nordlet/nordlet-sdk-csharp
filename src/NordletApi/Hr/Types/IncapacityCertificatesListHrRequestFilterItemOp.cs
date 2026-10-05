using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(IncapacityCertificatesListHrRequestFilterItemOp.IncapacityCertificatesListHrRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct IncapacityCertificatesListHrRequestFilterItemOp : IStringEnum
{
    public static readonly IncapacityCertificatesListHrRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly IncapacityCertificatesListHrRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly IncapacityCertificatesListHrRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly IncapacityCertificatesListHrRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly IncapacityCertificatesListHrRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly IncapacityCertificatesListHrRequestFilterItemOp In = new(Values.In);

    public IncapacityCertificatesListHrRequestFilterItemOp(string value)
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
    public static IncapacityCertificatesListHrRequestFilterItemOp FromCustom(string value)
    {
        return new IncapacityCertificatesListHrRequestFilterItemOp(value);
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
        IncapacityCertificatesListHrRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IncapacityCertificatesListHrRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(IncapacityCertificatesListHrRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator IncapacityCertificatesListHrRequestFilterItemOp(string value) =>
        new(value);

    internal class IncapacityCertificatesListHrRequestFilterItemOpSerializer
        : JsonConverter<IncapacityCertificatesListHrRequestFilterItemOp>
    {
        public override IncapacityCertificatesListHrRequestFilterItemOp Read(
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
            return new IncapacityCertificatesListHrRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IncapacityCertificatesListHrRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IncapacityCertificatesListHrRequestFilterItemOp ReadAsPropertyName(
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
            return new IncapacityCertificatesListHrRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IncapacityCertificatesListHrRequestFilterItemOp value,
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
