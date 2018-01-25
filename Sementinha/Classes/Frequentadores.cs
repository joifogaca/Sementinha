using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    public class Frequentadores
    {
        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 
        
        private  int código;       
        private  int famílias;       
        private  int escolas;      
        private  int escolaridades;       
        private  string nome;      
        private  int parentesco;
        private  int tipo_cadastro;
        private  string nome_crachá;        
        private  int situações;       
        private  char sexo;       
        private  string observações_saúde;       
        private  DateTime data_nascimento;       
        private  DateTime data_ingresso;      
        private  string tamanho_roupa;       
        private  string tamanho_calçado;      
        private  string cep;      
        private  string complemento;
        private  string DDD_telefone_residencial;        
        private  string telefone_residencial;
        private  string DDD_telefone_celular; 
        private  string telefone_celular;       
        private  int nome_cônjuge;       
        private  string profissão;        
        private  string observações;       
        private  string email;
        private  DateTime data_alteração;
        private string nome_pai;
        private string nome_mãe;

        // SEMPRE COLOCAR OS MÉTODOS NA MESMA ORDEM QUE ESTÃO NA TABELA DO BANCO DE DADOS

        public int Código
        {
            get { return código; }
            set { código = value; }
        }  

        public  int Famílias
        {
            get { return famílias; }
            set { famílias = value; }
        }

        public  int Escolas
        {
            get { return escolas; }
            set { escolas = value; }
        }

        public  int Escolaridades
        {
            get { return escolaridades; }
            set { escolaridades = value; }
        }

        public  string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public  int Parentescos
        {
            get { return parentesco; }
            set { parentesco = value; }
        }

        public  int Tipos_Cadastros
        {
            get { return tipo_cadastro; }
            set { tipo_cadastro = value; }
        }    

        public  string Nome_Crachá
        {
            get { return nome_crachá; }
            set { nome_crachá = value; }
        }

        public  int Situações
        {
            get { return situações; }
            set { situações = value; }
        }

        public string Sexo
        {
            get { if (sexo == 'F') return "FEMININO"; else if (sexo == 'M') return "MASCULINO"; else return null; }
            set { sexo = Convert.ToChar(value.ToString().Substring(0,1)); }
        }

        public  string Observações_Saúde
        {
            get { return observações_saúde; }
            set { observações_saúde = value; }
        }

        public  DateTime Data_Nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }

        public  DateTime Data_Ingresso
        {
            get { return data_ingresso; }
            set { data_ingresso = value; }
        }

        public  string Tamanho_Roupa
        {
            get { return tamanho_roupa; }
            set { tamanho_roupa = value; }
        }

        public  string Tamanho_Calçado
        {
            get { return tamanho_calçado; }
            set { tamanho_calçado = value; }
        }

        public  string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public  string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public  string Ddd_Telefone_Residencial
        {
            get { return DDD_telefone_residencial; }
            set { DDD_telefone_residencial = value; }
        }

        public  string Telefone_Residencial
        {
            get { return telefone_residencial; }
            set { telefone_residencial = value; }
        }

        public  string Ddd_Telefone_Celular
        {
            get { return DDD_telefone_celular; }
            set { DDD_telefone_celular = value; }
        }

        public  string Telefone_Celular
        {
            get { return telefone_celular; }
            set { telefone_celular = value; }
        }

        public  int Nome_Cônjuge
        {
            get { return nome_cônjuge; }
            set { nome_cônjuge = value; }
        }

        public  string Profissão
        {
            get { return profissão; }
            set { profissão = value; }
        }

        public  string Observações
        {
            get { return observações; }
            set { observações = value; }
        }

        public  string Email
        {
            get { return email; }
            set { email = value; }
        }

        public  DateTime Data_Alteração
        {
            get { return data_alteração; }
            set { data_alteração = value; }
        }

        public string Nome_Pai
        {
            get { return nome_pai; }
            set { nome_pai = value; }
        }


        public string Nome_Mãe
        {
            get { return nome_mãe; }
            set { nome_mãe = value; }
        }
          
       
    }
}
