using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuchidoriMaker_GUI
{
    public partial class Form1 : Form
    {
        [DllImport("C:\\Users\\sukai\\Documents\\HuchidoriMakerGUI\\HuchidoriDll\\HuchidoriDll.dll", EntryPoint = "manager")]
        static extern void manager(StringBuilder result, string input, string output, byte red, byte green, byte blue); //DLL���Œ�`���ꂽ�֐�

        private string input = "";
        private string output = "";

        private Color clr = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "�t�@�C����ۑ�����";
            sa.InitialDirectory = @"C:\";
            sa.Filter = "PNG�摜(*.png)|*png";

            //�I�[�v���t�@�C���_�C�A���O��\������
            DialogResult sa_result = sa.ShowDialog();

            if (sa_result == DialogResult.OK)
            {
                //�u�ۑ��v�{�^���������ꂽ���̏���
                output = sa.FileName;  //����Ȋ����Ŏw�肳�ꂽ�t�@�C���̃p�X���擾�ł���
            }
            else if (sa_result == DialogResult.Cancel)
            {
                //�u�L�����Z���v�{�^���܂��́u�~�v�{�^�����I�����ꂽ���̏���
            }

            StringBuilder result = new StringBuilder(256);
            manager(result, input, output, clr.R, clr.G, clr.B);//���̓p�X�A�o�̓p�X�𑗂�A���ʂ�result�ɓ����

            Result.Text = result.ToString();//���x���Ɍ��ʂ�\��
            if (result.ToString().Equals("Result:Success"))
            {
                OutputPath.Text = output;
            }

            sa.Dispose();
        }


        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBox1.Text = file[0];
            input = file[0];
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "�t�@�C�����J��";  //�_�C�A���O��
            od.InitialDirectory = @"C:\";  //�����t�H���_
            od.Filter = "PNG�摜(*.png)|*png";

            // �_�C�A���O��\������
            DialogResult result = od.ShowDialog();


            // �I����̔���
            if (result == DialogResult.OK)
            {
                //�u�J���v�{�^���N���b�N���̏���
                input = od.FileName;  //����őI�������t�@�C���p�X���擾�ł���
                textBox1.Text = input;
            }
            else if (result == DialogResult.Cancel)
            {
                //�u�L�����Z���v�{�^���N���b�N���̏���
            }

            od.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                ColorDialog dlg = new ColorDialog();

                //�f�t�H���g�J���[��ݒ�
                dlg.Color = clr;

                //�_�C�A���O��\������
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    //OK�ȊO�i���̏ꍇ�L�����Z���j���N���b�N���ꂽ�ꍇ�A������������������
                    return;
                }
                //�I�������F���擾
                clr = dlg.Color;

                label1.ForeColor = clr;

                dlg.Dispose();
            }
        }
    }
}
