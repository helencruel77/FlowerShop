
namespace FlowerShopView
{
    partial class FormBouquet
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxComponent = new System.Windows.Forms.GroupBox();
            this.buttonDelPacking = new System.Windows.Forms.Button();
            this.buttonAddPacking = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(290, 382);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 28);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(97, 53);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(311, 22);
            this.textBoxPrice.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(399, 382);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 28);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(97, 17);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(614, 22);
            this.textBoxName.TabIndex = 13;
            // 
            // groupBoxComponent
            // 
            this.groupBoxComponent.Controls.Add(this.buttonDelPacking);
            this.groupBoxComponent.Controls.Add(this.buttonAddPacking);
            this.groupBoxComponent.Controls.Add(this.buttonRef);
            this.groupBoxComponent.Controls.Add(this.buttonDel);
            this.groupBoxComponent.Controls.Add(this.buttonAdd);
            this.groupBoxComponent.Controls.Add(this.dataGridView);
            this.groupBoxComponent.Location = new System.Drawing.Point(17, 97);
            this.groupBoxComponent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxComponent.Name = "groupBoxComponent";
            this.groupBoxComponent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxComponent.Size = new System.Drawing.Size(784, 277);
            this.groupBoxComponent.TabIndex = 12;
            this.groupBoxComponent.TabStop = false;
            this.groupBoxComponent.Text = "Цветы и упаковка";
            // 
            // buttonDelPacking
            // 
            this.buttonDelPacking.Location = new System.Drawing.Point(495, 183);
            this.buttonDelPacking.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelPacking.Name = "buttonDelPacking";
            this.buttonDelPacking.Size = new System.Drawing.Size(289, 27);
            this.buttonDelPacking.TabIndex = 18;
            this.buttonDelPacking.Text = "Удалить упаковку";
            this.buttonDelPacking.UseVisualStyleBackColor = true;
            this.buttonDelPacking.Click += new System.EventHandler(this.buttonDelPacking_Click);
            // 
            // buttonAddPacking
            // 
            this.buttonAddPacking.Location = new System.Drawing.Point(495, 144);
            this.buttonAddPacking.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPacking.Name = "buttonAddPacking";
            this.buttonAddPacking.Size = new System.Drawing.Size(289, 31);
            this.buttonAddPacking.TabIndex = 17;
            this.buttonAddPacking.Text = "Добавить упаковку/изменить количество";
            this.buttonAddPacking.UseVisualStyleBackColor = true;
            this.buttonAddPacking.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(495, 227);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(111, 30);
            this.buttonRef.TabIndex = 7;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(495, 109);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(289, 27);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "Удалить цветок";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(495, 69);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(289, 32);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить цветок/изменить количество";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(8, 35);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(467, 234);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Товар";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(13, 57);
            this.labelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(43, 17);
            this.labelSum.TabIndex = 11;
            this.labelSum.Text = "Цена";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 20);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 17);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Название";
            // 
            // FormBouquet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 423);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.groupBoxComponent);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelName);
            this.Name = "FormBouquet";
            this.Text = "Товары в букете";
            this.Load += new System.EventHandler(this.FormBouquet_Load);
            this.groupBoxComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxComponent;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddPacking;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonDelPacking;
    }
}