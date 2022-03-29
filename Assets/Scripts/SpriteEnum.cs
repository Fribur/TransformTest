using System.Collections.Generic;
using Chart3D.Components;

namespace Chart3D.Helper
{   
    public enum S57Symbol
    {
        ACHARE02 = 1,
        ACHARE51 = 2,
        ACHBRT07 = 3,
        ACHRES51 = 4,
        ACHRES61 = 5,
        ACHRES71 = 6,
        AIRARE02 = 7,
        BCNCAR01 = 8,
        BCNCAR02 = 9,
        BCNCAR03 = 10,
        BCNCAR04 = 11,
        BCNDEF13 = 12,
        BCNISD21 = 13,
        BCNLAT15 = 14,
        BCNLAT16 = 15,
        BCNLAT21 = 16,
        BCNLAT22 = 17,
        BCNSAW13 = 18,
        BCNSAW21 = 19,
        BCNSPP13 = 20,
        BCNSPP21 = 21,
        BOYCAR01 = 22,
        BOYCAR02 = 23,
        BOYCAR03 = 24,
        BOYCAR04 = 25,
        BOYDEF03 = 26,
        BOYISD12 = 27,
        BOYLAT13 = 28,
        BOYLAT14 = 29,
        BOYLAT23 = 30,
        BOYLAT24 = 31,
        BOYMOR11 = 32,
        BOYSAW12 = 33,
        BOYSPP11 = 34,
        BOYSPP15 = 35,
        BOYSPP25 = 36,
        BOYSPP35 = 37,
        BOYSUP02 = 38,
        BRIDGE01 = 39,
        BRTHNO01 = 40,
        BUAARE02 = 41,
        BUIREL01 = 42,
        BUIREL04 = 43,
        BUIREL05 = 44,
        BUIREL13 = 45,
        BUIREL14 = 46,
        BUIREL15 = 47,
        BUISGL01 = 48,
        BUISGL11 = 49,
        CAIRNS01 = 50,
        CAIRNS11 = 51,
        CBLARE51 = 52,
        CGUSTA02 = 53,
        CHIMNY01 = 54,
        CHIMNY11 = 55,
        CHINFO06 = 56,
        CHINFO07 = 57,
        CHKPNT01 = 58,
        CRANES01 = 59,
        CTNARE51 = 60,
        CTYARE51 = 61,
        CTYARE71 = 62,
        CURDEF01 = 63,
        CURENT01 = 64,
        DANGER01 = 65,
        DANGER02 = 66,
        DANGER03 = 67,
        DAYSQR01 = 68,
        DAYTRI01 = 69,
        DAYTRI05 = 70,
        DISMAR03 = 71,
        DISMAR04 = 72,
        DOMES001 = 73,
        DOMES011 = 74,
        DRFSTA01 = 75,
        DSHAER01 = 76,
        DSHAER11 = 77,
        DWRTPT51 = 78,
        DWRUTE51 = 79,
        EBBSTR01 = 80,
        ENTRES51 = 81,
        ENTRES61 = 82,
        ENTRES71 = 83,
        ESSARE01 = 84,
        FAIRWY51 = 85,
        FAIRWY52 = 86,
        FLASTK01 = 87,
        FLASTK11 = 88,
        FLDSTR01 = 89,
        FLGSTF01 = 90,
        FLTHAZ02 = 91,
        FOGSIG01 = 92,
        FORSTC01 = 93,
        FORSTC11 = 94,
        FOULGND1 = 95,
        FRYARE51 = 96,
        FRYARE52 = 97,
        FSHFAC02 = 98,
        FSHFAC03 = 99,
        FSHGRD01 = 100,
        FSHHAV01 = 101,
        FSHRES51 = 102,
        FSHRES61 = 103,
        FSHRES71 = 104,
        GATCON03 = 105,
        GATCON04 = 106,
        HILTOP01 = 107,
        HRBFAC09 = 108,
        HULKES01 = 109,
        INFARE51 = 110,
        ISODGR01 = 111,
        ITZARE51 = 112,
        LIGHTS11 = 113,
        LIGHTS12 = 114,
        LIGHTS13 = 115,
        LIGHTS81 = 116,
        LIGHTS82 = 117,
        LITDEF11 = 118,
        LNDARE01 = 119,
        LOCMAG01 = 120,
        LOCMAG51 = 121,
        LOWACC01 = 122,
        MAGVAR01 = 123,
        MAGVAR51 = 124,
        MARCUL02 = 125,
        MONUMT02 = 126,
        MONUMT12 = 127,
        MORFAC03 = 128,
        MORFAC04 = 129,
        MSTCON04 = 130,
        MSTCON14 = 131,
        NOTBRD11 = 132,
        OBSTRN01 = 133,
        OBSTRN03 = 134,
        OBSTRN11 = 135,
        OFSPLF01 = 136,
        PILBOP02 = 137,
        PILPNT02 = 138,
        POSGEN01 = 139,
        POSGEN03 = 140,
        POSGEN04 = 141,
        PRCARE12 = 142,
        PRCARE51 = 143,
        PRDINS02 = 144,
        PSSARE01 = 145,
        QUARRY01 = 146,
        RACNSP01 = 147,
        RADRFL03 = 148,
        RASCAN01 = 149,
        RASCAN11 = 150,
        RCLDEF01 = 151,
        RCTLPT52 = 152,
        RDOCAL02 = 153,
        RDOCAL03 = 154,
        RDOSTA02 = 155,
        RECDEF51 = 156,
        RECTRC55 = 157,
        RECTRC56 = 158,
        RECTRC57 = 159,
        RECTRC58 = 160,
        RETRFL02 = 161,
        RFNERY01 = 162,
        RFNERY11 = 163,
        ROLROL01 = 164,
        RSCSTA02 = 165,
        RSRDEF51 = 166,
        RTLDEF51 = 167,
        RTPBCN02 = 168,
        SILBUI01 = 169,
        SILBUI11 = 170,
        SISTAT02 = 171,
        SMCFAC02 = 172,
        SNDWAV02 = 173,
        TMARDEF2 = 174,
        TMBYRD01 = 175,
        TNKCON02 = 176,
        TNKCON12 = 177,
        TNKFRM01 = 178,
        TNKFRM11 = 179,
        TOPMAR02 = 180,
        TOPMAR04 = 181,
        TOPMAR05 = 182,
        TOPMAR06 = 183,
        TOPMAR07 = 184,
        TOPMAR08 = 185,
        TOPMAR10 = 186,
        TOPMAR12 = 187,
        TOPMAR13 = 188,
        TOPMAR14 = 189,
        TOPMAR16 = 190,
        TOPMAR17 = 191,
        TOPMAR18 = 192,
        TOPMAR65 = 193,
        TOWERS01 = 194,
        TOWERS02 = 195,
        TOWERS03 = 196,
        TOWERS05 = 197,
        TOWERS12 = 198,
        TOWERS15 = 199,
        TREPNT04 = 200,
        TREPNT05 = 201,
        TSLDEF51 = 202,
        TSSLPT51 = 203,
        TWRDEF51 = 204,
        TWRTPT52 = 205,
        TWRTPT53 = 206,
        UWTROC03 = 207,
        UWTROC04 = 208,
        WATTUR02 = 209,
        WEDKLP03 = 210,
        WIMCON01 = 211,
        WIMCON11 = 212,
        WNDFRM51 = 213,
        WNDFRM61 = 214,
        WNDMIL02 = 215,
        WNDMIL12 = 216,
        WRECKS01 = 217,
        WRECKS04 = 218,
        WRECKS05 = 219,
        SPRING02 = 220,
        SWPARE51 = 221,
        TIDSTR01 = 222,
        TSSCRS51 = 223,
        TSSRON51 = 224,
        LITVES02 = 225,
        LITFLT02 = 226,
        QUESMRK1 = 227,
        SectorLightDash32 = 228,
    }
    public static class SpriteSharedRef
    {
        public static S57SpriteShared ACHARE02 = new S57SpriteShared { Value = S57Symbol.ACHARE02 };
        public static S57SpriteShared ACHARE51 = new S57SpriteShared { Value = S57Symbol.ACHARE51 };
        public static S57SpriteShared ACHBRT07 = new S57SpriteShared { Value = S57Symbol.ACHBRT07 };
        public static S57SpriteShared ACHRES51 = new S57SpriteShared { Value = S57Symbol.ACHRES51 };
        public static S57SpriteShared ACHRES61 = new S57SpriteShared { Value = S57Symbol.ACHRES61 };
        public static S57SpriteShared ACHRES71 = new S57SpriteShared { Value = S57Symbol.ACHRES71 };
        public static S57SpriteShared AIRARE02 = new S57SpriteShared { Value = S57Symbol.AIRARE02 };
        public static S57SpriteShared BCNCAR01 = new S57SpriteShared { Value = S57Symbol.BCNCAR01 };
        public static S57SpriteShared BCNCAR02 = new S57SpriteShared { Value = S57Symbol.BCNCAR02 };
        public static S57SpriteShared BCNCAR03 = new S57SpriteShared { Value = S57Symbol.BCNCAR03 };
        public static S57SpriteShared BCNCAR04 = new S57SpriteShared { Value = S57Symbol.BCNCAR04 };
        public static S57SpriteShared BCNDEF13 = new S57SpriteShared { Value = S57Symbol.BCNDEF13 };
        public static S57SpriteShared BCNISD21 = new S57SpriteShared { Value = S57Symbol.BCNISD21 };
        public static S57SpriteShared BCNLAT15 = new S57SpriteShared { Value = S57Symbol.BCNLAT15 };
        public static S57SpriteShared BCNLAT16 = new S57SpriteShared { Value = S57Symbol.BCNLAT16 };
        public static S57SpriteShared BCNLAT21 = new S57SpriteShared { Value = S57Symbol.BCNLAT21 };
        public static S57SpriteShared BCNLAT22 = new S57SpriteShared { Value = S57Symbol.BCNLAT22 };
        public static S57SpriteShared BCNSAW13 = new S57SpriteShared { Value = S57Symbol.BCNSAW13 };
        public static S57SpriteShared BCNSAW21 = new S57SpriteShared { Value = S57Symbol.BCNSAW21 };
        public static S57SpriteShared BCNSPP13 = new S57SpriteShared { Value = S57Symbol.BCNSPP13 };
        public static S57SpriteShared BCNSPP21 = new S57SpriteShared { Value = S57Symbol.BCNSPP21 };
        public static S57SpriteShared BOYCAR01 = new S57SpriteShared { Value = S57Symbol.BOYCAR01 };
        public static S57SpriteShared BOYCAR02 = new S57SpriteShared { Value = S57Symbol.BOYCAR02 };
        public static S57SpriteShared BOYCAR03 = new S57SpriteShared { Value = S57Symbol.BOYCAR03 };
        public static S57SpriteShared BOYCAR04 = new S57SpriteShared { Value = S57Symbol.BOYCAR04 };
        public static S57SpriteShared BOYDEF03 = new S57SpriteShared { Value = S57Symbol.BOYDEF03 };
        public static S57SpriteShared BOYISD12 = new S57SpriteShared { Value = S57Symbol.BOYISD12 };
        public static S57SpriteShared BOYLAT13 = new S57SpriteShared { Value = S57Symbol.BOYLAT13 };
        public static S57SpriteShared BOYLAT14 = new S57SpriteShared { Value = S57Symbol.BOYLAT14 };
        public static S57SpriteShared BOYLAT23 = new S57SpriteShared { Value = S57Symbol.BOYLAT23 };
        public static S57SpriteShared BOYLAT24 = new S57SpriteShared { Value = S57Symbol.BOYLAT24 };
        public static S57SpriteShared BOYMOR11 = new S57SpriteShared { Value = S57Symbol.BOYMOR11 };
        public static S57SpriteShared BOYSAW12 = new S57SpriteShared { Value = S57Symbol.BOYSAW12 };
        public static S57SpriteShared BOYSPP11 = new S57SpriteShared { Value = S57Symbol.BOYSPP11 };
        public static S57SpriteShared BOYSPP15 = new S57SpriteShared { Value = S57Symbol.BOYSPP15 };
        public static S57SpriteShared BOYSPP25 = new S57SpriteShared { Value = S57Symbol.BOYSPP25 };
        public static S57SpriteShared BOYSPP35 = new S57SpriteShared { Value = S57Symbol.BOYSPP35 };
        public static S57SpriteShared BOYSUP02 = new S57SpriteShared { Value = S57Symbol.BOYSUP02 };
        public static S57SpriteShared BRIDGE01 = new S57SpriteShared { Value = S57Symbol.BRIDGE01 };
        public static S57SpriteShared BRTHNO01 = new S57SpriteShared { Value = S57Symbol.BRTHNO01 };
        public static S57SpriteShared BUAARE02 = new S57SpriteShared { Value = S57Symbol.BUAARE02 };
        public static S57SpriteShared BUIREL01 = new S57SpriteShared { Value = S57Symbol.BUIREL01 };
        public static S57SpriteShared BUIREL04 = new S57SpriteShared { Value = S57Symbol.BUIREL04 };
        public static S57SpriteShared BUIREL05 = new S57SpriteShared { Value = S57Symbol.BUIREL05 };
        public static S57SpriteShared BUIREL13 = new S57SpriteShared { Value = S57Symbol.BUIREL13 };
        public static S57SpriteShared BUIREL14 = new S57SpriteShared { Value = S57Symbol.BUIREL14 };
        public static S57SpriteShared BUIREL15 = new S57SpriteShared { Value = S57Symbol.BUIREL15 };
        public static S57SpriteShared BUISGL01 = new S57SpriteShared { Value = S57Symbol.BUISGL01 };
        public static S57SpriteShared BUISGL11 = new S57SpriteShared { Value = S57Symbol.BUISGL11 };
        public static S57SpriteShared CAIRNS01 = new S57SpriteShared { Value = S57Symbol.CAIRNS01 };
        public static S57SpriteShared CAIRNS11 = new S57SpriteShared { Value = S57Symbol.CAIRNS11 };
        public static S57SpriteShared CBLARE51 = new S57SpriteShared { Value = S57Symbol.CBLARE51 };
        public static S57SpriteShared CGUSTA02 = new S57SpriteShared { Value = S57Symbol.CGUSTA02 };
        public static S57SpriteShared CHIMNY01 = new S57SpriteShared { Value = S57Symbol.CHIMNY01 };
        public static S57SpriteShared CHIMNY11 = new S57SpriteShared { Value = S57Symbol.CHIMNY11 };
        public static S57SpriteShared CHINFO06 = new S57SpriteShared { Value = S57Symbol.CHINFO06 };
        public static S57SpriteShared CHINFO07 = new S57SpriteShared { Value = S57Symbol.CHINFO07 };
        public static S57SpriteShared CHKPNT01 = new S57SpriteShared { Value = S57Symbol.CHKPNT01 };
        public static S57SpriteShared CRANES01 = new S57SpriteShared { Value = S57Symbol.CRANES01 };
        public static S57SpriteShared CTNARE51 = new S57SpriteShared { Value = S57Symbol.CTNARE51 };
        public static S57SpriteShared CTYARE51 = new S57SpriteShared { Value = S57Symbol.CTYARE51 };
        public static S57SpriteShared CTYARE71 = new S57SpriteShared { Value = S57Symbol.CTYARE71 };
        public static S57SpriteShared CURDEF01 = new S57SpriteShared { Value = S57Symbol.CURDEF01 };
        public static S57SpriteShared CURENT01 = new S57SpriteShared { Value = S57Symbol.CURENT01 };
        public static S57SpriteShared DANGER01 = new S57SpriteShared { Value = S57Symbol.DANGER01 };
        public static S57SpriteShared DANGER02 = new S57SpriteShared { Value = S57Symbol.DANGER02 };
        public static S57SpriteShared DANGER03 = new S57SpriteShared { Value = S57Symbol.DANGER03 };
        public static S57SpriteShared DAYSQR01 = new S57SpriteShared { Value = S57Symbol.DAYSQR01 };
        public static S57SpriteShared DAYTRI01 = new S57SpriteShared { Value = S57Symbol.DAYTRI01 };
        public static S57SpriteShared DAYTRI05 = new S57SpriteShared { Value = S57Symbol.DAYTRI05 };
        public static S57SpriteShared DISMAR03 = new S57SpriteShared { Value = S57Symbol.DISMAR03 };
        public static S57SpriteShared DISMAR04 = new S57SpriteShared { Value = S57Symbol.DISMAR04 };
        public static S57SpriteShared DOMES001 = new S57SpriteShared { Value = S57Symbol.DOMES001 };
        public static S57SpriteShared DOMES011 = new S57SpriteShared { Value = S57Symbol.DOMES011 };
        public static S57SpriteShared DRFSTA01 = new S57SpriteShared { Value = S57Symbol.DRFSTA01 };
        public static S57SpriteShared DSHAER01 = new S57SpriteShared { Value = S57Symbol.DSHAER01 };
        public static S57SpriteShared DSHAER11 = new S57SpriteShared { Value = S57Symbol.DSHAER11 };
        public static S57SpriteShared DWRTPT51 = new S57SpriteShared { Value = S57Symbol.DWRTPT51 };
        public static S57SpriteShared DWRUTE51 = new S57SpriteShared { Value = S57Symbol.DWRUTE51 };
        public static S57SpriteShared EBBSTR01 = new S57SpriteShared { Value = S57Symbol.EBBSTR01 };
        public static S57SpriteShared ENTRES51 = new S57SpriteShared { Value = S57Symbol.ENTRES51 };
        public static S57SpriteShared ENTRES61 = new S57SpriteShared { Value = S57Symbol.ENTRES61 };
        public static S57SpriteShared ENTRES71 = new S57SpriteShared { Value = S57Symbol.ENTRES71 };
        public static S57SpriteShared ESSARE01 = new S57SpriteShared { Value = S57Symbol.ESSARE01 };
        public static S57SpriteShared FAIRWY51 = new S57SpriteShared { Value = S57Symbol.FAIRWY51 };
        public static S57SpriteShared FAIRWY52 = new S57SpriteShared { Value = S57Symbol.FAIRWY52 };
        public static S57SpriteShared FLASTK01 = new S57SpriteShared { Value = S57Symbol.FLASTK01 };
        public static S57SpriteShared FLASTK11 = new S57SpriteShared { Value = S57Symbol.FLASTK11 };
        public static S57SpriteShared FLDSTR01 = new S57SpriteShared { Value = S57Symbol.FLDSTR01 };
        public static S57SpriteShared FLGSTF01 = new S57SpriteShared { Value = S57Symbol.FLGSTF01 };
        public static S57SpriteShared FLTHAZ02 = new S57SpriteShared { Value = S57Symbol.FLTHAZ02 };
        public static S57SpriteShared FOGSIG01 = new S57SpriteShared { Value = S57Symbol.FOGSIG01 };
        public static S57SpriteShared FORSTC01 = new S57SpriteShared { Value = S57Symbol.FORSTC01 };
        public static S57SpriteShared FORSTC11 = new S57SpriteShared { Value = S57Symbol.FORSTC11 };
        public static S57SpriteShared FOULGND1 = new S57SpriteShared { Value = S57Symbol.FOULGND1 };
        public static S57SpriteShared FRYARE51 = new S57SpriteShared { Value = S57Symbol.FRYARE51 };
        public static S57SpriteShared FRYARE52 = new S57SpriteShared { Value = S57Symbol.FRYARE52 };
        public static S57SpriteShared FSHFAC02 = new S57SpriteShared { Value = S57Symbol.FSHFAC02 };
        public static S57SpriteShared FSHFAC03 = new S57SpriteShared { Value = S57Symbol.FSHFAC03 };
        public static S57SpriteShared FSHGRD01 = new S57SpriteShared { Value = S57Symbol.FSHGRD01 };
        public static S57SpriteShared FSHHAV01 = new S57SpriteShared { Value = S57Symbol.FSHHAV01 };
        public static S57SpriteShared FSHRES51 = new S57SpriteShared { Value = S57Symbol.FSHRES51 };
        public static S57SpriteShared FSHRES61 = new S57SpriteShared { Value = S57Symbol.FSHRES61 };
        public static S57SpriteShared FSHRES71 = new S57SpriteShared { Value = S57Symbol.FSHRES71 };
        public static S57SpriteShared GATCON03 = new S57SpriteShared { Value = S57Symbol.GATCON03 };
        public static S57SpriteShared GATCON04 = new S57SpriteShared { Value = S57Symbol.GATCON04 };
        public static S57SpriteShared HILTOP01 = new S57SpriteShared { Value = S57Symbol.HILTOP01 };
        public static S57SpriteShared HRBFAC09 = new S57SpriteShared { Value = S57Symbol.HRBFAC09 };
        public static S57SpriteShared HULKES01 = new S57SpriteShared { Value = S57Symbol.HULKES01 };
        public static S57SpriteShared INFARE51 = new S57SpriteShared { Value = S57Symbol.INFARE51 };
        public static S57SpriteShared ISODGR01 = new S57SpriteShared { Value = S57Symbol.ISODGR01 };
        public static S57SpriteShared ITZARE51 = new S57SpriteShared { Value = S57Symbol.ITZARE51 };
        public static S57SpriteShared LIGHTS11 = new S57SpriteShared { Value = S57Symbol.LIGHTS11 };
        public static S57SpriteShared LIGHTS12 = new S57SpriteShared { Value = S57Symbol.LIGHTS12 };
        public static S57SpriteShared LIGHTS13 = new S57SpriteShared { Value = S57Symbol.LIGHTS13 };
        public static S57SpriteShared LIGHTS81 = new S57SpriteShared { Value = S57Symbol.LIGHTS81 };
        public static S57SpriteShared LIGHTS82 = new S57SpriteShared { Value = S57Symbol.LIGHTS82 };
        public static S57SpriteShared LITDEF11 = new S57SpriteShared { Value = S57Symbol.LITDEF11 };
        public static S57SpriteShared LNDARE01 = new S57SpriteShared { Value = S57Symbol.LNDARE01 };
        public static S57SpriteShared LOCMAG01 = new S57SpriteShared { Value = S57Symbol.LOCMAG01 };
        public static S57SpriteShared LOCMAG51 = new S57SpriteShared { Value = S57Symbol.LOCMAG51 };
        public static S57SpriteShared LOWACC01 = new S57SpriteShared { Value = S57Symbol.LOWACC01 };
        public static S57SpriteShared MAGVAR01 = new S57SpriteShared { Value = S57Symbol.MAGVAR01 };
        public static S57SpriteShared MAGVAR51 = new S57SpriteShared { Value = S57Symbol.MAGVAR51 };
        public static S57SpriteShared MARCUL02 = new S57SpriteShared { Value = S57Symbol.MARCUL02 };
        public static S57SpriteShared MONUMT02 = new S57SpriteShared { Value = S57Symbol.MONUMT02 };
        public static S57SpriteShared MONUMT12 = new S57SpriteShared { Value = S57Symbol.MONUMT12 };
        public static S57SpriteShared MORFAC03 = new S57SpriteShared { Value = S57Symbol.MORFAC03 };
        public static S57SpriteShared MORFAC04 = new S57SpriteShared { Value = S57Symbol.MORFAC04 };
        public static S57SpriteShared MSTCON04 = new S57SpriteShared { Value = S57Symbol.MSTCON04 };
        public static S57SpriteShared MSTCON14 = new S57SpriteShared { Value = S57Symbol.MSTCON14 };
        public static S57SpriteShared NOTBRD11 = new S57SpriteShared { Value = S57Symbol.NOTBRD11 };
        public static S57SpriteShared OBSTRN01 = new S57SpriteShared { Value = S57Symbol.OBSTRN01 };
        public static S57SpriteShared OBSTRN03 = new S57SpriteShared { Value = S57Symbol.OBSTRN03 };
        public static S57SpriteShared OBSTRN11 = new S57SpriteShared { Value = S57Symbol.OBSTRN11 };
        public static S57SpriteShared OFSPLF01 = new S57SpriteShared { Value = S57Symbol.OFSPLF01 };
        public static S57SpriteShared PILBOP02 = new S57SpriteShared { Value = S57Symbol.PILBOP02 };
        public static S57SpriteShared PILPNT02 = new S57SpriteShared { Value = S57Symbol.PILPNT02 };
        public static S57SpriteShared POSGEN01 = new S57SpriteShared { Value = S57Symbol.POSGEN01 };
        public static S57SpriteShared POSGEN03 = new S57SpriteShared { Value = S57Symbol.POSGEN03 };
        public static S57SpriteShared POSGEN04 = new S57SpriteShared { Value = S57Symbol.POSGEN04 };
        public static S57SpriteShared PRCARE12 = new S57SpriteShared { Value = S57Symbol.PRCARE12 };
        public static S57SpriteShared PRCARE51 = new S57SpriteShared { Value = S57Symbol.PRCARE51 };
        public static S57SpriteShared PRDINS02 = new S57SpriteShared { Value = S57Symbol.PRDINS02 };
        public static S57SpriteShared PSSARE01 = new S57SpriteShared { Value = S57Symbol.PSSARE01 };
        public static S57SpriteShared QUARRY01 = new S57SpriteShared { Value = S57Symbol.QUARRY01 };
        public static S57SpriteShared RACNSP01 = new S57SpriteShared { Value = S57Symbol.RACNSP01 };
        public static S57SpriteShared RADRFL03 = new S57SpriteShared { Value = S57Symbol.RADRFL03 };
        public static S57SpriteShared RASCAN01 = new S57SpriteShared { Value = S57Symbol.RASCAN01 };
        public static S57SpriteShared RASCAN11 = new S57SpriteShared { Value = S57Symbol.RASCAN11 };
        public static S57SpriteShared RCLDEF01 = new S57SpriteShared { Value = S57Symbol.RCLDEF01 };
        public static S57SpriteShared RCTLPT52 = new S57SpriteShared { Value = S57Symbol.RCTLPT52 };
        public static S57SpriteShared RDOCAL02 = new S57SpriteShared { Value = S57Symbol.RDOCAL02 };
        public static S57SpriteShared RDOCAL03 = new S57SpriteShared { Value = S57Symbol.RDOCAL03 };
        public static S57SpriteShared RDOSTA02 = new S57SpriteShared { Value = S57Symbol.RDOSTA02 };
        public static S57SpriteShared RECDEF51 = new S57SpriteShared { Value = S57Symbol.RECDEF51 };
        public static S57SpriteShared RECTRC55 = new S57SpriteShared { Value = S57Symbol.RECTRC55 };
        public static S57SpriteShared RECTRC56 = new S57SpriteShared { Value = S57Symbol.RECTRC56 };
        public static S57SpriteShared RECTRC57 = new S57SpriteShared { Value = S57Symbol.RECTRC57 };
        public static S57SpriteShared RECTRC58 = new S57SpriteShared { Value = S57Symbol.RECTRC58 };
        public static S57SpriteShared RETRFL02 = new S57SpriteShared { Value = S57Symbol.RETRFL02 };
        public static S57SpriteShared RFNERY01 = new S57SpriteShared { Value = S57Symbol.RFNERY01 };
        public static S57SpriteShared RFNERY11 = new S57SpriteShared { Value = S57Symbol.RFNERY11 };
        public static S57SpriteShared ROLROL01 = new S57SpriteShared { Value = S57Symbol.ROLROL01 };
        public static S57SpriteShared RSCSTA02 = new S57SpriteShared { Value = S57Symbol.RSCSTA02 };
        public static S57SpriteShared RSRDEF51 = new S57SpriteShared { Value = S57Symbol.RSRDEF51 };
        public static S57SpriteShared RTLDEF51 = new S57SpriteShared { Value = S57Symbol.RTLDEF51 };
        public static S57SpriteShared RTPBCN02 = new S57SpriteShared { Value = S57Symbol.RTPBCN02 };
        public static S57SpriteShared SILBUI01 = new S57SpriteShared { Value = S57Symbol.SILBUI01 };
        public static S57SpriteShared SILBUI11 = new S57SpriteShared { Value = S57Symbol.SILBUI11 };
        public static S57SpriteShared SISTAT02 = new S57SpriteShared { Value = S57Symbol.SISTAT02 };
        public static S57SpriteShared SMCFAC02 = new S57SpriteShared { Value = S57Symbol.SMCFAC02 };
        public static S57SpriteShared SNDWAV02 = new S57SpriteShared { Value = S57Symbol.SNDWAV02 };
        public static S57SpriteShared TMARDEF2 = new S57SpriteShared { Value = S57Symbol.TMARDEF2 };
        public static S57SpriteShared TMBYRD01 = new S57SpriteShared { Value = S57Symbol.TMBYRD01 };
        public static S57SpriteShared TNKCON02 = new S57SpriteShared { Value = S57Symbol.TNKCON02 };
        public static S57SpriteShared TNKCON12 = new S57SpriteShared { Value = S57Symbol.TNKCON12 };
        public static S57SpriteShared TNKFRM01 = new S57SpriteShared { Value = S57Symbol.TNKFRM01 };
        public static S57SpriteShared TNKFRM11 = new S57SpriteShared { Value = S57Symbol.TNKFRM11 };
        public static S57SpriteShared TOPMAR02 = new S57SpriteShared { Value = S57Symbol.TOPMAR02 };
        public static S57SpriteShared TOPMAR04 = new S57SpriteShared { Value = S57Symbol.TOPMAR04 };
        public static S57SpriteShared TOPMAR05 = new S57SpriteShared { Value = S57Symbol.TOPMAR05 };
        public static S57SpriteShared TOPMAR06 = new S57SpriteShared { Value = S57Symbol.TOPMAR06 };
        public static S57SpriteShared TOPMAR07 = new S57SpriteShared { Value = S57Symbol.TOPMAR07 };
        public static S57SpriteShared TOPMAR08 = new S57SpriteShared { Value = S57Symbol.TOPMAR08 };
        public static S57SpriteShared TOPMAR10 = new S57SpriteShared { Value = S57Symbol.TOPMAR10 };
        public static S57SpriteShared TOPMAR12 = new S57SpriteShared { Value = S57Symbol.TOPMAR12 };
        public static S57SpriteShared TOPMAR13 = new S57SpriteShared { Value = S57Symbol.TOPMAR13 };
        public static S57SpriteShared TOPMAR14 = new S57SpriteShared { Value = S57Symbol.TOPMAR14 };
        public static S57SpriteShared TOPMAR16 = new S57SpriteShared { Value = S57Symbol.TOPMAR16 };
        public static S57SpriteShared TOPMAR17 = new S57SpriteShared { Value = S57Symbol.TOPMAR17 };
        public static S57SpriteShared TOPMAR18 = new S57SpriteShared { Value = S57Symbol.TOPMAR18 };
        public static S57SpriteShared TOPMAR65 = new S57SpriteShared { Value = S57Symbol.TOPMAR65 };
        public static S57SpriteShared TOWERS01 = new S57SpriteShared { Value = S57Symbol.TOWERS01 };
        public static S57SpriteShared TOWERS02 = new S57SpriteShared { Value = S57Symbol.TOWERS02 };
        public static S57SpriteShared TOWERS03 = new S57SpriteShared { Value = S57Symbol.TOWERS03 };
        public static S57SpriteShared TOWERS05 = new S57SpriteShared { Value = S57Symbol.TOWERS05 };
        public static S57SpriteShared TOWERS12 = new S57SpriteShared { Value = S57Symbol.TOWERS12 };
        public static S57SpriteShared TOWERS15 = new S57SpriteShared { Value = S57Symbol.TOWERS15 };
        public static S57SpriteShared TREPNT04 = new S57SpriteShared { Value = S57Symbol.TREPNT04 };
        public static S57SpriteShared TREPNT05 = new S57SpriteShared { Value = S57Symbol.TREPNT05 };
        public static S57SpriteShared TSLDEF51 = new S57SpriteShared { Value = S57Symbol.TSLDEF51 };
        public static S57SpriteShared TSSLPT51 = new S57SpriteShared { Value = S57Symbol.TSSLPT51 };
        public static S57SpriteShared TWRDEF51 = new S57SpriteShared { Value = S57Symbol.TWRDEF51 };
        public static S57SpriteShared TWRTPT52 = new S57SpriteShared { Value = S57Symbol.TWRTPT52 };
        public static S57SpriteShared TWRTPT53 = new S57SpriteShared { Value = S57Symbol.TWRTPT53 };
        public static S57SpriteShared UWTROC03 = new S57SpriteShared { Value = S57Symbol.UWTROC03 };
        public static S57SpriteShared UWTROC04 = new S57SpriteShared { Value = S57Symbol.UWTROC04 };
        public static S57SpriteShared WATTUR02 = new S57SpriteShared { Value = S57Symbol.WATTUR02 };
        public static S57SpriteShared WEDKLP03 = new S57SpriteShared { Value = S57Symbol.WEDKLP03 };
        public static S57SpriteShared WIMCON01 = new S57SpriteShared { Value = S57Symbol.WIMCON01 };
        public static S57SpriteShared WIMCON11 = new S57SpriteShared { Value = S57Symbol.WIMCON11 };
        public static S57SpriteShared WNDFRM51 = new S57SpriteShared { Value = S57Symbol.WNDFRM51 };
        public static S57SpriteShared WNDFRM61 = new S57SpriteShared { Value = S57Symbol.WNDFRM61 };
        public static S57SpriteShared WNDMIL02 = new S57SpriteShared { Value = S57Symbol.WNDMIL02 };
        public static S57SpriteShared WNDMIL12 = new S57SpriteShared { Value = S57Symbol.WNDMIL12 };
        public static S57SpriteShared WRECKS01 = new S57SpriteShared { Value = S57Symbol.WRECKS01 };
        public static S57SpriteShared WRECKS04 = new S57SpriteShared { Value = S57Symbol.WRECKS04 };
        public static S57SpriteShared WRECKS05 = new S57SpriteShared { Value = S57Symbol.WRECKS05 };
        public static S57SpriteShared SPRING02 = new S57SpriteShared { Value = S57Symbol.SPRING02 };
        public static S57SpriteShared SWPARE51 = new S57SpriteShared { Value = S57Symbol.SWPARE51 };
        public static S57SpriteShared TIDSTR01 = new S57SpriteShared { Value = S57Symbol.TIDSTR01 };
        public static S57SpriteShared TSSCRS51 = new S57SpriteShared { Value = S57Symbol.TSSCRS51 };
        public static S57SpriteShared TSSRON51 = new S57SpriteShared { Value = S57Symbol.TSSRON51 };
        public static S57SpriteShared LITVES02 = new S57SpriteShared { Value = S57Symbol.LITVES02 };
        public static S57SpriteShared LITFLT02 = new S57SpriteShared { Value = S57Symbol.LITFLT02 };
        public static S57SpriteShared QUESMRK1 = new S57SpriteShared { Value = S57Symbol.QUESMRK1 };
        public static S57SpriteShared SectorLightDash32 = new S57SpriteShared { Value = S57Symbol.SectorLightDash32 };

