
namespace Tempar
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bOpen = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.TextAfter = new System.Windows.Forms.TextBox();
            this.TextBefore = new System.Windows.Forms.TextBox();
            this.timeMin = new System.Windows.Forms.TextBox();
            this.minTemp = new System.Windows.Forms.TextBox();
            this.timeMax = new System.Windows.Forms.TextBox();
            this.FishCollection = new System.Windows.Forms.ComboBox();
            this.maxTemp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bOpen);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.bRun);
            this.panel1.Controls.Add(this.TextAfter);
            this.panel1.Controls.Add(this.TextBefore);
            this.panel1.Controls.Add(this.timeMin);
            this.panel1.Controls.Add(this.minTemp);
            this.panel1.Controls.Add(this.timeMax);
            this.panel1.Controls.Add(this.FishCollection);
            this.panel1.Controls.Add(this.maxTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "minTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "maxTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "min";
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(328, 100);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(140, 52);
            this.bOpen.TabIndex = 9;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(328, 158);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(140, 48);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(328, 45);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(140, 49);
            this.bRun.TabIndex = 7;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // TextAfter
            // 
            this.TextAfter.Location = new System.Drawing.Point(486, 18);
            this.TextAfter.Multiline = true;
            this.TextAfter.Name = "TextAfter";
            this.TextAfter.Size = new System.Drawing.Size(302, 253);
            this.TextAfter.TabIndex = 6;
            // 
            // TextBefore
            // 
            this.TextBefore.Location = new System.Drawing.Point(3, 18);
            this.TextBefore.Multiline = true;
            this.TextBefore.Name = "TextBefore";
            this.TextBefore.Size = new System.Drawing.Size(309, 253);
            this.TextBefore.TabIndex = 5;
            // 
            // timeMin
            // 
            this.timeMin.Location = new System.Drawing.Point(242, 335);
            this.timeMin.Name = "timeMin";
            this.timeMin.ReadOnly = true;
            this.timeMin.Size = new System.Drawing.Size(70, 20);
            this.timeMin.TabIndex = 4;
            // 
            // minTemp
            // 
            this.minTemp.Location = new System.Drawing.Point(84, 335);
            this.minTemp.Name = "minTemp";
            this.minTemp.ReadOnly = true;
            this.minTemp.Size = new System.Drawing.Size(70, 20);
            this.minTemp.TabIndex = 3;
            // 
            // timeMax
            // 
            this.timeMax.Location = new System.Drawing.Point(242, 309);
            this.timeMax.Name = "timeMax";
            this.timeMax.ReadOnly = true;
            this.timeMax.Size = new System.Drawing.Size(70, 20);
            this.timeMax.TabIndex = 2;
            // 
            // FishCollection
            // 
            this.FishCollection.FormattingEnabled = true;
            this.FishCollection.Items.AddRange(new object[] {
            "Семга",
            "Минтай"});
            this.FishCollection.Location = new System.Drawing.Point(328, 18);
            this.FishCollection.Name = "FishCollection";
            this.FishCollection.Size = new System.Drawing.Size(140, 21);
            this.FishCollection.TabIndex = 1;
            this.FishCollection.SelectedIndexChanged += new System.EventHandler(this.FishCollection_SelectedIndexChanged);
            // 
            // maxTemp
            // 
            this.maxTemp.Location = new System.Drawing.Point(84, 309);
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.ReadOnly = true;
            this.maxTemp.Size = new System.Drawing.Size(70, 20);
            this.maxTemp.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.TextBox TextAfter;
        private System.Windows.Forms.TextBox TextBefore;
        private System.Windows.Forms.TextBox timeMin;
        private System.Windows.Forms.TextBox minTemp;
        private System.Windows.Forms.TextBox timeMax;
        private System.Windows.Forms.ComboBox FishCollection;
        private System.Windows.Forms.TextBox maxTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

