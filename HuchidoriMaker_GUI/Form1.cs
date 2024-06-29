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
        static extern void manager(StringBuilder result, string input, string output, byte red, byte green, byte blue); //DLL内で定義された関数

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
            sa.Title = "ファイルを保存する";
            sa.InitialDirectory = @"C:\";
            sa.Filter = "PNG画像(*.png)|*png";

            //オープンファイルダイアログを表示する
            DialogResult sa_result = sa.ShowDialog();

            if (sa_result == DialogResult.OK)
            {
                //「保存」ボタンが押された時の処理
                output = sa.FileName;  //こんな感じで指定されたファイルのパスが取得できる
            }
            else if (sa_result == DialogResult.Cancel)
            {
                //「キャンセル」ボタンまたは「×」ボタンが選択された時の処理
            }

            StringBuilder result = new StringBuilder(256);
            manager(result, input, output, clr.R, clr.G, clr.B);//入力パス、出力パスを送り、結果をresultに入れる

            Result.Text = result.ToString();//ラベルに結果を表示
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
            od.Title = "ファイルを開く";  //ダイアログ名
            od.InitialDirectory = @"C:\";  //初期フォルダ
            od.Filter = "PNG画像(*.png)|*png";

            // ダイアログを表示する
            DialogResult result = od.ShowDialog();


            // 選択後の判定
            if (result == DialogResult.OK)
            {
                //「開く」ボタンクリック時の処理
                input = od.FileName;  //これで選択したファイルパスを取得できる
                textBox1.Text = input;
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」ボタンクリック時の処理
            }

            od.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                ColorDialog dlg = new ColorDialog();

                //デフォルトカラーを設定
                dlg.Color = clr;

                //ダイアログを表示する
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    //OK以外（この場合キャンセル）がクリックされた場合、何も処理せず抜ける
                    return;
                }
                //選択した色を取得
                clr = dlg.Color;

                label1.ForeColor = clr;

                dlg.Dispose();
            }
        }
    }
}
