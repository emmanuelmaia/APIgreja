using System;
using Microsoft.EntityFrameworkCore.InMemory;
namespace ChurchAPI.Models
{
    public class Member
    {
        public long Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }
        private string? Endereco { get; set; }
        private string? Telefone { get; set; }
        private string DataNascimento { get; set; }
        private string? Email { get; set; }

        public void SetId(long id)
        {
            this.Id = id;
        }
        public long GetId()
        {
            return this.Id;
        }
        public void SetNome(string nome){
            this.Nome = nome;
        }
        public string GetNome( )
        {
            return this.Nome;
        }
        
        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }
        public string GetCPF()
        {
            return this.CPF;
        }
        public void SetEndereco(string endereco)
        {
            this.Endereco = endereco;
        }
        public string GetEndereco()
        {
            return this.Endereco;
        }
        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
        public string GetTelefone()
        {
            return this.Telefone;
        }
        public void SetDataNascimento(string dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }
        public string GetDataNascimento()
        {
            return this.DataNascimento;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }
        public string GetEmail()
        {
            return this.Email;
        }

    }
    
}

