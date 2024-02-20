// See https://aka.ms/new-console-template for more information

// public class Demo{
//     public void printmsg(){
//         Console.WriteLine("hello");
//     }
//        public void printmsg22(){
//         Console.WriteLine("hello22");
//     }
// }


// class Practice
// {
//     static void Main(string [] args)
//     {
//         Console.WriteLine("Welcome to Great karikalan magic show.");
//         Console.WriteLine("Hello, World!");
//         Demo d=new Demo();
//         d.printmsg();
//         d.printmsg22();
//         printmsg1();
//          printmsg12();
        

//     }

//      public static void printmsg1(){
//         Console.WriteLine("hello1");
//     }
//     public static void printmsg12(){
//         Console.WriteLine("hello12");
//     }
// }

// class Demopractice{
//     public void printmsg3(string[] args){
//         string name="Akil";
//         Console.WriteLine(name);
//     }
// }


// static string returnMsgMethod(){
//     string name="cadbatch01R";
//     return name;
// //    Console.WriteLine(name);
// }



// static void(string[] args){

// string name="akil";
// Console.WriteLine(name);

// }


class Program{

static void Main(string [] args){
    Console.WriteLine("aaded value is : " + add(5,6));
    Console.WriteLine("subtracted value is : " + subtract(2,3,4,12));
    Console.WriteLine("aaded double value is : " + add(10,20,12)); 
    Console.WriteLine("aaded float value is : " + add(12.63f,9.8f));
    Console.WriteLine("concatenated value is:" +add("Anjuka " , "Akil"));
        // Console.WriteLine("my name is:" +);

        constructordemo d=new constructordemo();
        d.demo();



    }
    
    static int add(int a, int b){
        return a+b;
    }

    static int subtract(int a, int b, int c,int d){
        return a-b-c-d;
    }

    static double add(double a, double b, double c){
            return a+b+c;
        }

    static float add(float a, float b){
        return a+b;
    }
    
    static string add(string a, string b){
        return a+b;
    }

    // static bool(int a, int b){
    //         return a>b;

    // }

}

class constructordemo{

    public void demo(){
        Console.WriteLine("normal method in another class");
    }

    public constructordemo(){
        Console.WriteLine("Constructed method in another class");
    }



}

