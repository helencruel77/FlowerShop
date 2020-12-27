using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using BusinessLogic.BusinessLogics;
using BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;
using System.Collections.Generic;
using BusinessLogic.Controller;

namespace FlowerShopView
{
    public partial class FormCreateRequest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly MainLogic logic;
        private readonly ExceptionHandling exceptionHandling;

        private readonly IRequestLogic requestLogic;
        private readonly IFlowerLogic flowerLogic;

        public FormCreateRequest(MainLogic logic, ExceptionHandling exceptionHandling, IRequestLogic requestLogic, IFlowerLogic flowerLogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.requestLogic = requestLogic;
            this.flowerLogic = flowerLogic;
            this.exceptionHandling = exceptionHandling;

        }
        private void FormCreateRequest_Load(object sender, EventArgs e)
        {
            try
            {
                List<FlowerViewModel> list = flowerLogic.Read(null);
                if (list != null)
                {
                    comboBoxNameFlower.DisplayMember = "FlowerName";
                    comboBoxNameFlower.ValueMember = "Id";
                    comboBoxNameFlower.DataSource = list;
                    comboBoxNameFlower.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                List<RequestViewModel> list = requestLogic.Read(null);
                if (list != null)
                {
                    comboBoxRequest.DisplayMember = "RequestName";
                    comboBoxRequest.ValueMember = "Id";
                    comboBoxRequest.DataSource = list;
                    comboBoxRequest.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                exceptionHandling.CheckingSelection(comboBoxNameFlower.SelectedValue, "цветов");
                exceptionHandling.CheckingSelection(comboBoxRequest.SelectedValue, "заявок");

                logic.CreateRequest(new RequestFlowersBindingModel
                {
                    Id = 0,
                    FlowerId = Convert.ToInt32(comboBoxNameFlower.SelectedValue),
                    RequestId = Convert.ToInt32(comboBoxRequest.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text)
                });
                flowerLogic.FlowersRefill(new RequestFlowersBindingModel
                {
                    FlowerId = Convert.ToInt32(comboBoxNameFlower.SelectedValue),
                    RequestId = Convert.ToInt32(comboBoxRequest.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text)
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
