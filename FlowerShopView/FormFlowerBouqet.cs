using BusinessLogic.BindingModels;
using BusinessLogic.BusinessLogics;
using BusinessLogic.Controller;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace FlowerShopView
{
    public partial class FormFlowerBouqet : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id
        {
            get { return Convert.ToInt32(comboBoxComponent.SelectedValue); }
            set { comboBoxComponent.SelectedValue = value; }
        }
        private readonly ExceptionHandling exceptionHandling;

        public string FlowerName { get { return comboBoxComponent.Text; } }
        public int Count
        {
            get { return Convert.ToInt32(textBoxCount.Text); }
            set
            {
                textBoxCount.Text = value.ToString();
            }
        }
        public FormFlowerBouqet(IFlowerLogic logic, ExceptionHandling exceptionHandling)
        {
            InitializeComponent(); 
            this.exceptionHandling = exceptionHandling;

            List<FlowerViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxComponent.DisplayMember = "FlowerName";
                comboBoxComponent.ValueMember = "Id";
                comboBoxComponent.DataSource = list;
                comboBoxComponent.SelectedItem = null;
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                exceptionHandling.СheckingInput(textBoxCount.Text, "Количество");
                exceptionHandling.CheckingInputNumbers(textBoxCount.Text);

                exceptionHandling.CheckingSelection(comboBoxComponent.SelectedValue, "цветок");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
