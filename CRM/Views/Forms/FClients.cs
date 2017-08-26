using CRM.Services.BusinessServices;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using CRM.Desktop.Presenter;

namespace CRM.Desktop.Views.Forms
{
    public partial class FClients : Form, IClientView, IContactView, IProjectView
    {
        DataTable dataClients;
        DataTable dataContact;
        DataTable dataProject;

        int selectedIdFromContacts;
        int selectedIdFromProjects;
        int selectedIdFromClients;

        ClientPresenter clientPresenter;
        ContactPresenter contactPresenter;
        ProjectPresenter projectPresenter;

        public FAddClient FAddClient { get; }
        public FaddProject FaddProject { get; }
        public FUpdateProject FUpdateProject { get; }
        public FAddContact FAddContact { get; set; }
        public FUpdateContact FUpdateContact { get; }

        public event EventHandler Button;
        public event DataGridViewCellMouseEventHandler cellMouseClick;

        public FClients(IClientService clientService, IContactService contactService, IProjectService projectService, FAddClient fAddClient, FaddProject faddProject, FUpdateProject fUpdateProject, FAddContact fAddContact, FUpdateContact fUpdateContact)
        {
            InitializeComponent();

            clientPresenter = new ClientPresenter(this, clientService);
            contactPresenter = new ContactPresenter(this, contactService);
            projectPresenter = new ProjectPresenter(this, projectService);
            FAddClient = fAddClient;
            FaddProject = faddProject;
            FUpdateProject = fUpdateProject;
            FAddContact = fAddContact;
            FUpdateContact = fUpdateContact;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAddClient.Button += new EventHandler(ButtonClickedForClients);
            FAddClient.ShowDialog();


        }

        private void Update_Click(object sender, EventArgs e)
        {

            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                selectedIdFromClients = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                FAddClient.ClientId = selectedIdFromClients;
                FAddClient.Button += new EventHandler(ButtonClickedForClients);
                FAddClient.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is not any row selected!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                selectedIdFromClients = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure to want to delete this client?", "Delete client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var success = clientPresenter.DeleteClient(selectedIdFromClients);
                    if (success)
                    {
                        MessageBox.Show("Success!", "Message");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Nothing was deleted!", "Message");
                }

                dataClients = clientPresenter.GetAll();
                dataGridViewClients.DataSource = dataClients;
                dataGridViewClients.Refresh();
            }
            else
            {
                MessageBox.Show("There is not any row selected!");
            }
        }

        private void ButtonClickedForClients(object sender, EventArgs e)
        {
            dataGridViewClients.Visible = true;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                selectedIdFromContacts = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                dataContact = clientPresenter.GetAll();
                dataGridViewClients.DataSource = dataContact;
                dataGridViewClients.DataMember = dataContact.TableName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedIdFromClients = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
            FAddContact.ClientId = selectedIdFromClients;
            FAddContact.Button += new EventHandler(ButtonAddClicked);
            FAddContact.ShowDialog();

        }

