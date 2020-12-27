
namespace FlowerShopView
{
    partial class FormCreateOrder
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
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.comboBoxBouqet = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDelivery = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(119, 195);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(437, 22);
            this.textBoxSum.TabIndex = 21;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(59, 195);
            this.labelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(50, 17);
            this.labelSum.TabIndex = 20;
            this.labelSum.Text = "Сумма";
            // 
            // comboBoxBouqet
            // 
            this.comboBoxBouqet.FormattingEnabled = true;
            this.comboBoxBouqet.Location = new System.Drawing.Point(119, 25);
            this.comboBoxBouqet.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBouqet.Name = "comboBoxBouqet";
            this.comboBoxBouqet.Size = new System.Drawing.Size(437, 24);
            this.comboBoxBouqet.TabIndex = 19;
            this.comboBoxBouqet.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(119, 156);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(437, 22);
            this.textBoxCount.TabIndex = 18;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(435, 236);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 27);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(278, 236);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 27);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(23, 159);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(86, 17);
            this.labelCount.TabIndex = 15;
            this.labelCount.Text = "Количество";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(63, 28);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(46, 17);
            this.labelProduct.TabIndex = 14;
            this.labelProduct.Text = "Букет";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(119, 66);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(437, 24);
            this.comboBoxClient.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Доставка";
            // 
            // comboBoxDelivery
            // 
            this.comboBoxDelivery.FormattingEnabled = true;
            this.comboBoxDelivery.Location = new System.Drawing.Point(119, 107);
            this.comboBoxDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDelivery.Name = "comboBoxDelivery";
            this.comboBoxDelivery.Size = new System.Drawing.Size(437, 24);
            this.comboBoxDelivery.TabIndex = 25;            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 277);
            this.Controls.Add(this.comboBoxDelivery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.comboBoxBouqet);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProduct);
            this.Name = "FormCreateOrder";
            this.Text = "Создать заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.ComboBox comboBoxBouqet;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDelivery;
    }
}