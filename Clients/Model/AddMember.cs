using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Model
{
    public class AddMember
    {
        private string fio;
        private int date;
        private bool female;
        private string pension;

        public string _Fio
        {
            get { return fio; }
            set
            {
                string[] str = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string lastName = str[0];
                string firstName = str[1];
                if (lastName.Substring(lastName.Length - 1) == "а" || lastName.Substring(lastName.Length - 1) == "о") 
                {
                    if(firstName.Substring(firstName.Length - 1) == "а" || firstName.Substring(firstName.Length - 1) == "я")
                        female = true;
                }
                fio = string.Format("{0} {1}. {2}.", str[0], str[1][0], str[2][0]);
            }
        }

        public int _Date
        {
            get { return date; }
            set 
            { 
                //int birthday = int.Parse(value);
                date = DateTime.Now.Year - value;

                //Вычисление возраста
                //DateTime birthday = Convert.ToDateTime(value);
                //int age = Convert.ToInt32(DateTime.Now.Year - birthday.Year);
                //if (birthday.Month <= DateTime.Now.Month && birthday.Day <= DateTime.Now.Day)
                //{
                //    date = age.ToString();
                //}
                //else
                //{
                //    date = (age - 1).ToString();
                //}
            }
        }

        public string _Pension
        {
            get { return pension; }
            set 
            {
                int age = int.Parse(value);
                if (female)
                    pension = (60 - age).ToString();
                else
                    pension = (65 - age).ToString();
                if (Convert.ToInt32(pension) <= 0)
                    pension = "Достигнут пенионный возраст";
            }
        }


    }
}
