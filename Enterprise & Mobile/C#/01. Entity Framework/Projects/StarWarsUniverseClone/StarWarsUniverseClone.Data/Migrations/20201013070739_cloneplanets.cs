using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverseClone.Data.Migrations
{
    public partial class cloneplanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RotationPeriod = table.Column<int>(nullable: false),
                    OrbitalPeriod = table.Column<int>(nullable: false),
                    Diameter = table.Column<int>(nullable: false),
                    Climate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Uri);
                });

            migrationBuilder.CreateTable(
                name: "MoviePlanet",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    PlanetUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePlanet", x => new { x.MovieUri, x.PlanetUri });
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Planets_PlanetUri",
                        column: x => x.PlanetUri,
                        principalTable: "Planets",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Uri", "Climate", "Created", "Diameter", "Edited", "Name", "OrbitalPeriod", "RotationPeriod" },
                values: new object[,]
                {
                    { "http://swapi.dev/api/planets/1/", "arid", new DateTime(2014, 12, 9, 13, 50, 49, 641, DateTimeKind.Utc), 10465, new DateTime(2014, 12, 20, 20, 58, 18, 411, DateTimeKind.Utc), "Tatooine", 304, 23 },
                    { "http://swapi.dev/api/planets/33/", "superheated", new DateTime(2014, 12, 18, 11, 25, 40, 243, DateTimeKind.Utc), 12780, new DateTime(2014, 12, 20, 20, 58, 18, 474, DateTimeKind.Utc), "Sullust", 263, 20 },
                    { "http://swapi.dev/api/planets/34/", "temperate", new DateTime(2014, 12, 19, 17, 47, 54, 403, DateTimeKind.Utc), 7900, new DateTime(2014, 12, 20, 20, 58, 18, 476, DateTimeKind.Utc), "Toydaria", 184, 21 },
                    { "http://swapi.dev/api/planets/35/", "arid, temperate, tropical", new DateTime(2014, 12, 19, 17, 52, 13, 106, DateTimeKind.Utc), 18880, new DateTime(2014, 12, 20, 20, 58, 18, 478, DateTimeKind.Utc), "Malastare", 201, 26 },
                    { "http://swapi.dev/api/planets/36/", "temperate", new DateTime(2014, 12, 19, 18, 0, 40, 142, DateTimeKind.Utc), 10480, new DateTime(2014, 12, 20, 20, 58, 18, 480, DateTimeKind.Utc), "Dathomir", 491, 24 },
                    { "http://swapi.dev/api/planets/37/", "temperate, arid, subartic", new DateTime(2014, 12, 20, 9, 46, 25, 740, DateTimeKind.Utc), 10600, new DateTime(2014, 12, 20, 20, 58, 18, 481, DateTimeKind.Utc), "Ryloth", 305, 30 },
                    { "http://swapi.dev/api/planets/38/", "-1", new DateTime(2014, 12, 20, 9, 52, 23, 452, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 483, DateTimeKind.Utc), "Aleen Minor", -1, -1 },
                    { "http://swapi.dev/api/planets/39/", "temperate, artic", new DateTime(2014, 12, 20, 9, 56, 58, 874, DateTimeKind.Utc), 14900, new DateTime(2014, 12, 20, 20, 58, 18, 485, DateTimeKind.Utc), "Vulpter", 391, 22 },
                    { "http://swapi.dev/api/planets/40/", "-1", new DateTime(2014, 12, 20, 10, 1, 37, 395, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 487, DateTimeKind.Utc), "Troiken", -1, -1 },
                    { "http://swapi.dev/api/planets/41/", "-1", new DateTime(2014, 12, 20, 10, 7, 29, 578, DateTimeKind.Utc), 12190, new DateTime(2014, 12, 20, 20, 58, 18, 489, DateTimeKind.Utc), "Tund", 1770, 48 },
                    { "http://swapi.dev/api/planets/42/", "temperate", new DateTime(2014, 12, 20, 10, 12, 28, 980, DateTimeKind.Utc), 10120, new DateTime(2014, 12, 20, 20, 58, 18, 491, DateTimeKind.Utc), "Haruun Kal", 383, 25 },
                    { "http://swapi.dev/api/planets/43/", "temperate", new DateTime(2014, 12, 20, 10, 14, 48, 178, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 493, DateTimeKind.Utc), "Cerea", 386, 27 },
                    { "http://swapi.dev/api/planets/44/", "tropical, temperate", new DateTime(2014, 12, 20, 10, 18, 26, 110, DateTimeKind.Utc), 15600, new DateTime(2014, 12, 20, 20, 58, 18, 495, DateTimeKind.Utc), "Glee Anselm", 206, 33 },
                    { "http://swapi.dev/api/planets/32/", "temperate", new DateTime(2014, 12, 18, 11, 11, 51, 872, DateTimeKind.Utc), 13500, new DateTime(2014, 12, 20, 20, 58, 18, 472, DateTimeKind.Utc), "Chandrila", 368, 20 },
                    { "http://swapi.dev/api/planets/45/", "-1", new DateTime(2014, 12, 20, 10, 26, 5, 788, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 497, DateTimeKind.Utc), "Iridonia", 413, 29 },
                    { "http://swapi.dev/api/planets/47/", "arid, rocky, windy", new DateTime(2014, 12, 20, 10, 31, 32, 413, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 500, DateTimeKind.Utc), "Iktotch", 481, 22 },
                    { "http://swapi.dev/api/planets/48/", "-1", new DateTime(2014, 12, 20, 10, 34, 8, 249, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 502, DateTimeKind.Utc), "Quermia", -1, -1 },
                    { "http://swapi.dev/api/planets/49/", "temperate", new DateTime(2014, 12, 20, 10, 48, 36, 141, DateTimeKind.Utc), 13400, new DateTime(2014, 12, 20, 20, 58, 18, 504, DateTimeKind.Utc), "Dorin", 409, 22 },
                    { "http://swapi.dev/api/planets/50/", "temperate", new DateTime(2014, 12, 20, 10, 52, 51, 524, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 506, DateTimeKind.Utc), "Champala", 318, 27 },
                    { "http://swapi.dev/api/planets/51/", "-1", new DateTime(2014, 12, 20, 16, 44, 46, 318, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 508, DateTimeKind.Utc), "Mirial", -1, -1 },
                    { "http://swapi.dev/api/planets/52/", "-1", new DateTime(2014, 12, 20, 16, 52, 13, 357, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 510, DateTimeKind.Utc), "Serenno", -1, -1 },
                    { "http://swapi.dev/api/planets/53/", "-1", new DateTime(2014, 12, 20, 16, 54, 39, 909, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 512, DateTimeKind.Utc), "Concord Dawn", -1, -1 },
                    { "http://swapi.dev/api/planets/54/", "-1", new DateTime(2014, 12, 20, 16, 56, 37, 250, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 514, DateTimeKind.Utc), "Zolan", -1, -1 },
                    { "http://swapi.dev/api/planets/55/", "frigid", new DateTime(2014, 12, 20, 17, 27, 41, 286, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 516, DateTimeKind.Utc), "Ojom", -1, -1 },
                    { "http://swapi.dev/api/planets/56/", "temperate", new DateTime(2014, 12, 20, 17, 50, 47, 864, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 517, DateTimeKind.Utc), "Skako", 384, 27 },
                    { "http://swapi.dev/api/planets/57/", "temperate", new DateTime(2014, 12, 20, 17, 57, 47, 420, DateTimeKind.Utc), 13800, new DateTime(2014, 12, 20, 20, 58, 18, 519, DateTimeKind.Utc), "Muunilinst", 412, 28 },
                    { "http://swapi.dev/api/planets/58/", "temperate", new DateTime(2014, 12, 20, 18, 43, 14, 49, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 521, DateTimeKind.Utc), "Shili", -1, -1 },
                    { "http://swapi.dev/api/planets/46/", "-1", new DateTime(2014, 12, 20, 10, 28, 31, 117, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 498, DateTimeKind.Utc), "Tholoth", -1, -1 },
                    { "http://swapi.dev/api/planets/31/", "temperate", new DateTime(2014, 12, 18, 11, 7, 1, 792, DateTimeKind.Utc), 11030, new DateTime(2014, 12, 20, 20, 58, 18, 471, DateTimeKind.Utc), "Mon Cala", 398, 21 },
                    { "http://swapi.dev/api/planets/30/", "arid", new DateTime(2014, 12, 15, 12, 56, 31, 121, DateTimeKind.Utc), 0, new DateTime(2014, 12, 20, 20, 58, 18, 469, DateTimeKind.Utc), "Socorro", 326, 20 },
                    { "http://swapi.dev/api/planets/29/", "arid", new DateTime(2014, 12, 15, 12, 53, 47, 695, DateTimeKind.Utc), 0, new DateTime(2014, 12, 20, 20, 58, 18, 468, DateTimeKind.Utc), "Trandosha", 371, 25 },
                    { "http://swapi.dev/api/planets/2/", "temperate", new DateTime(2014, 12, 10, 11, 35, 48, 479, DateTimeKind.Utc), 12500, new DateTime(2014, 12, 20, 20, 58, 18, 420, DateTimeKind.Utc), "Alderaan", 364, 24 },
                    { "http://swapi.dev/api/planets/3/", "temperate, tropical", new DateTime(2014, 12, 10, 11, 37, 19, 144, DateTimeKind.Utc), 10200, new DateTime(2014, 12, 20, 20, 58, 18, 421, DateTimeKind.Utc), "Yavin IV", 4818, 24 },
                    { "http://swapi.dev/api/planets/4/", "frozen", new DateTime(2014, 12, 10, 11, 39, 13, 934, DateTimeKind.Utc), 7200, new DateTime(2014, 12, 20, 20, 58, 18, 423, DateTimeKind.Utc), "Hoth", 549, 23 },
                    { "http://swapi.dev/api/planets/5/", "murky", new DateTime(2014, 12, 10, 11, 42, 22, 590, DateTimeKind.Utc), 8900, new DateTime(2014, 12, 20, 20, 58, 18, 425, DateTimeKind.Utc), "Dagobah", 341, 23 },
                    { "http://swapi.dev/api/planets/6/", "temperate", new DateTime(2014, 12, 10, 11, 43, 55, 240, DateTimeKind.Utc), 118000, new DateTime(2014, 12, 20, 20, 58, 18, 427, DateTimeKind.Utc), "Bespin", 5110, 12 },
                    { "http://swapi.dev/api/planets/7/", "temperate", new DateTime(2014, 12, 10, 11, 50, 29, 349, DateTimeKind.Utc), 4900, new DateTime(2014, 12, 20, 20, 58, 18, 429, DateTimeKind.Utc), "Endor", 402, 18 },
                    { "http://swapi.dev/api/planets/8/", "temperate", new DateTime(2014, 12, 10, 11, 52, 31, 66, DateTimeKind.Utc), 12120, new DateTime(2014, 12, 20, 20, 58, 18, 430, DateTimeKind.Utc), "Naboo", 312, 26 },
                    { "http://swapi.dev/api/planets/9/", "temperate", new DateTime(2014, 12, 10, 11, 54, 13, 921, DateTimeKind.Utc), 12240, new DateTime(2014, 12, 20, 20, 58, 18, 432, DateTimeKind.Utc), "Coruscant", 368, 24 },
                    { "http://swapi.dev/api/planets/10/", "temperate", new DateTime(2014, 12, 10, 12, 45, 6, 577, DateTimeKind.Utc), 19720, new DateTime(2014, 12, 20, 20, 58, 18, 434, DateTimeKind.Utc), "Kamino", 463, 27 },
                    { "http://swapi.dev/api/planets/11/", "temperate, arid", new DateTime(2014, 12, 10, 12, 47, 22, 350, DateTimeKind.Utc), 11370, new DateTime(2014, 12, 20, 20, 58, 18, 437, DateTimeKind.Utc), "Geonosis", 256, 30 },
                    { "http://swapi.dev/api/planets/12/", "temperate, arid, windy", new DateTime(2014, 12, 10, 12, 49, 1, 491, DateTimeKind.Utc), 12900, new DateTime(2014, 12, 20, 20, 58, 18, 439, DateTimeKind.Utc), "Utapau", 351, 27 },
                    { "http://swapi.dev/api/planets/13/", "hot", new DateTime(2014, 12, 10, 12, 50, 16, 526, DateTimeKind.Utc), 4200, new DateTime(2014, 12, 20, 20, 58, 18, 440, DateTimeKind.Utc), "Mustafar", 412, 36 },
                    { "http://swapi.dev/api/planets/14/", "tropical", new DateTime(2014, 12, 10, 13, 32, 0, 124, DateTimeKind.Utc), 12765, new DateTime(2014, 12, 20, 20, 58, 18, 442, DateTimeKind.Utc), "Kashyyyk", 381, 26 },
                    { "http://swapi.dev/api/planets/15/", "artificial temperate ", new DateTime(2014, 12, 10, 13, 33, 46, 405, DateTimeKind.Utc), 0, new DateTime(2014, 12, 20, 20, 58, 18, 444, DateTimeKind.Utc), "Polis Massa", 590, 24 },
                    { "http://swapi.dev/api/planets/16/", "frigid", new DateTime(2014, 12, 10, 13, 43, 39, 139, DateTimeKind.Utc), 10088, new DateTime(2014, 12, 20, 20, 58, 18, 446, DateTimeKind.Utc), "Mygeeto", 167, 12 },
                    { "http://swapi.dev/api/planets/17/", "hot, humid", new DateTime(2014, 12, 10, 13, 44, 50, 397, DateTimeKind.Utc), 9100, new DateTime(2014, 12, 20, 20, 58, 18, 447, DateTimeKind.Utc), "Felucia", 231, 34 },
                    { "http://swapi.dev/api/planets/18/", "temperate, moist", new DateTime(2014, 12, 10, 13, 46, 28, 704, DateTimeKind.Utc), 0, new DateTime(2014, 12, 20, 20, 58, 18, 449, DateTimeKind.Utc), "Cato Neimoidia", 278, 25 },
                    { "http://swapi.dev/api/planets/19/", "hot", new DateTime(2014, 12, 10, 13, 47, 46, 874, DateTimeKind.Utc), 14920, new DateTime(2014, 12, 20, 20, 58, 18, 450, DateTimeKind.Utc), "Saleucami", 392, 26 },
                    { "http://swapi.dev/api/planets/20/", "temperate", new DateTime(2014, 12, 10, 16, 16, 26, 566, DateTimeKind.Utc), 0, new DateTime(2014, 12, 20, 20, 58, 18, 452, DateTimeKind.Utc), "Stewjon", -1, -1 },
                    { "http://swapi.dev/api/planets/21/", "polluted", new DateTime(2014, 12, 10, 16, 26, 54, 384, DateTimeKind.Utc), 13490, new DateTime(2014, 12, 20, 20, 58, 18, 454, DateTimeKind.Utc), "Eriadu", 360, 24 },
                    { "http://swapi.dev/api/planets/22/", "temperate", new DateTime(2014, 12, 10, 16, 49, 12, 453, DateTimeKind.Utc), 11000, new DateTime(2014, 12, 20, 20, 58, 18, 456, DateTimeKind.Utc), "Corellia", 329, 25 },
                    { "http://swapi.dev/api/planets/23/", "hot", new DateTime(2014, 12, 10, 17, 3, 28, 110, DateTimeKind.Utc), 7549, new DateTime(2014, 12, 20, 20, 58, 18, 458, DateTimeKind.Utc), "Rodia", 305, 29 },
                    { "http://swapi.dev/api/planets/24/", "temperate", new DateTime(2014, 12, 10, 17, 11, 29, 452, DateTimeKind.Utc), 12150, new DateTime(2014, 12, 20, 20, 58, 18, 460, DateTimeKind.Utc), "Nal Hutta", 413, 87 },
                    { "http://swapi.dev/api/planets/25/", "temperate", new DateTime(2014, 12, 10, 17, 23, 29, 896, DateTimeKind.Utc), 9830, new DateTime(2014, 12, 20, 20, 58, 18, 461, DateTimeKind.Utc), "Dantooine", 378, 25 },
                    { "http://swapi.dev/api/planets/26/", "temperate", new DateTime(2014, 12, 12, 11, 16, 55, 78, DateTimeKind.Utc), 6400, new DateTime(2014, 12, 20, 20, 58, 18, 463, DateTimeKind.Utc), "Bestine IV", 680, 26 },
                    { "http://swapi.dev/api/planets/27/", "temperate", new DateTime(2014, 12, 15, 12, 23, 41, 661, DateTimeKind.Utc), 14050, new DateTime(2014, 12, 20, 20, 58, 18, 464, DateTimeKind.Utc), "Ord Mantell", 334, 26 },
                    { "http://swapi.dev/api/planets/28/", "-1", new DateTime(2014, 12, 15, 12, 25, 59, 569, DateTimeKind.Utc), 0, new DateTime(2014, 12, 20, 20, 58, 18, 466, DateTimeKind.Utc), "-1", 0, 0 },
                    { "http://swapi.dev/api/planets/59/", "arid, temperate, tropical", new DateTime(2014, 12, 20, 19, 43, 51, 278, DateTimeKind.Utc), 13850, new DateTime(2014, 12, 20, 20, 58, 18, 523, DateTimeKind.Utc), "Kalee", 378, 23 },
                    { "http://swapi.dev/api/planets/60/", "-1", new DateTime(2014, 12, 20, 20, 18, 36, 256, DateTimeKind.Utc), -1, new DateTime(2014, 12, 20, 20, 58, 18, 525, DateTimeKind.Utc), "Umbara", -1, -1 }
                });

            migrationBuilder.InsertData(
                table: "MoviePlanet",
                columns: new[] { "MovieUri", "PlanetUri" },
                values: new object[,]
                {
                    { "http://swapi.dev/api/films/1/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/18/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/17/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/16/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/15/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/14/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/13/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/12/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/11/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/10/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/4/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/19/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/7/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/6/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/5/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/5/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/5/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/4/" },
                    { "http://swapi.dev/api/films/1/", "http://swapi.dev/api/planets/3/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/2/" },
                    { "http://swapi.dev/api/films/1/", "http://swapi.dev/api/planets/2/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/4/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/4/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/27/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviePlanet_PlanetUri",
                table: "MoviePlanet",
                column: "PlanetUri");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviePlanet");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
