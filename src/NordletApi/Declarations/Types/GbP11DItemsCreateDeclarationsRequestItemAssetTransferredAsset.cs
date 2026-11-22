using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset.GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAssetSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset
    : IStringEnum
{
    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset Cars = new(
        Values.Cars
    );

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset Property =
        new(Values.Property);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset PreciousMetals =
        new(Values.PreciousMetals);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset Other =
        new(Values.Other);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset Multiple =
        new(Values.Multiple);

    public GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset(string value)
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
    public static GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset FromCustom(
        string value
    )
    {
        return new GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset(value);
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
        GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset value
    ) => value.Value;

    public static explicit operator GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset(
        string value
    ) => new(value);

    internal class GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAssetSerializer
        : JsonConverter<GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset>
    {
        public override GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset Read(
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
            return new GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset ReadAsPropertyName(
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
            return new GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset value,
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
        public const string Cars = "cars";

        public const string Property = "property";

        public const string PreciousMetals = "precious metals";

        public const string Other = "other";

        public const string Multiple = "multiple";
    }
}
