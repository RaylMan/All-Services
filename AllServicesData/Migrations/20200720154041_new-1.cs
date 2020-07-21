using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllServicesData.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.CreateTable(
                name: "CompanyManufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Company_Id = table.Column<int>(nullable: false),
                    Manufacturer_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyManufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyManufacturers_Service_Type",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyManufacturers_Manufacturer",
                        column: x => x.Manufacturer_Id,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "N83HNYOT5DTSJJ9UG6TO8IRX226S2EPHFH0FMWREWT61P9Z8E91IGZ3FRGOU1501XMMCS4ITPO1PLZH3D7O3MHAPOVXGI7N12FEDWWQJ0H227N328UQ3Q7OPM7Y7GCLSBAWGVEHQRFCFPIRA25IXQTK41Y0Z8SDY5J070XH3M9ML5IAEPXFL4YCSZ2O6OSS8COJFRUJE", 252, "K6NAR930ST@email.com", 937, 344, "YOLQG99SYWJKN13HHIH8IKO3RNJQ84W5NAXPMVL026I1JHUKUC", "http://39N6NEN4W6.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "RGLCWUK28567NTDDJP5WSAKNO25KHFGILM5EULN6ZB1WW6V43K5899OQ68X4Z9V3ZYVBY8S7C87QJX0SGAQ6KIIL7OIVYSHZP778LUG5176AC7HIIEXYSYTQPJEJ06JT1HBL01HW4VEMMIJ9G9NT4TG0OQTBP6E5YMI465SR7B47UGEGAED0TZYIBK7JIGG7QJY99OCK", 981, "QMHX59126Y@email.com", 341, 577, "R6W3YJGHMMAK3OL8XA3W8JI147QKSEGVB2JXD4T1D066F5DB7Z", "http://IFPIBFY52Q.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "BSHNMW83OM21HBVPB9H529HBX0ZXB6J4TSS8F4LJB7NT5Q8OXWEZX7YCLFZV6L2SD8IZSWJGY844VXGH2L9O2TGV3QX9FZN0F5P6II5BM7BYD4QX9R3UMNZU1W5B9KB8VEY0HJ9TQ8C5SSS8999X62N2F5FVN3BC6CC9GZP0SJEOL4BJE6C9KNB206VLENGW699PPS2J", 138, "SGPXBTGRFO@email.com", 399, 266, "TJFWY9QK45RQ1C1SBKJJDEWEDRRL5V4VE2PBIOD0PLRI6Z43IQ", "http://IB6M9WZKWG.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "T42WNHNXYCPHZLVWAOG56IK6IHAN4GTF180YN2J3FT3C9ALU0NWLD0JLT6OFHA2RTJP0V7IHENZNOH6H5PXRUHCAYPERODVF0LS0VU93EOGZB56M9GK1ML7LHOCG213B1UXCZGWLQ3MFBM92S2RI342OOGTGS3BNVF8RI4W2T9LT92K4OJX9JVH71IYSXP2X29T6NSUY", 355, "USBTUX5SQN@email.com", 963, 803, "FZY4TJPV6Y1JFBDA7BZ9FEFDGX09INQ6Y94U6NNS3CW8XSS16S", "http://SH5UFHSDUX.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "HGDRHPYF9D0PEDDR2BMZS9NZD127MUNPOZVOOTLE90TMWDD2RYOR15FH2ONQX02P0KBORZCIZI01QACAXAQYF5YSUNVAG5QI7DWMBYK1VG2SFN12LM2XKEK4WS4EDBC31R4MO0990YC8DFNGW3Y3D38331ZT4FYUE81XSONVN36VBL1REXRJMJ07SBTWAPFUAS4FOZYI", 580, "HNYSSVU1I9@email.com", 931, 569, "PDPJ6N1RAIOGXOH5H3FR41V7YMVTRVCO9J4J3QBFJCV1B86VK9", "http://OF9HOU8B02.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "AH2F36ZP9JSYR416G0L5QNBCGWB1SBL7G2UAVSZV5E29R0YFPSNH05LWFZ8H48787URZJ1KXBZ9MVCVQ76LAXDHKR746TR17H3B6I85YH0GA69ADESJ8X7K4NGIL6OET8BE1AYH9AX277GOR712BI2KKTHTB0T13VWC54JCQKK79EN6H20OFWCLF14I3EFIR68LLDSWX", 194, "XXQAW7OH9E@email.com", 2, 422, "ZM085KFFKMI9EVHTL6D9AILEBQDGBVDJD0QKMMKQZCT26IMK02", "http://YJ96NF7H8W.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "XK7ZSH2D2PJV64QDAJ0P5I084T7M9F3VBU1NZ0ROELPU5CNEPKEYRT0OU959JPEWVXULCDNJ1LKU3GD1G36YAEER3N305SEYH38HSBBM657FJGVO5D3QTPVRTCRZKWNIHVM9H6JE2U2FH8IX1P42YYF2HQXPTLBJRY8X3VG94YY8WPJU44852VUSPU20I3VQSSXTAU3F", 591, "UM3E7621A9@email.com", 416, 343, "I58A9HF1HCVZNGR6EPII3P0BDHPE20UJA2W6XTSIPATFH5DMA1", "http://QSLYUUUJU6.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "9235V3HEDDBL87QQ220X0RPADX5HS1QS4YM1T8TDYXX78EUOIE12S6FSN2177AWLXSQJUY74JW8D3RC8DR9NAX97T4N0GVFYALJPXK3UH6T68BZ6034QAJL9TT00KGXXQKDRHXK2XPFDED9RFRAN0ZX1AK5ETDJBJ5PY8HYDSB2VDH5QTIU2GK71WLQ71GJUFE4IXLT7", 13, "6HBVS5YWYP@email.com", 266, 265, "374Y6CX2OPULSR588XBW01LM2IQ9NX2IZW9IQI5TXYSMV7BXJ6", "http://1WMW5RWS02.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "S8CI914G2ZRN282P7X8MH79I1ZILGGXNTI17E3W0AR488N4O3PU9UNVU93RJTSAWCD4TH4KEAHLZDAKN54S0VY3FXG8LMMHRRI54TKG8EQ8MB5R8TDOYAJAOJY6A691YA3H4EP4UXTVFZRE1Y91I8SRHIRU4NGCFYJMHXW4DJ3BQY4Y2UFL6IT0RMAWX59HRRQRQE6DB", 265, "QB7QZS7BMA@email.com", 895, 50, "FY9ERATN22KI4F7FT55XAHIJWT9HNIYXBJ1TTVALQJ4DY8XLTM", "http://TEXHUONV85.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "TH0MFVX6YYAMOVUI3D3DCKEJK9A1D6F07OSJKVLE4BMX9HZCWLUK252JCRBFU631SKOADL7I1YIB7QJDJ8F1M58CVIG3TFU8HUFZ2Z9KOMSDW1LVH86W0CPXLMO4EEYWEK3MLUKU95M9M5Q47UVUI8IFESNQLEFJX68M78KXYMW5ZQKQ6T7TTENGCYH3G3I4ZCLP6D78", 137, "YH2RA2SH2T@email.com", 894, 836, "K856LNPYH7U1HV0TT1JI0RQ5D2FWE4T2W8JVIQ5ZITVIIRWDM1", "http://MO2EJMFLC6.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "UAH5HXVFCKN8O880QDIXMRP9I4PNN1GQ3IJYA6JMHNFSGNA4FS5BDPUCUHXNHI2KD7FGYK0U35Q9M7243VH45FMOXGD2J6F8U4PJI4G52LHI8V0WO2TWB8O8U1SRG7K7ZSORSTW9PLBU7EPCQQNRMT6WPQYRLYY5AKSQGIE5FUHZ64BPLQBZT2UGV2BB4FX0XGTWW95H", 281, "QAIRL55EAL@email.com", 905, 124, "MSL2MG0VPJF5W9LIZM4OGDBA6QCZKO3MV4NBQ24OBQVV92EX4L", "http://BP3K2VK17R.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "QM0SPAEMO58RTIE3FUF68KBETGGSLCUU82YEJZBK1TZFMT5VF8Q0VBSFLW9J3WAMLOT1TATPS4EPV52AKVMMW387JS2X01QFSN48AEBFPAH16DUP488IJXZRPVRBH6Z0N96HB39GUH7WWHBF7N313I64XNSPWA7SKQO6GMOA91YB0D5IULD4D87EDBUYKUUUKOLF3E9V", 549, "32JDM5QC32@email.com", 615, 298, "921CU4EURK4K7DPMTJ3F20ZPGD1L1ZPQMR4KG5UJ79GAZKWG99", "http://25O7PIFGXZ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "UI2TZZ6RVM2D5FTZVH3ADGDHNELMH732840V9ZNX89RQAYAIOZX8NXWNEVFVNTJXS9FAP7Z53FBDZWGZDD8RJ5PKINQOT2KP038AT93QA2EHWSYRPQRKV1NWU52CQLMB5VN5YFGEKRRR1HX0Y98DKA38PMQXG1AYPDMAE23JKN9EJ65MHCNRMJ052OPLYS7SR3BX5WV6", 392, "5TXDBRTCIZ@email.com", 305, 390, "FZ27AZZTQDQENSMGMRI0MRV1PRWQ4HRURRLXQ35CZ64VC2F8Q5", "http://JV5X6HY0TV.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "GAQW9ZWMY996DGW7XTOLM9QHV9HFI11E12H4DBDL4HOI0MSYB8TFLIJGTJBASRD7I4FL914WPCQEVHQJQTEJIW2TSAL39D3NDQA5HGYJE6ZI1EVL21U8M3ZVCV38QBWMICBEHVCJ44FL6T1NO9BIT4BJ1P2VN03DJN9YDREGZKERYNZS3QTQ9O3NB1M23R6EBCBTTDJ7", 931, "83SRK5ZD8C@email.com", 981, 462, "44SJ0TUNZJ17GMD4TVWLEMNINAQWLG90GVVE6UXRH9CT097Y8H", "http://TKA1U18898.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "FEEK3SOD1XEGBJH2DXVZ8NI7SJZHN7AI99L4YIY1QWLK7NI0T2XLNK915H1T3G04X6GC8ND493IMC79FB8YUJY5Z9T8QQE8K6QXAGF2FY3MTCXZ8HWS4SFV8BRDOPWN447PVK885GT6QMLXL4AJ4VE215Y9ZCNZBPRYEIEXJXWY8IFWZ31UPNTI0FYZW9J3234A4XSDZ", 694, "ULL01FUXEV@email.com", 614, 546, "MAG9P3SZCJ5L2KY5I89TOBJO35FNE1CLX4CNNJKMF9TZORASGF", "http://KHTX7HKR9X.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "WNORUAL5WH9FN1DT1XVE0YBOIR43CL6XWB6G73F13YA7WF32UOQW6578M9ICFS2LKLSM46V7R3KBXD2DXBJY4J11D847UDVL6ZXKXR7Y2SFCU6KJHFOEJEQBU0I6CYNNI8E8QRPGEU5MEYHHXVZOYRC1IW07JBWEF14V1M200I9YJE65TBIR88Z06NZ40S7D80GM4VPL", 734, "BY39QFVY9F@email.com", 290, 885, "29YQROSDZ4OH2EFHCDZOW89IL6ZS8UB7V7Z9KIIR5WE6EZK3U9", "http://F3QW5PG635.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "HTA3DDWW578JKBUI593DX35R9CXCPNOCQ5YSY96MS93BG5SOCWUHC0IOXS4BQTHRT62PNBU5CRUYA4LETJA23G90XJ5FF5691LRKCDBABYEVFTO2HZRHSOYN6C2DGP0HVV6YMBBQHA0FBOUD5C7PNZQNWEN9K73W879UXZPGYB9SXTLRSZIDRK36ETBIXBFKGEGEO9QF", 318, "MSPIFRBXF1@email.com", 8, 530, "W11MZ8ZD26RVYZEXDDQDXGSW5YLTMHCSJDR0SQGF38Q1UUWQ9S", "http://V39LVINFX6.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "LKZ01CKC4T3H197VBSN9FSYG48UJAIVNNOHC2ZQDG82W8OB9OAH52X12VS63RBBW7P3M152LBJ2G0CIQ6V4AA0VZXPQJ2XWF7FYSUYITH53S4UCTKP66GAWH4EZMOSSOXXIUOZ5HML2E6C4CM68N1086TQXQ96EYMP5HMSFUTYT5HRK2JX9STFW7YMB7CPIQGE1QHX04", 264, "0NT5YVEOVL@email.com", 670, 141, "1O3CGCZBF5HM6VEG27SAQHSEQCYDZ3VV6F1FMU0WW91GI5UV9U", "http://LKVP0494IG.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "6NRQL5VRDEEFLQG1IKX8WIBXQ6WP30A0PCIN6DU3AWKRHF8EJ8WZGJUYL39OIFYNEO0JH35F048A7TQK8RG5ELTGSUBDDFU487N3PZ6PDQ9MKU02MZQ183I24T1X22CUKDCAGX4JU01XLH573J0NZ25FYU867JXKOOBHS0VZ4GGHBVQWY34TCY5RH6MVY8LLDQI7GYPD", 619, "4ZXAWY2TT0@email.com", 401, 704, "XASSWXDCDMHEOEI0TT9VN9A644EUMTQ9N15BFM4T3JSM0G79HS", "http://U5I1XIHVGZ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "P2ERYGY7EM4F4KTCHBSYCAKT8QSPJ1A7H7KCUGLQA5OG5PB7IVAGCSXOSVSHXIXNM776ARRBZCYGVDXTOUHX044ZK5T9XD21HB37RF70E9Q93Q3O793DA9WSCHWE7RNVJ69TJZBJWQT1N453BFCYKY0HOL5KS23WV4Z7RJEH7TRUQ5EIL2D1PZLVG1F84113W7FSE8M1", 3, "XX4RT8TJJ3@email.com", 968, 216, "A400HG1THX8ZZBG6TE0ZEGMG2X7SZVDNQL0V8UN99W0H3CDU0J", "http://VTUJOLV790.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "1ZSPFN0UM1QWDF2X6DPW4Z02EXI3ZJFL9JQ7FPMGH97RN9QPQ0ORSN6B9ZKRE74CVEX3Z5SR1IO52JPFH2N94Y3WMO7QE5BKF45ILW0UH7ZJ8AI0JEJLU4H7LAQK7CM6GE08NH3UC2179TYMFHG9V00KX87LFPWFV3D4KKMCKZJ1CK71MEFZ5NKQNPKOJSOXFWMFP3B4", 794, "G46L6V5M1O@email.com", 650, 375, "4EY6Q8HMAF8AJ6JISXQ4A822KVVQ82LSDL51YO9PH7NDUNNJMD", "http://I4P78BSTDX.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "AWCUYH6HMD4ETF6Q8Q13ECQTFJEQPH4UTEMT1MWYYXAXUEKKARDB1JT8GTPOCQ2FJKUO2MZW3CEQC28A84P7E22JUONI6HVI44NKT6RY2QIYFD5NUOPIA5ARRK3O9Q0VR6VHOYRCN1EXUDERSAXR1NH9462IDDYL0WHIRX867N4J0M7OGL583I4DYVNS5I9KC27755A5", 746, "EUVZ6991LC@email.com", 150, 333, "B0UOT8JR9OC1HZSS2ET5KQBYOUG8P9SKLA7CXPT0M6SQGHCMJP", "http://A62QH2Q4MV.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "2TO7URHR4Y9318GPMN0QU9B4SUN14U3U2FTVGXEO2R6WCGE4J2QDE6A3RTPAEPWK4PBVPVIYIMXCCO2LQTSCD0Q6F0EWHEKM5W2WFSPXT152I80C1DTU7TGD9EQYRWQDBLHPWFG7E4TL5YYH9B4DV0PLQYXAB0G7L1071KQW7WPDA4HKPJZP1MSL6597SF5OYVAD71PZ", 508, "UOCEOHJ662@email.com", 829, 729, "VIG8KLLWRMV2B0F8JPA5LSE21BPO3EMY394SGTAUUNQFUDN7PC", "http://N968B6X10O.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "QL7C8HXXR81K48JV1O2M1XXUDFYEMB2KDDJIQAFGTVO7BCF7YQEI9OX2XM92TSLQFQG1YAE1IV2FJ0TAA0P56ULZPRVDANXAJ81U6NJXLNAOWRT72823DQTVFRLHPA05816K89EWR1TTT6D77XKCU373PFPOCBILXEQ4VI834GLL6ABIONJ1ZYKE3D53TZTPTI6OQIMY", 141, "4LUGC1V5JK@email.com", 579, 213, "ZQHORW6ODHAY1QV84LARNFKEW61XEW1FAUCIQ6WGGQZMZ5XDW7", "http://RP4XGONS7Z.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "4L7Q8P0IXAGCW8FJRCNEAL7FI65HRZJOXPNTNEIXANHIDP36R66KE2YSO1IBTT1812OGUW6N3ZEXDYB2D9ZU38K504EW6HDRWIRLAWL5ASROYBOZZP7U3HF2STQZRJRWVWB5H02RX4TKR5HZQP6RJTXPDY3RGWN1B52BATR9WQ79X5KWM0JCN9MC9W1T6KLBQ2IWCFY6", 335, "JF84SYZE5V@email.com", 102, 93, "7743VX1INGFPMLOBS0CO18CLE5T5WYUGCMFPFTQL4TF0F6YFNG", "http://YV8MAF869J.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "0TI3MGIHORPVID2HHUW41G97QEGTX9PKECM06ESMPS0NGDN5U38OJFSUUKNI9ZTOCERF0CKCBJOIQW1M0L94ABB8U2FV1KN09LKBWHFRS6M90JD7TBRY0YOBDSU86ZL16YJELZZTFRMDZBILYIB03ZAK6J7EWGU3VUDCA9W3L7SIMKMCJJKYXV8HX8HC1U696SSE7FKY", 47, "I7CFX4XQE3@email.com", 503, 750, "VHO5G18V654M66F9W6OB1TC0BSL32HEE9VCPGCA6AVG6ZUCAMS", "http://Y10NL303T6.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "SBFNFBQPKQJZCN0XAJSIMP62RE9G1HWZ8FIH1Y9WNHFXT8YNWX2QKLTCFN6BBKYD4U17ET5LK54EKIISPVTEOFOWVFBO28UDTB39H1ID1QGOQP26ENVQ0TZYGEL8RQTLL1UIPIKYMQM799GFNEJONEMAME3DQJVK74DZ5TR5C7DJG2YG8FVMGE8GOU6KPHHC4C9E5RK4", 971, "9HR7R0AXY1@email.com", 230, 186, "XOMPAC3TPWEKYID266KLWGQ4ZAPE2UKR40Z22SFL0M53C6OV8G", "http://5LXQ7TKAN1.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "8UJLX22W3GVLLK5TI5L2FYCV9ROQQCXG4HIP7FKZ7O4RFT9NUOLPZVVKRYMFNMF0TPRDCQVCUW403UPPRB6C1HRIW77J3ELUID80C5LE2I4C04Q6I6YLQD9L7IRESMJQKKS0WYNVZ2JTNOS1QBA7P9EFEX23OGVQ8O2QM0KUSCWY4Q7T00XRLMAKFNV85UHTG2U9VBO0", 108, "PVO1PSL8J1@email.com", 602, 719, "0QONNQKYZJCXTDEWNRL9FMY85CRB688ZL7158X6YC7IWRUACY7", "http://1LNMVMJY0U.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "W6HDCRLCON8M496MNDSFV02FRLEHO0OJ5TDSNKZ8HIT63OQNPJ9FFU86DBW0MDXY8ZRL6N8COU8NG6MC401F1JDKUHOLX9VEU57D7FRCK61VWV0HZU5VLS7ZWG1Z8WPP842K9IFYJZ44SRY8QHWDD92C8IR0O2DXRLX22PIROHMVXCGFS2I1ALM9B0M01OKRWHNG45FB", 172, "D8ROY92H8G@email.com", 178, 130, "9EY6XHO5BLIVULWF9X1CDR0A659QZALWXG26XQL4LQYPFY7KUI", "http://BAW8NT0RTM.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "70W2K4I7Z6R4ERTIKR9QTWNKXOTZT030W3HMMYD314SBZG5EPFJJSC2KNLF6KSO9D0HLKG6VNFZZELVQSPKOQTITB79ATHSIQS889U4IJX5MNDGB0YN5IASTSXJMH6CGWRJVNWR7UCE3X5G717J43XAPAOQLLRBNVZZ54UYEHQKG5Z6WRMVJWHN9R3V8FFWDB1I8FKDG", 443, "CITFVUEZQ3@email.com", 617, 900, "JEWNM4UKS348510NM0OB808B3HEDR7QGIP9SU9XXIKPMLXHJB4", "http://UMX0Q1H2MC.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "12XKW0FA5CWLAJGGQM9PS72R59X71R3CJNEKUIT4OE3OGJMNTJL526T3AGPWDHJOIUBXF6VI3FAOENKWXJNRG8JN3LKO361H5PGWHYIXXCBX5FZW539331HJLY43WHO6N3SYHYO9A03D6VRXVXT967NDH6KT4PAQYFJBWAOHOA2D8ENZGGH8YO9QQPRLN5EVZMP1MQAV", 526, "3CFSCA76TN@email.com", 615, 870, "IMV6EJECSVMXHB2JF3UHSD3T5HNVZVM0FWZL3DLHKO21SROXTG", "http://6IWRUMQPCS.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "N6DKBAO3ZCT934MTU31CNK1B5S693LD0UAR685QBWEGQ47O1FA2XY9ECFCOSEO9N82P3NPVYMZPJEKG8DE42TPBU6O16R77IE3SBRVO0PDK9U4855PO9UH3T0578YYHO1GFL2FRSZDMQECABQ5ABS7Y698KWYQB165HNZXC086JQ4NOY55S2YF63SIM3453JCVTJ5WM2", 476, "5RTOATY321@email.com", 258, 779, "3KDWXHCVUW027JD09N4QLJ5DC9OJ4F2ITZ9NCJFLG0JHEAM2S2", "http://P4SJIJZY0I.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "TKUAY8BXV1B5LQXHP9B0RRN93NW1DS2ETJIV7TZBRAHBZTSBVB40W90B6UGLMKUC87MCHCJ5JAIRKMJK5UFBYCRTSHYMNOYGPFD2GP3S18QW0I1UK5Q2ETN5P3UAO6S5MCBFJQEP0WJ0W42JPDCR85B61HMN52E4PVKYHWL31ABSJXJVAKVK4A6QAFNBD0U7SPKBUDC3", 736, "AUSSZR0T31@email.com", 362, 419, "2I074TXE81MUH49OY4YBIJZAPD93MHA6I1RWK9WQRJDMO90XP5", "http://01PMQMNEZI.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "IT8GNWPNMOQ4JRHG8EUR56YRMU8XKLC1XSGQWMEDCNHOL5R8EJNIUHMM5Q33Y2DAMYG1L0UWAQPSYJGRD9SA73HPF4VFSLPJJGCWYZXOZ1ID24XWKM0YJCDTR0VQFODYBFIRHU2NMELGUDXLG95GU19HDTE7EGIKXTBXVGO0UNLF078ODJKGT6EKFBNYP4IG5BSAB909", 276, "GH345DKU11@email.com", 590, 495, "UFWHP4QGU0445C01P1RU20K0EEKZO7MDTKWOK64KUHDZ9OL2L1", "http://WN0KUQLQS7.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "H9VXV003RNXMCWND2TO3T02PRLJD0M9KCMKGVGJFMQCOEKLE6QX1BZNQGFFKQWDFNMKZLHRWKJQCXOLH9FGJYHJM849QA9Y0N7A19V2Z9BR2IL2148KLP3QGD71QHBWLUZY0OTHOMRKX0QEXBHVBYNLTR3YC4MS7PFISWCMK1597T3PW3DP9PUWGOFJU5EUA9MHVIVB9", 181, "UGD5XROO4C@email.com", 70, 481, "5KK3ONAXOBJ06SR4SBER32PWL98GV4OHBPEFK32AEVG453DQ5N", "http://UWBZRNMUZJ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "DMHVV0S5RKI1H0RJBJWMNWJTVH3EVCS2N7NH8RK69T6T32PLIHMC7M5RDYAO7OJP1POKMJLU90M4ZZZ22R5O0Q5AB6EJR59UJR1OOE9851DHAA1N8HWPS5YLUNIPFBDD01VH7LOXS7S8NXAAE0KJJUCN3Q4A5U34Y9QIPUPX386UNZ86NHKO133GZHORRN28EYKNG2VU", 891, "NPMQAFYBLY@email.com", 214, 249, "KWQLXRADR7XXJOC5FKTHF8GQG8QYPV0VWZDENSTHHK9TZEYZVP", "http://6HBBTK8RX1.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "L958X0CJ1DAN4MIK1YMM4G5VDMXCEOW7TE7NTN3JDOKIYSNZ2JSKFK6FEJ4KC9EMQC3ZP40O5DJP6X7V98K55M2JH1JKSSHDK71VZXK8SEPBBRJQMJKEZJQEKURXUQ5M5FF85L5LYMM170H0S38JHDOARXLEFWNCJCF5MLUAN8PN6ZGUM1E1RWE20EQHA1FB8KS4UMNH", 198, "FM57IPJXSV@email.com", 890, 220, "I75IXBE2Q02ORVUW8NEH4MAW2NOWGMAAN7TU15FZAX1J81TNZ5", "http://E02AUCA5CH.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "PHGV0XB3B6LQ32HUXXSP5BSCWTG19KZ93928FJGUOPWVKX7A29PMMWMNZE9HRK40HLX39JONR8BPP629VG895MXGXOIBK8DEV5O8ADASUB5NV682M9WKL444YQGVBNDS574TS38SGPP4QJV1QPYKM220ATKU7PRG8MSYBPKSBEE6PAOO4PEWY2GCFDS9TOU08I6D07ZA", 294, "0D4GWYK8E5@email.com", 933, 400, "FGJIY5LAF5ZSK4RFGQS86K9WTN7GEKY70ERSS8OJ2S4YYCQE00", "http://4G11GN9XHB.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "JGOQK8Q63QNMNT9AWM6JDKXW9R6KK01DZIEUZN6YHNFYSS3I2G0X0788S2R3BGWCZKWEOOLJPHBZF9EQYYSD9EM1KGC66CXB1C8H5Y4N5RHT6I2SYAENYSDU744IMONMUA8DA6V93EIS735BNTH58KNI8OJA3WBQE485KZS2PFTUKVXE8243HROKWZEWWUFHC2NC4A1Y", 179, "GDFJV3OLQF@email.com", 656, 753, "APQ2038N0FCB1IIXPYJUU5F49MRRHUJ8BG22AVT3115RSEP4T0", "http://G5D9VPQW3E.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "P23AYM47X7R6DH5DXSO2FRKVZVPF4ODD4BLNKFUJ9QYTYJ25ER27IB88SHKD7ZCI4NCB6R2S8E2Y216Q2TAMVF53CN5C4RMJOPYLG19WZK9DIKF0L3KOY0XZSJ8SWZXQ2TKNDVKBTOXLF2U2HF1BH8VX29262QA9XSKZ92XZTI4KDMT0YFKR8WJ47WUE2NICNXXXR53P", 27, "QI9FM8LOE2@email.com", 393, 126, "RCS8DKUQPCHXFTABJQ1MHS6F916PY6I3M596EK0XCEY0FV64WW", "http://T3OKKTE78Z.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "EJD4G9O5B2BRHY6WA01MOI8MF60KVKSZPLAGEE8MUQMM0BW0OXTOFVL5L1ZKJDJ1KMC6YZR51P186VWDKA681ET4AE4NPYDRHVBN9ZCYFXW04M80FVAIGL9G2H6T5EQDLK0LTIDU8H2DR39XFEI3Y4K6V5V12S3BHSOTWXG6RPK9S6Y8IJN05WPRA40YXM1PO058PQAS", 523, "IUQCGVXZUY@email.com", 861, 945, "8MMITKNZHWTTFDGVD6S17RJFX5V2AZT1I52TKG8ZQAQA2IKKTK", "http://SC2LKKXK78.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "2L6BJMPVKI04A39KLRDVKA5M87A7AA697UF7YP34GCPM8YC8L99GHMX2PUCLLRVKM06QYBV5YJPIVTNK5BVAA02U6MSEMRSYQF9I1WKKNDS87PH5G2PJ6VJV8LTLSRSG001PTFTJ1LW6I4XRFX7UBI255OJPC915ULHGX1LBJGSU8NNEYBF5U8ER86UF6DG1U0L6WR3N", 916, "CHF1G59HYQ@email.com", 721, 258, "L6L40H6SAF1A35KWGZH1GGFF90AHBQRHI2UYWJ109CE1MF8ZPY", "http://UXU2BKW968.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "R1EBO242K1M0U7FUP7QO1TKWUD2N6O3Z382LCDMOAG67D3CWXQ5YTRG7QRQK9R568X7WF3RLUCOUWNS1BGZQTEFL145VXCOTLA9P5QQ48TERDWLC9ZJ21PM3SW4L86YRX4JVOC5UZ5RAAYHFT2W83V15XF7JVF6B4W3JMZY63YD68M23OZ1FK0YBCO8IFW9T9PFO4723", 59, "4CY88P87PD@email.com", 467, 739, "EZEES57LND46N00E72H81P1GZT7SHO9R78AUVTTGRW5B2DFIYA", "http://8EN8PZGTNJ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "AREUZOWOZ3H770C6MWWEUICT67OEZSSRD30M7EIU3UIW6BGW6TNT6JY1PVX29RYGKZ4EAZ8HNCLAAQX401IGE9V3E87MQPUL6CLGHCWGVGF38Y1972CHJRCKEA9B2V08SAE8EQXXFBV8315QH8OXNMBOABBGCVO9PHL8T35RFOCH6DQNFT33GDVF808CORVTXVTWQ76O", 271, "DSL44F1JGM@email.com", 10, 953, "D7S8K3R6UYBT1U2MWG9352CY3TTLU47HWPZJUW4FIBSZPB1C2G", "http://0146L5T19L.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "4U3JMI11QSN3XJT6NP0QD5CZ28VEQHJPA8ESZCRVOA2X86EUNPREBTI8REQOXWLJI83ZEAHL7FBDDP063A1A0FORZFBUVC72ZTPACPQNHFG5RE5CNUUW5KTDTM998W04HJOT903OUN3U8S9UK8HASK7OAMQ0PQOVPMYH0LCX0FCRQ8EBMOYAPZM6M9TXJD8D8IEW4148", 83, "DGRGXFJ6ZH@email.com", 636, 889, "5UKMIP7BHPNB2OF091511ONWG9TI3RGVTZE5OAY6BRQ407LUCO", "http://0I2RCKKL9D.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "9ZJ8T6JX9GO4DZQSXZ15P9MK0V8QJJ1DX96N7SW15V7S25EDATXVTEY9M9I773OZOLHE2DVECA93C4R4R5PZWFTSL7A7JY3CGIDRXAK77STTF46SSNQCOYCJ1Y25CY5NG7W409HQUR2EW9NRASO5H1YRF4Z9IP5IWFNIHC2TGAR667W1KL4UK9GPIEY6JHIFVURRWFJ7", 671, "GU3VZO7RJ1@email.com", 511, 181, "Z5YHJ1VHH8Y6UL7W889CN6J92MKMPFFEB64PL9FRTRYLTLUKW5", "http://C2T5XRSL93.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "ST6H8QR1A0UXR85MA4VUHAJZWS9Q63DTS5YXXVWJ7FQTHPLV9LQYZPVRJHVPRA4GWBEWJHYOHMWBT0RHGNQVNP3DJGNQAH26LK6GKZL2WBRN2T8SZOJDUI3HHAMD3IO9UZ0I3L6QBY9L8QKZH50W8YMCQZ8KNI8NXR3D3ZZNS2B6JRJ0ZW68R1B5NY2EMWD3ZVYQXH6R", 710, "1TVLIRPJEG@email.com", 30, 500, "GMEGXQ29QIU0M965P7ZE7UB5YHGX22DSZO2FX5I752XEBMR0Z3", "http://XFCB7G0HUZ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "2JE764M0Q891NA74H3PO3X0W999LUT8VQ9ZSOXPOFY3GG61CDC972G6FSS774AG69NKNKPPTOAIE4UPDI7HRTB3KDT960RTES6G3VN1XXPT172L8C4Z62ZN8T9K0PT36REV7NWR4GU3ERBNLIB452WL3TIJWDAIDWWK2GNVPM40I5IQSV9SOY7D422OFM51FL0S51UE5", 302, "Z6ALB4LF3U@email.com", 343, 590, "QOT86C8K11AES3OYSQ9O9PDRDU6E0V0A4W8KOF803DOV4WXSL3", "http://FA9J55EJMS.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "JU5BSXQ7O36JPPF089NLXUATIU5N1WHU92LEA83NNN09X5UTEF7F5B5YUM371DF2WMKXDA09F97J3A5M9LIWZBY77XUYF5VKH8NLV7PEP796EV4TQQ8Q4TCUXMZQPC4KNWB5XU0B5EH2C23M2BHY6FQY62XJI9YMCZSRT956Z7VZLJR5SNYN4GNIGN846R36P40NJM22", 964, "X1EL155P5D@email.com", 52, 51, "FL99U0MWK205LLS6LKKFBB9IEYKRTEWGU5ITHNXQBLTE08UEM4", "http://GFUKPC9Z7W.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "3EZR5RFDFFZCXE7DDHPS2AFIN8GXFBMFEMHSCXQJZ1J0ODSPNM91JP438QE6KS8E2U8L6OBQ0G2B1P4JQ0J2CV5YROTVSU8G2F73FGT9LSACW2CTW4PUJFBGYJ3R5P8GHVIVRAEKHKRUU2BZMA9XFO7WE1F5MBD5U45BUQBV0EM8YRV5HEF5QKB2YVR04I7GGWA07AE6", 840, "G6XWO26G6F@email.com", 941, 661, "8N6AC88WFKXI5IPJ2DN89L0SHF2CQ58G9J6CNB0ZX4UUUZK7G0", "http://KMQIWMM61M.com" });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Service_Type_Id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Service_Type_Id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 9,
                column: "Company_Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 7, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 7, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 22,
                column: "Company_Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 26,
                column: "Company_Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 11, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 11, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 32,
                column: "Company_Id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 34,
                column: "Company_Id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 13, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 13, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 14, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 14, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 14, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 15, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 16, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 45,
                column: "Company_Id",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 17, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 17, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 18, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 51,
                column: "Company_Id",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 19, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 20, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 21, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 21, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 23, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 24, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 24, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 26, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 28, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 28, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 76,
                column: "Company_Id",
                value: 30);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 31, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 31, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 32, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 33, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 33, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 34, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 83,
                column: "Company_Id",
                value: 34);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 84,
                column: "Company_Id",
                value: 34);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 34, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 35, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 36, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 36, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 36, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 37, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 37, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 37, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 37, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 38, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 38, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 38, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 39, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 40, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 40, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 101,
                column: "Company_Id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 42, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 42, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 42, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 42, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 43, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 107,
                column: "Company_Id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 44, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 44, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 45, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 45, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 46, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 46, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 47, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 47, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 48, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 48, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 48, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 49, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 50, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 50, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 50, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 50, 10 });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 2, null, "Samsung" },
                    { 3, null, "Xiaomi" },
                    { 4, null, "Huawei" },
                    { 7, null, "Gorenje" },
                    { 6, null, "Electrolux" },
                    { 30, null, "Toshiba" },
                    { 31, null, "Whirlpool" },
                    { 32, null, "ZyXEL" },
                    { 33, null, "D-Link" },
                    { 34, null, "ZTE" },
                    { 35, null, "Eltex" },
                    { 36, null, "BMW" },
                    { 37, null, "Mersedes" },
                    { 29, null, "Tefal" },
                    { 38, null, "Nissan" },
                    { 40, null, "Lada" },
                    { 41, null, "Toyota" },
                    { 42, null, "Hyundai" },
                    { 49, null, "GT" },
                    { 48, null, "Scott" },
                    { 47, null, "Merida" },
                    { 46, null, "Cannondale" },
                    { 45, null, "Microsoft" },
                    { 39, null, "Audi" },
                    { 28, null, "Rondell" },
                    { 27, null, "Redmond" },
                    { 26, null, "Braun" },
                    { 43, null, "Kia" },
                    { 8, null, "Bosch" },
                    { 9, null, "Simmens" },
                    { 10, null, "Liebherr" },
                    { 11, null, "Asus" },
                    { 12, null, "HP" },
                    { 13, null, "Lenovo" },
                    { 14, null, "Acer" },
                    { 15, null, "Intel" },
                    { 16, null, "AMD" },
                    { 17, null, "Nvidia" },
                    { 18, null, "Samsung" },
                    { 19, null, "LG" },
                    { 20, null, "Canon" },
                    { 21, null, "Nikon" },
                    { 22, null, "Sony" },
                    { 23, null, "Indesit" },
                    { 24, null, "HTC" },
                    { 25, null, "Hansa" },
                    { 5, null, "Beko" },
                    { 44, null, "Reno" },
                    { 1, null, "Apple" },
                    { 50, null, "Giant" },
                    { 51, null, "Honda" },
                    { 52, null, "KAWASAKI" },
                    { 53, null, "YAMAHA" }
                });

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telephone",
                value: "+386317195888");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telephone",
                value: "+387915832492");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telephone",
                value: "+388576221465");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 4,
                column: "Telephone",
                value: "+388814087944");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 5,
                column: "Telephone",
                value: "+382030432942");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 6,
                column: "Telephone",
                value: "+380895515449");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 7,
                column: "Telephone",
                value: "+388022097659");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 8,
                column: "Telephone",
                value: "+385305981729");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Telephone",
                value: "+389103599698");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 10,
                column: "Telephone",
                value: "+382344628095");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 11,
                column: "Telephone",
                value: "+386644778366");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Telephone",
                value: "+389815969870");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 13,
                column: "Telephone",
                value: "+380166729596");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 14,
                column: "Telephone",
                value: "+380077337668");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 15,
                column: "Telephone",
                value: "+380503931959");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 16,
                column: "Telephone",
                value: "+382939540775");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 17,
                column: "Telephone",
                value: "+388349681425");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 18,
                column: "Telephone",
                value: "+389329040373");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 19,
                column: "Telephone",
                value: "+380999307828");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 20,
                column: "Telephone",
                value: "+383091070060");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 21,
                column: "Telephone",
                value: "+382779097480");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 22,
                column: "Telephone",
                value: "+384694483455");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 23,
                column: "Telephone",
                value: "+381313284083");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 24,
                column: "Telephone",
                value: "+384066032994");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 25,
                column: "Telephone",
                value: "+383292460571");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 26,
                column: "Telephone",
                value: "+383650985371");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 27,
                column: "Telephone",
                value: "+385655630230");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 28,
                column: "Telephone",
                value: "+386441284995");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 29,
                column: "Telephone",
                value: "+388837984572");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 30,
                column: "Telephone",
                value: "+388828876360");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 31,
                column: "Telephone",
                value: "+386716591380");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 32,
                column: "Telephone",
                value: "+384532262858");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 33,
                column: "Telephone",
                value: "+389451171625");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 34,
                column: "Telephone",
                value: "+381139817710");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 35,
                column: "Telephone",
                value: "+386076725961");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 36,
                column: "Telephone",
                value: "+384877021048");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 37,
                column: "Telephone",
                value: "+387503932431");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 38,
                column: "Telephone",
                value: "+389575186839");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 39,
                column: "Telephone",
                value: "+382290033586");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 40,
                column: "Telephone",
                value: "+389622319474");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 41,
                column: "Telephone",
                value: "+380054290262");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 42,
                column: "Telephone",
                value: "+385375645935");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 43,
                column: "Telephone",
                value: "+389657233410");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 44,
                column: "Telephone",
                value: "+388218816580");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 45,
                column: "Telephone",
                value: "+382196168669");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 46,
                column: "Telephone",
                value: "+385901535829");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 47,
                column: "Telephone",
                value: "+386606321965");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 48,
                column: "Telephone",
                value: "+387012387856");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 49,
                column: "Telephone",
                value: "+384672481035");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 50,
                column: "Telephone",
                value: "+385829360228");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManufacturers_Company_Id",
                table: "CompanyManufacturers",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManufacturers_Manufacturer_Id",
                table: "CompanyManufacturers",
                column: "Manufacturer_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyManufacturers");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "VZOKN5L16ZZAX9DKPZRS9YUSI4R6Q1ONJMA2Z2VOKD3XSCGLDR8HAB26E6BSNPKELL0K8KUXDDH5579GYG383GNIUEY31CA53YLGM6M27LD637BH654HVLLF8SZ4W15BCLBGV2323BBRCQPXCQ66I2KSNGI4GRFFQC3R54VEBCNTJ3CRDC1G492JBT3PU9WM66B9W72I", 73, "QHZI3ZND41@email.com", 708, 462, "425GP0ITD01DZ8KQKUQLBFUBQBXN2C4FKTLCDW4KLJM3ISW7VU", "http://A6V3GXINXZ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "GA13137O02HN2Z3LW4K6RHQRL7XYQJNHCNKPP5RA28MCTXE694BNC0I8UJS4FJ8QOALPON60NJES4N8X21ZWI9ELEM5FMW4TA5XTMYRV8K93VZDHL4BOTMIO59KCS0O0OVS8ZOLDJDY7ALZPIY4SVP9YXJYMOODH6JOAGER7S7FQXKOUK54365E8W4LQ09Z49QB16ZID", 467, "5KFZQR9C2D@email.com", 636, 317, "G69YKSAM4DBTUJLAEPNM3BGSHKQHIXXVW0X96PYD48VW8FJ0EB", "http://HQQ63WLDY1.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "KS4PUUCB0CHAGJ0QRJP8YBB5OGSIPE378ZBNPZF6O8LZ6GJGGNECYZCIQ9ANC3VWJJBRINA1ETU0ZL8I7LCC91JJW36QZ24VNZQWE172MM8FFMSFA2Q00SWSA25PQTCLY8MA5MDGOKZW2DDJK1Q6LD54C7WL6SL2JWQHARJYZKMQ29Z6ZVEZDG9VDR7801J587MGX6J2", 780, "0IG3JBK6GP@email.com", 579, 801, "S1HB1OCCHZWKNWZDW5DSTL87AQR5XSJ2MMHL884YP50AF9SLHI", "http://ZQ38BPNFYB.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "PCYV72B8FXO7R9VDASY6T1IPBULBR64D60NXUV6RAM0SB183M8O5Q1RX3JUNQARJ3KB0W7TPWH5HA0OJVRYTR8XFJ03KBSAA4RZ10IHPO9JJ5JWD5K19L814X5Q5DINDG5MTAWTMKJESZNJ9E0P01BY6Z4D42LLGVGCA6CDI0OYC3JFJWQ1N2XLFGQ3GTZU8776TLIDB", 424, "W20S9SVQGD@email.com", 689, 409, "XHAMMWCQZ4HLU8N8464QJ6YA30F6NW7NN00VX93UNNRZSJN9U7", "http://D6374H1L5D.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "JC6P9SUMGMP7S918ADXQHDHJN2YLT12W3MFT6KSQ8JK4YFN4G6HYXO5F5WBG4I3OT2DG3HCZUHS82NVIO3FXTD8OQ9XJILVZP6K5CHA94RDQ67MSA32ACF5Q4Y04T2RJV2S6C0GH3G3B9SSTWFJPTVWJB3BNRGPCA44EOQPJXUH6M3QLGHIOSCZAFI5IZ30X00AFYNEG", 831, "8VSQ7E4UKO@email.com", 17, 383, "ZA18O07HNZGK8BT8E49GUGU44TFW2LX3CBZSK0WOLY5AWPZZGB", "http://BBNH6LBYNI.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "V46LTHO4PP1K3PEQGCMW13AJ38JI3OFNWV2DZH6ZZAF5X1I7CPF9L1Q14WRV7GBBKNXHWB19FX71YFVC0MFNIFB5FBJCZK1T8DVJDAKBYF3Y4ZCZBO5VAY2EM2CV2ZK55N2VTM9ZBEYDLNBQ9UBKPGTKKQ7L8ZJ9583Q6RFZPFU59Z380WWHX9PZ4RKDOY1L5YIMUVTR", 443, "FKMBD6NXAF@email.com", 842, 980, "OM4JVXLVX8UMDBL5SEVOHCK1NI9KQQOFCE2LEGDHGYPPDPI4NN", "http://GTPJ9I90MA.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "OISW5Y7AF7DW8G73QKBK0TGTI5YGIWNWRPU710GP8MSCBUVJMF2ZZCK5B9N9911TURETVAB0EWLNADRYKP3C3X6PEY52MGPGU9SUQBXMECVD0748RZYU8ZZ6UYP6EJN7GF3BV7HJ1Q81C3YG37KXS4H5KVA1V0H5YY6UE3MURP2R07309ICH80OL87096PXAJDCO6ECA", 315, "67HCCLKRSR@email.com", 160, 488, "U0FCCZFM2J2MYA68JVWGCNXC11IW4O45FCXIUMJI2OHXXKMIHE", "http://NO6HVMYO6L.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "OOYFAPQO9P0JSOJFPGRB81J64I1D16S0I9DRIBCX45RD0E5S7P7S65NWF1L1XNXD6AATK26OD3GDKFFZMIGL9A3NWQMQ0KARINH0EMHETSOCYJM9VVOOGLE6GW74PPX23Z468PVABB2QV1YMDN5E6VK6JKTRPNZD5VI9OQAG9NNETYKP8U0CUT6IO8XX6EVYMYUASY7X", 512, "Q4AOJ0TNSQ@email.com", 293, 104, "MYESHGNUADS4WWSMZAUQ3MK52Y24DK7KXDZ6ONAIUCX2W0CZFI", "http://ZGIHS7W7L9.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "M50YRIBWCY49OGGJZREXR4CV7WNTT2TK8T1UEL6AY6K3WZ1CAJHF3YRR3E155SCKFTB5PVFOUD8VUI9H4LSJVORJCJ19UBFG3AYCY6XPE3UZ067VETAT93Z1C13F4F4T821TT7T8YDF132TFMF5ABVHAL7A6CRU98B07ENBH9C46Y77JHX3YK3RMV1IW7W5HSF32BVB8", 635, "X3YNY2D74J@email.com", 259, 257, "EXB91KMNA0YPY5ZFTOMNEPJMGXNSEEIVW4UW2SVKO5VH7QTWQX", "http://6RD33LCMA3.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "C8J3CPZE1BQ5VM8B6IEZSMUWZZ4XZLOKI3GYU5LID8G22B5042P4IKKZOXDMUBOPXFW2FJQA75WTG13Y4E276TB7SQK718YBT0FWODUVLO6NY1TW3PSQJRTDDYJZ9TJ8HU9QWGK0THWRXYJ17XDMPH2CGBS045W2E8GD1DAWF17B5CQPOR1LQ7S927JUYT6YV3NYRF94", 298, "FAIRV2BKFP@email.com", 274, 823, "XQHYK0HEVDLMDLLHPHL43P8V5IQBY17JR7X904YB0E9VITUKRG", "http://3FC4GXMQUS.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "KDYQNNLYGTSRWPM6PSEBW0UZFPGZNWFZZ2SCL2EIRNDW7MSWSKI4LS5UT9L7HWKUN3246KUXN6UJW8127TGDNLNG68TMQGB4CTIEUXZIZVQP8V7UHSAXPHGCPV781IGH4ZHDZXIJ48O258ILB8E8FNP5NGY8Z1RRPIUJO44UJ13R2NGRNW72DHCRKMZT8JTCQ6NWN97G", 273, "5B28ZH46G8@email.com", 464, 13, "DUZOU7C99HVD4YNHGD8BELV9H0A5ATDOZ0YTSX6MK0U1YQI2TF", "http://PEHND93ZSH.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "V1O14K1RIM5D3N4Y6U2QBQD1EXRCF20Q8CODXBEOPMY4DMK3TPDI6CFFYXWH3YMPWOF181B4QOAZ1JX1MXT0ZRU57JP9O6U1AIHYHS42NI2RBQNO944FFV0E4J4ZMBQT3JYSB8U430MRZC4Q5AATCPVOSD48YEQL1IY224MAKAMPJIP2ON4LB6ROXJA8EWFYKAZQOCYA", 135, "FGJCVHNB60@email.com", 707, 941, "X9JCCGFJYBTLKEK51JES4O6X5YEIT8OMY3XCWPMRD0KDC4NF03", "http://ZXHWQRHIM7.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "WPEE3VAK9SZIJOSXN9AH8PG9UP5H6XSUNHL0BFJAGCCOARO2D3DIIE8HIETNZ3NLAF5BD2VIZAB5N29DBDDDUJMIJDS7V6LMZ0O5VMYLH5SHCC3PFQMWZK102X29KYW3ZZGWODSYO26Y1EGGKC1FUZWO9XC8UZBTIZSN6HBB8XH7OC9XQVZI6RJAC1W0BTEZ1NQBW2KC", 96, "GRY02O9U9L@email.com", 598, 504, "A0G7RZA7YOR892W1QSKEULAOSSFBV7BYKWHFKMSM1ZBWCF080Z", "http://1M3XMVQQEA.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "8N5KNLN1HK6L8FEFSPS7T21NJJJRNNJJRDT3VOMQBHMZPPOXTHCB7GRFVSAEC5O3BX45VLTEDC6LPC845W8GLILKWOHDOINF3TY1VTBIX884KFZSTFJP7IS2LTIHDPZ5Y0S6OGJLV0SMKQAQYYTJ88IVA5QBK3EHJDGTX3EM674GZFS4T2SO5Q60S75T0HA1VKDHKR35", 840, "C88UXEAQQ3@email.com", 18, 443, "UGMBDB55NVRSL0M2GQB07VWY6DVOBKUC8X3YD5WQBAFFZSQ48L", "http://CAPTX6XYL3.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "VZ6PQ8OW0Q0K0W5Y5EQ0W9UHDEJ828LWYB4NBTEYZNZAC2K3X8BTIUGVEYMMYP42EEVZ1SXL91AJJTEK4QK362NE4JIMG19JS758HVCFLZTQU6LUUBSIFA6M0R4SJKFI200MYGDINFRGJ6T77X2EJ0ERBSH00U6BULY3G96N8J5ATZD476UVRA8BWJLF9NR3IQW8I018", 603, "4K9AVJ3M6I@email.com", 594, 554, "1OGA5E8LPN339KTTMWG6X1OU1C1CCEVGFW4C37GSK9ZWUX386C", "http://K1WYMQRZPQ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "YWXB2ADI3GAT9WKM4BIXNFO0O479RSPMFF5IW7IUGUTZI11AOAVPR1CSI6X7DE1K0XN40CZ63XR2WYSXD6UQ6A4OCM9ZKLRB3I9UN6JLKYV4JK6TOA3GTKO0392OC9WRGP8NZ7JGXIGHOAE2QQLKRKST4I1NE5JLCEY3LT4Q0XTKDGL25A8WYLA57PSQG5B195FKMKQ6", 567, "U6GTZI86GX@email.com", 173, 393, "V4U40HPY79SE7WW1E266AOK4V2LIABQVTBB31FFZ94TGN74MIO", "http://5T7U5V398W.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "G6F5DRY78AW55G9E4JC6H32GXXPM90POH8HX0LQHUA7GB9X0V11T6BOND9HQCL8IVHX79LNT35LH5WEXAZ0H95RFT4U1DAFJBZV4MZ1KNHZB0HRR4UPMU0IZZSOE1WQ3ZCFGAKLK7Q41GQPLMC6TU2YLR6E4LWT116MYCLQUIFPE6QTJCC1YZ7I7N3ZEGR8L7CAJD1JB", 680, "APK8THJNVU@email.com", 610, 453, "VMKONUOAM51J44B4XPKIWLO1GEG3QJFL30CNW4T2PY2K0ZQCBF", "http://DZPPE1XH35.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "S37TDBRXE2KXR53L2PDWKO4EYVKJLKN8238GR04R0VJ2JPIUW39IEHUD934R0HL3OM5Y7W4BUV5ZFB4JM0XSLF4UI4HX6M0SJPO7UUW997XSL5788VFAU3SIRKQCPGFI4MPZW6Z2DXTNSMJM6IZKH08Q7FPKEUU21PX8QILC6M66JF0FBDFGR5AEN82QQPYTC0VDZK5Y", 178, "NICB7HQIYI@email.com", 678, 698, "7WO53CH2PKIAOOL6OSVRQ4VRXN3STWQ1IRJ4QEKL1AAGGYEYPY", "http://33R17FRQKI.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "J0Q4OL9JFD48KB4IG2T73DC1HMY6GS7IO7PW2IWWIHDVO4TP6Y8Y7MOGYZWCWCCWGWTMWHQ8G6YW9QMM3I9SUILBTJ8CVU9FEQP2LH3YHASAX2GHMJJOCUC7KS2MJOMV7SRTBUBVOKKTZLN1D00MLVDUORR2ORP3X7CFKWF1HX91KSI9EBJSXAKMP6FTCIH75Q62IIQQ", 503, "C98JFHSPQJ@email.com", 165, 529, "U8EXVLK5JSYMI6GXW0ZNRWY9QC63WP15V27Y5W0EWJKUU4Y8KI", "http://3120P9R199.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "V1HLEOVN7TNJIMT38O0PIYFAQ32EJ92RGS7K1WF0WER76USPHVADAU16VH5KWRE715D0PICLIA2DGIE6LM6X9YQV1AYT15EFAUFAQ1A8TY4A1XZND98JUQ8COR8OTSUN6XCWCEPTM8EL4Q4DLLQ164VUWDV93VPADREEVCK8TO7WMWI8X5DIB2QBCSA9SQ00TDHMMZSI", 293, "QGYBE4058U@email.com", 309, 641, "ARHS78H94WL8SG9KBCCCCLQDXGDJO6V8M4HTU8EDKBE5E2IMD7", "http://8BNVY9PZD7.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "91AHU8481FRULL6XTRQDOHMRF41HTNXHHNYYFQRF92E3CN0CZAQ8J9T1PTCZHXONRKN7XISCAKEVDSO1EZST6Z7I46IWO18LO0M1A2PRSN7857Y7FLVRF4R1MED095YIM2HMGW0MKABT19N6ILRCGQFTJUO6YYRWZYWC0L0SVJHE379N1GSXOVC5WYCVH3XVTP3DNLG6", 612, "FXQY0LWPLI@email.com", 470, 888, "U8R7JAZLUBFSG3HDW1PBJEK1VWVOD6AQ9VCPDFVV80BGYFOZH0", "http://YBZSU01AQF.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "3DSDDCQH6GNPOU48W1N38GWSMF9W38Q0AQCBEMUY5OSF4IWEXWE9WXGWQ918C3O80XP7R33KGY8UYRXDS49H4QDNKQVEVWWCATPH3ZX42338YW78MXPH3GEJUCXAHZZUC5TFCQK3HEPAXFYYSW28GOI3OFX0CWWDEI53C265MWAZ1EWOO9RV61NYX0062T1URM6OJ4V0", 60, "IYZ33Z7LWC@email.com", 535, 697, "Z6VUOTBKTIMDEAGN5HFMB9D24QHPHHFTN169F2KEYPNUHYPRFT", "http://LD3ZNEGHC7.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "BYWWSVGA0JYYD4ECGGMDM2BMBRO8BM8LQEXUCDKHS7VMOX98UL8A59VIWJUBHH9NKMH8GU9C5EUPHY8ORPO0N8QRTP73TIAL7HBBPB2AL6E0OGB7LFU13I9M6ZO1XGSWEJR9X69PXNPR30DNN9SOYJRZHZFZWAMENSWFYBKOFFEP3STGWBNXYE8522281J2WAKELD7YM", 353, "1DMRLHXWML@email.com", 753, 557, "YDITFB5ZF8DVWZPIU1N6IMW6MROSOHCZMB9U6OZ06D23GHAL45", "http://86NIV04MFB.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "WAFU3ZFRDYSQZFV7XDUHCET24628OVATVL7181XWCGTY2RGIXYD1179SQN067GCRX94OH495P8F5V59M0TL0SJ1YMPKUB1Z5DBA2W2B2YHL32D6VNNGN4M8OIGC2TO3YJJ1T4G07SSBL776ISZGXULB1DVUP0IJJNWUSMN0GWI4MLXRKK3K4IGD7IAQIWKHJJ17LNO5E", 729, "THQPYL6W5Z@email.com", 794, 126, "8AAMRYPPEKF68OBHSXJM7RUMBUCT0F668F5IF1PTUAEMFLL4ZZ", "http://8NI83S3C0H.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "Z16NIGZJI3ANG1O7P2QQT7YKF86NRL6WBSO1KCHSVWNCZVHQT5DBWKY1DWIJJM267NLXNXWMU756UWVT1Q4VI5A14WYY47JJ4QELKTD5J0QYO1HRAZS3SGYCNT2098SXYWCDRKIIM8MRPLMDOGXEPP0X2C700N6KI2A2YE90QKQU4GXBHZL2KNII5OKPMSR8BBJWLUPK", 536, "FPXS0MRXBY@email.com", 41, 648, "H6YE9G3VP5TBCE94U16J4UO72RS27A0WKBUOZDJZUY9Q9Q67BP", "http://OE61ATVERS.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "HYFU78MVV0S9H9EV75912BTAVLCZ5NPKUAPQKCU196CKGO76WPV0F00FFF8W5XZHKHPGTYK4KH169J4GOGCQ2ZF3KJLFD85MG49890M8E0P784G5K2IZUJPVCV5KMF1MLPZEK5HX3ELBKH5QDP4L0G17PN6N4CV99CVTECVPUU6Q7NL40PG6LPWFX1Y69320SMBHWLLA", 174, "8XF99NDNO0@email.com", 740, 452, "4P0FJL9CCBXP5YXUQP5NNZP11F7VLDIODGC6YQ6M1W38GN44YR", "http://82JMZW15AT.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "TV16RVOLD74NC8ET76YC28N64F6BEH7W0W6N5JSO92JR6V0LIGY5G71UH4BLYNG59HWPB0XYNKD9Y69IOV38TCP25MGBHH0WVORY9KKRTAR6415K436CUIM723UYTVRGTQNKPLJELLOSUT8DR6GOKXBNBT6F0V77TKMNNU4TT21I44MJ5QHXPC66OAJ5PENZNQ9KGU06", 742, "NUCSPC47FM@email.com", 882, 602, "BW4R53THGXJJOKSQOP8NL9EPPB5N4CCL0LW3IOAVRCY24DLD8S", "http://EU8TDYYI9P.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "N5JKMUL01PMGLZN0UL2MGXLZUH6UIPJK6LIRL1F40DF0A7IJGMDNPWIZUTZFY0SMFCKAQ6O2F8VCRVZX8XO5L54JCT61CAGAV3U8WI2K8LIRAFH94CGBMXBJHA779W0E2VRYA1A05E6AXNI6L7794EX71K0WK4KLVDYPYS8DCQGI0BW41BVBZ0KX8U6ZANPA3VPTY3I3", 633, "EHZ1IO29DE@email.com", 725, 346, "847O8PH0Y64JJJV43BREWJCYAFPEWDG822C536YSMFBETG1TAU", "http://V06QQG0A7M.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "81QI7F3O5EBMTVYVMDUR5SJBPOX0KMJU2KON0R4DVOE8DIGK253WPPQPSP2TRCES4RUJHK45JR6ROK7HHM8OSXEN384LYKVSJVDWY7CRB8N8S9AHRVLFE09HNGPIQTG85OH2GLSJJQNUJF437X4D9QNTV6IRR4BS1PDD1IAFCB5YMP8HLWK2ZD9OBYGKCB2PP524B1CZ", 347, "8X6W9XEQZT@email.com", 405, 677, "WYB7UZGG8BF5TI2YPZCDB0CBJQIRWDGUTVFACB3LRAMB566GCD", "http://45VM7C2WO5.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "1WBOAGNUCPTY36U7IOCNZ52RRGJU8DJRAQ7MWSV3KUOJAFBZ1A3OUAG54U6462V8FCYM8HK02IDERSQLFU28J56AKBSCV17R9PD8RY0TZDVL6COLDVYLAXYKFYC7ZIEBLVFBOS3Q4JIGJVDIXG9ACWRL0223W24R9UAL6M7U1IQ0OSBUU3KSIE8ZD3LV0A3BO1GYU2LK", 277, "II8URO0OK5@email.com", 67, 581, "JOI3F07H1II3SLI4WKHDBL40POMXLN92RAI45ETN5D4R2ATCSM", "http://NIQLSDO9R0.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "4H7QM8O5JE9KZHJ1KJN038VIQJLZA9ENVT0ALRHT94FG5CTJB12EV075VZADXZ5JAWZGQIP3C4083PMNZCXIH914V5OWQE5K96GJNM22L9C0A9BGMWNUBWCA45VU33M79Q87JDANK47H7B4W3IJ40LIN3FOS1H9SXE1TAE7JWAKHZ4D3A81VTRHXIVDDYSVC5OT2KKWY", 186, "HXRODL2ZNY@email.com", 861, 972, "K9H0AAY9CVR2QN8F7DLOB3VEOILKKKS0MCKUJQWH7EBDA2VRQO", "http://1C1QODO5RR.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "ER72RDWW346PM1FP3FGE3STQJAJMHOBSNZ4ZZY6AZG5T1M09K8JIZMXW8RTR3JPP2OBW6PZEIFPXW9Y6JJBIE23BCI1HFPGP0Q1NKED5JFAT79982WITIGK9VATYXR83896GILWFGG992JEDI3OTHXHUF12KUPH1GHV7C3ZR9CMBHLGL5QP4DPWL1MAQTLV19I2VYGAP", 391, "KX585WZDOL@email.com", 21, 5, "E7TEKGN4VQPD9NY0UJG02I8YRVC8SVXYQ90F6RAV9G5C6R1VUC", "http://920XAXS4CJ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "V0VN51A3QOQUJYGL4GB5LRU45JG418CH7EOTCSCDW5X95PTBQY2L3H8DG0RWVFCRMIWFJWJME7IP4U9Q0ENDG0O0GKNLBQSR3FXW2O24OQH59TJV1A5R19LV4688J8KXP1VZ7MYMMTYZTS0XB2UBVAZ43B25P3UQFTQI7UXPLSFIKVCLFL7ROJCOB055T27S8HT9CSZR", 19, "S2MJHRJHQG@email.com", 507, 343, "EFZC5RTI9Q0D5DC6RBGGY15SVWJDBCJXWQMJT9TUGX6DC3X4FX", "http://6HCRP13MSS.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "VAB51P19O8NUIKDX99MSJN0Q959LHDLKAS0S0QS1ZK2S2M82O214A9IIJV65PQ1LWDU0TV6SQU39UHXW7H7OMRKAJSIFUWMISR6Z2HI35INPGJXC7J8ISM9F2TRBM084IURDL83Z9ETDD4495GIKXD0FS07J0HQEKSHW2T18QJIO35B7ZRGGSXGE3LUUBU82XO3UXHHL", 594, "1MIL8EOV6V@email.com", 237, 433, "PJ4O5MLXZ9TIAKWWMC2Q9G75KQ0PBQJRJ41J32JRA74BA01N1H", "http://IZC8GTN2U3.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "KPBL64TZNX4IYCSSS74X45EMWL81U3OOY2FLL6PDUZII0ABAQXAP768OLYZU62ETJPT56GHWS0CFX6WWK8L728Q140AWG4H2UZ9KQFDJQO7H321PCDK8RH0K82BGGUPXTKV86LGE5BROBJ7C9UUDUJKN8YMXE6D58KXTG3S06GDQ0MJY49HV9LCJ9HAI9SA87VP0WO5F", 232, "5M1C2IBMSY@email.com", 527, 855, "C4GOG4XVPX3EZS5XHNT93K1OFESE7SCQEBTFEYDEUO2MY5JPZ2", "http://6UN9X90SSJ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "OOORPZK5COF94VIZ1DMQC2BZ51L6VQ9J98QR7JXC8FJET70218IXGCHWMYWXOOJWO596F11RPJS6S7G8BTEXIMD704EJX9YT5XZX74X9H0H6UKDPSYW4JWNC2CFKWS3QU8A5ISAH6FQRFGNQ1Y09N4KJKX55YMMZ71LVJHH9XP8EG56VYYT814C0X1VUXFSU20UO41GT", 276, "X64N4BR5YC@email.com", 717, 841, "R0M85GDO0KGA2O7DYV7SWWMR6OLPLS06SAQASE5RXH4N8S2N3R", "http://ITJR187VTZ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "Q5P29SOW7W42QC5DVXXDNW8EV3ZAAP66GTN2RCNLW57CIPCGWXMJ7PM46LGG3NVS07W6YDWSJMQRY65G0SONCW80HT5G6HRJKPMK3GSTA3AU84FAP9PL9HPE95ZEHQWB4HHJUVNUA5MIVO1MO5162GKC9IL7QNLUG9Z1W5Q4W4KD5GSUDM0MY0JY7FKLJPDXT1BWYA0S", 622, "I6KMCGIVDY@email.com", 909, 189, "P7J76GH3Z03EW95QZB3RVEUH0XUDE66DWI71RM217QWSV9AT5V", "http://340SOCE8NJ.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "CUESBV1XAHS9K6NLWOPFTF323Y5QVR1WTMEY22LQPVV6F3T3EDPZTH060MZMZKBTP6Q72ZT4D808U7W9ECMSBCCLWH8PD81ETCQJNWBPUVVVR1M2ZZHX8SRN3ELU1D1EGWOSQMWSA78QRR445FZN0EGBVDQILQXQ3QP5N4LNCZWBUA6LJQZVNNOCPN7N6OHUJSWAC9RB", 712, "RD45WSPNPH@email.com", 942, 572, "3MLBRFRUHE941BCQCMP978QYSC1BN5JJ8Y2BCMUK6MF1PM2IPG", "http://M4Z6CJBOZ1.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "EDU3ZJGJTWG7UZQU7FP3F6QE36ZQ08O2I7QOTBGNMG43AOKAPSL585WHWQ92TZTUHOZWJCB69CR8CXEPVZBHXT4MKI1DBN3WXJVWYY0MRO55OYF8LUG4YL6YUMLAL85WJ4L2CR078Y0JX87WD21QG98MN6BMM0BTTIWUNM644J5AUXAWOY7SGOQJ59PFQOUIXHZOLNJ1", 947, "54FTFHQVN1@email.com", 612, 682, "67V6E81Z6P7X3SME2NYO60OQZXMN7VKBPGWJ3TF7H0IAR6PE5V", "http://LE5IX6CKJH.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "0GGRN92HISM9MNULR0XLYM4875VY1I2KM07ZXXFFOJM5PM1SYLOLX8SOLIURNEP9ZBWWP4Y3VS6P98SVDD9Q3RXOHTNOCX2K3MFOZFC3WU0FBDON08OJE9GINIO6RJ18ZWWW2D68AG3I0SNEEAYDJSF3G7AQ0GLN32POR1UWCPJ8F7R45K1RVXYHR2Q5CPH45QO8D9XM", 863, "8B1SOU4E9Z@email.com", 871, 76, "QCB3JHYIPGUQO42GDI6YLYTWIODZTS16XPASV57KEHP640QAYI", "http://6OY393JUHK.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "VUDIW1R8CBKX63YOIAHKDGESSSG7QGOXXUQO7S6XD6B8OJS5EVUJN6HPPU0EVTR6WX9LMKQ0DUHGFGEJ9L35VFK1NB8N21BTOFM1JGS3E4F3YAKIQQEK0VKQMI8KLD7MSY194M932910ARCM106LW13345PAIHSB72KAIKNDQLR04TQ5GVTVGVZ058E978VVRZ3HGCDR", 610, "3L7WMUO34U@email.com", 120, 921, "M25LKC9KPT4WY64MDUEKFOGS06JE0IYERCJO0OQ293TNE86V5Q", "http://G50EWWQVYE.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "MKM42N19YJKECGY0L2N3C9EJNSN4K8O5PRVS9D393OFVKC2TQ5KYI4CMFCRK96ZZ4OYVVF1I8OAX4T9KZ4OPX0WVPIM6VT96ZP05NH7LDCZ44ORWCGUFSKCE1DGN24WPOD8P3E7S6DLUA21A004P83OONVDKBUSIPKP0QC27JCJP8RD9MFWBAHQVZTCHBWQMUCFZNAUX", 549, "YXO9TLXDVT@email.com", 864, 990, "86G6U8Q6RE857RII43A6AU6WV655MOVLV8CDBTB0DF07YVPC46", "http://DSXK8OEHL2.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "J344989R2BPTBL7LYDRHNXRWWOBKQYZZT0Z42TAULGKTEUQLNXZBZDPWLIHU7ZAEM09KWCSFD75HN8RC8Z738Y9QLDTULQXWFGHNVFZKEU72HIJM1FVH1HFY0S9SS83WKJBG0DR2AWZN0HID4G2G4P57ATXCGG2F1KR8GCVXY3GER27TK6YMFW24OEGHQPW44UWPZK61", 68, "45G9I45RSC@email.com", 907, 735, "UFSBI0PIVD2JSQ9ESXUC6OGJGMJ7GS39961AE0VXY7VMXMLOUR", "http://DK2KVY991B.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "7N823W3B4NYV0IEAVA650FG5SC4CZ0VREB3Q7NFWB4WFNRTTFVD8D5K1HCK111LE1GQZPYDH5J46SARASK7EWWOI0CI4DO4JSSNHA3ERR6D4BOIGUJIQ4HRF2H9NPIEROUNAXK9YGQW0TUHL3BK3FNPLAIP240BJ1WPQBITKJTKOU1VIAYTN8KLAFB9P5G4QON87E1JV", 725, "KMOVQ6KBUP@email.com", 623, 449, "SATVDB1IWH2FGXKQKOL9IDOCZ39G3YDJO848106EK02YOYJ0CR", "http://7DT1H2MZUR.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "HYRK0YAUJDLCN3EWQNK3WC0L5U57B702CIJV4E426Z2QD500XVM9O04E8GPG3CSLNTAETS1LSS77KJH93EKQU1NLNEWXYY93HQDT5VGE3AQ6374Y8QMY1C0WGY1P5DX3TDZ3GYEI8GWTKRSPK8YIMKCE0QNG41IZNXMZIARKLEZVQGLZGLE7PPRIBVDZK7NH76GWE2HJ", 10, "UMYNSRC2ET@email.com", 475, 133, "QN6IVQYTEY9SWLK8FEXW71AO0SYTAYUND4QBSJXV6TVW75UWVI", "http://PDWO14JQ6Q.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "C0NGNQ57B82HUJTS1XA1U229FTLQ31M1UTB48SACWF0F1ITM5JCWPF6K7NB4EOEKWAXAHYTJX7EPBWI6A8UTYZMOX16UQG7HAQT1USFHZ29SBQILFE4F4UV6YINP193R96OVCQMR3N3603NGSVOLL2NQ5XDMFZP09RSECXIY2MMQ0YF44H6FUSFHS8ZPNAMD8D6ILJD5", 14, "96UO19HOBO@email.com", 890, 638, "N0T9Q7ZGRJR73JGRMKWE82L29JSX26SVDB248F1VIS7ESOKY7P", "http://U0541RLSGT.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "B5P4HJV840MAS8EEIPHGTGGDNNWUSHV6ZQVDRZHROIULBUI70WJ6KAA4YLR3WAPXEPLBMAXSHZ2LV5C2FZ367YWYQ1OFHO5N27HVIGUZ80ZUIYJ3JYX7HTZQ3XVVVSK24OSYXQU9EE7H9BP1RV5S18GJI12VV9EQP603GVF3EX2CWRQ2H3DAW2B5IJP6Y8OEAQ1DKWV6", 433, "Z1H6I4SARA@email.com", 232, 23, "PCNDFDX0K9O15D3X44V6FIFFJXCF0NSVHGUUO70FWZWYUWJ6WE", "http://7Q3UYTJI7E.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "QKPWQUXOGSVECUSPNXGDHEEZZI1CUNN5KKUOMVQXGD49O2OIBJGVC36LFZ6I3V43FZ329DD2HS6EKFL64SALG13RNIJWYI4VJA4Z8WJ8FOOT72BAOAOKUTWN6MO14QD8YK5JLW8IJCF2NJTVGIIY4TA0OQ2VHSDYKP5W72Z2BGASO39W32UVIPEEKF543MA18QS7O7YO", 653, "6RYR7SJ7OJ@email.com", 634, 582, "TQWYTSMURF2P7SQ4L0M2758YGJU7KBI5EFB23QV23KMXUU3PAX", "http://P76L2QXB4E.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "U9WSLEVPE7XOVKIYNL58L4OA70XJB8NW2SA64GG2642QWAMVDEDLF63ZUWUURMOGUAWCKL3GFCBRB7N6OBF75BQ5ZKMHVVLUQW6WNJL1K6GD4LXWIYGPGRKSU1N98VVT1RBPB1SE0OW84NBNWZ97O6N8LNBW6M2YLWLMKIVQFBZ24MYG09MJWYF4ECDXZ6IOV8XIBYDO", 567, "5KF1ST6OHJ@email.com", 735, 440, "DS1NHVE8Z4669TBWRQIHE81I3KH6ZPFB67FE61XS8E849LOB6A", "http://JZ4ACN70Z3.com" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Dislikes", "Email", "Likes", "Popularity", "SmallDescription", "WebSiteUrl" },
                values: new object[] { "ZI9A6IR6F9ZZVWAX9NNI1E15YFFLMX9JA10XKF4JC9IHUUEIAOOTMRCURDL1DFURAPY45MM4SDF16TLEA6K7JP7TYFFG4DG7O1HF5KMXBTAJMKY82H0G5XHUSFF0HFAP7INELFJ0TW5ZOXGORHNWN9C1TWXZFWQ5TVME7TWX89XI1RF480IA2NB7GVVZSTV6G9F2LCR7", 936, "G9XWJ9V2HZ@email.com", 242, 118, "U0YOM39BQ31POQDGUO8L87EPO0B2LMS6ILPBYXVMWTIZ2GS059", "http://DK4GCACS62.com" });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Service_Type_Id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Service_Type_Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 9,
                column: "Company_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 22,
                column: "Company_Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 7, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 26,
                column: "Company_Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 32,
                column: "Company_Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 34,
                column: "Company_Id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 13, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 14, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 15, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 45,
                column: "Company_Id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 15, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 15, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 16, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 16, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 51,
                column: "Company_Id",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 17, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 17, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 18, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 18, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 18, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 18, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 19, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 19, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 21, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 21, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 22, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 23, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 23, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 23, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 23, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 24, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 24, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 76,
                column: "Company_Id",
                value: 24);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 24, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 26, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 27, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 83,
                column: "Company_Id",
                value: 27);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 84,
                column: "Company_Id",
                value: 27);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 28, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 29, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 30, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 30, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 30, 9 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 31, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 32, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 32, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 32, 6 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 32, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 33, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 33, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 33, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 34, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 34, 2 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 101,
                column: "Company_Id",
                value: 35);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 35, 3 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 36, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 36, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 37, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 107,
                column: "Company_Id",
                value: 37);

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 38, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 38, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 39, 5 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 39, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 40, 1 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 41, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 41, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 42, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 43, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 43, 11 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 43, 8 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 44, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 45, 7 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 45, 10 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 45, 4 });

            migrationBuilder.UpdateData(
                table: "CompanyServiceType",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Company_Id", "Service_Type_Id" },
                values: new object[] { 46, 7 });

            migrationBuilder.InsertData(
                table: "CompanyServiceType",
                columns: new[] { "Id", "Company_Id", "Service_Type_Id" },
                values: new object[,]
                {
                    { 125, 47, 8 },
                    { 126, 47, 4 },
                    { 127, 47, 10 },
                    { 128, 48, 9 },
                    { 129, 48, 9 },
                    { 130, 48, 6 },
                    { 131, 48, 11 },
                    { 132, 49, 10 },
                    { 133, 49, 11 },
                    { 134, 49, 2 },
                    { 135, 50, 7 },
                    { 136, 50, 5 },
                    { 137, 50, 1 },
                    { 124, 47, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telephone",
                value: "+386746462239");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telephone",
                value: "+383157037446");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telephone",
                value: "+389548149947");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 4,
                column: "Telephone",
                value: "+388431545926");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 5,
                column: "Telephone",
                value: "+387343397017");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 6,
                column: "Telephone",
                value: "+382602702559");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 7,
                column: "Telephone",
                value: "+387275087425");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 8,
                column: "Telephone",
                value: "+387827850041");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 9,
                column: "Telephone",
                value: "+386887413034");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 10,
                column: "Telephone",
                value: "+381932956825");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 11,
                column: "Telephone",
                value: "+381375944232");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 12,
                column: "Telephone",
                value: "+389114383019");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 13,
                column: "Telephone",
                value: "+384708484983");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 14,
                column: "Telephone",
                value: "+389189930370");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 15,
                column: "Telephone",
                value: "+386061498980");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 16,
                column: "Telephone",
                value: "+382572042911");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 17,
                column: "Telephone",
                value: "+389440283249");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 18,
                column: "Telephone",
                value: "+387930230934");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 19,
                column: "Telephone",
                value: "+389407033694");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 20,
                column: "Telephone",
                value: "+381125026686");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 21,
                column: "Telephone",
                value: "+386649322796");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 22,
                column: "Telephone",
                value: "+384256153698");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 23,
                column: "Telephone",
                value: "+384630767790");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 24,
                column: "Telephone",
                value: "+387407730148");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 25,
                column: "Telephone",
                value: "+381662085545");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 26,
                column: "Telephone",
                value: "+388960193426");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 27,
                column: "Telephone",
                value: "+384579902797");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 28,
                column: "Telephone",
                value: "+384221770008");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 29,
                column: "Telephone",
                value: "+380133177067");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 30,
                column: "Telephone",
                value: "+380597358639");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 31,
                column: "Telephone",
                value: "+386766067534");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 32,
                column: "Telephone",
                value: "+389243532472");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 33,
                column: "Telephone",
                value: "+382211793471");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 34,
                column: "Telephone",
                value: "+388370235625");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 35,
                column: "Telephone",
                value: "+389261881520");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 36,
                column: "Telephone",
                value: "+383490746491");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 37,
                column: "Telephone",
                value: "+382371555312");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 38,
                column: "Telephone",
                value: "+387511295938");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 39,
                column: "Telephone",
                value: "+387727744637");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 40,
                column: "Telephone",
                value: "+386071365462");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 41,
                column: "Telephone",
                value: "+383749282787");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 42,
                column: "Telephone",
                value: "+388610351040");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 43,
                column: "Telephone",
                value: "+380803577086");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 44,
                column: "Telephone",
                value: "+384030503249");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 45,
                column: "Telephone",
                value: "+381785809777");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 46,
                column: "Telephone",
                value: "+385406247045");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 47,
                column: "Telephone",
                value: "+380282383143");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 48,
                column: "Telephone",
                value: "+382855830555");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 49,
                column: "Telephone",
                value: "+388030090680");

            migrationBuilder.UpdateData(
                table: "Telephones",
                keyColumn: "Id",
                keyValue: 50,
                column: "Telephone",
                value: "+382289898510");
        }
    }
}
