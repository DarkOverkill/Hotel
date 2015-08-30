namespace Hotel.DesktopUI
{
    partial class MainForm
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
            this._btnRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox_AvailableRooms = new System.Windows.Forms.ListBox();
            this.datePicker_arraive = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker_departure = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxGuest = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnRegister
            // 
            this._btnRegister.Location = new System.Drawing.Point(385, 427);
            this._btnRegister.Name = "_btnRegister";
            this._btnRegister.Size = new System.Drawing.Size(75, 23);
            this._btnRegister.TabIndex = 0;
            this._btnRegister.Text = "Register";
            this._btnRegister.UseVisualStyleBackColor = true;
            this._btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 165);
            this.dataGridView1.TabIndex = 1;
            // 
            // listBox_AvailableRooms
            // 
            this.listBox_AvailableRooms.DisplayMember = "Number";
            this.listBox_AvailableRooms.FormattingEnabled = true;
            this.listBox_AvailableRooms.Location = new System.Drawing.Point(17, 225);
            this.listBox_AvailableRooms.Name = "listBox_AvailableRooms";
            this.listBox_AvailableRooms.Size = new System.Drawing.Size(74, 134);
            this.listBox_AvailableRooms.TabIndex = 2;
            this.listBox_AvailableRooms.ValueMember = "Id";
            // 
            // datePicker_arraive
            // 
            this.datePicker_arraive.Location = new System.Drawing.Point(260, 254);
            this.datePicker_arraive.Name = "datePicker_arraive";
            this.datePicker_arraive.Size = new System.Drawing.Size(200, 20);
            this.datePicker_arraive.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available rooms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arraive date:";
            // 
            // datePicker_departure
            // 
            this.datePicker_departure.Location = new System.Drawing.Point(260, 286);
            this.datePicker_departure.Name = "datePicker_departure";
            this.datePicker_departure.Size = new System.Drawing.Size(200, 20);
            this.datePicker_departure.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(133, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departure date:";
            // 
            // ComboBoxGuest
            // 
            this.ComboBoxGuest.FormattingEnabled = true;
            this.ComboBoxGuest.Location = new System.Drawing.Point(137, 427);
            this.ComboBoxGuest.Name = "ComboBoxGuest";
            this.ComboBoxGuest.Size = new System.Drawing.Size(227, 21);
            this.ComboBoxGuest.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(74, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Guest:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 462);
            this.Controls.Add(this.ComboBoxGuest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker_departure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker_arraive);
            this.Controls.Add(this.listBox_AvailableRooms);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._btnRegister);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnRegister;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox_AvailableRooms;
        private System.Windows.Forms.DateTimePicker datePicker_arraive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker_departure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxGuest;
        private System.Windows.Forms.Label label4;
    }
}

