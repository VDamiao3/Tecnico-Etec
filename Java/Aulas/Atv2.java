/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atv.pkg1;

import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class Atv2 {
    
    public static void main(String args[])
    {
     String casa="casa";
     String trabalho="trabalho";
     int dia;
     int c=0;
     while(c!=2){
     c=Integer.parseInt(JOptionPane.showInputDialog(null,"1- ver agenda \n 2- sair"));
     if(c==2)
     {c=2;}
     else{
     
         
         
     dia=Integer.parseInt(JOptionPane.showInputDialog(null,"digite o dia da semana de 1 ao 7"));
     
   switch(dia)
   {
       case 1: JOptionPane.showMessageDialog(null,"Segunda-Feira dia de ir ao "+trabalho);
           break;
           
       case 2: JOptionPane.showMessageDialog(null,"Terça-Feira dia de ir ao "+trabalho);
           break;
           
       case 3: JOptionPane.showMessageDialog(null,"Quarta-Feira dia de ir ao "+trabalho);
           break;
           
       case 4: JOptionPane.showMessageDialog(null,"Quinta-Feira dia de ir ao "+trabalho);
       break;
           
       case 5: JOptionPane.showMessageDialog(null,"Sexta-Feira dia de ir ao "+trabalho);
        break;
        
       case 6: JOptionPane.showMessageDialog(null,"Sábado dia de ficar em "+casa);
           break;
           
       case 7: JOptionPane.showMessageDialog(null,"Domingo dia de ficar em "+casa);
           break;
           
       default: JOptionPane.showMessageDialog(null,"Tente novamente");
           break;
   }
         
    }
    }
    }
}
