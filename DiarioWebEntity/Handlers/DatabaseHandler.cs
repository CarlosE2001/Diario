using System;
using System.Collections.Generic;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DiarioWebEntity.Models;
using System.Linq;

namespace DiarioWebEntity.Handlers {
    public class DatabaseHandler {

        public SqlConnection connection;
        public string connectionRoute;
        public const string CONNECTION_NAME = "blogDB";

        public DatabaseHandler() {
            connectionRoute = ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ToString();
            connection = new SqlConnection(connectionRoute);
        }

        public DataTable CreateTableFromQuery(string query) {
            SqlCommand queryCommand = new SqlCommand(query, connection);
            SqlDataAdapter tableAdapter = new SqlDataAdapter(queryCommand);
            DataTable queryTable = new DataTable();
            connection.Open();
            tableAdapter.Fill(queryTable);
            connection.Close();
            return queryTable;
        }

        public bool DatabaseQuery(string query) {
            bool success = false;
            SqlCommand queryCommand = new SqlCommand(query, connection);
            connection.Open();
            success = queryCommand.ExecuteNonQuery() >= 1;
            connection.Close();
            return success;
        }

        public bool DatabaseQuery(SqlCommand queryCommand) {
            bool success = false;
            connection.Open();
            success = queryCommand.ExecuteNonQuery() >= 1;
            connection.Close();
            return success;
        }

        public List<Publicacion> GetAllPublications() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            string query = "SELECT * FROM Publicacion";
            DataTable resultingTable = CreateTableFromQuery(query);
            foreach(DataRow row in resultingTable.Rows) {
                publicaciones.Add(CreatePublicacionModelFromRow(row));
            }
            return publicaciones;
        }

        

        public Publicacion CreatePublicacionModelFromRow(DataRow row) {
            return new Publicacion {
                Titulo = Convert.ToString(row["Titulo"]),
                Id = Convert.ToInt32(row["Id"]),
                Fecha = Convert.ToString(row["Fecha"]),
                LinkImg = Convert.ToString(row["LinkImg"]),
                Resumen = Convert.ToString(row["Resumen"]),
                AutorFK = Convert.ToInt32(row["AutorFK"]),
                CategoriaFK = Convert.ToInt32(row["CategoriaFK"])
            };
        }

        public Publicacion GetPublicacionById(int id) {
            Publicacion publicacion;
            string query = "SELECT * FROM Publicacion WHERE Publicacion.Id = " + id;
            DataTable resultingTable = CreateTableFromQuery(query);
            publicacion = CreatePublicacionModelFromRow(resultingTable.Rows[0]);
            return publicacion;
        }


        public List<Autor> GetAllAutors() {
            List<Autor> autores = new List<Autor>();
            string query = "SELECT * FROM Autor";
            DataTable resultingTable = CreateTableFromQuery(query);
            foreach (DataRow row in resultingTable.Rows) {
                autores.Add(CreateAutorModelFromRow(row));
            }
            return autores;
        }

        public Autor CreateAutorModelFromRow(DataRow row) {
            return new Autor {
                Id = Convert.ToInt32(row["Id"]),
                NombreCompleto = Convert.ToString(row["NombreCompleto"])
            };
        }

        public Autor GetAutorById(int id) {
            Autor autor;
            string query = "SELECT * FROM Autor WHERE Autor.Id = " + id;
            DataTable resultingTable = CreateTableFromQuery(query);
            autor = CreateAutorModelFromRow(resultingTable.Rows[0]);
            return autor;
        }


        public List<Categoria> GetAllCategorias() {
            List<Categoria> categorias = new List<Categoria>();
            string query = "SELECT * FROM Categoria";
            DataTable resultingTable = CreateTableFromQuery(query);
            foreach (DataRow row in resultingTable.Rows) {
                categorias.Add(CreateCategoriaModelFromRow(row));
            }
            return categorias;
        }

        public Categoria CreateCategoriaModelFromRow(DataRow row) {
            return new Categoria {
                Id = Convert.ToInt32(row["Id"]),
                NombreCategoria = Convert.ToString(row["NombreCategoria"])
            };
        }

        public List<Comentario> GetAllComentarios() {
            List<Comentario> comentarios = new List<Comentario>();
            string query = "SELECT * FROM Comentario";
            DataTable resultingTable = CreateTableFromQuery(query);
            foreach (DataRow row in resultingTable.Rows) {
                comentarios.Add(CreateComentarioModelFromRow(row));
            }
            return comentarios;
        }

        public Comentario CreateComentarioModelFromRow(DataRow row) {
            return new Comentario {
                Id = Convert.ToInt32(row["Id"]),
                IdPublicacionPKFK = Convert.ToInt32(row["IdPublicacionPKFK"]),
                Texto = Convert.ToString(row["Texto"])
            };
        }



        /**
         * 
         * 
         * TRATAMIENTO DE DATOS
         * 
         * 
        */
        public Dictionary<int, List<string>> GetCommentsDictionary() {
            List<Comentario> comentarios = GetAllComentarios();
            Dictionary<int, List<string>> comentariosDic = new Dictionary<int, List<string>>();
            foreach (Comentario com in comentarios) {
                if (!comentariosDic.ContainsKey(com.IdPublicacionPKFK)) {
                    List<string> lista = new List<string>();
                    lista.Add(com.Texto);
                    comentariosDic[com.IdPublicacionPKFK] = lista;
                } else {
                    comentariosDic[com.IdPublicacionPKFK].Add(com.Texto);
                }
            }
            return comentariosDic;
        }

        public Dictionary<int, int> GetCommentsCountDictionary() {
            List<Comentario> comentarios = GetAllComentarios();
            Dictionary<int, List<string>> comentariosDic = new Dictionary<int, List<string>>();
            foreach (Comentario com in comentarios) {
                if (!comentariosDic.ContainsKey(com.IdPublicacionPKFK)) {
                    List<string> lista = new List<string>();
                    lista.Add(com.Texto);
                    comentariosDic[com.IdPublicacionPKFK] = lista;
                } else {
                    comentariosDic[com.IdPublicacionPKFK].Add(com.Texto);
                }
            }
            Dictionary<int, int> commentCount = new Dictionary<int, int>();
            for (int index = 0; index < comentariosDic.Count; index++) {
                var item = comentariosDic.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;
                commentCount[itemKey] = itemValue.Count();
            }
            return commentCount;
        }

        public Dictionary<int, string> GetCategoriesDictionary() {
            List<Categoria> categories = GetAllCategorias();
            Dictionary<int, string> categoriasDic = new Dictionary<int, string>();
            foreach (Categoria cat in categories) {
                categoriasDic[cat.Id] = cat.NombreCategoria;
            }
            return categoriasDic;
        }

        public Dictionary<int, string> GetAutorsDictionary() {
            List<Autor> autores = GetAllAutors();
            Dictionary<int, string> autoresDic = new Dictionary<int, string>();
            foreach (Autor aut in autores) {
                autoresDic[aut.Id] = aut.NombreCompleto;
            }
            return autoresDic;
        }

        /**
         * 
         * 
         * FIN TRATAMIENTO DE DATOS
         * 
         * 
        */

    }


}
