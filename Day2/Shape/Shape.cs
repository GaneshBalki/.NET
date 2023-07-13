namespace Shape;
public class Shape{
    public int Width{get;set;}
    public int Length{get;set;}
    public string Color{get;set;}
    public Shape(int width,int length , string color){
        this.Width=width;
        this.Length=length;
        this.Color=color;
    }

     public Shape(string color){
       
        this.Color=color;
    }
    public Shape(int width , string color){
        
        this.Width=width;
        this.Color=color;
    }
}