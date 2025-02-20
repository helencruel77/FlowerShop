﻿using BusinessLogic.BindingModels;
using BusinessLogic.BusinessLogics;
using BusinessLogic.Controller;
using BusinessLogic.HelperModels;
using BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;


namespace FlowerShopView
{
    public partial class FormRequests : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IRequestLogic logic;
        private readonly ReportLogic reportLogic;
        private readonly ExceptionHandling exceptionHandling;

        public FormRequests(IRequestLogic logic, ExceptionHandling exceptionHandling, ReportLogic reportLogic)
        {
            InitializeComponent();
            this.exceptionHandling = exceptionHandling;

            this.logic = logic;
            this.reportLogic = reportLogic;

        }
        private void FormRequests_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);

                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[3].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRequest>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonSendReportWord_Click(object sender, EventArgs e)
        {

            try
            {
                exceptionHandling.СheckingInput(textBoxEmail.Text, "Почта");

                using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {

                        reportLogic.SaveRequestToWordFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        });
                        MailLogic.MailSend(new MailSendInfo
                        {
                            MailAddress = textBoxEmail.Text,
                            Subject = $"Оповещение по заявке",
                            Text = $"Поступила заявка на места",
                            FileName = dialog.FileName

                        });
                        MessageBox.Show("Отчет отправлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSendReportExcel_Click(object sender, EventArgs e)
        {
            exceptionHandling.СheckingInput(textBoxEmail.Text, "Почта");

            try
            {
                using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        reportLogic.SaveRequestToExcelFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        });
                        MailLogic.MailSend(new MailSendInfo
                        {
                            MailAddress = textBoxEmail.Text,
                            Subject = $"Оповещение по заявке",
                            Text = $"Поступила заявка на места",
                            FileName = dialog.FileName

                        });
                        MessageBox.Show("Отчет отправлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

                    try
                    {
                        logic.Delete(new RequestBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormRequest>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateRequest_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateRequest>();
            form.ShowDialog();
        }
    }
}
