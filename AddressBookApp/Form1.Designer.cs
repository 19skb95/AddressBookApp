namespace AddressBookApp
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtln = new System.Windows.Forms.TextBox();
            this.txtph = new System.Windows.Forms.TextBox();
            this.emtxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(331, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "First Name";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(442, 48);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(209, 24);
            this.TxtId.TabIndex = 5;
            // 
            // txtfn
            // 
            this.txtfn.BackColor = System.Drawing.SystemColors.Menu;
            this.txtfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.Location = new System.Drawing.Point(442, 96);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(209, 24);
            this.txtfn.TabIndex = 7;
            // 
            // txtln
            // 
            this.txtln.BackColor = System.Drawing.SystemColors.Menu;
            this.txtln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtln.Location = new System.Drawing.Point(442, 150);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(209, 24);
            this.txtln.TabIndex = 8;
            // 
            // txtph
            // 
            this.txtph.BackColor = System.Drawing.SystemColors.Menu;
            this.txtph.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtph.Location = new System.Drawing.Point(442, 244);
            this.txtph.Name = "txtph";
            this.txtph.Size = new System.Drawing.Size(209, 24);
            this.txtph.TabIndex = 9;
            // 
            // emtxt
            // 
            this.emtxt.BackColor = System.Drawing.SystemColors.Menu;
            this.emtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emtxt.Location = new System.Drawing.Point(442, 201);
            this.emtxt.Name = "emtxt";
            this.emtxt.Size = new System.Drawing.Size(209, 24);
            this.emtxt.TabIndex = 10;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(334, 301);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(107, 37);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Insert";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(406, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Browse All Entries";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(491, 301);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(107, 37);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(707, 147);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(107, 37);
            this.findBtn.TabIndex = 15;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(635, 301);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(107, 37);
            this.Deletebtn.TabIndex = 16;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(984, 592);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.emtxt);
            this.Controls.Add(this.txtph);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox fstNameTxt;
        private System.Windows.Forms.TextBox lstNameTxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox phTxt;
        private System.Windows.Forms.Button BtnSbmit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.TextBox txtph;
        private System.Windows.Forms.TextBox emtxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button Deletebtn;
    }
}

