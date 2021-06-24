using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Numerics;
// [ツール]>>[NuGetパッケージマネージャ]>>[ソリューションの...管理]からMathNet.Numericsをインストール
using MathNet.Numerics;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.IntegralTransforms;

namespace TestUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ArrayList timeList = new ArrayList();
        ArrayList emg_1chList = new ArrayList();
        ArrayList emg_2chList = new ArrayList();
        ArrayList emg_3chList = new ArrayList();
        ArrayList emg_4chList = new ArrayList();
        int first_t = 0;

        DateTime dtNow = DateTime.Now;


        /// センサデータ取得
        /// ////////////////////////////////////////////////
        delegate void setfocus();
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int time, emg_1ch, emg_2ch, emg_3ch, emg_4ch; // int型のデータ

            byte[] readdata = new byte[25]; // シリアルポートから1Byteごと値を取ってきてここに入れる．

            // byte型のデータ
            byte[] Btime = new byte[4];
            // 拡張 16bitAD 計測データ (筋電値)
            byte[] Bemg_1ch = new byte[2];
            byte[] Bemg_2ch = new byte[2];
            byte[] Bemg_3ch = new byte[2];
            byte[] Bemg_4ch = new byte[2];

            while (serialPort.BytesToRead > 8)
            {
                readdata[0] = (byte)serialPort.ReadByte();
                if (readdata[0] == 0x9A) // Header: プロトコルの先頭
                {
                    readdata[1] = (byte)serialPort.ReadByte();
                    if (readdata[1] == 0x8C) // コマンドの種類を表すコード　0x8Cは外部拡張端子計測データ通知
                    {
                        for (int i=0; i<4; i++) //ticktime[4Byte] 計測年月日の00:00:00:000からの経過時間(ms単位)
                        {
                            Btime[i] = (byte)serialPort.ReadByte();
                        }
                        setByte(Bemg_1ch);
                        setByte(Bemg_2ch);
                        setByte(Bemg_3ch);
                        setByte(Bemg_4ch);

                        // 時間データをbyte型からint型へ
                        if (timeList.Count > 0)
                            time = BitConverter.ToInt32(Btime, 0) - first_t;
                        else
                        {
                            first_t = BitConverter.ToInt32(Btime, 0);
                            time = 0;
                        }

                        // 筋電値をbyte型からint型へ
                        emg_1ch = BitConverter.ToInt16(Bemg_1ch, 0);
                        emg_2ch = BitConverter.ToInt16(Bemg_2ch, 0);
                        emg_3ch = BitConverter.ToInt16(Bemg_3ch, 0);
                        emg_4ch = BitConverter.ToInt16(Bemg_4ch, 0);

                        // リストに追加
                        timeList.Add(time);
                        emg_1chList.Add(emg_1ch);
                        emg_2chList.Add(emg_2ch);
                        emg_3chList.Add(emg_3ch);
                        emg_4chList.Add(emg_4ch);

                        // グラフ表示
                        Invoke((setfocus)delegate ()
                        {
                            MakeGraphicsEMG((short)emg_1ch, (short)emg_2ch);
                        });
                        break;
                    }
                    else if (readdata[1] == 0x93) // 計測時刻応答
                    {
                        for (int i=2; i<15; i++)
                        {

                        }
                    }
                }
            }
        }

        // setByteメソッド（筋電ver）
        private void setByte(byte[] bt)
        {
            for (int i = 0; i < 2; i++)//筋電は1回の計測値あたり2バイトで表現される
            {
                bt[i] = (byte)serialPort.ReadByte();
            }
        }


        /// ボタンクリック
        /// ////////////////////////////////////////////////
        int openflag = 0;
        int restart = 0;

        // startボタン
        private void startButton_Click(object sender, EventArgs e)
        {
            openflag = 0;
            restart = 0;
            try
            {
                statusLabel.Text = "ON";
                if (restart == 0)
                {
                    serialPort.Close();
                    serialPort.Open();
                    openflag++;
                    send_command("9A 13 00 00 01 01 00 00 00 00 00 01 01 00 00 00");//計測開始，終了時刻の設定
                }
                else if (restart != 0)
                {
                    send_command("9A 13 00 00 01 01 00 00 00 00 00 01 01 00 00 00");
                    restart = 0;
                    openflag++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("センサの電源が入っているか確認してください．");
            }
        }

        // stopボタン
        private void stopButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "OFF";
            if(openflag == 0)
            {
                MessageBox.Show("接続されていません", "エラー");
            }
            else
            {
                send_command("9A 15 00");
                openflag = 0;
                restart++;
            }
        }


        /// コマンド送信関連
        /// ////////////////////////////////////////////////
        // コマンド送信
        private void send_command(string str)
        {
            string[] hexValueSplit = (get_bcc(str)).Split(' ');
            byte[] binary = new byte[hexValueSplit.Length];

            for (int i = 0; i < hexValueSplit.Length; i++)
            {
                binary[i] = Convert.ToByte(hexValueSplit[i], 16);
            }
            serialPort.Write(binary, 0, binary.Length);
        }

        // 16進文字列にbcc付加して返す
        private string get_bcc(string str)
        {
            byte[] bcc = new byte[1];
            bcc[0] = 0;
            string[] value = str.Split(null as string[], 30, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < value.Length; i++)
            {
                bcc[0] ^= (Byte)Convert.ToInt32(value[i], 16);
            }
            str += " " + BitConverter.ToString(bcc);
            return str;
        }

        /// グラフの描画の関数
        /// ////////////////////////////////////////////////
        int t_count = 0;        // x座標カウント用
        int DataMax = 50000;    // データ表示上限値
        short pre_y1, pre_y2;       // データ保存用変数

        // 筋電値のグラフ描画
        void MakeGraphicsEMG(short y1, short y2)
        {

            Graphics g1 = graph1.CreateGraphics();

            Pen pen1 = new Pen(Color.DarkOrange, 1);
            Pen pen2 = new Pen(Color.DarkBlue, 1);
            Pen penA = new Pen(Color.Black, 1);

            // 初期描画(y座標線)
            if (t_count == 0)
            {
                g1.DrawLine(penA, 0, Ypoint(DataMax/ 2), graph1.Width, Ypoint(DataMax / 2));

            }

            // グラフ描画
            if (t_count > 0)
            {
                g1.DrawLine(pen1, (t_count - 1) * 2, Ypoint(50000 / 2 + pre_y1 / 2), 2 * t_count, Ypoint(50000 / 2 + y1 / 2));
                g1.DrawLine(pen2, (t_count - 1) * 2, Ypoint(50000 / 2 + pre_y2 / 2), 2 * t_count, Ypoint(50000 / 2 + y2 / 2));
            }

            // 過去データとして保存
            pre_y1 = y1;
            pre_y2 = y2;

            // カウントアップ
            t_count++;

            // 終端処理
            if (t_count == graph1.Width / 2)
            {
                graph1.Image = null;
                t_count = 0;
            }

            //定義破棄
            g1.Dispose();
            pen1.Dispose(); pen2.Dispose();
            penA.Dispose();
        }

        // a: 表示したいデータ値  Ypoint: 表示される座標
        int Ypoint(int a)
        {
            return graph1.Height - (a / (DataMax / graph1.Height));
        }
    }
}