        public static Dictionary<S57Symbol, S57SpriteShared> SpriteSharedComponent = new Dictionary<S57Symbol, S57SpriteShared>
        {
            {S57Symbol.ACHARE02,  ACHARE02 },
            {S57Symbol.ACHARE51,  ACHARE51 },
            {S57Symbol.ACHBRT07,  ACHBRT07 },
            {S57Symbol.ACHRES51,  ACHRES51 },
            {S57Symbol.ACHRES61,  ACHRES61 },
            {S57Symbol.ACHRES71,  ACHRES71 },
            {S57Symbol.AIRARE02,  AIRARE02 },
            {S57Symbol.BCNCAR01,  BCNCAR01 },
            {S57Symbol.BCNCAR02,  BCNCAR02 },
            {S57Symbol.BCNCAR03,  BCNCAR03 },
            {S57Symbol.BCNCAR04,  BCNCAR04 },
            {S57Symbol.BCNDEF13,  BCNDEF13 },
            {S57Symbol.BCNISD21,  BCNISD21 },
            {S57Symbol.BCNLAT15,  BCNLAT15 },
            {S57Symbol.BCNLAT16,  BCNLAT16 },
            {S57Symbol.BCNLAT21,  BCNLAT21 },
            {S57Symbol.BCNLAT22,  BCNLAT22 },
            {S57Symbol.BCNSAW13,  BCNSAW13 },
            {S57Symbol.BCNSAW21,  BCNSAW21 },
            {S57Symbol.BCNSPP13,  BCNSPP13 },
            {S57Symbol.BCNSPP21,  BCNSPP21 },
            {S57Symbol.BOYCAR01,  BOYCAR01 },
            {S57Symbol.BOYCAR02,  BOYCAR02 },
            {S57Symbol.BOYCAR03,  BOYCAR03 },
            {S57Symbol.BOYCAR04,  BOYCAR04 },
            {S57Symbol.BOYDEF03,  BOYDEF03 },
            {S57Symbol.BOYISD12,  BOYISD12 },
            {S57Symbol.BOYLAT13,  BOYLAT13 },
            {S57Symbol.BOYLAT14,  BOYLAT14 },
            {S57Symbol.BOYLAT23,  BOYLAT23 },
            {S57Symbol.BOYLAT24,  BOYLAT24 },
            {S57Symbol.BOYMOR11,  BOYMOR11 },
            {S57Symbol.BOYSAW12,  BOYSAW12 },
            {S57Symbol.BOYSPP11,  BOYSPP11 },
            {S57Symbol.BOYSPP15,  BOYSPP15 },
            {S57Symbol.BOYSPP25,  BOYSPP25 },
            {S57Symbol.BOYSPP35,  BOYSPP35 },
            {S57Symbol.BOYSUP02,  BOYSUP02 },
            {S57Symbol.BRIDGE01,  BRIDGE01 },
            {S57Symbol.BRTHNO01,  BRTHNO01 },
            {S57Symbol.BUAARE02,  BUAARE02 },
            {S57Symbol.BUIREL01,  BUIREL01 },
            {S57Symbol.BUIREL04,  BUIREL04 },
            {S57Symbol.BUIREL05,  BUIREL05 },
            {S57Symbol.BUIREL13,  BUIREL13 },
            {S57Symbol.BUIREL14,  BUIREL14 },
            {S57Symbol.BUIREL15,  BUIREL15 },
            {S57Symbol.BUISGL01,  BUISGL01 },
            {S57Symbol.BUISGL11,  BUISGL11 },
            {S57Symbol.CAIRNS01,  CAIRNS01 },
            {S57Symbol.CAIRNS11,  CAIRNS11 },
            {S57Symbol.CBLARE51,  CBLARE51 },
            {S57Symbol.CGUSTA02,  CGUSTA02 },
            {S57Symbol.CHIMNY01,  CHIMNY01 },
            {S57Symbol.CHIMNY11,  CHIMNY11 },
            {S57Symbol.CHINFO06,  CHINFO06 },
            {S57Symbol.CHINFO07,  CHINFO07 },
            {S57Symbol.CHKPNT01,  CHKPNT01 },
            {S57Symbol.CRANES01,  CRANES01 },
            {S57Symbol.CTNARE51,  CTNARE51 },
            {S57Symbol.CTYARE51,  CTYARE51 },
            {S57Symbol.CTYARE71,  CTYARE71 },
            {S57Symbol.CURDEF01,  CURDEF01 },
            {S57Symbol.CURENT01,  CURENT01 },
            {S57Symbol.DANGER01,  DANGER01 },
            {S57Symbol.DANGER02,  DANGER02 },
            {S57Symbol.DANGER03,  DANGER03 },
            {S57Symbol.DAYSQR01,  DAYSQR01 },
            {S57Symbol.DAYTRI01,  DAYTRI01 },
            {S57Symbol.DAYTRI05,  DAYTRI05 },
            {S57Symbol.DISMAR03,  DISMAR03 },
            {S57Symbol.DISMAR04,  DISMAR04 },
            {S57Symbol.DOMES001,  DOMES001 },
            {S57Symbol.DOMES011,  DOMES011 },
            {S57Symbol.DRFSTA01,  DRFSTA01 },
            {S57Symbol.DSHAER01,  DSHAER01 },
            {S57Symbol.DSHAER11,  DSHAER11 },
            {S57Symbol.DWRTPT51,  DWRTPT51 },
            {S57Symbol.DWRUTE51,  DWRUTE51 },
            {S57Symbol.EBBSTR01,  EBBSTR01 },
            {S57Symbol.ENTRES51,  ENTRES51 },
            {S57Symbol.ENTRES61,  ENTRES61 },
            {S57Symbol.ENTRES71,  ENTRES71 },
            {S57Symbol.ESSARE01,  ESSARE01 },
            {S57Symbol.FAIRWY51,  FAIRWY51 },
            {S57Symbol.FAIRWY52,  FAIRWY52 },
            {S57Symbol.FLASTK01,  FLASTK01 },
            {S57Symbol.FLASTK11,  FLASTK11 },
            {S57Symbol.FLDSTR01,  FLDSTR01 },
            {S57Symbol.FLGSTF01,  FLGSTF01 },
            {S57Symbol.FLTHAZ02,  FLTHAZ02 },
            {S57Symbol.FOGSIG01,  FOGSIG01 },
            {S57Symbol.FORSTC01,  FORSTC01 },
            {S57Symbol.FORSTC11,  FORSTC11 },
            {S57Symbol.FOULGND1,  FOULGND1 },
            {S57Symbol.FRYARE51,  FRYARE51 },
            {S57Symbol.FRYARE52,  FRYARE52 },
            {S57Symbol.FSHFAC02,  FSHFAC02 },
            {S57Symbol.FSHFAC03,  FSHFAC03 },
            {S57Symbol.FSHGRD01,  FSHGRD01 },
            {S57Symbol.FSHHAV01,  FSHHAV01 },
            {S57Symbol.FSHRES51,  FSHRES51 },
            {S57Symbol.FSHRES61,  FSHRES61 },
            {S57Symbol.FSHRES71,  FSHRES71 },
            {S57Symbol.GATCON03,  GATCON03 },
            {S57Symbol.GATCON04,  GATCON04 },
            {S57Symbol.HILTOP01,  HILTOP01 },
            {S57Symbol.HRBFAC09,  HRBFAC09 },
            {S57Symbol.HULKES01,  HULKES01 },
            {S57Symbol.INFARE51,  INFARE51 },
            {S57Symbol.ISODGR01,  ISODGR01 },
            {S57Symbol.ITZARE51,  ITZARE51 },
            {S57Symbol.LIGHTS11,  LIGHTS11 },
            {S57Symbol.LIGHTS12,  LIGHTS12 },
            {S57Symbol.LIGHTS13,  LIGHTS13 },
            {S57Symbol.LIGHTS81,  LIGHTS81 },
            {S57Symbol.LIGHTS82,  LIGHTS82 },
            {S57Symbol.LITDEF11,  LITDEF11 },
            {S57Symbol.LNDARE01,  LNDARE01 },
            {S57Symbol.LOCMAG01,  LOCMAG01 },
            {S57Symbol.LOCMAG51,  LOCMAG51 },
            {S57Symbol.LOWACC01,  LOWACC01 },
            {S57Symbol.MAGVAR01,  MAGVAR01 },
            {S57Symbol.MAGVAR51,  MAGVAR51 },
            {S57Symbol.MARCUL02,  MARCUL02 },
            {S57Symbol.MONUMT02,  MONUMT02 },
            {S57Symbol.MONUMT12,  MONUMT12 },
            {S57Symbol.MORFAC03,  MORFAC03 },
            {S57Symbol.MORFAC04,  MORFAC04 },
            {S57Symbol.MSTCON04,  MSTCON04 },
            {S57Symbol.MSTCON14,  MSTCON14 },
            {S57Symbol.NOTBRD11,  NOTBRD11 },
            {S57Symbol.OBSTRN01,  OBSTRN01 },
            {S57Symbol.OBSTRN03,  OBSTRN03 },
            {S57Symbol.OBSTRN11,  OBSTRN11 },
            {S57Symbol.OFSPLF01,  OFSPLF01 },
            {S57Symbol.PILBOP02,  PILBOP02 },
            {S57Symbol.PILPNT02,  PILPNT02 },
            {S57Symbol.POSGEN01,  POSGEN01 },
            {S57Symbol.POSGEN03,  POSGEN03 },
            {S57Symbol.POSGEN04,  POSGEN04 },
            {S57Symbol.PRCARE12,  PRCARE12 },
            {S57Symbol.PRCARE51,  PRCARE51 },
            {S57Symbol.PRDINS02,  PRDINS02 },
            {S57Symbol.PSSARE01,  PSSARE01 },
            {S57Symbol.QUARRY01,  QUARRY01 },
            {S57Symbol.RACNSP01,  RACNSP01 },
            {S57Symbol.RADRFL03,  RADRFL03 },
            {S57Symbol.RASCAN01,  RASCAN01 },
            {S57Symbol.RASCAN11,  RASCAN11 },
            {S57Symbol.RCLDEF01,  RCLDEF01 },
            {S57Symbol.RCTLPT52,  RCTLPT52 },
            {S57Symbol.RDOCAL02,  RDOCAL02 },
            {S57Symbol.RDOCAL03,  RDOCAL03 },
            {S57Symbol.RDOSTA02,  RDOSTA02 },
            {S57Symbol.RECDEF51,  RECDEF51 },
            {S57Symbol.RECTRC55,  RECTRC55 },
            {S57Symbol.RECTRC56,  RECTRC56 },
            {S57Symbol.RECTRC57,  RECTRC57 },
            {S57Symbol.RECTRC58,  RECTRC58 },
            {S57Symbol.RETRFL02,  RETRFL02 },
            {S57Symbol.RFNERY01,  RFNERY01 },
            {S57Symbol.RFNERY11,  RFNERY11 },
            {S57Symbol.ROLROL01,  ROLROL01 },
            {S57Symbol.RSCSTA02,  RSCSTA02 },
            {S57Symbol.RSRDEF51,  RSRDEF51 },
            {S57Symbol.RTLDEF51,  RTLDEF51 },
            {S57Symbol.RTPBCN02,  RTPBCN02 },
            {S57Symbol.SILBUI01,  SILBUI01 },
            {S57Symbol.SILBUI11,  SILBUI11 },
            {S57Symbol.SISTAT02,  SISTAT02 },
            {S57Symbol.SMCFAC02,  SMCFAC02 },
            {S57Symbol.SNDWAV02,  SNDWAV02 },
            {S57Symbol.TMARDEF2,  TMARDEF2 },
            {S57Symbol.TMBYRD01,  TMBYRD01 },
            {S57Symbol.TNKCON02,  TNKCON02 },
            {S57Symbol.TNKCON12,  TNKCON12 },
            {S57Symbol.TNKFRM01,  TNKFRM01 },
            {S57Symbol.TNKFRM11,  TNKFRM11 },
            {S57Symbol.TOPMAR02,  TOPMAR02 },
            {S57Symbol.TOPMAR04,  TOPMAR04 },
            {S57Symbol.TOPMAR05,  TOPMAR05 },
            {S57Symbol.TOPMAR06,  TOPMAR06 },
            {S57Symbol.TOPMAR07,  TOPMAR07 },
            {S57Symbol.TOPMAR08,  TOPMAR08 },
            {S57Symbol.TOPMAR10,  TOPMAR10 },
            {S57Symbol.TOPMAR12,  TOPMAR12 },
            {S57Symbol.TOPMAR13,  TOPMAR13 },
            {S57Symbol.TOPMAR14,  TOPMAR14 },
            {S57Symbol.TOPMAR16,  TOPMAR16 },
            {S57Symbol.TOPMAR17,  TOPMAR17 },
            {S57Symbol.TOPMAR18,  TOPMAR18 },
            {S57Symbol.TOPMAR65,  TOPMAR65 },
            {S57Symbol.TOWERS01,  TOWERS01 },
            {S57Symbol.TOWERS02,  TOWERS02 },
            {S57Symbol.TOWERS03,  TOWERS03 },
            {S57Symbol.TOWERS05,  TOWERS05 },
            {S57Symbol.TOWERS12,  TOWERS12 },
            {S57Symbol.TOWERS15,  TOWERS15 },
            {S57Symbol.TREPNT04,  TREPNT04 },
            {S57Symbol.TREPNT05,  TREPNT05 },
            {S57Symbol.TSLDEF51,  TSLDEF51 },
            {S57Symbol.TSSLPT51,  TSSLPT51 },
            {S57Symbol.TWRDEF51,  TWRDEF51 },
            {S57Symbol.TWRTPT52,  TWRTPT52 },
            {S57Symbol.TWRTPT53,  TWRTPT53 },
            {S57Symbol.UWTROC03,  UWTROC03 },
            {S57Symbol.UWTROC04,  UWTROC04 },
            {S57Symbol.WATTUR02,  WATTUR02 },
            {S57Symbol.WEDKLP03,  WEDKLP03 },
            {S57Symbol.WIMCON01,  WIMCON01 },
            {S57Symbol.WIMCON11,  WIMCON11 },
            {S57Symbol.WNDFRM51,  WNDFRM51 },
            {S57Symbol.WNDFRM61,  WNDFRM61 },
            {S57Symbol.WNDMIL02,  WNDMIL02 },
            {S57Symbol.WNDMIL12,  WNDMIL12 },
            {S57Symbol.WRECKS01,  WRECKS01 },
            {S57Symbol.WRECKS04,  WRECKS04 },
            {S57Symbol.WRECKS05,  WRECKS05 },
            {S57Symbol.SPRING02,  SPRING02 },
            {S57Symbol.SWPARE51,  SWPARE51 },
            {S57Symbol.TIDSTR01,  TIDSTR01 },
            {S57Symbol.TSSCRS51,  TSSCRS51 },
            {S57Symbol.TSSRON51,  TSSRON51 },
            {S57Symbol.LITVES02,  LITVES02 },
            {S57Symbol.LITFLT02,  LITFLT02 },
            {S57Symbol.QUESMRK1,  QUESMRK1 },
            {S57Symbol.SectorLightDash32,  SectorLightDash32 },
        };



