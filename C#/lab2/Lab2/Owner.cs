using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Owner
    {
        public string name = "";
        public string birthDay = "";
        public string sex = "";
        public string passport = "";
        public string date = "";
        public string vydan = "";
        public string adress = "";
        public  int numbt = 0;

        public Owner(string nam, string birthD, string se, string passp, string dat, string vyda, string adres, int nu)
        {
            name = nam;
            birthDay = birthD;
            sex = se;
            passport = passp;
            date = dat;
            vydan = vyda;
            adress = adres;
            numbt = nu;
        }
        public Owner() { }

        public void returnDefaultValue()
        {
            name = "";
            birthDay = "";
            sex = "";
            passport = "";
            date = "";
            vydan = "";
            adress = "";
            numbt = 0;
        }

        public override string ToString()
        {
            return Environment.NewLine + Environment.NewLine + "ФИО: " + name
                + Environment.NewLine + "Дата рождения: " + birthDay
                + Environment.NewLine + "Пол: " + sex
                + Environment.NewLine + "Номер паспорта: " + passport
                + Environment.NewLine + "Дата выдачи: " + date
                + Environment.NewLine + "Кем был выдан: " + vydan
                + Environment.NewLine + "Адрес прописки: " + adress
                + Environment.NewLine + "Номер телефона: " + numbt;
        }
    }
}
