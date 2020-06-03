namespace Calculadora
{
    public class Calculo : media
    {
        
         
         public string operacoes{get; set;}
         public float numero1{get; set;}
         public float numero2{get; set;}
         public float calculoTotalMulti{get;set;}
        public float calculoTotalSoma{get;set;}
        public float calculoTotalDiv{get;set;}
        public float calculoTotalSub{get;set;}
        public string selecao{get; set;}
        
         
         public void operacaoSoma(string operacoes = "+"){
             
             calculoTotalSoma = numero1 + numero2;
         }
         public void operacaoSub(string operacoes = "-"){
          calculoTotalSub = numero1 - numero2;
         }
            
         public void operacaoDiv(string operacoes = "-"){
             
             calculoTotalDiv = numero1 / numero2;
         }
         public void operacaoMulti(string operacoes = "-"){
             
             calculoTotalMulti = numero1 / numero2;
         }
    }
}