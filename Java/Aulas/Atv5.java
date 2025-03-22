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
public class Atv5 {
    public static void main(String args[]){
    double ganhos, desconto;
    
    ganhos=Double.parseDouble(JOptionPane.showInputDialog(null,"digite  o total de ganhos"));

    if(ganhos <= 500.00)
    {
       desconto=0.00;
       JOptionPane.showMessageDialog(null,"total de desconto é R$: "+desconto);
    }else if(ganhos>500.00 && ganhos <= 1500.00)
    {
    desconto=ganhos * 10 /100 ;
    JOptionPane.showMessageDialog(null,"desconto de "+ desconto);
    }else if(ganhos>1500.00 && ganhos <= 2500.00)
    {
    desconto=ganhos * 15 /100 ;
    JOptionPane.showMessageDialog(null,"desconto de "+ desconto);
    }
    else if(ganhos>2500.00)
    {
    desconto=ganhos * 25 /100 ;
    JOptionPane.showMessageDialog(null,"desconto de "+ desconto);
    }else{
    JOptionPane.showMessageDialog(null,"error tente novamente");
    }
    
    }
    
}
