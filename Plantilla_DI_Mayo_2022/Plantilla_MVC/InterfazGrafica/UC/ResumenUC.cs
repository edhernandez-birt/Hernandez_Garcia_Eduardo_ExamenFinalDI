using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.UC
{
    public partial class ResumenUC : UserControl
    {

        private List<PedidoDTO> listaPedidos;

        public ResumenUC(List<PedidoDTO> listaPedidos)
        {
            // TODO: Añade los campos que se piden al eje X e Y
            List<DateTime> ejeX = new List<DateTime>();
            List<double> ejeY = new List<double>();
            InitializeComponent();
            for(int i = 0; i<listaPedidos.Count;i++)
            {
                ejeX.Add(listaPedidos[i].FechaPedido);
                ejeY.Add(listaPedidos[i].PrecioEnvio);
            }
            chart_Pedidos.Series["Gastos Envio"].Points.DataBindXY(ejeX.ToArray(), ejeY.ToArray());

            // TODO: suma los gastos
            double suma = 0;
            foreach (double precio in ejeY)
            {
                suma += precio;
            }
            lab_SumaEnvio.Text += " "+suma.ToString();
        }


    }
}
