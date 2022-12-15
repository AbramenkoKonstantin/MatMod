using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Prog_lab3.Form1;

namespace Prog_lab3
{
    public partial class Form1 : Form
    {
        GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
        
        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            startDate.Text = today.ToString("d");
        }
        
        private void StartButton(object sender, EventArgs e)
        {
            try
            {
                if (plusDaysButton.Checked is true)
                {
                    result.Text = SumDays(startDate.Text, dataDaysTextBox.Text);
                }
                else if (minusDaysButton.Checked is true)
                {
                    result.Text = SubtractDays(startDate.Text, dataDaysTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Выберите операцию");
                }
            }
            catch
            {
                if (String.IsNullOrEmpty(dataDaysTextBox.Text))
                {
                    MessageBox.Show("Введите количество дней для суммы");
                }
                else
                {
                    MessageBox.Show("Вы ввели слишком большое число");
                }
            }
        }

        private void EqualityStartButton(object sender, EventArgs e)
        {
            try
            {
                string[] splitDate = dataDateTextBox.Text.Split(' ', '.', '-', '_', '/');
                int[] partsOfDate = new int[3];
                for (int index = 0; index < 3; index++)
                {
                    partsOfDate[index] = int.Parse(splitDate[index]);
                }
                int daysInMonth = calendar.GetDaysInMonth(partsOfDate[2], partsOfDate[1]);
                if (partsOfDate[0] <= daysInMonth)
                {
                    if (equalityCheckButton.Checked is true)
                    {
                        equalityResult.Text = EqualityDate(startDate.Text, dataDateTextBox.Text);
                    }
                    else if (unEqualityCheckButton.Checked is true)
                    {
                        equalityResult.Text = UnEqualityDate(startDate.Text, dataDateTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Выберите операцию");
                    }
                }
                else
                {
                    MessageBox.Show("День введен неправильно");
                }
                
            }
            catch
            {
                if (String.IsNullOrEmpty(dataDateTextBox.Text))
                {
                    MessageBox.Show("Введите дату для сравнения");
                }
                else if (DateTime.TryParseExact(dataDateTextBox.Text, new[] { "dd/MM/yyyy", "dd.MM.yyyy", "dd-MM-yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) is false)
                {
                    MessageBox.Show("Дата введена неверно либо в неправильном формате. \nВведите дату в нужном формате: \n1)\'dd.MM.yyyy\' \n2)\'dd-MM-yyyy\' \n3)\'dd/MM/yyyy\'");
                }
            }
        }

        public class Date
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }

            public Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
           
            public static string operator +(Date dateToSum, string stringDaysToSum)
            {
                GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
                int daysToSum = int.Parse(stringDaysToSum);
                int daysInMonth = calendar.GetDaysInMonth(dateToSum.Year, dateToSum.Month);
                for (int i = 0; i < daysToSum; ++i)
                {
                    if (dateToSum.Day < daysInMonth)
                    {
                        dateToSum.Day++;
                    }
                    else
                    {
                        if (dateToSum.Month == 12)
                        {
                            dateToSum.Year++;
                            dateToSum.Month = 1;
                        }
                        else
                        {
                            dateToSum.Month++;
                        }
                        dateToSum.Day = 1;
                        daysInMonth = calendar.GetDaysInMonth(dateToSum.Year, dateToSum.Month);
                    }
                } 
                return (dateToSum.Day + "." + dateToSum.Month + "." + dateToSum.Year).ToString();
            }

            public static string operator -(Date dateToSubstruct, string stringDaysToSubtract)
            {
                GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
                int daysToSubtract = int.Parse(stringDaysToSubtract);
                for (int i = daysToSubtract; i != 0; i--)
                {
                    if (dateToSubstruct.Day != 1)
                    {
                        dateToSubstruct.Day--;
                    }
                    else
                    {
                        if (dateToSubstruct.Month != 1)
                        {
                            dateToSubstruct.Month--;
                        }
                        else
                        {
                            dateToSubstruct.Year--;
                            dateToSubstruct.Month = 12;
                        }
                        dateToSubstruct.Day = calendar.GetDaysInMonth(dateToSubstruct.Year, dateToSubstruct.Month);
                    }
                }
                return (dateToSubstruct.Day + "." + dateToSubstruct.Month + "." + dateToSubstruct.Year).ToString();
            }

            public static bool operator ==(Date startDate, Date comparisonDate)
            {
                if (startDate.Day != comparisonDate.Day || startDate.Month != comparisonDate.Month || startDate.Year != comparisonDate.Year)
                {
                    return false;
                }
                return true;
            }

            public static bool operator !=(Date startDate, Date comparisonDate)
            {
                if (startDate.Day != comparisonDate.Day || startDate.Month != comparisonDate.Month || startDate.Year != comparisonDate.Year)
                {
                    return true;
                }
                return false;
            }

            public override bool Equals(object obj)
            {
                return obj is Date date &&
                       Year == date.Year &&
                       Month == date.Month &&
                       Day == date.Day;
            }

            public override int GetHashCode()
            {
                int hashCode = 592158470;
                hashCode = hashCode * -1521134295 + Year.GetHashCode();
                hashCode = hashCode * -1521134295 + Month.GetHashCode();
                hashCode = hashCode * -1521134295 + Day.GetHashCode();
                return hashCode;
            }
        }

        public static string SumDays(string startDate, string daysToSum)
        {
            return (StrToDate(startDate) + daysToSum).ToString();
        }

        public static string SubtractDays(string startDate, string daysToSum)
        {
            return (StrToDate(startDate) - daysToSum).ToString();
        }
        public static string EqualityDate(string startDate, string comparisonDate)
        {
            return (StrToDate(startDate) == StrToDate(comparisonDate)).ToString();
        }
        public static string UnEqualityDate(string startDate, string comparisonDate)
        {
            return (StrToDate(startDate) != StrToDate(comparisonDate)).ToString();
        }

        static Date StrToDate (string date)
        {
            string[] splitDate = date.Split(' ', '.', '-', '_', '/');
            int[] partsOfDate = new int[3];
            for (int index = 0; index < 3; index++)
            {
                partsOfDate[index] = int.Parse(splitDate[index]);
            }
            return new Date(partsOfDate[0], partsOfDate[1], partsOfDate[2]);
        }

        private void DataDaysTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void DataDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (char.IsPunctuation(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
