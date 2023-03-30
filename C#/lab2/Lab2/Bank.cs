using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Bank
    {
        public long? num = 0;
        public type type_ = type.none;

        public enum type { 
             Срочный,
             Накопительный,
             Сберегательный,
             До_востребования,
             none
        }
        public string DateofOpen = "";
        public string sms = "";
        public internet intern = internet.none;
        public List<Owner> owners = new List<Owner>();
        public enum internet
        {
            Включено,
            Выключено,
            none
        }
        public double balans = 0;
        public Bank (int numb, type tyPe, string dateOpen, string SMS, internet inter, double bal)
        {
            num = numb;
            type_ = tyPe;
            DateofOpen = dateOpen;
            sms = SMS;
            intern = inter;
            balans = bal;
        }
        public Bank() { }

        public void returnToTheDefaultValue()
        {
            num = 0;
            type_ = type.none;
            DateofOpen = "";
            sms = "";
            intern = internet.none;
            balans = 0;
        }
        public override string ToString()
        {
            string text = 
                "Информация о счёте: " + Environment.NewLine +
                $"Номер: {num}" + Environment.NewLine +
                $"Тип вклада: {type_}" + Environment.NewLine +
                $"Дата открытия: {DateofOpen}" + Environment.NewLine +
                $"СМС оповещение: {sms}" + Environment.NewLine +
                $"Интернет-банкинг: {intern}" + Environment.NewLine +
                $"Баланс: {balans}" + Environment.NewLine +
                Environment.NewLine + "Информация о владельце счёта: ";
            foreach(var a in owners)
            {
                text += a.ToString();
            }

            return text;
        }
    }
}
