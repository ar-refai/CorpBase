using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpBase.Business;
using System.Runtime.InteropServices;
using CorpBase.Common;

namespace CorpBase.WinUI
{
    public partial class EmployeesForm : Form
    {
        #region Drawing Properties
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        #endregion

        private readonly EmployeeService _service;
        private readonly DepartmentService _deptService;
        public EmployeesForm(EmployeeService service, DepartmentService deptService)
        {
            InitializeComponent();
            _service = service;
            _deptService = deptService;
        }

        #region Drawing Methods

        // To be able to drag the header section as there is no controls to drag the form
        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        // Helper method for the sake of rounded borders
        private void RoundControl(Control control, int radius)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }

        private void chk_isactive_CheckedChanged(object sender, EventArgs e)
        {
            chk_isactive.ForeColor = chk_isactive.ForeColor == Color.DimGray ? Color.White : Color.DimGray;
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
            // 1. Setup for high quality
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Define the path (Rounded Rectangle)
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, pnl_main.Width - 1, pnl_main.Height - 1);
            System.Drawing.Drawing2D.GraphicsPath path = GetRoundedPath(rect, radius);

            // 3. Draw the Glow (GDI+ specialized Pen)
            using (Pen glowPen = new Pen(Color.FromArgb(100, 0, 255, 200), 3)) // Semi-transparent teal
            {
                e.Graphics.DrawPath(glowPen, path);
            }

            // 4. Draw the Sharp Border
            using (Pen borderPen = new Pen(Color.FromArgb(0, 255, 200), 1))
            {
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            float d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
        #endregion

        // load the form
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            #region UiDrawings
            // form
            RoundControl(this, 15);
            // panels
            RoundControl(pnl_header, 15);
            RoundControl(pnl_border, 15);
            RoundControl(pnl_main, 15);
            // buttons
            RoundControl(btn_create, 10);
            RoundControl(pnl_create_wrapper, 10);
            RoundControl(btn_update, 10);
            RoundControl(pnl_update_wrapper, 10);
            RoundControl(btn_delete, 10);
            RoundControl(pnl_delete_wrapper, 10);
            RoundControl(btn_search, 10);
            RoundControl(pnl_search_wrapper, 10);
            // search text 
            RoundControl(txt_search, 10);
            RoundControl(txt_search_wrapper, 10);
            // inputs
            RoundControl(pnl_fullname, 10);
            RoundControl(txt_fullname, 10);
            RoundControl(pnl_jobtitle, 10);
            RoundControl(txt_jobtitle, 10);
            RoundControl(pnl_departmentid, 10);
            RoundControl(cmb_departments, 10);
            RoundControl(pnl_salary, 10);
            RoundControl(nud_salary, 10);
            RoundControl(chk_isactive, 50);
            nud_salary.Controls[0].Visible = false;

            #endregion

            nud_id.Maximum = int.MaxValue; // This sets it to 2.1 Billion
            // (In case someone gets a big raise!)
            nud_salary.Maximum = 100000000;

            cmb_departments.DataSource = _deptService.GetDepartmentsAsTable();
            cmb_departments.DisplayMember = "DeptName";
            cmb_departments.ValueMember = "Id";

            LoadEmployees();
        }

        // load employee data
        private void LoadEmployees()
        {
            dgv_employees.DataSource = null;
            dgv_employees.DataSource = _service.GetEmployeesAsTable(true);
        }
        
        // The exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // fill the inputs when cell if dgv clicked
        private void dgv_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_employees.Rows[e.RowIndex];

            if (row.Cells["Id"].Value == DBNull.Value) return;

            nud_id.Value = Convert.ToInt32(row.Cells["Id"].Value);
            txt_fullname.Text = row.Cells["FullName"].Value.ToString();
            txt_jobtitle.Text = row.Cells["JobTitle"].Value.ToString();
            nud_salary.Value = Convert.ToDecimal(row.Cells["Salary"].Value);
            chk_isactive.Checked = (bool)row.Cells["IsActive"].Value;
            cmb_departments.SelectedValue = row.Cells["DepartmentId"].Value;
        }

        // crud operations and search 
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {

                var emp = new Employee()
                {
                    FullName = txt_fullname.Text,
                    JobTitle = txt_jobtitle.Text,
                    Salary = nud_salary.Value,
                    IsActive = chk_isactive.Checked,
                    DepartmentId = Convert.ToInt32(cmb_departments.SelectedValue)
                };
                _service.Create(emp);
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var em = new Employee()
                {
                    Id = Convert.ToInt32(nud_id.Value),
                    FullName = txt_fullname.Text,
                    JobTitle = txt_jobtitle.Text,
                    Salary = nud_salary.Value,
                    IsActive = chk_isactive.Checked,
                    DepartmentId = Convert.ToInt32(cmb_departments.SelectedValue)
                };
                _service.Update(em);
                LoadEmployees();
                MessageBox.Show("Employee Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(nud_id.Value)) <= 0) { MessageBox.Show("Select An Employee First"); return; }
            var confirm = MessageBox.Show("Are you sure ypu want to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;
            try
            {
                int id = Convert.ToInt32(nud_id.Value);
                _service.Delete(id);
                LoadEmployees();
                MessageBox.Show("Employee deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_employees.DataSource = null;
                dgv_employees.DataSource = _service.Search(txt_search.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
