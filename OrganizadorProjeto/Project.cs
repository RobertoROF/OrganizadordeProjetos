using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorProjeto
{
    internal class Project
    {
        public string name { get; set; } // Nome do projeto 
        public string nameUser { get; set; } //Nome do usuaria responsavel pelo projeto
        public string startData { get; set; } //Data de inicio do projeto
        public string endData { get; set; } // Data de enceramento do projet
        public Int32 day { get; set; } //Dias trabalhados
        public Int32 time { get; set; } //Tempo tabalhado em segundos
        public string summary { get; set; } //Resumo do projeto
        public double endBudget { get; set; } // Dinheito total gasto
        public double startBudget { get; set; } //Orçamento previsto
        public string expectedDate { get; set; } //Praso de entrega 
        public bool status { get; set; } //Dizer se o projeto esta ativo ou não
    }
}
