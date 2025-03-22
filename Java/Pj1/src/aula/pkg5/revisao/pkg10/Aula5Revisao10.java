
package aula.pkg5.revisao.pkg10;

import javax.swing.JOptionPane;


public class Aula5Revisao10 {
 
    // variaveis globais
    static int a=90; int b=100;
    public static void main(String[] args) {
    soma();
    soma3(34,78);//valor a e b
    soma3(87,65);//chamando de novo o valor a e b
    }//fim do metodo main
    
    public static void soma()
    {
    int s=89+67;
    JOptionPane.showMessageDialog(null,"resultado: "+s);
    }    
    public void soma2()
    {
    int s= a+b;
    JOptionPane.showMessageDialog(null,s);
    }
    
    // metodo passagem de parametro
    public static void soma3(int a, int b){
    int s= a+b;
    }
            }
