using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatClassifiersListReferenceResponseRowsItemSide.VatClassifiersListReferenceResponseRowsItemSideSerializer)
)]
[Serializable]
public readonly record struct VatClassifiersListReferenceResponseRowsItemSide : IStringEnum
{
    public static readonly VatClassifiersListReferenceResponseRowsItemSide Sale = new(Values.Sale);

    public static readonly VatClassifiersListReferenceResponseRowsItemSide Purchase = new(
        Values.Purchase
    );

    public static readonly VatClassifiersListReferenceResponseRowsItemSide Both = new(Values.Both);

    public VatClassifiersListReferenceResponseRowsItemSide(string value)
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
    public static VatClassifiersListReferenceResponseRowsItemSide FromCustom(string value)
    {
        return new VatClassifiersListReferenceResponseRowsItemSide(value);
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
        VatClassifiersListReferenceResponseRowsItemSide value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatClassifiersListReferenceResponseRowsItemSide value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatClassifiersListReferenceResponseRowsItemSide value) =>
        value.Value;

    public static explicit operator VatClassifiersListReferenceResponseRowsItemSide(string value) =>
        new(value);

    internal class VatClassifiersListReferenceResponseRowsItemSideSerializer
        : JsonConverter<VatClassifiersListReferenceResponseRowsItemSide>
    {
        public override VatClassifiersListReferenceResponseRowsItemSide Read(
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
            return new VatClassifiersListReferenceResponseRowsItemSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatClassifiersListReferenceResponseRowsItemSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatClassifiersListReferenceResponseRowsItemSide ReadAsPropertyName(
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
            return new VatClassifiersListReferenceResponseRowsItemSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatClassifiersListReferenceResponseRowsItemSide value,
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
        public const string Sale = "sale";

        public const string Purchase = "purchase";

        public const string Both = "both";
    }
}
