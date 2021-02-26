using CochesNuGet.Models;
using CochesNuGet.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CochesNuGet
{
    public enum Marcas
    {
        DMG = 0, Pontiac = 1, Ford = 2, Cadillac = 3
    }

    public class Garaje
    {
        RepositoryCoches repo;

        public Garaje()
        {
            this.repo = new RepositoryCoches();
        }

        public List<Coche> GetCoches()
        {
            return this.repo.GetCoches();
            //List<Coche> coches = new List<Coche>();
            //Coche c = new Coche
            //{
            //    IdCoche = 0,
            //    Marca = "DMG",
            //    Modelo = "Delorian",
            //    Imagen = "https://static.motor.es/fotos-noticias/2015/10/min652x435/curiosidades-delorean-regreso-al-futuro-201523728_4.jpg"
            //};
            //coches.Add(c);
            //c = new Coche
            //{
            //    IdCoche = 1,
            //    Marca = "PONTIAC"
            //    ,
            //    Modelo = "FireBird"
            //    ,
            //    Imagen = "https://i.ytimg.com/vi/UJFwmjfTSJw/hqdefault.jpg"
            //};
            //coches.Add(c);
            //c = new Coche
            //{
            //    IdCoche = 2
            //    ,
            //    Marca = "Volkswagen"
            //    ,
            //    Modelo = "Escarabajo"
            //    ,
            //    Imagen = "https://i.ytimg.com/vi/AP-HLHi0HUw/maxresdefault.jpg"
            //};
            //coches.Add(c);
            //c = new Coche
            //{
            //    IdCoche = 3
            //    ,
            //    Marca = "Citroen"
            //    ,
            //    Modelo = "2 CV"
            //    ,
            //    Imagen = "http://iconroad.es/onewebmedia/Iconos%20Citro%C3%ABn%202CV%20En%20el%20cine%204.png"
            //};
            //coches.Add(c);
            //return coches;
        }

        //public Coche BuscarCoche(Marcas marca)
        //{
        //    int indice = (int)marca;
        //    Coche car = this.GetCoches().SingleOrDefault
        //        (x => x.IdCoche == indice);
        //    return car;
        //}

        public Coche BuscarCoche(int id)
        {
            return this.repo.BuscarCoche(id);
        }
    }
}
