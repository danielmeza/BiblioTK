namespace BiblioTK.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreaciondeTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 70),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true, name: "ixu_pais_nombre");
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 36),
                        Nombres = c.String(nullable: false, maxLength: 100),
                        Apellidos = c.String(nullable: false, maxLength: 100),
                        Nivel = c.Byte(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        Website = c.String(nullable: false, maxLength: 100),
                        PaisNacimientoID = c.Int(nullable: false),
                        PaisResidenciaID = c.Int(nullable: false),
                        Email = c.String(maxLength: 100),
                        EmailConfirmado = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        TokenSeguridad = c.String(),
                        Telefono = c.String(maxLength: 50),
                        TelefonoConfirmado = c.Boolean(nullable: false),
                        DobleAutenticacion = c.Boolean(nullable: false),
                        UltimoBloqueo = c.DateTime(),
                        Bloqueado = c.Boolean(nullable: false),
                        TotalIntentosFallidos = c.Int(nullable: false),
                        Usuario = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paises", t => t.PaisNacimientoID)
                .ForeignKey("dbo.Paises", t => t.PaisResidenciaID)
                .Index(t => t.PaisNacimientoID)
                .Index(t => t.PaisResidenciaID)
                .Index(t => t.Usuario, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.UsuariosNotificaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioId = c.String(nullable: false, maxLength: 36),
                        Tipo = c.String(),
                        Valor = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.UsuariosLogines",
                c => new
                    {
                        Proveedor = c.String(nullable: false, maxLength: 128),
                        ProveedorToken = c.String(nullable: false, maxLength: 128),
                        UsuarioId = c.String(nullable: false, maxLength: 36),
                    })
                .PrimaryKey(t => new { t.Proveedor, t.ProveedorToken, t.UsuarioId })
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.UsuariosRoles",
                c => new
                    {
                        UsuarioId = c.String(nullable: false, maxLength: 36),
                        RolId = c.String(nullable: false, maxLength: 36),
                    })
                .PrimaryKey(t => new { t.UsuarioId, t.RolId })
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RolId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 36),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(maxLength: 200),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Nombre, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuariosRoles", "RolId", "dbo.Roles");
            DropForeignKey("dbo.UsuariosRoles", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.UsuariosLogines", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "PaisResidenciaID", "dbo.Paises");
            DropForeignKey("dbo.Usuarios", "PaisNacimientoID", "dbo.Paises");
            DropForeignKey("dbo.UsuariosNotificaciones", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Roles", "RoleNameIndex");
            DropIndex("dbo.UsuariosRoles", new[] { "RolId" });
            DropIndex("dbo.UsuariosRoles", new[] { "UsuarioId" });
            DropIndex("dbo.UsuariosLogines", new[] { "UsuarioId" });
            DropIndex("dbo.UsuariosNotificaciones", new[] { "UsuarioId" });
            DropIndex("dbo.Usuarios", "UserNameIndex");
            DropIndex("dbo.Usuarios", new[] { "PaisResidenciaID" });
            DropIndex("dbo.Usuarios", new[] { "PaisNacimientoID" });
            DropIndex("dbo.Paises", "ixu_pais_nombre");
            DropTable("dbo.Roles");
            DropTable("dbo.UsuariosRoles");
            DropTable("dbo.UsuariosLogines");
            DropTable("dbo.UsuariosNotificaciones");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Paises");
        }
    }
}
