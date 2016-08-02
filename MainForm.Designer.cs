namespace DatabaseClassConverter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_GetTables = new System.Windows.Forms.Button();
            this.textBox_ConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ConvertAllTables = new System.Windows.Forms.Button();
            this.button_GetTableDefinition = new System.Windows.Forms.Button();
            this.listBox_TableListing = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_RenderColumnDefinition = new System.Windows.Forms.CheckBox();
            this.label_TableName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_RenderClassDefinition = new System.Windows.Forms.Button();
            this.dataGridView_TableDefinition = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nullable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_CopyToClipboard = new System.Windows.Forms.Button();
            this.textBox_RenderedClass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TableDefinition)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_GetTables);
            this.groupBox1.Controls.Add(this.textBox_ConnectionString);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(539, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1. Enter Your Database Connection String";
            // 
            // button_GetTables
            // 
            this.button_GetTables.Location = new System.Drawing.Point(13, 79);
            this.button_GetTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_GetTables.Name = "button_GetTables";
            this.button_GetTables.Size = new System.Drawing.Size(100, 28);
            this.button_GetTables.TabIndex = 3;
            this.button_GetTables.Text = "Get Tables";
            this.button_GetTables.UseVisualStyleBackColor = true;
            this.button_GetTables.Click += new System.EventHandler(this.button_GetTables_Click);
            // 
            // textBox_ConnectionString
            // 
            this.textBox_ConnectionString.Location = new System.Drawing.Point(12, 46);
            this.textBox_ConnectionString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ConnectionString.Name = "textBox_ConnectionString";
            this.textBox_ConnectionString.Size = new System.Drawing.Size(517, 22);
            this.textBox_ConnectionString.TabIndex = 2;
            this.textBox_ConnectionString.Text = "Data Source=localhost;Initial Catalog=MainSteamDB;User Id=sa;Password=Abcd123$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ConvertAllTables);
            this.groupBox2.Controls.Add(this.button_GetTableDefinition);
            this.groupBox2.Controls.Add(this.listBox_TableListing);
            this.groupBox2.Location = new System.Drawing.Point(16, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(539, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 : Choose Your Table";
            // 
            // button_ConvertAllTables
            // 
            this.button_ConvertAllTables.Location = new System.Drawing.Point(184, 356);
            this.button_ConvertAllTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ConvertAllTables.Name = "button_ConvertAllTables";
            this.button_ConvertAllTables.Size = new System.Drawing.Size(137, 28);
            this.button_ConvertAllTables.TabIndex = 1;
            this.button_ConvertAllTables.Text = "Batch Convert All";
            this.button_ConvertAllTables.UseVisualStyleBackColor = true;
            this.button_ConvertAllTables.Click += new System.EventHandler(this.button_ConvertAllTables_Click);
            // 
            // button_GetTableDefinition
            // 
            this.button_GetTableDefinition.Location = new System.Drawing.Point(13, 356);
            this.button_GetTableDefinition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_GetTableDefinition.Name = "button_GetTableDefinition";
            this.button_GetTableDefinition.Size = new System.Drawing.Size(164, 28);
            this.button_GetTableDefinition.TabIndex = 0;
            this.button_GetTableDefinition.Text = "Get Table Definition";
            this.button_GetTableDefinition.Click += new System.EventHandler(this.button_GetTableDefinition_Click);
            // 
            // listBox_TableListing
            // 
            this.listBox_TableListing.FormattingEnabled = true;
            this.listBox_TableListing.ItemHeight = 16;
            this.listBox_TableListing.Location = new System.Drawing.Point(13, 25);
            this.listBox_TableListing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_TableListing.Name = "listBox_TableListing";
            this.listBox_TableListing.Size = new System.Drawing.Size(516, 324);
            this.listBox_TableListing.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_RenderColumnDefinition);
            this.groupBox3.Controls.Add(this.label_TableName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button_RenderClassDefinition);
            this.groupBox3.Controls.Add(this.dataGridView_TableDefinition);
            this.groupBox3.Location = new System.Drawing.Point(563, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(435, 512);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 : Preview the Table Definition";
            // 
            // checkBox_RenderColumnDefinition
            // 
            this.checkBox_RenderColumnDefinition.AutoSize = true;
            this.checkBox_RenderColumnDefinition.Checked = true;
            this.checkBox_RenderColumnDefinition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RenderColumnDefinition.Location = new System.Drawing.Point(228, 481);
            this.checkBox_RenderColumnDefinition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RenderColumnDefinition.Name = "checkBox_RenderColumnDefinition";
            this.checkBox_RenderColumnDefinition.Size = new System.Drawing.Size(162, 21);
            this.checkBox_RenderColumnDefinition.TabIndex = 4;
            this.checkBox_RenderColumnDefinition.Text = "Render Column Def?";
            this.checkBox_RenderColumnDefinition.UseVisualStyleBackColor = true;
            // 
            // label_TableName
            // 
            this.label_TableName.AutoSize = true;
            this.label_TableName.Location = new System.Drawing.Point(108, 23);
            this.label_TableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TableName.Name = "label_TableName";
            this.label_TableName.Size = new System.Drawing.Size(0, 17);
            this.label_TableName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Name : ";
            // 
            // button_RenderClassDefinition
            // 
            this.button_RenderClassDefinition.Location = new System.Drawing.Point(9, 476);
            this.button_RenderClassDefinition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RenderClassDefinition.Name = "button_RenderClassDefinition";
            this.button_RenderClassDefinition.Size = new System.Drawing.Size(209, 28);
            this.button_RenderClassDefinition.TabIndex = 1;
            this.button_RenderClassDefinition.Text = "Render C# Class Definition";
            this.button_RenderClassDefinition.UseVisualStyleBackColor = true;
            this.button_RenderClassDefinition.Click += new System.EventHandler(this.button_RenderClassDefinition_Click);
            // 
            // dataGridView_TableDefinition
            // 
            this.dataGridView_TableDefinition.AllowUserToAddRows = false;
            this.dataGridView_TableDefinition.AllowUserToDeleteRows = false;
            this.dataGridView_TableDefinition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TableDefinition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_DataType,
            this.Column_Length,
            this.Column_Nullable});
            this.dataGridView_TableDefinition.Location = new System.Drawing.Point(8, 46);
            this.dataGridView_TableDefinition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_TableDefinition.Name = "dataGridView_TableDefinition";
            this.dataGridView_TableDefinition.ReadOnly = true;
            this.dataGridView_TableDefinition.RowHeadersVisible = false;
            this.dataGridView_TableDefinition.ShowEditingIcon = false;
            this.dataGridView_TableDefinition.Size = new System.Drawing.Size(413, 425);
            this.dataGridView_TableDefinition.TabIndex = 0;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "ColName";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_DataType
            // 
            this.Column_DataType.HeaderText = "DataType";
            this.Column_DataType.Name = "Column_DataType";
            this.Column_DataType.ReadOnly = true;
            // 
            // Column_Length
            // 
            this.Column_Length.HeaderText = "Length";
            this.Column_Length.Name = "Column_Length";
            this.Column_Length.ReadOnly = true;
            this.Column_Length.Width = 50;
            // 
            // Column_Nullable
            // 
            this.Column_Nullable.HeaderText = "Nullable?";
            this.Column_Nullable.Name = "Column_Nullable";
            this.Column_Nullable.ReadOnly = true;
            this.Column_Nullable.Width = 55;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_CopyToClipboard);
            this.groupBox4.Controls.Add(this.textBox_RenderedClass);
            this.groupBox4.Location = new System.Drawing.Point(1005, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(379, 512);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4: Copy/Paste the rendered class.";
            // 
            // button_CopyToClipboard
            // 
            this.button_CopyToClipboard.Location = new System.Drawing.Point(9, 476);
            this.button_CopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_CopyToClipboard.Name = "button_CopyToClipboard";
            this.button_CopyToClipboard.Size = new System.Drawing.Size(144, 28);
            this.button_CopyToClipboard.TabIndex = 1;
            this.button_CopyToClipboard.Text = "Copy to Clipboard";
            this.button_CopyToClipboard.UseVisualStyleBackColor = true;
            this.button_CopyToClipboard.Click += new System.EventHandler(this.button_CopyToClipboard_Click);
            // 
            // textBox_RenderedClass
            // 
            this.textBox_RenderedClass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RenderedClass.Location = new System.Drawing.Point(9, 25);
            this.textBox_RenderedClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RenderedClass.Multiline = true;
            this.textBox_RenderedClass.Name = "textBox_RenderedClass";
            this.textBox_RenderedClass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_RenderedClass.Size = new System.Drawing.Size(364, 445);
            this.textBox_RenderedClass.TabIndex = 0;
            this.textBox_RenderedClass.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 542);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database -> C# Class Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TableDefinition)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_ConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GetTables;
        private System.Windows.Forms.ListBox listBox_TableListing;
        private System.Windows.Forms.Button button_GetTableDefinition;
        private System.Windows.Forms.DataGridView dataGridView_TableDefinition;
        private System.Windows.Forms.TextBox textBox_RenderedClass;
        private System.Windows.Forms.Button button_RenderClassDefinition;
        private System.Windows.Forms.Label label_TableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nullable;
        private System.Windows.Forms.CheckBox checkBox_RenderColumnDefinition;
        private System.Windows.Forms.Button button_ConvertAllTables;
        private System.Windows.Forms.Button button_CopyToClipboard;

    }
}

