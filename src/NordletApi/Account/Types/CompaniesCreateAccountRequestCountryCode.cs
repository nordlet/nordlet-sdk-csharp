using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesCreateAccountRequestCountryCode.CompaniesCreateAccountRequestCountryCodeSerializer)
)]
[Serializable]
public readonly record struct CompaniesCreateAccountRequestCountryCode : IStringEnum
{
    public static readonly CompaniesCreateAccountRequestCountryCode Ad = new(Values.Ad);

    public static readonly CompaniesCreateAccountRequestCountryCode Ae = new(Values.Ae);

    public static readonly CompaniesCreateAccountRequestCountryCode Af = new(Values.Af);

    public static readonly CompaniesCreateAccountRequestCountryCode Ag = new(Values.Ag);

    public static readonly CompaniesCreateAccountRequestCountryCode Ai = new(Values.Ai);

    public static readonly CompaniesCreateAccountRequestCountryCode Al = new(Values.Al);

    public static readonly CompaniesCreateAccountRequestCountryCode Am = new(Values.Am);

    public static readonly CompaniesCreateAccountRequestCountryCode Ao = new(Values.Ao);

    public static readonly CompaniesCreateAccountRequestCountryCode Aq = new(Values.Aq);

    public static readonly CompaniesCreateAccountRequestCountryCode Ar = new(Values.Ar);

    public static readonly CompaniesCreateAccountRequestCountryCode As = new(Values.As);

    public static readonly CompaniesCreateAccountRequestCountryCode At = new(Values.At);

    public static readonly CompaniesCreateAccountRequestCountryCode Au = new(Values.Au);

    public static readonly CompaniesCreateAccountRequestCountryCode Aw = new(Values.Aw);

    public static readonly CompaniesCreateAccountRequestCountryCode Ax = new(Values.Ax);

    public static readonly CompaniesCreateAccountRequestCountryCode Az = new(Values.Az);

    public static readonly CompaniesCreateAccountRequestCountryCode Ba = new(Values.Ba);

    public static readonly CompaniesCreateAccountRequestCountryCode Bb = new(Values.Bb);

    public static readonly CompaniesCreateAccountRequestCountryCode Bd = new(Values.Bd);

    public static readonly CompaniesCreateAccountRequestCountryCode Be = new(Values.Be);

    public static readonly CompaniesCreateAccountRequestCountryCode Bf = new(Values.Bf);

    public static readonly CompaniesCreateAccountRequestCountryCode Bg = new(Values.Bg);

    public static readonly CompaniesCreateAccountRequestCountryCode Bh = new(Values.Bh);

    public static readonly CompaniesCreateAccountRequestCountryCode Bi = new(Values.Bi);

    public static readonly CompaniesCreateAccountRequestCountryCode Bj = new(Values.Bj);

    public static readonly CompaniesCreateAccountRequestCountryCode Bl = new(Values.Bl);

    public static readonly CompaniesCreateAccountRequestCountryCode Bm = new(Values.Bm);

    public static readonly CompaniesCreateAccountRequestCountryCode Bn = new(Values.Bn);

    public static readonly CompaniesCreateAccountRequestCountryCode Bo = new(Values.Bo);

    public static readonly CompaniesCreateAccountRequestCountryCode Bq = new(Values.Bq);

    public static readonly CompaniesCreateAccountRequestCountryCode Br = new(Values.Br);

    public static readonly CompaniesCreateAccountRequestCountryCode Bs = new(Values.Bs);

    public static readonly CompaniesCreateAccountRequestCountryCode Bt = new(Values.Bt);

    public static readonly CompaniesCreateAccountRequestCountryCode Bv = new(Values.Bv);

    public static readonly CompaniesCreateAccountRequestCountryCode Bw = new(Values.Bw);

    public static readonly CompaniesCreateAccountRequestCountryCode By = new(Values.By);

    public static readonly CompaniesCreateAccountRequestCountryCode Bz = new(Values.Bz);

    public static readonly CompaniesCreateAccountRequestCountryCode Ca = new(Values.Ca);

    public static readonly CompaniesCreateAccountRequestCountryCode Cc = new(Values.Cc);

    public static readonly CompaniesCreateAccountRequestCountryCode Cd = new(Values.Cd);

    public static readonly CompaniesCreateAccountRequestCountryCode Cf = new(Values.Cf);

    public static readonly CompaniesCreateAccountRequestCountryCode Cg = new(Values.Cg);

    public static readonly CompaniesCreateAccountRequestCountryCode Ch = new(Values.Ch);

    public static readonly CompaniesCreateAccountRequestCountryCode Ci = new(Values.Ci);

    public static readonly CompaniesCreateAccountRequestCountryCode Ck = new(Values.Ck);

    public static readonly CompaniesCreateAccountRequestCountryCode Cl = new(Values.Cl);

    public static readonly CompaniesCreateAccountRequestCountryCode Cm = new(Values.Cm);

    public static readonly CompaniesCreateAccountRequestCountryCode Cn = new(Values.Cn);

    public static readonly CompaniesCreateAccountRequestCountryCode Co = new(Values.Co);

    public static readonly CompaniesCreateAccountRequestCountryCode Cr = new(Values.Cr);

    public static readonly CompaniesCreateAccountRequestCountryCode Cu = new(Values.Cu);

    public static readonly CompaniesCreateAccountRequestCountryCode Cv = new(Values.Cv);

    public static readonly CompaniesCreateAccountRequestCountryCode Cw = new(Values.Cw);

    public static readonly CompaniesCreateAccountRequestCountryCode Cx = new(Values.Cx);

    public static readonly CompaniesCreateAccountRequestCountryCode Cy = new(Values.Cy);

    public static readonly CompaniesCreateAccountRequestCountryCode Cz = new(Values.Cz);

    public static readonly CompaniesCreateAccountRequestCountryCode De = new(Values.De);

    public static readonly CompaniesCreateAccountRequestCountryCode Dj = new(Values.Dj);

    public static readonly CompaniesCreateAccountRequestCountryCode Dk = new(Values.Dk);

    public static readonly CompaniesCreateAccountRequestCountryCode Dm = new(Values.Dm);

    public static readonly CompaniesCreateAccountRequestCountryCode Do = new(Values.Do);

    public static readonly CompaniesCreateAccountRequestCountryCode Dz = new(Values.Dz);

    public static readonly CompaniesCreateAccountRequestCountryCode Ec = new(Values.Ec);

    public static readonly CompaniesCreateAccountRequestCountryCode Ee = new(Values.Ee);

    public static readonly CompaniesCreateAccountRequestCountryCode Eg = new(Values.Eg);

    public static readonly CompaniesCreateAccountRequestCountryCode Eh = new(Values.Eh);

    public static readonly CompaniesCreateAccountRequestCountryCode Er = new(Values.Er);

    public static readonly CompaniesCreateAccountRequestCountryCode Es = new(Values.Es);

    public static readonly CompaniesCreateAccountRequestCountryCode Et = new(Values.Et);

    public static readonly CompaniesCreateAccountRequestCountryCode Fi = new(Values.Fi);

    public static readonly CompaniesCreateAccountRequestCountryCode Fj = new(Values.Fj);

    public static readonly CompaniesCreateAccountRequestCountryCode Fk = new(Values.Fk);

    public static readonly CompaniesCreateAccountRequestCountryCode Fm = new(Values.Fm);

    public static readonly CompaniesCreateAccountRequestCountryCode Fo = new(Values.Fo);

    public static readonly CompaniesCreateAccountRequestCountryCode Fr = new(Values.Fr);

    public static readonly CompaniesCreateAccountRequestCountryCode Ga = new(Values.Ga);

    public static readonly CompaniesCreateAccountRequestCountryCode Gb = new(Values.Gb);

    public static readonly CompaniesCreateAccountRequestCountryCode Gd = new(Values.Gd);

    public static readonly CompaniesCreateAccountRequestCountryCode Ge = new(Values.Ge);

    public static readonly CompaniesCreateAccountRequestCountryCode Gf = new(Values.Gf);

    public static readonly CompaniesCreateAccountRequestCountryCode Gg = new(Values.Gg);

    public static readonly CompaniesCreateAccountRequestCountryCode Gh = new(Values.Gh);

    public static readonly CompaniesCreateAccountRequestCountryCode Gi = new(Values.Gi);

    public static readonly CompaniesCreateAccountRequestCountryCode Gl = new(Values.Gl);

    public static readonly CompaniesCreateAccountRequestCountryCode Gm = new(Values.Gm);

    public static readonly CompaniesCreateAccountRequestCountryCode Gn = new(Values.Gn);

    public static readonly CompaniesCreateAccountRequestCountryCode Gp = new(Values.Gp);

    public static readonly CompaniesCreateAccountRequestCountryCode Gq = new(Values.Gq);

    public static readonly CompaniesCreateAccountRequestCountryCode Gr = new(Values.Gr);

    public static readonly CompaniesCreateAccountRequestCountryCode Gs = new(Values.Gs);

    public static readonly CompaniesCreateAccountRequestCountryCode Gt = new(Values.Gt);

    public static readonly CompaniesCreateAccountRequestCountryCode Gu = new(Values.Gu);

    public static readonly CompaniesCreateAccountRequestCountryCode Gw = new(Values.Gw);

    public static readonly CompaniesCreateAccountRequestCountryCode Gy = new(Values.Gy);

    public static readonly CompaniesCreateAccountRequestCountryCode Hk = new(Values.Hk);

    public static readonly CompaniesCreateAccountRequestCountryCode Hm = new(Values.Hm);

    public static readonly CompaniesCreateAccountRequestCountryCode Hn = new(Values.Hn);

    public static readonly CompaniesCreateAccountRequestCountryCode Hr = new(Values.Hr);

    public static readonly CompaniesCreateAccountRequestCountryCode Ht = new(Values.Ht);

    public static readonly CompaniesCreateAccountRequestCountryCode Hu = new(Values.Hu);

    public static readonly CompaniesCreateAccountRequestCountryCode Id = new(Values.Id);

    public static readonly CompaniesCreateAccountRequestCountryCode Ie = new(Values.Ie);

    public static readonly CompaniesCreateAccountRequestCountryCode Il = new(Values.Il);

    public static readonly CompaniesCreateAccountRequestCountryCode Im = new(Values.Im);

    public static readonly CompaniesCreateAccountRequestCountryCode In = new(Values.In);

    public static readonly CompaniesCreateAccountRequestCountryCode Io = new(Values.Io);

    public static readonly CompaniesCreateAccountRequestCountryCode Iq = new(Values.Iq);

    public static readonly CompaniesCreateAccountRequestCountryCode Ir = new(Values.Ir);

    public static readonly CompaniesCreateAccountRequestCountryCode Is = new(Values.Is);

    public static readonly CompaniesCreateAccountRequestCountryCode It = new(Values.It);

    public static readonly CompaniesCreateAccountRequestCountryCode Je = new(Values.Je);

    public static readonly CompaniesCreateAccountRequestCountryCode Jm = new(Values.Jm);

    public static readonly CompaniesCreateAccountRequestCountryCode Jo = new(Values.Jo);

    public static readonly CompaniesCreateAccountRequestCountryCode Jp = new(Values.Jp);

    public static readonly CompaniesCreateAccountRequestCountryCode Ke = new(Values.Ke);

    public static readonly CompaniesCreateAccountRequestCountryCode Kg = new(Values.Kg);

    public static readonly CompaniesCreateAccountRequestCountryCode Kh = new(Values.Kh);

    public static readonly CompaniesCreateAccountRequestCountryCode Ki = new(Values.Ki);

    public static readonly CompaniesCreateAccountRequestCountryCode Km = new(Values.Km);

    public static readonly CompaniesCreateAccountRequestCountryCode Kn = new(Values.Kn);

    public static readonly CompaniesCreateAccountRequestCountryCode Kp = new(Values.Kp);

    public static readonly CompaniesCreateAccountRequestCountryCode Kr = new(Values.Kr);

    public static readonly CompaniesCreateAccountRequestCountryCode Kw = new(Values.Kw);

    public static readonly CompaniesCreateAccountRequestCountryCode Ky = new(Values.Ky);

    public static readonly CompaniesCreateAccountRequestCountryCode Kz = new(Values.Kz);

    public static readonly CompaniesCreateAccountRequestCountryCode La = new(Values.La);

    public static readonly CompaniesCreateAccountRequestCountryCode Lb = new(Values.Lb);

    public static readonly CompaniesCreateAccountRequestCountryCode Lc = new(Values.Lc);

    public static readonly CompaniesCreateAccountRequestCountryCode Li = new(Values.Li);

    public static readonly CompaniesCreateAccountRequestCountryCode Lk = new(Values.Lk);

    public static readonly CompaniesCreateAccountRequestCountryCode Lr = new(Values.Lr);

    public static readonly CompaniesCreateAccountRequestCountryCode Ls = new(Values.Ls);

    public static readonly CompaniesCreateAccountRequestCountryCode Lt = new(Values.Lt);

    public static readonly CompaniesCreateAccountRequestCountryCode Lu = new(Values.Lu);

    public static readonly CompaniesCreateAccountRequestCountryCode Lv = new(Values.Lv);

    public static readonly CompaniesCreateAccountRequestCountryCode Ly = new(Values.Ly);

    public static readonly CompaniesCreateAccountRequestCountryCode Ma = new(Values.Ma);

    public static readonly CompaniesCreateAccountRequestCountryCode Mc = new(Values.Mc);

    public static readonly CompaniesCreateAccountRequestCountryCode Md = new(Values.Md);

    public static readonly CompaniesCreateAccountRequestCountryCode Me = new(Values.Me);

    public static readonly CompaniesCreateAccountRequestCountryCode Mf = new(Values.Mf);

    public static readonly CompaniesCreateAccountRequestCountryCode Mg = new(Values.Mg);

    public static readonly CompaniesCreateAccountRequestCountryCode Mh = new(Values.Mh);

    public static readonly CompaniesCreateAccountRequestCountryCode Mk = new(Values.Mk);

    public static readonly CompaniesCreateAccountRequestCountryCode Ml = new(Values.Ml);

    public static readonly CompaniesCreateAccountRequestCountryCode Mm = new(Values.Mm);

    public static readonly CompaniesCreateAccountRequestCountryCode Mn = new(Values.Mn);

    public static readonly CompaniesCreateAccountRequestCountryCode Mo = new(Values.Mo);

    public static readonly CompaniesCreateAccountRequestCountryCode Mp = new(Values.Mp);

    public static readonly CompaniesCreateAccountRequestCountryCode Mq = new(Values.Mq);

    public static readonly CompaniesCreateAccountRequestCountryCode Mr = new(Values.Mr);

    public static readonly CompaniesCreateAccountRequestCountryCode Ms = new(Values.Ms);

    public static readonly CompaniesCreateAccountRequestCountryCode Mt = new(Values.Mt);

    public static readonly CompaniesCreateAccountRequestCountryCode Mu = new(Values.Mu);

    public static readonly CompaniesCreateAccountRequestCountryCode Mv = new(Values.Mv);

    public static readonly CompaniesCreateAccountRequestCountryCode Mw = new(Values.Mw);

    public static readonly CompaniesCreateAccountRequestCountryCode Mx = new(Values.Mx);

    public static readonly CompaniesCreateAccountRequestCountryCode My = new(Values.My);

    public static readonly CompaniesCreateAccountRequestCountryCode Mz = new(Values.Mz);

    public static readonly CompaniesCreateAccountRequestCountryCode Na = new(Values.Na);

    public static readonly CompaniesCreateAccountRequestCountryCode Nc = new(Values.Nc);

    public static readonly CompaniesCreateAccountRequestCountryCode Ne = new(Values.Ne);

    public static readonly CompaniesCreateAccountRequestCountryCode Nf = new(Values.Nf);

    public static readonly CompaniesCreateAccountRequestCountryCode Ng = new(Values.Ng);

    public static readonly CompaniesCreateAccountRequestCountryCode Ni = new(Values.Ni);

    public static readonly CompaniesCreateAccountRequestCountryCode Nl = new(Values.Nl);

    public static readonly CompaniesCreateAccountRequestCountryCode No = new(Values.No);

    public static readonly CompaniesCreateAccountRequestCountryCode Np = new(Values.Np);

    public static readonly CompaniesCreateAccountRequestCountryCode Nr = new(Values.Nr);

    public static readonly CompaniesCreateAccountRequestCountryCode Nu = new(Values.Nu);

    public static readonly CompaniesCreateAccountRequestCountryCode Nz = new(Values.Nz);

    public static readonly CompaniesCreateAccountRequestCountryCode Om = new(Values.Om);

    public static readonly CompaniesCreateAccountRequestCountryCode Pa = new(Values.Pa);

    public static readonly CompaniesCreateAccountRequestCountryCode Pe = new(Values.Pe);

    public static readonly CompaniesCreateAccountRequestCountryCode Pf = new(Values.Pf);

    public static readonly CompaniesCreateAccountRequestCountryCode Pg = new(Values.Pg);

    public static readonly CompaniesCreateAccountRequestCountryCode Ph = new(Values.Ph);

    public static readonly CompaniesCreateAccountRequestCountryCode Pk = new(Values.Pk);

    public static readonly CompaniesCreateAccountRequestCountryCode Pl = new(Values.Pl);

    public static readonly CompaniesCreateAccountRequestCountryCode Pm = new(Values.Pm);

    public static readonly CompaniesCreateAccountRequestCountryCode Pn = new(Values.Pn);

    public static readonly CompaniesCreateAccountRequestCountryCode Pr = new(Values.Pr);

    public static readonly CompaniesCreateAccountRequestCountryCode Ps = new(Values.Ps);

    public static readonly CompaniesCreateAccountRequestCountryCode Pt = new(Values.Pt);

    public static readonly CompaniesCreateAccountRequestCountryCode Pw = new(Values.Pw);

    public static readonly CompaniesCreateAccountRequestCountryCode Py = new(Values.Py);

    public static readonly CompaniesCreateAccountRequestCountryCode Qa = new(Values.Qa);

    public static readonly CompaniesCreateAccountRequestCountryCode Re = new(Values.Re);

    public static readonly CompaniesCreateAccountRequestCountryCode Ro = new(Values.Ro);

    public static readonly CompaniesCreateAccountRequestCountryCode Rs = new(Values.Rs);

    public static readonly CompaniesCreateAccountRequestCountryCode Ru = new(Values.Ru);

    public static readonly CompaniesCreateAccountRequestCountryCode Rw = new(Values.Rw);

    public static readonly CompaniesCreateAccountRequestCountryCode Sa = new(Values.Sa);

    public static readonly CompaniesCreateAccountRequestCountryCode Sb = new(Values.Sb);

    public static readonly CompaniesCreateAccountRequestCountryCode Sc = new(Values.Sc);

    public static readonly CompaniesCreateAccountRequestCountryCode Sd = new(Values.Sd);

    public static readonly CompaniesCreateAccountRequestCountryCode Se = new(Values.Se);

    public static readonly CompaniesCreateAccountRequestCountryCode Sg = new(Values.Sg);

    public static readonly CompaniesCreateAccountRequestCountryCode Sh = new(Values.Sh);

    public static readonly CompaniesCreateAccountRequestCountryCode Si = new(Values.Si);

    public static readonly CompaniesCreateAccountRequestCountryCode Sj = new(Values.Sj);

    public static readonly CompaniesCreateAccountRequestCountryCode Sk = new(Values.Sk);

    public static readonly CompaniesCreateAccountRequestCountryCode Sl = new(Values.Sl);

    public static readonly CompaniesCreateAccountRequestCountryCode Sm = new(Values.Sm);

    public static readonly CompaniesCreateAccountRequestCountryCode Sn = new(Values.Sn);

    public static readonly CompaniesCreateAccountRequestCountryCode So = new(Values.So);

    public static readonly CompaniesCreateAccountRequestCountryCode Sr = new(Values.Sr);

    public static readonly CompaniesCreateAccountRequestCountryCode Ss = new(Values.Ss);

    public static readonly CompaniesCreateAccountRequestCountryCode St = new(Values.St);

    public static readonly CompaniesCreateAccountRequestCountryCode Sv = new(Values.Sv);

    public static readonly CompaniesCreateAccountRequestCountryCode Sx = new(Values.Sx);

    public static readonly CompaniesCreateAccountRequestCountryCode Sy = new(Values.Sy);

    public static readonly CompaniesCreateAccountRequestCountryCode Sz = new(Values.Sz);

    public static readonly CompaniesCreateAccountRequestCountryCode Tc = new(Values.Tc);

    public static readonly CompaniesCreateAccountRequestCountryCode Td = new(Values.Td);

    public static readonly CompaniesCreateAccountRequestCountryCode Tf = new(Values.Tf);

    public static readonly CompaniesCreateAccountRequestCountryCode Tg = new(Values.Tg);

    public static readonly CompaniesCreateAccountRequestCountryCode Th = new(Values.Th);

    public static readonly CompaniesCreateAccountRequestCountryCode Tj = new(Values.Tj);

    public static readonly CompaniesCreateAccountRequestCountryCode Tk = new(Values.Tk);

    public static readonly CompaniesCreateAccountRequestCountryCode Tl = new(Values.Tl);

    public static readonly CompaniesCreateAccountRequestCountryCode Tm = new(Values.Tm);

    public static readonly CompaniesCreateAccountRequestCountryCode Tn = new(Values.Tn);

    public static readonly CompaniesCreateAccountRequestCountryCode To = new(Values.To);

    public static readonly CompaniesCreateAccountRequestCountryCode Tr = new(Values.Tr);

    public static readonly CompaniesCreateAccountRequestCountryCode Tt = new(Values.Tt);

    public static readonly CompaniesCreateAccountRequestCountryCode Tv = new(Values.Tv);

    public static readonly CompaniesCreateAccountRequestCountryCode Tw = new(Values.Tw);

    public static readonly CompaniesCreateAccountRequestCountryCode Tz = new(Values.Tz);

    public static readonly CompaniesCreateAccountRequestCountryCode Ua = new(Values.Ua);

    public static readonly CompaniesCreateAccountRequestCountryCode Ug = new(Values.Ug);

    public static readonly CompaniesCreateAccountRequestCountryCode Um = new(Values.Um);

    public static readonly CompaniesCreateAccountRequestCountryCode Us = new(Values.Us);

    public static readonly CompaniesCreateAccountRequestCountryCode Uy = new(Values.Uy);

    public static readonly CompaniesCreateAccountRequestCountryCode Uz = new(Values.Uz);

    public static readonly CompaniesCreateAccountRequestCountryCode Va = new(Values.Va);

    public static readonly CompaniesCreateAccountRequestCountryCode Vc = new(Values.Vc);

    public static readonly CompaniesCreateAccountRequestCountryCode Ve = new(Values.Ve);

    public static readonly CompaniesCreateAccountRequestCountryCode Vg = new(Values.Vg);

    public static readonly CompaniesCreateAccountRequestCountryCode Vi = new(Values.Vi);

    public static readonly CompaniesCreateAccountRequestCountryCode Vn = new(Values.Vn);

    public static readonly CompaniesCreateAccountRequestCountryCode Vu = new(Values.Vu);

    public static readonly CompaniesCreateAccountRequestCountryCode Wf = new(Values.Wf);

    public static readonly CompaniesCreateAccountRequestCountryCode Ws = new(Values.Ws);

    public static readonly CompaniesCreateAccountRequestCountryCode Ye = new(Values.Ye);

    public static readonly CompaniesCreateAccountRequestCountryCode Yt = new(Values.Yt);

    public static readonly CompaniesCreateAccountRequestCountryCode Za = new(Values.Za);

    public static readonly CompaniesCreateAccountRequestCountryCode Zm = new(Values.Zm);

    public static readonly CompaniesCreateAccountRequestCountryCode Zw = new(Values.Zw);

    public CompaniesCreateAccountRequestCountryCode(string value)
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
    public static CompaniesCreateAccountRequestCountryCode FromCustom(string value)
    {
        return new CompaniesCreateAccountRequestCountryCode(value);
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
        CompaniesCreateAccountRequestCountryCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesCreateAccountRequestCountryCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesCreateAccountRequestCountryCode value) =>
        value.Value;

    public static explicit operator CompaniesCreateAccountRequestCountryCode(string value) =>
        new(value);

    internal class CompaniesCreateAccountRequestCountryCodeSerializer
        : JsonConverter<CompaniesCreateAccountRequestCountryCode>
    {
        public override CompaniesCreateAccountRequestCountryCode Read(
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
            return new CompaniesCreateAccountRequestCountryCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestCountryCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesCreateAccountRequestCountryCode ReadAsPropertyName(
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
            return new CompaniesCreateAccountRequestCountryCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestCountryCode value,
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
        public const string Ad = "AD";

        public const string Ae = "AE";

        public const string Af = "AF";

        public const string Ag = "AG";

        public const string Ai = "AI";

        public const string Al = "AL";

        public const string Am = "AM";

        public const string Ao = "AO";

        public const string Aq = "AQ";

        public const string Ar = "AR";

        public const string As = "AS";

        public const string At = "AT";

        public const string Au = "AU";

        public const string Aw = "AW";

        public const string Ax = "AX";

        public const string Az = "AZ";

        public const string Ba = "BA";

        public const string Bb = "BB";

        public const string Bd = "BD";

        public const string Be = "BE";

        public const string Bf = "BF";

        public const string Bg = "BG";

        public const string Bh = "BH";

        public const string Bi = "BI";

        public const string Bj = "BJ";

        public const string Bl = "BL";

        public const string Bm = "BM";

        public const string Bn = "BN";

        public const string Bo = "BO";

        public const string Bq = "BQ";

        public const string Br = "BR";

        public const string Bs = "BS";

        public const string Bt = "BT";

        public const string Bv = "BV";

        public const string Bw = "BW";

        public const string By = "BY";

        public const string Bz = "BZ";

        public const string Ca = "CA";

        public const string Cc = "CC";

        public const string Cd = "CD";

        public const string Cf = "CF";

        public const string Cg = "CG";

        public const string Ch = "CH";

        public const string Ci = "CI";

        public const string Ck = "CK";

        public const string Cl = "CL";

        public const string Cm = "CM";

        public const string Cn = "CN";

        public const string Co = "CO";

        public const string Cr = "CR";

        public const string Cu = "CU";

        public const string Cv = "CV";

        public const string Cw = "CW";

        public const string Cx = "CX";

        public const string Cy = "CY";

        public const string Cz = "CZ";

        public const string De = "DE";

        public const string Dj = "DJ";

        public const string Dk = "DK";

        public const string Dm = "DM";

        public const string Do = "DO";

        public const string Dz = "DZ";

        public const string Ec = "EC";

        public const string Ee = "EE";

        public const string Eg = "EG";

        public const string Eh = "EH";

        public const string Er = "ER";

        public const string Es = "ES";

        public const string Et = "ET";

        public const string Fi = "FI";

        public const string Fj = "FJ";

        public const string Fk = "FK";

        public const string Fm = "FM";

        public const string Fo = "FO";

        public const string Fr = "FR";

        public const string Ga = "GA";

        public const string Gb = "GB";

        public const string Gd = "GD";

        public const string Ge = "GE";

        public const string Gf = "GF";

        public const string Gg = "GG";

        public const string Gh = "GH";

        public const string Gi = "GI";

        public const string Gl = "GL";

        public const string Gm = "GM";

        public const string Gn = "GN";

        public const string Gp = "GP";

        public const string Gq = "GQ";

        public const string Gr = "GR";

        public const string Gs = "GS";

        public const string Gt = "GT";

        public const string Gu = "GU";

        public const string Gw = "GW";

        public const string Gy = "GY";

        public const string Hk = "HK";

        public const string Hm = "HM";

        public const string Hn = "HN";

        public const string Hr = "HR";

        public const string Ht = "HT";

        public const string Hu = "HU";

        public const string Id = "ID";

        public const string Ie = "IE";

        public const string Il = "IL";

        public const string Im = "IM";

        public const string In = "IN";

        public const string Io = "IO";

        public const string Iq = "IQ";

        public const string Ir = "IR";

        public const string Is = "IS";

        public const string It = "IT";

        public const string Je = "JE";

        public const string Jm = "JM";

        public const string Jo = "JO";

        public const string Jp = "JP";

        public const string Ke = "KE";

        public const string Kg = "KG";

        public const string Kh = "KH";

        public const string Ki = "KI";

        public const string Km = "KM";

        public const string Kn = "KN";

        public const string Kp = "KP";

        public const string Kr = "KR";

        public const string Kw = "KW";

        public const string Ky = "KY";

        public const string Kz = "KZ";

        public const string La = "LA";

        public const string Lb = "LB";

        public const string Lc = "LC";

        public const string Li = "LI";

        public const string Lk = "LK";

        public const string Lr = "LR";

        public const string Ls = "LS";

        public const string Lt = "LT";

        public const string Lu = "LU";

        public const string Lv = "LV";

        public const string Ly = "LY";

        public const string Ma = "MA";

        public const string Mc = "MC";

        public const string Md = "MD";

        public const string Me = "ME";

        public const string Mf = "MF";

        public const string Mg = "MG";

        public const string Mh = "MH";

        public const string Mk = "MK";

        public const string Ml = "ML";

        public const string Mm = "MM";

        public const string Mn = "MN";

        public const string Mo = "MO";

        public const string Mp = "MP";

        public const string Mq = "MQ";

        public const string Mr = "MR";

        public const string Ms = "MS";

        public const string Mt = "MT";

        public const string Mu = "MU";

        public const string Mv = "MV";

        public const string Mw = "MW";

        public const string Mx = "MX";

        public const string My = "MY";

        public const string Mz = "MZ";

        public const string Na = "NA";

        public const string Nc = "NC";

        public const string Ne = "NE";

        public const string Nf = "NF";

        public const string Ng = "NG";

        public const string Ni = "NI";

        public const string Nl = "NL";

        public const string No = "NO";

        public const string Np = "NP";

        public const string Nr = "NR";

        public const string Nu = "NU";

        public const string Nz = "NZ";

        public const string Om = "OM";

        public const string Pa = "PA";

        public const string Pe = "PE";

        public const string Pf = "PF";

        public const string Pg = "PG";

        public const string Ph = "PH";

        public const string Pk = "PK";

        public const string Pl = "PL";

        public const string Pm = "PM";

        public const string Pn = "PN";

        public const string Pr = "PR";

        public const string Ps = "PS";

        public const string Pt = "PT";

        public const string Pw = "PW";

        public const string Py = "PY";

        public const string Qa = "QA";

        public const string Re = "RE";

        public const string Ro = "RO";

        public const string Rs = "RS";

        public const string Ru = "RU";

        public const string Rw = "RW";

        public const string Sa = "SA";

        public const string Sb = "SB";

        public const string Sc = "SC";

        public const string Sd = "SD";

        public const string Se = "SE";

        public const string Sg = "SG";

        public const string Sh = "SH";

        public const string Si = "SI";

        public const string Sj = "SJ";

        public const string Sk = "SK";

        public const string Sl = "SL";

        public const string Sm = "SM";

        public const string Sn = "SN";

        public const string So = "SO";

        public const string Sr = "SR";

        public const string Ss = "SS";

        public const string St = "ST";

        public const string Sv = "SV";

        public const string Sx = "SX";

        public const string Sy = "SY";

        public const string Sz = "SZ";

        public const string Tc = "TC";

        public const string Td = "TD";

        public const string Tf = "TF";

        public const string Tg = "TG";

        public const string Th = "TH";

        public const string Tj = "TJ";

        public const string Tk = "TK";

        public const string Tl = "TL";

        public const string Tm = "TM";

        public const string Tn = "TN";

        public const string To = "TO";

        public const string Tr = "TR";

        public const string Tt = "TT";

        public const string Tv = "TV";

        public const string Tw = "TW";

        public const string Tz = "TZ";

        public const string Ua = "UA";

        public const string Ug = "UG";

        public const string Um = "UM";

        public const string Us = "US";

        public const string Uy = "UY";

        public const string Uz = "UZ";

        public const string Va = "VA";

        public const string Vc = "VC";

        public const string Ve = "VE";

        public const string Vg = "VG";

        public const string Vi = "VI";

        public const string Vn = "VN";

        public const string Vu = "VU";

        public const string Wf = "WF";

        public const string Ws = "WS";

        public const string Ye = "YE";

        public const string Yt = "YT";

        public const string Za = "ZA";

        public const string Zm = "ZM";

        public const string Zw = "ZW";
    }
}
