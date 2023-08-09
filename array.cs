using System;
using System.Collections.Generic;

// namespace Arrays{
//     public class Array{
//     public void DisplayArray(){
//         int[] numbers = {1, 2, 3, 4, 5, 6};
//         foreach(int number in numbers){
//             System.Console.WriteLine(number);
//         } 

//         }
//     }
// }

// namespace Collections{
//     public class Arrays{
//         public void ArraysList(){
//             string[] names = {"Bill", "Pat", "Joe", "Lee"};
//             for(var i=0; i<names.Length; i++){
//                 System.Console.WriteLine(names[i]);
//             }
//         }
//     }
// }

//# challenge
// namespace Pattern{
//     public class Hash{
//         public void Hashes(int n){
//             for (int i=0; i< n; i++ ){
//                 string num = "";
//                 for(int j = 0; j< n; j++){
//                     if (j<=i){
//                         num += "#";
//                     }
//                     else {
//                         num += "";
//                     }
//                 }
//                 System.Console.WriteLine(num);
//             }
//         }
//     }
// }

// namespace ArrayLists{
//     public class List{
//         public void Array(){
//             ArrayList arrayList = new ArrayList();

//             arrayList.Add("Jonathan");
//             arrayList.Add(800);
//             arrayList.Add(DateTime.Now);

//             System.Console.WriteLine(arrayList[0]);
//             System.Console.WriteLine(arrayList[1]);
//             System.Console.WriteLine(arrayList[2]);

//             Console.ReadLine();

//             arrayList.Remove(800);

//             foreach (object item in arrayList)
//             {
//                 System.Console.WriteLine(item);
//             }

//         }
//     }
// }

// namespace Generic{
//     class GenericClass<T>
// { public T Value { get; set; }
// public GenericClass(T value)
// {
//     Value = value;
// }
//  }


// public class Gen{
//     public void Main(){
//         GenericClass<int>intInstance = new GenericClass<int>(2001);
//         GenericClass<string>stringInstance = new GenericClass<string>("Allez");

//         System.Console.WriteLine(intInstance.Value);
//         System.Console.WriteLine(stringInstance.Value);
//     }
// }
// }

namespace Sort{
    public class Program{
    public static void Mean(){
        List<int> numbers = new List<int>{2,4,56,7,4,2,7,8};
        numbers.Sort();
        foreach ( int number in numbers ){
            System.Console.WriteLine(number + " ");
        }
        {
            
        }
    }
}
}


