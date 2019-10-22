using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace clase_29_09_2015
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //test1();
            test2(13);
        }

        private void test1()
        {


            string frase = "programando linq con C# en visual studio 2010 en inacap";
            string[] palabras = frase.Split(' ');


           // Response.Write(palabras[0]+" " + palabras[1] + " " + palabras[2] + "  " +palabras[3] + " " + palabras[4] + " "+ palabras[5] + " " + palabras[6]);

            foreach (string element in palabras)
            {
                Response.Write(element + "  "); //"</br>"
            }
           
            //Linq usando sintaxis de consulta basado en expresion

            Response.Write("</br>" +"---------------------------------" + "</br>");
            var consulta = from pala in palabras
                           group pala.ToUpper() by pala.Length into grupo
                           orderby grupo.Key descending
                            select new {Lenght = grupo.Key, Words = grupo};

            foreach ( var obj in consulta)
            {
            Response.Write(string.Format("Palabra de largo (0):</br>", obj.Lenght));
                foreach (string word in obj.Words)
                {
                    Response.Write(word + "</br>"); 
                }
            }

            Response.Write("</br>" + "---------------------------------" + "</br>");
            //Linq usando sintaxis de consulta basado en metodos
            var consulta2 = palabras.
                            GroupBy (pala => pala.Length, pala => pala.ToUpper()).
                            Select (grupo => new {Lenght = grupo.Key, Words = grupo }).
                            OrderByDescending (o => o.Lenght);

            foreach (var obj in consulta2) {
                Response.Write(string.Format("Palabra de largo (0):</br>", obj.Lenght));
                foreach (string word in obj.Words)
                { Response.Write(word + "</br>"); }
            }
                            
        }

        private void test2(int marca)
        {
            XElement articulos = XElement.Load(Server.MapPath("articulos.xml"));
        
            var datos = (from art in articulos.Elements()
                         where Int32.Parse(art.Element("articulo_marca").Value) == marca
                         select art);

            foreach (var obj in datos) 
            { 
            Response.Write(obj.Element("articulo_codart").Value + " - ");
            Response.Write(obj.Element("articulo_nombre").Value + " - ");
            Response.Write(obj.Element("articulo_marca").Value + "</br>");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}