﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DSProgram
{
    class OrderedList
    {
        public static void Ordered()
        {
            string text = File.ReadAllText(@"J:\240\DSProgram\DSProgram\NumberList1.txt");
            string[] textArray = text.Split(" ");
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            int[] arr = new int[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
            {
                int a = Convert.ToInt32(textArray[i]);
                arr[i] = a;
            }
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.Write(arr[i] + " ");
                //Console.WriteLine("\n");
            }
            for (int i = 0; i < textArray.Length; i++)
            {
                list.Sort(arr[i]);
            }
            list.Display();
            Console.WriteLine("\nEnter a number to search");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            if (list.Search(searchNum))
            {
                list.DeleteElement(searchNum);

            }
            else
            {
                list.Sort(searchNum);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"J:\240\DSProgram\DSProgram\NumberList.txt", textFile);
            list.Display();

        }
    }
}