﻿/**
 * Editor for MARC records
 *
 * This project is built upon the CSharp_MARC project of the same name available
 * at http://csharpmarc.net, which itself is based on the File_MARC package
 * (http://pear.php.net/package/File_MARC) by Dan Scott, which was based on PHP
 * MARC package, originally called "php-marc", that is part of the Emilda
 * Project (http://www.emilda.org). Both projects were released under the LGPL
 * which allowed me to port the project to C# for use with the .NET Framework.
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * @author    Mattie Schraeder <mattie@csharpmarc.net>
 * @copyright 2016-2018 Mattie Schraeder
 * @license   http://www.gnu.org/licenses/gpl-3.0.html  GPL License 3
 */

namespace CSharp_MARC_Editor
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.recordsDataGridView = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyrightDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainEntryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custom4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custom5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidationErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcDataSet = new CSharp_MARC_Editor.MARCDataSet();
            this.fieldsSortButton = new System.Windows.Forms.Button();
            this.fieldDownButton = new System.Windows.Forms.Button();
            this.fieldUpButton = new System.Windows.Forms.Button();
            this.subfieldSortButton = new System.Windows.Forms.Button();
            this.subfieldDownButton = new System.Windows.Forms.Button();
            this.subfieldUpButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.progressToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helptextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cancelButtonToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.previewTextBox = new System.Windows.Forms.TextBox();
            this.subfieldsDataGridView = new System.Windows.Forms.DataGridView();
            this.subfieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldsDataGridView = new System.Windows.Forms.DataGridView();
            this.fieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ind1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ind2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromZ3950SRUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBlankRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedBatchEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAllFieldsAndSubfieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordListAtTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseOnExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARC8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceUTF8ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToRDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightDateByDecadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.exportingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.csvExportBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.rebuildBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.loadingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.rdaConversionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.validationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.sortAllBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.batchEditBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.importingXMLBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcDataSet)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subfieldsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsDataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer.Panel1.Controls.Add(this.recordsDataGridView);
            this.splitContainer.Panel1MinSize = 50;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.fieldsSortButton);
            this.splitContainer.Panel2.Controls.Add(this.fieldDownButton);
            this.splitContainer.Panel2.Controls.Add(this.fieldUpButton);
            this.splitContainer.Panel2.Controls.Add(this.subfieldSortButton);
            this.splitContainer.Panel2.Controls.Add(this.subfieldDownButton);
            this.splitContainer.Panel2.Controls.Add(this.subfieldUpButton);
            this.splitContainer.Panel2.Controls.Add(this.statusStrip);
            this.splitContainer.Panel2.Controls.Add(this.previewTextBox);
            this.splitContainer.Panel2.Controls.Add(this.subfieldsDataGridView);
            this.splitContainer.Panel2.Controls.Add(this.fieldsDataGridView);
            this.splitContainer.Size = new System.Drawing.Size(984, 613);
            this.splitContainer.SplitterDistance = 150;
            this.splitContainer.SplitterWidth = 15;
            this.splitContainer.TabIndex = 1;
            // 
            // recordsDataGridView
            // 
            this.recordsDataGridView.AllowUserToAddRows = false;
            this.recordsDataGridView.AllowUserToResizeRows = false;
            this.recordsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordsDataGridView.AutoGenerateColumns = false;
            this.recordsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.recordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.dateChangedDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.CopyrightDate,
            this.barcodeDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn,
            this.mainEntryDataGridViewTextBoxColumn,
            this.Custom1,
            this.Custom2,
            this.Custom3,
            this.Custom4,
            this.Custom5,
            this.ImportErrors,
            this.ValidationErrors});
            this.recordsDataGridView.DataMember = "Records";
            this.recordsDataGridView.DataSource = this.marcDataSet;
            this.recordsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.recordsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.recordsDataGridView.Name = "recordsDataGridView";
            this.recordsDataGridView.ReadOnly = true;
            this.recordsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordsDataGridView.Size = new System.Drawing.Size(984, 150);
            this.recordsDataGridView.TabIndex = 0;
            this.recordsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordsDataGridView_CellClick);
            this.recordsDataGridView.SelectionChanged += new System.EventHandler(this.recordsDataGridView_SelectionChanged);
            this.recordsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.recordsDataGridView_UserDeletingRow);
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.recordIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAddedDataGridViewTextBoxColumn.Width = 140;
            // 
            // dateChangedDataGridViewTextBoxColumn
            // 
            this.dateChangedDataGridViewTextBoxColumn.DataPropertyName = "DateChanged";
            this.dateChangedDataGridViewTextBoxColumn.HeaderText = "Date Changed";
            this.dateChangedDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.dateChangedDataGridViewTextBoxColumn.Name = "dateChangedDataGridViewTextBoxColumn";
            this.dateChangedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateChangedDataGridViewTextBoxColumn.Width = 140;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 200;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.titleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 400;
            // 
            // CopyrightDate
            // 
            this.CopyrightDate.DataPropertyName = "CopyrightDate";
            this.CopyrightDate.HeaderText = "Copyright Date";
            this.CopyrightDate.Name = "CopyrightDate";
            this.CopyrightDate.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            this.classificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainEntryDataGridViewTextBoxColumn
            // 
            this.mainEntryDataGridViewTextBoxColumn.DataPropertyName = "MainEntry";
            this.mainEntryDataGridViewTextBoxColumn.HeaderText = "Main Entry";
            this.mainEntryDataGridViewTextBoxColumn.Name = "mainEntryDataGridViewTextBoxColumn";
            this.mainEntryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Custom1
            // 
            this.Custom1.DataPropertyName = "Custom1";
            this.Custom1.HeaderText = "Custom1";
            this.Custom1.Name = "Custom1";
            this.Custom1.ReadOnly = true;
            // 
            // Custom2
            // 
            this.Custom2.DataPropertyName = "Custom2";
            this.Custom2.HeaderText = "Custom2";
            this.Custom2.Name = "Custom2";
            this.Custom2.ReadOnly = true;
            // 
            // Custom3
            // 
            this.Custom3.DataPropertyName = "Custom3";
            this.Custom3.HeaderText = "Custom3";
            this.Custom3.Name = "Custom3";
            this.Custom3.ReadOnly = true;
            // 
            // Custom4
            // 
            this.Custom4.DataPropertyName = "Custom4";
            this.Custom4.HeaderText = "Custom4";
            this.Custom4.Name = "Custom4";
            this.Custom4.ReadOnly = true;
            // 
            // Custom5
            // 
            this.Custom5.DataPropertyName = "Custom5";
            this.Custom5.HeaderText = "Custom5";
            this.Custom5.Name = "Custom5";
            this.Custom5.ReadOnly = true;
            // 
            // ImportErrors
            // 
            this.ImportErrors.DataPropertyName = "ImportErrors";
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportErrors.DefaultCellStyle = dataGridViewCellStyle19;
            this.ImportErrors.HeaderText = "Import Errors";
            this.ImportErrors.Name = "ImportErrors";
            this.ImportErrors.ReadOnly = true;
            this.ImportErrors.Width = 500;
            // 
            // ValidationErrors
            // 
            this.ValidationErrors.DataPropertyName = "ValidationErrors";
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ValidationErrors.DefaultCellStyle = dataGridViewCellStyle20;
            this.ValidationErrors.HeaderText = "Validation Errors";
            this.ValidationErrors.Name = "ValidationErrors";
            this.ValidationErrors.ReadOnly = true;
            this.ValidationErrors.Width = 500;
            // 
            // marcDataSet
            // 
            this.marcDataSet.DataSetName = "MARCDataSet";
            this.marcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldsSortButton
            // 
            this.fieldsSortButton.Image = ((System.Drawing.Image)(resources.GetObject("fieldsSortButton.Image")));
            this.fieldsSortButton.Location = new System.Drawing.Point(211, 258);
            this.fieldsSortButton.Name = "fieldsSortButton";
            this.fieldsSortButton.Size = new System.Drawing.Size(26, 56);
            this.fieldsSortButton.TabIndex = 12;
            this.toolTip.SetToolTip(this.fieldsSortButton, "Sort fields by tag number");
            this.fieldsSortButton.UseVisualStyleBackColor = true;
            this.fieldsSortButton.Click += new System.EventHandler(this.fieldsSortButton_Click);
            // 
            // fieldDownButton
            // 
            this.fieldDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fieldDownButton.Image")));
            this.fieldDownButton.Location = new System.Drawing.Point(211, 196);
            this.fieldDownButton.Name = "fieldDownButton";
            this.fieldDownButton.Size = new System.Drawing.Size(26, 56);
            this.fieldDownButton.TabIndex = 11;
            this.toolTip.SetToolTip(this.fieldDownButton, "Move field down");
            this.fieldDownButton.UseVisualStyleBackColor = true;
            this.fieldDownButton.Click += new System.EventHandler(this.fieldDownButton_Click);
            // 
            // fieldUpButton
            // 
            this.fieldUpButton.Image = ((System.Drawing.Image)(resources.GetObject("fieldUpButton.Image")));
            this.fieldUpButton.Location = new System.Drawing.Point(211, 134);
            this.fieldUpButton.Name = "fieldUpButton";
            this.fieldUpButton.Size = new System.Drawing.Size(26, 56);
            this.fieldUpButton.TabIndex = 10;
            this.toolTip.SetToolTip(this.fieldUpButton, "Move field up");
            this.fieldUpButton.UseVisualStyleBackColor = true;
            this.fieldUpButton.Click += new System.EventHandler(this.fieldUpButton_Click);
            // 
            // subfieldSortButton
            // 
            this.subfieldSortButton.Image = ((System.Drawing.Image)(resources.GetObject("subfieldSortButton.Image")));
            this.subfieldSortButton.Location = new System.Drawing.Point(656, 258);
            this.subfieldSortButton.Name = "subfieldSortButton";
            this.subfieldSortButton.Size = new System.Drawing.Size(26, 56);
            this.subfieldSortButton.TabIndex = 9;
            this.toolTip.SetToolTip(this.subfieldSortButton, "Sort subfields by code");
            this.subfieldSortButton.UseVisualStyleBackColor = true;
            this.subfieldSortButton.Click += new System.EventHandler(this.subfieldSortButton_Click);
            // 
            // subfieldDownButton
            // 
            this.subfieldDownButton.Image = ((System.Drawing.Image)(resources.GetObject("subfieldDownButton.Image")));
            this.subfieldDownButton.Location = new System.Drawing.Point(656, 196);
            this.subfieldDownButton.Name = "subfieldDownButton";
            this.subfieldDownButton.Size = new System.Drawing.Size(26, 56);
            this.subfieldDownButton.TabIndex = 5;
            this.toolTip.SetToolTip(this.subfieldDownButton, "Move subfield down");
            this.subfieldDownButton.UseVisualStyleBackColor = true;
            this.subfieldDownButton.Click += new System.EventHandler(this.subfieldDownButton_Click);
            // 
            // subfieldUpButton
            // 
            this.subfieldUpButton.Image = ((System.Drawing.Image)(resources.GetObject("subfieldUpButton.Image")));
            this.subfieldUpButton.Location = new System.Drawing.Point(656, 134);
            this.subfieldUpButton.Name = "subfieldUpButton";
            this.subfieldUpButton.Size = new System.Drawing.Size(26, 56);
            this.subfieldUpButton.TabIndex = 4;
            this.toolTip.SetToolTip(this.subfieldUpButton, "Move subfield up");
            this.subfieldUpButton.UseVisualStyleBackColor = true;
            this.subfieldUpButton.Click += new System.EventHandler(this.subfieldUpButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.progressToolStripStatusLabel,
            this.helptextToolStripStatusLabel,
            this.cancelButtonToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // progressToolStripStatusLabel
            // 
            this.progressToolStripStatusLabel.Name = "progressToolStripStatusLabel";
            this.progressToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // helptextToolStripStatusLabel
            // 
            this.helptextToolStripStatusLabel.Name = "helptextToolStripStatusLabel";
            this.helptextToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cancelButtonToolStripStatusLabel
            // 
            this.cancelButtonToolStripStatusLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.cancelButtonToolStripStatusLabel.Name = "cancelButtonToolStripStatusLabel";
            this.cancelButtonToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.cancelButtonToolStripStatusLabel.Text = "Cancel";
            this.cancelButtonToolStripStatusLabel.Visible = false;
            this.cancelButtonToolStripStatusLabel.Click += new System.EventHandler(this.cancelButtonToolStripStatusLabel_Click);
            // 
            // previewTextBox
            // 
            this.previewTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTextBox.Location = new System.Drawing.Point(688, 3);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.ReadOnly = true;
            this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewTextBox.Size = new System.Drawing.Size(293, 420);
            this.previewTextBox.TabIndex = 2;
            // 
            // subfieldsDataGridView
            // 
            this.subfieldsDataGridView.AllowUserToAddRows = false;
            this.subfieldsDataGridView.AllowUserToResizeColumns = false;
            this.subfieldsDataGridView.AllowUserToResizeRows = false;
            this.subfieldsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subfieldsDataGridView.AutoGenerateColumns = false;
            this.subfieldsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subfieldsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subfieldIDDataGridViewTextBoxColumn,
            this.fieldIDDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.subfieldsDataGridView.DataMember = "Subfields";
            this.subfieldsDataGridView.DataSource = this.marcDataSet;
            this.subfieldsDataGridView.Enabled = false;
            this.subfieldsDataGridView.Location = new System.Drawing.Point(243, 3);
            this.subfieldsDataGridView.MultiSelect = false;
            this.subfieldsDataGridView.Name = "subfieldsDataGridView";
            this.subfieldsDataGridView.Size = new System.Drawing.Size(407, 420);
            this.subfieldsDataGridView.TabIndex = 1;
            this.subfieldsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.subfieldsDataGridView_CellBeginEdit);
            this.subfieldsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.subfieldsDataGridView_CellEndEdit);
            this.subfieldsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.subfieldsDataGridView_CellValidated);
            this.subfieldsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.subfieldsDataGridView_CellValidating);
            this.subfieldsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.subfieldsDataGridView_RowValidating);
            this.subfieldsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.subfieldsDataGridView_UserDeletingRow);
            // 
            // subfieldIDDataGridViewTextBoxColumn
            // 
            this.subfieldIDDataGridViewTextBoxColumn.DataPropertyName = "SubfieldID";
            this.subfieldIDDataGridViewTextBoxColumn.HeaderText = "SubfieldID";
            this.subfieldIDDataGridViewTextBoxColumn.Name = "subfieldIDDataGridViewTextBoxColumn";
            this.subfieldIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fieldIDDataGridViewTextBoxColumn1
            // 
            this.fieldIDDataGridViewTextBoxColumn1.DataPropertyName = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn1.HeaderText = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn1.Name = "fieldIDDataGridViewTextBoxColumn1";
            this.fieldIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codeDataGridViewTextBoxColumn.Width = 40;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sort";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sort";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // fieldsDataGridView
            // 
            this.fieldsDataGridView.AllowUserToAddRows = false;
            this.fieldsDataGridView.AllowUserToResizeColumns = false;
            this.fieldsDataGridView.AllowUserToResizeRows = false;
            this.fieldsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fieldsDataGridView.AutoGenerateColumns = false;
            this.fieldsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldIDDataGridViewTextBoxColumn,
            this.recordIDDataGridViewTextBoxColumn1,
            this.tagNumberDataGridViewTextBoxColumn,
            this.ind1DataGridViewTextBoxColumn,
            this.ind2DataGridViewTextBoxColumn,
            this.controlDataDataGridViewTextBoxColumn,
            this.Sort});
            this.fieldsDataGridView.DataMember = "Fields";
            this.fieldsDataGridView.DataSource = this.marcDataSet;
            this.fieldsDataGridView.Enabled = false;
            this.fieldsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fieldsDataGridView.MultiSelect = false;
            this.fieldsDataGridView.Name = "fieldsDataGridView";
            this.fieldsDataGridView.Size = new System.Drawing.Size(202, 420);
            this.fieldsDataGridView.TabIndex = 0;
            this.fieldsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.fieldsDataGridView_CellBeginEdit);
            this.fieldsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldsDataGridView_CellClick);
            this.fieldsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldsDataGridView_CellEndEdit);
            this.fieldsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldsDataGridView_CellValidated);
            this.fieldsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.fieldsDataGridView_CellValidating);
            this.fieldsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.fieldsDataGridView_RowValidating);
            this.fieldsDataGridView.SelectionChanged += new System.EventHandler(this.fieldsDataGridView_SelectionChanged);
            this.fieldsDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.fieldsDataGridView_UserAddedRow);
            this.fieldsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.fieldsDataGridView_UserDeletingRow);
            // 
            // fieldIDDataGridViewTextBoxColumn
            // 
            this.fieldIDDataGridViewTextBoxColumn.DataPropertyName = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.HeaderText = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.Name = "fieldIDDataGridViewTextBoxColumn";
            this.fieldIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // recordIDDataGridViewTextBoxColumn1
            // 
            this.recordIDDataGridViewTextBoxColumn1.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn1.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn1.Name = "recordIDDataGridViewTextBoxColumn1";
            this.recordIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tagNumberDataGridViewTextBoxColumn
            // 
            this.tagNumberDataGridViewTextBoxColumn.DataPropertyName = "TagNumber";
            this.tagNumberDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagNumberDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.tagNumberDataGridViewTextBoxColumn.MinimumWidth = 45;
            this.tagNumberDataGridViewTextBoxColumn.Name = "tagNumberDataGridViewTextBoxColumn";
            this.tagNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tagNumberDataGridViewTextBoxColumn.Width = 45;
            // 
            // ind1DataGridViewTextBoxColumn
            // 
            this.ind1DataGridViewTextBoxColumn.DataPropertyName = "Ind1";
            this.ind1DataGridViewTextBoxColumn.HeaderText = "Ind1";
            this.ind1DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.ind1DataGridViewTextBoxColumn.MinimumWidth = 40;
            this.ind1DataGridViewTextBoxColumn.Name = "ind1DataGridViewTextBoxColumn";
            this.ind1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ind1DataGridViewTextBoxColumn.Width = 40;
            // 
            // ind2DataGridViewTextBoxColumn
            // 
            this.ind2DataGridViewTextBoxColumn.DataPropertyName = "Ind2";
            this.ind2DataGridViewTextBoxColumn.HeaderText = "Ind2";
            this.ind2DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.ind2DataGridViewTextBoxColumn.MinimumWidth = 40;
            this.ind2DataGridViewTextBoxColumn.Name = "ind2DataGridViewTextBoxColumn";
            this.ind2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ind2DataGridViewTextBoxColumn.Width = 40;
            // 
            // controlDataDataGridViewTextBoxColumn
            // 
            this.controlDataDataGridViewTextBoxColumn.DataPropertyName = "ControlData";
            this.controlDataDataGridViewTextBoxColumn.HeaderText = "Control Data";
            this.controlDataDataGridViewTextBoxColumn.Name = "controlDataDataGridViewTextBoxColumn";
            this.controlDataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.controlDataDataGridViewTextBoxColumn.Visible = false;
            // 
            // Sort
            // 
            this.Sort.DataPropertyName = "Sort";
            this.Sort.HeaderText = "Sort";
            this.Sort.Name = "Sort";
            this.Sort.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.mrc";
            this.saveFileDialog.Filter = "MRC Files|*.mrc|USM Files|*.usm|MARC Fiels|*.marc|001 Files|*.001|MARCXML Files|*" +
    ".xml|All Files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.mrc";
            this.openFileDialog.Filter = "MARC Records|*.mrc;*.marc;*.usm;*.001;*.xml|MRC Files|*.mrc|MARC Files|*.marc|USM" +
    " Files|*.usm|001 Files|*.001|MARCXML Files|*.xml|All Files|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // importingBackgroundWorker
            // 
            this.importingBackgroundWorker.WorkerReportsProgress = true;
            this.importingBackgroundWorker.WorkerSupportsCancellation = true;
            this.importingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importingBackgroundWorker_DoWork);
            this.importingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.importingBackgroundWorker_ProgressChanged);
            this.importingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importingBackgroundWorker_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importRecordsToolStripMenuItem,
            this.exportRecordsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importRecordsToolStripMenuItem
            // 
            this.importRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromXMLFileToolStripMenuItem,
            this.fromZ3950SRUToolStripMenuItem});
            this.importRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importRecordsToolStripMenuItem.Image")));
            this.importRecordsToolStripMenuItem.Name = "importRecordsToolStripMenuItem";
            this.importRecordsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importRecordsToolStripMenuItem.Text = "Import Records";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fromFileToolStripMenuItem.Image")));
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fromFileToolStripMenuItem.Text = "From MARC21 File";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // fromXMLFileToolStripMenuItem
            // 
            this.fromXMLFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fromXMLFileToolStripMenuItem.Image")));
            this.fromXMLFileToolStripMenuItem.Name = "fromXMLFileToolStripMenuItem";
            this.fromXMLFileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fromXMLFileToolStripMenuItem.Text = "From XML File";
            this.fromXMLFileToolStripMenuItem.Click += new System.EventHandler(this.fromXMLFileToolStripMenuItem_Click);
            // 
            // fromZ3950SRUToolStripMenuItem
            // 
            this.fromZ3950SRUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fromZ3950SRUToolStripMenuItem.Image")));
            this.fromZ3950SRUToolStripMenuItem.Name = "fromZ3950SRUToolStripMenuItem";
            this.fromZ3950SRUToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fromZ3950SRUToolStripMenuItem.Text = "From Z39.50/SRU";
            this.fromZ3950SRUToolStripMenuItem.Click += new System.EventHandler(this.fromZ3950SRUToolStripMenuItem_Click);
            // 
            // exportRecordsToolStripMenuItem
            // 
            this.exportRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullToolStripMenuItem,
            this.splitToolStripMenuItem,
            this.toCSVFileToolStripMenuItem});
            this.exportRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportRecordsToolStripMenuItem.Image")));
            this.exportRecordsToolStripMenuItem.Name = "exportRecordsToolStripMenuItem";
            this.exportRecordsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportRecordsToolStripMenuItem.Text = "Export Records";
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fullToolStripMenuItem.Image")));
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fullToolStripMenuItem.Text = "Full";
            this.fullToolStripMenuItem.Click += new System.EventHandler(this.exportRecordsToolStripMenuItem_Click);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("splitToolStripMenuItem.Image")));
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.splitToolStripMenuItem.Text = "Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.exportRecordsToolStripMenuItem_Click);
            // 
            // toCSVFileToolStripMenuItem
            // 
            this.toCSVFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toCSVFileToolStripMenuItem.Image")));
            this.toCSVFileToolStripMenuItem.Name = "toCSVFileToolStripMenuItem";
            this.toCSVFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.toCSVFileToolStripMenuItem.Text = "To CSV File";
            this.toCSVFileToolStripMenuItem.Click += new System.EventHandler(this.toCSVFileToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRecordsToolStripMenuItem,
            this.currentRecordToolStripMenuItem,
            this.selectedRecordsToolStripMenuItem});
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // allRecordsToolStripMenuItem
            // 
            this.allRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allRecordsToolStripMenuItem.Image")));
            this.allRecordsToolStripMenuItem.Name = "allRecordsToolStripMenuItem";
            this.allRecordsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.allRecordsToolStripMenuItem.Text = "All Records";
            this.allRecordsToolStripMenuItem.Click += new System.EventHandler(this.allRecordsToolStripMenuItem_Click);
            // 
            // currentRecordToolStripMenuItem
            // 
            this.currentRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("currentRecordToolStripMenuItem.Image")));
            this.currentRecordToolStripMenuItem.Name = "currentRecordToolStripMenuItem";
            this.currentRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.currentRecordToolStripMenuItem.Text = "Current Record";
            this.currentRecordToolStripMenuItem.Click += new System.EventHandler(this.currentRecordToolStripMenuItem_Click);
            // 
            // selectedRecordsToolStripMenuItem
            // 
            this.selectedRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectedRecordsToolStripMenuItem.Image")));
            this.selectedRecordsToolStripMenuItem.Name = "selectedRecordsToolStripMenuItem";
            this.selectedRecordsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectedRecordsToolStripMenuItem.Text = "Selected Records";
            this.selectedRecordsToolStripMenuItem.Click += new System.EventHandler(this.selectedRecordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBlankRecordToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem,
            this.advancedBatchEditToolStripMenuItem,
            this.sortAllFieldsAndSubfieldsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // createBlankRecordToolStripMenuItem
            // 
            this.createBlankRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createBlankRecordToolStripMenuItem.Image")));
            this.createBlankRecordToolStripMenuItem.Name = "createBlankRecordToolStripMenuItem";
            this.createBlankRecordToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.createBlankRecordToolStripMenuItem.Text = "Create Blank Record";
            this.createBlankRecordToolStripMenuItem.Click += new System.EventHandler(this.createBlankRecordToolStripMenuItem_Click);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findAndReplaceToolStripMenuItem.Image")));
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // advancedBatchEditToolStripMenuItem
            // 
            this.advancedBatchEditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("advancedBatchEditToolStripMenuItem.Image")));
            this.advancedBatchEditToolStripMenuItem.Name = "advancedBatchEditToolStripMenuItem";
            this.advancedBatchEditToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.advancedBatchEditToolStripMenuItem.Text = "Advanced Batch Edit";
            this.advancedBatchEditToolStripMenuItem.Click += new System.EventHandler(this.advancedBatchEditToolStripMenuItem_Click);
            // 
            // sortAllFieldsAndSubfieldsToolStripMenuItem
            // 
            this.sortAllFieldsAndSubfieldsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortAllFieldsAndSubfieldsToolStripMenuItem.Image")));
            this.sortAllFieldsAndSubfieldsToolStripMenuItem.Name = "sortAllFieldsAndSubfieldsToolStripMenuItem";
            this.sortAllFieldsAndSubfieldsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.sortAllFieldsAndSubfieldsToolStripMenuItem.Text = "Sort all fields and subfields";
            this.sortAllFieldsAndSubfieldsToolStripMenuItem.Click += new System.EventHandler(this.sortAllFieldsAndSubfieldsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordListAtTopToolStripMenuItem,
            this.clearDatabaseOnExitToolStripMenuItem,
            this.customFieldsToolStripMenuItem,
            this.exportFormatToolStripMenuItem,
            this.forceUTF8ImportToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // recordListAtTopToolStripMenuItem
            // 
            this.recordListAtTopToolStripMenuItem.Checked = true;
            this.recordListAtTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recordListAtTopToolStripMenuItem.Name = "recordListAtTopToolStripMenuItem";
            this.recordListAtTopToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.recordListAtTopToolStripMenuItem.Text = "Record List at Top";
            this.recordListAtTopToolStripMenuItem.Click += new System.EventHandler(this.recordListAtTopToolStripMenuItem_Click);
            // 
            // clearDatabaseOnExitToolStripMenuItem
            // 
            this.clearDatabaseOnExitToolStripMenuItem.Name = "clearDatabaseOnExitToolStripMenuItem";
            this.clearDatabaseOnExitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearDatabaseOnExitToolStripMenuItem.Text = "Clear database on exit";
            this.clearDatabaseOnExitToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseOnExitToolStripMenuItem_Click);
            // 
            // customFieldsToolStripMenuItem
            // 
            this.customFieldsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customFieldsToolStripMenuItem.Image")));
            this.customFieldsToolStripMenuItem.Name = "customFieldsToolStripMenuItem";
            this.customFieldsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.customFieldsToolStripMenuItem.Text = "Custom Fields";
            this.customFieldsToolStripMenuItem.Click += new System.EventHandler(this.customFieldsToolStripMenuItem_Click);
            // 
            // exportFormatToolStripMenuItem
            // 
            this.exportFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTF8ToolStripMenuItem,
            this.mARC8ToolStripMenuItem,
            this.mARCXMLToolStripMenuItem});
            this.exportFormatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportFormatToolStripMenuItem.Image")));
            this.exportFormatToolStripMenuItem.Name = "exportFormatToolStripMenuItem";
            this.exportFormatToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exportFormatToolStripMenuItem.Text = "Export Format";
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Checked = true;
            this.uTF8ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.uTF8ToolStripMenuItem.Text = "UTF8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.exportFormatToolStripMenuItem_Click);
            // 
            // mARC8ToolStripMenuItem
            // 
            this.mARC8ToolStripMenuItem.Name = "mARC8ToolStripMenuItem";
            this.mARC8ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mARC8ToolStripMenuItem.Text = "MARC8";
            this.mARC8ToolStripMenuItem.Click += new System.EventHandler(this.exportFormatToolStripMenuItem_Click);
            // 
            // mARCXMLToolStripMenuItem
            // 
            this.mARCXMLToolStripMenuItem.Name = "mARCXMLToolStripMenuItem";
            this.mARCXMLToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mARCXMLToolStripMenuItem.Text = "MARCXML";
            this.mARCXMLToolStripMenuItem.Click += new System.EventHandler(this.exportFormatToolStripMenuItem_Click);
            // 
            // forceUTF8ImportToolStripMenuItem
            // 
            this.forceUTF8ImportToolStripMenuItem.Name = "forceUTF8ImportToolStripMenuItem";
            this.forceUTF8ImportToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.forceUTF8ImportToolStripMenuItem.Text = "Force UTF8 Import";
            this.forceUTF8ImportToolStripMenuItem.Click += new System.EventHandler(this.forceUTF8ImportToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToRDAToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.validateRecordsToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearDatabaseToolStripMenuItem,
            this.resetDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // convertToRDAToolStripMenuItem
            // 
            this.convertToRDAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("convertToRDAToolStripMenuItem.Image")));
            this.convertToRDAToolStripMenuItem.Name = "convertToRDAToolStripMenuItem";
            this.convertToRDAToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.convertToRDAToolStripMenuItem.Text = "Convert to RDA";
            this.convertToRDAToolStripMenuItem.Click += new System.EventHandler(this.convertToRDAToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classificationsToolStripMenuItem,
            this.copyrightDateToolStripMenuItem,
            this.copyrightDateByDecadeToolStripMenuItem,
            this.recordSummaryToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // classificationsToolStripMenuItem
            // 
            this.classificationsToolStripMenuItem.Name = "classificationsToolStripMenuItem";
            this.classificationsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.classificationsToolStripMenuItem.Text = "Classifications";
            this.classificationsToolStripMenuItem.Click += new System.EventHandler(this.classificationsToolStripMenuItem_Click);
            // 
            // copyrightDateToolStripMenuItem
            // 
            this.copyrightDateToolStripMenuItem.Name = "copyrightDateToolStripMenuItem";
            this.copyrightDateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copyrightDateToolStripMenuItem.Text = "Copyright Date";
            this.copyrightDateToolStripMenuItem.Click += new System.EventHandler(this.copyrightDateToolStripMenuItem_Click);
            // 
            // copyrightDateByDecadeToolStripMenuItem
            // 
            this.copyrightDateByDecadeToolStripMenuItem.Name = "copyrightDateByDecadeToolStripMenuItem";
            this.copyrightDateByDecadeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copyrightDateByDecadeToolStripMenuItem.Text = "Copyright Date by Decade";
            this.copyrightDateByDecadeToolStripMenuItem.Click += new System.EventHandler(this.copyrightDateByDecadeToolStripMenuItem_Click);
            // 
            // recordSummaryToolStripMenuItem
            // 
            this.recordSummaryToolStripMenuItem.Name = "recordSummaryToolStripMenuItem";
            this.recordSummaryToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.recordSummaryToolStripMenuItem.Text = "Record Summary";
            this.recordSummaryToolStripMenuItem.Click += new System.EventHandler(this.recordSummaryToolStripMenuItem_Click);
            // 
            // validateRecordsToolStripMenuItem
            // 
            this.validateRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("validateRecordsToolStripMenuItem.Image")));
            this.validateRecordsToolStripMenuItem.Name = "validateRecordsToolStripMenuItem";
            this.validateRecordsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.validateRecordsToolStripMenuItem.Text = "Validate Records";
            this.validateRecordsToolStripMenuItem.Click += new System.EventHandler(this.validateRecordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearDatabaseToolStripMenuItem.Image")));
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetDatabaseToolStripMenuItem.Image")));
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // exportingBackgroundWorker
            // 
            this.exportingBackgroundWorker.WorkerReportsProgress = true;
            this.exportingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.exportingBackgroundWorker_DoWork);
            this.exportingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.exportingBackgroundWorker_ProgressChanged);
            this.exportingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.exportingBackgroundWorker_RunWorkerCompleted);
            // 
            // csvExportBackgroundWorker
            // 
            this.csvExportBackgroundWorker.WorkerReportsProgress = true;
            this.csvExportBackgroundWorker.WorkerSupportsCancellation = true;
            this.csvExportBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.csvExportBackgroundWorker_DoWork);
            this.csvExportBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.csvExportBackgroundWorker_ProgressChanged);
            this.csvExportBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.csvExportBackgroundWorker_RunWorkerCompleted);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // rebuildBackgroundWorker
            // 
            this.rebuildBackgroundWorker.WorkerReportsProgress = true;
            this.rebuildBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.rebuildBackgroundWorker_DoWork);
            this.rebuildBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.rebuildBackgroundWorker_ProgressChanged);
            this.rebuildBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.rebuildBackgroundWorker_RunWorkerCompleted);
            // 
            // loadingBackgroundWorker
            // 
            this.loadingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadingBackgroundWorker_DoWork);
            this.loadingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadingBackgroundWorker_RunWorkerCompleted);
            // 
            // rdaConversionBackgroundWorker
            // 
            this.rdaConversionBackgroundWorker.WorkerReportsProgress = true;
            this.rdaConversionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.rdaConversionBackgroundWorker_DoWork);
            this.rdaConversionBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.rdaConversionBackgroundWorker_ProgressChanged);
            this.rdaConversionBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.rdaConversionBackgroundWorker_RunWorkerCompleted);
            // 
            // validationBackgroundWorker
            // 
            this.validationBackgroundWorker.WorkerReportsProgress = true;
            this.validationBackgroundWorker.WorkerSupportsCancellation = true;
            this.validationBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.validationBackgroundWorker_DoWork);
            this.validationBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.validationBackgroundWorker_ProgressChanged);
            this.validationBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.validationBackgroundWorker_RunWorkerCompleted);
            // 
            // sortAllBackgroundWorker
            // 
            this.sortAllBackgroundWorker.WorkerReportsProgress = true;
            this.sortAllBackgroundWorker.WorkerSupportsCancellation = true;
            this.sortAllBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sortAllBackgroundWorker_DoWork);
            this.sortAllBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.sortAllBackgroundWorker_ProgressChanged);
            this.sortAllBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sortAllBackgroundWorker_RunWorkerCompleted);
            // 
            // batchEditBackgroundWorker
            // 
            this.batchEditBackgroundWorker.WorkerReportsProgress = true;
            this.batchEditBackgroundWorker.WorkerSupportsCancellation = true;
            this.batchEditBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.batchEditBackgroundWorker_DoWork);
            this.batchEditBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.batchEditBackgroundWorker_ProgressChanged);
            this.batchEditBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.batchEditBackgroundWorker_RunWorkerCompleted);
            // 
            // importingXMLBackgroundWorker
            // 
            this.importingXMLBackgroundWorker.WorkerReportsProgress = true;
            this.importingXMLBackgroundWorker.WorkerSupportsCancellation = true;
            this.importingXMLBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importingXMLBackgroundWorker_DoWork);
            this.importingXMLBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.importingBackgroundWorker_ProgressChanged);
            this.importingXMLBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importingBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 637);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 676);
            this.Name = "MainForm";
            this.Text = "C# MARC Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcDataSet)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subfieldsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsDataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox previewTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker importingBackgroundWorker;
        private System.Windows.Forms.DataGridView recordsDataGridView;
        private System.Windows.Forms.DataGridView subfieldsDataGridView;
        private System.Windows.Forms.DataGridView fieldsDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordListAtTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel progressToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel helptextToolStripStatusLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.ComponentModel.BackgroundWorker exportingBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBlankRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseOnExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARC8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromZ3950SRUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCSVFileToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker csvExportBackgroundWorker;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.ComponentModel.BackgroundWorker rebuildBackgroundWorker;
        private System.ComponentModel.BackgroundWorker loadingBackgroundWorker;
        private System.Windows.Forms.ToolStripStatusLabel cancelButtonToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem validateRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem convertToRDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordSummaryToolStripMenuItem;
        internal MARCDataSet marcDataSet;
        private System.Windows.Forms.ToolStripMenuItem copyrightDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightDateByDecadeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker rdaConversionBackgroundWorker;
        private System.Windows.Forms.Button subfieldDownButton;
        private System.Windows.Forms.Button subfieldUpButton;
        private System.Windows.Forms.Button subfieldSortButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ind1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ind2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort;
        private System.Windows.Forms.Button fieldsSortButton;
        private System.Windows.Forms.Button fieldDownButton;
        private System.Windows.Forms.Button fieldUpButton;
        private System.ComponentModel.BackgroundWorker validationBackgroundWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyrightDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainEntryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custom4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custom5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidationErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn subfieldIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem forceUTF8ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedBatchEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAllFieldsAndSubfieldsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker sortAllBackgroundWorker;
        private System.ComponentModel.BackgroundWorker batchEditBackgroundWorker;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fromXMLFileToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker importingXMLBackgroundWorker;
    }
}

