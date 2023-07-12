// See https://aka.ms/new-console-template for more information

using Membership;
Console.WriteLine("Hello, World!");

User usr=new User{ Email="ravi123@Transflower.com",
                 Password="ravi"};
User usr2=new User{ Email="Virat123@gmail.com",
                 Password="virat"};
bool status=AuthManager.AddMember(usr);
status=AuthManager.AddMember(usr2);

if(status){
    Console.WriteLine("Added successfully");
}
status=AuthManager.Validate("ravi123@Transflower.com","ravi");
if(status){
    Console.WriteLine("Valid User");
}
AuthManager.DisplayAll();