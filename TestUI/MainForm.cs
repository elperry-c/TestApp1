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
using MathNet.Numerics.Statistics; // NuGetパッケージの管理

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

        ///////////////////////////////////////////////////////
        //センサデータ取得
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

                        // グラフに表示
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

            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
