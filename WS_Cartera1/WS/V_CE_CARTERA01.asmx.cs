using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Odbc;
using System.Data.OleDb;

namespace WS_Cartera1.WS
{
    /// <summary>
    /// Summary description for V_CE_CARTERA01
    /// </summary>
    [WebService(Namespace = "http://www.wsfinanciero.aviacioncivil.gob.ec/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class V_CE_CARTERA01 : System.Web.Services.WebService
    {
        private List<V_CE_CarteraClass> ListaCartera;
        [WebMethod]
        public List<V_CE_CarteraClass> RetornarCartera ()
        {
            V_CE_CarteraClass V_CE_carteraclass;
            ListaCartera = new List<V_CE_CarteraClass>();
            OleDbDataReader oledardr;

            String query = "select * from V_CE_CARTERA01 ";
            OleDbConnection db2connection = new OleDbConnection();
            db2connection.ConnectionString="Provider=IBMDADB2;Database=Dac_db;Hostname=172.20.10.13;Protocol=TCPIP;Port=50000;Uid=dacadm;Pwd=dacadm;";
            try
            {
                OleDbCommand oledbcommand= new OleDbCommand(query,db2connection);
                db2connection.Open();
                oledardr = oledbcommand.ExecuteReader();
                
                while (oledardr.Read())
                {
                    V_CE_carteraclass = new V_CE_CarteraClass();

                    if (oledardr.IsDBNull(0))
                    {
                        V_CE_carteraclass.id = 0;
                    }
                    else
                    {
                        V_CE_carteraclass.id = oledardr.GetInt64(0);
                    }
                    if (oledardr.IsDBNull(1))
                    {
                        V_CE_carteraclass.tipo = "";
                    }
                    else
                    {
                        V_CE_carteraclass.tipo = oledardr.GetString(1);
                    }
                    if (oledardr.IsDBNull(2))
                    {
                        V_CE_carteraclass.tipodocumento = "";
                    }
                    else
                    {
                        V_CE_carteraclass.tipodocumento = oledardr.GetString(2);
                    }
                    if (oledardr.IsDBNull(3))
                    {
                        V_CE_carteraclass.numerofactura = "";
                    }
                    else
                    {
                        V_CE_carteraclass.numerofactura = oledardr.GetString(3);
                    }
                    if (oledardr.IsDBNull(4))
                    {
                        V_CE_carteraclass.nombrecliente = "";
                    }
                    else
                    {
                        V_CE_carteraclass.nombrecliente = oledardr.GetString(4);
                    }
                    if (oledardr.IsDBNull(5))
                    {
                        V_CE_carteraclass.cedula= "";
                    }
                    else
                    {
                        V_CE_carteraclass.cedula = oledardr.GetString(5);
                    }
                    if (oledardr.IsDBNull(6))
                    {
                        V_CE_carteraclass.oiddocumentocc = "";
                    }
                    else
                    {
                        V_CE_carteraclass.oiddocumentocc = oledardr.GetInt64(6).ToString();
                    }
                    if (oledardr.IsDBNull(7))
                    {
                        V_CE_carteraclass.estado = "";
                    }
                    else
                    {
                        V_CE_carteraclass.estado = oledardr.GetString(7);

                    }
                    if (oledardr.IsDBNull(8))
                    {
                        V_CE_carteraclass.autorizacion = "";
                    }
                    else
                    {
                        V_CE_carteraclass.autorizacion = oledardr.GetString(8);
                    }
                    if (oledardr.IsDBNull(9))
                    {
                        V_CE_carteraclass.mes = "";
                    }
                    else
                    {
                        V_CE_carteraclass.mes = oledardr.GetInt32(9).ToString();
                    }
                    if (oledardr.IsDBNull(10))
                    {
                        V_CE_carteraclass.fecha = DateTime.UtcNow; ;
                    }
                    else
                    {
                        V_CE_carteraclass.fecha = oledardr.GetDateTime(10);
                    }
                    if (oledardr.IsDBNull(11))
                    {
                        V_CE_carteraclass.fechacrea = DateTime.UtcNow;
                    }
                    else
                    {
                        V_CE_carteraclass.fechacrea = oledardr.GetDateTime(11);
                    }
                    if (oledardr.IsDBNull(12))
                    {
                        V_CE_carteraclass.valorfactura ="";
                    }
                    else
                    {
                        V_CE_carteraclass.valorfactura = oledardr.GetDecimal(12).ToString();
                    }
                    if (oledardr.IsDBNull(13))
                    {
                        V_CE_carteraclass.saldo = "";
                    }
                    else
                    {
                        V_CE_carteraclass.saldo = oledardr.GetDecimal(13).ToString();
                    }
                    if (oledardr.IsDBNull(14))
                    {
                        V_CE_carteraclass.usuariocrea = "";
                    }
                    else
                    {
                        V_CE_carteraclass.usuariocrea = oledardr.GetString(14);
                    }
                    if (oledardr.IsDBNull(15))
                    {
                        V_CE_carteraclass.nombre = "";
                    }
                    else
                    {
                        V_CE_carteraclass.nombre = oledardr.GetString(15);
                    }
                    if (oledardr.IsDBNull(16))
                    {
                        V_CE_carteraclass.apellidoasubicacion = "";
                    }
                    else
                    {
                        V_CE_carteraclass.apellidoasubicacion = oledardr.GetString(16);
                    }
                    if (oledardr.IsDBNull(17))
                    {
                        V_CE_carteraclass.lugar = "";
                    }
                    else
                    {
                        V_CE_carteraclass.lugar = oledardr.GetString(17);
                    }
                    if (oledardr.IsDBNull(18))
                    {
                        V_CE_carteraclass.fecharecepcion = DateTime.UtcNow;
                    }
                    else
                    {
                        V_CE_carteraclass.fecharecepcion = oledardr.GetDateTime(18);
                    }
                    if (oledardr.IsDBNull(19))
                    {
                        V_CE_carteraclass.fecharecaudacion = DateTime.UtcNow;
                    }
                    else
                    {
                        V_CE_carteraclass.fecharecaudacion = oledardr.GetDateTime(19);
                    }
                    if (oledardr.IsDBNull(20))
                    {
                        V_CE_carteraclass.fechaanulacion = DateTime.UtcNow;
                    }
                    else
                    {
                        V_CE_carteraclass.fechaanulacion = oledardr.GetDateTime(20);
                    }
                    if (oledardr.IsDBNull(21))
                    {
                        V_CE_carteraclass.tiporec = "";
                    }
                    else
                    {
                        V_CE_carteraclass.tiporec = oledardr.GetString(21);
                    }
                    if (oledardr.IsDBNull(22))
                    {
                        V_CE_carteraclass.codigo = "";
                    }
                    else
                    {
                        V_CE_carteraclass.codigo = oledardr.GetString(22);
                    }
                    if (oledardr.IsDBNull(23))
                    {
                        V_CE_carteraclass.concepto = "";
                    }
                    else
                    {
                        V_CE_carteraclass.concepto = oledardr.GetString(23); ;
                    }
                    if (oledardr.IsDBNull(24))
                    {
                        V_CE_carteraclass.capitalpagado = "";
                    }
                    else
                    {
                        V_CE_carteraclass.capitalpagado = oledardr.GetDecimal(24).ToString() ;
                    }
                    if (oledardr.IsDBNull(25))
                    {
                        V_CE_carteraclass.valorrecaudado = "";
                    }
                    else
                    {
                        V_CE_carteraclass.valorrecaudado = oledardr.GetDecimal(25).ToString();
                    }
                    if (oledardr.IsDBNull(26))
                    {
                        V_CE_carteraclass.valorefectivo = "";
                    }
                    else
                    {
                        V_CE_carteraclass.valorefectivo = oledardr.GetDecimal(26).ToString();
                    }
                    if (oledardr.IsDBNull(27))
                    {
                        V_CE_carteraclass.valorcheque = "";
                    }
                    else
                    {
                        V_CE_carteraclass.valorcheque = oledardr.GetDecimal(27).ToString();
                    }
                    if (oledardr.IsDBNull(28))
                    {
                        V_CE_carteraclass.valorabono = "";
                    }
                    else
                    {
                        V_CE_carteraclass.valorabono = oledardr.GetDecimal(28).ToString();
                    }
                    if (oledardr.IsDBNull(29))
                    {
                        V_CE_carteraclass.valornotacredito = "";
                    }
                    else
                    {
                        V_CE_carteraclass.valornotacredito = oledardr.GetDecimal(29).ToString();
                    }
                    if (oledardr.IsDBNull(30))
                    {
                        V_CE_carteraclass.valordeposito = "";
                    }
                    else
                    {
                        V_CE_carteraclass.valordeposito = oledardr.GetDecimal(30).ToString();
                    }
                   
                    ListaCartera.Add(V_CE_carteraclass);
                
                }
                
                db2connection.Close();


            }
            catch (Exception)
            {
                
                return null;
            }


            return ListaCartera;
        }
    }
}
