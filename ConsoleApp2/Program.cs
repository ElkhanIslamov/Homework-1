//Console.WriteLine("Enter any word or numbers:");
//string p = Console.ReadLine();
//bool isPolindrom  = true;
//for (int i = 0;i<p.Length;i++)
//{
//    if (p[i] != p[p.Length - 1 - i])
//    {
//        Console.WriteLine("It is not a Polindrom");
//        isPolindrom = false;
//        break;
//    }
//}
//if (isPolindrom)
//{
//    Console.WriteLine("It is a Polindrom");
//}

//int[] arr = {2,51,1,0,5,6,10,3,11,4,-5 };
//int min = 0;
//for (int i = 0;i<arr.Length;i++)
//{
//    min = i;
//    for (int j =i+ 1;j<arr.Length;j++)
//    {
//        if (arr[j] < arr[min])
//            min = j;
//    }
//    int tmp = arr[min];
//    arr[min] = arr[i];
//    arr[i] = tmp;
//}
//for (int i = 0; i<arr.Length;i++)
//{
//    Console.Write(arr[i] + " ");
//}

//int[] arr = { 2, 51, 1, 0, 5, 6, 10, 3, 11, 4, -5 };
//int min = 0;
//for (int i = 0; i < arr.Length; i++)
//{

//    for (int j = 0; j < arr.Length - 1 - i; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//           int tmp = arr[j];
//           arr[j] = arr[j+1];
//           arr[j+1] = tmp;
//        }
//    }
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}