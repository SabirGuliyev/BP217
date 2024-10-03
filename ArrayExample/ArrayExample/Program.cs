
#region Intro
//   1         2       3        4        5       6       7
//string[] students = { "ismayil", "ayla", "mehin", "kubra", "azad", "nicat" };
////////////////////////  0         1        2        3       4        5       6

//students[1] += " BP217";
//students[0] = "Huseyn";


//Console.WriteLine(students[students.Length-1]);


//string[] students = { "ismayil", "ayla", "mehin", "kubra", "azad", "nicat" }; 
#endregion


#region Example 1

//for (int i = 0; i < students.Length; i++)
//{

//    //students[i] += " BP217";
//    Console.WriteLine(students[i]+" BP217");
//}
//for (int i = students.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(students[i]);
//}

#endregion


#region Example 2
//string word = "salam";

//for (int i = 0;i< word.Length; i++)
//{
//    if (word[i] == 'a')
//    {
//        Console.WriteLine("A herfi movcuddur");
//        break;
//    }
//    //Console.WriteLine(word[i]);
//}


#endregion

#region Example 3
//int[] arr = { 12, 34, 13, 56, 3, 7 };

//int count = 0;

//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count); 
#endregion

#region Example 4

//int[] arr = { 11, 34, 13, 57, 3, 7 };
//bool result = false;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        result = true;
//        break;
//    }
//}

//if (result)
//{
//    Console.WriteLine("Cut eded movcuddur");
//}
//else
//{
//    Console.WriteLine("Cut eded YOXDUR");
//}


#endregion

#region Different syntaxis
//int[] nums = new int[0];
//int[] nums2 = new int[] {1,4,6,20 };

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

#endregion

#region Multidimensional

//int[,] nums =
//{
//    {2,3,4 },
//    {5,6,7 },
//    {8,9,10 }
//};
////Console.WriteLine(nums[2,2]);
//Console.WriteLine(nums.Rank);


#endregion


#region Example 5
//int[] numbers = { 13, 11, 14, 27, 91 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 2; j < numbers[i]; j++)
//    {
//        if (numbers[i] % j == 0)
//        {
//            count++;
//            break;
//        }
//    }

//}

//Console.WriteLine(count); 
#endregion