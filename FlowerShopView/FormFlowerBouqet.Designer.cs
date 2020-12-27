
namespace FlowerShopView
{
    partial class FormFlowerBouqet
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
            this.comboBoxComponent = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelComponents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxComponent
            // 
            this.comboBoxComponent.FormattingEnabled = true;
            this.comboBoxComponent.Location = new System.Drawing.Point(111, 32);
            this.comboBoxComponent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComponent.Name = "comboBoxComponent";
            this.comboBoxComponent.Size = new System.Drawing.Size(437, 24);
            this.comboBoxComponent.TabIndex = 11;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(111, 76);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(437, 22);
            this.textBoxCount.TabIndex = 10;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(430, 123);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 27);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(274, 123);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 27);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(15, 80);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(86, 17);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Количество";
            // 
            // labelComponents
            // 
            this.labelComponents.AutoSize = true;
            this.labelComponents.Location = new System.Drawing.Point(36, 35);
            this.labelComponents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComponents.Name = "labelComponents";
            this.labelComponents.Size = new System.Drawing.Size(56, 17);
            this.labelComponents.TabIndex = 6;
            this.labelComponents.Text = "Цветок";
            // 
            // FormFlowerBouqet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 163);
            this.Controls.Add(this.comboBoxComponent);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelComponents);
            this.Name = "FormFlowerBouqet";
            this.Text = "Цветы в букете";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComponent;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelComponents;
    }
}