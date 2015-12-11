using System;
using System.Collections.Generic;

namespace firstAppOfMVC.Models
{
    class Usuario
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public Usuario()
        {
            listaUsuarios.Add(new UsuarioModel
            {
                id = 01,
                nome = "José Augusto",
                sobrenome = "Ribeiro",
                endereco = "Rua Eloy Domingues",
                email = "ribeiry10@hotmail.com",
                nascimento = Convert.ToDateTime("15/05/1992")

            });
            listaUsuarios.Add(new UsuarioModel
            {
                id = 02,
                nome = "Jefferson Andre",
                sobrenome = "Ribeiro",
                endereco = "Rua Mirassol, 50",
                email = "jeffbol@bol.com.br",
                nascimento = Convert.ToDateTime("15/07/1990")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                id = 03,
                nome = "Jose Carlos",
                sobrenome = "Macorrati",
                endereco = "Rua Projetada , 100",
                email = "macoratti@yahoo.com",
                nascimento = Convert.ToDateTime("05/09/1975")
            });
        }
        public void CriarUsuario(UsuarioModel usuarioModelo)
        {
            usuarioModelo.id = listaUsuarios.Count + 1;
            listaUsuarios.Add(usuarioModelo);
        }
        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
           foreach(UsuarioModel usuario in listaUsuarios)
            {
                if(usuario.id == usuarioModelo.id)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(int id)
        {
            UsuarioModel _usuarioModel = null;

            foreach(UsuarioModel _usuario in listaUsuarios)
                if(_usuario.id == id)
                {
                    _usuarioModel = _usuario;
                }

            return _usuarioModel;
        }
        public void DeletarUsuario(int id)
        {
            foreach(UsuarioModel _usuario in listaUsuarios)
            {
                if(_usuario.id == id)
                {
                    listaUsuarios.Remove(_usuario);
                    break;
                }
            }
        }
    }
}
