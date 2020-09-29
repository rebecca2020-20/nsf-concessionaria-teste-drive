using System.Collections.Generic;
using System.Linq;
using System;

namespace backend.Business
{
    public class FuncionarioBusiness
    {
        Validar.ValidardorTestDrive validador = new Validar.ValidardorTestDrive();
        Database.FuncionarioDatabase database = new Database.FuncionarioDatabase();
        public List<Models.TbAgendamento> Listar()
        {
            List<Models.TbAgendamento> agendamento=database.Listar();

               if(agendamento.Count==0)
                  throw new ArgumentException("ainda não há registros");

                  return  agendamento;
        }

       public List<Models.TbAgendamento> ListarAgendamentos(int id)
       {
           return database.ListarAgendamentos(id);
       } 

       public Models.TbAgendamento AprovarAgendamento(int idagendamento,int idFuncionario)
       {
           validador.Validacao(idagendamento);
           return database.VerificarDisponibilidade(idagendamento,idFuncionario);
       }
        public Models.TbAgendamento AlterarSituacao(int idAgendamento,string situacao)
        {
           validador.Validacao(idAgendamento);
           return database.AlterarSituacao(idAgendamento,situacao);
        }
        

    }
}