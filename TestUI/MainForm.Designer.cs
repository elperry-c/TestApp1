
namespace TestUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.graph1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.emgLabel = new System.Windows.Forms.Label();
            this.fftLabel = new System.Windows.Forms.Label();
            this.graph2 = new System.Windows.Forms.PictureBox();
            this.emgAxisX = new System.Windows.Forms.Label();
            this.fftAxisX = new System.Windows.Forms.Label();
            this.predictionText1 = new System.Windows.Forms.Label();
            this.predictionTextl2 = new System.Windows.Forms.Label();
            this.predictionResultValue1 = new System.Windows.Forms.Label();
            this.predictionResultValue2 = new System.Windows.Forms.Label();
            this.blueLegendLabel1 = new System.Windows.Forms.Label();
            this.yellowLegendLabel1 = new System.Windows.Forms.Label();
            this.yellowLegendLabel2 = new System.Windows.Forms.Label();
            this.blueLegendLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph2)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM8";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // graph1
            // 
            this.graph1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.graph1.Location = new System.Drawing.Point(86, 344);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(576, 306);
            this.graph1.TabIndex = 0;
            this.graph1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(98, 719);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 45);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(563, 709);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 48);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "OFF";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(323, 719);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(104, 45);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // emgLabel
            // 
            this.emgLabel.AutoSize = true;
            this.emgLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.emgLabel.Location = new System.Drawing.Point(332, 296);
            this.emgLabel.Name = "emgLabel";
            this.emgLabel.Size = new System.Drawing.Size(95, 48);
            this.emgLabel.TabIndex = 7;
            this.emgLabel.Text = "EMG";
            this.emgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fftLabel
            // 
            this.fftLabel.AutoSize = true;
            this.fftLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.fftLabel.Location = new System.Drawing.Point(986, 296);
            this.fftLabel.Name = "fftLabel";
            this.fftLabel.Size = new System.Drawing.Size(75, 48);
            this.fftLabel.TabIndex = 9;
            this.fftLabel.Text = "FFT";
            this.fftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graph2
            // 
            this.graph2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.graph2.Location = new System.Drawing.Point(736, 344);
            this.graph2.Name = "graph2";
            this.graph2.Size = new System.Drawing.Size(576, 306);
            this.graph2.TabIndex = 8;
            this.graph2.TabStop = false;
            // 
            // emgAxisX
            // 
            this.emgAxisX.AutoSize = true;
            this.emgAxisX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emgAxisX.Location = new System.Drawing.Point(341, 653);
            this.emgAxisX.Name = "emgAxisX";
            this.emgAxisX.Size = new System.Drawing.Size(63, 32);
            this.emgAxisX.TabIndex = 10;
            this.emgAxisX.Text = "time";
            this.emgAxisX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fftAxisX
            // 
            this.fftAxisX.AutoSize = true;
            this.fftAxisX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fftAxisX.Location = new System.Drawing.Point(971, 653);
            this.fftAxisX.Name = "fftAxisX";
            this.fftAxisX.Size = new System.Drawing.Size(108, 32);
            this.fftAxisX.TabIndex = 11;
            this.fftAxisX.Text = "freqency";
            this.fftAxisX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictionText1
            // 
            this.predictionText1.AutoSize = true;
            this.predictionText1.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.predictionText1.Location = new System.Drawing.Point(40, 72);
            this.predictionText1.Name = "predictionText1";
            this.predictionText1.Size = new System.Drawing.Size(468, 61);
            this.predictionText1.TabIndex = 12;
            this.predictionText1.Text = "現在の筋肉痛レベル：";
            this.predictionText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictionTextl2
            // 
            this.predictionTextl2.AutoSize = true;
            this.predictionTextl2.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.predictionTextl2.Location = new System.Drawing.Point(90, 180);
            this.predictionTextl2.Name = "predictionTextl2";
            this.predictionTextl2.Size = new System.Drawing.Size(418, 61);
            this.predictionTextl2.TabIndex = 13;
            this.predictionTextl2.Text = "筋肉痛が治るまで：";
            this.predictionTextl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictionResultValue1
            // 
            this.predictionResultValue1.AutoSize = true;
            this.predictionResultValue1.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.predictionResultValue1.Location = new System.Drawing.Point(514, 72);
            this.predictionResultValue1.Name = "predictionResultValue1";
            this.predictionResultValue1.Size = new System.Drawing.Size(87, 61);
            this.predictionResultValue1.TabIndex = 14;
            this.predictionResultValue1.Text = "**";
            this.predictionResultValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.predictionResultValue1.Visible = false;
            // 
            // predictionResultValue2
            // 
            this.predictionResultValue2.AutoSize = true;
            this.predictionResultValue2.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.predictionResultValue2.Location = new System.Drawing.Point(514, 180);
            this.predictionResultValue2.Name = "predictionResultValue2";
            this.predictionResultValue2.Size = new System.Drawing.Size(87, 61);
            this.predictionResultValue2.TabIndex = 15;
            this.predictionResultValue2.Text = "**";
            this.predictionResultValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.predictionResultValue2.Visible = false;
            // 
            // blueLegendLabel1
            // 
            this.blueLegendLabel1.AutoSize = true;
            this.blueLegendLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueLegendLabel1.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLegendLabel1.ForeColor = System.Drawing.Color.White;
            this.blueLegendLabel1.Location = new System.Drawing.Point(563, 357);
            this.blueLegendLabel1.Name = "blueLegendLabel1";
            this.blueLegendLabel1.Size = new System.Drawing.Size(92, 46);
            this.blueLegendLabel1.TabIndex = 16;
            this.blueLegendLabel1.Text = "前腕";
            this.blueLegendLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowLegendLabel1
            // 
            this.yellowLegendLabel1.AutoSize = true;
            this.yellowLegendLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yellowLegendLabel1.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLegendLabel1.ForeColor = System.Drawing.Color.Black;
            this.yellowLegendLabel1.Location = new System.Drawing.Point(456, 357);
            this.yellowLegendLabel1.Name = "yellowLegendLabel1";
            this.yellowLegendLabel1.Size = new System.Drawing.Size(92, 46);
            this.yellowLegendLabel1.TabIndex = 17;
            this.yellowLegendLabel1.Text = "上腕";
            this.yellowLegendLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowLegendLabel2
            // 
            this.yellowLegendLabel2.AutoSize = true;
            this.yellowLegendLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yellowLegendLabel2.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLegendLabel2.ForeColor = System.Drawing.Color.Black;
            this.yellowLegendLabel2.Location = new System.Drawing.Point(1100, 357);
            this.yellowLegendLabel2.Name = "yellowLegendLabel2";
            this.yellowLegendLabel2.Size = new System.Drawing.Size(92, 46);
            this.yellowLegendLabel2.TabIndex = 18;
            this.yellowLegendLabel2.Text = "上腕";
            this.yellowLegendLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLegendLabel2
            // 
            this.blueLegendLabel2.AutoSize = true;
            this.blueLegendLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueLegendLabel2.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLegendLabel2.ForeColor = System.Drawing.Color.White;
            this.blueLegendLabel2.Location = new System.Drawing.Point(1212, 357);
            this.blueLegendLabel2.Name = "blueLegendLabel2";
            this.blueLegendLabel2.Size = new System.Drawing.Size(92, 46);
            this.blueLegendLabel2.TabIndex = 19;
            this.blueLegendLabel2.Text = "前腕";
            this.blueLegendLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(603, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "**";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(529, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "**";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1486, 788);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predictionResultValue2);
            this.Controls.Add(this.predictionResultValue1);
            this.Controls.Add(this.predictionTextl2);
            this.Controls.Add(this.predictionText1);
            this.Controls.Add(this.blueLegendLabel2);
            this.Controls.Add(this.yellowLegendLabel2);
            this.Controls.Add(this.yellowLegendLabel1);
            this.Controls.Add(this.blueLegendLabel1);
            this.Controls.Add(this.fftAxisX);
            this.Controls.Add(this.emgAxisX);
            this.Controls.Add(this.fftLabel);
            this.Controls.Add(this.graph2);
            this.Controls.Add(this.emgLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.graph1);
            this.Name = "MainForm";
            this.Text = "DOMSAP App";
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox graph1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label emgLabel;
        private System.Windows.Forms.Label fftLabel;
        private System.Windows.Forms.PictureBox graph2;
        private System.Windows.Forms.Label emgAxisX;
        private System.Windows.Forms.Label fftAxisX;
        private System.Windows.Forms.Label predictionText1;
        private System.Windows.Forms.Label predictionTextl2;
        private System.Windows.Forms.Label predictionResultValue1;
        private System.Windows.Forms.Label predictionResultValue2;
        private System.Windows.Forms.Label blueLegendLabel1;
        private System.Windows.Forms.Label yellowLegendLabel1;
        private System.Windows.Forms.Label yellowLegendLabel2;
        private System.Windows.Forms.Label blueLegendLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

