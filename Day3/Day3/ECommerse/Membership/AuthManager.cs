namespace Membership;

using System.Collections.Generic;
public static class AuthManager
{
    public static List<User> Ulist=new List<User>(); 
    

    public static bool Validate(string email, string password)
    {
        bool status = false;

        foreach (User U in Ulist)
        {
            if (U.Email==email && U.Password==password)
            {
                status = true;
            }
        }


        return status;
    }


    public static bool AddMember(User usr)
    {
        Ulist.Add(usr);
        return true;
    }
    public static void DisplayAll()
    {
        foreach (User U in Ulist)
        {
            Console.WriteLine("Email : "+U.Email+"\n"+"Password : "+U.Password);
        }
    }
}
