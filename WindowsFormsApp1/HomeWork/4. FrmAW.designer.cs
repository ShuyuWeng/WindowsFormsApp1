
namespace WindowsFormsApp1.HomeWork
{
    partial class FrmAW
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
            System.Windows.Forms.Label largePhotoLabel;
            this.largePhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productPhotoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.awDataSet1 = new WindowsFormsApp1.AWDataSet();
            this.productPhotoTableAdapter1 = new WindowsFormsApp1.AWDataSetTableAdapters.ProductPhotoTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.AWDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            largePhotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // largePhotoLabel
            // 
            largePhotoLabel.AutoSize = true;
            largePhotoLabel.Location = new System.Drawing.Point(666, 77);
            largePhotoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            largePhotoLabel.Name = "largePhotoLabel";
            largePhotoLabel.Size = new System.Drawing.Size(65, 12);
            largePhotoLabel.TabIndex = 49;
            largePhotoLabel.Text = "Large Photo:";
            // 
            // largePhotoPictureBox
            // 
            this.largePhotoPictureBox.Location = new System.Drawing.Point(668, 101);
            this.largePhotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.largePhotoPictureBox.Name = "largePhotoPictureBox";
            this.largePhotoPictureBox.Size = new System.Drawing.Size(185, 165);
            this.largePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePhotoPictureBox.TabIndex = 51;
            this.largePhotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = " 某 日期區間 的腳踏車";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(517, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "Year:";
            // 
            // productPhotoDataGridView
            // 
            this.productPhotoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPhotoDataGridView.Location = new System.Drawing.Point(36, 75);
            this.productPhotoDataGridView.Name = "productPhotoDataGridView";
            this.productPhotoDataGridView.RowHeadersWidth = 62;
            this.productPhotoDataGridView.RowTemplate.Height = 74;
            this.productPhotoDataGridView.Size = new System.Drawing.Size(612, 285);
            this.productPhotoDataGridView.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 33);
            this.dateTimePicker2.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker2.TabIndex = 44;
            this.dateTimePicker2.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 33);
            this.dateTimePicker1.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // awDataSet1
            // 
            this.awDataSet1.DataSetName = "AWDataSet";
            this.awDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ProductPhotoTableAdapter = null;
            this.tableAdapterManager1.ProductProductPhotoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.AWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 54;
            this.label3.Text = "label3";
            // 
            // FrmAW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(largePhotoLabel);
            this.Controls.Add(this.largePhotoPictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPhotoDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAW";
            this.Text = "FrmAW";
            this.Load += new System.EventHandler(this.FrmAW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox largePhotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productPhotoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private AWDataSet awDataSet1;
        private AWDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
        private AWDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
    }
}