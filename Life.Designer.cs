
namespace lab_1
{
    partial class Screen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.BluBut = new System.Windows.Forms.Button();
            this.RedBut = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Race = new System.Windows.Forms.Label();
            this.MapIsLife = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapIsLife)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.IsSplitterFixed = true;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AutoScroll = true;
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.Gold;
            this.SplitContainer.Panel1.Controls.Add(this.BluBut);
            this.SplitContainer.Panel1.Controls.Add(this.RedBut);
            this.SplitContainer.Panel1.Controls.Add(this.Continue);
            this.SplitContainer.Panel1.Controls.Add(this.Stop);
            this.SplitContainer.Panel1.Controls.Add(this.Race);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.AllowDrop = true;
            this.SplitContainer.Panel2.Controls.Add(this.MapIsLife);
            this.SplitContainer.Size = new System.Drawing.Size(1045, 581);
            this.SplitContainer.SplitterDistance = 193;
            this.SplitContainer.SplitterWidth = 5;
            this.SplitContainer.TabIndex = 1;
            // 
            // BluBut
            // 
            this.BluBut.BackColor = System.Drawing.Color.Blue;
            this.BluBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BluBut.FlatAppearance.BorderSize = 5;
            this.BluBut.Location = new System.Drawing.Point(28, 167);
            this.BluBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BluBut.Name = "BluBut";
            this.BluBut.Size = new System.Drawing.Size(147, 53);
            this.BluBut.TabIndex = 8;
            this.BluBut.Text = "Синий";
            this.BluBut.UseVisualStyleBackColor = false;
            this.BluBut.Click += new System.EventHandler(this.button4_Click);
            // 
            // RedBut
            // 
            this.RedBut.BackColor = System.Drawing.Color.Red;
            this.RedBut.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.RedBut.FlatAppearance.BorderSize = 5;
            this.RedBut.Location = new System.Drawing.Point(28, 228);
            this.RedBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RedBut.Name = "RedBut";
            this.RedBut.Size = new System.Drawing.Size(147, 53);
            this.RedBut.TabIndex = 7;
            this.RedBut.Text = "Красный";
            this.RedBut.UseVisualStyleBackColor = false;
            this.RedBut.Click += new System.EventHandler(this.button3_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Lime;
            this.Continue.Location = new System.Drawing.Point(13, 98);
            this.Continue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(173, 41);
            this.Continue.TabIndex = 6;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Stop.Location = new System.Drawing.Point(13, 513);
            this.Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(173, 42);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Остоновка";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Race
            // 
            this.Race.AutoSize = true;
            this.Race.Location = new System.Drawing.Point(57, 44);
            this.Race.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(61, 16);
            this.Race.TabIndex = 4;
            this.Race.Text = "Время: 0";
            // 
            // MapIsLife
            // 
            this.MapIsLife.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapIsLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapIsLife.Location = new System.Drawing.Point(0, 0);
            this.MapIsLife.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MapIsLife.Name = "MapIsLife";
            this.MapIsLife.RowHeadersWidth = 51;
            this.MapIsLife.Size = new System.Drawing.Size(847, 581);
            this.MapIsLife.TabIndex = 0;
            this.MapIsLife.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PoleLife_CellClick);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 581);
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Screen";
            this.Text = "Игра \"Жизнь\"";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapIsLife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridView MapIsLife;
        private System.Windows.Forms.Label Race;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button BluBut;
        private System.Windows.Forms.Button RedBut;
    }
}

