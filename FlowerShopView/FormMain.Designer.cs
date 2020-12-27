
namespace FlowerShopView
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonPayOrder = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упаковкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.букетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 51);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(928, 295);
            this.dataGridView.TabIndex = 13;
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(955, 251);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(140, 27);
            this.buttonRef.TabIndex = 12;
            this.buttonRef.Text = "Обновить список";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonPayOrder
            // 
            this.buttonPayOrder.Location = new System.Drawing.Point(955, 210);
            this.buttonPayOrder.Name = "buttonPayOrder";
            this.buttonPayOrder.Size = new System.Drawing.Size(140, 27);
            this.buttonPayOrder.TabIndex = 11;
            this.buttonPayOrder.Text = "Заказ оплачен";
            this.buttonPayOrder.UseVisualStyleBackColor = true;
            this.buttonPayOrder.Click += new System.EventHandler(this.buttonPayOrder_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(955, 167);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(140, 27);
            this.buttonOrderReady.TabIndex = 10;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(955, 125);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(140, 27);
            this.buttonTakeOrderInWork.TabIndex = 9;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение ";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(955, 81);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(140, 27);
            this.buttonCreateOrder.TabIndex = 8;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветыToolStripMenuItem,
            this.упаковкаToolStripMenuItem,
            this.букетыToolStripMenuItem,
            this.заявкиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // цветыToolStripMenuItem
            // 
            this.цветыToolStripMenuItem.Name = "цветыToolStripMenuItem";
            this.цветыToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.цветыToolStripMenuItem.Text = "Цветы";
            this.цветыToolStripMenuItem.Click += new System.EventHandler(this.ЦветыToolStripMenuItem_Click);
            // 
            // упаковкаToolStripMenuItem
            // 
            this.упаковкаToolStripMenuItem.Name = "упаковкаToolStripMenuItem";
            this.упаковкаToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.упаковкаToolStripMenuItem.Text = "Упаковка";
            this.упаковкаToolStripMenuItem.Click += new System.EventHandler(this.УпаковкаToolStripMenuItem_Click);
            // 
            // букетыToolStripMenuItem
            // 
            this.букетыToolStripMenuItem.Name = "букетыToolStripMenuItem";
            this.букетыToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.букетыToolStripMenuItem.Text = "Букеты";
            this.букетыToolStripMenuItem.Click += new System.EventHandler(this.букетыToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(955, 293);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(140, 27);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить заказ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 366);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonPayOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonPayOrder;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упаковкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem букетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.Button buttonDel;
    }
}