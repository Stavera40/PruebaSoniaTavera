using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace Datos
{
    public class AccesoDatos
    {
        public static DataTable SelectEmpleado(int Documento)
        {
            NpgsqlCommand com = MetodosDatos.CrearComando();
            com.CommandText = @"select b.nombre as TipoDocumento,a.numerodocumento,a.primernombre || ' ' || a.segundonombre || ' ' || a.primerapellido || ' ' || a.Segundoapellido as Nombre,
                                a.idcontrato,c.nombre as Cargo, d.valor as ARL, a.fechainicio, a.fechafin, a.salario
                                from pruebatecnica.contratoslaborales a
                                inner join pruebatecnica.tipodocumento b on a.idtipodocumento = b.idtipodocumento
                                inner join pruebatecnica.cargos c on a.idcargo = c.idcargo
                                inner join pruebatecnica.arl d on a.idarl = d.idarl
                                where numerodocumento = " + Documento;
            return MetodosDatos.EjecutarComandoSelect(com);
        }
    }
}
