using System;

    public static class Program {
    private static void Bubble(int[] a) {
        int n = a.Length;
        for (int i = 0; i < n -1; i++) {
            if (a[i+1] < a[i]) {
                int tmp = a[i+1];
                a[i+1] = a[i];
                a[i] = tmp;
            }
        }
    }

    private static void BubbleSort(int[] a, int n) {
        for (int i = n; i > 1; i--) {
            Bubble(a);
        }
    }

    public static void PrintArray(int[] a) {
        foreach (int i in a) {
            Console.Write($"{i} ");
        }
    }

    public static void Main (string[] args) {
    int[] a = new int[] {1, 2, 4, 5, 6, 8, 3};
    BubbleSort(a, a.Length);
    PrintArray(a);
    }
}
