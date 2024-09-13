using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class ininal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacabookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<int>(type: "int", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompaniesData",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleNameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleNameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsiblePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkFiled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesData", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeResqust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datecreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Stutes = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dateupdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractStatuses",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<int>(type: "int", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractStatuses", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "CoursesIsonlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHide = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesIsonlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesTypes",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    filt = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesTypes", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "CuntaryCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaCun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotationCun = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuntaryCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeScreens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShowTitel = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShowDes = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsButton = table.Column<bool>(type: "bit", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeScreens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayTabsCallbackModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcquirerMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcquirerRRN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranRef = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayTabsCallbackModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNameAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    VlaueData = table.Column<int>(type: "int", nullable: false),
                    MessageData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionsWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionsWeeks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idnumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationsType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsBlock = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainerData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNumber = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    EmailPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailZoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordZoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypePaidData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePaidData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViewsNows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfCourses = table.Column<int>(type: "int", nullable: false),
                    Descraption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Head = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOpen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    PreDiscount = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewsNows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContetntTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Absractation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitelSubject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentSubject2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleSubject3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleContont3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iamge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdaue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoursesTypeCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_CoursesTypes_CoursesTypeCode",
                        column: x => x.CoursesTypeCode,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentCount = table.Column<int>(type: "int", nullable: false),
                    Tiltle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractPrise = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractRest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BranchCode = table.Column<int>(type: "int", nullable: false),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeletae = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractStatusCode = table.Column<int>(type: "int", nullable: true),
                    CompaniesDataId = table.Column<int>(type: "int", nullable: false),
                    CoursesTypeCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractData_CompaniesData_CompaniesDataId",
                        column: x => x.CompaniesDataId,
                        principalTable: "CompaniesData",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractData_ContractStatuses_ContractStatusCode",
                        column: x => x.ContractStatusCode,
                        principalTable: "ContractStatuses",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_ContractData_CoursesTypes_CoursesTypeCode",
                        column: x => x.CoursesTypeCode,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "CoursesData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SummaryAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SammaryEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalsAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalsEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailsAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailsEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceNoM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FromalutetestAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromalutetestEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilesData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoursesTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesData_CoursesTypes_CoursesTypeId",
                        column: x => x.CoursesTypeId,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePremotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursesData = table.Column<bool>(type: "bit", nullable: false),
                    CoursesScheduless = table.Column<bool>(type: "bit", nullable: false),
                    CoursesStutes = table.Column<bool>(type: "bit", nullable: false),
                    Matdetory = table.Column<bool>(type: "bit", nullable: false),
                    ViewsNow = table.Column<bool>(type: "bit", nullable: false),
                    RequiredCourse = table.Column<bool>(type: "bit", nullable: false),
                    Article = table.Column<bool>(type: "bit", nullable: false),
                    Company = table.Column<bool>(type: "bit", nullable: false),
                    Contract = table.Column<bool>(type: "bit", nullable: false),
                    CompanyRequest = table.Column<bool>(type: "bit", nullable: false),
                    Studnt = table.Column<bool>(type: "bit", nullable: false),
                    CoursesType = table.Column<bool>(type: "bit", nullable: false),
                    TypePaid = table.Column<bool>(type: "bit", nullable: false),
                    EmployeePage = table.Column<bool>(type: "bit", nullable: false),
                    HomePage = table.Column<bool>(type: "bit", nullable: false),
                    Room = table.Column<bool>(type: "bit", nullable: false),
                    Zoom = table.Column<bool>(type: "bit", nullable: false),
                    Complaints = table.Column<bool>(type: "bit", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePremotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePremotion_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SessionsDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionsWeekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionsDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionsDays_SessionsWeeks_SessionsWeekId",
                        column: x => x.SessionsWeekId,
                        principalTable: "SessionsWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursesScheduless",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    NumberOfHourse = table.Column<int>(type: "int", nullable: false),
                    CloseDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfWeek = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsHadaf = table.Column<bool>(type: "bit", nullable: false),
                    IsFares = table.Column<bool>(type: "bit", nullable: false),
                    IsRamdan = table.Column<bool>(type: "bit", nullable: false),
                    LinkWhatsApp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeCoures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHide = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoursesIsonlineId = table.Column<int>(type: "int", nullable: false),
                    CoursesDataId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    CoursesTypeCode = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CoursesStatusId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CoursesTypeCode1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesScheduless", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_CoursesData_CoursesDataId",
                        column: x => x.CoursesDataId,
                        principalTable: "CoursesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_CoursesIsonlines_CoursesIsonlineId",
                        column: x => x.CoursesIsonlineId,
                        principalTable: "CoursesIsonlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_CoursesStatuses_CoursesStatusId",
                        column: x => x.CoursesStatusId,
                        principalTable: "CoursesStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_CoursesTypes_CoursesTypeCode",
                        column: x => x.CoursesTypeCode,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_CoursesTypes_CoursesTypeCode1",
                        column: x => x.CoursesTypeCode1,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesScheduless_TrainerData_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "TrainerData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursesReserveds",
                columns: table => new
                {
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StutusReserved = table.Column<bool>(type: "bit", nullable: false),
                    StutusPaidup = table.Column<bool>(type: "bit", nullable: false),
                    Paidup = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreDiscount = table.Column<int>(type: "int", nullable: false),
                    IsView = table.Column<bool>(type: "bit", nullable: false),
                    BalanceDue = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractDatumId = table.Column<int>(type: "int", nullable: true),
                    IsCompany = table.Column<bool>(type: "bit", nullable: true),
                    TypePaidId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesReserveds", x => new { x.StudentId, x.CoursesSchedulessId });
                    table.ForeignKey(
                        name: "FK_CoursesReserveds_ContractData_ContractDatumId",
                        column: x => x.ContractDatumId,
                        principalTable: "ContractData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CoursesReserveds_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesReserveds_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesReserveds_TypePaidData_TypePaidId",
                        column: x => x.TypePaidId,
                        principalTable: "TypePaidData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoveStudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    ToCourses = table.Column<int>(type: "int", nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateTraform = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudntId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveStudent_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveStudent_Students_StudntId",
                        column: x => x.StudntId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequiredCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAribic = table.Column<bool>(type: "bit", nullable: false),
                    DateNw = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoursesTypeCode = table.Column<int>(type: "int", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    CoursesTypeCode1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequiredCourse_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequiredCourse_CoursesTypes_CoursesTypeCode",
                        column: x => x.CoursesTypeCode,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequiredCourse_CoursesTypes_CoursesTypeCode1",
                        column: x => x.CoursesTypeCode1,
                        principalTable: "CoursesTypes",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "SessionsRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    MeatingId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeatingUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReplcesing = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionsDayId = table.Column<int>(type: "int", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionsRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionsRecords_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SessionsRecords_SessionsDays_SessionsDayId",
                        column: x => x.SessionsDayId,
                        principalTable: "SessionsDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ViewStudnts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isSelected = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    ViewsNowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewStudnts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViewStudnts_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ViewStudnts_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ViewStudnts_ViewsNows_ViewsNowId",
                        column: x => x.ViewsNowId,
                        principalTable: "ViewsNows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "ArabicName", "CreatedDate", "EnglishName", "FacabookUrl", "InstagramUrl", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "Location", "Phone", "Phone2", "TwitterUrl", "UserCode", "WebsiteUrl", "WhatsApp" },
                values: new object[] { 1, null, "الرياض", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5253), "Riyadh", null, null, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5253), 1, null, null, null, null, 1, null, null });

            migrationBuilder.InsertData(
                table: "ContractStatuses",
                columns: new[] { "Code", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "مفعل", new DateTime(2023, 8, 27, 0, 52, 18, 0, DateTimeKind.Unspecified), "Active", false, null, null, 111 },
                    { 2, "غير مفعل", new DateTime(2023, 8, 27, 0, 52, 34, 0, DateTimeKind.Unspecified), "Not Active", false, null, null, 111 }
                });

            migrationBuilder.InsertData(
                table: "CoursesIsonlines",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "حضوري", new DateTime(2023, 8, 27, 0, 52, 18, 0, DateTimeKind.Unspecified), "offline", new DateTime(2023, 11, 28, 0, 20, 10, 0, DateTimeKind.Unspecified), "111", "111" },
                    { 2, "أون لاين", new DateTime(2023, 8, 27, 0, 52, 34, 0, DateTimeKind.Unspecified), "online", null, null, "111" }
                });

            migrationBuilder.InsertData(
                table: "CoursesStatuses",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "مفتوحه", new DateTime(2023, 8, 27, 0, 52, 52, 0, DateTimeKind.Unspecified), "opened", false, false, new DateTime(2023, 8, 27, 0, 54, 50, 0, DateTimeKind.Unspecified), "111", "111" },
                    { 2, "مغلقه", new DateTime(2023, 8, 27, 0, 53, 9, 0, DateTimeKind.Unspecified), "clossed", false, false, new DateTime(2023, 8, 27, 0, 55, 18, 0, DateTimeKind.Unspecified), "111", "111" },
                    { 3, "منتهيه", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5414), "ended", false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5415), "111", "111" },
                    { 4, "ملغاه", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5417), "cancelled", false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5418), "111", "111" }
                });

            migrationBuilder.InsertData(
                table: "CoursesTypes",
                columns: new[] { "Code", "ArabicName", "CreatedDate", "EnglishName", "Image", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "UserCode", "filt" },
                values: new object[,]
                {
                    { 1, "أمن المعلومات", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5191), "Information Security", null, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5203), null, null, 0 },
                    { 2, "إدارة أعمال", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5207), "Business Management", null, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5207), null, null, 0 },
                    { 3, "برمجـــــــة", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5208), "Programming", null, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5209), null, null, 0 },
                    { 4, "شبكـــــات", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5217), "Networking", null, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5217), null, null, 0 },
                    { 5, "إدارة خوادم وسـيرفرات", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5218), "Server Management", null, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5219), null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "HomeScreens",
                columns: new[] { "Id", "Description", "Image", "IsButton", "IsShowDes", "IsShowTitel", "State", "Title" },
                values: new object[] { 1, "معهد شبكة آباد للتدريب من المعاهد الرائدة في تقديم الدورات التطويرية المتخصصة في تقنية المعلومات.", "banner.webp", true, true, true, true, "مرحبا بكم في آباد للتدريب" });

            migrationBuilder.InsertData(
                table: "SelectDatas",
                columns: new[] { "Id", "MessageData", "VlaueData" },
                values: new object[] { 1, "1", 1 });

            migrationBuilder.InsertData(
                table: "TypePaidData",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "IsHide", "IsLocked", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "كاش", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5277), "Cash", false, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5274), null, "111" },
                    { 2, "شبكه", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5279), "network", false, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5278), null, "111" },
                    { 3, "تمارا", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5282), "Tamara", false, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5281), null, "111" },
                    { 4, "تابي", new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5284), "tabby", false, false, false, new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5283), null, "111" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_CoursesTypeCode",
                table: "Article",
                column: "CoursesTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_CompaniesDataId",
                table: "ContractData",
                column: "CompaniesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_ContractStatusCode",
                table: "ContractData",
                column: "ContractStatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_ContractData_CoursesTypeCode",
                table: "ContractData",
                column: "CoursesTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesData_CoursesTypeId",
                table: "CoursesData",
                column: "CoursesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesReserveds_ContractDatumId",
                table: "CoursesReserveds",
                column: "ContractDatumId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesReserveds_CoursesSchedulessId",
                table: "CoursesReserveds",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesReserveds_TypePaidId",
                table: "CoursesReserveds",
                column: "TypePaidId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_BranchId",
                table: "CoursesScheduless",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_CoursesDataId",
                table: "CoursesScheduless",
                column: "CoursesDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_CoursesIsonlineId",
                table: "CoursesScheduless",
                column: "CoursesIsonlineId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_CoursesStatusId",
                table: "CoursesScheduless",
                column: "CoursesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_CoursesTypeCode",
                table: "CoursesScheduless",
                column: "CoursesTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_CoursesTypeCode1",
                table: "CoursesScheduless",
                column: "CoursesTypeCode1");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_RoomId",
                table: "CoursesScheduless",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesScheduless_TrainerId",
                table: "CoursesScheduless",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePremotion_EmployeeId",
                table: "EmployeePremotion",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveStudent_CoursesSchedulessId",
                table: "MoveStudent",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveStudent_StudntId",
                table: "MoveStudent",
                column: "StudntId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredCourse_CoursesSchedulessId",
                table: "RequiredCourse",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredCourse_CoursesTypeCode",
                table: "RequiredCourse",
                column: "CoursesTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredCourse_CoursesTypeCode1",
                table: "RequiredCourse",
                column: "CoursesTypeCode1");

            migrationBuilder.CreateIndex(
                name: "IX_SessionsDays_SessionsWeekId",
                table: "SessionsDays",
                column: "SessionsWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionsRecords_CoursesSchedulessId",
                table: "SessionsRecords",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionsRecords_SessionsDayId",
                table: "SessionsRecords",
                column: "SessionsDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViewStudnts_CoursesSchedulessId",
                table: "ViewStudnts",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewStudnts_StudentId",
                table: "ViewStudnts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewStudnts_ViewsNowId",
                table: "ViewStudnts",
                column: "ViewsNowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "CompanyRequests");

            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "CoursesReserveds");

            migrationBuilder.DropTable(
                name: "CuntaryCodes");

            migrationBuilder.DropTable(
                name: "EmployeePremotion");

            migrationBuilder.DropTable(
                name: "HomeScreens");

            migrationBuilder.DropTable(
                name: "MoveStudent");

            migrationBuilder.DropTable(
                name: "PayTabsCallbackModel");

            migrationBuilder.DropTable(
                name: "RequiredCourse");

            migrationBuilder.DropTable(
                name: "SelectDatas");

            migrationBuilder.DropTable(
                name: "SessionsRecords");

            migrationBuilder.DropTable(
                name: "ViewStudnts");

            migrationBuilder.DropTable(
                name: "ContractData");

            migrationBuilder.DropTable(
                name: "TypePaidData");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "SessionsDays");

            migrationBuilder.DropTable(
                name: "CoursesScheduless");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ViewsNows");

            migrationBuilder.DropTable(
                name: "CompaniesData");

            migrationBuilder.DropTable(
                name: "ContractStatuses");

            migrationBuilder.DropTable(
                name: "SessionsWeeks");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "CoursesData");

            migrationBuilder.DropTable(
                name: "CoursesIsonlines");

            migrationBuilder.DropTable(
                name: "CoursesStatuses");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "TrainerData");

            migrationBuilder.DropTable(
                name: "CoursesTypes");
        }
    }
}
