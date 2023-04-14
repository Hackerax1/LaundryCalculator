namespace LaundryCalculator
{
    partial class LaundryCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaundryCalculator));
            this.calculateButton = new System.Windows.Forms.Button();
            this.dryTime = new System.Windows.Forms.TextBox();
            this.washTime = new System.Windows.Forms.TextBox();
            this.endtimeTextbox = new System.Windows.Forms.TextBox();
            this.washerCount = new System.Windows.Forms.NumericUpDown();
            this.dryerCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTimeTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.washerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dryerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(199, 217);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // dryTime
            // 
            this.dryTime.Location = new System.Drawing.Point(35, 114);
            this.dryTime.Name = "dryTime";
            this.dryTime.Size = new System.Drawing.Size(100, 20);
            this.dryTime.TabIndex = 2;
            // 
            // washTime
            // 
            this.washTime.Location = new System.Drawing.Point(35, 58);
            this.washTime.Name = "washTime";
            this.washTime.Size = new System.Drawing.Size(100, 20);
            this.washTime.TabIndex = 1;
            // 
            // endtimeTextbox
            // 
            this.endtimeTextbox.Location = new System.Drawing.Point(199, 111);
            this.endtimeTextbox.Name = "endtimeTextbox";
            this.endtimeTextbox.Size = new System.Drawing.Size(100, 20);
            this.endtimeTextbox.TabIndex = 10;
            this.endtimeTextbox.TabStop = false;
            // 
            // washerCount
            // 
            this.washerCount.Location = new System.Drawing.Point(35, 217);
            this.washerCount.Name = "washerCount";
            this.washerCount.Size = new System.Drawing.Size(52, 20);
            this.washerCount.TabIndex = 4;
            // 
            // dryerCount
            // 
            this.dryerCount.Location = new System.Drawing.Point(35, 264);
            this.dryerCount.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dryerCount.Name = "dryerCount";
            this.dryerCount.Size = new System.Drawing.Size(52, 20);
            this.dryerCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dryer Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Washer Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Loads";
            // 
            // loadCount
            // 
            this.loadCount.Location = new System.Drawing.Point(35, 175);
            this.loadCount.Name = "loadCount";
            this.loadCount.Size = new System.Drawing.Size(52, 20);
            this.loadCount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time to Wash (In Minutes)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Time to Dry (In Minutes)";
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "\"hh:mm\"";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(199, 58);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(82, 20);
            this.startTime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Start Time";
            // 
            // totalTimeTextbox
            // 
            this.totalTimeTextbox.Location = new System.Drawing.Point(199, 174);
            this.totalTimeTextbox.Name = "totalTimeTextbox";
            this.totalTimeTextbox.Size = new System.Drawing.Size(142, 20);
            this.totalTimeTextbox.TabIndex = 16;
            this.totalTimeTextbox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "End Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Time";
            // 
            // LaundryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 334);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalTimeTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dryerCount);
            this.Controls.Add(this.washerCount);
            this.Controls.Add(this.endtimeTextbox);
            this.Controls.Add(this.washTime);
            this.Controls.Add(this.dryTime);
            this.Controls.Add(this.calculateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LaundryCalculator";
            this.Text = "Laundry Calculator";
            this.Load += new System.EventHandler(this.LaundryCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.washerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dryerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox dryTime;
        private System.Windows.Forms.TextBox washTime;
        private System.Windows.Forms.TextBox endtimeTextbox;
        private System.Windows.Forms.NumericUpDown washerCount;
        private System.Windows.Forms.NumericUpDown dryerCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown loadCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTimeTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

