namespace UTC.Calculator
{
    partial class UtcCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.utcLabel = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btnCloseInfo = new System.Windows.Forms.Button();
            this.aboutInfoForm1 = new UTC.Calculator.AboutInfoForm();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(18, 214);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(191, 40);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(643, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 33);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 8, 4, 10, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(414, 51);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // utcLabel
            // 
            this.utcLabel.AutoSize = true;
            this.utcLabel.Location = new System.Drawing.Point(354, 54);
            this.utcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.utcLabel.Name = "utcLabel";
            this.utcLabel.Size = new System.Drawing.Size(50, 25);
            this.utcLabel.TabIndex = 2;
            this.utcLabel.Text = "UTC:";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(18, 104);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(5);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(314, 40);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "Calculate UTC";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 104);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.Location = new System.Drawing.Point(18, 149);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(91, 40);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "result";
            // 
            // btnCloseInfo
            // 
            this.btnCloseInfo.Location = new System.Drawing.Point(508, 216);
            this.btnCloseInfo.Margin = new System.Windows.Forms.Padding(5);
            this.btnCloseInfo.Name = "btnCloseInfo";
            this.btnCloseInfo.Size = new System.Drawing.Size(117, 38);
            this.btnCloseInfo.TabIndex = 6;
            this.btnCloseInfo.Text = "Close";
            this.btnCloseInfo.UseVisualStyleBackColor = true;
            this.btnCloseInfo.Click += new System.EventHandler(this.btnCloseInfo_Click);
            // 
            // aboutInfoForm1
            // 
            this.aboutInfoForm1.Location = new System.Drawing.Point(4, 46);
            this.aboutInfoForm1.Margin = new System.Windows.Forms.Padding(5);
            this.aboutInfoForm1.Name = "aboutInfoForm1";
            this.aboutInfoForm1.Size = new System.Drawing.Size(494, 213);
            this.aboutInfoForm1.TabIndex = 7;
            // 
            // UtcCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 268);
            this.Controls.Add(this.btnCloseInfo);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.utcLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.aboutInfoForm1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 307);
            this.MinimumSize = new System.Drawing.Size(659, 307);
            this.Name = "UtcCalc";
            this.Text = "UTC Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCopy;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label utcLabel;
        private Button btn_calc;
        private Button btnReset;
        private Label lbl_result;
        private Button btnCloseInfo;
        private AboutInfoForm aboutInfoForm1;
    }
}