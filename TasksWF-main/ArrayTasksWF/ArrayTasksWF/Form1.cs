using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrayTasksWF
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnTask1_Click(object sender, EventArgs e)
        {
            output.Clear();

            int[] arr = new int[10];
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(InputBox($"Введите элемент {i + 1}:"));
                sum += arr[i];
            }

            output.AppendText("Сумма = " + sum);
        }

     
        private void btnTask2_Click(object sender, EventArgs e)
        {
            output.Clear();

            int N = int.Parse(InputBox("Введите размер массива:"));
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
                arr[i] = rnd.Next(1, 101);

            int max = arr[0], min = arr[0];
            int maxIndex = 0, minIndex = 0;

            for (int i = 1; i < N; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            output.AppendText("Массив: " + string.Join(", ", arr) + Environment.NewLine);
            output.AppendText($"Max = {max} (индекс {maxIndex})" + Environment.NewLine);
            output.AppendText($"Min = {min} (индекс {minIndex})");
        }

       
        private void btnTask3_Click(object sender, EventArgs e)
        {
            output.Clear();

            int[] arr = new int[15];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(10, 51);

            int even = 0, odd = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    even++;
                else
                    odd++;
            }

            output.AppendText("Массив: " + string.Join(", ", arr) + Environment.NewLine);
            output.AppendText($"Четных: {even}" + Environment.NewLine);
            output.AppendText($"Нечетных: {odd}");
        }

     
        private void btnTask4_Click(object sender, EventArgs e)
        {
            output.Clear();

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(InputBox($"Введите число {i + 1}:"));

            int[] reversed = new int[5];

            for (int i = 0; i < 5; i++)
                reversed[i] = arr[4 - i];

            output.AppendText("Исходный: " + string.Join(", ", arr) + Environment.NewLine);
            output.AppendText("Реверс: " + string.Join(", ", reversed));
        }

     
        private void btnTask5_Click(object sender, EventArgs e)
        {
            output.Clear();

            int[] arr = { 1, 2, 3, 4, 5 };

            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];

            arr[0] = last;

            output.AppendText("После сдвига: " + string.Join(", ", arr));
        }

     
        private void btnTask6_Click(object sender, EventArgs e)
        {
            output.Clear();

            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(InputBox($"Введите число {i + 1}:"));

            bool[] counted = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                if (counted[i]) continue;

                int count = 1;

                for (int j = i + 1; j < 10; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        counted[j] = true;
                    }
                }

                output.AppendText($"Число {arr[i]} встречается {count} раз(а)" + Environment.NewLine);
            }
        }

    
        private string InputBox(string text)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = text;
            label.Text = text;
            buttonOk.Text = "OK";

            label.SetBounds(10, 10, 300, 20);
            textBox.SetBounds(10, 40, 300, 20);
            buttonOk.SetBounds(120, 70, 75, 23);

            buttonOk.DialogResult = DialogResult.OK;

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(buttonOk);
            form.AcceptButton = buttonOk;
            form.ClientSize = new System.Drawing.Size(320, 110);

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}