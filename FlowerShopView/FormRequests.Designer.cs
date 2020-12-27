
namespace FlowerShopView
{
    partial class FormRequests
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
            this.buttonSendReportExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendReportWord = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateRequest = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSendReportExcel
            // 
            this.buttonSendReportExcel.Location = new System.Drawing.Point(647, 382);
            this.buttonSendReportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendReportExcel.Name = "buttonSendReportExcel";
            this.buttonSendReportExcel.Size = new System.Drawing.Size(178, 27);
            this.buttonSendReportExcel.TabIndex = 25;
            this.buttonSendReportExcel.Text = "В excel формате";
            this.buttonSendReportExcel.UseVisualStyleBackColor = true;
            this.buttonSendReportExcel.Click += new System.EventHandler(this.buttonSendReportExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "Отправка отчета \r\nпо заявкам на почту";
            // 
            // buttonSendReportWord
            // 
            this.buttonSendReportWord.Location = new System.Drawing.Point(648, 347);
            this.buttonSendReportWord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendReportWord.Name = "buttonSendReportWord";
            this.buttonSendReportWord.Size = new System.Drawing.Size(178, 27);
            this.buttonSendReportWord.TabIndex = 23;
            this.buttonSendReportWord.Text = "В doc формате";
            this.buttonSendReportWord.UseVisualStyleBackColor = true;
            this.buttonSendReportWord.Click += new System.EventHandler(this.buttonSendReportWord_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(647, 206);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(179, 30);
            this.buttonRef.TabIndex = 22;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(647, 107);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(179, 31);
            this.buttonUpd.TabIndex = 21;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(647, 158);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(179, 30);
            this.buttonDel.TabIndex = 20;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(647, 57);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 32);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(13, 57);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(613, 379);
            this.dataGridView.TabIndex = 18;
            // 
            // buttonCreateRequest
            // 
            this.buttonCreateRequest.Location = new System.Drawing.Point(13, 12);
            this.buttonCreateRequest.Name = "buttonCreateRequest";
            this.buttonCreateRequest.Size = new System.Drawing.Size(175, 34);
            this.buttonCreateRequest.TabIndex = 26;
            this.buttonCreateRequest.Text = "Пополнить заявку";
            this.buttonCreateRequest.UseVisualStyleBackColor = true;
            this.buttonCreateRequest.Click += new System.EventHandler(this.buttonCreateRequest_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(647, 309);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(179, 22);
            this.textBoxEmail.TabIndex = 27;
            // 
            // FormRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonCreateRequest);
            this.Controls.Add(this.buttonSendReportExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendReportWord);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormRequests";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.FormRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendReportExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendReportWord;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateRequest;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}