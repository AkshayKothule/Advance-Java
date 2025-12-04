// See https://aka.ms/new-console-template for more information

class progrma
{
    public static void Main(string[] args)
    {
        //we cannot write bussiness logic inside main 
        Console.WriteLine(" Documentation  !");
     /*   PDF obj = new PDF(); */
     DocumentBase obj=new PDF();
     obj.Generate();
     
     

    }

   
}

abstract class  DocumentBase
{
    //abstract method 
    
    protected abstract void create(); 
    protected abstract void Validated();
    protected abstract void parse();
    protected abstract void save();
    
    //non abstract method
    public void Generate()
    {
        create();
        Validated();
        parse();
        save();
    }
    
    
}

//create a separate class for B.L
class PDF : DocumentBase
{
    protected override void create()
    {
        Console.WriteLine("create PDF file");
    }

    protected override void Validated()
    {
        Console.WriteLine("Validated PDF file");
    }

    protected override void parse()
    {
        Console.WriteLine("Parse PDF file");
    }

    protected override  void save()
    {
        Console.WriteLine("Save PDF file" );
    }
   
    
}

class DOCX
{
    public  void create()
    {
        Console.WriteLine("create DOCX file");
    }

    public void Validated()
    {
        Console.WriteLine("Validated DOCX file");
    }

    public void parse()
    {
        Console.WriteLine("Parse DOCX file");
    }

    public  void save()
    {
        Console.WriteLine("Save DOCX file" );
    }
    
}
