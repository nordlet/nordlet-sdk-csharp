using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UsDeGrossReceiptsGetDeclarationsRequestActivity.UsDeGrossReceiptsGetDeclarationsRequestActivitySerializer)
)]
[Serializable]
public readonly record struct UsDeGrossReceiptsGetDeclarationsRequestActivity : IStringEnum
{
    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity Services = new(
        Values.Services
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity Contractor = new(
        Values.Contractor
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity Manufacturer = new(
        Values.Manufacturer
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity CleanEnergyDeviceManufacturer =
        new(Values.CleanEnergyDeviceManufacturer);

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity AutomobileManufacturer =
        new(Values.AutomobileManufacturer);

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity Wholesaler = new(
        Values.Wholesaler
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity FoodProcessor = new(
        Values.FoodProcessor
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity CommercialFeedDealer =
        new(Values.CommercialFeedDealer);

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity Retailer = new(
        Values.Retailer
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity RestaurantRetailer = new(
        Values.RestaurantRetailer
    );

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity FarmMachineryRetailer =
        new(Values.FarmMachineryRetailer);

    public static readonly UsDeGrossReceiptsGetDeclarationsRequestActivity GrocerySupermarketRetailer =
        new(Values.GrocerySupermarketRetailer);

    public UsDeGrossReceiptsGetDeclarationsRequestActivity(string value)
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
    public static UsDeGrossReceiptsGetDeclarationsRequestActivity FromCustom(string value)
    {
        return new UsDeGrossReceiptsGetDeclarationsRequestActivity(value);
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
        UsDeGrossReceiptsGetDeclarationsRequestActivity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UsDeGrossReceiptsGetDeclarationsRequestActivity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UsDeGrossReceiptsGetDeclarationsRequestActivity value) =>
        value.Value;

    public static explicit operator UsDeGrossReceiptsGetDeclarationsRequestActivity(string value) =>
        new(value);

    internal class UsDeGrossReceiptsGetDeclarationsRequestActivitySerializer
        : JsonConverter<UsDeGrossReceiptsGetDeclarationsRequestActivity>
    {
        public override UsDeGrossReceiptsGetDeclarationsRequestActivity Read(
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
            return new UsDeGrossReceiptsGetDeclarationsRequestActivity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UsDeGrossReceiptsGetDeclarationsRequestActivity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UsDeGrossReceiptsGetDeclarationsRequestActivity ReadAsPropertyName(
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
            return new UsDeGrossReceiptsGetDeclarationsRequestActivity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UsDeGrossReceiptsGetDeclarationsRequestActivity value,
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
        public const string Services = "services";

        public const string Contractor = "contractor";

        public const string Manufacturer = "manufacturer";

        public const string CleanEnergyDeviceManufacturer = "clean-energy-device-manufacturer";

        public const string AutomobileManufacturer = "automobile-manufacturer";

        public const string Wholesaler = "wholesaler";

        public const string FoodProcessor = "food-processor";

        public const string CommercialFeedDealer = "commercial-feed-dealer";

        public const string Retailer = "retailer";

        public const string RestaurantRetailer = "restaurant-retailer";

        public const string FarmMachineryRetailer = "farm-machinery-retailer";

        public const string GrocerySupermarketRetailer = "grocery-supermarket-retailer";
    }
}
