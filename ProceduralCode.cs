namespace knightmoves;
public class ProceduralCode
{
    public int length = 5;
    public int height = 10;

    
}

// Add your code here
public class Rectangle
{
    public int length;
    public int height;

    public Rectangle(int length, int height){
        this.length = length;
        this.height = height;
    }

    public int CalculateArea(){
        return length * height;
    }
}