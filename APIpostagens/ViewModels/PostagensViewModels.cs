using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIpostagens.ViewModels
{
    public class PostagensViewModels : ObservableObject
    {
        [ObservableProperty]
        public int userId;
        int id;
        string title;
        string body;


        //public int UserId { get; set; }
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public string Body { get; set; }
    }
}
