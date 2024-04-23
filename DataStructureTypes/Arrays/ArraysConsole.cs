using System;
using System.Runtime.InteropServices;

namespace DataStructureInterviewPrep.DataStructureTypes.Arrays
{
    public static class ArraysConsole
    {
        public static void Array2DExample()
        {
            //Define a 2D araray
            int[,] arr = new int[3, 4]
            {
            {1,2,3,4 },
            {5,6,7,8 },
            {9,10,11,12}
            };

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            Console.WriteLine($"rows count: {rows}");
            Console.WriteLine($"columns count: {cols}");

            GCHandle handle = GCHandle.Alloc(arr, GCHandleType.Pinned);
            IntPtr baseAddress = handle.AddrOfPinnedObject();

            //Each int value in the array occupies 4 bytes (or 32 bits) of memory.
            //When you access the memory address of an int array in a 2D context,
            //you're effectively traversing the array in row-major order.
            //each consecutive element in the array is located 4 bytes apart in memory,
            //resulting in a difference of 4 in their addresses.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = arr[i, j];
                    IntPtr address = IntPtr.Add(baseAddress, (i * cols + j) * sizeof(int));

                    Console.WriteLine($"arr[{i}][{j}] => Address: {address}, Value: {value}");
                }
            }

            handle.Free();
        }
    }
}
