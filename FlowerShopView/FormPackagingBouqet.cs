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
    public partial class FormPackagingBouqet : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id
        {
            get { return Convert.ToInt32(comboBoxComponent.SelectedValue); }
            set { comboBoxComponent.SelectedValue = value; }
        }
        public string PackagingName { get { return comboBoxComponent.Text; } }
        private readonly ExceptionHandling exceptionHandling;

        public int Count
        {
            get { return Convert.ToInt32(textBoxCount.Text); }
            set
            {
                textBoxCount.Text = value.ToString();
            }
        }
        public FormPackagingBouqet(IPackagingLogic logic, ExceptionHandling exceptionHandling)
        {
            InitializeComponent();
            this.exceptionHandling = exceptionHandling;

            List<PackagingViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxComponent.DisplayMember = "PackagingName";
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

                exceptionHandling.CheckingSelection(comboBoxComponent.SelectedValue, "упаковки");

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
