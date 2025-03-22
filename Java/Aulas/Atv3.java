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
public class Atv3 {
    
    public static void main(String args[])
    {
    int n1,n2,n3,n4;
    int r1,r2,r3,r4;
    
    try{
    n1=Integer.parseInt(JOptionPane.showInputDialog(null,"digite o valor 1"));
    n2=Integer.parseInt(JOptionPane.showInputDialog(null,"digite o valor 2"));
    n3=Integer.parseInt(JOptionPane.showInputDialog(null,"digite o valor 3"));
    n4=Integer.parseInt(JOptionPane.showInputDialog(null,"digite o valor 4"));
    
    r1=n1%2 + n1%3;
    r2=n2%2 + n2%3;
    r3=n3%2 + n2%3;
    r4=n4%2 + n4%3;
    JOptionPane.showMessageDialog(null," numeros divisiveis por 2 e 3 são : ");
    if(r1==0 && r2==0 && r3==0 && r4==0)
    {
      JOptionPane.showMessageDialog(null," todos os numeros sao divisiveis:"
              + "\n"+n1+"\n"+n2+"\n"+n3+"\n"+n4);
    }
    else{
    
    
    if(r1==0)
    {
        JOptionPane.showMessageDialog(null,"numero "+ n1);
    }else
    { JOptionPane.showMessageDialog(null,"primeiro numero não é divisivel: "+ n1);}
    if(r2==0)
    {
        JOptionPane.showMessageDialog(null,"numero "+n2);
    }else
    { JOptionPane.showMessageDialog(null,"segundo numero não é divisivel: "+ n2);}
    
    if(r3==0)
    {
        JOptionPane.showMessageDialog(null,"numero "+n3);
    }else
    { JOptionPane.showMessageDialog(null,"terceiro não é divisivel: "+ n3);}
    
    if(r4==0)
    {
        JOptionPane.showMessageDialog(null,"numero "+n4);
    }
    else
    { JOptionPane.showMessageDialog(null,"quarto numero  não é divisivel: "+ n4);}
   
    
    }
    }catch(Exception x){JOptionPane.showMessageDialog(null,"digite apenas números inteiros"); }
    }
}
