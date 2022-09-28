Human me = new Human();

//me.BMI = 25;

double myDouble = me.BMI;

Console.WriteLine(me);

class Human
{
    private double _BMI = 25.0;
    /*
    public double BMI 
    { 
        get { return _BMI; } 
        //set { _BMI = value; }
    }
    */
    /*  Expression Body
    public double BMI
    {
        get => _BMI;
        set => _BMI = value;
    }
    */

    public double BMI => _BMI;


    public override string ToString()
    {
        return $"I'm a human with BMI: {_BMI}";
    }

    // Method with expression body syntax:
    //public override string ToString() => $"I'm a human with BMI: {_BMI}";


}
