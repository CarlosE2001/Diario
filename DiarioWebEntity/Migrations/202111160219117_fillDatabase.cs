namespace DiarioWebEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fillDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Autor ON ");

            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (1,'Sebastián Montero')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (2,'Carlos Espinoza')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (3,'Braulio Solano')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (4,'Rigoberto González')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (5,'Armando Esteban Quito')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (6,'Esteban Montero')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (7,'Mariana Chaverri')");
            Sql("INSERT INTO dbo.Autor(Id,NombreCompleto) VALUES (8,'Cristiano Ronaldo')");

            Sql("SET IDENTITY_INSERT Autor OFF ");
            Sql("SET IDENTITY_INSERT Categoria ON ");

            Sql("INSERT INTO dbo.Categoria(Id,NombreCategoria) VALUES (1,'Inteligencia Artifical')");
            Sql("INSERT INTO dbo.Categoria(Id,NombreCategoria) VALUES (2,'Tecnologías de la Información')");
            Sql("INSERT INTO dbo.Categoria(Id,NombreCategoria) VALUES (3,'Ciencias de la Computación')");
            Sql("INSERT INTO dbo.Categoria(Id,NombreCategoria) VALUES (4,'Análisis de Datos')");

            Sql("SET IDENTITY_INSERT Categoria OFF ");
            Sql("SET IDENTITY_INSERT Publicacion ON ");

            Sql("INSERT INTO dbo.Publicacion(Id,Fecha,Titulo,LinkImg,Resumen,AutorFK,CategoriaFK) VALUES (1,'19-05-2020','Machine Learning: El futuro de la humanidad','https://revistabyte.es/wp-content/uploads/2020/06/el-machine-learning-en-50-terminos-por-paradigma-digital.jpg','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',1,1)");
            Sql("INSERT INTO dbo.Publicacion(Id,Fecha,Titulo,LinkImg,Resumen,AutorFK,CategoriaFK) VALUES (2,'19-07-2020','Unit Testing y su importancia','https://www.functionize.com/wp-content/uploads/2018/07/unit-testing.png','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',2,1)");
            Sql("INSERT INTO dbo.Publicacion(Id,Fecha,Titulo,LinkImg,Resumen,AutorFK,CategoriaFK) VALUES (3,'28-05-2018','Cómo y cuándo protegerse de un cyber ataque','https://revistabyte.es/wp-content/uploads/2020/06/el-machine-learning-en-50-terminos-por-paradigma-digital.jpg','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',2,3)");
            Sql("INSERT INTO dbo.Publicacion(Id,Fecha,Titulo,LinkImg,Resumen,AutorFK,CategoriaFK) VALUES (4,'29-02-2016','NFTs: qué son y por qué no debería caer en la trampa','https://revistabyte.es/wp-content/uploads/2020/06/el-machine-learning-en-50-terminos-por-paradigma-digital.jpg','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',3,4)");
            Sql("INSERT INTO dbo.Publicacion(Id,Fecha,Titulo,LinkImg,Resumen,AutorFK,CategoriaFK) VALUES (5,'10-12-2020','Turing: cómo perdimos una gran mente a causa de odio','https://revistabyte.es/wp-content/uploads/2020/06/el-machine-learning-en-50-terminos-por-paradigma-digital.jpg','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',3,2)");

            Sql("SET IDENTITY_INSERT Publicacion OFF ");
            Sql("SET IDENTITY_INSERT Comentario ON ");

            Sql("INSERT INTO dbo.Comentario(Id,IdPublicacionPKFK,Texto) VALUES (1,1,'¿para qué se podría usar el machine learning? no soy muy expero en esto entonces no comprendo su funcionalidad!')");
            Sql("INSERT INTO dbo.Comentario(Id,IdPublicacionPKFK,Texto) VALUES (2,1,'El pensar que es posible que una maquina tenga razonamiento propio es distopico. Debemos detener esto!')");
            Sql("INSERT INTO dbo.Comentario(Id,IdPublicacionPKFK,Texto) VALUES (3,2,'en mis tiempos de universidad perdí un curso porque se me olvidó hacer testing jaja excelente publicacion!')");
            Sql("INSERT INTO dbo.Comentario(Id,IdPublicacionPKFK,Texto) VALUES (4,4,'Pero Choché me dijo que los NFTS eran el futuro?????? puse una hipoteca en mi casa para invertir todo mi dinero en eso D:')");
            Sql("INSERT INTO dbo.Comentario(Id,IdPublicacionPKFK,Texto) VALUES (5,5,'increíble pensar que casi 80 años después existen personas con el mismo odio en su corazón... excelente publicación')");
            
            Sql("SET IDENTITY_INSERT Comentario OFF ");
        }
        
        public override void Down()
        {
        }
    }
}
