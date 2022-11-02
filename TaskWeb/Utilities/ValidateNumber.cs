using System.ComponentModel.DataAnnotations;

namespace TaskWeb.Utilities
{
    public class ValidateNumber : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string[] strings = value.ToString().Split();
            //if(strings.Length < 15)
            //{
            //    return false;
            //}
            foreach (string s in strings)
            {
                for (int a = 0; a < s.Length; a++)
                {
                    if ((int)s[a] <= 47 && (int)s[a] >= 44 || (int)s[a] <= 42|| (int)s[a] <= 255 && (int)s[a] >= 58)
                    {
                        return false;
                    }
                }
            }
            string fw = strings[0];
            if (fw[0] == '+' && fw[1]=='9'&& fw[2] == '6' && fw[3] == '6')
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}
