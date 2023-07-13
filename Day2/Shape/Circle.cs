namespace Shape;
public class Circle:Shape{
    public int Radius{get;set;}
    public Circle(int radius,string  color):base(color){
       this.Radius=radius;
    }
}