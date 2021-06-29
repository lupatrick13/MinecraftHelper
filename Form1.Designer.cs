
namespace MinecraftHelper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Console = new System.Windows.Forms.TextBox();
            this.AddRecipeButton_Submit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TestTree = new System.Windows.Forms.TreeView();
            this.AddRecipe_Type = new System.Windows.Forms.ComboBox();
            this.AddRecipeText_Amt = new System.Windows.Forms.TextBox();
            this.AddRecipeText_Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ER_CR_LIST = new System.Windows.Forms.ListBox();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ER_DataGrid = new System.Windows.Forms.DataGridView();
            this.recipeFacadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ER_DM_SUB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ER_AM_AMT = new System.Windows.Forms.NumericUpDown();
            this.ER_AM_SUB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ER_AM_ChoicesList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ER_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeFacadeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ER_AM_AMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Console.Location = new System.Drawing.Point(12, 289);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(782, 147);
            this.Console.TabIndex = 0;
            // 
            // AddRecipeButton_Submit
            // 
            this.AddRecipeButton_Submit.Location = new System.Drawing.Point(6, 114);
            this.AddRecipeButton_Submit.Name = "AddRecipeButton_Submit";
            this.AddRecipeButton_Submit.Size = new System.Drawing.Size(75, 23);
            this.AddRecipeButton_Submit.TabIndex = 5;
            this.AddRecipeButton_Submit.Text = "Submit";
            this.AddRecipeButton_Submit.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 271);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.TestTree);
            this.tabPage1.Controls.Add(this.AddRecipe_Type);
            this.tabPage1.Controls.Add(this.AddRecipeText_Amt);
            this.tabPage1.Controls.Add(this.AddRecipeText_Name);
            this.tabPage1.Controls.Add(this.AddRecipeButton_Submit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Recipe";
            // 
            // TestTree
            // 
            this.TestTree.Location = new System.Drawing.Point(506, 17);
            this.TestTree.Name = "TestTree";
            this.TestTree.Size = new System.Drawing.Size(247, 206);
            this.TestTree.TabIndex = 9;
            // 
            // AddRecipe_Type
            // 
            this.AddRecipe_Type.FormattingEnabled = true;
            this.AddRecipe_Type.Items.AddRange(new object[] {
            "- Choose One -",
            "Liquid",
            "Item"});
            this.AddRecipe_Type.Location = new System.Drawing.Point(6, 87);
            this.AddRecipe_Type.Name = "AddRecipe_Type";
            this.AddRecipe_Type.Size = new System.Drawing.Size(121, 21);
            this.AddRecipe_Type.TabIndex = 8;
            // 
            // AddRecipeText_Amt
            // 
            this.AddRecipeText_Amt.Location = new System.Drawing.Point(6, 52);
            this.AddRecipeText_Amt.Name = "AddRecipeText_Amt";
            this.AddRecipeText_Amt.Size = new System.Drawing.Size(121, 20);
            this.AddRecipeText_Amt.TabIndex = 7;
            // 
            // AddRecipeText_Name
            // 
            this.AddRecipeText_Name.Location = new System.Drawing.Point(6, 17);
            this.AddRecipeText_Name.Name = "AddRecipeText_Name";
            this.AddRecipeText_Name.Size = new System.Drawing.Size(121, 20);
            this.AddRecipeText_Name.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Recipe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ER_CR_LIST);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 230);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Recipe";
            // 
            // ER_CR_LIST
            // 
            this.ER_CR_LIST.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ER_CR_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ER_CR_LIST.DataSource = this.recipeBindingSource;
            this.ER_CR_LIST.DisplayMember = "Name";
            this.ER_CR_LIST.FormattingEnabled = true;
            this.ER_CR_LIST.HorizontalScrollbar = true;
            this.ER_CR_LIST.Location = new System.Drawing.Point(6, 22);
            this.ER_CR_LIST.MultiColumn = true;
            this.ER_CR_LIST.Name = "ER_CR_LIST";
            this.ER_CR_LIST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ER_CR_LIST.Size = new System.Drawing.Size(158, 195);
            this.ER_CR_LIST.Sorted = true;
            this.ER_CR_LIST.TabIndex = 5;
            this.ER_CR_LIST.SelectedIndexChanged += new System.EventHandler(this.ER_CR_LIST_SelectedIndexChanged);
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataSource = typeof(MinecraftHelper.src.comp.Recipe);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ER_DataGrid);
            this.groupBox2.Controls.Add(this.ER_DM_SUB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Materials";
            // 
            // ER_DataGrid
            // 
            this.ER_DataGrid.AllowUserToAddRows = false;
            this.ER_DataGrid.AllowUserToDeleteRows = false;
            this.ER_DataGrid.AllowUserToResizeColumns = false;
            this.ER_DataGrid.AllowUserToResizeRows = false;
            this.ER_DataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ER_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ER_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ER_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.needDataGridViewTextBoxColumn,
            this.makesDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.ER_DataGrid.DataSource = this.recipeFacadeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ER_DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ER_DataGrid.Location = new System.Drawing.Point(6, 16);
            this.ER_DataGrid.Name = "ER_DataGrid";
            this.ER_DataGrid.Size = new System.Drawing.Size(398, 175);
            this.ER_DataGrid.TabIndex = 7;
            // 
            // recipeFacadeBindingSource
            // 
            this.recipeFacadeBindingSource.DataSource = typeof(MinecraftHelper.src.comp.RecipeFacade);
            // 
            // ER_DM_SUB
            // 
            this.ER_DM_SUB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ER_DM_SUB.Location = new System.Drawing.Point(169, 197);
            this.ER_DM_SUB.Name = "ER_DM_SUB";
            this.ER_DM_SUB.Size = new System.Drawing.Size(75, 23);
            this.ER_DM_SUB.TabIndex = 5;
            this.ER_DM_SUB.Text = "Delete";
            this.ER_DM_SUB.UseVisualStyleBackColor = true;
            this.ER_DM_SUB.Click += new System.EventHandler(this.ER_DM_SUB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ER_AM_AMT);
            this.groupBox1.Controls.Add(this.ER_AM_SUB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ER_AM_ChoicesList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(182, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Materials";
            // 
            // ER_AM_AMT
            // 
            this.ER_AM_AMT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ER_AM_AMT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ER_AM_AMT.Location = new System.Drawing.Point(37, 202);
            this.ER_AM_AMT.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ER_AM_AMT.Name = "ER_AM_AMT";
            this.ER_AM_AMT.Size = new System.Drawing.Size(50, 16);
            this.ER_AM_AMT.TabIndex = 5;
            this.ER_AM_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ER_AM_AMT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ER_AM_SUB
            // 
            this.ER_AM_SUB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ER_AM_SUB.Location = new System.Drawing.Point(119, 197);
            this.ER_AM_SUB.Name = "ER_AM_SUB";
            this.ER_AM_SUB.Size = new System.Drawing.Size(45, 23);
            this.ER_AM_SUB.TabIndex = 4;
            this.ER_AM_SUB.Text = "Add";
            this.ER_AM_SUB.UseVisualStyleBackColor = true;
            this.ER_AM_SUB.Click += new System.EventHandler(this.ER_AM_SUB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amt";
            // 
            // ER_AM_ChoicesList
            // 
            this.ER_AM_ChoicesList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ER_AM_ChoicesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ER_AM_ChoicesList.DataSource = this.recipeBindingSource;
            this.ER_AM_ChoicesList.DisplayMember = "Name";
            this.ER_AM_ChoicesList.FormattingEnabled = true;
            this.ER_AM_ChoicesList.HorizontalScrollbar = true;
            this.ER_AM_ChoicesList.Location = new System.Drawing.Point(6, 19);
            this.ER_AM_ChoicesList.MultiColumn = true;
            this.ER_AM_ChoicesList.Name = "ER_AM_ChoicesList";
            this.ER_AM_ChoicesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ER_AM_ChoicesList.Size = new System.Drawing.Size(158, 169);
            this.ER_AM_ChoicesList.Sorted = true;
            this.ER_AM_ChoicesList.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "Components";
            this.componentsBindingSource.DataSource = this.recipeBindingSource;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 175;
            // 
            // needDataGridViewTextBoxColumn
            // 
            this.needDataGridViewTextBoxColumn.DataPropertyName = "Need";
            this.needDataGridViewTextBoxColumn.HeaderText = "Needs";
            this.needDataGridViewTextBoxColumn.Name = "needDataGridViewTextBoxColumn";
            this.needDataGridViewTextBoxColumn.ReadOnly = true;
            this.needDataGridViewTextBoxColumn.Width = 60;
            // 
            // makesDataGridViewTextBoxColumn
            // 
            this.makesDataGridViewTextBoxColumn.DataPropertyName = "Makes";
            this.makesDataGridViewTextBoxColumn.HeaderText = "Makes";
            this.makesDataGridViewTextBoxColumn.Name = "makesDataGridViewTextBoxColumn";
            this.makesDataGridViewTextBoxColumn.ReadOnly = true;
            this.makesDataGridViewTextBoxColumn.Width = 60;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ER_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeFacadeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ER_AM_AMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Button AddRecipeButton_Submit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox AddRecipeText_Name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox AddRecipeText_Amt;
        private System.Windows.Forms.ComboBox AddRecipe_Type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ER_AM_ChoicesList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.ComponentModel.BindingList<MinecraftHelper.src.comp.Recipe> CurrentRecipes;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ER_AM_SUB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ER_DM_SUB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ER_CR_LIST;
        private System.Windows.Forms.DataGridView ER_DataGrid;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private System.Windows.Forms.BindingSource recipeFacadeBindingSource;
        private System.Windows.Forms.TreeView TestTree;
        private MinecraftHelper.src.comp.Recipe ER_SelectedRecipe;
        private System.Windows.Forms.NumericUpDown ER_AM_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn needDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}

