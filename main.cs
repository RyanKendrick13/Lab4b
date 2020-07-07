using System;

class MainClass {  
   
     
  public static void Main (string[] args) {
    for(int i =0;i<=10;i++){
      Console.WriteLine("Enter your height in inches ");
      double height = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter your weight in pounds");
      double weight = Convert.ToDouble(Console.ReadLine());
      double BMI =CalculateBMI(height,weight);
       BMIResults(BMI);
   


    }
    
  }
  public static double CalculateBMI(double height, double weight){

      double BMI =0;
       BMI = (weight*703/(height*height));
      return BMI;
  }
      public static void BMIResults(double BMI)
      {   if(BMI<18.5){
      
          Console.WriteLine("Underweight");
        }
         else if(BMI>18.5&& BMI<=24.9)
         {
          Console.WriteLine("Normal");

          }
          else if(BMI<=25.0&&BMI<=29.9){
          Console.WriteLine("Overweight");

        }
          else{
            Console.WriteLine("Obese");
        }
      

    }
    

    }

