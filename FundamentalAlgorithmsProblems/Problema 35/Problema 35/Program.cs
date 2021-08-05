namespace Problema_35
{
    internal class Program
    {
        private static int[] Merge(int[] st, int[] dr)
        {
            int i1, i2, i3;
            int[] v = new int[st.Length + dr.Length];
            i1 = i2 = i3 = 0;
            while (i1 < st.Length && i2 < dr.Length)
            {
                if (st[i1] < dr[i2])
                    v[i3++] = st[i1++];
                else
                    v[i3++] = dr[i2++];
            }
            while (i1 < st.Length)
                v[i3++] = st[i1++];
            while (i2 < dr.Length)
                v[i3++] = dr[i2++];
            return v;
        }

        private static int[] MergeSort(int[] a)
        {
            if (a.Length == 1)
                return a;
            else
            {
                int m = a.Length / 2;
                
                int[] left = new int[m];
                int[] right;
                
                if (a.Length % 2 != 0)
                    right = new int[m + 1];
                else
                    right = new int[m];

                for (int i = 0; i < m; i++)
                    left[i] = a[i];

                int k = 0;
                for (int i = m; i < a.Length; i++)
                    right[k++] = a[i];

                left = MergeSort(left);
                right = MergeSort(right);

                int[] r = Merge(left, right);
                return r;
            }
        }

        private static void Main()
        {
            return;
        }
    }
}