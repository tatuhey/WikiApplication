namespace WikiApplication
{
    partial class wikiApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textDefinition = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.dataListView = new System.Windows.Forms.ListView();
            this.dataName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.gbStructure = new System.Windows.Forms.GroupBox();
            this.radBtnNonlinear = new System.Windows.Forms.RadioButton();
            this.radBtnLinear = new System.Windows.Forms.RadioButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.gbStructure.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Wiki Application";
            // 
            // textSearch
            // 
            this.textSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textSearch.Location = new System.Drawing.Point(532, 53);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(179, 20);
            this.textSearch.TabIndex = 35;
            this.textSearch.Text = "Search by name";
            this.textSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textSearch_MouseClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(717, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(451, 50);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(451, 21);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 31;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(370, 183);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 48);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(370, 132);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 45);
            this.buttonEdit.TabIndex = 29;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(370, 81);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 45);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(12, 239);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(76, 20);
            this.labelDefinition.TabIndex = 27;
            this.labelDefinition.Text = "Definition";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(12, 109);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 20);
            this.labelCategory.TabIndex = 25;
            this.labelCategory.Text = "Category";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Name";
            // 
            // textDefinition
            // 
            this.textDefinition.Location = new System.Drawing.Point(16, 262);
            this.textDefinition.Multiline = true;
            this.textDefinition.Name = "textDefinition";
            this.textDefinition.Size = new System.Drawing.Size(348, 148);
            this.textDefinition.TabIndex = 23;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(16, 81);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(348, 20);
            this.textName.TabIndex = 20;
            this.textName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textName_MouseDoubleClick);
            // 
            // dataListView
            // 
            this.dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataName,
            this.dataCategory});
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(451, 81);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(341, 329);
            this.dataListView.TabIndex = 19;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            this.dataListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataListView_MouseClick);
            // 
            // dataName
            // 
            this.dataName.Text = "Name";
            this.dataName.Width = 150;
            // 
            // dataCategory
            // 
            this.dataCategory.Text = "Category";
            this.dataCategory.Width = 81;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(16, 133);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(348, 21);
            this.cbCategory.TabIndex = 37;
            this.cbCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCategory_KeyPress);
            // 
            // gbStructure
            // 
            this.gbStructure.Controls.Add(this.radBtnNonlinear);
            this.gbStructure.Controls.Add(this.radBtnLinear);
            this.gbStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStructure.Location = new System.Drawing.Point(16, 160);
            this.gbStructure.Name = "gbStructure";
            this.gbStructure.Size = new System.Drawing.Size(348, 71);
            this.gbStructure.TabIndex = 38;
            this.gbStructure.TabStop = false;
            this.gbStructure.Text = "Structure";
            // 
            // radBtnNonlinear
            // 
            this.radBtnNonlinear.AutoSize = true;
            this.radBtnNonlinear.Location = new System.Drawing.Point(131, 34);
            this.radBtnNonlinear.Name = "radBtnNonlinear";
            this.radBtnNonlinear.Size = new System.Drawing.Size(105, 24);
            this.radBtnNonlinear.TabIndex = 1;
            this.radBtnNonlinear.TabStop = true;
            this.radBtnNonlinear.Text = "Non-Linear";
            this.radBtnNonlinear.UseVisualStyleBackColor = true;
            // 
            // radBtnLinear
            // 
            this.radBtnLinear.AutoSize = true;
            this.radBtnLinear.Location = new System.Drawing.Point(6, 34);
            this.radBtnLinear.Name = "radBtnLinear";
            this.radBtnLinear.Size = new System.Drawing.Size(71, 24);
            this.radBtnLinear.TabIndex = 0;
            this.radBtnLinear.TabStop = true;
            this.radBtnLinear.Text = "Linear";
            this.radBtnLinear.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(806, 22);
            this.statusStrip.TabIndex = 39;
            this.statusStrip.Text = "statusStrip";
            // 
            // stStripLabel
            // 
            this.stStripLabel.Name = "stStripLabel";
            this.stStripLabel.Size = new System.Drawing.Size(77, 17);
            this.stStripLabel.Text = "STATUS STRIP";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // wikiApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbStructure);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textDefinition);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dataListView);
            this.Name = "wikiApplication";
            this.Text = "Wiki Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.wikiApplication_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wikiApplication_MouseClick);
            this.gbStructure.ResumeLayout(false);
            this.gbStructure.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textDefinition;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.ColumnHeader dataName;
        private System.Windows.Forms.ColumnHeader dataCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox gbStructure;
        private System.Windows.Forms.RadioButton radBtnNonlinear;
        private System.Windows.Forms.RadioButton radBtnLinear;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stStripLabel;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

