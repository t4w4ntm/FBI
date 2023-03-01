class Program {
    static void Main()
    {

        Console.Write("Please input password: ");
        int x = int.Parse(Console.ReadLine());

        int หน่วย = x % 10;
        int สิบ = (x / 10) % 10;
        int ร้อย = (x / 100) % 10;
        int พัน = (x / 1000) % 10;
        int หมื่น = (x / 10000) % 10;
        int แสน = (x / 100000) % 10;

         Console.Write("input หน่วยงาน ");
            string input=Console.ReadLine();
        
        if (หน่วย % 3 ==0 && สิบ != 1 && สิบ != 3 && สิบ != 5 && พัน >=6 && พัน != 8)
            {if(input.ToUpper() == "CIA") {   
                 Console.WriteLine("True");}
                 else {Console.WriteLine("False");} }

        else if(แสน >=4 && แสน <=7 && ร้อย % 2 == 0 && ร้อย !=6 && หมื่น % 2 !=0){
            if(input.ToUpper() == "FBI") {    
                 Console.WriteLine("True"); }
                 else {Console.WriteLine("False");}}
        else if(30 % หน่วย == 0 && ร้อย % 3 == 0 && ร้อย % 2 !=0 && (หน่วย == 7||สิบ == 7||ร้อย == 7|| พัน == 7 ||หมื่น == 7||แสน == 7) ){
            if(input.ToUpper() == "NSA") {    
                 Console.WriteLine("True"); }
                 else {Console.WriteLine("False");}
}
else {Console.WriteLine("False");}
}
}
