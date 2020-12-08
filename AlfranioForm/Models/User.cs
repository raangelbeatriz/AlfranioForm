using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlfranioForm.Models{
    public class User{
        public int Id {get; set;}

        [Display(Name= "Nome do Cliente")]
        public string NomeUser {get; set;}

        public string Telefone {get; set;}

        public string CPF {get; set;}

        public string RG {get;set;}
        public string Email {get ; set;}

        [Display(Name= "Endereço")]
        public string Endereco {get; set;}



    } 
}