using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Paginas
{
    public partial class SalidaPDFBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOG"] == null)
            {
                Response.Redirect("inicio.aspx");
            }

            DataTable fila;
            if (!String.IsNullOrEmpty((string)Request.QueryString["id"]))
            {
                string ElId = Request.QueryString["id"].ToString();
                fila = Biblioteca.fx.reporteBoxPdf(ElId);
                System.Text.StringBuilder Template = new System.Text.StringBuilder();
                Template.Append(ObtenerPlantilla("ReporteBox.html"));

                if (fila.Rows.Count > 0)
                {
                    DataRow oRow = fila.Rows[0];

                    Template.Replace("#IDBOX#", oRow["NumeroBox"].ToString());
                    Template.Replace("#TIPO#", oRow["TipoDeBox"].ToString());
                    Template.Replace("#ESTADOBOX#", oRow["estadobox"].ToString());
                    Template.Replace("#DESC#", oRow["descripcion"].ToString());
                    Template.Replace("#FECHAI#", oRow["fechainicio"].ToString());
                    Template.Replace("#HORAI#", oRow["horaInicio"].ToString());
                    Template.Replace("#FECHAF#", oRow["fechafin"].ToString());
                    Template.Replace("#HORAF#", oRow["horafin"].ToString());
                    Template.Replace("#ESTADOSE#", oRow["estadoSesion"].ToString());
                    Template.Replace("#FECHAEX#", oRow["fechaExtension"].ToString());
                    Template.Replace("#HORAEX#", oRow["horaExtension"].ToString());
                    



                    /*GENERANDO PDF------------------------------------------------------------------------------*/
                    //string file = @"C:\tmp2\" + lblFolio.Text + rdoTipo.SelectedValue + ".pdf";
                    string fontpath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "\\fonts\\cour.ttf";

                    using (MemoryStream _MemoryStream = new MemoryStream())
                    {
                        BaseFont bf = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        FontFactory.RegisterDirectory(System.Web.HttpContext.Current.Request.PhysicalApplicationPath, true);
                        FontFactory.Register(fontpath, "Courier New");
                        //FontFactory.RegisterFamily("Courier New", "Courier New", fontpath);

                        string html = Template.ToString();
                        Document document = new Document(PageSize.LETTER, 1, 1, 1, 1);
                        //PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
                        PdfWriter writer = PdfWriter.GetInstance(document, _MemoryStream);

                        document.Open();
                        foreach (IElement E in HTMLWorker.ParseToList(new StringReader(html), new StyleSheet()))
                        {
                            document.Add(E);
                        }
                        document.Close();

                        //guardar certificado---------------------------------------------->                
                        int bytesLenght = Convert.ToInt32(_MemoryStream.ToArray().Length);
                        byte[] bytes = _MemoryStream.ToArray(); //new byte[bytesLenght];
                        //_MemoryStream.Read(bytes, 0, bytesLenght);


                        //----------------------------------------------------------------->

                        Response.ClearContent();
                        Response.ClearHeaders();
                        Response.AppendHeader("content-disposition", "attachment; filename=Reporte_Box" + ElId + ".pdf");
                        HttpContext.Current.Response.BinaryWrite(_MemoryStream.ToArray());
                        Response.End();

                        /*-----------------------------------------------------------------------------------------------*/
                    }
                }
            }
        }

        public static string ObtenerPlantilla(string plantilla)
        {
            StreamReader objReader = new StreamReader(HttpContext.Current.Server.MapPath("./plantillas/" + plantilla));
            string sLine = "";
            string lectura = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    lectura += sLine.ToString();
            }
            objReader.Close();
            return lectura;
        }
    }
}