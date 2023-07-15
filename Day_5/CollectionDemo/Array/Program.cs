// See https://aka.ms/new-console-template for more information


//Array Declaration
int [] arr=new int [5];
arr[0]=11;
arr[1]=22;

//2D Rectangle Array
int [,] ar=new int [2,3]{
    {1,2,3},
    {4,5,6}
   
};
for(int i=0;i<2;i++){
    for(int j=0;j<3;j++){
        Console.Write(ar[i,j]+"  ");
    }
    Console.WriteLine();
}
