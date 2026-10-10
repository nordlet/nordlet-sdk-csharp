using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatResolveReferenceRequestGoodsKind.VatResolveReferenceRequestGoodsKindSerializer)
)]
[Serializable]
public readonly record struct VatResolveReferenceRequestGoodsKind : IStringEnum
{
    public static readonly VatResolveReferenceRequestGoodsKind Installed = new(Values.Installed);

    public static readonly VatResolveReferenceRequestGoodsKind EnergyNetwork = new(
        Values.EnergyNetwork
    );

    public VatResolveReferenceRequestGoodsKind(string value)
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
    public static VatResolveReferenceRequestGoodsKind FromCustom(string value)
    {
        return new VatResolveReferenceRequestGoodsKind(value);
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

    public static bool operator ==(VatResolveReferenceRequestGoodsKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatResolveReferenceRequestGoodsKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatResolveReferenceRequestGoodsKind value) =>
        value.Value;

    public static explicit operator VatResolveReferenceRequestGoodsKind(string value) => new(value);

    internal class VatResolveReferenceRequestGoodsKindSerializer
        : JsonConverter<VatResolveReferenceRequestGoodsKind>
    {
        public override VatResolveReferenceRequestGoodsKind Read(
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
            return new VatResolveReferenceRequestGoodsKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatResolveReferenceRequestGoodsKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatResolveReferenceRequestGoodsKind ReadAsPropertyName(
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
            return new VatResolveReferenceRequestGoodsKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatResolveReferenceRequestGoodsKind value,
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
        public const string Installed = "installed";

        public const string EnergyNetwork = "energy_network";
    }
}
