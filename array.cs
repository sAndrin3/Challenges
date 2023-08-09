
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

namespace Pattern{
    public class Hash{
        public void Hashes(int n){
            for (int i=0; i< n; i++ ){
                string num = "";
                for(int j = 0; j< n; j++){
                    if (j<=i){
                        num += "#";
                    }
                    else {
                        num += "";
                    }
                }
                System.Console.WriteLine(num);
            }
        }
    }
}

