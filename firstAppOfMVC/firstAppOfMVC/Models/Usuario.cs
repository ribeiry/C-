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
                Nome = "José Augusto",
                Sobrenome = "Ribeiro",
                Endereco = "Rua Eloy Domingues",
                Email = "ribeiry10@hotmail.com",
                Nascimento = Convert.ToDateTime("15/05/1992")

            });
            listaUsuarios.Add(new UsuarioModel
            {
                Nome = "Jefferson Andre",
                Sobrenome = "Ribeiro",
                Endereco = "Rua Mirassol, 50",
                Email = "jeffbol@bol.com.br",
                Nascimento = Convert.ToDateTime("15/07/1990")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                Nome = "Jose Carlos",
                Sobrenome = "Macorrati",
                Endereco = "Rua Projetada , 100",
                Email = "macoratti@yahoo.com",
                Nascimento = Convert.ToDateTime("05/09/1975")
            });
        }
        public void CriarUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }
        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach(UsuarioModel usuario in listaUsuarios)
            {
                if(usuario.Email == usuarioModelo.Email)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;

            foreach(UsuarioModel _usuario in listaUsuarios)
                if(_usuario.Email == Email)
                {
                    _usuarioModel = _usuario;
                }

            return _usuarioModel;
        }
        public void DeletarUsuario(String Email)
        {
            foreach(UsuarioModel _usuario in listaUsuarios)
            {
                if(_usuario.Email == Email)
                {
                    listaUsuarios.Remove(_usuario);
                    break;
                }
            }
        }
    }
}
