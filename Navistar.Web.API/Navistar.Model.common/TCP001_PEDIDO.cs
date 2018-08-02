using System;
using System.Collections.Generic;
using System.Text;

namespace Navistar.Model.common
{
    public class TCP001_PEDIDO : Entity
    {
        public int CD_PEDIDO { get; set; }
        public int CD_DISTRIBUIDOR { get; set; }
        public int CD_LOCALIDAD { get; set; }
        public int? CD_CLIENTE{ get; set; }
        public String CD_STPEDIDO { get; set; }
        public String ST_ESPECIAL { get; set; }
        public String NU_COTIZACION { get; set; }
        public DateTime FH_ALTA { get; set; }
        public DateTime? FH_MODIF { get; set; }
        public DateTime? FH_LIBERACION { get; set; }
        public String CD_USERALTA { get; set; }
        public String CD_USERMODIF { get; set; }
        public String NU_ORDENPROD { get; set; }
        public String TX_OBSERVACION { get; set; }
        public int? CD_IVA { get; set; }
        public String ST_IVAFRONTERA { get; set; }
        public int CD_TPFLOTILLA { get; set; }
        public String NB_CLIENTE { get; set; }
        public String CD_USUARIO_CAPTURA_DISTRIBUIDOR { get; set; }
        public int? CD_PUNTODEENTREGA { get; set; }
        public String TX_CONTACTO_DEST { get; set; }
        public String TX_DIRECCION_DEST { get; set; }
        public String TX_PUNTODEENTREGA { get; set; }
        public String TX_RAZONSOCIAL_DEST { get; set; }
        public String TX_TELEFONO_DEST { get; set; }
        public Double? IM_TIPOCAMBIO_OPERACION { get; set; }
        public String TX_COLONIA_DEST { get; set; }
        public String TX_CP_DEST { get; set; }
        public String TX_ESTADO_DEST { get; set; }
        public String TX_MUNICIPIO_DEST { get; set; }
        public String TX_RFC_DEST { get; set; }
        public String CD_PEDIDO_COMPLETO { get; set; }
        public String CD_PEDIDO_PREFIJO { get; set; }
        public int? CD_PEDIDO_FOLIO { get; set; }
        public int? CD_PEDIDO_CONSECUTIVO { get; set; }
        public String CD_STPEDIDO_ANTERIOR { get; set; }
    }
}
