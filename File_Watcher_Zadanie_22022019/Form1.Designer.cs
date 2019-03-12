namespace File_Watcher_Zadanie_22022019
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1_Folder = new System.Windows.Forms.Label();
            this.tB_PathFolder = new System.Windows.Forms.TextBox();
            this.bt_ChooseFolder = new System.Windows.Forms.Button();
            this.listBox1_Logs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_StatusEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1_Folder
            // 
            this.label1_Folder.AutoSize = true;
            this.label1_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Folder.Location = new System.Drawing.Point(0, 0);
            this.label1_Folder.Name = "label1_Folder";
            this.label1_Folder.Size = new System.Drawing.Size(70, 24);
            this.label1_Folder.TabIndex = 2;
            this.label1_Folder.Text = "Folder:";
            this.label1_Folder.Click += new System.EventHandler(this.label1_Click);
            // 
            // tB_PathFolder
            // 
            this.tB_PathFolder.Location = new System.Drawing.Point(76, 4);
            this.tB_PathFolder.Name = "tB_PathFolder";
            this.tB_PathFolder.Size = new System.Drawing.Size(272, 20);
            this.tB_PathFolder.TabIndex = 3;
            this.tB_PathFolder.Text = "C:\\";
            this.tB_PathFolder.TextChanged += new System.EventHandler(this.tB_PathFolder_TextChanged);
            // 
            // bt_ChooseFolder
            // 
            this.bt_ChooseFolder.Location = new System.Drawing.Point(354, 3);
            this.bt_ChooseFolder.Name = "bt_ChooseFolder";
            this.bt_ChooseFolder.Size = new System.Drawing.Size(112, 23);
            this.bt_ChooseFolder.TabIndex = 4;
            this.bt_ChooseFolder.Text = "Wybierz folder";
            this.bt_ChooseFolder.UseVisualStyleBackColor = true;
            this.bt_ChooseFolder.Click += new System.EventHandler(this.bt_ChooseFolder_Click);
            // 
            // listBox1_Logs
            // 
            this.listBox1_Logs.FormattingEnabled = true;
            this.listBox1_Logs.Location = new System.Drawing.Point(12, 80);
            this.listBox1_Logs.Name = "listBox1_Logs";
            this.listBox1_Logs.Size = new System.Drawing.Size(454, 264);
            this.listBox1_Logs.TabIndex = 5;
            this.listBox1_Logs.SelectedIndexChanged += new System.EventHandler(this.listBox1_Logs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOG FOLDERU";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "STATUS Wiadomośc email";
            // 
            // tB_StatusEmail
            // 
            this.tB_StatusEmail.Location = new System.Drawing.Point(382, 57);
            this.tB_StatusEmail.Name = "tB_StatusEmail";
            this.tB_StatusEmail.Size = new System.Drawing.Size(84, 20);
            this.tB_StatusEmail.TabIndex = 9;
            this.tB_StatusEmail.TextChanged += new System.EventHandler(this.tB_StatusEmail_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 366);
            this.Controls.Add(this.tB_StatusEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_Logs);
            this.Controls.Add(this.bt_ChooseFolder);
            this.Controls.Add(this.tB_PathFolder);
            this.Controls.Add(this.label1_Folder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Monitor Folderu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1_Folder;
        private System.Windows.Forms.TextBox tB_PathFolder;
        private System.Windows.Forms.Button bt_ChooseFolder;
        private System.Windows.Forms.ListBox listBox1_Logs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_StatusEmail;
    }
}

