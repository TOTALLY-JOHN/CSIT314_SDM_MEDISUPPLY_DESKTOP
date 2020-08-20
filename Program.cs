using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIT314_project
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }

    // Testing Code
    /*public class User
    {
        private string userID;
        private string userPwd;
        private string userName;
        private string userType;
        private string userStatus;
        private string personalQuestion;
        private string personalAnswer;

        private User () { }

        public User(string userID, string userPwd, string userName, string userType, string userStatus, string personalQuestion, string personalAnswer)
        {
            this.userID = userID;
            this.userPwd = userPwd;
            this.userName = userName;
            this.userType = userType;
            this.userStatus = userStatus;
            this.personalQuestion = personalQuestion;
            this.personalAnswer = personalAnswer;
        }

        public string getUserID()
        {
            return userID;
        }

        public string getUserPwd()
        {
            return userPwd;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getUserType()
        {
            return userType;
        }

        public string getUserStatus()
        {
            return userStatus;
        }

        public string getPersonalQuestion()
        {
            return personalQuestion;
        }

        public string getPersonalAnswer()
        {
            return personalAnswer;
        }

        public static void Main()
        {
            User user = new User("ac123", "12345678", "Andrew", "OIC", "Available", "What is your pet's name?", "Lovely");
            Console.WriteLine("Personal Answer :  {0}", user.getPersonalAnswer());
        }
    }*/
}
