// Develop an application for hostel management system.  Consider different types of rooms (AC, Non AC, shared, attached), capacity of room, price, allotment criteria and so on. (Create appropriate classes and methods based on requirements)
import java.util.Scanner;

class Hostel{
    static int count;
    static boolean sac,dac,sa,da,sc,dc,tc;                      
    static void available(double cgpa){
        count=0;
        if (cgpa>8.5){
            System.out.println(++count+". Single Attached AC");
        }
        if (cgpa>8.0){
            System.out.println(++count+". Double Attached AC");
        }
        if (cgpa>8.0){
            System.out.println(++count+". Single Attached Non-AC");
        }
        if (cgpa>7.5){
            System.out.println(++count+". Double Attached Non-AC");
        }
        if (cgpa>7.0){
            System.out.println(++count+". Single Common Non-AC");
        }
        if (cgpa>6.5){
            System.out.println(++count+". Double Common Non-AC");
        }
        if (cgpa>=6.0){
            System.out.println(++count+". Triple Common Non-AC");
        }
        if(cgpa<6){
            System.out.println("Ineligible for hostel allotment...");
        }
    }

    static void criteria(){
        System.out.println("\nCGPA CRITERIA\n8.5+ SAC\n8.0+ DAC\n8.0+ SA\n7.5+ DA\n7.0+ SC\n6.5+ DC\n6.0+ TC");
    }
}

class Booking extends Hostel{
    boolean booked;
    Scanner sc=new Scanner(System.in);
    int cap[]=new int[7],j;
    double cost[]=new double[7];
    String typename[]=new String[7];
    Booking(double cgpa){
        booked=false;
        count=0;
        if (cgpa>8.5){
            typename[count]="SAC";
            cap[count]=1;
            cost[count++]=190000;
        }
        if (cgpa>8.0){
            typename[count]="DAC";
            cap[count]=2;
            cost[count++]=149500;
        }
        if (cgpa>8.0){
            typename[count]="SA";
            cap[count]=1;
            cost[count++]=152500;
        }
        if (cgpa>7.5){
            typename[count]="DA";
            cap[count]=2;
            cost[count++]=120500;
        }
        if (cgpa>7.0){
            typename[count]="SC";
            cap[count]=1;
            cost[count++]=103500;
        }
        if (cgpa>6.5){
            typename[count]="DC";
            cap[count]=2;
            cost[count++]=100500;
        }
        if (cgpa>=6.0){
            typename[count]="TC";
            cap[count]=3;
            cost[count++]=92500;
        }
    }

    void checkPrice(){
        System.out.println("\n\nBASED ON ELIGIBILITY:");
        for(int i=0 ; i < typename.length ; i++){
            if(typename[i]==null)
                break;
            System.out.println(typename[i]+": "+cost[i]);
        }
    }

    void allotment(String type){
        boolean flag=false;
        for(j=0 ; j < typename.length ; j++){
            if(typename[j]==null){
                break;
            }
            if (type.equalsIgnoreCase(typename[j])){
                flag=true;
                break;
            }
        }
        if (flag==false){
            System.out.println("\n\nWARNING: You Are Not Eligible For This Type Of Room\nPlease Check Eligibility");
            return;
        }
        System.out.print("\nAre you sure you want to book "+type+" (y/n)? ");
        char conf=sc.next().charAt(0);
        if(conf=='y' || conf=='Y'){
            System.out.println("\nROOM BOOKED SUCCESSFULLY...");
            booked=true;
        }
        else{
            System.out.println("TERMINATING SESSION...");
        }
    }

    void displayalloted(String name,long reg){
        if(!booked){
            System.out.println("\n\nWARNING: Room Not Booked Yet\nPlease Book A Room First");
            return;
        }
        System.out.println("\n\nNAME: "+name+"\nREGISTRATION NUMBER: "+reg+"\nROOM TYPE: "+typename[j]+"\nCAPACITY: "+cap[j]+"\nPRICE: "+cost[j]);
    }
}

class Student{
    public static void main(String args[]){
        Scanner sc=new Scanner(System.in);
        System.out.println("\n~ WELCOME TO MIT HOSTEL MANAGEMENT WEBSITE ~\n\nPlease Login To Continue");
        System.out.print("Enter Name: ");
        String name=sc.nextLine();
        System.out.print("Enter Registration Number: ");
        long regno=sc.nextLong();
        System.out.print("Enter CGPA: ");
        double cgpa=sc.nextDouble();

        if (cgpa>10 || cgpa<0){
            System.out.println("INVALID CGPA...");
        }

        Booking b=new Booking(cgpa);
        char res='y';
        while(res=='y'){
            System.out.print("\n\nTOOLS\n1::Check Criteria\n2::Check Eligibility\n3::Check Prices\n4::Room Booking\n5::Display Allotment\n\nEnter your choice: ");
            int ch=sc.nextInt();
            if (ch==1){
                Hostel.criteria();
            }
            else if(ch==2){
                System.out.println("\nELIGIBILITY");
                Hostel.available(cgpa);
            }
            else if(ch==3){
                b.checkPrice();
            }
            else if(ch==4){
                if (b.booked==true){
                    System.out.println("\nWARNING: You Have Already Booked A Room...");
                    continue;
                }
                System.out.print("\nEnter the desired type of room: ");
                String type=sc.nextLine();
                type=sc.nextLine();
                b.allotment(type);
            }
            else if(ch==5){
                b.displayalloted(name,regno);
            }
            else{
                System.out.println("INVALID OPTION... TERMINATING SESSION...");
                sc.close();
                return;
            }
            System.out.print("\n\nDo you want to continue?(y/n): ");
            res=sc.next().charAt(0);
            if(res!='y'){
                System.out.println("Have A Great Day :)");
                break;
            }
        }
        sc.close();
    }
}