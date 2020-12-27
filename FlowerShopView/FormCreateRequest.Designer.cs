
namespace FlowerShopView
{
    partial class FormCreateRequest
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
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxNameFlower = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.FormattingEnabled = true;
            this.comboBoxRequest.Location = new System.Drawing.Point(116, 21);
            this.comboBoxRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(321, 24);
            this.comboBoxRequest.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Заявка:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(320, 120);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 32);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(199, 120);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 32);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxNameFlower
            // 
            this.comboBoxNameFlower.FormattingEnabled = true;
            this.comboBoxNameFlower.Location = new System.Drawing.Point(116, 53);
            this.comboBoxNameFlower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNameFlower.Name = "comboBoxNameFlower";
            this.comboBoxNameFlower.Size = new System.Drawing.Size(321, 24);
            this.comboBoxNameFlower.TabIndex = 33;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(115, 85);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(322, 22);
            this.textBoxCount.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Количество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Цветок:";
            // 
            // FormCreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 164);
            this.Controls.Add(this.comboBoxRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxNameFlower);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateRequest";
            this.Text = "Создание заявки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCreateRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxNameFlower;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}