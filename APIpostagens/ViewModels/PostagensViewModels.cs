using APIpostagens.Models;
using APIpostagens.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace APIpostagens.ViewModels
{
    public partial class PostagensViewModels : ObservableObject
    {
        [ObservableProperty]
        public int userId;          //public int UserId { get; set; }
        [ObservableProperty]
        int id;                     //public int Id { get; set; }
        [ObservableProperty]
        string title;               //public string Title { get; set; }
        [ObservableProperty]
        string body;                //public string Body { get; set; }

        //método "Exibir na tela"

        public ICommand CarregaPostagensCommand => new Command(async () => CarregaPostagens());

        public async void CarregaPostagens()
        {
            List<Postagem> listar = new List<Postagem>();
            listar = await new PostagensService().GetPostagens();

            Id = listar[0].Id;
            Title = listar[0].Title;
            Body = listar[0].Body;


        }


    }
}
