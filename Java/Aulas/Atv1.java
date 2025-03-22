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
public class Atv1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      
        
         double  a,b, result ;
         String c="" ;
         
        
         c=String.valueOf(JOptionPane.showInputDialog(null,"digite o nome do produto"));
         a=Double.parseDouble(JOptionPane.showInputDialog(null,"Digite  o valor da compra"));
         b=Double.parseDouble(JOptionPane.showInputDialog(null,"Digite  o valor de venda"));
          
         result = (100*b/a)-100;
         
         JOptionPane.showMessageDialog(null,"percentual de lucro é "+result);
         
         }
         
         
    }
    

