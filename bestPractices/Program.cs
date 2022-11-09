
using System;

namespace documentation { 
    class documentation
    {
        ///<summary>Avoid the use of underscore while naming identifiers</summary>
       /// <summary>corrrect practice</summary>
        public String firstName;

        ///<summary>wrong pracice</summary>
        public String first_Name;



       ///<summary>Naming convention</summary>
        ///<summary>Pascal Convention:First  character of all words should be in uppercase and others in lowercase.Use pascal 
        ///casing for naming classes,records, or structs.For interface,prefix the name with an "I".For public members of types,such as fields,properties
        ///,events,methods, and local functions,use pascal casing too</summary>
        ///<summary>correct practice</summary>
        public record UserInfo
        (
            string firstName,
            string lastName,
            string phoneNumber
        );
        public struct RoadMap
        {
        }
        public interface IClasslList
        {

        }
        public class TotalTasks
        {
            public bool IsFalse;
            public ITaskQueue TaskQueue { get; init; }
            public event Action TaskSubmission;

        public void StartTaskSubmission()
        {
                static int CountTotalTasks() => TaskQueue.Count;
        }
            }


        /// <summary>
        /// wrong practice
        /// </summary>
        public record userInfo
        (
            string firstName,
            string lastName,
            string phoneNumber
        );
        public struct roadMap
        {
        }
        public interface iclasslList
        {

        }
        public class totalTasks
        {
            public bool isFalse;
            public iTaskQueue TaskQueue { get; init; }
            public event Action taskSubmission;

            public void startTaskSubmission()
            {
                static int countTotalTasks() => taskQueue.Count;
            }
        }

        ///<summary>avoid the use of  system type names</summary>
        ///<summary>correct practice</summary>
        string address;
        int numbers;
        bool isTrue;
        ///<summary>wrong practice</summary>
        String address;
        Int32 numbers;
        Boolean isTrue;


        ///<summary>Camel Case Convention:The first character of all words of every local variable,
        ///except the first word,is upper case and other characters are lowercase.</summary>
        ///<summary>correct practice</summary>
        int evenNumbers;
        string fullName;

        ///<summary>wrong practice</summary>
        int evennumbers;
        string fullname;




        ///<summary>Constants should always be declared in UPPER_CASE</summary>
        ///<summary>Correct practice</summary>
        public const string USERNAME = "Chizoba";

        ///<summary>Bad practice</summary>
        public const string username = "Chizoba";


        ///<summary>place comments on separate lines,not at the end of the lines of codes,begin comments
        ///with uppercase and end it with a period</summary>
        ///<summary>good practice</summary>
        string footWare = "sneakers";
        // The is a correct commment format.
        ///<summary>bad practice</summary>
        string footWare = "sneakers"; // the is a correct commment 



        ///<summary>For better code indentation and readability,always alignthe curly braces vertcally</summary>
        ///<summary>correct practice</summary>
        class CurlyBraces
        {
            static void ShowBraces()
            {

            }
        }


        ///<summary>wrong  practice</summary>
        class CurlyBraces
        {
            static void ShowBraces()
            {

               }
           }
        ///<summary>use meaningful,descriptive words to name variables, avoid abbreviations</summary>
        ///<summary>correct practice</summary>
        string[] cars = { "Benz", "Ford", "volvo" };
        string userName = "Alice";
        ///<summary>wrong practice</summary>
        string[] cars = { "fork", "plate", "pot" };
        string uName = "Alice";



        ///<summary>Method name should be meaningful</summary>
        ///<summary>Good practice</summary>
        private void UserInfo(string firstName, int age);
        ///<summary>Bad practice</summary>
        private void FoodRecipe(string firstName, int age);




    }
}
