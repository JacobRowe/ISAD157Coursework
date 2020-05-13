namespace SOFT562Week18
{
    partial class DatabaseForm
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewOther = new System.Windows.Forms.DataGridView();
            this.comboBoxQueryChoice = new System.Windows.Forms.ComboBox();
            this.dataGridViewFreindInfo = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataLabelUser = new System.Windows.Forms.TextBox();
            this.dataLabelInfo = new System.Windows.Forms.TextBox();
            this.dataLabelFreinds = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreindInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(17, 38);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(579, 585);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // dataGridViewOther
            // 
            this.dataGridViewOther.AllowUserToAddRows = false;
            this.dataGridViewOther.AllowUserToDeleteRows = false;
            this.dataGridViewOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOther.Location = new System.Drawing.Point(609, 38);
            this.dataGridViewOther.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOther.Name = "dataGridViewOther";
            this.dataGridViewOther.RowHeadersWidth = 51;
            this.dataGridViewOther.RowTemplate.Height = 24;
            this.dataGridViewOther.Size = new System.Drawing.Size(463, 585);
            this.dataGridViewOther.TabIndex = 1;
            // 
            // comboBoxQueryChoice
            // 
            this.comboBoxQueryChoice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQueryChoice.FormattingEnabled = true;
            this.comboBoxQueryChoice.Items.AddRange(new object[] {
            "Freindships",
            "WorkPlace",
            "School",
            "Messages"});
            this.comboBoxQueryChoice.Location = new System.Drawing.Point(253, 628);
            this.comboBoxQueryChoice.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxQueryChoice.Name = "comboBoxQueryChoice";
            this.comboBoxQueryChoice.Size = new System.Drawing.Size(569, 29);
            this.comboBoxQueryChoice.TabIndex = 2;
            this.comboBoxQueryChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueryChoice_SelectedIndexChanged);
            // 
            // dataGridViewFreindInfo
            // 
            this.dataGridViewFreindInfo.AllowUserToAddRows = false;
            this.dataGridViewFreindInfo.AllowUserToDeleteRows = false;
            this.dataGridViewFreindInfo.AllowUserToOrderColumns = true;
            this.dataGridViewFreindInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreindInfo.Location = new System.Drawing.Point(1070, 38);
            this.dataGridViewFreindInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFreindInfo.Name = "dataGridViewFreindInfo";
            this.dataGridViewFreindInfo.RowHeadersWidth = 51;
            this.dataGridViewFreindInfo.RowTemplate.Height = 24;
            this.dataGridViewFreindInfo.Size = new System.Drawing.Size(311, 585);
            this.dataGridViewFreindInfo.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(840, 634);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Change user, and select info again to update datagrids";
            // 
            // dataLabelUser
            // 
            this.dataLabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabelUser.Location = new System.Drawing.Point(17, 8);
            this.dataLabelUser.Name = "dataLabelUser";
            this.dataLabelUser.Size = new System.Drawing.Size(68, 27);
            this.dataLabelUser.TabIndex = 5;
            this.dataLabelUser.Text = "USERS";
            // 
            // dataLabelInfo
            // 
            this.dataLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabelInfo.Location = new System.Drawing.Point(609, 8);
            this.dataLabelInfo.Name = "dataLabelInfo";
            this.dataLabelInfo.Size = new System.Drawing.Size(50, 27);
            this.dataLabelInfo.TabIndex = 6;
            this.dataLabelInfo.Text = "INFO";
            // 
            // dataLabelFreinds
            // 
            this.dataLabelFreinds.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabelFreinds.Location = new System.Drawing.Point(1070, 8);
            this.dataLabelFreinds.Name = "dataLabelFreinds";
            this.dataLabelFreinds.Size = new System.Drawing.Size(86, 27);
            this.dataLabelFreinds.TabIndex = 7;
            this.dataLabelFreinds.Text = "FREINDS";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(153, 631);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "INFO SELECT";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1400, 660);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataLabelFreinds);
            this.Controls.Add(this.dataLabelInfo);
            this.Controls.Add(this.dataLabelUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewFreindInfo);
            this.Controls.Add(this.comboBoxQueryChoice);
            this.Controls.Add(this.dataGridViewOther);
            this.Controls.Add(this.dataGridViewUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseForm";
            this.Text = "Facebook User Data Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreindInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewOther;
        private System.Windows.Forms.ComboBox comboBoxQueryChoice;
        private System.Windows.Forms.DataGridView dataGridViewFreindInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox dataLabelUser;
        private System.Windows.Forms.TextBox dataLabelInfo;
        private System.Windows.Forms.TextBox dataLabelFreinds;
        private System.Windows.Forms.TextBox textBox2;
    }
}

