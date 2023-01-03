using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SAOD_kyrsach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        unsafe public class Node
        {
            public Node(string data)
            {
                Data = data;
            }
            public string Data { get; set; }
            public Node Next { get; set; }

        }
        public class Circle_Link_list
        {
            Node head;
            Node last;
            int count;
            int pos_of_del;
            int pos_of_find;

            public string show()
            {
                
                string text ="";
                Node current = head;
                int i = 0;
                 
                while(i<count)
                {
                    Node a = current;
                    Node r = current;
                    var ad = a.Next?.GetHashCode()??0;
                    text += "Элемент " + (i + 1).ToString()+ " " +current.Data +  "\tАдрес элемента: " + r.GetHashCode() + " Указатель на след: " + ad +"\n";
                    current = current.Next;
                    i++;
                    
                }

                return text;
            }
        public void Add_back(string data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                    last = node;
                    last.Next = head;
                }
                else
                {
                    node.Next = head;
                    last.Next = node;
                    last = node;
                }
                count++;
            }
            public void Add_front(string data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                    last = node;
                    last.Next = head;
                }
                else
                {
                    last.Next = node;
                    node.Next = head;
                    head = node;
                }
                count++;
            }
            
            public bool Remove(string data)
            {
                pos_of_del = 0;
                Node current = head;
                Node previous = null;

                if (IsEmpty)
                    return false;
                do
                {
                    if (current.Data.Equals(data))
                    {
                        if (previous != null)
                        {
                            previous.Next = current.Next;
                            if (current == last)
                                last = previous;
                        }
                        else
                        {
                            if (count == 1)
                                head = last = null;
                            else
                            {
                                head = current.Next;
                                last.Next = current.Next;
                            }

                        }
                        count--;
                        return true;

                    }
                    pos_of_del++;
                    previous = current;
                    current = current.Next;

                } while (current != head);
                return false;
            }
            public int Count
            { get { return count; } }
            public int Pos_of_del
            { get { return pos_of_del; } }
            public int Pos_of_find
            { get { return pos_of_find; } }
            public bool IsEmpty
            { get { return count == 0; } }

            public void Clear()
            {
                head = null;
                last = null;
                count = 0;
            }
            public bool Contains(string data)
            {
                Node current = head;
                pos_of_find = 0;
                if (current == null)
                    return false;
                do
                {
                    if (current.Data.Equals(data))
                        return true;
                    current = current.Next;
                    pos_of_find++;
                }
                while (current != head);
                return false;
            }
        }

        Circle_Link_list Circle_list = new Circle_Link_list();

        async void Add_color(int numb)
        {
                if (numb == 1)
                {
                    string line = richTextBox1.Lines[0];
                    int start = richTextBox1.GetFirstCharIndexFromLine(0);
                    int end = line.Length;
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = end;
                    richTextBox1.SelectionBackColor = Color.Green;
                    await Task.Delay(2000);
                    richTextBox1.SelectionBackColor = Color.White;
                }
                if (numb ==2)
                {
                    int count = Circle_list.Count-1;
                    string line = richTextBox1.Lines[count];
                    int start = richTextBox1.GetFirstCharIndexFromLine(count);
                    int end = line.Length;
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = end;
                    richTextBox1.SelectionBackColor = Color.Green;
                    await Task.Delay(2000);
                    richTextBox1.SelectionBackColor = Color.White;
                }
                if (numb ==3)
                {
                    int pos = Circle_list.Pos_of_del;
                    string line = richTextBox1.Lines[pos];
                    int start = richTextBox1.GetFirstCharIndexFromLine(pos);
                    int end = line.Length;
                    richTextBox1.SelectionStart = start;
                    richTextBox1.SelectionLength = end;
                    richTextBox1.SelectionBackColor = Color.Red;
                    await Task.Delay(2000);
                    richTextBox1.SelectionBackColor = Color.White;
                    richTextBox1.Text = Circle_list.show();
                }
            if (numb == 4)
            {
                int pos = Circle_list.Pos_of_find;
                string line = richTextBox1.Lines[pos];
                int start = richTextBox1.GetFirstCharIndexFromLine(pos);
                int end = line.Length;
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = end;
                richTextBox1.SelectionBackColor = Color.Yellow;
                await Task.Delay(2000);
                richTextBox1.SelectionBackColor = Color.White;

            }

        }
        private void Btn_add_font_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            string data = textBox1.Text;
            Circle_list.Add_front(data);
            richTextBox1.Text = Circle_list.show();
            Add_color(1);
            textBox1.Clear();
        }

        private void Btn_add_back_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            string data = textBox1.Text;
            Circle_list.Add_back(data);
            richTextBox1.Text = Circle_list.show();
            Add_color(2);
            textBox1.Clear();
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            string data = textBox1.Text;
            if (Circle_list.Remove(data))
            {
                Add_color(3);
                textBox1.Clear();
            }
            else
                MessageBox.Show("Такое имя не существует");

            

        }

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                return;
            string data = textBox2.Text;
            if (Circle_list.Contains(data))
            {
                Add_color(4);
                textBox2.Clear();
            }
            else
                MessageBox.Show("Такое имя не найдено");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle_list.Clear();
            richTextBox1.Clear();
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
