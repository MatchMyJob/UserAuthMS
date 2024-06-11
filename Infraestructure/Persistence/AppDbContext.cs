using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "2048b194-4cda-4320-8b72-c169b4788fe9", Name = "admin", NormalizedName = "ADMIN" },
               new IdentityRole { Id = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", Name = "jobuser", NormalizedName = "JOBUSER" },
               new IdentityRole { Id = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", Name = "company", NormalizedName = "COMPANY" }
            );

            var hasher = new PasswordHasher<User>();
                


            modelBuilder.Entity<User>().HasData(
                
                //ADMIN

                new User
                {
                    Id = "3c875016-9cfb-4529-824d-1517c5a93583",
                    UserName = "Ivy97",
                    NormalizedUserName = "IVY97",
                    Email = "ivanbrestt@gmail.com",
                    NormalizedEmail = "IVANBRESTT@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },

                //COMPANY

                new User
                {
                    Id = "ecdb5eda-1cee-4e68-b100-160203158d57",
                    UserName = "Accenture",
                    NormalizedUserName = "ACCENTURE",
                    Email = "accenture@accenture.com",
                    NormalizedEmail = "ACCENTURE@ACCENTURE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "d51252c3-6e21-4ffc-aab3-f4bda791a574",
                    UserName = "MercadoLibre",
                    NormalizedUserName = "MERCADOLIBRE",
                    Email = "meli@mercadolibre.com",
                    NormalizedEmail = "MELI@MERCADOLIBRE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "925b2ab6-5a03-40a7-891e-7bb594086e61",
                    UserName = "EntaConsulting",
                    NormalizedUserName = "ENTACONSULTING",
                    Email = "entaconsulting@gmail.com",
                    NormalizedEmail = "ENTACONSULTING@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "9d8b9e84-33a7-4c28-a6c0-5941a68f1968",
                    UserName = "AdnRecursosHumanos",
                    NormalizedUserName = "ADNRECURSOSHUMANOS",
                    Email = "rrhh@adnrh.com.ar",
                    NormalizedEmail = "RRHH@ADNRH.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "09260ec0-0368-4da8-80d5-6e8b9c574920",
                    UserName = "QuickPass",
                    NormalizedUserName = "QUICKPASS",
                    Email = "rrhh@quickpassweb.com",
                    NormalizedEmail = "RRHH@QUICKPASSWEB.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "a3fb7e92-6b31-4630-835c-3ea7d11e4306",
                    UserName = "Data108",
                    NormalizedUserName = "DATA108",
                    Email = "data108@hotmail.com",
                    NormalizedEmail = "DATA108@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "02bdfba1-5d7d-46f8-89c7-5d02a5fc7655",
                    UserName = "AccusysTechnology",
                    NormalizedUserName = "ACCUSYSTECHNOLOGY",
                    Email = "rrhh@accusys.com.ar",
                    NormalizedEmail = "RRHH@ACCUSYS.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "be76d6cb-0532-4dd5-8e4e-f944faf0106b",
                    UserName = "SistemasActivosSRL",
                    NormalizedUserName = "SISTEMASACTIVOSSRL",
                    Email = "rrhh@sistemasactivos.com",
                    NormalizedEmail = "RRHH@SISTEMASACTIVOS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ac270f24-3f1f-43a6-b291-1f0ce4489bfd",
                    UserName = "IngematicaSA",
                    NormalizedUserName = "INGEMATICASA",
                    Email = "rrhh@ingematica.net",
                    NormalizedEmail = "RRHH@INGEMATICA.NET",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "2a913313-dc4c-4f93-a1be-3fc5568e00b1",
                    UserName = "Axoft",
                    NormalizedUserName = "AXOFT",
                    Email = "rrhh@axoft.com",
                    NormalizedEmail = "RRHH@AXOFT.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "f42be566-1cc3-4863-9cf1-315828169000",
                    UserName = "Softtek",
                    NormalizedUserName = "SOFTTEK",
                    Email = "recursosh@softtek.com",
                    NormalizedEmail = "RECURSOSH@SOFTTEK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "0d4ad714-56a4-4bfc-b4b4-d776cfd51fd8",
                    UserName = "TelecomArgentina",
                    NormalizedUserName = "TELECOMARGENTINA",
                    Email = "rrhhtca@telecom.com.ar",
                    NormalizedEmail = "RRHHTCA@TELECOM.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "d4caf327-f110-4ab6-9305-c064a2071dc5",
                    UserName = "PersonalArgentina",
                    NormalizedUserName = "PERSONALARGENTINA",
                    Email = "personal@personal.com.ar",
                    NormalizedEmail = "PERSONAL@PERSONAL.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "874fb32f-0ddd-4b5f-ac31-f2f11b66e098",
                    UserName = "PayPal",
                    NormalizedUserName = "PAYPAL",
                    Email = "info@paypal.com",
                    NormalizedEmail = "INFO@PAYPAL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "57168621-b0dd-4fe4-a20e-489171d70a5d",
                    UserName = "EY",
                    NormalizedUserName = "EY",
                    Email = "rrhh@ey.com",
                    NormalizedEmail = "RRHH@EY.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "379982fe-d22e-429f-bc14-26fffc569958",
                    UserName = "SantanderArgentina",
                    NormalizedUserName = "SANTANDERARGENTINA",
                    Email = "rrhh@santander.com.ar",
                    NormalizedEmail = "RRHH@SANTANDER.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "9f7c46a4-9ea5-4bc6-bd47-90ba52c54734",
                    UserName = "GaliciaBank",
                    NormalizedUserName = "GALICIABANK",
                    Email = "rrhh@galicia.com.ar",
                    NormalizedEmail = "RRHH@GALICIA.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "b735e23e-c928-41fc-b399-aa4a28807210",
                    UserName = "Adviters",
                    NormalizedUserName = "ADVITERS",
                    Email = "rrhh@Adviters.com",
                    NormalizedEmail = "RRHH@ADVITERS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "f4c4ffe2-e95d-4c05-a958-d32b26fecfc2",
                    UserName = "FasterArgentina",
                    NormalizedUserName = "FASTERARGENTINA",
                    Email = "info@ettfaster.com.ar",
                    NormalizedEmail = "INFO@ETTFASTER.COM.AR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "a4db8ecb-2f10-436e-8011-cf701620ea60",
                    UserName = "SidesysItSolutions",
                    NormalizedUserName = "SIDESYSITSOLUTIONS",
                    Email = "rrhh@sis.com",
                    NormalizedEmail = "RRHH@SIS.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ddc7879b-e104-4047-bd15-d0fade9bbeee",
                    UserName = "GrupoGestion",
                    NormalizedUserName = "GRUPOGESTION",
                    Email = "rrhh@grupogestion.com",
                    NormalizedEmail = "RRHH@GRUPOGESTION.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },

                //JOBUSER

                new User
                {
                    Id = "e60df533-79d7-42f2-a36d-99362dbc6f85",
                    UserName = "Leonel47",
                    NormalizedUserName = "LEONEL47",
                    Email = "leonelesquivel@gmail.com",
                    NormalizedEmail = "LEONELESQUIVEL@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473",
                    UserName = "AnaGomez",
                    NormalizedUserName = "ANAGOMEZ",
                    Email = "anagomez@gmail.com",
                    NormalizedEmail = "ANAGOMEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "a0deb200-955f-4b6c-b550-9ca1712392a8",
                    UserName = "Carlos23",
                    NormalizedUserName = "CARLOS23",
                    Email = "carlosrodriguez@gmail.com",
                    NormalizedEmail = "CARLOSRODRIGUEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "5b68ad8c-f42e-40d7-87de-3622d34dcf84",
                    UserName = "Maria25",
                    NormalizedUserName = "MARIA25",
                    Email = "mariagarcia@gmail.com",
                    NormalizedEmail = "MARIAGARCIA@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "597719b7-3036-4f95-92f8-5163b3e18931",
                    UserName = "JoseLuis45",
                    NormalizedUserName = "JOSELUIS45",
                    Email = "joseluis@gmail.com",
                    NormalizedEmail = "JOSELUIS@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "b9b2181b-d620-4db0-9561-9c1ba02480bb",
                    UserName = "Luis10",
                    NormalizedUserName = "LUIS10",
                    Email = "luisfernandez@gmail.com",
                    NormalizedEmail = "LUISFERNANDEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "53a20833-f2ef-4cb7-a049-326d0cb255ad",
                    UserName = "Marta34",
                    NormalizedUserName = "MARTA34",
                    Email = "martarivera@gmail.com",
                    NormalizedEmail = "MARTARIVERA@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "3c36090f-464c-4c80-ac2b-e32ca07c44a9",
                    UserName = "Miguel67",
                    NormalizedUserName = "MIGUEL67",
                    Email = "miguelsanchez@gmail.com",
                    NormalizedEmail = "MIGUELSANCHEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978",
                    UserName = "Laura12",
                    NormalizedUserName = "LAURA12",
                    Email = "laurahernandez@gmail.com",
                    NormalizedEmail = "LAURAHERNANDEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f",
                    UserName = "David89",
                    NormalizedUserName = "DAVID89",
                    Email = "davidmartin@gmail.com",
                    NormalizedEmail = "DAVIDMARTIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "b0c0659c-a57a-4acb-a906-5e3bf9ab2675",
                    UserName = "Sara56",
                    NormalizedUserName = "SARA56",
                    Email = "saraperez@gmail.com",
                    NormalizedEmail = "SARAPEREZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8",
                    UserName = "JuanCarlos",
                    NormalizedUserName = "JUANCARLOS",
                    Email = "juancarlos@gmail.com",
                    NormalizedEmail = "JUANCARLOS@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "35a26eb2-c01c-4df3-b98d-40561190ae36",
                    UserName = "Carmen78",
                    NormalizedUserName = "CARMEN78",
                    Email = "carmenlopez@gmail.com",
                    NormalizedEmail = "CARMENLOPEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "cd88e529-eedb-42c5-a88d-384f5976a754",
                    UserName = "Pablo43",
                    NormalizedUserName = "PABLO43",
                    Email = "pablomartinez@gmail.com",
                    NormalizedEmail = "PABLOMARTINEZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "0835e1cc-d304-4b61-9b58-135ab2d27b3f",
                    UserName = "Gloria22",
                    NormalizedUserName = "GLORIA22",
                    Email = "gloriaramos@gmail.com",
                    NormalizedEmail = "GLORIARAMOS@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "944cbcf3-7479-4eed-97f1-80fd4c50eda6",
                    UserName = "Antonio65",
                    NormalizedUserName = "ANTONIO65",
                    Email = "antonioalvarez@gmail.com",
                    NormalizedEmail = "ANTONIOALVAREZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "cca9654e-d839-4e21-a23d-01fbb75e0a26",
                    UserName = "Patricia98",
                    NormalizedUserName = "PATRICIA98",
                    Email = "patriciaflores@gmail.com",
                    NormalizedEmail = "PATRICIAFLORES@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "f3952051-fbde-4d44-a9b7-c3cb54027090",
                    UserName = "Andres55",
                    NormalizedUserName = "ANDRES55",
                    Email = "andresromero@gmail.com",
                    NormalizedEmail = "ANDRESROMERO@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "7e246319-564e-4920-bd8c-6029be2a7729",
                    UserName = "Elena31",
                    NormalizedUserName = "ELENA31",
                    Email = "elenadiaz@gmail.com",
                    NormalizedEmail = "ELENADIAZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ba694638-8e1c-4398-a3db-50b879ea1414",
                    UserName = "Roberto44",
                    NormalizedUserName = "ROBERTO44",
                    Email = "robertohidalgo@gmail.com",
                    NormalizedEmail = "ROBERTOHIDALGO@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "2f5c9c2f-de8c-4396-90af-534f4e163439",
                    UserName = "Pedro78",
                    NormalizedUserName = "PEDRO78",
                    Email = "pedrogomez@hotmail.com",
                    NormalizedEmail = "PEDROGOMEZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "b2269673-9d47-471a-a958-24160608ae82",
                    UserName = "Isabel45",
                    NormalizedUserName = "ISABEL45",
                    Email = "isabelhernandez@hotmail.com",
                    NormalizedEmail = "ISABELHERNANDEZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "bb491436-8b44-4049-8f28-60b5689b6fd7",
                    UserName = "Rafael23",
                    NormalizedUserName = "RAFAEL23",
                    Email = "rafaelmartinez@hotmail.com",
                    NormalizedEmail = "RAFAELMARTINEZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "525d6c44-e75c-466a-9510-fb4c0d8f28d1",
                    UserName = "AnaMaria67",
                    NormalizedUserName = "ANAMARIA67",
                    Email = "anamaria@hotmail.com",
                    NormalizedEmail = "ANAMARIA@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "6d46504c-1a72-4036-98e3-3434676e05bb",
                    UserName = "JuanAntonio89",
                    NormalizedUserName = "JUANANTONIO89",
                    Email = "juanantonio@hotmail.com",
                    NormalizedEmail = "JUANANTONIO@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "6ca18a54-6c7b-46af-b298-fa756919a4f1",
                    UserName = "Sofia34",
                    NormalizedUserName = "SOFIA34",
                    Email = "sofiagonzalez@hotmail.com",
                    NormalizedEmail = "SOFIAGONZALEZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "347c951c-16c5-4043-bedc-a847c40fcb7f",
                    UserName = "Alejandro22",
                    NormalizedUserName = "ALEJANDRO22",
                    Email = "alejandro@hotmail.com",
                    NormalizedEmail = "ALEJANDRO@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "3e0f155c-6f59-4214-a4e4-2d992447488f",
                    UserName = "Lucia56",
                    NormalizedUserName = "LUCIA56",
                    Email = "luciaramos@hotmail.com",
                    NormalizedEmail = "LUCIARAMOS@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f",
                    UserName = "Diego12",
                    NormalizedUserName = "DIEGO12",
                    Email = "diegolopez@hotmail.com",
                    NormalizedEmail = "DIEGOLOPEZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "c2c1137a-2957-489a-b6bc-a520a28c3206",
                    UserName = "Paula31",
                    NormalizedUserName = "PAULA31",
                    Email = "paulaperez@hotmail.com",
                    NormalizedEmail = "PAULAPEREZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ccedb55a-6010-4ec9-913b-caa122d34ba7",
                    UserName = "Roberto67",
                    NormalizedUserName = "ROBERTO67",
                    Email = "robertomorales@hotmail.com",
                    NormalizedEmail = "ROBERTO MORALES@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "c9ea88e7-aba3-4aa3-8dd7-0977a84004c9",
                    UserName = "Teresa44",
                    NormalizedUserName = "TERESA44",
                    Email = "teresadiaz@hotmail.com",
                    NormalizedEmail = "TERESADIAZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b",
                    UserName = "JoseManuel78",
                    NormalizedUserName = "JOSEMANUEL78",
                    Email = "josemanuel@hotmail.com",
                    NormalizedEmail = "JOSEMANUEL@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "4a6b6c16-1593-4425-935c-d2ddc3c8eef5",
                    UserName = "Adriana65",
                    NormalizedUserName = "ADRIANA65",
                    Email = "adrianaperez@hotmail.com",
                    NormalizedEmail = "ADRIANAPEREZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "3c36090f-464c-4c80-ac2b-e32ca07c44a4",
                    UserName = "Francisco99",
                    NormalizedUserName = "FRANCISCO99",
                    Email = "francisco@hotmail.com",
                    NormalizedEmail = "FRANCISCO@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2",
                    UserName = "Monica43",
                    NormalizedUserName = "MONICA43",
                    Email = "monicagarcia@hotmail.com",
                    NormalizedEmail = "MONICAGARCIA@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "38c07b15-1adc-47fb-adca-5a93ab1ec6c3",
                    UserName = "Victor87",
                    NormalizedUserName = "VICTOR87",
                    Email = "victormorales@hotmail.com",
                    NormalizedEmail = "VICTORMORALES@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "1b29f96a-23e1-4824-9e66-775d807af9ae",
                    UserName = "Carmen56",
                    NormalizedUserName = "CARMEN56",
                    Email = "carmenflores@hotmail.com",
                    NormalizedEmail = "CARMENFLORES@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "c5f0f42f-255f-400d-b657-bed222ec9903",
                    UserName = "LuisMiguel",
                    NormalizedUserName = "LUISMIGUEL",
                    Email = "luismiguel@hotmail.com",
                    NormalizedEmail = "LUISMIGUEL@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "4ce9ea91-e281-47df-9fc7-79f0c9a95ddd",
                    UserName = "Beatriz12",
                    NormalizedUserName = "BEATRIZ12",
                    Email = "beatriz@hotmail.com",
                    NormalizedEmail = "BEATRIZ@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "60786725-191b-4172-acd8-ef669024173b",
                    UserName = "Jorge77",
                    NormalizedUserName = "JORGE77",
                    Email = "jorge@hotmail.com",
                    NormalizedEmail = "JORGE@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ba7faac0-0e0c-4fb8-a329-5483da03032c",
                    UserName = "Fernando78",
                    NormalizedUserName = "FERNANDO78",
                    Email = "fernandogomez@outlook.com",
                    NormalizedEmail = "FERNANDOGOMEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "939a97f5-10b8-4d6c-ab74-ce77187d36df",
                    UserName = "Alejandra45",
                    NormalizedUserName = "ALEJANDRA45",
                    Email = "alejandrahernandez@outlook.com",
                    NormalizedEmail = "ALEJANDRAHERNANDEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "c54c442f-e6a2-40b7-a022-3a58bccb2b3b",
                    UserName = "Gustavo23",
                    NormalizedUserName = "GUSTAVO23",
                    Email = "gustavomartinez@outlook.com",
                    NormalizedEmail = "GUSTAVOMARTINEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "83ae68c3-f621-4f03-bda7-73d77aec8ce3",
                    UserName = "Valeria67",
                    NormalizedUserName = "VALERIA67",
                    Email = "valeriagonzalez@outlook.com",
                    NormalizedEmail = "VALERIAGONZALEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "70e6cdc7-85df-452f-84ea-5e985024734c",
                    UserName = "Raul89",
                    NormalizedUserName = "RAUL89",
                    Email = "raulperez@outlook.com",
                    NormalizedEmail = "RAULPEREZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "a9805c2f-71d4-4c13-92fb-ac069cb7d633",
                    UserName = "Camila34",
                    NormalizedUserName = "CAMILA34",
                    Email = "camilasanchez@outlook.com",
                    NormalizedEmail = "CAMILASANCHEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ffd79ac4-d69f-4b74-b7c2-67e92905239a",
                    UserName = "Felipe22",
                    NormalizedUserName = "FELIPE22",
                    Email = "felipelopez@outlook.com",
                    NormalizedEmail = "FELIPELOPEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "81319e22-745a-45c6-9402-6d1389fd0f44",
                    UserName = "Natalia56",
                    NormalizedUserName = "NATALIA56",
                    Email = "nataliaramirez@outlook.com",
                    NormalizedEmail = "NATALIARAMIREZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2",
                    UserName = "Alberto12",
                    NormalizedUserName = "ALBERTO12",
                    Email = "albertogarcia@outlook.com",
                    NormalizedEmail = "ALBERTOGARCIA@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "d496f336-c5ab-4648-841c-38853c4aa4f7",
                    UserName = "Paola31",
                    NormalizedUserName = "PAOLA31",
                    Email = "paoladiaz@outlook.com",
                    NormalizedEmail = "PAOLADIAZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "19d1cc4c-18e4-42fc-9cbd-56253b20165e",
                    UserName = "Claudia67",
                    NormalizedUserName = "CLAUDIA67",
                    Email = "claudiaramirez@outlook.com",
                    NormalizedEmail = "CLAUDIARAMIREZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "c2199980-e00d-45dd-bdb6-8497cfeac41d",
                    UserName = "Ricardo44",
                    NormalizedUserName = "RICARDO44",
                    Email = "ricardomorales@outlook.com",
                    NormalizedEmail = "RICARDOMORALES@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "1199aa46-b03b-4cc4-921e-62b08fd5247f",
                    UserName = "Rosa78",
                    NormalizedUserName = "ROSA78",
                    Email = "rosagonzalez@outlook.com",
                    NormalizedEmail = "ROSAGONZALEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "17923d13-ffa5-4e87-9cab-3b313d44b3ea",
                    UserName = "Ignacio99",
                    NormalizedUserName = "IGNACIO99",
                    Email = "ignacio@outlook.com",
                    NormalizedEmail = "IGNACIO@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "31550335-200e-442a-9cca-f1d0f62c0819",
                    UserName = "Andrea43",
                    NormalizedUserName = "ANDREA43",
                    Email = "andrearamirez@outlook.com",
                    NormalizedEmail = "ANDREARAMIREZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "2301041e-8c28-4711-b70d-9daed300ae21",
                    UserName = "Victor88",
                    NormalizedUserName = "VICTOR88",
                    Email = "victorgarcia@outlook.com",
                    NormalizedEmail = "VICTORGARCIA@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "37991d47-ddc6-400b-a3fe-b17b998a76b2",
                    UserName = "Lorena56",
                    NormalizedUserName = "LORENA56",
                    Email = "lorenadiaz@outlook.com",
                    NormalizedEmail = "LORENADIAZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "97767fcd-f146-4e88-87dd-f1f1806dec49",
                    UserName = "Carlos77",
                    NormalizedUserName = "CARLOS77",
                    Email = "carloshernandez@outlook.com",
                    NormalizedEmail = "CARLOSHERNANDEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "2641ba50-9bdf-4107-80e8-a723e7feb06e",
                    UserName = "Miriam12",
                    NormalizedUserName = "MIRIAM12",
                    Email = "miriamlopez@outlook.com",
                    NormalizedEmail = "MIRIAMLOPEZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "0497ee14-d660-49a1-916d-8d2391ba6cf2",
                    UserName = "Marcos43",
                    NormalizedUserName = "MARCOS43",
                    Email = "marcosperez@outlook.com",
                    NormalizedEmail = "MARCOSPEREZ@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "2d624f65-a74a-4011-a187-862f58df7885",
                    UserName = "Patricia99",
                    NormalizedUserName = "PATRICIA99",
                    Email = "patriciaflores@outlook.com",
                    NormalizedEmail = "PATRICIAFLORES@OUTLOOK.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "52432a25-6a28-480e-ab5c-17fd71be2ffb",
                    UserName = "Juliana78",
                    NormalizedUserName = "JULIANA78",
                    Email = "julianagonzalez@yahoo.com",
                    NormalizedEmail = "JULIANAGONZALEZ@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "f102e342-a664-4b43-bcdb-b1c6945bf241",
                    UserName = "Roberto45",
                    NormalizedUserName = "ROBERTO45",
                    Email = "robertolopez@yahoo.com",
                    NormalizedEmail = "ROBERTOLOPEZ@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "31105ee2-5a05-4bcf-bff7-f07be401442e",
                    UserName = "Maria33",
                    NormalizedUserName = "MARIA33",
                    Email = "maria33@gmail.com",
                    NormalizedEmail = "MARIA33@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "80120fd9-ade7-4cd0-9dda-7b733e02d7cd",
                    UserName = "Carlos22",
                    NormalizedUserName = "CARLOS22",
                    Email = "carlos22@hotmail.com",
                    NormalizedEmail = "CARLOS22@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "0e5a9aab-eb68-4ca9-8b80-ea7bef076946",
                    UserName = "Laura11",
                    NormalizedUserName = "LAURA11",
                    Email = "laura11@yahoo.com",
                    NormalizedEmail = "LAURA11@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "0b450794-1b65-4d42-8df7-05b57b970454",
                    UserName = "Jose99",
                    NormalizedUserName = "JOSE99",
                    Email = "jose99@gmail.com",
                    NormalizedEmail = "JOSE99@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "87dbaf90-f343-423e-9f14-e124fd145730",
                    UserName = "Ana88",
                    NormalizedUserName = "ANA88",
                    Email = "ana88@hotmail.com",
                    NormalizedEmail = "ANA88@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "dd39eee3-6b17-4b39-95e0-075ad1b704bd",
                    UserName = "Pedro77",
                    NormalizedUserName = "PEDRO77",
                    Email = "pedro77@yahoo.com",
                    NormalizedEmail = "PEDRO77@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "3a76ac51-89f5-4b7f-a2fb-cca12abc04e9",
                    UserName = "Isabel66",
                    NormalizedUserName = "ISABEL66",
                    Email = "isabel66@gmail.com",
                    NormalizedEmail = "ISABEL66@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "ecf7b85e-8c3c-47ee-a80d-b0b360512c16",
                    UserName = "David55",
                    NormalizedUserName = "DAVID55",
                    Email = "david55@hotmail.com",
                    NormalizedEmail = "DAVID55@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "866d732a-ab7e-42b8-aa7d-3bfb6e1477da",
                    UserName = "Monica44",
                    NormalizedUserName = "MONICA44",
                    Email = "monica44@yahoo.com",
                    NormalizedEmail = "MONICA44@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "20b9c66b-7518-4cbc-aa39-f8bf41f0a423",
                    UserName = "Fernando33",
                    NormalizedUserName = "FERNANDO33",
                    Email = "fernando33@gmail.com",
                    NormalizedEmail = "FERNANDO33@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "1cdb46ef-e0a5-427c-8409-9a58cde54ce9",
                    UserName = "Luis22",
                    NormalizedUserName = "LUIS22",
                    Email = "luis22@hotmail.com",
                    NormalizedEmail = "LUIS22@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "3f059c7a-b764-49b9-bf1d-e5e2359e0cf6",
                    UserName = "Carmen11",
                    NormalizedUserName = "CARMEN11",
                    Email = "carmen11@yahoo.com",
                    NormalizedEmail = "CARMEN11@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7",
                    UserName = "Pablo99",
                    NormalizedUserName = "PABLO99",
                    Email = "pablo99@gmail.com",
                    NormalizedEmail = "PABLO99@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "b7d7964a-3f03-4930-a23d-59d90711f002",
                    UserName = "Elena88",
                    NormalizedUserName = "ELENA88",
                    Email = "elena88@hotmail.com",
                    NormalizedEmail = "ELENA88@HOTMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "153ff2f4-ccb7-43b1-b163-8f995adb1d13",
                    UserName = "Diego77",
                    NormalizedUserName = "DIEGO77",
                    Email = "diego77@yahoo.com",
                    NormalizedEmail = "DIEGO77@YAHOO.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                },
                new User
                {
                    Id = "7c5891f9-9fac-4dbf-9afd-2c9e01759e20",
                    UserName = "Alejandra66",
                    NormalizedUserName = "ALEJANDRA66",
                    Email = "alejandra66@gmail.com",
                    NormalizedEmail = "ALEJANDRA66@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminIvy97@123")
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                //ADMIN
            new IdentityUserRole<string> { UserId = "3c875016-9cfb-4529-824d-1517c5a93583", RoleId = "2048b194-4cda-4320-8b72-c169b4788fe9" },

            //COMPANY
            new IdentityUserRole<string> { UserId = "ecdb5eda-1cee-4e68-b100-160203158d57", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "d51252c3-6e21-4ffc-aab3-f4bda791a574", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "925b2ab6-5a03-40a7-891e-7bb594086e61", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "9d8b9e84-33a7-4c28-a6c0-5941a68f1968", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "09260ec0-0368-4da8-80d5-6e8b9c574920", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "a3fb7e92-6b31-4630-835c-3ea7d11e4306", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "02bdfba1-5d7d-46f8-89c7-5d02a5fc7655", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "be76d6cb-0532-4dd5-8e4e-f944faf0106b", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "ac270f24-3f1f-43a6-b291-1f0ce4489bfd", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "2a913313-dc4c-4f93-a1be-3fc5568e00b1", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "f42be566-1cc3-4863-9cf1-315828169000", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "0d4ad714-56a4-4bfc-b4b4-d776cfd51fd8", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "d4caf327-f110-4ab6-9305-c064a2071dc5", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "874fb32f-0ddd-4b5f-ac31-f2f11b66e098", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "57168621-b0dd-4fe4-a20e-489171d70a5d", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "379982fe-d22e-429f-bc14-26fffc569958", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "9f7c46a4-9ea5-4bc6-bd47-90ba52c54734", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "b735e23e-c928-41fc-b399-aa4a28807210", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "f4c4ffe2-e95d-4c05-a958-d32b26fecfc2", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "a4db8ecb-2f10-436e-8011-cf701620ea60", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },
            new IdentityUserRole<string> { UserId = "ddc7879b-e104-4047-bd15-d0fade9bbeee", RoleId = "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9" },

            //JOBUSER
            new IdentityUserRole<string> { UserId = "e60df533-79d7-42f2-a36d-99362dbc6f85", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "a0deb200-955f-4b6c-b550-9ca1712392a8", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "5b68ad8c-f42e-40d7-87de-3622d34dcf84", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "597719b7-3036-4f95-92f8-5163b3e18931", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "b9b2181b-d620-4db0-9561-9c1ba02480bb", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "53a20833-f2ef-4cb7-a049-326d0cb255ad", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "3c36090f-464c-4c80-ac2b-e32ca07c44a4", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "b0c0659c-a57a-4acb-a906-5e3bf9ab2675", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "35a26eb2-c01c-4df3-b98d-40561190ae36", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "cd88e529-eedb-42c5-a88d-384f5976a754", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "0835e1cc-d304-4b61-9b58-135ab2d27b3f", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "944cbcf3-7479-4eed-97f1-80fd4c50eda6", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "cca9654e-d839-4e21-a23d-01fbb75e0a26", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "f3952051-fbde-4d44-a9b7-c3cb54027090", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "7e246319-564e-4920-bd8c-6029be2a7729", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "ba694638-8e1c-4398-a3db-50b879ea1414", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },


            new IdentityUserRole<string> { UserId = "2f5c9c2f-de8c-4396-90af-534f4e163439", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "b2269673-9d47-471a-a958-24160608ae82", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "bb491436-8b44-4049-8f28-60b5689b6fd7", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "525d6c44-e75c-466a-9510-fb4c0d8f28d1", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "6d46504c-1a72-4036-98e3-3434676e05bb", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "6ca18a54-6c7b-46af-b298-fa756919a4f1", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "347c951c-16c5-4043-bedc-a847c40fcb7f", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "3e0f155c-6f59-4214-a4e4-2d992447488f", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "c2c1137a-2957-489a-b6bc-a520a28c3206", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "ccedb55a-6010-4ec9-913b-caa122d34ba7", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "c9ea88e7-aba3-4aa3-8dd7-0977a84004c9", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "4a6b6c16-1593-4425-935c-d2ddc3c8eef5", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "3c36090f-464c-4c80-ac2b-e32ca07c44a9", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "38c07b15-1adc-47fb-adca-5a93ab1ec6c3", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "1b29f96a-23e1-4824-9e66-775d807af9ae", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "c5f0f42f-255f-400d-b657-bed222ec9903", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "4ce9ea91-e281-47df-9fc7-79f0c9a95ddd", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "60786725-191b-4172-acd8-ef669024173b", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },


            new IdentityUserRole<string> { UserId = "ba7faac0-0e0c-4fb8-a329-5483da03032c", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "939a97f5-10b8-4d6c-ab74-ce77187d36df", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "c54c442f-e6a2-40b7-a022-3a58bccb2b3b", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "83ae68c3-f621-4f03-bda7-73d77aec8ce3", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "70e6cdc7-85df-452f-84ea-5e985024734c", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "a9805c2f-71d4-4c13-92fb-ac069cb7d633", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "ffd79ac4-d69f-4b74-b7c2-67e92905239a", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "81319e22-745a-45c6-9402-6d1389fd0f44", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "d496f336-c5ab-4648-841c-38853c4aa4f7", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "19d1cc4c-18e4-42fc-9cbd-56253b20165e", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "c2199980-e00d-45dd-bdb6-8497cfeac41d", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "1199aa46-b03b-4cc4-921e-62b08fd5247f", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "17923d13-ffa5-4e87-9cab-3b313d44b3ea", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "31550335-200e-442a-9cca-f1d0f62c0819", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "2301041e-8c28-4711-b70d-9daed300ae21", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "37991d47-ddc6-400b-a3fe-b17b998a76b2", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "97767fcd-f146-4e88-87dd-f1f1806dec49", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "2641ba50-9bdf-4107-80e8-a723e7feb06e", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "0497ee14-d660-49a1-916d-8d2391ba6cf2", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "2d624f65-a74a-4011-a187-862f58df7885", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },


            new IdentityUserRole<string> { UserId = "52432a25-6a28-480e-ab5c-17fd71be2ffb", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "f102e342-a664-4b43-bcdb-b1c6945bf241", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "31105ee2-5a05-4bcf-bff7-f07be401442e", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "80120fd9-ade7-4cd0-9dda-7b733e02d7cd", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "0e5a9aab-eb68-4ca9-8b80-ea7bef076946", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "0b450794-1b65-4d42-8df7-05b57b970454", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "87dbaf90-f343-423e-9f14-e124fd145730", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "dd39eee3-6b17-4b39-95e0-075ad1b704bd", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "3a76ac51-89f5-4b7f-a2fb-cca12abc04e9", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "ecf7b85e-8c3c-47ee-a80d-b0b360512c16", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "866d732a-ab7e-42b8-aa7d-3bfb6e1477da", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "20b9c66b-7518-4cbc-aa39-f8bf41f0a423", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "1cdb46ef-e0a5-427c-8409-9a58cde54ce9", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "3f059c7a-b764-49b9-bf1d-e5e2359e0cf6", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "b7d7964a-3f03-4930-a23d-59d90711f002", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "153ff2f4-ccb7-43b1-b163-8f995adb1d13", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" },
            new IdentityUserRole<string> { UserId = "7c5891f9-9fac-4dbf-9afd-2c9e01759e20", RoleId = "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb" }
            );
        }
    }
}
