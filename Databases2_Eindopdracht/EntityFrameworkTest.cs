using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases2_Eindopdracht
{
    class EntityFrameworkTest : GenericTest
    {

        override public void CleanDatabase()
        {
            using (EntityFramework context = new EntityFramework())
            {
                context.Database.Delete();
                context.Database.Create();
            }
        }

        override public TimeSpan RunCreate(int n)
        {
            using (EntityFramework context = new EntityFramework())
            {
                return RunTemplate((int i) =>
                {
                    var account = CreateAccount(i);
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }, n);

            }
        }

        override public TimeSpan RunRead(int n)
        {
            using (EntityFramework context = new EntityFramework())
            {
                return RunTemplate((int i) =>
                {
                    context.Accounts.Find(i);
                }, n);

            }
        }

        override public TimeSpan RunUpdate(int n)
        {
            using (EntityFramework context = new EntityFramework())
            {
                return RunTemplate((int i) =>
                {
                    // Accounts worden door entity framework getracked waardoor het updaten heel snel gaat.
                    // Ik weet niet of ik dit wel of niet mee moet nemen in de test.
                    Account account = context.Accounts.Find(i);
                    account.MailAdress = "a.santiago@nypd.com";
                    context.SaveChanges();
                }, n);

            }
        }

        override public TimeSpan RunDelete(int n)
        {
            using (EntityFramework context = new EntityFramework())
            {
                return RunTemplate((int i) =>
                {
                    Account account = context.Accounts.Find(i);
                    context.Accounts.Remove(account);
                    context.SaveChanges();
                }, n);

            }
        }
    }
}
