using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;


namespace Proyecto1
{
    public class QuerysProject
    {
        const string Server = @"DESKTOP-KQ2IP3F\MSSQLSERVER03";
        const string DB = "Paz";
        public static DataSet GetAllMovies()
        {
            WSDB.WebServiceSoapClient WS = new WSDB.WebServiceSoapClient();
            DataSet ds = WS.GetData("SELECT [id],[Codigo],[Pelicula] FROM [Paz].[dbo].[Peliculas]", Server, DB);
            return ds;
        }

        public static DataSet GetNameOfMovieXCode(string Id)
        {
            
            WSDB.WebServiceSoapClient WS = new WSDB.WebServiceSoapClient();
            DataSet ds = WS.GetData("SELECT [id],[Codigo],[Pelicula] FROM [Paz].[dbo].[Peliculas] where codigo='" + Id + "'", Server, DB);
            return ds;
        }

        public static void InsertNewMovie(string Codigo, string NPelicula)
        {
            WSDB.WebServiceSoapClient WS = new WSDB.WebServiceSoapClient();
            DataSet ds = WS.GetData("INSERT INTO [Paz].[dbo].[Peliculas] (Codigo,Pelicula) values ('" + Codigo + "','" + NPelicula + "');", Server, DB);
        }
    }
}