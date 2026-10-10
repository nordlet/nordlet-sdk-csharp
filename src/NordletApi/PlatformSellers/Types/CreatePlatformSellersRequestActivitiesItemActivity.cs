using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePlatformSellersRequestActivitiesItemActivity.CreatePlatformSellersRequestActivitiesItemActivitySerializer)
)]
[Serializable]
public readonly record struct CreatePlatformSellersRequestActivitiesItemActivity : IStringEnum
{
    public static readonly CreatePlatformSellersRequestActivitiesItemActivity ImmovableProperty =
        new(Values.ImmovableProperty);

    public static readonly CreatePlatformSellersRequestActivitiesItemActivity PersonalServices =
        new(Values.PersonalServices);

    public static readonly CreatePlatformSellersRequestActivitiesItemActivity SaleOfGoods = new(
        Values.SaleOfGoods
    );

    public static readonly CreatePlatformSellersRequestActivitiesItemActivity TransportationRental =
        new(Values.TransportationRental);

    public CreatePlatformSellersRequestActivitiesItemActivity(string value)
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
    public static CreatePlatformSellersRequestActivitiesItemActivity FromCustom(string value)
    {
        return new CreatePlatformSellersRequestActivitiesItemActivity(value);
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
        CreatePlatformSellersRequestActivitiesItemActivity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePlatformSellersRequestActivitiesItemActivity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePlatformSellersRequestActivitiesItemActivity value
    ) => value.Value;

    public static explicit operator CreatePlatformSellersRequestActivitiesItemActivity(
        string value
    ) => new(value);

    internal class CreatePlatformSellersRequestActivitiesItemActivitySerializer
        : JsonConverter<CreatePlatformSellersRequestActivitiesItemActivity>
    {
        public override CreatePlatformSellersRequestActivitiesItemActivity Read(
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
            return new CreatePlatformSellersRequestActivitiesItemActivity(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePlatformSellersRequestActivitiesItemActivity value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePlatformSellersRequestActivitiesItemActivity ReadAsPropertyName(
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
            return new CreatePlatformSellersRequestActivitiesItemActivity(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePlatformSellersRequestActivitiesItemActivity value,
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
