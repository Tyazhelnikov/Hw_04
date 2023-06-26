// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int getNumber(string massage){
    int number = 0;
    System.Console.WriteLine(massage);
    try {
         number = Convert.ToInt32(Console.ReadLine());
       
    }
    catch(Exception ex) {
        System.Console.WriteLine($"incorrect input {ex}");
    }
    return number;    
}



int checkSum(int[] arg){
    int result = 0;
    for(int i = 0; i < arg.Length; i++){
        result = arg[i] + result;   
    }
    System.Console.WriteLine(result);
    return result;
   
}

int[] numToArray(int arg){
    int[] nums = new int[5];
    for(int i = 0;i< nums.Length;i++){
        
        nums[i] = arg % 10;
        arg = arg / 10;              
          
         //System.Console.WriteLine($"nums i - {nums[i]}   arg - {arg}     i - {i} ");          
    }
    return nums;

}



int result = checkSum(numToArray(getNumber("enter number")));

