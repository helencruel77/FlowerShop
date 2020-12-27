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
    public partial class FormBouquet : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IBouquetLogic logic;
        private int? id;
        private Dictionary<int, (string, int)> flowerBouquet;
        private Dictionary<int, (string, int)> packagingBouquet;
        private readonly ExceptionHandling exceptionHandling;

        public FormBouquet(IBouquetLogic service, ExceptionHandling exceptionHandling)
        {
            InitializeComponent();
            this.logic = service;
            this.exceptionHandling = exceptionHandling;

        }
        private void FormBouquet_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    BouquetViewModel view = logic.Read(new BouquetBindingModel
                    {
                        Id = id.Value
                    })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.BouquetName;
                        textBoxPrice.Text = view.Price.ToString();
                        flowerBouquet = view.FlowerBouquets;
                        packagingBouquet = view.PackagingBouquets;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                packagingBouquet = new Dictionary<int, (string, int)>();
                flowerBouquet = new Dictionary<int, (string, int)>();
            }
        }
        private void LoadData()
        {                  
            try
            {
                if (flowerBouquet != null)
                {
                    dataGridView.Rows.Clear();

                    foreach (var pc in flowerBouquet)
                    {
                        dataGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
                    }
                    if (packagingBouquet != null)
                    {
                        foreach (var pc in packagingBouquet)
                        {
                            dataGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,  MessageBoxIcon.Error);
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
                exceptionHandling.СheckingFullness(flowerBouquet, "цветы");
                exceptionHandling.СheckingFullness(packagingBouquet, "упаковку");
                exceptionHandling.СheckingInput(textBoxName.Text, "Название");
                exceptionHandling.СheckingInput(textBoxPrice.Text, "Цена");
                logic.CreateOrUpdate(new BouquetBindingModel
                {
                    Id = id,
                    BouquetName = textBoxName.Text,
                    Price = Convert.ToDecimal(textBoxPrice.Text),
                    FlowerBouquets = flowerBouquet,
                    PackagingBouquets = packagingBouquet
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

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,  MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {                    
                        flowerBouquet.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
                        logic.DeleteFlowerBouquets(new BouquetBindingModel { Id = id, FlowerBouquets = flowerBouquet });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

      

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            var form = Container.Resolve<FormFlowerBouqet>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (flowerBouquet.ContainsKey(form.Id))
                {
                    flowerBouquet[form.Id] = (form.FlowerName, form.Count);                
                }
                else
                {
                    flowerBouquet.Add(form.Id, (form.FlowerName, form.Count));                
                }
                LoadData();
            }
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPackagingBouqet>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (packagingBouquet.ContainsKey(form.Id))
                {
                    packagingBouquet[form.Id] = (form.PackagingName, form.Count);
                }
                else
                {
                    packagingBouquet.Add(form.Id, (form.PackagingName, form.Count));                  
                }
                LoadData();
            }
        }

        private void buttonDelPacking_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        packagingBouquet.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
                        logic.DeletePackagingBouquets(new BouquetBindingModel { Id = id, PackagingBouquets = packagingBouquet });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
    }
}
