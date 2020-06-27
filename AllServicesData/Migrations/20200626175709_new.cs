using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllServicesData.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Access_Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Acceess_Id = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Access",
                        column: x => x.Acceess_Id,
                        principalTable: "Access",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceType_EquipmentTypes",
                        column: x => x.ServiceType_Id,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepairCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Service_Type_Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairCategories_ServiceType",
                        column: x => x.Service_Type_Id,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    LogoUrl = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false, defaultValue: "0"),
                    SmallDescription = table.Column<string>(nullable: false),
                    Popularity = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false, defaultValue: 0),
                    Dislikes = table.Column<int>(nullable: false, defaultValue: 0),
                    AccessId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Access_AccessId",
                        column: x => x.AccessId,
                        principalTable: "Access",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_User",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    EquipmentType_Id = table.Column<int>(nullable: false),
                    Manufacturer_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_EquipmentTypes",
                        column: x => x.EquipmentType_Id,
                        principalTable: "EquipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_Manufacturers",
                        column: x => x.Manufacturer_Id,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Company_Id = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyAddress",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Image_Id = table.Column<int>(nullable: false),
                    Company_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyImage",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Image_CompanyImage",
                        column: x => x.Image_Id,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyServiceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Company_Id = table.Column<int>(nullable: false),
                    Service_Type_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyServiceType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyServiceType_Service_Type",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyServiceType_User",
                        column: x => x.Service_Type_Id,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Telephone = table.Column<string>(maxLength: 30, nullable: false),
                    Company_Id = table.Column<int>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telephones_Company",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Access",
                columns: new[] { "Id", "Access_Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Company" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path" },
                values: new object[] { 1, "All-Service_default-image.jpg", "/Images/All-Service_default-image.jpg" });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Смартфоны и гаджеты" },
                    { 2, null, "Техника для кухни" },
                    { 3, null, "Техника для дома" },
                    { 4, null, "Компьютеры и ноутбуки" },
                    { 5, null, "Телевизоры, аудио, видео" },
                    { 6, null, "Фото и видео" },
                    { 7, null, "Велосипеды и самокаты" },
                    { 8, null, "Автомобили и мотоциклы" },
                    { 9, null, "Сантехника" },
                    { 10, null, "Строительство" },
                    { 11, null, "Бензо-электроинструмент" },
                    { 12, null, "Игры и развлечения" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Acceess_Id", "Adress", "Email", "FirstName", "LastName", "PasswordHash", "Telephone", "Token" },
                values: new object[] { 1, 1, "admin", "admin", "admin", "admin", "admin", "admin", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Acceess_Id", "Adress", "Email", "FirstName", "LastName", "PasswordHash", "Telephone", "Token" },
                values: new object[] { 2, 2, "user", "user", "user", "user", "user", "user", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Acceess_Id", "Adress", "Email", "FirstName", "LastName", "PasswordHash", "Telephone", "Token" },
                values: new object[] { 3, 3, "company", "company", "company", "company", "company", "company", null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccessId", "Description", "Dislikes", "Email", "Likes", "LogoUrl", "Name", "Popularity", "SmallDescription", "User_Id", "WebSiteUrl" },
                values: new object[,]
                {
                    { 1, null, "VZOKN5L16ZZAX9DKPZRS9YUSI4R6Q1ONJMA2Z2VOKD3XSCGLDR8HAB26E6BSNPKELL0K8KUXDDH5579GYG383GNIUEY31CA53YLGM6M27LD637BH654HVLLF8SZ4W15BCLBGV2323BBRCQPXCQ66I2KSNGI4GRFFQC3R54VEBCNTJ3CRDC1G492JBT3PU9WM66B9W72I", 73, "QHZI3ZND41@email.com", 708, "/Images/All-Service_default-image.jpg", "RandomCompany-1", 462, "425GP0ITD01DZ8KQKUQLBFUBQBXN2C4FKTLCDW4KLJM3ISW7VU", 3, "http://A6V3GXINXZ.com" },
                    { 28, null, "N5JKMUL01PMGLZN0UL2MGXLZUH6UIPJK6LIRL1F40DF0A7IJGMDNPWIZUTZFY0SMFCKAQ6O2F8VCRVZX8XO5L54JCT61CAGAV3U8WI2K8LIRAFH94CGBMXBJHA779W0E2VRYA1A05E6AXNI6L7794EX71K0WK4KLVDYPYS8DCQGI0BW41BVBZ0KX8U6ZANPA3VPTY3I3", 633, "EHZ1IO29DE@email.com", 725, "/Images/All-Service_default-image.jpg", "RandomCompany-28", 346, "847O8PH0Y64JJJV43BREWJCYAFPEWDG822C536YSMFBETG1TAU", 3, "http://V06QQG0A7M.com" },
                    { 29, null, "81QI7F3O5EBMTVYVMDUR5SJBPOX0KMJU2KON0R4DVOE8DIGK253WPPQPSP2TRCES4RUJHK45JR6ROK7HHM8OSXEN384LYKVSJVDWY7CRB8N8S9AHRVLFE09HNGPIQTG85OH2GLSJJQNUJF437X4D9QNTV6IRR4BS1PDD1IAFCB5YMP8HLWK2ZD9OBYGKCB2PP524B1CZ", 347, "8X6W9XEQZT@email.com", 405, "/Images/All-Service_default-image.jpg", "RandomCompany-29", 677, "WYB7UZGG8BF5TI2YPZCDB0CBJQIRWDGUTVFACB3LRAMB566GCD", 3, "http://45VM7C2WO5.com" },
                    { 30, null, "1WBOAGNUCPTY36U7IOCNZ52RRGJU8DJRAQ7MWSV3KUOJAFBZ1A3OUAG54U6462V8FCYM8HK02IDERSQLFU28J56AKBSCV17R9PD8RY0TZDVL6COLDVYLAXYKFYC7ZIEBLVFBOS3Q4JIGJVDIXG9ACWRL0223W24R9UAL6M7U1IQ0OSBUU3KSIE8ZD3LV0A3BO1GYU2LK", 277, "II8URO0OK5@email.com", 67, "/Images/All-Service_default-image.jpg", "RandomCompany-30", 581, "JOI3F07H1II3SLI4WKHDBL40POMXLN92RAI45ETN5D4R2ATCSM", 3, "http://NIQLSDO9R0.com" },
                    { 31, null, "4H7QM8O5JE9KZHJ1KJN038VIQJLZA9ENVT0ALRHT94FG5CTJB12EV075VZADXZ5JAWZGQIP3C4083PMNZCXIH914V5OWQE5K96GJNM22L9C0A9BGMWNUBWCA45VU33M79Q87JDANK47H7B4W3IJ40LIN3FOS1H9SXE1TAE7JWAKHZ4D3A81VTRHXIVDDYSVC5OT2KKWY", 186, "HXRODL2ZNY@email.com", 861, "/Images/All-Service_default-image.jpg", "RandomCompany-31", 972, "K9H0AAY9CVR2QN8F7DLOB3VEOILKKKS0MCKUJQWH7EBDA2VRQO", 3, "http://1C1QODO5RR.com" },
                    { 32, null, "ER72RDWW346PM1FP3FGE3STQJAJMHOBSNZ4ZZY6AZG5T1M09K8JIZMXW8RTR3JPP2OBW6PZEIFPXW9Y6JJBIE23BCI1HFPGP0Q1NKED5JFAT79982WITIGK9VATYXR83896GILWFGG992JEDI3OTHXHUF12KUPH1GHV7C3ZR9CMBHLGL5QP4DPWL1MAQTLV19I2VYGAP", 391, "KX585WZDOL@email.com", 21, "/Images/All-Service_default-image.jpg", "RandomCompany-32", 5, "E7TEKGN4VQPD9NY0UJG02I8YRVC8SVXYQ90F6RAV9G5C6R1VUC", 3, "http://920XAXS4CJ.com" },
                    { 33, null, "V0VN51A3QOQUJYGL4GB5LRU45JG418CH7EOTCSCDW5X95PTBQY2L3H8DG0RWVFCRMIWFJWJME7IP4U9Q0ENDG0O0GKNLBQSR3FXW2O24OQH59TJV1A5R19LV4688J8KXP1VZ7MYMMTYZTS0XB2UBVAZ43B25P3UQFTQI7UXPLSFIKVCLFL7ROJCOB055T27S8HT9CSZR", 19, "S2MJHRJHQG@email.com", 507, "/Images/All-Service_default-image.jpg", "RandomCompany-33", 343, "EFZC5RTI9Q0D5DC6RBGGY15SVWJDBCJXWQMJT9TUGX6DC3X4FX", 3, "http://6HCRP13MSS.com" },
                    { 34, null, "VAB51P19O8NUIKDX99MSJN0Q959LHDLKAS0S0QS1ZK2S2M82O214A9IIJV65PQ1LWDU0TV6SQU39UHXW7H7OMRKAJSIFUWMISR6Z2HI35INPGJXC7J8ISM9F2TRBM084IURDL83Z9ETDD4495GIKXD0FS07J0HQEKSHW2T18QJIO35B7ZRGGSXGE3LUUBU82XO3UXHHL", 594, "1MIL8EOV6V@email.com", 237, "/Images/All-Service_default-image.jpg", "RandomCompany-34", 433, "PJ4O5MLXZ9TIAKWWMC2Q9G75KQ0PBQJRJ41J32JRA74BA01N1H", 3, "http://IZC8GTN2U3.com" },
                    { 35, null, "KPBL64TZNX4IYCSSS74X45EMWL81U3OOY2FLL6PDUZII0ABAQXAP768OLYZU62ETJPT56GHWS0CFX6WWK8L728Q140AWG4H2UZ9KQFDJQO7H321PCDK8RH0K82BGGUPXTKV86LGE5BROBJ7C9UUDUJKN8YMXE6D58KXTG3S06GDQ0MJY49HV9LCJ9HAI9SA87VP0WO5F", 232, "5M1C2IBMSY@email.com", 527, "/Images/All-Service_default-image.jpg", "RandomCompany-35", 855, "C4GOG4XVPX3EZS5XHNT93K1OFESE7SCQEBTFEYDEUO2MY5JPZ2", 3, "http://6UN9X90SSJ.com" },
                    { 36, null, "OOORPZK5COF94VIZ1DMQC2BZ51L6VQ9J98QR7JXC8FJET70218IXGCHWMYWXOOJWO596F11RPJS6S7G8BTEXIMD704EJX9YT5XZX74X9H0H6UKDPSYW4JWNC2CFKWS3QU8A5ISAH6FQRFGNQ1Y09N4KJKX55YMMZ71LVJHH9XP8EG56VYYT814C0X1VUXFSU20UO41GT", 276, "X64N4BR5YC@email.com", 717, "/Images/All-Service_default-image.jpg", "RandomCompany-36", 841, "R0M85GDO0KGA2O7DYV7SWWMR6OLPLS06SAQASE5RXH4N8S2N3R", 3, "http://ITJR187VTZ.com" },
                    { 37, null, "Q5P29SOW7W42QC5DVXXDNW8EV3ZAAP66GTN2RCNLW57CIPCGWXMJ7PM46LGG3NVS07W6YDWSJMQRY65G0SONCW80HT5G6HRJKPMK3GSTA3AU84FAP9PL9HPE95ZEHQWB4HHJUVNUA5MIVO1MO5162GKC9IL7QNLUG9Z1W5Q4W4KD5GSUDM0MY0JY7FKLJPDXT1BWYA0S", 622, "I6KMCGIVDY@email.com", 909, "/Images/All-Service_default-image.jpg", "RandomCompany-37", 189, "P7J76GH3Z03EW95QZB3RVEUH0XUDE66DWI71RM217QWSV9AT5V", 3, "http://340SOCE8NJ.com" },
                    { 38, null, "CUESBV1XAHS9K6NLWOPFTF323Y5QVR1WTMEY22LQPVV6F3T3EDPZTH060MZMZKBTP6Q72ZT4D808U7W9ECMSBCCLWH8PD81ETCQJNWBPUVVVR1M2ZZHX8SRN3ELU1D1EGWOSQMWSA78QRR445FZN0EGBVDQILQXQ3QP5N4LNCZWBUA6LJQZVNNOCPN7N6OHUJSWAC9RB", 712, "RD45WSPNPH@email.com", 942, "/Images/All-Service_default-image.jpg", "RandomCompany-38", 572, "3MLBRFRUHE941BCQCMP978QYSC1BN5JJ8Y2BCMUK6MF1PM2IPG", 3, "http://M4Z6CJBOZ1.com" },
                    { 39, null, "EDU3ZJGJTWG7UZQU7FP3F6QE36ZQ08O2I7QOTBGNMG43AOKAPSL585WHWQ92TZTUHOZWJCB69CR8CXEPVZBHXT4MKI1DBN3WXJVWYY0MRO55OYF8LUG4YL6YUMLAL85WJ4L2CR078Y0JX87WD21QG98MN6BMM0BTTIWUNM644J5AUXAWOY7SGOQJ59PFQOUIXHZOLNJ1", 947, "54FTFHQVN1@email.com", 612, "/Images/All-Service_default-image.jpg", "RandomCompany-39", 682, "67V6E81Z6P7X3SME2NYO60OQZXMN7VKBPGWJ3TF7H0IAR6PE5V", 3, "http://LE5IX6CKJH.com" },
                    { 40, null, "0GGRN92HISM9MNULR0XLYM4875VY1I2KM07ZXXFFOJM5PM1SYLOLX8SOLIURNEP9ZBWWP4Y3VS6P98SVDD9Q3RXOHTNOCX2K3MFOZFC3WU0FBDON08OJE9GINIO6RJ18ZWWW2D68AG3I0SNEEAYDJSF3G7AQ0GLN32POR1UWCPJ8F7R45K1RVXYHR2Q5CPH45QO8D9XM", 863, "8B1SOU4E9Z@email.com", 871, "/Images/All-Service_default-image.jpg", "RandomCompany-40", 76, "QCB3JHYIPGUQO42GDI6YLYTWIODZTS16XPASV57KEHP640QAYI", 3, "http://6OY393JUHK.com" },
                    { 41, null, "VUDIW1R8CBKX63YOIAHKDGESSSG7QGOXXUQO7S6XD6B8OJS5EVUJN6HPPU0EVTR6WX9LMKQ0DUHGFGEJ9L35VFK1NB8N21BTOFM1JGS3E4F3YAKIQQEK0VKQMI8KLD7MSY194M932910ARCM106LW13345PAIHSB72KAIKNDQLR04TQ5GVTVGVZ058E978VVRZ3HGCDR", 610, "3L7WMUO34U@email.com", 120, "/Images/All-Service_default-image.jpg", "RandomCompany-41", 921, "M25LKC9KPT4WY64MDUEKFOGS06JE0IYERCJO0OQ293TNE86V5Q", 3, "http://G50EWWQVYE.com" },
                    { 42, null, "MKM42N19YJKECGY0L2N3C9EJNSN4K8O5PRVS9D393OFVKC2TQ5KYI4CMFCRK96ZZ4OYVVF1I8OAX4T9KZ4OPX0WVPIM6VT96ZP05NH7LDCZ44ORWCGUFSKCE1DGN24WPOD8P3E7S6DLUA21A004P83OONVDKBUSIPKP0QC27JCJP8RD9MFWBAHQVZTCHBWQMUCFZNAUX", 549, "YXO9TLXDVT@email.com", 864, "/Images/All-Service_default-image.jpg", "RandomCompany-42", 990, "86G6U8Q6RE857RII43A6AU6WV655MOVLV8CDBTB0DF07YVPC46", 3, "http://DSXK8OEHL2.com" },
                    { 43, null, "J344989R2BPTBL7LYDRHNXRWWOBKQYZZT0Z42TAULGKTEUQLNXZBZDPWLIHU7ZAEM09KWCSFD75HN8RC8Z738Y9QLDTULQXWFGHNVFZKEU72HIJM1FVH1HFY0S9SS83WKJBG0DR2AWZN0HID4G2G4P57ATXCGG2F1KR8GCVXY3GER27TK6YMFW24OEGHQPW44UWPZK61", 68, "45G9I45RSC@email.com", 907, "/Images/All-Service_default-image.jpg", "RandomCompany-43", 735, "UFSBI0PIVD2JSQ9ESXUC6OGJGMJ7GS39961AE0VXY7VMXMLOUR", 3, "http://DK2KVY991B.com" },
                    { 44, null, "7N823W3B4NYV0IEAVA650FG5SC4CZ0VREB3Q7NFWB4WFNRTTFVD8D5K1HCK111LE1GQZPYDH5J46SARASK7EWWOI0CI4DO4JSSNHA3ERR6D4BOIGUJIQ4HRF2H9NPIEROUNAXK9YGQW0TUHL3BK3FNPLAIP240BJ1WPQBITKJTKOU1VIAYTN8KLAFB9P5G4QON87E1JV", 725, "KMOVQ6KBUP@email.com", 623, "/Images/All-Service_default-image.jpg", "RandomCompany-44", 449, "SATVDB1IWH2FGXKQKOL9IDOCZ39G3YDJO848106EK02YOYJ0CR", 3, "http://7DT1H2MZUR.com" },
                    { 45, null, "HYRK0YAUJDLCN3EWQNK3WC0L5U57B702CIJV4E426Z2QD500XVM9O04E8GPG3CSLNTAETS1LSS77KJH93EKQU1NLNEWXYY93HQDT5VGE3AQ6374Y8QMY1C0WGY1P5DX3TDZ3GYEI8GWTKRSPK8YIMKCE0QNG41IZNXMZIARKLEZVQGLZGLE7PPRIBVDZK7NH76GWE2HJ", 10, "UMYNSRC2ET@email.com", 475, "/Images/All-Service_default-image.jpg", "RandomCompany-45", 133, "QN6IVQYTEY9SWLK8FEXW71AO0SYTAYUND4QBSJXV6TVW75UWVI", 3, "http://PDWO14JQ6Q.com" },
                    { 46, null, "C0NGNQ57B82HUJTS1XA1U229FTLQ31M1UTB48SACWF0F1ITM5JCWPF6K7NB4EOEKWAXAHYTJX7EPBWI6A8UTYZMOX16UQG7HAQT1USFHZ29SBQILFE4F4UV6YINP193R96OVCQMR3N3603NGSVOLL2NQ5XDMFZP09RSECXIY2MMQ0YF44H6FUSFHS8ZPNAMD8D6ILJD5", 14, "96UO19HOBO@email.com", 890, "/Images/All-Service_default-image.jpg", "RandomCompany-46", 638, "N0T9Q7ZGRJR73JGRMKWE82L29JSX26SVDB248F1VIS7ESOKY7P", 3, "http://U0541RLSGT.com" },
                    { 47, null, "B5P4HJV840MAS8EEIPHGTGGDNNWUSHV6ZQVDRZHROIULBUI70WJ6KAA4YLR3WAPXEPLBMAXSHZ2LV5C2FZ367YWYQ1OFHO5N27HVIGUZ80ZUIYJ3JYX7HTZQ3XVVVSK24OSYXQU9EE7H9BP1RV5S18GJI12VV9EQP603GVF3EX2CWRQ2H3DAW2B5IJP6Y8OEAQ1DKWV6", 433, "Z1H6I4SARA@email.com", 232, "/Images/All-Service_default-image.jpg", "RandomCompany-47", 23, "PCNDFDX0K9O15D3X44V6FIFFJXCF0NSVHGUUO70FWZWYUWJ6WE", 3, "http://7Q3UYTJI7E.com" },
                    { 48, null, "QKPWQUXOGSVECUSPNXGDHEEZZI1CUNN5KKUOMVQXGD49O2OIBJGVC36LFZ6I3V43FZ329DD2HS6EKFL64SALG13RNIJWYI4VJA4Z8WJ8FOOT72BAOAOKUTWN6MO14QD8YK5JLW8IJCF2NJTVGIIY4TA0OQ2VHSDYKP5W72Z2BGASO39W32UVIPEEKF543MA18QS7O7YO", 653, "6RYR7SJ7OJ@email.com", 634, "/Images/All-Service_default-image.jpg", "RandomCompany-48", 582, "TQWYTSMURF2P7SQ4L0M2758YGJU7KBI5EFB23QV23KMXUU3PAX", 3, "http://P76L2QXB4E.com" },
                    { 27, null, "TV16RVOLD74NC8ET76YC28N64F6BEH7W0W6N5JSO92JR6V0LIGY5G71UH4BLYNG59HWPB0XYNKD9Y69IOV38TCP25MGBHH0WVORY9KKRTAR6415K436CUIM723UYTVRGTQNKPLJELLOSUT8DR6GOKXBNBT6F0V77TKMNNU4TT21I44MJ5QHXPC66OAJ5PENZNQ9KGU06", 742, "NUCSPC47FM@email.com", 882, "/Images/All-Service_default-image.jpg", "RandomCompany-27", 602, "BW4R53THGXJJOKSQOP8NL9EPPB5N4CCL0LW3IOAVRCY24DLD8S", 3, "http://EU8TDYYI9P.com" },
                    { 26, null, "HYFU78MVV0S9H9EV75912BTAVLCZ5NPKUAPQKCU196CKGO76WPV0F00FFF8W5XZHKHPGTYK4KH169J4GOGCQ2ZF3KJLFD85MG49890M8E0P784G5K2IZUJPVCV5KMF1MLPZEK5HX3ELBKH5QDP4L0G17PN6N4CV99CVTECVPUU6Q7NL40PG6LPWFX1Y69320SMBHWLLA", 174, "8XF99NDNO0@email.com", 740, "/Images/All-Service_default-image.jpg", "RandomCompany-26", 452, "4P0FJL9CCBXP5YXUQP5NNZP11F7VLDIODGC6YQ6M1W38GN44YR", 3, "http://82JMZW15AT.com" },
                    { 25, null, "Z16NIGZJI3ANG1O7P2QQT7YKF86NRL6WBSO1KCHSVWNCZVHQT5DBWKY1DWIJJM267NLXNXWMU756UWVT1Q4VI5A14WYY47JJ4QELKTD5J0QYO1HRAZS3SGYCNT2098SXYWCDRKIIM8MRPLMDOGXEPP0X2C700N6KI2A2YE90QKQU4GXBHZL2KNII5OKPMSR8BBJWLUPK", 536, "FPXS0MRXBY@email.com", 41, "/Images/All-Service_default-image.jpg", "RandomCompany-25", 648, "H6YE9G3VP5TBCE94U16J4UO72RS27A0WKBUOZDJZUY9Q9Q67BP", 3, "http://OE61ATVERS.com" },
                    { 24, null, "WAFU3ZFRDYSQZFV7XDUHCET24628OVATVL7181XWCGTY2RGIXYD1179SQN067GCRX94OH495P8F5V59M0TL0SJ1YMPKUB1Z5DBA2W2B2YHL32D6VNNGN4M8OIGC2TO3YJJ1T4G07SSBL776ISZGXULB1DVUP0IJJNWUSMN0GWI4MLXRKK3K4IGD7IAQIWKHJJ17LNO5E", 729, "THQPYL6W5Z@email.com", 794, "/Images/All-Service_default-image.jpg", "RandomCompany-24", 126, "8AAMRYPPEKF68OBHSXJM7RUMBUCT0F668F5IF1PTUAEMFLL4ZZ", 3, "http://8NI83S3C0H.com" },
                    { 2, null, "GA13137O02HN2Z3LW4K6RHQRL7XYQJNHCNKPP5RA28MCTXE694BNC0I8UJS4FJ8QOALPON60NJES4N8X21ZWI9ELEM5FMW4TA5XTMYRV8K93VZDHL4BOTMIO59KCS0O0OVS8ZOLDJDY7ALZPIY4SVP9YXJYMOODH6JOAGER7S7FQXKOUK54365E8W4LQ09Z49QB16ZID", 467, "5KFZQR9C2D@email.com", 636, "/Images/All-Service_default-image.jpg", "RandomCompany-2", 317, "G69YKSAM4DBTUJLAEPNM3BGSHKQHIXXVW0X96PYD48VW8FJ0EB", 3, "http://HQQ63WLDY1.com" },
                    { 3, null, "KS4PUUCB0CHAGJ0QRJP8YBB5OGSIPE378ZBNPZF6O8LZ6GJGGNECYZCIQ9ANC3VWJJBRINA1ETU0ZL8I7LCC91JJW36QZ24VNZQWE172MM8FFMSFA2Q00SWSA25PQTCLY8MA5MDGOKZW2DDJK1Q6LD54C7WL6SL2JWQHARJYZKMQ29Z6ZVEZDG9VDR7801J587MGX6J2", 780, "0IG3JBK6GP@email.com", 579, "/Images/All-Service_default-image.jpg", "RandomCompany-3", 801, "S1HB1OCCHZWKNWZDW5DSTL87AQR5XSJ2MMHL884YP50AF9SLHI", 3, "http://ZQ38BPNFYB.com" },
                    { 4, null, "PCYV72B8FXO7R9VDASY6T1IPBULBR64D60NXUV6RAM0SB183M8O5Q1RX3JUNQARJ3KB0W7TPWH5HA0OJVRYTR8XFJ03KBSAA4RZ10IHPO9JJ5JWD5K19L814X5Q5DINDG5MTAWTMKJESZNJ9E0P01BY6Z4D42LLGVGCA6CDI0OYC3JFJWQ1N2XLFGQ3GTZU8776TLIDB", 424, "W20S9SVQGD@email.com", 689, "/Images/All-Service_default-image.jpg", "RandomCompany-4", 409, "XHAMMWCQZ4HLU8N8464QJ6YA30F6NW7NN00VX93UNNRZSJN9U7", 3, "http://D6374H1L5D.com" },
                    { 5, null, "JC6P9SUMGMP7S918ADXQHDHJN2YLT12W3MFT6KSQ8JK4YFN4G6HYXO5F5WBG4I3OT2DG3HCZUHS82NVIO3FXTD8OQ9XJILVZP6K5CHA94RDQ67MSA32ACF5Q4Y04T2RJV2S6C0GH3G3B9SSTWFJPTVWJB3BNRGPCA44EOQPJXUH6M3QLGHIOSCZAFI5IZ30X00AFYNEG", 831, "8VSQ7E4UKO@email.com", 17, "/Images/All-Service_default-image.jpg", "RandomCompany-5", 383, "ZA18O07HNZGK8BT8E49GUGU44TFW2LX3CBZSK0WOLY5AWPZZGB", 3, "http://BBNH6LBYNI.com" },
                    { 6, null, "V46LTHO4PP1K3PEQGCMW13AJ38JI3OFNWV2DZH6ZZAF5X1I7CPF9L1Q14WRV7GBBKNXHWB19FX71YFVC0MFNIFB5FBJCZK1T8DVJDAKBYF3Y4ZCZBO5VAY2EM2CV2ZK55N2VTM9ZBEYDLNBQ9UBKPGTKKQ7L8ZJ9583Q6RFZPFU59Z380WWHX9PZ4RKDOY1L5YIMUVTR", 443, "FKMBD6NXAF@email.com", 842, "/Images/All-Service_default-image.jpg", "RandomCompany-6", 980, "OM4JVXLVX8UMDBL5SEVOHCK1NI9KQQOFCE2LEGDHGYPPDPI4NN", 3, "http://GTPJ9I90MA.com" },
                    { 7, null, "OISW5Y7AF7DW8G73QKBK0TGTI5YGIWNWRPU710GP8MSCBUVJMF2ZZCK5B9N9911TURETVAB0EWLNADRYKP3C3X6PEY52MGPGU9SUQBXMECVD0748RZYU8ZZ6UYP6EJN7GF3BV7HJ1Q81C3YG37KXS4H5KVA1V0H5YY6UE3MURP2R07309ICH80OL87096PXAJDCO6ECA", 315, "67HCCLKRSR@email.com", 160, "/Images/All-Service_default-image.jpg", "RandomCompany-7", 488, "U0FCCZFM2J2MYA68JVWGCNXC11IW4O45FCXIUMJI2OHXXKMIHE", 3, "http://NO6HVMYO6L.com" },
                    { 8, null, "OOYFAPQO9P0JSOJFPGRB81J64I1D16S0I9DRIBCX45RD0E5S7P7S65NWF1L1XNXD6AATK26OD3GDKFFZMIGL9A3NWQMQ0KARINH0EMHETSOCYJM9VVOOGLE6GW74PPX23Z468PVABB2QV1YMDN5E6VK6JKTRPNZD5VI9OQAG9NNETYKP8U0CUT6IO8XX6EVYMYUASY7X", 512, "Q4AOJ0TNSQ@email.com", 293, "/Images/All-Service_default-image.jpg", "RandomCompany-8", 104, "MYESHGNUADS4WWSMZAUQ3MK52Y24DK7KXDZ6ONAIUCX2W0CZFI", 3, "http://ZGIHS7W7L9.com" },
                    { 9, null, "M50YRIBWCY49OGGJZREXR4CV7WNTT2TK8T1UEL6AY6K3WZ1CAJHF3YRR3E155SCKFTB5PVFOUD8VUI9H4LSJVORJCJ19UBFG3AYCY6XPE3UZ067VETAT93Z1C13F4F4T821TT7T8YDF132TFMF5ABVHAL7A6CRU98B07ENBH9C46Y77JHX3YK3RMV1IW7W5HSF32BVB8", 635, "X3YNY2D74J@email.com", 259, "/Images/All-Service_default-image.jpg", "RandomCompany-9", 257, "EXB91KMNA0YPY5ZFTOMNEPJMGXNSEEIVW4UW2SVKO5VH7QTWQX", 3, "http://6RD33LCMA3.com" },
                    { 10, null, "C8J3CPZE1BQ5VM8B6IEZSMUWZZ4XZLOKI3GYU5LID8G22B5042P4IKKZOXDMUBOPXFW2FJQA75WTG13Y4E276TB7SQK718YBT0FWODUVLO6NY1TW3PSQJRTDDYJZ9TJ8HU9QWGK0THWRXYJ17XDMPH2CGBS045W2E8GD1DAWF17B5CQPOR1LQ7S927JUYT6YV3NYRF94", 298, "FAIRV2BKFP@email.com", 274, "/Images/All-Service_default-image.jpg", "RandomCompany-10", 823, "XQHYK0HEVDLMDLLHPHL43P8V5IQBY17JR7X904YB0E9VITUKRG", 3, "http://3FC4GXMQUS.com" },
                    { 11, null, "KDYQNNLYGTSRWPM6PSEBW0UZFPGZNWFZZ2SCL2EIRNDW7MSWSKI4LS5UT9L7HWKUN3246KUXN6UJW8127TGDNLNG68TMQGB4CTIEUXZIZVQP8V7UHSAXPHGCPV781IGH4ZHDZXIJ48O258ILB8E8FNP5NGY8Z1RRPIUJO44UJ13R2NGRNW72DHCRKMZT8JTCQ6NWN97G", 273, "5B28ZH46G8@email.com", 464, "/Images/All-Service_default-image.jpg", "RandomCompany-11", 13, "DUZOU7C99HVD4YNHGD8BELV9H0A5ATDOZ0YTSX6MK0U1YQI2TF", 3, "http://PEHND93ZSH.com" },
                    { 49, null, "U9WSLEVPE7XOVKIYNL58L4OA70XJB8NW2SA64GG2642QWAMVDEDLF63ZUWUURMOGUAWCKL3GFCBRB7N6OBF75BQ5ZKMHVVLUQW6WNJL1K6GD4LXWIYGPGRKSU1N98VVT1RBPB1SE0OW84NBNWZ97O6N8LNBW6M2YLWLMKIVQFBZ24MYG09MJWYF4ECDXZ6IOV8XIBYDO", 567, "5KF1ST6OHJ@email.com", 735, "/Images/All-Service_default-image.jpg", "RandomCompany-49", 440, "DS1NHVE8Z4669TBWRQIHE81I3KH6ZPFB67FE61XS8E849LOB6A", 3, "http://JZ4ACN70Z3.com" },
                    { 12, null, "V1O14K1RIM5D3N4Y6U2QBQD1EXRCF20Q8CODXBEOPMY4DMK3TPDI6CFFYXWH3YMPWOF181B4QOAZ1JX1MXT0ZRU57JP9O6U1AIHYHS42NI2RBQNO944FFV0E4J4ZMBQT3JYSB8U430MRZC4Q5AATCPVOSD48YEQL1IY224MAKAMPJIP2ON4LB6ROXJA8EWFYKAZQOCYA", 135, "FGJCVHNB60@email.com", 707, "/Images/All-Service_default-image.jpg", "RandomCompany-12", 941, "X9JCCGFJYBTLKEK51JES4O6X5YEIT8OMY3XCWPMRD0KDC4NF03", 3, "http://ZXHWQRHIM7.com" },
                    { 14, null, "8N5KNLN1HK6L8FEFSPS7T21NJJJRNNJJRDT3VOMQBHMZPPOXTHCB7GRFVSAEC5O3BX45VLTEDC6LPC845W8GLILKWOHDOINF3TY1VTBIX884KFZSTFJP7IS2LTIHDPZ5Y0S6OGJLV0SMKQAQYYTJ88IVA5QBK3EHJDGTX3EM674GZFS4T2SO5Q60S75T0HA1VKDHKR35", 840, "C88UXEAQQ3@email.com", 18, "/Images/All-Service_default-image.jpg", "RandomCompany-14", 443, "UGMBDB55NVRSL0M2GQB07VWY6DVOBKUC8X3YD5WQBAFFZSQ48L", 3, "http://CAPTX6XYL3.com" },
                    { 15, null, "VZ6PQ8OW0Q0K0W5Y5EQ0W9UHDEJ828LWYB4NBTEYZNZAC2K3X8BTIUGVEYMMYP42EEVZ1SXL91AJJTEK4QK362NE4JIMG19JS758HVCFLZTQU6LUUBSIFA6M0R4SJKFI200MYGDINFRGJ6T77X2EJ0ERBSH00U6BULY3G96N8J5ATZD476UVRA8BWJLF9NR3IQW8I018", 603, "4K9AVJ3M6I@email.com", 594, "/Images/All-Service_default-image.jpg", "RandomCompany-15", 554, "1OGA5E8LPN339KTTMWG6X1OU1C1CCEVGFW4C37GSK9ZWUX386C", 3, "http://K1WYMQRZPQ.com" },
                    { 16, null, "YWXB2ADI3GAT9WKM4BIXNFO0O479RSPMFF5IW7IUGUTZI11AOAVPR1CSI6X7DE1K0XN40CZ63XR2WYSXD6UQ6A4OCM9ZKLRB3I9UN6JLKYV4JK6TOA3GTKO0392OC9WRGP8NZ7JGXIGHOAE2QQLKRKST4I1NE5JLCEY3LT4Q0XTKDGL25A8WYLA57PSQG5B195FKMKQ6", 567, "U6GTZI86GX@email.com", 173, "/Images/All-Service_default-image.jpg", "RandomCompany-16", 393, "V4U40HPY79SE7WW1E266AOK4V2LIABQVTBB31FFZ94TGN74MIO", 3, "http://5T7U5V398W.com" },
                    { 17, null, "G6F5DRY78AW55G9E4JC6H32GXXPM90POH8HX0LQHUA7GB9X0V11T6BOND9HQCL8IVHX79LNT35LH5WEXAZ0H95RFT4U1DAFJBZV4MZ1KNHZB0HRR4UPMU0IZZSOE1WQ3ZCFGAKLK7Q41GQPLMC6TU2YLR6E4LWT116MYCLQUIFPE6QTJCC1YZ7I7N3ZEGR8L7CAJD1JB", 680, "APK8THJNVU@email.com", 610, "/Images/All-Service_default-image.jpg", "RandomCompany-17", 453, "VMKONUOAM51J44B4XPKIWLO1GEG3QJFL30CNW4T2PY2K0ZQCBF", 3, "http://DZPPE1XH35.com" },
                    { 18, null, "S37TDBRXE2KXR53L2PDWKO4EYVKJLKN8238GR04R0VJ2JPIUW39IEHUD934R0HL3OM5Y7W4BUV5ZFB4JM0XSLF4UI4HX6M0SJPO7UUW997XSL5788VFAU3SIRKQCPGFI4MPZW6Z2DXTNSMJM6IZKH08Q7FPKEUU21PX8QILC6M66JF0FBDFGR5AEN82QQPYTC0VDZK5Y", 178, "NICB7HQIYI@email.com", 678, "/Images/All-Service_default-image.jpg", "RandomCompany-18", 698, "7WO53CH2PKIAOOL6OSVRQ4VRXN3STWQ1IRJ4QEKL1AAGGYEYPY", 3, "http://33R17FRQKI.com" },
                    { 19, null, "J0Q4OL9JFD48KB4IG2T73DC1HMY6GS7IO7PW2IWWIHDVO4TP6Y8Y7MOGYZWCWCCWGWTMWHQ8G6YW9QMM3I9SUILBTJ8CVU9FEQP2LH3YHASAX2GHMJJOCUC7KS2MJOMV7SRTBUBVOKKTZLN1D00MLVDUORR2ORP3X7CFKWF1HX91KSI9EBJSXAKMP6FTCIH75Q62IIQQ", 503, "C98JFHSPQJ@email.com", 165, "/Images/All-Service_default-image.jpg", "RandomCompany-19", 529, "U8EXVLK5JSYMI6GXW0ZNRWY9QC63WP15V27Y5W0EWJKUU4Y8KI", 3, "http://3120P9R199.com" },
                    { 20, null, "V1HLEOVN7TNJIMT38O0PIYFAQ32EJ92RGS7K1WF0WER76USPHVADAU16VH5KWRE715D0PICLIA2DGIE6LM6X9YQV1AYT15EFAUFAQ1A8TY4A1XZND98JUQ8COR8OTSUN6XCWCEPTM8EL4Q4DLLQ164VUWDV93VPADREEVCK8TO7WMWI8X5DIB2QBCSA9SQ00TDHMMZSI", 293, "QGYBE4058U@email.com", 309, "/Images/All-Service_default-image.jpg", "RandomCompany-20", 641, "ARHS78H94WL8SG9KBCCCCLQDXGDJO6V8M4HTU8EDKBE5E2IMD7", 3, "http://8BNVY9PZD7.com" },
                    { 21, null, "91AHU8481FRULL6XTRQDOHMRF41HTNXHHNYYFQRF92E3CN0CZAQ8J9T1PTCZHXONRKN7XISCAKEVDSO1EZST6Z7I46IWO18LO0M1A2PRSN7857Y7FLVRF4R1MED095YIM2HMGW0MKABT19N6ILRCGQFTJUO6YYRWZYWC0L0SVJHE379N1GSXOVC5WYCVH3XVTP3DNLG6", 612, "FXQY0LWPLI@email.com", 470, "/Images/All-Service_default-image.jpg", "RandomCompany-21", 888, "U8R7JAZLUBFSG3HDW1PBJEK1VWVOD6AQ9VCPDFVV80BGYFOZH0", 3, "http://YBZSU01AQF.com" },
                    { 22, null, "3DSDDCQH6GNPOU48W1N38GWSMF9W38Q0AQCBEMUY5OSF4IWEXWE9WXGWQ918C3O80XP7R33KGY8UYRXDS49H4QDNKQVEVWWCATPH3ZX42338YW78MXPH3GEJUCXAHZZUC5TFCQK3HEPAXFYYSW28GOI3OFX0CWWDEI53C265MWAZ1EWOO9RV61NYX0062T1URM6OJ4V0", 60, "IYZ33Z7LWC@email.com", 535, "/Images/All-Service_default-image.jpg", "RandomCompany-22", 697, "Z6VUOTBKTIMDEAGN5HFMB9D24QHPHHFTN169F2KEYPNUHYPRFT", 3, "http://LD3ZNEGHC7.com" },
                    { 23, null, "BYWWSVGA0JYYD4ECGGMDM2BMBRO8BM8LQEXUCDKHS7VMOX98UL8A59VIWJUBHH9NKMH8GU9C5EUPHY8ORPO0N8QRTP73TIAL7HBBPB2AL6E0OGB7LFU13I9M6ZO1XGSWEJR9X69PXNPR30DNN9SOYJRZHZFZWAMENSWFYBKOFFEP3STGWBNXYE8522281J2WAKELD7YM", 353, "1DMRLHXWML@email.com", 753, "/Images/All-Service_default-image.jpg", "RandomCompany-23", 557, "YDITFB5ZF8DVWZPIU1N6IMW6MROSOHCZMB9U6OZ06D23GHAL45", 3, "http://86NIV04MFB.com" },
                    { 13, null, "WPEE3VAK9SZIJOSXN9AH8PG9UP5H6XSUNHL0BFJAGCCOARO2D3DIIE8HIETNZ3NLAF5BD2VIZAB5N29DBDDDUJMIJDS7V6LMZ0O5VMYLH5SHCC3PFQMWZK102X29KYW3ZZGWODSYO26Y1EGGKC1FUZWO9XC8UZBTIZSN6HBB8XH7OC9XQVZI6RJAC1W0BTEZ1NQBW2KC", 96, "GRY02O9U9L@email.com", 598, "/Images/All-Service_default-image.jpg", "RandomCompany-13", 504, "A0G7RZA7YOR892W1QSKEULAOSSFBV7BYKWHFKMSM1ZBWCF080Z", 3, "http://1M3XMVQQEA.com" },
                    { 50, null, "ZI9A6IR6F9ZZVWAX9NNI1E15YFFLMX9JA10XKF4JC9IHUUEIAOOTMRCURDL1DFURAPY45MM4SDF16TLEA6K7JP7TYFFG4DG7O1HF5KMXBTAJMKY82H0G5XHUSFF0HFAP7INELFJ0TW5ZOXGORHNWN9C1TWXZFWQ5TVME7TWX89XI1RF480IA2NB7GVVZSTV6G9F2LCR7", 936, "G9XWJ9V2HZ@email.com", 242, "/Images/All-Service_default-image.jpg", "RandomCompany-50", 118, "U0YOM39BQ31POQDGUO8L87EPO0B2LMS6ILPBYXVMWTIZ2GS059", 3, "http://DK4GCACS62.com" }
                });

            migrationBuilder.InsertData(
                table: "CompanyServiceType",
                columns: new[] { "Id", "Company_Id", "Service_Type_Id" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 83, 27, 11 },
                    { 84, 27, 5 },
                    { 85, 28, 3 },
                    { 86, 29, 5 },
                    { 87, 29, 6 },
                    { 88, 30, 9 },
                    { 89, 30, 9 },
                    { 90, 30, 9 },
                    { 91, 31, 2 },
                    { 92, 32, 4 },
                    { 93, 32, 2 },
                    { 94, 32, 6 },
                    { 95, 32, 4 },
                    { 96, 33, 10 },
                    { 97, 33, 8 },
                    { 82, 27, 4 },
                    { 81, 26, 8 },
                    { 80, 25, 6 },
                    { 79, 25, 5 },
                    { 63, 21, 11 },
                    { 64, 21, 11 },
                    { 65, 21, 6 },
                    { 66, 22, 8 },
                    { 67, 22, 3 },
                    { 68, 22, 9 },
                    { 69, 22, 7 },
                    { 98, 33, 5 },
                    { 70, 23, 8 },
                    { 137, 50, 1 },
                    { 73, 23, 9 },
                    { 74, 24, 3 },
                    { 75, 24, 8 },
                    { 76, 24, 7 },
                    { 77, 24, 4 },
                    { 78, 25, 10 },
                    { 71, 23, 10 },
                    { 62, 20, 2 },
                    { 99, 34, 8 },
                    { 101, 35, 6 },
                    { 122, 45, 4 },
                    { 123, 46, 7 },
                    { 124, 47, 4 },
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
                    { 121, 45, 10 },
                    { 120, 45, 7 },
                    { 119, 44, 10 },
                    { 118, 43, 8 },
                    { 102, 35, 3 },
                    { 103, 35, 1 },
                    { 104, 36, 11 },
                    { 105, 36, 10 },
                    { 106, 37, 4 },
                    { 107, 37, 4 },
                    { 108, 38, 7 },
                    { 100, 34, 2 },
                    { 109, 38, 7 },
                    { 111, 39, 4 },
                    { 112, 40, 1 },
                    { 113, 41, 10 },
                    { 114, 41, 7 },
                    { 115, 42, 10 },
                    { 116, 43, 4 },
                    { 117, 43, 11 },
                    { 110, 39, 5 },
                    { 61, 19, 1 },
                    { 72, 23, 10 },
                    { 59, 19, 5 },
                    { 22, 7, 8 },
                    { 23, 7, 11 },
                    { 24, 8, 5 },
                    { 25, 8, 5 },
                    { 26, 8, 6 },
                    { 27, 9, 1 },
                    { 28, 9, 9 },
                    { 29, 9, 11 },
                    { 60, 19, 9 },
                    { 31, 10, 1 },
                    { 32, 10, 7 },
                    { 33, 11, 11 },
                    { 34, 11, 7 },
                    { 35, 11, 1 },
                    { 36, 11, 9 },
                    { 21, 7, 8 },
                    { 20, 7, 1 },
                    { 19, 6, 1 },
                    { 18, 6, 5 },
                    { 2, 1, 4 },
                    { 3, 1, 5 },
                    { 4, 2, 8 },
                    { 5, 2, 11 },
                    { 6, 2, 6 },
                    { 7, 3, 10 },
                    { 8, 3, 6 },
                    { 37, 12, 2 },
                    { 9, 3, 3 },
                    { 11, 4, 9 },
                    { 12, 4, 1 },
                    { 13, 5, 9 },
                    { 14, 5, 2 },
                    { 15, 5, 5 },
                    { 16, 5, 9 },
                    { 17, 6, 4 },
                    { 10, 4, 10 },
                    { 38, 12, 9 },
                    { 30, 9, 6 },
                    { 50, 16, 1 },
                    { 53, 17, 8 },
                    { 44, 15, 4 },
                    { 54, 17, 4 },
                    { 55, 18, 4 },
                    { 52, 17, 1 },
                    { 43, 14, 5 },
                    { 47, 15, 3 },
                    { 56, 18, 8 },
                    { 45, 15, 8 },
                    { 42, 13, 3 },
                    { 46, 15, 7 },
                    { 51, 17, 1 },
                    { 58, 18, 3 },
                    { 41, 13, 8 },
                    { 48, 16, 9 },
                    { 39, 12, 1 },
                    { 49, 16, 4 },
                    { 40, 12, 1 },
                    { 57, 18, 5 }
                });

            migrationBuilder.InsertData(
                table: "Telephones",
                columns: new[] { "Id", "Company_Id", "Telephone" },
                values: new object[,]
                {
                    { 43, 43, "+380803577086" },
                    { 22, 22, "+384256153698" },
                    { 4, 4, "+388431545926" },
                    { 45, 45, "+381785809777" },
                    { 16, 16, "+382572042911" },
                    { 44, 44, "+384030503249" },
                    { 17, 17, "+389440283249" },
                    { 5, 5, "+387343397017" },
                    { 3, 3, "+389548149947" },
                    { 47, 47, "+380282383143" },
                    { 21, 21, "+386649322796" },
                    { 2, 2, "+383157037446" },
                    { 48, 48, "+382855830555" },
                    { 20, 20, "+381125026686" },
                    { 1, 1, "+386746462239" },
                    { 49, 49, "+388030090680" },
                    { 18, 18, "+387930230934" },
                    { 19, 19, "+389407033694" },
                    { 46, 46, "+385406247045" },
                    { 29, 29, "+380133177067" },
                    { 40, 40, "+386071365462" },
                    { 23, 23, "+384630767790" },
                    { 30, 30, "+380597358639" },
                    { 11, 11, "+381375944232" },
                    { 31, 31, "+386766067534" },
                    { 12, 12, "+389114383019" },
                    { 28, 28, "+384221770008" },
                    { 27, 27, "+384579902797" },
                    { 32, 32, "+389243532472" },
                    { 10, 10, "+381932956825" },
                    { 13, 13, "+384708484983" },
                    { 33, 33, "+382211793471" },
                    { 9, 9, "+386887413034" },
                    { 34, 34, "+388370235625" },
                    { 42, 42, "+388610351040" },
                    { 26, 26, "+388960193426" },
                    { 25, 25, "+381662085545" },
                    { 35, 35, "+389261881520" },
                    { 8, 8, "+387827850041" },
                    { 36, 36, "+383490746491" },
                    { 37, 37, "+382371555312" },
                    { 7, 7, "+387275087425" },
                    { 24, 24, "+387407730148" },
                    { 38, 38, "+387511295938" },
                    { 15, 15, "+386061498980" },
                    { 39, 39, "+387727744637" },
                    { 6, 6, "+382602702559" },
                    { 41, 41, "+383749282787" },
                    { 14, 14, "+389189930370" },
                    { 50, 50, "+382289898510" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AccessId",
                table: "Companies",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_User_Id",
                table: "Companies",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_Company_Id",
                table: "CompanyAddresses",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyImages_Company_Id",
                table: "CompanyImages",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyImages_Image_Id",
                table: "CompanyImages",
                column: "Image_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceType_Company_Id",
                table: "CompanyServiceType",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceType_Service_Type_Id",
                table: "CompanyServiceType",
                column: "Service_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentType_Id",
                table: "Equipment",
                column: "EquipmentType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Manufacturer_Id",
                table: "Equipment",
                column: "Manufacturer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentTypes_ServiceType_Id",
                table: "EquipmentTypes",
                column: "ServiceType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairCategories_Service_Type_Id",
                table: "RepairCategories",
                column: "Service_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_Company_Id",
                table: "Telephones",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Acceess_Id",
                table: "Users",
                column: "Acceess_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyAddresses");

            migrationBuilder.DropTable(
                name: "CompanyImages");

            migrationBuilder.DropTable(
                name: "CompanyServiceType");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "RepairCategories");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Access");
        }
    }
}
