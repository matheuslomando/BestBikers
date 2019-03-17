using BestBikers.Entidades.Model;
using BestBikers.Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBikers.Repositorios.Logic
{
    public class MotosRepositorio
    {
        private BestBikersContext _contexto;

        public MotosRepositorio(BestBikersContext contexto)
        {
            _contexto = contexto;
        }


        public Moto ObterPorId(int id)
        {


            return new Moto();
        }

        public List<Moto> ObterTodas()
        {
            return _contexto.Motos.ToList();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }

        public void Incluir(Moto moto)
        {
            _contexto.Motos.Add(moto);
        }

        private void DefirnirDataAtual()
        {

        }
    }
}
