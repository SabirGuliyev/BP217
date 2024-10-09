

//int num = 20000;



//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine(i);
//}

//O(1)
//if (num > 10)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}



//int[] arr = { 2, 4, 5, 6, 9, 11, 12,13, };


//Console.WriteLine(arr[0]);


//int num = 113;

//int step = 0;
//bool result=false;

//for (int i = 2;i*i <= num; i++)
//{
//    step++;
//    if (num % i == 0)
//    {
//       result = true;
//        break;
//    }
//}

//if (result)
//{
//    Console.WriteLine("Murekkeb");
//}
//else
//{
//    Console.WriteLine("Sade");
//}
//Console.WriteLine(step);


//int num = 20;
//int step = 0;
//for (int i = 0; i < num; i++)
//{
//    for (int j = 0; j < num; j++)
//    {
//        step++;
//    }
//}


//Console.WriteLine(step);





//int[] nums = { 34, 12, 45, 4, 1, 8, 9 };
//int search = 8;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == search)
//    {
//        Console.WriteLine("var");
//        break;
//    }
//}


//int[] arr = { 1, 4, 12, 20, 30, 45, 67, 90 };
/////////////// L              L                 H
/////
//int step = 0;
//int search = 4;


//int low = 0;
//int high = arr.Length - 1;

//int mid = (low + high) / 2;

//while (arr[mid] != search)
//{
//    step++;
//    if (arr[mid] > search)
//    {
//        high = mid - 1;

//    }
//    else
//    {
//        low = mid + 1;

//    }
//    mid= (low + high) / 2;
//}

//Console.WriteLine("index: "+mid+" deyeri: " + arr[mid]);
//Console.WriteLine("Addimlarin sayi :"+step);





//int[] numbers = { 6, 5, 3, 60, 10,71, 0, 81,11,23,67,99,-5,-8 };

//int step = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0;j< numbers.Length-1-i; j++)
//    {
//        step++;
//        if (numbers[j] > numbers[j + 1])
//        {

//            int save = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = save;


//            //numbers[j] += numbers[j + 1];
//            //numbers[j + 1] = numbers[j] - numbers[j + 1];
//            //numbers[j] -= numbers[j + 1];
//        }
//    }
//}



//for (int i = 0;i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//Console.WriteLine("Addimlarin sayi: "+step);







int[] arr = { 9, 6, 7, -10, 0, 3, 1, -20 };


int step = 0;
for(int i = 0; i < arr.Length - 1; )
{
    step++;
    if (arr[i] > arr[i + 1])
    {
        int save = arr[i];
        arr[i]= arr[i + 1];
        arr[i+1]= save;

        i = 0;
    }
    else
    {
        i++;
    }
}



for(int i = 0;i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine("Addim "+step);