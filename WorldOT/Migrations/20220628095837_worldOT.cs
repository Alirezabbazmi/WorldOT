using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldOT.Migrations
{
    public partial class worldOT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailIsVerif = table.Column<bool>(type: "bit", nullable: false),
                    SpaceInUse = table.Column<long>(type: "bigint", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Satisfied = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Anbar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anbar", x => x.id);
                    table.ForeignKey(
                        name: "FK_Anbar_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coal", x => x.id);
                    table.ForeignKey(
                        name: "FK_Coal_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "coalMine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coalMine", x => x.id);
                    table.ForeignKey(
                        name: "FK_coalMine_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "coordinates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<long>(type: "bigint", nullable: false),
                    Y = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coordinates", x => x.id);
                    table.ForeignKey(
                        name: "FK_coordinates_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuttingWood",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuttingWood", x => x.id);
                    table.ForeignKey(
                        name: "FK_CuttingWood_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.id);
                    table.ForeignKey(
                        name: "FK_Farm_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GrapeGarden",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrapeGarden", x => x.id);
                    table.ForeignKey(
                        name: "FK_GrapeGarden_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grapes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grapes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Grapes_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Iron",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iron", x => x.id);
                    table.ForeignKey(
                        name: "FK_Iron_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "level",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_level", x => x.id);
                    table.ForeignKey(
                        name: "FK_level_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RaceOfSoliders",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceOfSoliders", x => x.id);
                    table.ForeignKey(
                        name: "FK_RaceOfSoliders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Smithy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smithy", x => x.id);
                    table.ForeignKey(
                        name: "FK_Smithy_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SoliderHouses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoliderHouses", x => x.id);
                    table.ForeignKey(
                        name: "FK_SoliderHouses_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stone",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stone", x => x.id);
                    table.ForeignKey(
                        name: "FK_Stone_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoneMine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneMine", x => x.id);
                    table.ForeignKey(
                        name: "FK_StoneMine_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sulfur",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sulfur", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sulfur_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Volcano",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volcano", x => x.id);
                    table.ForeignKey(
                        name: "FK_Volcano_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wealth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coin = table.Column<long>(type: "bigint", nullable: false),
                    Diamonds = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wealth", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wealth_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wheat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wheat_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wood",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    Sourcesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wood", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wood_Users_Sourcesid",
                        column: x => x.Sourcesid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkerBuilding",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Workers = table.Column<int>(type: "int", nullable: false),
                    Buildingid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerBuilding", x => x.id);
                    table.ForeignKey(
                        name: "FK_WorkerBuilding_Users_Buildingid",
                        column: x => x.Buildingid,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KnightsRace",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Racesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnightsRace", x => x.id);
                    table.ForeignKey(
                        name: "FK_KnightsRace_RaceOfSoliders_Racesid",
                        column: x => x.Racesid,
                        principalTable: "RaceOfSoliders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NaziRace",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Racesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaziRace", x => x.id);
                    table.ForeignKey(
                        name: "FK_NaziRace_RaceOfSoliders_Racesid",
                        column: x => x.Racesid,
                        principalTable: "RaceOfSoliders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VikingRace",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Racesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VikingRace", x => x.id);
                    table.ForeignKey(
                        name: "FK_VikingRace_RaceOfSoliders_Racesid",
                        column: x => x.Racesid,
                        principalTable: "RaceOfSoliders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WizardRace",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Racesid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WizardRace", x => x.id);
                    table.ForeignKey(
                        name: "FK_WizardRace_RaceOfSoliders_Racesid",
                        column: x => x.Racesid,
                        principalTable: "RaceOfSoliders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catapults",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catapults", x => x.id);
                    table.ForeignKey(
                        name: "FK_Catapults_KnightsRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "KnightsRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Doctors_KnightsRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "KnightsRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DragonRider",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DragonRider", x => x.id);
                    table.ForeignKey(
                        name: "FK_DragonRider_KnightsRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "KnightsRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecretSpecialForces",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretSpecialForces", x => x.id);
                    table.ForeignKey(
                        name: "FK_SecretSpecialForces_KnightsRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "KnightsRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Swordsmans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swordsmans", x => x.id);
                    table.ForeignKey(
                        name: "FK_Swordsmans_KnightsRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "KnightsRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NArmed",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NArmed", x => x.id);
                    table.ForeignKey(
                        name: "FK_NArmed_NaziRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "NaziRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NMortar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NMortar", x => x.id);
                    table.ForeignKey(
                        name: "FK_NMortar_NaziRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "NaziRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NNurse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NNurse", x => x.id);
                    table.ForeignKey(
                        name: "FK_NNurse_NaziRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "NaziRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NSniper",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSniper", x => x.id);
                    table.ForeignKey(
                        name: "FK_NSniper_NaziRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "NaziRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NWarplane",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWarplane", x => x.id);
                    table.ForeignKey(
                        name: "FK_NWarplane_NaziRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "NaziRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VBalon",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VBalon", x => x.id);
                    table.ForeignKey(
                        name: "FK_VBalon_VikingRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "VikingRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VBarbar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    WizardRaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VBarbar", x => x.id);
                    table.ForeignKey(
                        name: "FK_VBarbar_VikingRace_WizardRaceModelid",
                        column: x => x.WizardRaceModelid,
                        principalTable: "VikingRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VSecretaxes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VSecretaxes", x => x.id);
                    table.ForeignKey(
                        name: "FK_VSecretaxes_VikingRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "VikingRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VStonethrower",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VStonethrower", x => x.id);
                    table.ForeignKey(
                        name: "FK_VStonethrower_VikingRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "VikingRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VTapster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    RaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VTapster", x => x.id);
                    table.ForeignKey(
                        name: "FK_VTapster_VikingRace_RaceModelid",
                        column: x => x.RaceModelid,
                        principalTable: "VikingRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WCarpetRider",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    WizardRaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WCarpetRider", x => x.id);
                    table.ForeignKey(
                        name: "FK_WCarpetRider_WizardRace_WizardRaceModelid",
                        column: x => x.WizardRaceModelid,
                        principalTable: "WizardRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WCrowMan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    WizardRaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WCrowMan", x => x.id);
                    table.ForeignKey(
                        name: "FK_WCrowMan_WizardRace_WizardRaceModelid",
                        column: x => x.WizardRaceModelid,
                        principalTable: "WizardRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WHealer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    WizardRaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WHealer", x => x.id);
                    table.ForeignKey(
                        name: "FK_WHealer_WizardRace_WizardRaceModelid",
                        column: x => x.WizardRaceModelid,
                        principalTable: "WizardRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WinvisibleMan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    WizardRaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinvisibleMan", x => x.id);
                    table.ForeignKey(
                        name: "FK_WinvisibleMan_WizardRace_WizardRaceModelid",
                        column: x => x.WizardRaceModelid,
                        principalTable: "WizardRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WWitcher",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lev = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    WizardRaceModelid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WWitcher", x => x.id);
                    table.ForeignKey(
                        name: "FK_WWitcher_WizardRace_WizardRaceModelid",
                        column: x => x.WizardRaceModelid,
                        principalTable: "WizardRace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anbar_Buildingid",
                table: "Anbar",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Catapults_RaceModelid",
                table: "Catapults",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Coal_Sourcesid",
                table: "Coal",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_coalMine_Buildingid",
                table: "coalMine",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_coordinates_UserID",
                table: "coordinates",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingWood_Buildingid",
                table: "CuttingWood",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_RaceModelid",
                table: "Doctors",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DragonRider_RaceModelid",
                table: "DragonRider",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Farm_Buildingid",
                table: "Farm",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GrapeGarden_Buildingid",
                table: "GrapeGarden",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Grapes_Sourcesid",
                table: "Grapes",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Iron_Sourcesid",
                table: "Iron",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KnightsRace_Racesid",
                table: "KnightsRace",
                column: "Racesid",
                unique: true,
                filter: "[Racesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_level_UserID",
                table: "level",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NArmed_RaceModelid",
                table: "NArmed",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NaziRace_Racesid",
                table: "NaziRace",
                column: "Racesid",
                unique: true,
                filter: "[Racesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NMortar_RaceModelid",
                table: "NMortar",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NNurse_RaceModelid",
                table: "NNurse",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NSniper_RaceModelid",
                table: "NSniper",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NWarplane_RaceModelid",
                table: "NWarplane",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RaceOfSoliders_UserID",
                table: "RaceOfSoliders",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SecretSpecialForces_RaceModelid",
                table: "SecretSpecialForces",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Smithy_Buildingid",
                table: "Smithy",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoliderHouses_Buildingid",
                table: "SoliderHouses",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Stone_Sourcesid",
                table: "Stone",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StoneMine_Buildingid",
                table: "StoneMine",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Sulfur_Sourcesid",
                table: "Sulfur",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Swordsmans_RaceModelid",
                table: "Swordsmans",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VBalon_RaceModelid",
                table: "VBalon",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VBarbar_WizardRaceModelid",
                table: "VBarbar",
                column: "WizardRaceModelid",
                unique: true,
                filter: "[WizardRaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VikingRace_Racesid",
                table: "VikingRace",
                column: "Racesid",
                unique: true,
                filter: "[Racesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Volcano_Buildingid",
                table: "Volcano",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VSecretaxes_RaceModelid",
                table: "VSecretaxes",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VStonethrower_RaceModelid",
                table: "VStonethrower",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VTapster_RaceModelid",
                table: "VTapster",
                column: "RaceModelid",
                unique: true,
                filter: "[RaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WCarpetRider_WizardRaceModelid",
                table: "WCarpetRider",
                column: "WizardRaceModelid",
                unique: true,
                filter: "[WizardRaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WCrowMan_WizardRaceModelid",
                table: "WCrowMan",
                column: "WizardRaceModelid",
                unique: true,
                filter: "[WizardRaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wealth_UserID",
                table: "Wealth",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WHealer_WizardRaceModelid",
                table: "WHealer",
                column: "WizardRaceModelid",
                unique: true,
                filter: "[WizardRaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wheat_Sourcesid",
                table: "Wheat",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WinvisibleMan_WizardRaceModelid",
                table: "WinvisibleMan",
                column: "WizardRaceModelid",
                unique: true,
                filter: "[WizardRaceModelid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WizardRace_Racesid",
                table: "WizardRace",
                column: "Racesid",
                unique: true,
                filter: "[Racesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wood_Sourcesid",
                table: "Wood",
                column: "Sourcesid",
                unique: true,
                filter: "[Sourcesid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerBuilding_Buildingid",
                table: "WorkerBuilding",
                column: "Buildingid",
                unique: true,
                filter: "[Buildingid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WWitcher_WizardRaceModelid",
                table: "WWitcher",
                column: "WizardRaceModelid",
                unique: true,
                filter: "[WizardRaceModelid] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anbar");

            migrationBuilder.DropTable(
                name: "Catapults");

            migrationBuilder.DropTable(
                name: "Coal");

            migrationBuilder.DropTable(
                name: "coalMine");

            migrationBuilder.DropTable(
                name: "coordinates");

            migrationBuilder.DropTable(
                name: "CuttingWood");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "DragonRider");

            migrationBuilder.DropTable(
                name: "Farm");

            migrationBuilder.DropTable(
                name: "GrapeGarden");

            migrationBuilder.DropTable(
                name: "Grapes");

            migrationBuilder.DropTable(
                name: "Iron");

            migrationBuilder.DropTable(
                name: "level");

            migrationBuilder.DropTable(
                name: "NArmed");

            migrationBuilder.DropTable(
                name: "NMortar");

            migrationBuilder.DropTable(
                name: "NNurse");

            migrationBuilder.DropTable(
                name: "NSniper");

            migrationBuilder.DropTable(
                name: "NWarplane");

            migrationBuilder.DropTable(
                name: "SecretSpecialForces");

            migrationBuilder.DropTable(
                name: "Smithy");

            migrationBuilder.DropTable(
                name: "SoliderHouses");

            migrationBuilder.DropTable(
                name: "Stone");

            migrationBuilder.DropTable(
                name: "StoneMine");

            migrationBuilder.DropTable(
                name: "Sulfur");

            migrationBuilder.DropTable(
                name: "Swordsmans");

            migrationBuilder.DropTable(
                name: "VBalon");

            migrationBuilder.DropTable(
                name: "VBarbar");

            migrationBuilder.DropTable(
                name: "Volcano");

            migrationBuilder.DropTable(
                name: "VSecretaxes");

            migrationBuilder.DropTable(
                name: "VStonethrower");

            migrationBuilder.DropTable(
                name: "VTapster");

            migrationBuilder.DropTable(
                name: "WCarpetRider");

            migrationBuilder.DropTable(
                name: "WCrowMan");

            migrationBuilder.DropTable(
                name: "Wealth");

            migrationBuilder.DropTable(
                name: "WHealer");

            migrationBuilder.DropTable(
                name: "Wheat");

            migrationBuilder.DropTable(
                name: "WinvisibleMan");

            migrationBuilder.DropTable(
                name: "Wood");

            migrationBuilder.DropTable(
                name: "WorkerBuilding");

            migrationBuilder.DropTable(
                name: "WWitcher");

            migrationBuilder.DropTable(
                name: "NaziRace");

            migrationBuilder.DropTable(
                name: "KnightsRace");

            migrationBuilder.DropTable(
                name: "VikingRace");

            migrationBuilder.DropTable(
                name: "WizardRace");

            migrationBuilder.DropTable(
                name: "RaceOfSoliders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
