using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantManager.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutSubtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutNumberOne = table.Column<int>(type: "int", nullable: false),
                    AboutNumberTwo = table.Column<int>(type: "int", nullable: false),
                    AboutNumberOneTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutNumberTwoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDescriptionOneTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDescriptionTwoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrlOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrlTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrlThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrlFour = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingSubtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingPersonCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingSpecialRequest = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    ChefsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChefsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChefsSubtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChefsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChefsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChefsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.ChefsId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "PopularMenus",
                columns: table => new
                {
                    PopularMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakfastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakfestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakfastPrice = table.Column<int>(type: "int", nullable: false),
                    BreakfastImageUrl = table.Column<int>(type: "int", nullable: false),
                    LaunchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaunchDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaunchPrice = table.Column<int>(type: "int", nullable: false),
                    LaunchImageUrl = table.Column<int>(type: "int", nullable: false),
                    DinnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerPrice = table.Column<int>(type: "int", nullable: false),
                    DinnerImageUrl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopularMenus", x => x.PopularMenuId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaIcon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Testiomonials",
                columns: table => new
                {
                    TestiomonialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestiomonialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestiomonialDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestiomonialImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testiomonials", x => x.TestiomonialId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Chefs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "PopularMenus");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Testiomonials");
        }
    }
}
