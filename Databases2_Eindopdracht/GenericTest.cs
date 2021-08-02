using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    abstract class GenericTest
    {
        public abstract void CleanDatabase();
        public abstract TimeSpan RunCreate(int n);
        public abstract TimeSpan RunRead(int n);
        public abstract TimeSpan RunUpdate(int n);
        public abstract TimeSpan RunDelete(int n);

        protected TimeSpan RunTemplate(Action<int> function, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i <= n; i++)
            {
                function(i);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        protected Account CreateAccount(int id)
        {
            return new Account()
            {
                AccountId = id,
                MailAdress = "jakeperalta@nypd.com",
                Password = "nine-nine",
                AccountActivated = true,
                DateStarted = DateTime.Now,
                NumberOfProfiles = 1,
                Invited = false,
                FriendId = 5,
                SubscriptionId = 1
            };
        }
    }
}
