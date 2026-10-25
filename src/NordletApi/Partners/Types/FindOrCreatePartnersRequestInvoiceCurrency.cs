using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FindOrCreatePartnersRequestInvoiceCurrency.FindOrCreatePartnersRequestInvoiceCurrencySerializer)
)]
[Serializable]
public readonly record struct FindOrCreatePartnersRequestInvoiceCurrency : IStringEnum
{
    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Eur = new(Values.Eur);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Usd = new(Values.Usd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Gbp = new(Values.Gbp);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Pln = new(Values.Pln);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Sek = new(Values.Sek);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Nok = new(Values.Nok);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Dkk = new(Values.Dkk);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Chf = new(Values.Chf);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Czk = new(Values.Czk);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Huf = new(Values.Huf);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Ron = new(Values.Ron);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Aed = new(Values.Aed);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Afn = new(Values.Afn);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency All = new(Values.All);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Amd = new(Values.Amd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Ars = new(Values.Ars);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Aud = new(Values.Aud);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Azn = new(Values.Azn);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Bam = new(Values.Bam);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Bdt = new(Values.Bdt);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Bhd = new(Values.Bhd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Bob = new(Values.Bob);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Brl = new(Values.Brl);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Byn = new(Values.Byn);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Cad = new(Values.Cad);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Clp = new(Values.Clp);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Cny = new(Values.Cny);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Cop = new(Values.Cop);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Djf = new(Values.Djf);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Dzd = new(Values.Dzd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Egp = new(Values.Egp);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Etb = new(Values.Etb);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Gel = new(Values.Gel);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Gnf = new(Values.Gnf);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Hkd = new(Values.Hkd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Idr = new(Values.Idr);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Ils = new(Values.Ils);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Inr = new(Values.Inr);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Iqd = new(Values.Iqd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Irr = new(Values.Irr);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Isk = new(Values.Isk);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Jod = new(Values.Jod);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Jpy = new(Values.Jpy);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Kes = new(Values.Kes);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Kgs = new(Values.Kgs);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Krw = new(Values.Krw);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Kwd = new(Values.Kwd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Kzt = new(Values.Kzt);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Lbp = new(Values.Lbp);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Lkr = new(Values.Lkr);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Lyd = new(Values.Lyd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mad = new(Values.Mad);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mdl = new(Values.Mdl);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mga = new(Values.Mga);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mkd = new(Values.Mkd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mnt = new(Values.Mnt);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mxn = new(Values.Mxn);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Myr = new(Values.Myr);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Mzn = new(Values.Mzn);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Nzd = new(Values.Nzd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Pab = new(Values.Pab);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Pen = new(Values.Pen);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Php = new(Values.Php);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Pkr = new(Values.Pkr);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Qar = new(Values.Qar);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Rsd = new(Values.Rsd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Sar = new(Values.Sar);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Sgd = new(Values.Sgd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Syp = new(Values.Syp);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Thb = new(Values.Thb);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Tjs = new(Values.Tjs);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Tmt = new(Values.Tmt);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Tnd = new(Values.Tnd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Try = new(Values.Try);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Twd = new(Values.Twd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Tzs = new(Values.Tzs);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Uah = new(Values.Uah);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Uyu = new(Values.Uyu);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Uzs = new(Values.Uzs);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Ves = new(Values.Ves);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Vnd = new(Values.Vnd);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Xaf = new(Values.Xaf);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Xof = new(Values.Xof);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Yer = new(Values.Yer);

    public static readonly FindOrCreatePartnersRequestInvoiceCurrency Zar = new(Values.Zar);

    public FindOrCreatePartnersRequestInvoiceCurrency(string value)
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
    public static FindOrCreatePartnersRequestInvoiceCurrency FromCustom(string value)
    {
        return new FindOrCreatePartnersRequestInvoiceCurrency(value);
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
        FindOrCreatePartnersRequestInvoiceCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FindOrCreatePartnersRequestInvoiceCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FindOrCreatePartnersRequestInvoiceCurrency value) =>
        value.Value;

    public static explicit operator FindOrCreatePartnersRequestInvoiceCurrency(string value) =>
        new(value);

    internal class FindOrCreatePartnersRequestInvoiceCurrencySerializer
        : JsonConverter<FindOrCreatePartnersRequestInvoiceCurrency>
    {
        public override FindOrCreatePartnersRequestInvoiceCurrency Read(
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
            return new FindOrCreatePartnersRequestInvoiceCurrency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FindOrCreatePartnersRequestInvoiceCurrency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FindOrCreatePartnersRequestInvoiceCurrency ReadAsPropertyName(
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
            return new FindOrCreatePartnersRequestInvoiceCurrency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FindOrCreatePartnersRequestInvoiceCurrency value,
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
