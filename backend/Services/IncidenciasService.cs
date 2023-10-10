using S11.Common.Dto;
using S11.Common.Enums;
using S11.Data;
using S11.Data.Models;

namespace S11.Services
{
    public class IncidenciasService
    {
        //TODO pagedList
        //TODO Filter

        private readonly Contexto _contexto;
        public IncidenciasService(Contexto contexto)
        {
            _contexto = contexto;
        }

        /// <summary>  Obtiene el resumen de las incidencias con las [nItems] primeras ordenadas por fecha </summary>
        /// <returns></returns>
        public IncidenciasResumeDto GetResume(int nItems = 10 )
        {
            var data = _contexto.Incidencias.OrderBy(x => x.FechaIncidencia);

            var dto = new IncidenciasResumeDto()
            {
                //TODO mapper
                Data = data.Take(nItems).Select(x => new IncidenciaDto()
                {
                    Area = x.Area,
                    Categoria = x.Categoria,
                    Descripcion = x.Descripcion,
                    Estado = x.Estado,
                    FechaIncidencia = x.FechaIncidencia,
                    HabitacionId = x.HabitacionId,
                    HuespedId = x.HuespedId,
                    Incidencia_Id = x.Incidencia_Id,
                    ReportadoPor = x.ReportadoPor,
                    Titulo = x.Titulo
                }),
                EnAtencion = data.Count(x => x.Estado == TipoIncidencia.EnAtencion),
                Pendientes = data.Count(x => x.Estado == TipoIncidencia.Pendiente),
                Resueltas = data.Count(x => x.Estado == TipoIncidencia.Resuelta),
                Total = data.Count()
            };

            return dto;
        }

        [Obsolete("No para este sprint", error:true)]
        public Incidencia CreateNew(IncidenciaDto incidencia)
        {
            var model = new Incidencia()
            {
                Area = incidencia.Area,
                Categoria = incidencia.Categoria,
                Descripcion = incidencia.Descripcion,
                Estado = incidencia.Estado,
                FechaIncidencia = incidencia.FechaIncidencia,
                HabitacionId = incidencia.HabitacionId,
                HuespedId = incidencia.HuespedId,
                Incidencia_Id = incidencia.Incidencia_Id,
                ReportadoPor = incidencia.ReportadoPor,
                Titulo = incidencia.Titulo
            };

            try
            {
                _contexto.Incidencias.Add(model);
                _contexto.SaveChanges();
                return model;
            }
            catch (Exception e)
            {
                //log
                throw;
            }
        }

        [Obsolete("No para este sprint", error: true)]
        public List<IncidenciaDto> GetAll()
        {
            var data = _contexto.Incidencias.ToList();
            var dtos = data.Select(x => new IncidenciaDto()
            {
                Area = x.Area,
                Categoria = x.Categoria,
                Descripcion = x.Descripcion,
                Estado = x.Estado,
                FechaIncidencia = x.FechaIncidencia,
                HabitacionId = x.HabitacionId,
                HuespedId = x.HuespedId,
                Incidencia_Id = x.Incidencia_Id,
                ReportadoPor = x.ReportadoPor,
                Titulo = x.Titulo
            }).ToList();

            return dtos;
        }
    }
}

