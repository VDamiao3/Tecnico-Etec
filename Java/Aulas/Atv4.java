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
public class Atv4 {
    
public static void main(String args[]){
 
    double SB;
    double INSS;
    double IR;
    double FS;
    double total;
    double salario = 0;
    
    SB=Double.parseDouble(JOptionPane.showInputDialog(null,"digite o valor do salário bruto"));
    // calculando INSS
    
   INSS=(SB* 8 )/100;
    // desconto IR
  IR=(SB * 10)/100;
    
  FS = ((salario - (INSS+IR)) * 0.5) / 100;
  
  total=(salario -(INSS + IR + FS));
  
  salario=SB-INSS - IR -FS;
  
  JOptionPane.showMessageDialog(null,"total de impostos a pagar:"+ total);
  
  JOptionPane.showMessageDialog(null,"INSS: "+ INSS);
  
  JOptionPane.showMessageDialog(null,"IR: "+IR );
  
  JOptionPane.showMessageDialog(null,"FS: "+ FS);
  
  JOptionPane.showMessageDialog(null,"salario liquido: "+ salario);
  
    
}

}
