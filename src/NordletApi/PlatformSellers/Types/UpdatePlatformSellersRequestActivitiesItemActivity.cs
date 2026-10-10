using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdatePlatformSellersRequestActivitiesItemActivity.UpdatePlatformSellersRequestActivitiesItemActivitySerializer)
)]
[Serializable]
public readonly record struct UpdatePlatformSellersRequestActivitiesItemActivity : IStringEnum
{
    public static readonly UpdatePlatformSellersRequestActivitiesItemActivity ImmovableProperty =
        new(Values.ImmovableProperty);

    public static readonly UpdatePlatformSellersRequestActivitiesItemActivity PersonalServices =
        new(Values.PersonalServices);

    public static readonly UpdatePlatformSellersRequestActivitiesItemActivity SaleOfGoods = new(
        Values.SaleOfGoods
    );

    public static readonly UpdatePlatformSellersRequestActivitiesItemActivity TransportationRental =
        new(Values.TransportationRental);

    public UpdatePlatformSellersRequestActivitiesItemActivity(string value)
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
    public static UpdatePlatformSellersRequestActivitiesItemActivity FromCustom(string value)
    {
        return new UpdatePlatformSellersRequestActivitiesItemActivity(value);
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
        UpdatePlatformSellersRequestActivitiesItemActivity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePlatformSellersRequestActivitiesItemActivity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePlatformSellersRequestActivitiesItemActivity value
    ) => value.Value;

    public static explicit operator UpdatePlatformSellersRequestActivitiesItemActivity(
        string value
    ) => new(value);

    internal class UpdatePlatformSellersRequestActivitiesItemActivitySerializer
        : JsonConverter<UpdatePlatformSellersRequestActivitiesItemActivity>
    {
        public override UpdatePlatformSellersRequestActivitiesItemActivity Read(
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
            return new UpdatePlatformSellersRequestActivitiesItemActivity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePlatformSellersRequestActivitiesItemActivity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePlatformSellersRequestActivitiesItemActivity ReadAsPropertyName(
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
            return new UpdatePlatformSellersRequestActivitiesItemActivity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePlatformSellersRequestActivitiesItemActivity value,
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
        public const string ImmovableProperty = "immovable_property";

        public const string PersonalServices = "personal_services";

        public const string SaleOfGoods = "sale_of_goods";

        public const string TransportationRental = "transportation_rental";
    }
}
