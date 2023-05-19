namespace WindowsFormsApp1.HomeWork
{
    partial class FrmProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productsTableAdapter1 = new WindowsFormsApp1.NWDataSetTableAdapters.ProductsTableAdapter();
            this.nwDataSet1 = new WindowsFormsApp1.NWDataSet();
            this.tableAdapterManager1 = new WindowsFormsApp1.NWDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disconnected";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(10, 50);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(64, 41);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load Products";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Location = new System.Drawing.Point(98, 50);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(49, 41);
            this.buttonTop.TabIndex = 2;
            this.buttonTop.Text = "<<";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(298, 52);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(45, 41);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(349, 52);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(45, 41);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = ">>";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(689, 31);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(64, 59);
            this.search.TabIndex = 6;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(402, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UnitPrice:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(402, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "ProductName:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 327);
            this.dataGridView1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(208, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = " ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(536, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 11;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(490, 29);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(80, 22);
            this.txtmin.TabIndex = 12;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(605, 29);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(78, 22);
            this.txtmax.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(576, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "~";
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriesTableAdapter = null;
            this.tableAdapterManager1.CustomersTableAdapter = null;
            this.tableAdapterManager1.ProductsTableAdapter = this.productsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.NWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label5;
        private NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private NWDataSet nwDataSet1;
        private NWDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}