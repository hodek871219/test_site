using System;
using System.Collections.Generic;
using System.Text;
using Navistar.Model.common;

namespace Navistar.Model.Factory
{
    public static class TCP001_PedidoFactory
    {
        public static TCP001_PEDIDO Create(int cd_pedido, int cd_distribuidor, int cd_localidad, int cd_cliente,
              String cd_stpedido, String st_especial, String nu_cotizacion, DateTime fh_alta, DateTime fh_modif, DateTime fh_liberacion,
              String cd_useralta, String cd_usermodif, String nu_ordenprod, String tx_observacion, int cd_iva, String st_ivafrontera,
              int cd_tpflotilla, String nb_cliente, String cd_usuario_captura_distribuidor, int cd_puntodeentrega, String tx_contacto_dest,
              String tx_direccion_dest, String tx_puntoentrega, String tx_razonsocial_dest, String tx_telefono_dest, Double im_tipocambio_operacion,
              String tx_colonia_dest, String tx_cp_dest, String tx_estado_dest, String tx_municipio_dest, String tx_rfc_dest, String cd_pedido_completo,
              String cd_pedido_prefijo, int cd_pedido_folio, int cd_pedido_consecutivo, String cd_stpedido_anterior)
        {
            var pedido = new TCP001_PEDIDO
            {
                CD_PEDIDO = cd_pedido,
                CD_DISTRIBUIDOR = cd_distribuidor,
                CD_LOCALIDAD = cd_localidad,
                CD_CLIENTE = cd_cliente,
                CD_STPEDIDO = cd_stpedido,
                ST_ESPECIAL = st_especial,
                NU_COTIZACION = nu_cotizacion,
                FH_ALTA = fh_alta,
                FH_MODIF = fh_modif,
                FH_LIBERACION = fh_liberacion,
                CD_USERALTA = cd_useralta,
                CD_USERMODIF = cd_usermodif,
                NU_ORDENPROD = nu_ordenprod,
                TX_OBSERVACION = tx_observacion,
                CD_IVA = cd_iva,
                ST_IVAFRONTERA = st_ivafrontera,
                CD_TPFLOTILLA = cd_tpflotilla,
                NB_CLIENTE = nb_cliente,
                CD_USUARIO_CAPTURA_DISTRIBUIDOR = cd_usuario_captura_distribuidor,
                CD_PUNTODEENTREGA = cd_puntodeentrega,
                TX_CONTACTO_DEST = tx_contacto_dest,
                TX_DIRECCION_DEST = tx_direccion_dest,
                TX_PUNTODEENTREGA = tx_puntoentrega,
                TX_RAZONSOCIAL_DEST = tx_razonsocial_dest,
                TX_TELEFONO_DEST = tx_telefono_dest,
                IM_TIPOCAMBIO_OPERACION = im_tipocambio_operacion,
                TX_COLONIA_DEST = tx_colonia_dest,
                TX_CP_DEST = tx_cp_dest,
                TX_ESTADO_DEST = tx_estado_dest,
                TX_MUNICIPIO_DEST = tx_municipio_dest,
                TX_RFC_DEST = tx_rfc_dest,
                CD_PEDIDO_COMPLETO = cd_pedido_completo,
                CD_PEDIDO_PREFIJO = cd_pedido_prefijo,
                CD_PEDIDO_FOLIO = cd_pedido_folio,
                CD_PEDIDO_CONSECUTIVO = cd_pedido_consecutivo,
                CD_STPEDIDO_ANTERIOR = cd_stpedido_anterior

            };
            return pedido;
        }
    }
}
