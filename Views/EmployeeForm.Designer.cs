using BookHaven.Models.Services;
using System;
using System.Linq;
using System.Windows.Forms;


namespace BookHeaven.Views
{
    public partial class EmployeeForm : Form
    {
        private readonly UserService userService;

        public EmployeeForm(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }


        private Label lblId;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdateEmployee;
        private TextBox txtId;
        private Label lblUserName;
        private Label lblRole;
        private Button btnAddEmployee;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewButtonColumn colDelete;
        private ComboBox cmbRole;
        private Label lblPassword;
        private TextBox txtPassord;
        private Button btnBack;
    }
}