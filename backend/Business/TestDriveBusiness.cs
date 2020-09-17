using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Business
{
    public class TestDriveBusiness
    {
        Database.TestDriveDatabase database=new Database.TestDriveDatabase();
        public Models.TbLogin VerificarLogin(Models.Request.TestDriveRequest.Login req )
        {
            Models.TbLogin tabela=database.verificarLogin(req);
            
            if(tabela==null)
                  throw new ArgumentException("username ou senha incorretos");

                  return tabela;

        }
        public string VerificarPerfil (Models.TbLogin tabela)
        {
            return database.VerificarPerfil(tabela);
        }
    
        public Models.TbCliente verificarCliente(Models.TbLogin tb)
        {
                return database.verificarCliente(tb);
          
        }
      public Models.TbFuncionario verificarFucionario(Models.TbLogin tb)
        {
                return database.verificarFuncionario(tb);
          
        }
    }
}