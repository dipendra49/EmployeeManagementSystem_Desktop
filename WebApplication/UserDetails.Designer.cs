
namespace LogINForm
{
    partial class UserDetails
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
            this.labelManageEmployee = new Wisej.Web.Label();
            this.labelEmployeeID = new Wisej.Web.Label();
            this.employeeIDTextBox = new Wisej.Web.TextBox();
            this.labelEmployeeName = new Wisej.Web.Label();
            this.employeeNameTextBox = new Wisej.Web.TextBox();
            this.addressTextBox = new Wisej.Web.TextBox();
            this.labelAddress = new Wisej.Web.Label();
            this.labelSalary = new Wisej.Web.Label();
            this.salaryTextBox = new Wisej.Web.TextBox();
            this.addBtn = new Wisej.Web.Button();
            this.updateBtn = new Wisej.Web.Button();
            this.deleteBtn = new Wisej.Web.Button();
            this.clearBtn = new Wisej.Web.Button();
            this.employeeDataGridView = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageEmployee
            // 
            this.labelManageEmployee.AutoSize = true;
            this.labelManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageEmployee.Location = new System.Drawing.Point(57, 25);
            this.labelManageEmployee.Name = "labelManageEmployee";
            this.labelManageEmployee.Size = new System.Drawing.Size(447, 32);
            this.labelManageEmployee.TabIndex = 1;
            this.labelManageEmployee.Text = "MANAGE EMPLOYEE DETAILS";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(16, 99);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(134, 25);
            this.labelEmployeeID.TabIndex = 2;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(170, 100);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(167, 22);
            this.employeeIDTextBox.TabIndex = 4;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(44, 160);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(68, 25);
            this.labelEmployeeName.TabIndex = 5;
            this.labelEmployeeName.Text = "Name";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(170, 160);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(167, 22);
            this.employeeNameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(170, 214);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(167, 22);
            this.addressTextBox.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(31, 210);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(92, 25);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(38, 270);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(74, 25);
            this.labelSalary.TabIndex = 9;
            this.labelSalary.Text = "Salary";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(170, 270);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(167, 22);
            this.salaryTextBox.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(37, 342);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 34);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(140, 342);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(106, 34);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(275, 342);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 34);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(140, 394);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 30);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(547, 87);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(683, 318);
            this.employeeDataGridView.TabIndex = 15;
            this.employeeDataGridView.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
            this.employeeDataGridView.CellContentClick += new Wisej.Web.DataGridViewCellEventHandler(this.employeeDataGridView_CellContentClick);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 450);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.labelManageEmployee);
            this.Name = "UserDetails";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label labelManageEmployee;
        private Wisej.Web.Label labelEmployeeID;
        private Wisej.Web.TextBox employeeIDTextBox;
        private Wisej.Web.Label labelEmployeeName;
        private Wisej.Web.TextBox employeeNameTextBox;
        private Wisej.Web.TextBox addressTextBox;
        private Wisej.Web.Label labelAddress;
        private Wisej.Web.Label labelSalary;
        private Wisej.Web.TextBox salaryTextBox;
        private Wisej.Web.Button addBtn;
        private Wisej.Web.Button updateBtn;
        private Wisej.Web.Button deleteBtn;
        private Wisej.Web.Button clearBtn;
        private Wisej.Web.DataGridView employeeDataGridView;
    }
}