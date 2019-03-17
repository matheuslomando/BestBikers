using BestBikers.Entidades.Model;
using BestBikers.Repositorios.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBikers.Aplicacao.Logic
{
    public class CriarMotoAplicacao
    {
        private MotosRepositorio _motoRepositorio;

        public CriarMotoAplicacao()
        {
            var contexto = new Repositorios.Contexto.BestBikersContext();
            _motoRepositorio = new MotosRepositorio(contexto);
        }

        public Boolean GravarMotoNova(Moto moto)
        {
            if (moto.Marca == "" || moto.Marca == null)
            {
                return false;
            }


            _motoRepositorio.Incluir(moto);

            _motoRepositorio.Salvar();

            return true;
        }
    }
}
