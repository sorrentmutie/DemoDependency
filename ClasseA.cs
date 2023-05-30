namespace DemoDependency;

public  class ClasseA
{
    private readonly IClasseB classeB;

    public ClasseA(IClasseB classeB)
    {
        this.classeB = classeB;
    }
    public void FaiQualcosaA()
    {
        //var classeb = new ClasseB();
        var tempo = DateTime.Now;

        Console.WriteLine("Fai Qualcosa A " + tempo.ToLongTimeString());
        classeB.FaiQualcosaB();
    }
}


public interface IClasseB
{
    void FaiQualcosaB();
}

public class ClasseC : IClasseB
{
    public void FaiQualcosaB()
    {
        Console.WriteLine("Classe c"); ;
    }
}



public class ClasseB : IClasseB
{
    private readonly int parameter;

    public ClasseB(int parameter)
    {
        this.parameter = parameter;
    }


    public void FaiQualcosaB()
    {
        if (parameter < 15)
        {
            throw new Exception();
        }
        Console.WriteLine("Fai Qualcosa B");
    }

}

//public class ClasseB
//{
//    private readonly int parameter;

//    public ClasseB(int parameter)
//    {
//        this.parameter = parameter;
//    }


//    public void FaiQualcosaB()
//    {
//        if(parameter < 15)
//        {
//            throw new Exception();
//        }
//        Console.WriteLine("Fai Qualcosa B");
//    }
//}
