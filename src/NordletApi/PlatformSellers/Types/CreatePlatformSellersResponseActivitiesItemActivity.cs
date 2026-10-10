using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePlatformSellersResponseActivitiesItemActivity.CreatePlatformSellersResponseActivitiesItemActivitySerializer)
)]
[Serializable]
public readonly record struct CreatePlatformSellersResponseActivitiesItemActivity : IStringEnum
{
    public static readonly CreatePlatformSellersResponseActivitiesItemActivity ImmovableProperty =
        new(Values.ImmovableProperty);

    public static readonly CreatePlatformSellersResponseActivitiesItemActivity PersonalServices =
        new(Values.PersonalServices);

    public static readonly CreatePlatformSellersResponseActivitiesItemActivity SaleOfGoods = new(
        Values.SaleOfGoods
    );

    public static readonly CreatePlatformSellersResponseActivitiesItemActivity TransportationRental =
        new(Values.TransportationRental);

    public CreatePlatformSellersResponseActivitiesItemActivity(string value)
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
    public static CreatePlatformSellersResponseActivitiesItemActivity FromCustom(string value)
    {
        return new CreatePlatformSellersResponseActivitiesItemActivity(value);
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
        CreatePlatformSellersResponseActivitiesItemActivity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePlatformSellersResponseActivitiesItemActivity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePlatformSellersResponseActivitiesItemActivity value
    ) => value.Value;

    public static explicit operator CreatePlatformSellersResponseActivitiesItemActivity(
        string value
    ) => new(value);

    internal class CreatePlatformSellersResponseActivitiesItemActivitySerializer
        : JsonConverter<CreatePlatformSellersResponseActivitiesItemActivity>
    {
        public override CreatePlatformSellersResponseActivitiesItemActivity Read(
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
            return new CreatePlatformSellersResponseActivitiesItemActivity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePlatformSellersResponseActivitiesItemActivity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePlatformSellersResponseActivitiesItemActivity ReadAsPropertyName(
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
            return new CreatePlatformSellersResponseActivitiesItemActivity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePlatformSellersResponseActivitiesItemActivity value,
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
