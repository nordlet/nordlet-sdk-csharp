using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAssetSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset
    : IStringEnum
{
    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset HolidayAccommodation =
        new(Values.HolidayAccommodation);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset TimeshareAccommodation =
        new(Values.TimeshareAccommodation);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset Aircraft =
        new(Values.Aircraft);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset Boat =
        new(Values.Boat);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset CorporateHospitality =
        new(Values.CorporateHospitality);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset Multiple =
        new(Values.Multiple);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset Other =
        new(Values.Other);

    public GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset(string value)
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
    public static GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset FromCustom(
        string value
    )
    {
        return new GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset(value);
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
        GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset value
    ) => value.Value;

    public static explicit operator GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset(
        string value
    ) => new(value);

    internal class GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAssetSerializer
        : JsonConverter<GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset>
    {
        public override GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset Read(
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
            return new GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset ReadAsPropertyName(
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
            return new GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailableAsset value,
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
        public const string HolidayAccommodation = "holiday accommodation";

        public const string TimeshareAccommodation = "timeshare accommodation";

        public const string Aircraft = "aircraft";

        public const string Boat = "boat";

        public const string CorporateHospitality = "corporate hospitality";

        public const string Multiple = "multiple";

        public const string Other = "other";
    }
}
