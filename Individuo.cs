public class Individuo 
{ 
    public double Massa {get ; set ;} 
    public double Altura {get ; set ;} 
    public Individuo (double massa, double altura)
    {
        Massa = massa ;
        Altura = altura ; 
    }
    public double IMC 
    {
        get =>(Massa/(Altura* Altura));
    } 
    public string Classificar()
    {
        if(IMC < 17)
        {
            return "Muito abaixo do peso"; 
        } 
        else if ( IMC >= 17 && IMC < 18.5 ) 
        {
            return "baixo do peso";  
        }  
        else if ( IMC >= 18.5 && IMC <= 24.9 ) 
        {
            return "peso ideal";  
        } 
        else if ( IMC >= 25 && IMC <= 29.9 ) 
        {
            return "acima do peso"; 
        } 
        else if ( IMC >= 30 && IMC <= 34.9 )
        {
            return "obesidae grau 1"; 
        }
        else if ( IMC >= 35 && IMC <= 39.9 ) 
        {
            return "obesidade grau 2"; 
        } 
        else 
        {
            return "Obesidade morbida"; 
        } 


    }  
    public string ReajusteDePeso()
    {
        if (IMC < 18.5 )
        {
            return "Ganhe " + (18.5*(Altura*Altura))-Massa + " kg"; 
        } 
        else if (IMC >= 25) 
        {
            return "perca " + Massa-(24.9*(Altura *Altura)) + " kg"; 
        } 
        else 
        {
            return "Você está no seu peso ideal"; 
        }
    }

}
