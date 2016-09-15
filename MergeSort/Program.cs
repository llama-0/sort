using System;

public static class Program {
    private static void Merge(int[] a, int[] b, int[] c) {
        int n = a.Length, m = b.Length;
        int i = 0, j = 0;
        for (int k = 0; k < m + n; k++) {
            if (i < n && a[i] < b[j]) {
                c [k] = a [i];
                i++;
            } else {
                c[k] = b[j];
                j++;
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
            u[i] = a[s + n1];
        for (int i = 0; i < n2; i++)
            v[i] = a[s + n1 + i];
        Merge(u, v, w);
        for (int i = 0; i < n; i++)
            a[s + i] = w[i];
    }

    /// <summary>
    /// Merges the sort.
    /// </summary>
    /// <param name="a">The alpha component.</param>
    public static void MergeSort(int[] a) {
        MergeSort(a, 0, a.Length);
    }

    /// <summary>
    /// The entry point of the program, where the program control starts and ends.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main (string[] args) {
        int[] a = new int[] { 1, 4, 2, 6, 7, 4, 8, 9, 4, 6, 5, 3 };
        MergeSort(a, 0, a.Length);
    }
}
