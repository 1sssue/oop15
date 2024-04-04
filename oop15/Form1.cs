using System;
using System.Windows.Forms;

namespace oop15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;

            if (double.TryParse(textBox1.Text, out x))
            { textBox3.Text = Convert.ToString(2 * Math.Tan(3 * x) - ((Math.Log(1) * Math.Cos(x)) / (Math.Log(1 + Math.Pow(x, 2))))); }
            else
            {
                if (!double.TryParse(textBox1.Text, out x))
                {
                    textBox3.Text = "Введіть число у змінну x";
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //  події не використовується, можна залишити порожнім
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(textBox2.Text, out a) && double.TryParse(textBox4.Text, out b))
            { textBox5.Text = Convert.ToString((Math.Pow(a, 3) + Math.Pow(b, 3)) / 2); }
            else
            {
                if (!double.TryParse(textBox2.Text, out a))
                {
                    textBox5.Text = "Ввведіть перше число!";
                }
                if (!double.TryParse(textBox4.Text, out b))
                {
                    textBox5.Text = "Введіть друге число!";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(textBox2.Text, out a) && double.TryParse(textBox4.Text, out b))
            { textBox6.Text = Convert.ToString(Math.Sqrt(Math.Abs(a) * Math.Abs(b))); }
            else
            {
                if (!double.TryParse(textBox2.Text, out a))
                {
                    textBox6.Text = "Ввведіть перше число!";
                }
                if (!double.TryParse(textBox4.Text, out b))
                {
                    textBox6.Text = "Введіть друге число!";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox7.Text);
            int M = Convert.ToInt32(textBox8.Text);

            // Перевірка, чи входить цифра M в число N
            bool containsM = CheckContainsDigit(N, M);

            textBox9.Text = containsM.ToString();
        }
        // Функція для перевірки входження цифри M в число N
        static bool CheckContainsDigit(int N, int M)
        {
            while (N != 0)
            {
                int digit = N % 10;
                if (digit == M)
                {
                    return true;
                }
                N = N / 10;
            }
            return false;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        static double VectorLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        static double VectorSlope(double x1, double y1, double x2, double y2)
        {
            return (y1 - y2) / (x1 - x2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4;

            x1 = Convert.ToDouble(textBox10.Text);
            y1 = Convert.ToDouble(textBox11.Text);

            x2 = Convert.ToDouble(textBox12.Text);
            y2 = Convert.ToDouble(textBox13.Text);

            x3 = Convert.ToDouble(textBox14.Text);
            y3 = Convert.ToDouble(textBox15.Text);

            x4 = Convert.ToDouble(textBox16.Text);
            y4 = Convert.ToDouble(textBox17.Text);

            if (VectorLength(x1, y1, x2, y2) == VectorLength(x4, y4, x3, y3) &&
                VectorSlope(x1, y1, x2, y2) == VectorSlope(x4, y4, x3, y3))
            {
                textBox18.Text = "True";
            }
            else
            {
                textBox18.Text = "False";
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox19.Text);

            int[] digits = GetDigits(N);

            int minDigit = FindMinDigit(digits);

            int count = CountMinDigits(digits, minDigit);

            string result = $"{minDigit} x{count}";

            textBox20.Text = result;
        }

        // Функція для отримання цифр числа у масив
        static int[] GetDigits(int number)
        {
            string numberString = number.ToString();
            int[] digits = new int[numberString.Length];
            for (int i = 0; i < numberString.Length; i++)
            {
                digits[i] = int.Parse(numberString[i].ToString());
            }
            return digits;
        }

        // Функція для пошуку мінімальної цифри у масиві
        static int FindMinDigit(int[] digits)
        {
            int minDigit = digits[0];
            foreach (int digit in digits)
            {
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
            }
            return minDigit;
        }

        // Функція для підрахунку кількості цифр з мінімальним значенням у масиві
        static int CountMinDigits(int[] digits, int minDigit)
        {
            int count = 0;
            foreach (int digit in digits)
            {
                if (digit == minDigit)
                {
                    count++;
                }
            }
            return count;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        // Обчислення суми додатніх чисел
        private void button7_Click(object sender, EventArgs e)
        {
            double[] sequence = GetSequence(textBox21.Text);

            double sumPositive = sequence.Where(num => num > 0).Sum();

            textBox22.Text = sumPositive.ToString();
        }

        // Обчислення суми від'ємних чисел
        private void button8_Click(object sender, EventArgs e)
        {
            double[] sequence = GetSequence(textBox21.Text);

            double sumNegative = sequence.Where(num => num < 0).Sum();

            textBox23.Text = sumNegative.ToString();
        }

        // Порівняння модулів сум
        private void button9_Click(object sender, EventArgs e)
        {
            double[] sequence = GetSequence(textBox21.Text);

            double sumPositive = sequence.Where(num => num > 0).Sum();

            double sumNegative = sequence.Where(num => num < 0).Sum();

            double absSumPositive = Math.Abs(sumPositive);
            double absSumNegative = Math.Abs(sumNegative);

            if (absSumPositive > absSumNegative)
            {
                textBox24.Text = $"P1<|P2|";
            }
            else if (absSumPositive < absSumNegative)
            {
                textBox24.Text = $"P1>|P2|";
            }
            else
            {
                textBox24.Text = "P1=|P2|";
            }
        }

        // Функція для отримання послідовності дійсних чисел з рядка
        static double[] GetSequence(string input)
        {
            // Розділення рядка на числа за пробілами та конвертація до double
            string[] numbersString = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] sequence = new double[numbersString.Length];
            for (int i = 0; i < numbersString.Length; i++)
            {
                sequence[i] = Convert.ToDouble(numbersString[i]);
            }
            return sequence;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string text = textBox25.Text;
            string word = textBox26.Text;

            int occurrences = CountOccurrences(text, word);

            textBox27.Text = occurrences.ToString();
        }

        // Функція для підрахунку кількості входжень слова у текст
        static int CountOccurrences(string text, string word)
        {
            int index = 0;
            int count = 0;

            // Пошук входжень слова у тексті
            while ((index = text.IndexOf(word, index)) != -1)
            {
                count++;
                index += word.Length;
            }
            return count;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
