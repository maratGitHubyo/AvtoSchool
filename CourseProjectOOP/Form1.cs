using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// чтение из файла, меню сохранение в файл, всплывающие окно 
namespace CourseProjectOOP
{
    public partial class Form1 : Form
    {
       
        public List<ClientSchool> listSQL = new List<ClientSchool>();
        public Form1()
        {
            HelloForm helloForm = new HelloForm();
            helloForm.Show();
            Thread.Sleep(3000);
            helloForm.Close();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox5.Text.Equals("") || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            
            String FIO = textBox1.Text;
            if (!Regex.Match(FIO, "^[A-zА-я]+[ ]+[A-zА-я]+[ ]+[A-zА-я]+[ ]*$").Success)
            {
                info.Text = "ФИО некоректно";
                return;
            }
            
            String category = textBox2.Text;
            
            if (!Regex.Match(category, "^[A]?[B]?[C]?$").Success)
            {
                info.Text = "Такой категории нет";
                return;
            }

            String countHourse = textBox4.Text;
            int countH = int.Parse(countHourse);

            if (countH <= 0)
            {
                info.Text = "Количество часов не может быть отрицательным";
                return;
            }
            String countFails = textBox3.Text;
            int countF = int.Parse(countFails);

            if (countF <= 0)
            {
                info.Text = "Количество ошибок не может быть отрицательным";
                return;
            }

            bool resExam = false;
            String exam = textBox6.Text;
            if (exam.Equals("Сдал"))
            {
                resExam = true;
            } 
            else if (exam.Equals("Не сдал"))
            {
                resExam = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Результат экзамена|";
                return;
            }

            bool resTraining = false;
            exam = textBox5.Text;
            if (exam.Equals("Да"))
            {
                resTraining = true;
            } 
            else if (exam.Equals("Нет"))
            {
                resTraining = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Закончил обучение|";
                return;
            }

            ClientSchool client = new ClientSchool(FIO, category, countH, countF, resExam, resTraining);

            if (listSQL.Contains(client))
            {
                info.Text = "Такой ученик уже есть";
                return;
            }
            listSQL.Add(client);
            viewList();
            info.Text = "Добавлен";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox5.Text.Equals("") || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            String FIO = textBox1.Text;

            String category = textBox2.Text;
            if (!(category.Equals("A") || category.Equals("B") || category.Equals("C")))
            {
                info.Text = "Такой категории нет";
                return;
            }

            String countHourse = textBox4.Text;
            int countH = int.Parse(countHourse);

            if (countH <= 0)
            {
                info.Text = "Количество часов не может быть отрицательным";
                return;
            }
            String countFails = textBox3.Text;
            int countF = int.Parse(countFails);

            if (countF <= 0)
            {
                info.Text = "Количество ошибок не может быть отрицательным";
                return;
            }

            bool resExam = false;
            String exam = textBox6.Text;
            if (exam.Equals("Сдал"))
            {
                resExam = true;
            } 
            else if (exam.Equals("Не сдал"))
            {
                resExam = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Результат экзамена|";
            }

            bool resTraining = false;
            exam = textBox5.Text;
            if (exam.Equals("Да"))
            {
                resTraining = true;
            } 
            else if (exam.Equals("Нет"))
            {
                resTraining = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Результат экзамена|";
            }

            ClientSchool client = new ClientSchool(FIO, category, countH, countF, resExam, resTraining);

            if (listSQL.Contains(client))
            {
                info.Text = "Данный пользователь найден";
            }
            else
            {
                info.Text = "Данный пользователь не найден";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox5.Text.Equals("") || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            String FIO = textBox1.Text;

            String category = textBox2.Text;
            if (!(category.Equals("A") || category.Equals("B") || category.Equals("C")))
            {
                info.Text = "Такой категории нет";
                return;
            }

            String countHourse = textBox4.Text;
            int countH = int.Parse(countHourse);

            if (countH <= 0)
            {
                info.Text = "Количество часов не может быть отрицательным";
                return;
            }
            String countFails = textBox3.Text;
            int countF = int.Parse(countFails);

            if (countF <= 0)
            {
                info.Text = "Количество ошибок не может быть отрицательным";
                return;
            }

            bool resExam = false;
            String exam = textBox6.Text;
            if (exam.Equals("Сдал"))
            {
                resExam = true;
            } 
            else if (exam.Equals("Не сдал"))
            {
                resExam = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Результат экзамена|";
                return;
            }

            bool resTraining = false;
            exam = textBox5.Text;
            if (exam.Equals("Да"))
            {
                resTraining = true;
            } 
            else if (exam.Equals("Нет"))
            {
                resTraining = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Закончил обучение|";
                return;
            }

            ClientSchool client = new ClientSchool(FIO, category, countH, countF, resExam, resTraining);

            listSQL.Remove(client);
            viewList();
            info.Text = "Удалено";
        }
        
        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            ClientSchool valuePair = listSQL[0];
            ListViewItem item = new ListViewItem(valuePair.getFIO());
            item.SubItems.Add(valuePair.getCategory().ToString());
            item.SubItems.Add(valuePair.getCountHourse().ToString());
            item.SubItems.Add(valuePair.getCountFails().ToString());
            item.SubItems.Add(valuePair.getResultExam().ToString());
            item.SubItems.Add(valuePair.getCompletedTraining().ToString());;
            e.Item = item;
        }
        

