import java.util.Scanner;

class InvalidFormatException extends Exception {
    String st;

    InvalidFormatException(String st) {
        this.st = st;
    }

    public String toString() {
        return "Exception Caught: InvalidFormatException[" + st + "]";
    }
}

class Caesar {

    // Function to exclude non-alphabetical values
    static boolean isNotAlpha(char ch) {
        int num = (int) ch;
        if ((num > 64 && num < 91) || (num > 96 && num < 123)) {
            return false;
        }
        return true;
    }

    // Function to check for numeric values
    static boolean isNum(char ch) {
        int num = (int) ch;
        if (num > 47 && num < 58) {
            return true;
        }
        return false;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Input string and key
        System.out.print("Enter string to encrypt: ");
        String str = sc.nextLine();
        System.out.print("Enter key: ");
        int key = sc.nextInt();

        // Menu Display
        System.out.print(
                "\n\nOPTIONS\n1.Lowercase Only\n2.Case Insensitive\n3.Alphanumeric Shift\n\nEnter your choice: ");
        int res = sc.nextInt();

        // Create Empty StringBuffer to append characters
        String str1 = "";
        StringBuffer code = new StringBuffer(str1);

        // Convert to Character Array to access easily
        // Can use charAt() function alternatively as well
        char ch[] = str.toCharArray();

        // Shifts only lowercase values and throws exception for any other input
        if (res == 1) {
            key %= 26;
            for (int i = 0; i < str.length(); i++) {
                try {
                    if (ch[i] == ' ') {
                        str1 = Character.toString(ch[i]);
                        code.append(str1);
                        continue;
                    }

                    else if ((int) ch[i] < 97 || (int) ch[i] > 122) {
                        throw new InvalidFormatException(str);
                    }

                    else {
                        int num = (int) ch[i];
                        num += key;
                        if (num > 122) {
                            num -= 26;
                        }
                        str1 = Character.toString((char) num);
                        code.append(str1);
                    }
                }

                catch (InvalidFormatException e) {
                    System.out.println("\n" + e);
                    sc.close();
                    return;
                }
            }
        }

        // Shifts all alphabetical values regardless of case and excludes other
        // characters
        else if (res == 2) {
            key %= 26;
            for (int i = 0; i < str.length(); i++) {
                if (Caesar.isNotAlpha(ch[i])) {
                    str1 = Character.toString(ch[i]);
                    code.append(str1);
                    continue;
                }

                else {
                    int num = (int) ch[i];
                    num += key;
                    if (num > 122) {
                        num -= 26;
                    }
                    str1 = Character.toString((char) num);
                    code.append(str1);
                }
            }
        }

        // Shifts all alphabets and numbers
        else if (res == 3) {
            for (int i = 0; i < str.length(); i++) {

                if (Caesar.isNum(ch[i])) {
                    int num = (int) ch[i];
                    num += (key % 10);
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
                    num += (key % 26);
                    if (num > 122) {
                        num -= 26;
                    }
                    str1 = Character.toString((char) num);
                    code.append(str1);
                }
            }
        }

        // Default case
        else {
            System.out.println("Not an option...");
            sc.close();
            return;
        }

        // Encryted string display
        System.out.println("\nEncryted String: " + code.toString());
        sc.close();
    }
}