namespace CorpBase.WinUI
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lbl_fullname;
            Label lbl_jobtitle;
            Label lbl_salary;
            Label lbl_departments;
            Label lbl_status;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnl_border = new Panel();
            pnl_main = new Panel();
            pnl_content = new Panel();
            nud_id = new NumericUpDown();
            chk_isactive = new CheckBox();
            pnl_departmentid = new Panel();
            cmb_departments = new ComboBox();
            pnl_salary = new Panel();
            nud_salary = new NumericUpDown();
            pnl_jobtitle = new Panel();
            txt_jobtitle = new TextBox();
            pnl_fullname = new Panel();
            txt_fullname = new TextBox();
            dgv_employees = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnl_create_wrapper = new Panel();
            btn_create = new Button();
            pnl_update_wrapper = new Panel();
            btn_update = new Button();
            pnl_delete_wrapper = new Panel();
            btn_delete = new Button();
            pnl_header = new Panel();
            label1 = new Label();
            txt_search_wrapper = new Panel();
            txt_search = new TextBox();
            pnl_search_wrapper = new Panel();
            btn_search = new Button();
            lbl_employees = new Label();
            btn_close = new Button();
            lbl_fullname = new Label();
            lbl_jobtitle = new Label();
            lbl_salary = new Label();
            lbl_departments = new Label();
            lbl_status = new Label();
            pnl_border.SuspendLayout();
            pnl_main.SuspendLayout();
            pnl_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_id).BeginInit();
            pnl_departmentid.SuspendLayout();
            pnl_salary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_salary).BeginInit();
            pnl_jobtitle.SuspendLayout();
            pnl_fullname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employees).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pnl_create_wrapper.SuspendLayout();
            pnl_update_wrapper.SuspendLayout();
            pnl_delete_wrapper.SuspendLayout();
            pnl_header.SuspendLayout();
            txt_search_wrapper.SuspendLayout();
            pnl_search_wrapper.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_fullname
            // 
            lbl_fullname.AutoSize = true;
            lbl_fullname.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fullname.ForeColor = Color.DimGray;
            lbl_fullname.Location = new Point(15, 15);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(60, 13);
            lbl_fullname.TabIndex = 8;
            lbl_fullname.Text = "Full Name";
            // 
            // lbl_jobtitle
            // 
            lbl_jobtitle.AutoSize = true;
            lbl_jobtitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_jobtitle.ForeColor = Color.DimGray;
            lbl_jobtitle.Location = new Point(250, 15);
            lbl_jobtitle.Name = "lbl_jobtitle";
            lbl_jobtitle.Size = new Size(51, 13);
            lbl_jobtitle.TabIndex = 9;
            lbl_jobtitle.Text = "Job Title";
            // 
            // lbl_salary
            // 
            lbl_salary.AutoSize = true;
            lbl_salary.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_salary.ForeColor = Color.DimGray;
            lbl_salary.Location = new Point(15, 80);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Size = new Size(38, 13);
            lbl_salary.TabIndex = 10;
            lbl_salary.Text = "Salary";
            // 
            // lbl_departments
            // 
            lbl_departments.AutoSize = true;
            lbl_departments.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_departments.ForeColor = Color.DimGray;
            lbl_departments.Location = new Point(160, 80);
            lbl_departments.Name = "lbl_departments";
            lbl_departments.Size = new Size(69, 13);
            lbl_departments.TabIndex = 11;
            lbl_departments.Text = "Department";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status.ForeColor = Color.DimGray;
            lbl_status.Location = new Point(330, 80);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(39, 13);
            lbl_status.TabIndex = 12;
            lbl_status.Text = "Status";
            // 
            // pnl_border
            // 
            pnl_border.BackColor = Color.FromArgb(0, 255, 200);
            pnl_border.Controls.Add(pnl_main);
            pnl_border.Dock = DockStyle.Fill;
            pnl_border.Location = new Point(2, 2);
            pnl_border.Name = "pnl_border";
            pnl_border.Padding = new Padding(1);
            pnl_border.Size = new Size(496, 596);
            pnl_border.TabIndex = 0;
            // 
            // pnl_main
            // 
            pnl_main.BackColor = Color.FromArgb(40, 40, 55);
            pnl_main.Controls.Add(pnl_content);
            pnl_main.Controls.Add(flowLayoutPanel1);
            pnl_main.Controls.Add(pnl_header);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(1, 1);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(494, 594);
            pnl_main.TabIndex = 0;
            pnl_main.Paint += pnl_main_Paint;
            // 
            // pnl_content
            // 
            pnl_content.BackColor = Color.FromArgb(35, 35, 50);
            pnl_content.Controls.Add(nud_id);
            pnl_content.Controls.Add(chk_isactive);
            pnl_content.Controls.Add(lbl_status);
            pnl_content.Controls.Add(lbl_departments);
            pnl_content.Controls.Add(lbl_salary);
            pnl_content.Controls.Add(lbl_jobtitle);
            pnl_content.Controls.Add(lbl_fullname);
            pnl_content.Controls.Add(pnl_departmentid);
            pnl_content.Controls.Add(pnl_salary);
            pnl_content.Controls.Add(pnl_jobtitle);
            pnl_content.Controls.Add(pnl_fullname);
            pnl_content.Controls.Add(dgv_employees);
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(0, 150);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(494, 444);
            pnl_content.TabIndex = 3;
            // 
            // nud_id
            // 
            nud_id.Enabled = false;
            nud_id.Location = new Point(142, 0);
            nud_id.Name = "nud_id";
            nud_id.Size = new Size(120, 23);
            nud_id.TabIndex = 14;
            nud_id.Visible = false;
            // 
            // chk_isactive
            // 
            chk_isactive.Appearance = Appearance.Button;
            chk_isactive.FlatAppearance.BorderSize = 0;
            chk_isactive.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 255, 200);
            chk_isactive.FlatStyle = FlatStyle.Flat;
            chk_isactive.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_isactive.ForeColor = Color.FromArgb(0, 255, 200);
            chk_isactive.Location = new Point(330, 97);
            chk_isactive.Name = "chk_isactive";
            chk_isactive.Padding = new Padding(5);
            chk_isactive.RightToLeft = RightToLeft.No;
            chk_isactive.Size = new Size(133, 42);
            chk_isactive.TabIndex = 13;
            chk_isactive.Text = "ACTIVE";
            chk_isactive.TextAlign = ContentAlignment.MiddleCenter;
            chk_isactive.UseVisualStyleBackColor = true;
            chk_isactive.CheckedChanged += chk_isactive_CheckedChanged;
            // 
            // pnl_departmentid
            // 
            pnl_departmentid.BackColor = Color.FromArgb(150, 100, 255);
            pnl_departmentid.Controls.Add(cmb_departments);
            pnl_departmentid.Location = new Point(160, 97);
            pnl_departmentid.Name = "pnl_departmentid";
            pnl_departmentid.Padding = new Padding(5, 10, 5, 5);
            pnl_departmentid.Size = new Size(162, 42);
            pnl_departmentid.TabIndex = 6;
            // 
            // cmb_departments
            // 
            cmb_departments.BackColor = Color.FromArgb(40, 40, 60);
            cmb_departments.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_departments.FlatStyle = FlatStyle.Flat;
            cmb_departments.Font = new Font("Segoe UI", 16F);
            cmb_departments.ForeColor = Color.White;
            cmb_departments.FormattingEnabled = true;
            cmb_departments.Location = new Point(4, 3);
            cmb_departments.Name = "cmb_departments";
            cmb_departments.Size = new Size(155, 38);
            cmb_departments.TabIndex = 0;
            // 
            // pnl_salary
            // 
            pnl_salary.BackColor = Color.FromArgb(0, 255, 200);
            pnl_salary.Controls.Add(nud_salary);
            pnl_salary.Location = new Point(15, 97);
            pnl_salary.Name = "pnl_salary";
            pnl_salary.Padding = new Padding(5, 10, 5, 5);
            pnl_salary.Size = new Size(132, 42);
            pnl_salary.TabIndex = 5;
            // 
            // nud_salary
            // 
            nud_salary.BackColor = Color.FromArgb(40, 40, 60);
            nud_salary.BorderStyle = BorderStyle.None;
            nud_salary.Font = new Font("Segoe UI", 19F);
            nud_salary.ForeColor = Color.White;
            nud_salary.Location = new Point(3, 3);
            nud_salary.Name = "nud_salary";
            nud_salary.Size = new Size(140, 37);
            nud_salary.TabIndex = 0;
            nud_salary.TextAlign = HorizontalAlignment.Center;
            // 
            // pnl_jobtitle
            // 
            pnl_jobtitle.BackColor = Color.FromArgb(0, 255, 200);
            pnl_jobtitle.Controls.Add(txt_jobtitle);
            pnl_jobtitle.Location = new Point(250, 33);
            pnl_jobtitle.Name = "pnl_jobtitle";
            pnl_jobtitle.Padding = new Padding(8, 10, 8, 5);
            pnl_jobtitle.Size = new Size(215, 40);
            pnl_jobtitle.TabIndex = 4;
            // 
            // txt_jobtitle
            // 
            txt_jobtitle.BackColor = Color.FromArgb(40, 40, 60);
            txt_jobtitle.BorderStyle = BorderStyle.None;
            txt_jobtitle.Font = new Font("Segoe UI", 20F);
            txt_jobtitle.ForeColor = Color.White;
            txt_jobtitle.Location = new Point(3, 2);
            txt_jobtitle.Name = "txt_jobtitle";
            txt_jobtitle.Size = new Size(210, 36);
            txt_jobtitle.TabIndex = 2;
            // 
            // pnl_fullname
            // 
            pnl_fullname.BackColor = Color.FromArgb(0, 255, 200);
            pnl_fullname.Controls.Add(txt_fullname);
            pnl_fullname.Location = new Point(15, 33);
            pnl_fullname.Name = "pnl_fullname";
            pnl_fullname.Padding = new Padding(8, 10, 8, 5);
            pnl_fullname.Size = new Size(212, 40);
            pnl_fullname.TabIndex = 3;
            // 
            // txt_fullname
            // 
            txt_fullname.BackColor = Color.FromArgb(40, 40, 60);
            txt_fullname.BorderStyle = BorderStyle.None;
            txt_fullname.Font = new Font("Segoe UI", 20F);
            txt_fullname.ForeColor = Color.White;
            txt_fullname.Location = new Point(2, 2);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(207, 36);
            txt_fullname.TabIndex = 1;
            // 
            // dgv_employees
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dgv_employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_employees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_employees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_employees.BackgroundColor = Color.FromArgb(30, 30, 45);
            dgv_employees.BorderStyle = BorderStyle.None;
            dgv_employees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 255, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 50, 75);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 100);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_employees.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_employees.EnableHeadersVisualStyles = false;
            dgv_employees.GridColor = Color.FromArgb(50, 50, 70);
            dgv_employees.Location = new Point(15, 161);
            dgv_employees.Name = "dgv_employees";
            dgv_employees.RowHeadersVisible = false;
            dgv_employees.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 50);
            dgv_employees.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgv_employees.RowTemplate.Height = 35;
            dgv_employees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_employees.Size = new Size(464, 270);
            dgv_employees.TabIndex = 2;
            dgv_employees.CellClick += dgv_employees_CellClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pnl_create_wrapper);
            flowLayoutPanel1.Controls.Add(pnl_update_wrapper);
            flowLayoutPanel1.Controls.Add(pnl_delete_wrapper);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 10, 0, 0);
            flowLayoutPanel1.Size = new Size(494, 50);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pnl_create_wrapper
            // 
            pnl_create_wrapper.BackColor = Color.FromArgb(0, 255, 200);
            pnl_create_wrapper.Controls.Add(btn_create);
            pnl_create_wrapper.Location = new Point(18, 13);
            pnl_create_wrapper.Name = "pnl_create_wrapper";
            pnl_create_wrapper.Padding = new Padding(1);
            pnl_create_wrapper.Size = new Size(149, 30);
            pnl_create_wrapper.TabIndex = 5;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.FromArgb(30, 30, 45);
            btn_create.Dock = DockStyle.Fill;
            btn_create.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
            btn_create.FlatAppearance.BorderSize = 0;
            btn_create.FlatStyle = FlatStyle.Flat;
            btn_create.ForeColor = Color.White;
            btn_create.Location = new Point(1, 1);
            btn_create.Margin = new Padding(0, 0, 10, 0);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(147, 28);
            btn_create.TabIndex = 4;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // pnl_update_wrapper
            // 
            pnl_update_wrapper.BackColor = Color.FromArgb(150, 100, 255);
            pnl_update_wrapper.Controls.Add(btn_update);
            pnl_update_wrapper.Location = new Point(173, 13);
            pnl_update_wrapper.Name = "pnl_update_wrapper";
            pnl_update_wrapper.Padding = new Padding(1);
            pnl_update_wrapper.Size = new Size(149, 30);
            pnl_update_wrapper.TabIndex = 6;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(30, 30, 45);
            btn_update.Dock = DockStyle.Fill;
            btn_update.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(1, 1);
            btn_update.Margin = new Padding(0, 0, 10, 0);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(147, 28);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // pnl_delete_wrapper
            // 
            pnl_delete_wrapper.BackColor = Color.FromArgb(255, 80, 80);
            pnl_delete_wrapper.Controls.Add(btn_delete);
            pnl_delete_wrapper.Location = new Point(328, 13);
            pnl_delete_wrapper.Name = "pnl_delete_wrapper";
            pnl_delete_wrapper.Padding = new Padding(1);
            pnl_delete_wrapper.Size = new Size(149, 30);
            pnl_delete_wrapper.TabIndex = 7;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(30, 30, 45);
            btn_delete.Dock = DockStyle.Fill;
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(1, 1);
            btn_delete.Margin = new Padding(0, 0, 10, 0);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(147, 28);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(label1);
            pnl_header.Controls.Add(txt_search_wrapper);
            pnl_header.Controls.Add(pnl_search_wrapper);
            pnl_header.Controls.Add(lbl_employees);
            pnl_header.Controls.Add(btn_close);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Padding = new Padding(10, 20, 10, 10);
            pnl_header.Size = new Size(494, 100);
            pnl_header.TabIndex = 0;
            pnl_header.MouseDown += pnl_header_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(29, 19);
            label1.TabIndex = 7;
            label1.Text = "";
            // 
            // txt_search_wrapper
            // 
            txt_search_wrapper.BackColor = Color.FromArgb(200, 225, 200);
            txt_search_wrapper.Controls.Add(txt_search);
            txt_search_wrapper.Location = new Point(18, 48);
            txt_search_wrapper.Name = "txt_search_wrapper";
            txt_search_wrapper.Padding = new Padding(2);
            txt_search_wrapper.Size = new Size(354, 26);
            txt_search_wrapper.TabIndex = 3;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(40, 40, 60);
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Dock = DockStyle.Fill;
            txt_search.Font = new Font("Segoe UI", 12F);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(2, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(350, 22);
            txt_search.TabIndex = 0;
            // 
            // pnl_search_wrapper
            // 
            pnl_search_wrapper.BackColor = Color.FromArgb(200, 225, 200);
            pnl_search_wrapper.Controls.Add(btn_search);
            pnl_search_wrapper.Location = new Point(379, 47);
            pnl_search_wrapper.Name = "pnl_search_wrapper";
            pnl_search_wrapper.Padding = new Padding(1);
            pnl_search_wrapper.Size = new Size(97, 28);
            pnl_search_wrapper.TabIndex = 6;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(30, 30, 45);
            btn_search.Dock = DockStyle.Fill;
            btn_search.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(1, 1);
            btn_search.Margin = new Padding(0, 0, 10, 0);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(95, 26);
            btn_search.TabIndex = 4;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // lbl_employees
            // 
            lbl_employees.AutoSize = true;
            lbl_employees.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_employees.ForeColor = Color.White;
            lbl_employees.Location = new Point(44, 14);
            lbl_employees.Name = "lbl_employees";
            lbl_employees.Size = new Size(104, 25);
            lbl_employees.TabIndex = 4;
            lbl_employees.Text = "Employees";
            // 
            // btn_close
            // 
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.FromArgb(255, 80, 80);
            btn_close.Location = new Point(456, -1);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(39, 36);
            btn_close.TabIndex = 3;
            btn_close.Text = "x";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += button1_Click;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 35);
            ClientSize = new Size(500, 600);
            Controls.Add(pnl_border);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesForm";
            Opacity = 0.95D;
            Padding = new Padding(2);
            Text = "EmployeesForm";
            Load += EmployeesForm_Load;
            pnl_border.ResumeLayout(false);
            pnl_main.ResumeLayout(false);
            pnl_content.ResumeLayout(false);
            pnl_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_id).EndInit();
            pnl_departmentid.ResumeLayout(false);
            pnl_salary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_salary).EndInit();
            pnl_jobtitle.ResumeLayout(false);
            pnl_jobtitle.PerformLayout();
            pnl_fullname.ResumeLayout(false);
            pnl_fullname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employees).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pnl_create_wrapper.ResumeLayout(false);
            pnl_update_wrapper.ResumeLayout(false);
            pnl_delete_wrapper.ResumeLayout(false);
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            txt_search_wrapper.ResumeLayout(false);
            txt_search_wrapper.PerformLayout();
            pnl_search_wrapper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_border;
        private Panel pnl_main;
        private Panel pnl_header;
        private TextBox txt_search;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_create;
        private DataGridView dgv_employees;
        private Button btn_close;
        private Label lbl_employees;
        private Panel pnl_create_wrapper;
        private Panel pnl_update_wrapper;
        private Button btn_update;
        private Panel pnl_delete_wrapper;
        private Button btn_delete;
        private Panel pnl_search_wrapper;
        private Button btn_search;
        private Panel txt_search_wrapper;
        private Panel pnl_content;
        private Panel pnl_departmentid;
        private Panel pnl_salary;
        private Panel pnl_jobtitle;
        private Panel pnl_fullname;
        private Label lbl_fullname;
        private Panel pnl_isactive;
        private NumericUpDown nud_salary;
        private ComboBox cmb_departments;
        private TextBox txt_jobtitle;
        private TextBox txt_fullname;
        private CheckBox checkBox1;
        private CheckBox chk_isactive;
        private Label label1;
        private NumericUpDown nud_id;
    }
}