using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace backend.Utils
{
    public class TestDriveConversor
    {
        public Models.Response.TestDriveResponse.Login ParaResponseLogin(Models.TbCliente tb,Models.TbFuncionario tb2,string descricao)
        {
            Models.Response.TestDriveResponse.Login usuario=new Models.Response.TestDriveResponse.Login();


            if(descricao=="Cliente"&&tb!=null)
            {
                usuario.IdLogin=tb.IdLoginNavigation.IdLogin;
                usuario.UserName=tb.IdLoginNavigation.DsUsername;
                usuario.Descricao="não é funcionario";
                usuario.IdCliente=tb.IdCliente;
                usuario.Nome=tb.NmCliente;
                usuario.ClienteFuncionario=descricao;
                usuario.IdFuncionario=0;
            }
            else if(descricao=="Funcionário"&&tb2!=null)
            {
                usuario.IdCliente=0;
                usuario.UserName=tb2.IdLoginNavigation.DsUsername;
                usuario.Descricao=tb2.IdLoginNavigation.DsPerfil;
                usuario.IdLogin=tb2.IdLoginNavigation.IdLogin;
                usuario.Nome=tb2.NmFuncionario;
                usuario.ClienteFuncionario=descricao;
                usuario.IdFuncionario=tb2.IdFuncionario;
            }
   

           return usuario;
            
        }
        public Models.Response.TestDriveResponse.ClienteAgendamento ParaResponseagenda(Models.TbAgendamento ag)
        {
            Models.Response.TestDriveResponse.ClienteAgendamento agendamento=new Models.Response.TestDriveResponse.ClienteAgendamento();
            agendamento.Id=ag.IdAgendamento;
            agendamento.Nome=ag.IdClienteNavigation.NmCliente;
            agendamento.Cpf=ag.IdClienteNavigation.DsCpf;
            agendamento.Funcionario=ag.IdFuncionarioNavigation.NmFuncionario;
            agendamento.Carro=ag.DsCarro;
            agendamento.Dia=ag.DtAgendamento;
            agendamento.Situacao=ag.DsSituacao;

            return agendamento;
        }
        public Models.TbAgendamento ParaTabelaAgenda (Models.Request.TestDriveRequest.Agendar ag,int id)
        {
            Models.TbAgendamento tb=new Models.TbAgendamento(); 

            tb.DsSituacao="Aguardando aprovação";
            tb.IdCliente=id;
            tb.DtAgendamento=ag.Agendamento;
            tb.HrAgendamento=ag.Agendamento.TimeOfDay;
            tb.DsCarro=ag.Carro;
            tb.IdFuncionario=ag.IdFuncionario;

            return tb;
        }
       // public Models.Response.TestDriveResponse.ClienteAgendar ParaResponseagendar(Models.TbAgendamento ag)
/*{
            Models.Response.TestDriveResponse.ClienteAgendar agendar=new Models.Response.TestDriveResponse.ClienteAgendar();
            agendar.Carro=ag.DsCarro;
            agendar.Dia=ag.DtAgendamento;
            agendar.Funcionario=ag.IdFuncionario;
            agendar.Situacao=ag.DsSituacao;
            agendar.Id=ag.IdAgendamento;
            return agendar;
        }
    }*/ 
    /*public Models.Response.TestDriveResponse.ResponseFeedback ParaResponseFeedback(Models.TbAgendamento tb)
    {
        Models.Response.TestDriveResponse.ResponseFeedback response=new Models.Response.TestDriveResponse.ResponseFeedback();
        response.Feedback=tb.VlFeedback;

        return response
    }*/
}
}