        private void ButtonAddClicked(object sender, EventArgs e)
        {
            dataGridViewContacts.Visible = true;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                selectedIdFromContacts = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                dataContact = contactPresenter.GetAllContact(selectedIdFromContacts);
                dataGridViewContacts.DataSource = dataContact;
                dataGridViewContacts.DataMember = dataContact.TableName;
            }
        }



        private void deleteContact_Click(object sender, EventArgs e)
        {
            dataGridViewContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewContacts.SelectedRows.Count > 0)
            {
                selectedIdFromContacts = Convert.ToInt32(dataGridViewContacts.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Are you sure to want to delete this contact?", "Delete contact", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var success = contactPresenter.DeleteContact(selectedIdFromContacts);
                    if (success)
                    {
                        MessageBox.Show("Success!", "Message");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Nothing was deleted!", "Message");
                }

                dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (dataGridViewClients.SelectedRows.Count > 0)
                {
                    selectedIdFromContacts = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                    dataContact = contactPresenter.GetAllContact(selectedIdFromContacts);
                    dataGridViewContacts.DataSource = dataContact;
                    dataGridViewContacts.DataMember = dataContact.TableName;
                }
            }
            else
            {
                MessageBox.Show("There is not any row selected!");
            }
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            decimal select = Convert.ToDecimal(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());

            FaddProject.ClientId = select;
            FaddProject.Button += new EventHandler(ButtonClickedForProjects);
            FaddProject.ShowDialog();
        }

        private void ButtonClickedForProjects(object sender, EventArgs e)
        {
            dataGridViewProjects.Visible = true;

            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                selectedIdFromProjects = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                dataProject = projectPresenter.GetAllProjects(selectedIdFromProjects);
                dataGridViewProjects.DataSource = dataProject;
                dataGridViewProjects.DataMember = dataProject.TableName;
            }
        }

        private void deleteProject_Click(object sender, EventArgs e)
        {
            dataGridViewProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                selectedIdFromProjects = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Are you sure to want to delete this project?", "Delete project", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var success = projectPresenter.DeleteProject(selectedIdFromProjects);
                    if (success)
                    {
                        MessageBox.Show("Success!", "Message");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Nothing was deleted!", "Message");
                }

                dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (dataGridViewClients.SelectedRows.Count > 0)
                {
                    selectedIdFromProjects = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
                    dataContact = projectPresenter.GetAllProjects(selectedIdFromProjects);
                    dataGridViewProjects.DataSource = dataContact;
                    dataGridViewProjects.DataMember = dataContact.TableName;
                }
            }
            else
            {
                MessageBox.Show("There is not any row selected!");
            }
        }

        private void updateContact_Click(object sender, EventArgs e)
        {
            if (dataGridViewContacts.SelectedRows.Count > 0)
            {
                selectedIdFromContacts = Convert.ToInt32(dataGridViewContacts.SelectedRows[0].Cells[0].Value.ToString());
                FUpdateContact.ContactId = selectedIdFromContacts;
                FUpdateContact.Button += new EventHandler(ButtonAddClicked);
                FUpdateContact.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is not any row selected!");
            }
        }

        private void updateProject_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                int selectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells[0].Value.ToString());
                FUpdateProject.ProjectId = selectId;
                FUpdateProject.Button += new EventHandler(ButtonClickedForProjects);
                FUpdateProject.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is not any row selected!");
            }
        }

        private void txtSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = this.clientPresenter.SearchClients(textBox1.Text);
                this.LoadDataGridViewForClients(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }


        private void bSearchContact_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = contactPresenter.SearchContact(txtSearchContact.Text);
                this.LoadDataGridViewForContact(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        private void bSearchProject_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = projectPresenter.SearchProject(txtSearchProject.Text);
                this.LoadDataGridViewForProject(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        private void LoadDataGridViewForContact(DataTable data)
        {
            dataGridViewContacts.DataSource = data;
            dataGridViewContacts.DataMember = data.TableName;
            dataGridViewContacts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LoadDataGridViewForProject(DataTable data)
        {
            dataGridViewProjects.DataSource = data;
            dataGridViewProjects.DataMember = data.TableName;
            dataGridViewProjects.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LoadDataGridViewForClients(DataTable data)
        {
            dataGridViewClients.DataSource = data;
            dataGridViewClients.DataMember = data.TableName;
            dataGridViewClients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void bRefreshContacts_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
            var data = contactPresenter.GetAllContact(selectId);
            dataGridViewContacts.DataSource = data;
            dataGridViewContacts.DataMember = data.TableName;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());
            var data = projectPresenter.GetAllProjects(selectId);
            dataGridViewProjects.DataSource = data;
            dataGridViewProjects.DataMember = data.TableName;
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            dataClients = clientPresenter.GetAll();
            dataGridViewClients.DataSource = dataClients;
            dataGridViewClients.DataMember = dataClients.TableName;
        }

        private void hideContact_Click(object sender, EventArgs e)
        {
            dataGridViewContacts.Visible = false;
        }

        private void hideProjects_Click(object sender, EventArgs e)
        {
            dataGridViewProjects.Visible = false;
        }

        private void additionsForContact_Click(object sender, EventArgs e)
        {
            panelContacts.Visible = true;
        }

        private void additionForProjects_Click(object sender, EventArgs e)
        {
            panelProjects.Visible = true;
        }

        public void NotifyButtonClicked(EventArgs e)
        {
            if (Button != null)
                Button(this, e);
        }

        private void FClients_Load(object sender, EventArgs e)
        {

            LabelStatus.Text = "Loading... Please wait!";

            var loadThread = new Thread(LoadClients);
            loadThread.Start();
        }

        private void LoadClients()
        {
            dataClients = clientPresenter.GetAll();

            this.Invoke((MethodInvoker)delegate
            {
                dataGridViewClients.DataSource = dataClients;
                dataGridViewClients.DataMember = dataClients.TableName;
                Delete.Visible = true;
                LabelStatus.Text = "Completed";
            });
        }

        private void DataGridClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                selectedIdFromClients = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString());

                LabelStatus.Text = "Loading... Please wait!";

                Thread thread = new Thread(LoadContactsAndProjects);
                thread.Start();
            }
        }

        private void LoadContactsAndProjects()
        {
            dataContact = contactPresenter.GetAllContact(selectedIdFromClients);
            dataProject = projectPresenter.GetAllProjects(selectedIdFromClients);

            this.Invoke((MethodInvoker)delegate
            {
                dataGridViewContacts.DataSource = dataContact;
                dataGridViewContacts.DataMember = dataContact.TableName;

                dataGridViewProjects.DataSource = dataProject;
                dataGridViewProjects.DataMember = dataProject.TableName;

                LabelStatus.Text = "Completed";
            });
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
