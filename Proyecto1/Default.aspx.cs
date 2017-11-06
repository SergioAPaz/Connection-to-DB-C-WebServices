using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace Proyecto1
{
    public partial class Default : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = QuerysProject.GetAllMovies();
            GVPeliculas.DataSource = ds;
            GVPeliculas.DataBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ds = QuerysProject.GetNameOfMovieXCode(txtCode.Text);
            txtMovieName.Text = ds.Tables[0].Rows[0]["Pelicula"].ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            QuerysProject.InsertNewMovie(txtCodigo.Text, txtNombre.Text);
            Response.Write("<script>alert('Agregada con exito!');</script>");
        }
    }
}