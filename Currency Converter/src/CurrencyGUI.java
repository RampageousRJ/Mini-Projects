// Java swing application to convert a given currency value to a different currency value
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.HashMap;
import java.util.Map;

public class CurrencyGUI {
    HashMap<String,Double> currency=new HashMap<String,Double>();
    JFrame f=new JFrame("Currency Converter");
    JLabel l1=new JLabel("Enter value: ");
    JLabel l2=new JLabel("Convert from: ");
    JLabel l3=new JLabel("Convert to: ");
    JTextField tf1=new JTextField(30);
    String s1="USD-American",s2="EUR-Europe";
    JButton b=new JButton("Calculate");

    CurrencyGUI(){
        currency.put("INR-Indian",88.14);
        currency.put("USD-American",1.08);
        currency.put("EUR-Europe",1.0);
        currency.put("LKR-SriLankan",395.54);
        currency.put("GBP-British",0.89);
        currency.put("JPY-Japanese",138.74);
        currency.put("ASD-Australian",1.55);
        currency.put("CAD-Canadian",1.45);

        f.setVisible(true);
        f.setSize(500,500);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        // f.setLayout(new FlowLayout());
        f.setLayout(null);
        f.getContentPane().setBackground(new Color(1, 214, 158));

        String box1[]={"USD-American","INR-Indian","EUR-Europe","LKR-SriLankan","GBP-British","JPY-Japanese","ASD-Australian","CAD-Canadian"};
        JComboBox<String> cb1=new JComboBox<String>(box1);
        cb1.addItemListener(new ItemListener(){
            public void itemStateChanged(ItemEvent ie){
                ItemSelectable is1=ie.getItemSelectable();
                Object o[]=is1.getSelectedObjects();
                s1=(String) o[0];
            }
        }); 

        String box2[]={"EUR-Europe","INR-Indian","USD-American","LKR-SriLankan","GBP-British","JPY-Japanese","ASD-Australian","CAD-Canadian"};
        JComboBox<String> cb2=new JComboBox<String>(box2);
        cb2.addItemListener(new ItemListener(){
            public void itemStateChanged(ItemEvent ie){
                ItemSelectable is2=ie.getItemSelectable();
                Object o[]=is2.getSelectedObjects();
                s2=(String) o[0];
            }
        });

        b.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent ae){
                if(s1.equalsIgnoreCase(s2)){
                    JOptionPane.showMessageDialog(null, "After Conversion: "+tf1.getText()+" "+s2.substring(0,3), "InfoBox: " + "Converted Successfully!", JOptionPane.INFORMATION_MESSAGE);
                }
                else{
                    double val1=0,val2=0,inp,res;
                    for(Map.Entry<String,Double> curr:currency.entrySet()){
                        if(s1.equals(curr.getKey())){
                            val1=curr.getValue();
                        }
                    }
                    for(Map.Entry<String,Double> curr:currency.entrySet()){
                        if(s2.equals(curr.getKey())){
                            val2=curr.getValue();
                        }
                    }
                    inp=Double.parseDouble(tf1.getText());
                    res=inp*val2/val1;
                    JOptionPane.showMessageDialog(null, "After Conversion: "+String.format("%.2f",res)+" "+s2.substring(0,3), "InfoBox: " + "Converted Successfully!", JOptionPane.INFORMATION_MESSAGE);
                }
            }
        });

        l1.setBounds(35,200,200,20);
        tf1.setBounds(145, 200, 200, 20);
        l2.setBounds(35,125,200,20);
        cb1.setBounds(145,125,200,20);
        l3.setBounds(35,275,200,20);
        cb2.setBounds(145,275,200,20);
        b.setBounds(200,375,100,20);

        f.add(l1);
        f.add(l2);
        f.add(l3);
        f.add(tf1);
        f.add(cb1);
        f.add(cb2);
        f.add(b);
    }

    public static void main(String[] args) throws Exception {
        SwingUtilities.invokeLater(new Runnable(){
            public void run(){
                new CurrencyGUI();
            }
        });
    }
}