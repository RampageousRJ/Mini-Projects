import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class InvalidFormatException extends Exception {
    String st;

    InvalidFormatException(String st) {
        this.st = st;
    }

    public String toString() {
        return "Exception Caught: InvalidFormatException[" + st + "]";
    }
}

class CaesarResult{
    JFrame f=new JFrame("Result");
    JLabel l=new JLabel("Result: ");
    JTextField tf=new JTextField(30);
    JButton b=new JButton("Back");
    CaesarResult(String st){
        f.setVisible(true);
        f.setSize(500,500);
        f.setDefaultCloseOperation(3);
        f.setLayout(new FlowLayout());
        tf.setText(st);
        b.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent ae){
                new CaesarMain();
            }
        });
        f.add(l);
        f.add(tf);
        f.add(b);
    }
}

class CaesarMain{
    JFrame f=new JFrame("Caesar Encrypter");
    JLabel l1=new JLabel("Enter text to encrypt: ");
    JLabel l2=new JLabel("Enter key: ");
    JTextField tf1=new JTextField(30);
    JTextField tf2=new JTextField(4);
    JButton b=new JButton("Encrypt");
    CaesarMain(){
        f.setVisible(true);
        f.setSize(500,500);
        f.setDefaultCloseOperation(3);
        f.setLayout(new FlowLayout());

        b.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent ae){
                String str=tf1.getText();
                int key=Integer.parseInt(tf2.getText());
                String str1 = "";
                StringBuffer code = new StringBuffer(str1);
                char ch[] = str.toCharArray();
                for (int i = 0; i < str.length(); i++) {
                
                    if(Caesar.isNum(ch[i])){
                        int num = (int) ch[i];
                        num += (key%10);
                        if (num > 57) {
                            num -= 10;
                        }
                        str1 = Character.toString((char) num);
                        code.append(str1);
                    }
    
                    else if (Caesar.isNotAlpha(ch[i])) {
                        str1 = Character.toString(ch[i]);
                        code.append(str1);
                        continue;
                    }
                    
                    else {
                        int num = (int) ch[i];
                        num += (key%26);
                        if (num > 122) {
                            num -= 26;
                        }
                        str1 = Character.toString((char) num);
                        code.append(str1);
                    }
                }
                new CaesarResult(code.toString());
            }
        });
        f.add(l1);
        f.add(tf1);
        f.add(l2);
        f.add(tf2);
        f.add(b);
    }

    static boolean isNotAlpha(char ch) {
        int num = (int) ch;
        if ((num > 64 && num < 91) || (num > 96 && num < 123)) {
            return false;
        }
        return true;
    }

    static boolean isNum(char ch) {
        int num = (int) ch;
        if (num>47 && num<58) {
            return true;
        }
        return false;
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable(){
            public void run(){
                new CaesarMain();
            }
        });
    }
}