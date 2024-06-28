using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_HAPPY_PET.Views
{
    public partial class PetView : Form, IPetView
    {
        #region  Fields
        private bool isEdit;
        private bool isSuccessfull;
        private bool message;
        #endregion

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            btnClose.Click += delegate { this.Close(); }; 
        }

        private void AssociateAndRaiseEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        #region Properties
        public string PetId { get { return txtPetId.Text; } set { txtPetId.Text = value; } }
        public string PetName { get { return txtPetName.Text; } set { txtPetName.Text = value; } }
        public string PetType { get { return txtPetType.Text; } set { txtPetType.Text = value; } }
        public string PetColour { get { return txtPetId.Text; } set { txtPetId.Text = value; } }
        public string SearchValue { get { return txtSearch.Text; } set { txtSearch.Text = value; } }
        public bool IsEdit { get { return isEdit; } set { isEdit = value; } }
        public bool IsSuccessfull { get { return isSuccessfull; } set { isSuccessfull = value; } }
        public bool Message { get { return message; } set { message = value; } }
        #endregion

        #region Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        #endregion

        #region Methods
        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        private void PetView_Load(object sender, EventArgs e)
        {

        }
        #endregion

        // Single Pattern (Open a single form instance)
        private static PetView Instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new PetView();
                Instance.MdiParent = parentContainer;
                Instance.FormBorderStyle = FormBorderStyle.None;
                Instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (Instance.WindowState == FormWindowState.Minimized)
                    Instance.WindowState = FormWindowState.Normal;
                Instance.BringToFront();
            }
            return Instance;
        }
    }
}
