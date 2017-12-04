using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R43.SeparateQueryFromModifier.depois
{
    class Guard
    {
        // ...
        public void CheckSecurity(String[] people)
        {
            DoSendAlert(people);
            String found = FindCriminal(people);
            SomeLaterCode(found);
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }

        public void DoSendAlert(String[] people)
        {
            if (FindCriminal(people) != "")
            {
                SendAlert();
            }
        }

        private void SendAlert()
        {
            throw new NotImplementedException();
        }

        public String FindCriminal(String[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    return "John";
                }
            }
            return "";
        }
    }
}
