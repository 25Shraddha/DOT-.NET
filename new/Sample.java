public class Sample{
    public static void main(String[] args){
      
        int decimal = 4 ; 
        String binary="";
        int remainder;
        while (decimal > 0) {
            remainder= decimal%2;
            binary=remainder+binary;
            decimal = decimal/2;
        }
        System.out.println(binary);



        // int decimal = 10 ; 
        // int [] binary = new int[10] ;
        // int i = 0;
        // while (decimal > 0) {
        //     binary[i] = decimal%2;
        //     decimal = decimal/2;
        //     i++;
        // }
        // for(int j = i-1; j>=0; j--) {
        //     System.out.print(binary[j]);
        // }


    }
}