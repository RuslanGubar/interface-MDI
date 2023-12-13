using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace лаба_8_часть_2
{
    public partial class noteForm : Form
    {
        private string fileName = "";
        public static int countNotes;
        public noteForm()
        {
            InitializeComponent();
        }

        private void noteForm_Load(object sender, EventArgs e)
        {

        }
        public void NewNote()
        {
            countNotes++; 
            Text = "Новая заметка " + countNotes.ToString();
        }

        public bool OpenNote()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
            openFileDialog1.FileName.Length > 0)
            {
                fileName = openFileDialog1.FileName; 
                try
                {
                    rtbNote.LoadFile(fileName, RichTextBoxStreamType.RichText);
                    Text = Path.GetFileNameWithoutExtension(fileName);
                    return true; 
                }
                catch (ArgumentException ex) 
                {
                    rtbNote.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    return true;
                }
                catch (IOException ex) 
                {
                    MessageBox.Show("Не удалось открыть файл" + ex.ToString(), "Ошибка");
                    return false;
                }
            }
            else 
                return false; 
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
saveFileDialog1.FileName.Length > 0)
            {
                fileName = saveFileDialog1.FileName; 
                try
                {
                    if (saveFileDialog1.FilterIndex == 2) 
                    {
                        rtbNote.SaveFile(fileName);
                    }
                    else 
                    {
                        rtbNote.SaveFile(fileName,
                        RichTextBoxStreamType.PlainText);
                    }
                    Text = Path.GetFileNameWithoutExtension(fileName);
                    countNotes--;
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить", "Ошибка");
                    return;
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (fileName != "") 
            {
                try
                {
                    File.Delete(fileName);
                    Close(); 
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить", "Ошибка");
                    return;
                }
            }
        }
        
        //4 задание
        private void tsbFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbNote.Font = fontDialog1.Font;
            }
        }
        

    }
}
