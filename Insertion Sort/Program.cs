using System;

class InsertionSort{

     void sort(int []arr){
        int n = arr.Length;
        for(int i=0;i<n;i++){
        int key = arr[i];
        int j =i-1;

        while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
    static void PrintArray(int[]arr){
        int n= arr.Length;
        for(int i=0;i<n;++i)
        Console.WriteLine(arr[i] + " ");
        Console.WriteLine(" ");
    }
    public static void Main(){

        int[] arr = {11,23,10,44,35,20};
        InsertionSort ob = new InsertionSort();
        ob.sort(arr);
        Console.WriteLine("Sorted Array");
        PrintArray(arr);
    }
}