        private void viewList()
        {
            listView1.Items.Clear();
            
            foreach (ClientSchool valuePair in listSQL)
            {
                ListViewItem item = new ListViewItem(valuePair.getFIO());
                item.SubItems.Add(valuePair.getCategory().ToString());
                item.SubItems.Add(valuePair.getCountHourse().ToString());
                item.SubItems.Add(valuePair.getCountFails().ToString());
                item.SubItems.Add(valuePair.getResultExam().ToString());
                item.SubItems.Add(valuePair.getCompletedTraining().ToString());
                listView1.Items.Add(item);
            }
            listView1.VirtualListSize = listSQL.Count;
            listView1.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listView1_RetrieveVirtualItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                int index = int.Parse(textBox7.Text);
                if (index < 0 || index >= listSQL.Count)
                {
                    info.Text = "Такого индекса нет";
                    return;
                }

                listSQL.RemoveAt(index);

            }
            catch (FormatException exception )
            {
                info.Text = "Неверный формат поля";
            }
            viewList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBox7.Text);
                if (index < 0 || index >= listSQL.Count)
                {
                    info.Text = "Такого индекса нет";
                    return;
                }

                ClientSchool client = listSQL[index];
                textBox1.Text = client.getFIO();
                textBox2.Text = client.getCategory();
                textBox4.Text = client.getCountHourse().ToString();
                textBox3.Text = client.getCountFails().ToString();

                if (client.getResultExam())
                {
                    textBox6.Text = "Сдал";
                }
                else
                {
                    textBox6.Text = "Не сдал";
                }

