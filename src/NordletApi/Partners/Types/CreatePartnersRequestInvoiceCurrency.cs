using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePartnersRequestInvoiceCurrency.CreatePartnersRequestInvoiceCurrencySerializer)
)]
[Serializable]
public readonly record struct CreatePartnersRequestInvoiceCurrency : IStringEnum
{
    public static readonly CreatePartnersRequestInvoiceCurrency Eur = new(Values.Eur);

    public static readonly CreatePartnersRequestInvoiceCurrency Usd = new(Values.Usd);

    public static readonly CreatePartnersRequestInvoiceCurrency Gbp = new(Values.Gbp);

    public static readonly CreatePartnersRequestInvoiceCurrency Pln = new(Values.Pln);

    public static readonly CreatePartnersRequestInvoiceCurrency Sek = new(Values.Sek);

    public static readonly CreatePartnersRequestInvoiceCurrency Nok = new(Values.Nok);

    public static readonly CreatePartnersRequestInvoiceCurrency Dkk = new(Values.Dkk);

    public static readonly CreatePartnersRequestInvoiceCurrency Chf = new(Values.Chf);

    public static readonly CreatePartnersRequestInvoiceCurrency Czk = new(Values.Czk);

    public static readonly CreatePartnersRequestInvoiceCurrency Huf = new(Values.Huf);

    public static readonly CreatePartnersRequestInvoiceCurrency Ron = new(Values.Ron);

    public static readonly CreatePartnersRequestInvoiceCurrency Aed = new(Values.Aed);

    public static readonly CreatePartnersRequestInvoiceCurrency Afn = new(Values.Afn);

    public static readonly CreatePartnersRequestInvoiceCurrency All = new(Values.All);

    public static readonly CreatePartnersRequestInvoiceCurrency Amd = new(Values.Amd);

    public static readonly CreatePartnersRequestInvoiceCurrency Ars = new(Values.Ars);

    public static readonly CreatePartnersRequestInvoiceCurrency Aud = new(Values.Aud);

    public static readonly CreatePartnersRequestInvoiceCurrency Azn = new(Values.Azn);

    public static readonly CreatePartnersRequestInvoiceCurrency Bam = new(Values.Bam);

    public static readonly CreatePartnersRequestInvoiceCurrency Bdt = new(Values.Bdt);

    public static readonly CreatePartnersRequestInvoiceCurrency Bhd = new(Values.Bhd);

    public static readonly CreatePartnersRequestInvoiceCurrency Bob = new(Values.Bob);

    public static readonly CreatePartnersRequestInvoiceCurrency Brl = new(Values.Brl);

    public static readonly CreatePartnersRequestInvoiceCurrency Byn = new(Values.Byn);

    public static readonly CreatePartnersRequestInvoiceCurrency Cad = new(Values.Cad);

    public static readonly CreatePartnersRequestInvoiceCurrency Clp = new(Values.Clp);

    public static readonly CreatePartnersRequestInvoiceCurrency Cny = new(Values.Cny);

    public static readonly CreatePartnersRequestInvoiceCurrency Cop = new(Values.Cop);

    public static readonly CreatePartnersRequestInvoiceCurrency Djf = new(Values.Djf);

    public static readonly CreatePartnersRequestInvoiceCurrency Dzd = new(Values.Dzd);

    public static readonly CreatePartnersRequestInvoiceCurrency Egp = new(Values.Egp);

    public static readonly CreatePartnersRequestInvoiceCurrency Etb = new(Values.Etb);

    public static readonly CreatePartnersRequestInvoiceCurrency Gel = new(Values.Gel);

    public static readonly CreatePartnersRequestInvoiceCurrency Gnf = new(Values.Gnf);

    public static readonly CreatePartnersRequestInvoiceCurrency Hkd = new(Values.Hkd);

    public static readonly CreatePartnersRequestInvoiceCurrency Idr = new(Values.Idr);

    public static readonly CreatePartnersRequestInvoiceCurrency Ils = new(Values.Ils);

    public static readonly CreatePartnersRequestInvoiceCurrency Inr = new(Values.Inr);

    public static readonly CreatePartnersRequestInvoiceCurrency Iqd = new(Values.Iqd);

    public static readonly CreatePartnersRequestInvoiceCurrency Irr = new(Values.Irr);

    public static readonly CreatePartnersRequestInvoiceCurrency Isk = new(Values.Isk);

    public static readonly CreatePartnersRequestInvoiceCurrency Jod = new(Values.Jod);

    public static readonly CreatePartnersRequestInvoiceCurrency Jpy = new(Values.Jpy);

    public static readonly CreatePartnersRequestInvoiceCurrency Kes = new(Values.Kes);

    public static readonly CreatePartnersRequestInvoiceCurrency Kgs = new(Values.Kgs);

    public static readonly CreatePartnersRequestInvoiceCurrency Krw = new(Values.Krw);

    public static readonly CreatePartnersRequestInvoiceCurrency Kwd = new(Values.Kwd);

    public static readonly CreatePartnersRequestInvoiceCurrency Kzt = new(Values.Kzt);

    public static readonly CreatePartnersRequestInvoiceCurrency Lbp = new(Values.Lbp);

    public static readonly CreatePartnersRequestInvoiceCurrency Lkr = new(Values.Lkr);

    public static readonly CreatePartnersRequestInvoiceCurrency Lyd = new(Values.Lyd);

    public static readonly CreatePartnersRequestInvoiceCurrency Mad = new(Values.Mad);

    public static readonly CreatePartnersRequestInvoiceCurrency Mdl = new(Values.Mdl);

    public static readonly CreatePartnersRequestInvoiceCurrency Mga = new(Values.Mga);

    public static readonly CreatePartnersRequestInvoiceCurrency Mkd = new(Values.Mkd);

    public static readonly CreatePartnersRequestInvoiceCurrency Mnt = new(Values.Mnt);

    public static readonly CreatePartnersRequestInvoiceCurrency Mxn = new(Values.Mxn);

    public static readonly CreatePartnersRequestInvoiceCurrency Myr = new(Values.Myr);

    public static readonly CreatePartnersRequestInvoiceCurrency Mzn = new(Values.Mzn);

    public static readonly CreatePartnersRequestInvoiceCurrency Nzd = new(Values.Nzd);

    public static readonly CreatePartnersRequestInvoiceCurrency Pab = new(Values.Pab);

    public static readonly CreatePartnersRequestInvoiceCurrency Pen = new(Values.Pen);

    public static readonly CreatePartnersRequestInvoiceCurrency Php = new(Values.Php);

    public static readonly CreatePartnersRequestInvoiceCurrency Pkr = new(Values.Pkr);

    public static readonly CreatePartnersRequestInvoiceCurrency Qar = new(Values.Qar);

    public static readonly CreatePartnersRequestInvoiceCurrency Rsd = new(Values.Rsd);

    public static readonly CreatePartnersRequestInvoiceCurrency Sar = new(Values.Sar);

    public static readonly CreatePartnersRequestInvoiceCurrency Sgd = new(Values.Sgd);

    public static readonly CreatePartnersRequestInvoiceCurrency Syp = new(Values.Syp);

    public static readonly CreatePartnersRequestInvoiceCurrency Thb = new(Values.Thb);

    public static readonly CreatePartnersRequestInvoiceCurrency Tjs = new(Values.Tjs);

    public static readonly CreatePartnersRequestInvoiceCurrency Tmt = new(Values.Tmt);

    public static readonly CreatePartnersRequestInvoiceCurrency Tnd = new(Values.Tnd);

    public static readonly CreatePartnersRequestInvoiceCurrency Try = new(Values.Try);

    public static readonly CreatePartnersRequestInvoiceCurrency Twd = new(Values.Twd);

    public static readonly CreatePartnersRequestInvoiceCurrency Tzs = new(Values.Tzs);

    public static readonly CreatePartnersRequestInvoiceCurrency Uah = new(Values.Uah);

    public static readonly CreatePartnersRequestInvoiceCurrency Uyu = new(Values.Uyu);

    public static readonly CreatePartnersRequestInvoiceCurrency Uzs = new(Values.Uzs);

    public static readonly CreatePartnersRequestInvoiceCurrency Ves = new(Values.Ves);

    public static readonly CreatePartnersRequestInvoiceCurrency Vnd = new(Values.Vnd);

    public static readonly CreatePartnersRequestInvoiceCurrency Xaf = new(Values.Xaf);

    public static readonly CreatePartnersRequestInvoiceCurrency Xof = new(Values.Xof);

    public static readonly CreatePartnersRequestInvoiceCurrency Yer = new(Values.Yer);

    public static readonly CreatePartnersRequestInvoiceCurrency Zar = new(Values.Zar);

    public CreatePartnersRequestInvoiceCurrency(string value)
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
    public static CreatePartnersRequestInvoiceCurrency FromCustom(string value)
    {
        return new CreatePartnersRequestInvoiceCurrency(value);
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

    public static bool operator ==(CreatePartnersRequestInvoiceCurrency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePartnersRequestInvoiceCurrency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePartnersRequestInvoiceCurrency value) =>
        value.Value;

    public static explicit operator CreatePartnersRequestInvoiceCurrency(string value) =>
        new(value);

    internal class CreatePartnersRequestInvoiceCurrencySerializer
        : JsonConverter<CreatePartnersRequestInvoiceCurrency>
    {
        public override CreatePartnersRequestInvoiceCurrency Read(
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
            return new CreatePartnersRequestInvoiceCurrency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePartnersRequestInvoiceCurrency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePartnersRequestInvoiceCurrency ReadAsPropertyName(
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
            return new CreatePartnersRequestInvoiceCurrency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePartnersRequestInvoiceCurrency value,
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
        public const string Eur = "EUR";

        public const string Usd = "USD";

        public const string Gbp = "GBP";

        public const string Pln = "PLN";

        public const string Sek = "SEK";

        public const string Nok = "NOK";

        public const string Dkk = "DKK";

        public const string Chf = "CHF";

        public const string Czk = "CZK";

        public const string Huf = "HUF";

        public const string Ron = "RON";

        public const string Aed = "AED";

        public const string Afn = "AFN";

        public const string All = "ALL";

        public const string Amd = "AMD";

        public const string Ars = "ARS";

        public const string Aud = "AUD";

        public const string Azn = "AZN";

        public const string Bam = "BAM";

        public const string Bdt = "BDT";

        public const string Bhd = "BHD";

        public const string Bob = "BOB";

        public const string Brl = "BRL";

        public const string Byn = "BYN";

        public const string Cad = "CAD";

        public const string Clp = "CLP";

        public const string Cny = "CNY";

        public const string Cop = "COP";

        public const string Djf = "DJF";

        public const string Dzd = "DZD";

        public const string Egp = "EGP";

        public const string Etb = "ETB";

        public const string Gel = "GEL";

        public const string Gnf = "GNF";

        public const string Hkd = "HKD";

        public const string Idr = "IDR";

        public const string Ils = "ILS";

        public const string Inr = "INR";

        public const string Iqd = "IQD";

        public const string Irr = "IRR";

        public const string Isk = "ISK";

        public const string Jod = "JOD";

        public const string Jpy = "JPY";

        public const string Kes = "KES";

        public const string Kgs = "KGS";

        public const string Krw = "KRW";

        public const string Kwd = "KWD";

        public const string Kzt = "KZT";

        public const string Lbp = "LBP";

        public const string Lkr = "LKR";

        public const string Lyd = "LYD";

        public const string Mad = "MAD";

        public const string Mdl = "MDL";

        public const string Mga = "MGA";

        public const string Mkd = "MKD";

        public const string Mnt = "MNT";

        public const string Mxn = "MXN";

        public const string Myr = "MYR";

        public const string Mzn = "MZN";

        public const string Nzd = "NZD";

        public const string Pab = "PAB";

        public const string Pen = "PEN";

        public const string Php = "PHP";

        public const string Pkr = "PKR";

        public const string Qar = "QAR";

        public const string Rsd = "RSD";

        public const string Sar = "SAR";

        public const string Sgd = "SGD";

        public const string Syp = "SYP";

        public const string Thb = "THB";

        public const string Tjs = "TJS";

        public const string Tmt = "TMT";

        public const string Tnd = "TND";

        public const string Try = "TRY";

        public const string Twd = "TWD";

        public const string Tzs = "TZS";

        public const string Uah = "UAH";

        public const string Uyu = "UYU";

        public const string Uzs = "UZS";

        public const string Ves = "VES";

        public const string Vnd = "VND";

        public const string Xaf = "XAF";

        public const string Xof = "XOF";

        public const string Yer = "YER";

        public const string Zar = "ZAR";
    }
}
