using CochesNuGet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CochesNuGet.Repositories
{
    internal class RepositoryCoches
    {
        private XDocument docxml;

        public RepositoryCoches()
        {
            String resource = "CochesNuGet.coches.xml";
            Stream stream = this.GetType().Assembly
                .GetManifestResourceStream(resource);
            this.docxml = XDocument.Load(stream);
        }

        public List<Coche> GetCoches() {
            var consulta = from datos in this.docxml.Descendants("coche")
                           select new Coche
                           {
                               IdCoche =
                                int.Parse(datos.Element("idcoche").Value),
                               Marca = datos.Element("marca").Value,
                               Modelo = datos.Element("modelo").Value,
                               Imagen = datos.Element("imagen").Value
                           };
            return consulta.ToList();
        }

        public Coche BuscarCoche(int id)
        {
            return this.GetCoches().SingleOrDefault(x => x.IdCoche == id);
        }
    }
}
