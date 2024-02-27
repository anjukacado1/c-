class drivedclass3{
    public int derimet3(int a){
        return a*10;
    }
}
class derivedclass2:drivedclass3{
    public int derimet2(int a){
        return derimet3(a+10);
    }
}
class drivedclass:drivedclass3{
    public int derimet(int a){
        return derimet3(a+15);
    }
}
class  Program{
    static void Main(String[] args){
        drivedclass obj = new drivedclass();        
        derivedclass2 obj1 = new derivedclass2();        

        Console.WriteLine(obj1.derimet2(10));

    }
}