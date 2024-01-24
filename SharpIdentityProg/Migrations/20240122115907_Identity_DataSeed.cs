using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpIdentityProg.Migrations
{
    /// <inheritdoc />
    public partial class Identity_DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce8613d0-eb5a-44e4-b163-ed82953efaed", 0, "48f54203-7dbd-4ddf-ad56-ddbd1f1201fe", "admin@admin.com", false, true, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOz5jotj3wCA6wtIcmJDXvnjuzn9kUGLlhGSS3Jn+x4y1feHOrKU946epjVy7isIBw==", null, false, "RRJP55XYEE2V3GWWPPQ76ECWXQCPIN7G", false, "admin@admin.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce8613d0-eb5a-44e4-b163-ed82953efaed");
        }
    }
}
