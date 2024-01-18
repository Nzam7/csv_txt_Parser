
namespace LIS_Parser
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Setup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_1 = new System.Windows.Forms.TableLayoutPanel();
            this.Excel_Step01_SetFolder = new System.Windows.Forms.Button();
            this.Excel_Step01_Folder = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxCSV = new System.Windows.Forms.CheckBox();
            this.checkBoxTXT = new System.Windows.Forms.CheckBox();
            this.filetype = new System.Windows.Forms.Label();
            this.Mapping = new System.Windows.Forms.TabPage();
            this.Upload = new System.Windows.Forms.TabPage();
            this.delimitertype = new System.Windows.Forms.Label();
            this.checkBoxTab = new System.Windows.Forms.CheckBox();
            this.checkBoxPipe = new System.Windows.Forms.CheckBox();
            this.checkBoxComma = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Setup.SuspendLayout();
            this.tableLayoutPanel_1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Mapping.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Setup);
            this.tabControl1.Controls.Add(this.Mapping);
            this.tabControl1.Controls.Add(this.Upload);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1696, 1080);
            this.tabControl1.TabIndex = 0;
            // 
            // Setup
            // 
            this.Setup.Controls.Add(this.tableLayoutPanel_1);
            this.Setup.Location = new System.Drawing.Point(8, 39);
            this.Setup.Name = "Setup";
            this.Setup.Padding = new System.Windows.Forms.Padding(3);
            this.Setup.Size = new System.Drawing.Size(1680, 1033);
            this.Setup.TabIndex = 0;
            this.Setup.Text = "Setup";
            this.Setup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_1
            // 
            this.tableLayoutPanel_1.ColumnCount = 2;
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1076F));
            this.tableLayoutPanel_1.Controls.Add(this.Excel_Step01_SetFolder, 0, 0);
            this.tableLayoutPanel_1.Controls.Add(this.Excel_Step01_Folder, 1, 0);
            this.tableLayoutPanel_1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel_1.Controls.Add(this.filetype, 0, 1);
            this.tableLayoutPanel_1.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel_1.Controls.Add(this.delimitertype, 0, 2);
            this.tableLayoutPanel_1.Location = new System.Drawing.Point(28, 90);
            this.tableLayoutPanel_1.Name = "tableLayoutPanel_1";
            this.tableLayoutPanel_1.RowCount = 4;
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.28249F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_1.Size = new System.Drawing.Size(1506, 581);
            this.tableLayoutPanel_1.TabIndex = 0;
            this.tableLayoutPanel_1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Excel_Step01_SetFolder
            // 
            this.Excel_Step01_SetFolder.Location = new System.Drawing.Point(3, 3);
            this.Excel_Step01_SetFolder.Name = "Excel_Step01_SetFolder";
            this.Excel_Step01_SetFolder.Size = new System.Drawing.Size(424, 48);
            this.Excel_Step01_SetFolder.TabIndex = 0;
            this.Excel_Step01_SetFolder.Text = "Set Input Folder";
            this.Excel_Step01_SetFolder.UseVisualStyleBackColor = true;
            this.Excel_Step01_SetFolder.Click += new System.EventHandler(this.Excel_Step01_SetFolder_Click);
            // 
            // Excel_Step01_Folder
            // 
            this.Excel_Step01_Folder.Location = new System.Drawing.Point(433, 3);
            this.Excel_Step01_Folder.Name = "Excel_Step01_Folder";
            this.Excel_Step01_Folder.Size = new System.Drawing.Size(1055, 31);
            this.Excel_Step01_Folder.TabIndex = 1;
            this.Excel_Step01_Folder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxCSV, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxTXT, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(433, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1066, 118);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // checkBoxCSV
            // 
            this.checkBoxCSV.AutoSize = true;
            this.checkBoxCSV.Location = new System.Drawing.Point(3, 23);
            this.checkBoxCSV.Name = "checkBoxCSV";
            this.checkBoxCSV.Size = new System.Drawing.Size(87, 29);
            this.checkBoxCSV.TabIndex = 0;
            this.checkBoxCSV.Text = "CSV";
            this.checkBoxCSV.UseVisualStyleBackColor = true;
            this.checkBoxCSV.CheckedChanged += new System.EventHandler(this.checkBoxCSV_CheckedChanged);
            // 
            // checkBoxTXT
            // 
            this.checkBoxTXT.AutoSize = true;
            this.checkBoxTXT.Location = new System.Drawing.Point(3, 60);
            this.checkBoxTXT.Name = "checkBoxTXT";
            this.checkBoxTXT.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.checkBoxTXT.Size = new System.Drawing.Size(84, 39);
            this.checkBoxTXT.TabIndex = 1;
            this.checkBoxTXT.Text = "TXT";
            this.checkBoxTXT.UseVisualStyleBackColor = true;
            this.checkBoxTXT.CheckedChanged += new System.EventHandler(this.checkBoxTXT_CheckedChanged);
            // 
            // filetype
            // 
            this.filetype.AutoSize = true;
            this.filetype.Location = new System.Drawing.Point(3, 79);
            this.filetype.Name = "filetype";
            this.filetype.Padding = new System.Windows.Forms.Padding(4, 20, 0, 0);
            this.filetype.Size = new System.Drawing.Size(105, 45);
            this.filetype.TabIndex = 3;
            this.filetype.Text = "File Type";
            // 
            // Mapping
            // 
            this.Mapping.Controls.Add(this.button1);
            this.Mapping.Controls.Add(this.dataGridView1);
            this.Mapping.Location = new System.Drawing.Point(8, 39);
            this.Mapping.Name = "Mapping";
            this.Mapping.Padding = new System.Windows.Forms.Padding(3);
            this.Mapping.Size = new System.Drawing.Size(1680, 1033);
            this.Mapping.TabIndex = 1;
            this.Mapping.Text = "Mapping";
            this.Mapping.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(8, 39);
            this.Upload.Name = "Upload";
            this.Upload.Padding = new System.Windows.Forms.Padding(3);
            this.Upload.Size = new System.Drawing.Size(1560, 771);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // delimitertype
            // 
            this.delimitertype.AutoSize = true;
            this.delimitertype.Location = new System.Drawing.Point(3, 275);
            this.delimitertype.Name = "delimitertype";
            this.delimitertype.Padding = new System.Windows.Forms.Padding(4, 20, 0, 0);
            this.delimitertype.Size = new System.Drawing.Size(100, 45);
            this.delimitertype.TabIndex = 5;
            this.delimitertype.Text = "Delimiter";
            // 
            // checkBoxTab
            // 
            this.checkBoxTab.AutoSize = true;
            this.checkBoxTab.Location = new System.Drawing.Point(3, 111);
            this.checkBoxTab.Name = "checkBoxTab";
            this.checkBoxTab.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.checkBoxTab.Size = new System.Drawing.Size(125, 39);
            this.checkBoxTab.TabIndex = 2;
            this.checkBoxTab.Text = "Tab ( \\t )";
            this.checkBoxTab.UseVisualStyleBackColor = true;
            this.checkBoxTab.CheckedChanged += new System.EventHandler(this.checkBoxTab_CheckedChanged);
            // 
            // checkBoxPipe
            // 
            this.checkBoxPipe.AutoSize = true;
            this.checkBoxPipe.Location = new System.Drawing.Point(3, 59);
            this.checkBoxPipe.Name = "checkBoxPipe";
            this.checkBoxPipe.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.checkBoxPipe.Size = new System.Drawing.Size(124, 39);
            this.checkBoxPipe.TabIndex = 1;
            this.checkBoxPipe.Text = "Pipe ( | )";
            this.checkBoxPipe.UseVisualStyleBackColor = true;
            this.checkBoxPipe.CheckedChanged += new System.EventHandler(this.checkBoxPipe_CheckedChanged);
            // 
            // checkBoxComma
            // 
            this.checkBoxComma.AutoSize = true;
            this.checkBoxComma.Location = new System.Drawing.Point(3, 13);
            this.checkBoxComma.Name = "checkBoxComma";
            this.checkBoxComma.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.checkBoxComma.Size = new System.Drawing.Size(155, 39);
            this.checkBoxComma.TabIndex = 0;
            this.checkBoxComma.Text = "Comma ( , )";
            this.checkBoxComma.UseVisualStyleBackColor = true;
            this.checkBoxComma.CheckedChanged += new System.EventHandler(this.checkBoxComma_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxComma, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPipe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxTab, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(433, 278);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 170);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1674, 889);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 1104);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "LIS Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Setup.ResumeLayout(false);
            this.tableLayoutPanel_1.ResumeLayout(false);
            this.tableLayoutPanel_1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Mapping.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.TabPage Mapping;
        private System.Windows.Forms.TabPage Upload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_1;
        private System.Windows.Forms.Button Excel_Step01_SetFolder;
        private System.Windows.Forms.TextBox Excel_Step01_Folder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxCSV;
        private System.Windows.Forms.CheckBox checkBoxTXT;
        private System.Windows.Forms.Label filetype;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxComma;
        private System.Windows.Forms.CheckBox checkBoxPipe;
        private System.Windows.Forms.CheckBox checkBoxTab;
        private System.Windows.Forms.Label delimitertype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

