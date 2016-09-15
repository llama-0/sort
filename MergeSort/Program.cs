using System;

public static class Program {
    private static void Merge(int[] a, int[] b, int[] c) {
        int n = a.Length, m = b.Length;
        int i = 0, j = 0;
        for (int k = 0; k < m + n; k++) {
            if (j >= m || i < n && a[i] < b[j]) {
                c[k] = a[i++];
            } else {
                c[k] = b[j++];
            }
        }
    }

    private static void MergeSort(int[] a, int s, int f) { // 's' for "start" and 'f' for "final"== the next after the last
        int n = f - s;
        if (n == 1) return;
        int n1 = n / 2, n2 = n - n1;
        MergeSort(a, s, s + n1);
        MergeSort(a, s + n1, f);
        int[] u = new int[n1];
        int[] v = new int[n2];
        int[] w = new int[n];
        for (int i = 0; i < n1; i++)
            u[i] = a[s + i];
        for (int i = 0; i < n2; i++)
            v[i] = a[s + n1 + i];
        Merge(u, v, w);
        for (int i = 0; i < n; i++)
            a[s + i] = w[i];
    }

    public static void MergeSort(int[] a) {
        MergeSort(a, 0, a.Length);
    }

    public static void PrintArray(int[] a) {
        foreach (int i in a) {
            Console.Write($"{i} ");
        }
    }

    public static void Main (string[] args) {
        int[] a = new int[] { 6, 5, 2, 1, 8, 3};
        PrintArray(a);
        MergeSort(a, 0, a.Length);
        PrintArray(a);
    }
}
