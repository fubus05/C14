using System;
public class Program
{
    public static void Main ()
    {
    const int size_A = 3;
    const int size_B = 4;
    const int size_C = 5;
    const int size_D = 6;
    int [,] A = new int[size_A, size_A];
    int [,] B = new int[size_B, size_B];
    int [,] C = new int[size_C, size_C];
    int [,] D = new int[size_D, size_D];
    fillArr(A, size_A);
    printArr(A, size_A);
    int sum_of_el = sum_of_elements(A, size_A);
    int sum_of_main_diag_el = sum_of_main_diag(A, size_A);
    int sum_of_second_diag_el = sum_of_second_diag(A, size_A);
    Console.WriteLine("Sum all elements of A: " + sum_of_el.ToString());
    Console.WriteLine("Sum main diag of A: " + sum_of_main_diag_el.ToString());
    Console.WriteLine("Sum second diag of A: " + sum_of_second_diag_el.ToString());
    fillArr(B, size_B);
    printArr(B, size_B);
    int sum_of_el_first = sum_of_elements(B, size_B);
    int sum_of_main_diag_el_first = sum_of_main_diag(B, size_B);
    int sum_of_second_diag_el_first = sum_of_second_diag(B, size_B);
    Console.WriteLine("Sum all elements of B: " + sum_of_el_first.ToString());
    Console.WriteLine("Sum main diag of B: " + sum_of_main_diag_el_first.ToString());
    Console.WriteLine("Sum second diag of B: " + sum_of_second_diag_el_first.ToString());
    fillArr(C, size_C);
    printArr(C, size_C);
    int sum_of_el_second = sum_of_elements(C, size_C);
    int sum_of_main_diag_el_second = sum_of_main_diag(C, size_C);
    int sum_of_second_diag_el_second = sum_of_second_diag(C, size_C);
    Console.WriteLine("Sum all elements of C: " + sum_of_el_second.ToString());
    Console.WriteLine("Sum main diag of C: " + sum_of_main_diag_el_second.ToString());
    Console.WriteLine("Sum second diag of C: " + sum_of_second_diag_el_second.ToString());
    fillArr(D, size_D);
    printArr(D, size_D);
    int sum_of_el_third = sum_of_elements(D, size_D);
    int sum_of_main_diag_el_third = sum_of_main_diag(D, size_D);
    int sum_of_second_diag_el_third = sum_of_second_diag(D, size_D);
    Console.WriteLine("Sum all elements of D: " + sum_of_el_third.ToString());
    Console.WriteLine("Sum main diag of D: " + sum_of_main_diag_el_third.ToString());
    Console.WriteLine("Sum second diag of D: " + sum_of_second_diag_el_third.ToString());
    }
    static void fillArr (int[,] arr , int size)
    {
    Random rand = new Random ();
    for (int i = 0; i < size; i++)
    {
    for (int j = 0; j < size; j++)
    {
        arr[i,j] = rand.Next (0, 10);
    }
    }
    }
    static void printArr (int[,] arr , int size){
    for (int i = 0; i < size; i++){
    for (int j = 0; j < size; j++){
        Console.Write(arr[i,j]);
        Console.Write(' ');
    }
    Console.Write('\n');
    }
    }
    static int sum_of_main_diag(int[,] arr , int size){
    int sum = 0;
    for (int i = 0; i < size; i++){
        sum += arr[i,i];
    }
    return sum;
    }
    static int sum_of_second_diag(int[,] arr , int size){
    int sum = 0;
    for (int i = 0; i < size; i++){
    sum += arr[i,size - i - 1];
    }
    return sum;
    }
    static int sum_of_elements(int[,] arr , int size){
    int sum = 0;
    for (int i = 0; i < size; i++){
        for (int j = 0; j < size; j++){
        sum += arr[i,j] ;
        }
    }
    return sum;
    }

}