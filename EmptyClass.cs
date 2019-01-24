using System;
namespace Lab8_9
{
    public class Student : System.IComparable <Student> //implement IComparable interface 
    {
       public String name { set; get; }
        public String homeTown { set; get; }
       public String favoriteFood { set; get; }

        public int CompareTo(Student that)
        {
            int result = this.name.CompareTo(that.name);//sort student list based on names

            if(result == 0)
            {
                this.homeTown.CompareTo(that.homeTown);// if there are two students with same name sort them based on hometown
            
            }

            return result;
        
        }

    }
}