        public static Dictionary<string, S57Symbol> SpriteEnum = new Dictionary<string, S57Symbol> 
        {
            {"ACHARE02(Clone)", S57Symbol.ACHARE02},
            {"ACHARE51(Clone)", S57Symbol.ACHARE51},
            {"ACHBRT07(Clone)", S57Symbol.ACHBRT07},
            {"ACHRES51(Clone)", S57Symbol.ACHRES51},
            {"ACHRES61(Clone)", S57Symbol.ACHRES61},
            {"ACHRES71(Clone)", S57Symbol.ACHRES71},
            {"AIRARE02(Clone)", S57Symbol.AIRARE02},
            {"BCNCAR01(Clone)", S57Symbol.BCNCAR01},
            {"BCNCAR02(Clone)", S57Symbol.BCNCAR02},
            {"BCNCAR03(Clone)", S57Symbol.BCNCAR03},
            {"BCNCAR04(Clone)", S57Symbol.BCNCAR04},
            {"BCNDEF13(Clone)", S57Symbol.BCNDEF13},
            {"BCNISD21(Clone)", S57Symbol.BCNISD21},
            {"BCNLAT15(Clone)", S57Symbol.BCNLAT15},
            {"BCNLAT16(Clone)", S57Symbol.BCNLAT16},
            {"BCNLAT21(Clone)", S57Symbol.BCNLAT21},
            {"BCNLAT22(Clone)", S57Symbol.BCNLAT22},
            {"BCNSAW13(Clone)", S57Symbol.BCNSAW13},
            {"BCNSAW21(Clone)", S57Symbol.BCNSAW21},
            {"BCNSPP13(Clone)", S57Symbol.BCNSPP13},
            {"BCNSPP21(Clone)", S57Symbol.BCNSPP21},
            {"BOYCAR01(Clone)", S57Symbol.BOYCAR01},
            {"BOYCAR02(Clone)", S57Symbol.BOYCAR02},
            {"BOYCAR03(Clone)", S57Symbol.BOYCAR03},
            {"BOYCAR04(Clone)", S57Symbol.BOYCAR04},
            {"BOYDEF03(Clone)", S57Symbol.BOYDEF03},
            {"BOYISD12(Clone)", S57Symbol.BOYISD12},
            {"BOYLAT13(Clone)", S57Symbol.BOYLAT13},
            {"BOYLAT14(Clone)", S57Symbol.BOYLAT14},
            {"BOYLAT23(Clone)", S57Symbol.BOYLAT23},
            {"BOYLAT24(Clone)", S57Symbol.BOYLAT24},
            {"BOYMOR11(Clone)", S57Symbol.BOYMOR11},
            {"BOYSAW12(Clone)", S57Symbol.BOYSAW12},
            {"BOYSPP11(Clone)", S57Symbol.BOYSPP11},
            {"BOYSPP15(Clone)", S57Symbol.BOYSPP15},
            {"BOYSPP25(Clone)", S57Symbol.BOYSPP25},
            {"BOYSPP35(Clone)", S57Symbol.BOYSPP35},
            {"BOYSUP02(Clone)", S57Symbol.BOYSUP02},
            {"BRIDGE01(Clone)", S57Symbol.BRIDGE01},
            {"BRTHNO01(Clone)", S57Symbol.BRTHNO01},
            {"BUAARE02(Clone)", S57Symbol.BUAARE02},
            {"BUIREL01(Clone)", S57Symbol.BUIREL01},
            {"BUIREL04(Clone)", S57Symbol.BUIREL04},
            {"BUIREL05(Clone)", S57Symbol.BUIREL05},
            {"BUIREL13(Clone)", S57Symbol.BUIREL13},
            {"BUIREL14(Clone)", S57Symbol.BUIREL14},
            {"BUIREL15(Clone)", S57Symbol.BUIREL15},
            {"BUISGL01(Clone)", S57Symbol.BUISGL01},
            {"BUISGL11(Clone)", S57Symbol.BUISGL11},
            {"CAIRNS01(Clone)", S57Symbol.CAIRNS01},
            {"CAIRNS11(Clone)", S57Symbol.CAIRNS11},
            {"CBLARE51(Clone)", S57Symbol.CBLARE51},
            {"CGUSTA02(Clone)", S57Symbol.CGUSTA02},
            {"CHIMNY01(Clone)", S57Symbol.CHIMNY01},
            {"CHIMNY11(Clone)", S57Symbol.CHIMNY11},
            {"CHINFO06(Clone)", S57Symbol.CHINFO06},
            {"CHINFO07(Clone)", S57Symbol.CHINFO07},
            {"CHKPNT01(Clone)", S57Symbol.CHKPNT01},
            {"CRANES01(Clone)", S57Symbol.CRANES01},
            {"CTNARE51(Clone)", S57Symbol.CTNARE51},
            {"CTYARE51(Clone)", S57Symbol.CTYARE51},
            {"CTYARE71(Clone)", S57Symbol.CTYARE71},
            {"CURDEF01(Clone)", S57Symbol.CURDEF01},
            {"CURENT01(Clone)", S57Symbol.CURENT01},
            {"DANGER01(Clone)", S57Symbol.DANGER01},
            {"DANGER02(Clone)", S57Symbol.DANGER02},
            {"DANGER03(Clone)", S57Symbol.DANGER03},
            {"DAYSQR01(Clone)", S57Symbol.DAYSQR01},
            {"DAYTRI01(Clone)", S57Symbol.DAYTRI01},
            {"DAYTRI05(Clone)", S57Symbol.DAYTRI05},
            {"DISMAR03(Clone)", S57Symbol.DISMAR03},
            {"DISMAR04(Clone)", S57Symbol.DISMAR04},
            {"DOMES001(Clone)", S57Symbol.DOMES001},
            {"DOMES011(Clone)", S57Symbol.DOMES011},
            {"DRFSTA01(Clone)", S57Symbol.DRFSTA01},
            {"DSHAER01(Clone)", S57Symbol.DSHAER01},
            {"DSHAER11(Clone)", S57Symbol.DSHAER11},
            {"DWRTPT51(Clone)", S57Symbol.DWRTPT51},
            {"DWRUTE51(Clone)", S57Symbol.DWRUTE51},
            {"EBBSTR01(Clone)", S57Symbol.EBBSTR01},
            {"ENTRES51(Clone)", S57Symbol.ENTRES51},
            {"ENTRES61(Clone)", S57Symbol.ENTRES61},
            {"ENTRES71(Clone)", S57Symbol.ENTRES71},
            {"ESSARE01(Clone)", S57Symbol.ESSARE01},
            {"FAIRWY51(Clone)", S57Symbol.FAIRWY51},
            {"FAIRWY52(Clone)", S57Symbol.FAIRWY52},
            {"FLASTK01(Clone)", S57Symbol.FLASTK01},
            {"FLASTK11(Clone)", S57Symbol.FLASTK11},
            {"FLDSTR01(Clone)", S57Symbol.FLDSTR01},
            {"FLGSTF01(Clone)", S57Symbol.FLGSTF01},
            {"FLTHAZ02(Clone)", S57Symbol.FLTHAZ02},
            {"FOGSIG01(Clone)", S57Symbol.FOGSIG01},
            {"FORSTC01(Clone)", S57Symbol.FORSTC01},
            {"FORSTC11(Clone)", S57Symbol.FORSTC11},
            {"FOULGND1(Clone)", S57Symbol.FOULGND1},
            {"FRYARE51(Clone)", S57Symbol.FRYARE51},
            {"FRYARE52(Clone)", S57Symbol.FRYARE52},
            {"FSHFAC02(Clone)", S57Symbol.FSHFAC02},
            {"FSHFAC03(Clone)", S57Symbol.FSHFAC03},
            {"FSHGRD01(Clone)", S57Symbol.FSHGRD01},
            {"FSHHAV01(Clone)", S57Symbol.FSHHAV01},
            {"FSHRES51(Clone)", S57Symbol.FSHRES51},
            {"FSHRES61(Clone)", S57Symbol.FSHRES61},
            {"FSHRES71(Clone)", S57Symbol.FSHRES71},
            {"GATCON03(Clone)", S57Symbol.GATCON03},
            {"GATCON04(Clone)", S57Symbol.GATCON04},
            {"HILTOP01(Clone)", S57Symbol.HILTOP01},
            {"HRBFAC09(Clone)", S57Symbol.HRBFAC09},
            {"HULKES01(Clone)", S57Symbol.HULKES01},
            {"INFARE51(Clone)", S57Symbol.INFARE51},
            {"ISODGR01(Clone)", S57Symbol.ISODGR01},
            {"ITZARE51(Clone)", S57Symbol.ITZARE51},
            {"LIGHTS11(Clone)", S57Symbol.LIGHTS11},
            {"LIGHTS12(Clone)", S57Symbol.LIGHTS12},
            {"LIGHTS13(Clone)", S57Symbol.LIGHTS13},
            {"LIGHTS81(Clone)", S57Symbol.LIGHTS81},
            {"LIGHTS82(Clone)", S57Symbol.LIGHTS82},
            {"LITDEF11(Clone)", S57Symbol.LITDEF11},
            {"LNDARE01(Clone)", S57Symbol.LNDARE01},
            {"LOCMAG01(Clone)", S57Symbol.LOCMAG01},
            {"LOCMAG51(Clone)", S57Symbol.LOCMAG51},
            {"LOWACC01(Clone)", S57Symbol.LOWACC01},
            {"MAGVAR01(Clone)", S57Symbol.MAGVAR01},
            {"MAGVAR51(Clone)", S57Symbol.MAGVAR51},
            {"MARCUL02(Clone)", S57Symbol.MARCUL02},
            {"MONUMT02(Clone)", S57Symbol.MONUMT02},
            {"MONUMT12(Clone)", S57Symbol.MONUMT12},
            {"MORFAC03(Clone)", S57Symbol.MORFAC03},
            {"MORFAC04(Clone)", S57Symbol.MORFAC04},
            {"MSTCON04(Clone)", S57Symbol.MSTCON04},
            {"MSTCON14(Clone)", S57Symbol.MSTCON14},
            {"NOTBRD11(Clone)", S57Symbol.NOTBRD11},
            {"OBSTRN01(Clone)", S57Symbol.OBSTRN01},
            {"OBSTRN03(Clone)", S57Symbol.OBSTRN03},
            {"OBSTRN11(Clone)", S57Symbol.OBSTRN11},
            {"OFSPLF01(Clone)", S57Symbol.OFSPLF01},
            {"PILBOP02(Clone)", S57Symbol.PILBOP02},
            {"PILPNT02(Clone)", S57Symbol.PILPNT02},
            {"POSGEN01(Clone)", S57Symbol.POSGEN01},
            {"POSGEN03(Clone)", S57Symbol.POSGEN03},
            {"POSGEN04(Clone)", S57Symbol.POSGEN04},
            {"PRCARE12(Clone)", S57Symbol.PRCARE12},
            {"PRCARE51(Clone)", S57Symbol.PRCARE51},
            {"PRDINS02(Clone)", S57Symbol.PRDINS02},
            {"PSSARE01(Clone)", S57Symbol.PSSARE01},
            {"QUARRY01(Clone)", S57Symbol.QUARRY01},
            {"RACNSP01(Clone)", S57Symbol.RACNSP01},
            {"RADRFL03(Clone)", S57Symbol.RADRFL03},
            {"RASCAN01(Clone)", S57Symbol.RASCAN01},
            {"RASCAN11(Clone)", S57Symbol.RASCAN11},
            {"RCLDEF01(Clone)", S57Symbol.RCLDEF01},
            {"RCTLPT52(Clone)", S57Symbol.RCTLPT52},
            {"RDOCAL02(Clone)", S57Symbol.RDOCAL02},
            {"RDOCAL03(Clone)", S57Symbol.RDOCAL03},
            {"RDOSTA02(Clone)", S57Symbol.RDOSTA02},
            {"RECDEF51(Clone)", S57Symbol.RECDEF51},
            {"RECTRC55(Clone)", S57Symbol.RECTRC55},
            {"RECTRC56(Clone)", S57Symbol.RECTRC56},
            {"RECTRC57(Clone)", S57Symbol.RECTRC57},
            {"RECTRC58(Clone)", S57Symbol.RECTRC58},
            {"RETRFL02(Clone)", S57Symbol.RETRFL02},
            {"RFNERY01(Clone)", S57Symbol.RFNERY01},
            {"RFNERY11(Clone)", S57Symbol.RFNERY11},
            {"ROLROL01(Clone)", S57Symbol.ROLROL01},
            {"RSCSTA02(Clone)", S57Symbol.RSCSTA02},
            {"RSRDEF51(Clone)", S57Symbol.RSRDEF51},
            {"RTLDEF51(Clone)", S57Symbol.RTLDEF51},
            {"RTPBCN02(Clone)", S57Symbol.RTPBCN02},
            {"SILBUI01(Clone)", S57Symbol.SILBUI01},
            {"SILBUI11(Clone)", S57Symbol.SILBUI11},
            {"SISTAT02(Clone)", S57Symbol.SISTAT02},
            {"SMCFAC02(Clone)", S57Symbol.SMCFAC02},
            {"SNDWAV02(Clone)", S57Symbol.SNDWAV02},
            {"TMARDEF2(Clone)", S57Symbol.TMARDEF2},
            {"TMBYRD01(Clone)", S57Symbol.TMBYRD01},
            {"TNKCON02(Clone)", S57Symbol.TNKCON02},
            {"TNKCON12(Clone)", S57Symbol.TNKCON12},
            {"TNKFRM01(Clone)", S57Symbol.TNKFRM01},
            {"TNKFRM11(Clone)", S57Symbol.TNKFRM11},
            {"TOPMAR02(Clone)", S57Symbol.TOPMAR02},
            {"TOPMAR04(Clone)", S57Symbol.TOPMAR04},
            {"TOPMAR05(Clone)", S57Symbol.TOPMAR05},
            {"TOPMAR06(Clone)", S57Symbol.TOPMAR06},
            {"TOPMAR07(Clone)", S57Symbol.TOPMAR07},
            {"TOPMAR08(Clone)", S57Symbol.TOPMAR08},
            {"TOPMAR10(Clone)", S57Symbol.TOPMAR10},
            {"TOPMAR12(Clone)", S57Symbol.TOPMAR12},
            {"TOPMAR13(Clone)", S57Symbol.TOPMAR13},
            {"TOPMAR14(Clone)", S57Symbol.TOPMAR14},
            {"TOPMAR16(Clone)", S57Symbol.TOPMAR16},
            {"TOPMAR17(Clone)", S57Symbol.TOPMAR17},
            {"TOPMAR18(Clone)", S57Symbol.TOPMAR18},
            {"TOPMAR65(Clone)", S57Symbol.TOPMAR65},
            {"TOWERS01(Clone)", S57Symbol.TOWERS01},
            {"TOWERS02(Clone)", S57Symbol.TOWERS02},
            {"TOWERS03(Clone)", S57Symbol.TOWERS03},
            {"TOWERS05(Clone)", S57Symbol.TOWERS05},
            {"TOWERS12(Clone)", S57Symbol.TOWERS12},
            {"TOWERS15(Clone)", S57Symbol.TOWERS15},
            {"TREPNT04(Clone)", S57Symbol.TREPNT04},
            {"TREPNT05(Clone)", S57Symbol.TREPNT05},
            {"TSLDEF51(Clone)", S57Symbol.TSLDEF51},
            {"TSSLPT51(Clone)", S57Symbol.TSSLPT51},
            {"TWRDEF51(Clone)", S57Symbol.TWRDEF51},
            {"TWRTPT52(Clone)", S57Symbol.TWRTPT52},
            {"TWRTPT53(Clone)", S57Symbol.TWRTPT53},
            {"UWTROC03(Clone)", S57Symbol.UWTROC03},
            {"UWTROC04(Clone)", S57Symbol.UWTROC04},
            {"WATTUR02(Clone)", S57Symbol.WATTUR02},
            {"WEDKLP03(Clone)", S57Symbol.WEDKLP03},
            {"WIMCON01(Clone)", S57Symbol.WIMCON01},
            {"WIMCON11(Clone)", S57Symbol.WIMCON11},
            {"WNDFRM51(Clone)", S57Symbol.WNDFRM51},
            {"WNDFRM61(Clone)", S57Symbol.WNDFRM61},
            {"WNDMIL02(Clone)", S57Symbol.WNDMIL02},
            {"WNDMIL12(Clone)", S57Symbol.WNDMIL12},
            {"WRECKS01(Clone)", S57Symbol.WRECKS01},
            {"WRECKS04(Clone)", S57Symbol.WRECKS04},
            {"WRECKS05(Clone)", S57Symbol.WRECKS05},
            {"SPRING02(Clone)", S57Symbol.SPRING02},
            {"SWPARE51(Clone)", S57Symbol.SWPARE51},
            {"TIDSTR01(Clone)", S57Symbol.TIDSTR01},
            {"TSSCRS51(Clone)", S57Symbol.TSSCRS51},
            {"TSSRON51(Clone)", S57Symbol.TSSRON51},
            {"LITVES02(Clone)", S57Symbol.LITVES02},
            {"LITFLT02(Clone)", S57Symbol.LITFLT02},           
            {"QUESMRK1(Clone)", S57Symbol.QUESMRK1},
            {"SectorLightDash32(Clone)", S57Symbol.SectorLightDash32},

        };
        
    }
}