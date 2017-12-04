using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R43.SeparateQueryFromModifier.antes
{
    class Guard
    {
        // ...
        public void CheckSecurity(String[] people)
        {
            String found = FindCriminalAndAlert(people);
            SomeLaterCode(found);
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }

        public String FindCriminalAndAlert(String[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return "John";
                }
            }
            return "";
        }

        private void SendAlert()
        {
            throw new NotImplementedException();
        }
    }
}
