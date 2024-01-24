using SharpIdentityProg.Data;

namespace SharpCountriesProg.Models
{
    internal class Seeder
    {
        public ApplicationUser GetDefault()
        {
            var user = new ApplicationUser();

            user.Email = "admin@admin.com";
            user.PasswordHash = "AQAAAAIAAYagAAAAEOz5jotj3wCA6wtIcmJDXvnjuzn9kUGLlhGSS3Jn+x4y1feHOrKU946epjVy7isIBw==";
            user.SecurityStamp = "RRJP55XYEE2V3GWWPPQ76ECWXQCPIN7G";
            user.ConcurrencyStamp = "48f54203-7dbd-4ddf-ad56-ddbd1f1201fe";

            user.Id = "5d3e01f4-d15a-4ba4-9935-2965f2a3e585";
            user.NormalizedUserName = "ADMIN@ADMIN.COM";
            user.UserName = "admin@admin.com";
            user.NormalizedEmail = "ADMIN@ADMIN.COM";
            user.EmailConfirmed = false;
            user.LockoutEnabled = true;

            return user;
        }
    }
}
