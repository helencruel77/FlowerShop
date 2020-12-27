using BusinessLogic.BindingModels;
using BusinessLogic.BusinessLogics;
using BusinessLogic.Controller;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;


namespace FlowerShopView
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IBouquetLogic logicB;
        private readonly IClientLogic logicC; 
        private readonly ExceptionHandling exceptionHandling;
        private readonly MainLogic logicM;
        public FormCreateOrder(IBouquetLogic logicB, ExceptionHandling exceptionHandling, MainLogic logicM, IClientLogic logicC)
        {
            InitializeComponent();
            this.logicB = logicB; 
            this.exceptionHandling = exceptionHandling;
            this.logicM = logicM;
            this.logicC = logicC;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                var list = logicB.Read(null);
                comboBoxBouqet.DataSource = list;
                comboBoxBouqet.DisplayMember = "BouquetName";
                comboBoxBouqet.ValueMember = "Id";


                var listC = logicC.Read(null);

                if (listC != null)
                {
                    comboBoxClient.DisplayMember = "ClientFIO";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listC;
                    comboBoxClient.SelectedItem = null;
                }

                LoadEnumeration(typeof(DeliveryType));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        public void LoadEnumeration(Type type)
        {
            foreach (var elem in Enum.GetValues(type))
            {
                comboBoxDelivery.Items.Add(elem.ToString());
            }
        }

        private void CalcSum()
        {
            if (comboBoxBouqet.SelectedValue != null && !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxBouqet.SelectedValue);
                    BouquetViewModel product = logicB.Read(new BouquetBindingModel
                    {
                        Id =
                    id
                    })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * product?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
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
                exceptionHandling.CheckingSelection(comboBoxBouqet.SelectedValue, "букет"); 
                exceptionHandling.CheckingDelivery(comboBoxDelivery.SelectedIndex, "тип доставки");
                exceptionHandling.CheckingSelection(comboBoxClient.SelectedValue, "клиента");

                logicM.CreateOrder(new CreateOrderBindingModel
                {
                    BouquetId = Convert.ToInt32(comboBoxBouqet.SelectedValue),
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    Delivery = (DeliveryType)comboBoxDelivery.SelectedIndex,
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
       
    }
}
