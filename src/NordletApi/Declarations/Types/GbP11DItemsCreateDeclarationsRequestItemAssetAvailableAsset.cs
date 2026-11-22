using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset.GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAssetSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset
    : IStringEnum
{
    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset HolidayAccommodation =
        new(Values.HolidayAccommodation);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset TimeshareAccommodation =
        new(Values.TimeshareAccommodation);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset Aircraft =
        new(Values.Aircraft);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset Boat = new(
        Values.Boat
    );

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset CorporateHospitality =
        new(Values.CorporateHospitality);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset Multiple =
        new(Values.Multiple);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset Other = new(
        Values.Other
    );

    public GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset(string value)
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
    public static GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset FromCustom(
        string value
    )
    {
        return new GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset(value);
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
        GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset value
    ) => value.Value;

    public static explicit operator GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset(
        string value
    ) => new(value);

    internal class GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAssetSerializer
        : JsonConverter<GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset>
    {
        public override GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset Read(
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
            return new GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset ReadAsPropertyName(
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
            return new GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemAssetAvailableAsset value,
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
