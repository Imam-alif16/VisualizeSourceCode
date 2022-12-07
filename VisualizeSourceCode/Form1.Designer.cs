﻿namespace VisualizeSourceCode
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.diagramView1 = new MindFusion.Diagramming.WinForms.DiagramView();
            this.diagram = new MindFusion.Diagramming.Diagram();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgv_sourceCode = new System.Windows.Forms.DataGridView();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBox_sourceCode = new System.Windows.Forms.RichTextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ClassesData = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sourceCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesData)).BeginInit();
            this.tabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(9, 7);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(233, 20);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "VisualizeSourceCode-Demo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.btnVisualize);
            this.tabPage3.Controls.Add(this.diagramView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(920, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visualize";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(817, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVisualize
            // 
            this.btnVisualize.Location = new System.Drawing.Point(5, 5);
            this.btnVisualize.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(79, 31);
            this.btnVisualize.TabIndex = 1;
            this.btnVisualize.Text = "Visualize";
            this.btnVisualize.UseVisualStyleBackColor = true;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // diagramView1
            // 
            this.diagramView1.Diagram = this.diagram;
            this.diagramView1.LicenseKey = null;
            this.diagramView1.Location = new System.Drawing.Point(5, 41);
            this.diagramView1.Name = "diagramView1";
            this.diagramView1.Size = new System.Drawing.Size(910, 420);
            this.diagramView1.TabIndex = 0;
            this.diagramView1.Text = "diagramView1";
            // 
            // diagram
            // 
            this.diagram.TouchThreshold = 0F;
            this.diagram.NodeCreated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.diagram1_NodeCreated);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.dgv_sourceCode);
            this.tabPage1.Controls.Add(this.txtBox_sourceCode);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(920, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(817, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgv_sourceCode
            // 
            this.dgv_sourceCode.AllowUserToAddRows = false;
            this.dgv_sourceCode.AllowUserToDeleteRows = false;
            this.dgv_sourceCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sourceCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sourceCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.className,
            this.superClass,
            this.Id,
            this.target});
            this.dgv_sourceCode.Location = new System.Drawing.Point(381, 41);
            this.dgv_sourceCode.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_sourceCode.Name = "dgv_sourceCode";
            this.dgv_sourceCode.ReadOnly = true;
            this.dgv_sourceCode.RowHeadersWidth = 51;
            this.dgv_sourceCode.RowTemplate.Height = 24;
            this.dgv_sourceCode.Size = new System.Drawing.Size(537, 423);
            this.dgv_sourceCode.TabIndex = 2;
            // 
            // className
            // 
            this.className.DataPropertyName = "className";
            this.className.HeaderText = "Class Name";
            this.className.MinimumWidth = 6;
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // superClass
            // 
            this.superClass.DataPropertyName = "superClass";
            this.superClass.HeaderText = "Super Class";
            this.superClass.MinimumWidth = 6;
            this.superClass.Name = "superClass";
            this.superClass.ReadOnly = true;
            this.superClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // target
            // 
            this.target.DataPropertyName = "target";
            this.target.HeaderText = "target";
            this.target.Name = "target";
            this.target.ReadOnly = true;
            // 
            // txtBox_sourceCode
            // 
            this.txtBox_sourceCode.Location = new System.Drawing.Point(4, 41);
            this.txtBox_sourceCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_sourceCode.Name = "txtBox_sourceCode";
            this.txtBox_sourceCode.Size = new System.Drawing.Size(373, 424);
            this.txtBox_sourceCode.TabIndex = 1;
            this.txtBox_sourceCode.Text = "";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(4, 5);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 31);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(9, 45);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(928, 492);
            this.tabControl.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(669, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programming Languages";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Java";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizeSourceCode-Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sourceCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesData)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_sourceCode;
        private System.Windows.Forms.RichTextBox txtBox_sourceCode;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.BindingSource ClassesData;
        private MindFusion.Diagramming.Diagram diagram;
        private System.Windows.Forms.Button btnVisualize;
        private MindFusion.Diagramming.WinForms.DiagramView diagramView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn superClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

