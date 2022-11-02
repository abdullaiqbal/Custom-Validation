using System.ComponentModel.DataAnnotations;

namespace TaskWeb.Utilities
{
    public class ValidateDOB : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string str = value.ToString();
            if (str[2] != '/' || str[5] != '/')
            {
                return false;
            }
            string[] strings = value.ToString().Split("/");
            int check = 0;
            int count = 0;
            int val;
            Int16 currentYear = Convert.ToInt16(DateTime.Now.Year.ToString());
            foreach (string s in strings)
            {
                check++;
                if (check == 1 && Int16.Parse(s) > 31)
                {
                    
                   return false;
                   
                }
                else if(check == 2 && Int16.Parse(s) > 12)
                {
                    return false;
                }
                else if (check == 3 && Int16.Parse(s) > currentYear)
                {
                    return false;
                }
                for (int a = 0; a < s.Length; a++)
                {
                    if ((int)s[a] <= 47 || (int)s[a] >= 58)
                    {
                        return false;
                    }
                }
                count = count+s.Length;
            }
            if (count < 8 || count > 8)
            {
                return false;
            }
            return true;
        }
    }
}
