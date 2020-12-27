using System;
using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using System.Windows.Forms;
using Unity;
using BusinessLogic.Controller;

namespace FlowerShopView
{
    public partial class FormPackaging : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPackagingLogic logic;
        public int Id { set { id = value; } }
        private int? id;
        private readonly ExceptionHandling exceptionHandling;

        public FormPackaging(IPackagingLogic logic, ExceptionHandling exceptionHandling)
        {
            InitializeComponent();
            this.logic = logic;
            this.exceptionHandling = exceptionHandling;

        }
        private void FormPackaging_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new PackagingBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.PackagingName;
                        textBoxPrice.Text = view.Price.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        public FormPackaging()
        {
            InitializeComponent();
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
                exceptionHandling.СheckingInput(textBoxName.Text, "Название");
                exceptionHandling.СheckingInput(textBoxPrice.Text, "Цена");

                logic.CreateOrUpdate(new PackagingBindingModel
                {
                    Id = id,
                    PackagingName = textBoxName.Text,
                    Price = Convert.ToDecimal(textBoxPrice.Text)
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
    }
}