                if (client.getCompletedTraining())
                {
                    textBox5.Text = "Да";
                }
                else
                {
                    textBox5.Text = "Нет";
                }
                
            }
            catch (FormatException exception )
            {
                info.Text = "Неверный формат поля";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listSQL.Clear();
            viewList();
            info.Text = "Список удален";
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            
            for (int f = listSQL.Count - 1; f >= 1; f--)
            {
                for (int s = 0; s < f; s++)
                {
                    if (listSQL[s].getCountHourse() > listSQL[s + 1].getCountHourse())
                    {
                        ClientSchool c = listSQL[s];
                        listSQL[s] = listSQL[s + 1];
                        listSQL[s + 1] = c;
                    }
                }
                
            }
            viewList();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            for (int f = listSQL.Count - 1; f >= 1; f--)
            {
                for (int s = 0; s < f; s++)
                {
                    if (listSQL[s].getCountFails() > listSQL[s + 1].getCountFails())
                    {
                        ClientSchool c = listSQL[s];
                        listSQL[s] = listSQL[s + 1];
                        listSQL[s + 1] = c;
                    }
                }

            }
            viewList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String p = "^.*" + textBox8.Text + ".*$";
            List<ClientSchool> copyList = new List<ClientSchool>();

            for (int i = 0; i < listSQL.Count; i++)
            {
                if (Regex.IsMatch(listSQL[i].getFIO(), p))
                {
                    copyList.Add(listSQL[i]);
                }
            }
            listView1.Items.Clear();
            info.Text = copyList.Count.ToString();
            foreach (ClientSchool valuePair in copyList)
            {
                ListViewItem item = new ListViewItem(valuePair.getFIO());
                item.SubItems.Add(valuePair.getCategory().ToString());
                item.SubItems.Add(valuePair.getCountHourse().ToString());
                item.SubItems.Add(valuePair.getCountFails().ToString());
                item.SubItems.Add(valuePair.getResultExam().ToString());
                item.SubItems.Add(valuePair.getCompletedTraining().ToString());
                listView1.Items.Add(item);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") || textBox4.Text.Equals("")
                || textBox5.Text.Equals("") || textBox6.Text.Equals(""))
            {
                info.Text = "Заполните все поля";
                return;
            }

            
            String FIO = textBox1.Text;
            if (!Regex.Match(FIO, "^[A-zА-я]+[ ]+[A-zА-я]+[ ]+[A-zА-я]+[ ]*$").Success)
            {
                info.Text = "ФИО некоректно";
                return;
            }
            
            String category = textBox2.Text;
            
            if (!Regex.Match(category, "^[A]?[B]?[C]?$").Success)
            {
                info.Text = "Такой категории нет";
                return;
            }

            String countHourse = textBox4.Text;
            int countH = int.Parse(countHourse);

            if (countH <= 0)
            {
                info.Text = "Количество часов не может быть отрицательным";
                return;
            }
            String countFails = textBox3.Text;
            int countF = int.Parse(countFails);

            if (countF <= 0)
            {
                info.Text = "Количество ошибок не может быть отрицательным";
                return;
            }

            bool resExam = false;
            String exam = textBox6.Text;
            if (exam.Equals("Сдал"))
            {
                resExam = true;
            } 
            else if (exam.Equals("Не сдал"))
            {
                resExam = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Результат экзамена|";
                return;
            }

            bool resTraining = false;
            exam = textBox5.Text;
            if (exam.Equals("Да"))
            {
                resTraining = true;
            } 
            else if (exam.Equals("Нет"))
            {
                resTraining = false;
            }
            else
            {
                info.Text = "Введите правильные значения для поля |Закончил обучение|";
                return;
            }

            ClientSchool client = new ClientSchool(FIO, category, countH, countF, resExam, resTraining);
            

            if (listSQL.Contains(client))
            {
                listSQL[listSQL.IndexOf(client)] = client;
            }
            else
            {
                info.Text = "Данного пользователя нет в списке";
                return;
            }
            viewList();
            info.Text = "Изменено";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            viewList();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            String str = "";
            for (int i = 0; i < listSQL.Count; i++)
            {
                str = str + listSQL[i].ToString() + "\n";
            }
            System.IO.File.WriteAllText("output.txt", str);
            info.Text = "Сохранено";
        }

        private void DownlaodFile_Click(object sender, EventArgs e)
        {
            listSQL.Clear();
            string s;
            StreamReader f = new StreamReader("output.txt");
            while ((s = f.ReadLine()) != null)
            {
                string[] words = s.Split(new char[] { ',' });         
                ClientSchool clientSchool = new ClientSchool(words[0], words[1], Int32.Parse(words[2]),
                    Int32.Parse(words[3]), Boolean.Parse(words[4]), Boolean.Parse(words[5]));               
                listSQL.Add(clientSchool);

            }
            f.Close();
            info.Text = "Загружено";
            viewList();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}