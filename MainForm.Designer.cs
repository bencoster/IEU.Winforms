﻿namespace ImageEnhancingUtility.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.upscale_button = new System.Windows.Forms.Button();
            this.esrganPath_textBox = new System.Windows.Forms.TextBox();
            this.resultsMergedPath_textBox = new System.Windows.Forms.TextBox();
            this.crop_button = new System.Windows.Forms.Button();
            this.merge_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressFiltered_label = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overwriteMode_comboBox = new System.Windows.Forms.ComboBox();
            this.runAll_button = new System.Windows.Forms.Button();
            this.outputMode_groupBox = new System.Windows.Forms.GroupBox();
            this.outputDestinationMode_comboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.previewResult_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.previewModels_comboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.previewUpdate_button = new System.Windows.Forms.Button();
            this.previewSave_button = new System.Windows.Forms.Button();
            this.preview_progressBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.imageSizeToolStripStatusLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomLevelsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.settings_tabPage = new System.Windows.Forms.TabPage();
            this.useBasicSR_checkBox = new System.Windows.Forms.CheckBox();
            this.outputFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.modelForAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.appCoreVersion_linkLabel = new System.Windows.Forms.LinkLabel();
            this.appVersion_label = new System.Windows.Forms.LinkLabel();
            this.checkForUpdates_checkBox = new System.Windows.Forms.CheckBox();
            this.deleteResults_checkBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maxTileHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxTileWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.createMemoryImage_checkBox = new System.Windows.Forms.CheckBox();
            this.useCPU_checkBox = new System.Windows.Forms.CheckBox();
            this.seamlessTextures_checkBox = new System.Windows.Forms.CheckBox();
            this.preserveFormat_checkBox = new System.Windows.Forms.CheckBox();
            this.changeInputImgPath_button = new System.Windows.Forms.Button();
            this.changeMergedResultsPath_button = new System.Windows.Forms.Button();
            this.changeEsrganPath_button = new System.Windows.Forms.Button();
            this.debugUpscale_checkBox = new System.Windows.Forms.CheckBox();
            this.useDifferentModelForAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.splitRGB_checkBox = new System.Windows.Forms.CheckBox();
            this.preciseTile_checkBox = new System.Windows.Forms.CheckBox();
            this.balanceAlphas_checkBox = new System.Windows.Forms.CheckBox();
            this.ignoreSingleColorAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.ignoreAlpha_checkBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.overlapSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxTileResolution_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.imgPath_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsOutputFormat_tabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webpLossless_checkBox = new System.Windows.Forms.CheckBox();
            this.webpQuality_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.webpPreset_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pngCompression_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.tiffSetting_groupBox = new System.Windows.Forms.GroupBox();
            this.tiffJpegQuality_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tiffSettings_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsOutputSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ddsGenerateMipmaps_checkBox = new System.Windows.Forms.CheckBox();
            this.ddsCompresion_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsFileFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.ddsTextureType_comboBox = new System.Windows.Forms.ComboBox();
            this.advanced_tabPage = new System.Windows.Forms.TabPage();
            this.imagePostprocess_groupBox = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.threshold_groupBox = new System.Windows.Forms.GroupBox();
            this.thresholdBlack_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.thresholdEnabled_checkBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.thresholdWhite_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.resizeImageAfterFilterType_comboBox = new System.Windows.Forms.ComboBox();
            this.resizeImageAfterScaleFactor_comboBox = new System.Windows.Forms.ComboBox();
            this.imagePreprocess_groupBox = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.resizeImageBeforeScaleFactor_comboBox = new System.Windows.Forms.ComboBox();
            this.resizeImageBeforeFilterType_comboBox = new System.Windows.Forms.ComboBox();
            this.noiseReductionType_comboBox = new System.Windows.Forms.ComboBox();
            this.changeModelsPath_button = new System.Windows.Forms.Button();
            this.upscaleSize_groupBox = new System.Windows.Forms.GroupBox();
            this.x1_radioButton = new System.Windows.Forms.RadioButton();
            this.x2_radioButton = new System.Windows.Forms.RadioButton();
            this.x4_radioButton = new System.Windows.Forms.RadioButton();
            this.changeOutputPath_button = new System.Windows.Forms.Button();
            this.filters_groupBox = new System.Windows.Forms.GroupBox();
            this.filterExtensions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.filtersSize_groupBox = new System.Windows.Forms.GroupBox();
            this.filtersSizeOn_checkBox = new System.Windows.Forms.CheckBox();
            this.filterSizeWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filterSizeHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.filterSizeOr_checkBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filtersFilename_groupBox = new System.Windows.Forms.GroupBox();
            this.filterFilenameCaseSensitive_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameContains_textBox = new System.Windows.Forms.TextBox();
            this.filterFilenameNotContains_checkBox = new System.Windows.Forms.CheckBox();
            this.filterFilenameNotContains_textBox = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.filtersAlpha_groupBox = new System.Windows.Forms.GroupBox();
            this.filterAlpha_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.advancedSuffix_textBox = new System.Windows.Forms.TextBox();
            this.changeInputPath_button = new System.Windows.Forms.Button();
            this.advancedUseSuffix_checkBox = new System.Windows.Forms.CheckBox();
            this.inputPath_textBox = new System.Windows.Forms.TextBox();
            this.outputPath_textBox = new System.Windows.Forms.TextBox();
            this.modelsPath_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interpolation_tabPage = new System.Windows.Forms.TabPage();
            this.modelInterpolationAlpha_trackBar = new System.Windows.Forms.TrackBar();
            this.interpolationOutputModelName_textBox = new System.Windows.Forms.TextBox();
            this.interpolationStart_button = new System.Windows.Forms.Button();
            this.modelInterpolationAlphaValue_textBox = new System.Windows.Forms.TextBox();
            this.interpolationModelTwo_comboBox = new System.Windows.Forms.ComboBox();
            this.interpolationModelOne_comboBox = new System.Windows.Forms.ComboBox();
            this.overlayResults_tabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.overlayImages_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.imageB_panel = new System.Windows.Forms.Panel();
            this.imageB_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imageA_panel = new System.Windows.Forms.Panel();
            this.imageA_pictureBox = new System.Windows.Forms.PictureBox();
            this.overlayResultName_textBox = new System.Windows.Forms.TextBox();
            this.overlayFolders_button = new System.Windows.Forms.Button();
            this.imageInterpolationAlphaValue_textBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.changeResultsDestinationPath_button = new System.Windows.Forms.Button();
            this.originalImagesPath_textBox = new System.Windows.Forms.TextBox();
            this.changeResultsBPath_button = new System.Windows.Forms.Button();
            this.resultsAPath_textBox = new System.Windows.Forms.TextBox();
            this.changeResultsAPath_button = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.changeOriginalImagesPath_button = new System.Windows.Forms.Button();
            this.resultsBPath_textBox = new System.Windows.Forms.TextBox();
            this.resultsDestinationPath_textBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageInterpolation_trackBar = new System.Windows.Forms.TrackBar();
            this.treeView_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openModelFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.main_tabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.outputMode_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.previewResult_tabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.settings_tabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).BeginInit();
            this.settingsOutputFormat_tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webpQuality_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).BeginInit();
            this.tiffSetting_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffJpegQuality_numericUpDown)).BeginInit();
            this.ddsOutputSettings_groupBox.SuspendLayout();
            this.advanced_tabPage.SuspendLayout();
            this.imagePostprocess_groupBox.SuspendLayout();
            this.threshold_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).BeginInit();
            this.imagePreprocess_groupBox.SuspendLayout();
            this.upscaleSize_groupBox.SuspendLayout();
            this.filters_groupBox.SuspendLayout();
            this.filtersSize_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).BeginInit();
            this.filtersFilename_groupBox.SuspendLayout();
            this.filtersAlpha_groupBox.SuspendLayout();
            this.interpolation_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelInterpolationAlpha_trackBar)).BeginInit();
            this.overlayResults_tabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.imageB_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageB_pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.imageA_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageA_pictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInterpolation_trackBar)).BeginInit();
            this.treeView_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // upscale_button
            // 
            this.upscale_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upscale_button.Location = new System.Drawing.Point(0, 332);
            this.upscale_button.Name = "upscale_button";
            this.upscale_button.Size = new System.Drawing.Size(149, 83);
            this.upscale_button.TabIndex = 1;
            this.upscale_button.Text = "RUN ESRGAN";
            this.toolTip1.SetToolTip(this.upscale_button, "Process all files from ESRGAN input folder and save them in results folder or it " +
        "subfolders depending on output mode");
            this.upscale_button.UseVisualStyleBackColor = true;
            // 
            // esrganPath_textBox
            // 
            this.esrganPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.esrganPath_textBox.Location = new System.Drawing.Point(84, 18);
            this.esrganPath_textBox.Name = "esrganPath_textBox";
            this.esrganPath_textBox.ReadOnly = true;
            this.esrganPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.esrganPath_textBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.esrganPath_textBox, "ESRGAN root folder");
            // 
            // resultsMergedPath_textBox
            // 
            this.resultsMergedPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsMergedPath_textBox.Location = new System.Drawing.Point(84, 44);
            this.resultsMergedPath_textBox.Name = "resultsMergedPath_textBox";
            this.resultsMergedPath_textBox.ReadOnly = true;
            this.resultsMergedPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.resultsMergedPath_textBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.resultsMergedPath_textBox, "IEU output folder");
            // 
            // crop_button
            // 
            this.crop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crop_button.Location = new System.Drawing.Point(0, 149);
            this.crop_button.Name = "crop_button";
            this.crop_button.Size = new System.Drawing.Size(149, 83);
            this.crop_button.TabIndex = 17;
            this.crop_button.Text = "SPLIT";
            this.toolTip1.SetToolTip(this.crop_button, "Create tiles from original images and save them as png in ESRGAN input folder");
            this.crop_button.UseVisualStyleBackColor = true;
            // 
            // merge_button
            // 
            this.merge_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.merge_button.Location = new System.Drawing.Point(0, 421);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(149, 83);
            this.merge_button.TabIndex = 18;
            this.merge_button.Text = "MERGE";
            this.toolTip1.SetToolTip(this.merge_button, "Find all image tiles in results folder/subfolders, merge them in single image and" +
        " save it in merged-results folder/subfolder depending on output mode.");
            this.merge_button.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.main_tabPage);
            this.tabControl1.Controls.Add(this.previewResult_tabPage);
            this.tabControl1.Controls.Add(this.settings_tabPage);
            this.tabControl1.Controls.Add(this.settingsOutputFormat_tabPage);
            this.tabControl1.Controls.Add(this.advanced_tabPage);
            this.tabControl1.Controls.Add(this.interpolation_tabPage);
            this.tabControl1.Controls.Add(this.overlayResults_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 642);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainTab_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            // 
            // main_tabPage
            // 
            this.main_tabPage.Controls.Add(this.tableLayoutPanel1);
            this.main_tabPage.Location = new System.Drawing.Point(4, 25);
            this.main_tabPage.Name = "main_tabPage";
            this.main_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.main_tabPage.Size = new System.Drawing.Size(770, 613);
            this.main_tabPage.TabIndex = 0;
            this.main_tabPage.Text = "Basic";
            this.main_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 607);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressFiltered_label);
            this.panel2.Controls.Add(this.progress_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 24);
            this.panel2.TabIndex = 37;
            // 
            // progressFiltered_label
            // 
            this.progressFiltered_label.AutoSize = true;
            this.progressFiltered_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressFiltered_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressFiltered_label.Font = new System.Drawing.Font("Malgun Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressFiltered_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressFiltered_label.Location = new System.Drawing.Point(0, 0);
            this.progressFiltered_label.Name = "progressFiltered_label";
            this.progressFiltered_label.Size = new System.Drawing.Size(19, 21);
            this.progressFiltered_label.TabIndex = 24;
            this.progressFiltered_label.Text = "0";
            this.progressFiltered_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progress_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.progress_label.Font = new System.Drawing.Font("Malgun Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress_label.Location = new System.Drawing.Point(116, 0);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(33, 21);
            this.progress_label.TabIndex = 23;
            this.progress_label.Text = "0/0";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.runAll_button);
            this.panel1.Controls.Add(this.outputMode_groupBox);
            this.panel1.Controls.Add(this.upscale_button);
            this.panel1.Controls.Add(this.crop_button);
            this.panel1.Controls.Add(this.merge_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 571);
            this.panel1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overwriteMode_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 50);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overwrite";
            // 
            // overwriteMode_comboBox
            // 
            this.overwriteMode_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overwriteMode_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overwriteMode_comboBox.FormattingEnabled = true;
            this.overwriteMode_comboBox.Location = new System.Drawing.Point(6, 19);
            this.overwriteMode_comboBox.Name = "overwriteMode_comboBox";
            this.overwriteMode_comboBox.Size = new System.Drawing.Size(137, 21);
            this.overwriteMode_comboBox.TabIndex = 0;
            // 
            // runAll_button
            // 
            this.runAll_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runAll_button.Location = new System.Drawing.Point(0, 524);
            this.runAll_button.Name = "runAll_button";
            this.runAll_button.Size = new System.Drawing.Size(149, 32);
            this.runAll_button.TabIndex = 32;
            this.runAll_button.Text = "SPLIT-ESRGAN-MERGE";
            this.runAll_button.UseVisualStyleBackColor = true;
            // 
            // outputMode_groupBox
            // 
            this.outputMode_groupBox.Controls.Add(this.outputDestinationMode_comboBox);
            this.outputMode_groupBox.Location = new System.Drawing.Point(0, 91);
            this.outputMode_groupBox.Name = "outputMode_groupBox";
            this.outputMode_groupBox.Size = new System.Drawing.Size(149, 52);
            this.outputMode_groupBox.TabIndex = 31;
            this.outputMode_groupBox.TabStop = false;
            this.outputMode_groupBox.Text = "Output mode";
            // 
            // outputDestinationMode_comboBox
            // 
            this.outputDestinationMode_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDestinationMode_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputDestinationMode_comboBox.FormattingEnabled = true;
            this.outputDestinationMode_comboBox.Location = new System.Drawing.Point(6, 19);
            this.outputDestinationMode_comboBox.Name = "outputDestinationMode_comboBox";
            this.outputDestinationMode_comboBox.Size = new System.Drawing.Size(137, 21);
            this.outputDestinationMode_comboBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(158, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(603, 571);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 10.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(199, 571);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(158, 580);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(603, 24);
            this.progressBar1.TabIndex = 22;
            // 
            // previewResult_tabPage
            // 
            this.previewResult_tabPage.Controls.Add(this.tableLayoutPanel3);
            this.previewResult_tabPage.Controls.Add(this.toolStrip);
            this.previewResult_tabPage.Location = new System.Drawing.Point(4, 25);
            this.previewResult_tabPage.Name = "previewResult_tabPage";
            this.previewResult_tabPage.Size = new System.Drawing.Size(770, 613);
            this.previewResult_tabPage.TabIndex = 5;
            this.previewResult_tabPage.Text = "Preview result";
            this.previewResult_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.zoomImageBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.previewImageBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.previewModels_comboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.preview_progressBar, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 588);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // zoomImageBox
            // 
            this.zoomImageBox.AllowDrop = true;
            this.zoomImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomImageBox.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zoomImageBox.GridColorAlternate = System.Drawing.SystemColors.ControlDark;
            this.zoomImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.zoomImageBox.Location = new System.Drawing.Point(3, 3);
            this.zoomImageBox.Name = "zoomImageBox";
            this.zoomImageBox.Size = new System.Drawing.Size(379, 397);
            this.zoomImageBox.TabIndex = 0;
            this.zoomImageBox.TabStop = false;
            this.zoomImageBox.ImageChanged += new System.EventHandler(this.zoomImageBox_ImageChanged);
            this.zoomImageBox.PanEnd += new System.EventHandler(this.zoomImageBox_PanEnd);
            this.zoomImageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.zoomImageBox_Zoomed);
            this.zoomImageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.zoomImageBox_Scroll);
            this.zoomImageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.zoomImageBox_DragDrop);
            this.zoomImageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            this.zoomImageBox.Resize += new System.EventHandler(this.zoomImageBox_ImageChanged);
            // 
            // previewImageBox
            // 
            this.previewImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImageBox.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previewImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.previewImageBox.Location = new System.Drawing.Point(388, 3);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(379, 397);
            this.previewImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.previewImageBox.TabIndex = 4;
            this.previewImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewImageBox_MouseDown);
            this.previewImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewImageBox_MouseUp);
            // 
            // previewModels_comboBox
            // 
            this.previewModels_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.previewModels_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.previewModels_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewModels_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previewModels_comboBox.FormattingEnabled = true;
            this.previewModels_comboBox.Location = new System.Drawing.Point(388, 406);
            this.previewModels_comboBox.Name = "previewModels_comboBox";
            this.previewModels_comboBox.Size = new System.Drawing.Size(379, 21);
            this.previewModels_comboBox.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(388, 437);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.previewUpdate_button);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.previewSave_button);
            this.splitContainer2.Size = new System.Drawing.Size(379, 118);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 7;
            // 
            // previewUpdate_button
            // 
            this.previewUpdate_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewUpdate_button.Location = new System.Drawing.Point(0, 0);
            this.previewUpdate_button.Name = "previewUpdate_button";
            this.previewUpdate_button.Size = new System.Drawing.Size(198, 118);
            this.previewUpdate_button.TabIndex = 6;
            this.previewUpdate_button.Text = "Update preview";
            this.previewUpdate_button.UseVisualStyleBackColor = true;
            this.previewUpdate_button.Click += new System.EventHandler(this.previewUpdate_button_Click);
            // 
            // previewSave_button
            // 
            this.previewSave_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewSave_button.Location = new System.Drawing.Point(0, 0);
            this.previewSave_button.Name = "previewSave_button";
            this.previewSave_button.Size = new System.Drawing.Size(177, 118);
            this.previewSave_button.TabIndex = 6;
            this.previewSave_button.Text = "Enhance and save as png";
            this.previewSave_button.UseVisualStyleBackColor = true;
            this.previewSave_button.Click += new System.EventHandler(this.previewSave_button_Click);
            // 
            // preview_progressBar
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.preview_progressBar, 2);
            this.preview_progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_progressBar.Location = new System.Drawing.Point(3, 561);
            this.preview_progressBar.Name = "preview_progressBar";
            this.preview_progressBar.Size = new System.Drawing.Size(764, 24);
            this.preview_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.preview_progressBar.TabIndex = 8;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 406);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.miniMapImageBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.imageSizeToolStripStatusLabel);
            this.tableLayoutPanel3.SetRowSpan(this.splitContainer3, 2);
            this.splitContainer3.Size = new System.Drawing.Size(379, 149);
            this.splitContainer3.SplitterDistance = 146;
            this.splitContainer3.TabIndex = 9;
            // 
            // miniMapImageBox
            // 
            this.miniMapImageBox.AllowZoom = false;
            this.miniMapImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.miniMapImageBox.AutoPan = false;
            this.miniMapImageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miniMapImageBox.GridColor = System.Drawing.SystemColors.Control;
            this.miniMapImageBox.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.miniMapImageBox.Location = new System.Drawing.Point(5, 19);
            this.miniMapImageBox.Name = "miniMapImageBox";
            this.miniMapImageBox.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            this.miniMapImageBox.PixelGridColor = System.Drawing.Color.Transparent;
            this.miniMapImageBox.Size = new System.Drawing.Size(129, 127);
            this.miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.miniMapImageBox.TabIndex = 1;
            this.miniMapImageBox.TabStop = false;
            this.miniMapImageBox.VirtualMode = true;
            this.miniMapImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.miniMapImageBox_Paint);
            // 
            // imageSizeToolStripStatusLabel
            // 
            this.imageSizeToolStripStatusLabel.AutoSize = true;
            this.imageSizeToolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.imageSizeToolStripStatusLabel.Location = new System.Drawing.Point(187, 0);
            this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(42, 13);
            this.imageSizeToolStripStatusLabel.TabIndex = 0;
            this.imageSizeToolStripStatusLabel.Text = "X:0 Y:0";
            this.imageSizeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripButton,
            this.toolStripSeparator8,
            this.actualSizeToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.toolStripSeparator2,
            this.zoomLevelsToolStripComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(770, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // openFromFileToolStripButton
            // 
            this.openFromFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFromFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFromFileToolStripButton.Image")));
            this.openFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFromFileToolStripButton.Name = "openFromFileToolStripButton";
            this.openFromFileToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openFromFileToolStripButton.Text = "&Open";
            this.openFromFileToolStripButton.Click += new System.EventHandler(this.openFromFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // actualSizeToolStripButton
            // 
            this.actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualSizeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("actualSizeToolStripButton.Image")));
            this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
            this.actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.actualSizeToolStripButton.Text = "Actual Size";
            this.actualSizeToolStripButton.Click += new System.EventHandler(this.actualSizeToolStripButton_Click);
            // 
            // zoomInToolStripButton
            // 
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton.Image")));
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolStripButton.Text = "Zoom In";
            this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolStripButton.Text = "Zoom Out";
            this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomLevelsToolStripComboBox
            // 
            this.zoomLevelsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.zoomLevelsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomLevelsToolStripComboBox_SelectedIndexChanged);
            // 
            // settings_tabPage
            // 
            this.settings_tabPage.Controls.Add(this.useBasicSR_checkBox);
            this.settings_tabPage.Controls.Add(this.outputFormat_comboBox);
            this.settings_tabPage.Controls.Add(this.modelForAlpha_comboBox);
            this.settings_tabPage.Controls.Add(this.tableLayoutPanel2);
            this.settings_tabPage.Controls.Add(this.deleteResults_checkBox);
            this.settings_tabPage.Controls.Add(this.label9);
            this.settings_tabPage.Controls.Add(this.maxTileHeight_numericUpDown);
            this.settings_tabPage.Controls.Add(this.maxTileWidth_numericUpDown);
            this.settings_tabPage.Controls.Add(this.createMemoryImage_checkBox);
            this.settings_tabPage.Controls.Add(this.useCPU_checkBox);
            this.settings_tabPage.Controls.Add(this.seamlessTextures_checkBox);
            this.settings_tabPage.Controls.Add(this.preserveFormat_checkBox);
            this.settings_tabPage.Controls.Add(this.changeInputImgPath_button);
            this.settings_tabPage.Controls.Add(this.changeMergedResultsPath_button);
            this.settings_tabPage.Controls.Add(this.changeEsrganPath_button);
            this.settings_tabPage.Controls.Add(this.debugUpscale_checkBox);
            this.settings_tabPage.Controls.Add(this.useDifferentModelForAlpha_checkBox);
            this.settings_tabPage.Controls.Add(this.splitRGB_checkBox);
            this.settings_tabPage.Controls.Add(this.preciseTile_checkBox);
            this.settings_tabPage.Controls.Add(this.balanceAlphas_checkBox);
            this.settings_tabPage.Controls.Add(this.ignoreSingleColorAlpha_checkBox);
            this.settings_tabPage.Controls.Add(this.ignoreAlpha_checkBox);
            this.settings_tabPage.Controls.Add(this.label23);
            this.settings_tabPage.Controls.Add(this.label6);
            this.settings_tabPage.Controls.Add(this.overlapSize_numericUpDown);
            this.settings_tabPage.Controls.Add(this.label5);
            this.settings_tabPage.Controls.Add(this.maxTileResolution_numericUpDown);
            this.settings_tabPage.Controls.Add(this.label4);
            this.settings_tabPage.Controls.Add(this.imgPath_textBox);
            this.settings_tabPage.Controls.Add(this.label3);
            this.settings_tabPage.Controls.Add(this.label1);
            this.settings_tabPage.Controls.Add(this.esrganPath_textBox);
            this.settings_tabPage.Controls.Add(this.resultsMergedPath_textBox);
            this.settings_tabPage.Location = new System.Drawing.Point(4, 25);
            this.settings_tabPage.Name = "settings_tabPage";
            this.settings_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settings_tabPage.Size = new System.Drawing.Size(770, 613);
            this.settings_tabPage.TabIndex = 1;
            this.settings_tabPage.Text = "Settings";
            this.settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // useBasicSR_checkBox
            // 
            this.useBasicSR_checkBox.AutoSize = true;
            this.useBasicSR_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useBasicSR_checkBox.Location = new System.Drawing.Point(294, 289);
            this.useBasicSR_checkBox.Name = "useBasicSR_checkBox";
            this.useBasicSR_checkBox.Size = new System.Drawing.Size(146, 17);
            this.useBasicSR_checkBox.TabIndex = 51;
            this.useBasicSR_checkBox.Text = "Use BasicSR architecture";
            this.useBasicSR_checkBox.UseVisualStyleBackColor = true;
            // 
            // outputFormat_comboBox
            // 
            this.outputFormat_comboBox.FormattingEnabled = true;
            this.outputFormat_comboBox.Location = new System.Drawing.Point(84, 159);
            this.outputFormat_comboBox.Name = "outputFormat_comboBox";
            this.outputFormat_comboBox.Size = new System.Drawing.Size(120, 21);
            this.outputFormat_comboBox.TabIndex = 48;
            // 
            // modelForAlpha_comboBox
            // 
            this.modelForAlpha_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelForAlpha_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelForAlpha_comboBox.Enabled = false;
            this.modelForAlpha_comboBox.FormattingEnabled = true;
            this.modelForAlpha_comboBox.Location = new System.Drawing.Point(249, 216);
            this.modelForAlpha_comboBox.Name = "modelForAlpha_comboBox";
            this.modelForAlpha_comboBox.Size = new System.Drawing.Size(381, 21);
            this.modelForAlpha_comboBox.TabIndex = 47;
            this.modelForAlpha_comboBox.SelectedIndexChanged += new System.EventHandler(this.modelForAlpha_comboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.appCoreVersion_linkLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.appVersion_label, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkForUpdates_checkBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(520, 556);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 57);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // appCoreVersion_linkLabel
            // 
            this.appCoreVersion_linkLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.appCoreVersion_linkLabel, 2);
            this.appCoreVersion_linkLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.appCoreVersion_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appCoreVersion_linkLabel.Location = new System.Drawing.Point(141, 3);
            this.appCoreVersion_linkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.appCoreVersion_linkLabel.Name = "appCoreVersion_linkLabel";
            this.appCoreVersion_linkLabel.Size = new System.Drawing.Size(98, 14);
            this.appCoreVersion_linkLabel.TabIndex = 45;
            this.appCoreVersion_linkLabel.TabStop = true;
            this.appCoreVersion_linkLabel.Text = "Core v0.0.00.00";
            this.appCoreVersion_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appCoreVersion_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // appVersion_label
            // 
            this.appVersion_label.AutoSize = true;
            this.appVersion_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.appVersion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersion_label.Location = new System.Drawing.Point(145, 20);
            this.appVersion_label.Name = "appVersion_label";
            this.appVersion_label.Size = new System.Drawing.Size(94, 37);
            this.appVersion_label.TabIndex = 45;
            this.appVersion_label.TabStop = true;
            this.appVersion_label.Text = "GUI v0.0.00.00";
            this.appVersion_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appVersion_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkForUpdates_checkBox
            // 
            this.checkForUpdates_checkBox.AutoSize = true;
            this.checkForUpdates_checkBox.Checked = true;
            this.checkForUpdates_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForUpdates_checkBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkForUpdates_checkBox.Location = new System.Drawing.Point(3, 23);
            this.checkForUpdates_checkBox.Name = "checkForUpdates_checkBox";
            this.checkForUpdates_checkBox.Size = new System.Drawing.Size(113, 31);
            this.checkForUpdates_checkBox.TabIndex = 39;
            this.checkForUpdates_checkBox.Text = "Check for updates";
            this.checkForUpdates_checkBox.UseVisualStyleBackColor = true;
            // 
            // deleteResults_checkBox
            // 
            this.deleteResults_checkBox.AutoSize = true;
            this.deleteResults_checkBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteResults_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteResults_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteResults_checkBox.Location = new System.Drawing.Point(84, 310);
            this.deleteResults_checkBox.Name = "deleteResults_checkBox";
            this.deleteResults_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteResults_checkBox.Size = new System.Drawing.Size(144, 17);
            this.deleteResults_checkBox.TabIndex = 38;
            this.deleteResults_checkBox.Text = "Delete results after merge";
            this.deleteResults_checkBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "X";
            // 
            // maxTileHeight_numericUpDown
            // 
            this.maxTileHeight_numericUpDown.Location = new System.Drawing.Point(294, 107);
            this.maxTileHeight_numericUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.maxTileHeight_numericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxTileHeight_numericUpDown.Name = "maxTileHeight_numericUpDown";
            this.maxTileHeight_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.maxTileHeight_numericUpDown.TabIndex = 32;
            this.maxTileHeight_numericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // maxTileWidth_numericUpDown
            // 
            this.maxTileWidth_numericUpDown.Location = new System.Drawing.Point(210, 107);
            this.maxTileWidth_numericUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.maxTileWidth_numericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.maxTileWidth_numericUpDown.Name = "maxTileWidth_numericUpDown";
            this.maxTileWidth_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.maxTileWidth_numericUpDown.TabIndex = 32;
            this.maxTileWidth_numericUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // createMemoryImage_checkBox
            // 
            this.createMemoryImage_checkBox.AutoSize = true;
            this.createMemoryImage_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createMemoryImage_checkBox.Location = new System.Drawing.Point(84, 289);
            this.createMemoryImage_checkBox.Name = "createMemoryImage_checkBox";
            this.createMemoryImage_checkBox.Size = new System.Drawing.Size(169, 17);
            this.createMemoryImage_checkBox.TabIndex = 31;
            this.createMemoryImage_checkBox.Text = "Create max resolution tile in LR";
            this.toolTip1.SetToolTip(this.createMemoryImage_checkBox, " Helps with ESRGAN memory allocation, when you have images with different dimensi" +
        "ons in LR");
            this.createMemoryImage_checkBox.UseVisualStyleBackColor = true;
            // 
            // useCPU_checkBox
            // 
            this.useCPU_checkBox.AutoSize = true;
            this.useCPU_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useCPU_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.useCPU_checkBox.Location = new System.Drawing.Point(84, 333);
            this.useCPU_checkBox.Name = "useCPU_checkBox";
            this.useCPU_checkBox.Size = new System.Drawing.Size(68, 17);
            this.useCPU_checkBox.TabIndex = 30;
            this.useCPU_checkBox.Text = "Use CPU";
            this.toolTip1.SetToolTip(this.useCPU_checkBox, "Use CPU instead of GPU (very slow, especially on Windows)");
            this.useCPU_checkBox.UseVisualStyleBackColor = true;
            // 
            // seamlessTextures_checkBox
            // 
            this.seamlessTextures_checkBox.AutoSize = true;
            this.seamlessTextures_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seamlessTextures_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.seamlessTextures_checkBox.Location = new System.Drawing.Point(84, 260);
            this.seamlessTextures_checkBox.Name = "seamlessTextures_checkBox";
            this.seamlessTextures_checkBox.Size = new System.Drawing.Size(137, 17);
            this.seamlessTextures_checkBox.TabIndex = 30;
            this.seamlessTextures_checkBox.Text = "Seamless (tiled) textures";
            this.toolTip1.SetToolTip(this.seamlessTextures_checkBox, "Use if original image is seamless texture");
            this.seamlessTextures_checkBox.UseVisualStyleBackColor = true;
            // 
            // preserveFormat_checkBox
            // 
            this.preserveFormat_checkBox.AutoSize = true;
            this.preserveFormat_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preserveFormat_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.preserveFormat_checkBox.Location = new System.Drawing.Point(210, 162);
            this.preserveFormat_checkBox.Name = "preserveFormat_checkBox";
            this.preserveFormat_checkBox.Size = new System.Drawing.Size(142, 17);
            this.preserveFormat_checkBox.TabIndex = 30;
            this.preserveFormat_checkBox.Text = "Use original image format";
            this.toolTip1.SetToolTip(this.preserveFormat_checkBox, "Use original image extension with settings from Output fortmat tab");
            this.preserveFormat_checkBox.UseVisualStyleBackColor = true;
            this.preserveFormat_checkBox.CheckedChanged += new System.EventHandler(this.preserveFormat_checkBox_CheckedChanged);
            // 
            // changeInputImgPath_button
            // 
            this.changeInputImgPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInputImgPath_button.Location = new System.Drawing.Point(591, 69);
            this.changeInputImgPath_button.Name = "changeInputImgPath_button";
            this.changeInputImgPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeInputImgPath_button.TabIndex = 29;
            this.changeInputImgPath_button.Text = "...";
            this.changeInputImgPath_button.UseVisualStyleBackColor = true;
            this.changeInputImgPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // changeMergedResultsPath_button
            // 
            this.changeMergedResultsPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeMergedResultsPath_button.Location = new System.Drawing.Point(591, 44);
            this.changeMergedResultsPath_button.Name = "changeMergedResultsPath_button";
            this.changeMergedResultsPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeMergedResultsPath_button.TabIndex = 29;
            this.changeMergedResultsPath_button.Text = "...";
            this.changeMergedResultsPath_button.UseVisualStyleBackColor = true;
            this.changeMergedResultsPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // changeEsrganPath_button
            // 
            this.changeEsrganPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeEsrganPath_button.Location = new System.Drawing.Point(591, 18);
            this.changeEsrganPath_button.Name = "changeEsrganPath_button";
            this.changeEsrganPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeEsrganPath_button.TabIndex = 29;
            this.changeEsrganPath_button.Text = "...";
            this.changeEsrganPath_button.UseVisualStyleBackColor = true;
            this.changeEsrganPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // debugUpscale_checkBox
            // 
            this.debugUpscale_checkBox.AutoSize = true;
            this.debugUpscale_checkBox.Checked = true;
            this.debugUpscale_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugUpscale_checkBox.Location = new System.Drawing.Point(734, 693);
            this.debugUpscale_checkBox.Name = "debugUpscale_checkBox";
            this.debugUpscale_checkBox.Size = new System.Drawing.Size(166, 17);
            this.debugUpscale_checkBox.TabIndex = 28;
            this.debugUpscale_checkBox.Text = "Keep ESRGAN console open";
            this.debugUpscale_checkBox.UseVisualStyleBackColor = true;
            this.debugUpscale_checkBox.Visible = false;
            // 
            // useDifferentModelForAlpha_checkBox
            // 
            this.useDifferentModelForAlpha_checkBox.AutoSize = true;
            this.useDifferentModelForAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.useDifferentModelForAlpha_checkBox.Location = new System.Drawing.Point(84, 217);
            this.useDifferentModelForAlpha_checkBox.Name = "useDifferentModelForAlpha_checkBox";
            this.useDifferentModelForAlpha_checkBox.Size = new System.Drawing.Size(159, 17);
            this.useDifferentModelForAlpha_checkBox.TabIndex = 25;
            this.useDifferentModelForAlpha_checkBox.Text = "Use different model for alpha";
            this.toolTip1.SetToolTip(this.useDifferentModelForAlpha_checkBox, "Need to split images when changing this setting");
            this.useDifferentModelForAlpha_checkBox.UseVisualStyleBackColor = true;
            this.useDifferentModelForAlpha_checkBox.CheckedChanged += new System.EventHandler(this.useDifferentModelForAlpha_checkBox_CheckedChanged);
            // 
            // splitRGB_checkBox
            // 
            this.splitRGB_checkBox.AutoSize = true;
            this.splitRGB_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.splitRGB_checkBox.Location = new System.Drawing.Point(84, 240);
            this.splitRGB_checkBox.Name = "splitRGB_checkBox";
            this.splitRGB_checkBox.Size = new System.Drawing.Size(116, 17);
            this.splitRGB_checkBox.TabIndex = 25;
            this.splitRGB_checkBox.Text = "Split RGB channels";
            this.splitRGB_checkBox.UseVisualStyleBackColor = true;
            // 
            // preciseTile_checkBox
            // 
            this.preciseTile_checkBox.AutoSize = true;
            this.preciseTile_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preciseTile_checkBox.Location = new System.Drawing.Point(369, 109);
            this.preciseTile_checkBox.Name = "preciseTile_checkBox";
            this.preciseTile_checkBox.Size = new System.Drawing.Size(130, 17);
            this.preciseTile_checkBox.TabIndex = 25;
            this.preciseTile_checkBox.Text = "Precise tile dimensions";
            this.toolTip1.SetToolTip(this.preciseTile_checkBox, "Usefull when you need to create tiles for training");
            this.preciseTile_checkBox.UseVisualStyleBackColor = true;
            this.preciseTile_checkBox.CheckedChanged += new System.EventHandler(this.preciseTile_checkBox_CheckedChanged);
            // 
            // balanceAlphas_checkBox
            // 
            this.balanceAlphas_checkBox.AutoSize = true;
            this.balanceAlphas_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceAlphas_checkBox.Location = new System.Drawing.Point(355, 194);
            this.balanceAlphas_checkBox.Name = "balanceAlphas_checkBox";
            this.balanceAlphas_checkBox.Size = new System.Drawing.Size(161, 17);
            this.balanceAlphas_checkBox.TabIndex = 25;
            this.balanceAlphas_checkBox.Text = "Use globalbalance on alphas";
            this.toolTip1.SetToolTip(this.balanceAlphas_checkBox, "Disable if all image alphas that represents transparency mask");
            this.balanceAlphas_checkBox.UseVisualStyleBackColor = true;
            // 
            // ignoreSingleColorAlpha_checkBox
            // 
            this.ignoreSingleColorAlpha_checkBox.AutoSize = true;
            this.ignoreSingleColorAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignoreSingleColorAlpha_checkBox.Location = new System.Drawing.Point(210, 194);
            this.ignoreSingleColorAlpha_checkBox.Name = "ignoreSingleColorAlpha_checkBox";
            this.ignoreSingleColorAlpha_checkBox.Size = new System.Drawing.Size(144, 17);
            this.ignoreSingleColorAlpha_checkBox.TabIndex = 25;
            this.ignoreSingleColorAlpha_checkBox.Text = "Ignore single color alphas";
            this.toolTip1.SetToolTip(this.ignoreSingleColorAlpha_checkBox, "Solid alphas (pure white or black) will be always ignored on split");
            this.ignoreSingleColorAlpha_checkBox.UseVisualStyleBackColor = true;
            // 
            // ignoreAlpha_checkBox
            // 
            this.ignoreAlpha_checkBox.AutoSize = true;
            this.ignoreAlpha_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignoreAlpha_checkBox.Location = new System.Drawing.Point(84, 194);
            this.ignoreAlpha_checkBox.Name = "ignoreAlpha_checkBox";
            this.ignoreAlpha_checkBox.Size = new System.Drawing.Size(124, 17);
            this.ignoreAlpha_checkBox.TabIndex = 25;
            this.ignoreAlpha_checkBox.Text = "Ignore alpha channel";
            this.toolTip1.SetToolTip(this.ignoreAlpha_checkBox, "Don\'t create alpha tiles in LR, don\'t read alpha tiles from results");
            this.ignoreAlpha_checkBox.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 162);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Output format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tiles overlap";
            // 
            // overlapSize_numericUpDown
            // 
            this.overlapSize_numericUpDown.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Location = new System.Drawing.Point(84, 133);
            this.overlapSize_numericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.overlapSize_numericUpDown.Name = "overlapSize_numericUpDown";
            this.overlapSize_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.overlapSize_numericUpDown.TabIndex = 23;
            this.overlapSize_numericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Max tile WxH";
            // 
            // maxTileResolution_numericUpDown
            // 
            this.maxTileResolution_numericUpDown.Enabled = false;
            this.maxTileResolution_numericUpDown.Location = new System.Drawing.Point(84, 107);
            this.maxTileResolution_numericUpDown.Maximum = new decimal(new int[] {
            16777216,
            0,
            0,
            0});
            this.maxTileResolution_numericUpDown.Name = "maxTileResolution_numericUpDown";
            this.maxTileResolution_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxTileResolution_numericUpDown.TabIndex = 21;
            this.maxTileResolution_numericUpDown.ThousandsSeparator = true;
            this.maxTileResolution_numericUpDown.Value = new decimal(new int[] {
            204800,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Images";
            // 
            // imgPath_textBox
            // 
            this.imgPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPath_textBox.Location = new System.Drawing.Point(84, 70);
            this.imgPath_textBox.Name = "imgPath_textBox";
            this.imgPath_textBox.ReadOnly = true;
            this.imgPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.imgPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.imgPath_textBox, "IEU input folder");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Merged results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ESRGAN";
            // 
            // settingsOutputFormat_tabPage
            // 
            this.settingsOutputFormat_tabPage.Controls.Add(this.groupBox2);
            this.settingsOutputFormat_tabPage.Controls.Add(this.groupBox3);
            this.settingsOutputFormat_tabPage.Controls.Add(this.tiffSetting_groupBox);
            this.settingsOutputFormat_tabPage.Controls.Add(this.ddsOutputSettings_groupBox);
            this.settingsOutputFormat_tabPage.Location = new System.Drawing.Point(4, 25);
            this.settingsOutputFormat_tabPage.Name = "settingsOutputFormat_tabPage";
            this.settingsOutputFormat_tabPage.Size = new System.Drawing.Size(770, 613);
            this.settingsOutputFormat_tabPage.TabIndex = 4;
            this.settingsOutputFormat_tabPage.Text = "Output formats";
            this.settingsOutputFormat_tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webpLossless_checkBox);
            this.groupBox2.Controls.Add(this.webpQuality_numericUpDown);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.webpPreset_comboBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 107);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WEBP";
            // 
            // webpLossless_checkBox
            // 
            this.webpLossless_checkBox.AutoSize = true;
            this.webpLossless_checkBox.Location = new System.Drawing.Point(9, 24);
            this.webpLossless_checkBox.Name = "webpLossless_checkBox";
            this.webpLossless_checkBox.Size = new System.Drawing.Size(66, 17);
            this.webpLossless_checkBox.TabIndex = 47;
            this.webpLossless_checkBox.Text = "Lossless";
            this.webpLossless_checkBox.UseVisualStyleBackColor = true;
            this.webpLossless_checkBox.CheckedChanged += new System.EventHandler(this.webpLossless_checkBox_CheckedChanged);
            // 
            // webpQuality_numericUpDown
            // 
            this.webpQuality_numericUpDown.Location = new System.Drawing.Point(111, 73);
            this.webpQuality_numericUpDown.Name = "webpQuality_numericUpDown";
            this.webpQuality_numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.webpQuality_numericUpDown.TabIndex = 46;
            this.webpQuality_numericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(64, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Quality";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Compression preset";
            // 
            // webpPreset_comboBox
            // 
            this.webpPreset_comboBox.FormattingEnabled = true;
            this.webpPreset_comboBox.Location = new System.Drawing.Point(111, 44);
            this.webpPreset_comboBox.Name = "webpPreset_comboBox";
            this.webpPreset_comboBox.Size = new System.Drawing.Size(96, 21);
            this.webpPreset_comboBox.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pngCompression_numericUpDown);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(8, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 52);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PNG";
            // 
            // pngCompression_numericUpDown
            // 
            this.pngCompression_numericUpDown.Location = new System.Drawing.Point(111, 19);
            this.pngCompression_numericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pngCompression_numericUpDown.Name = "pngCompression_numericUpDown";
            this.pngCompression_numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.pngCompression_numericUpDown.TabIndex = 44;
            this.toolTip1.SetToolTip(this.pngCompression_numericUpDown, "0 - no compression, 9 - max compression");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Compression factor";
            this.toolTip1.SetToolTip(this.label18, "0 - no compression, 9 - max compression");
            // 
            // tiffSetting_groupBox
            // 
            this.tiffSetting_groupBox.Controls.Add(this.tiffJpegQuality_numericUpDown);
            this.tiffSetting_groupBox.Controls.Add(this.label25);
            this.tiffSetting_groupBox.Controls.Add(this.label24);
            this.tiffSetting_groupBox.Controls.Add(this.tiffSettings_comboBox);
            this.tiffSetting_groupBox.Location = new System.Drawing.Point(8, 17);
            this.tiffSetting_groupBox.Name = "tiffSetting_groupBox";
            this.tiffSetting_groupBox.Size = new System.Drawing.Size(225, 73);
            this.tiffSetting_groupBox.TabIndex = 46;
            this.tiffSetting_groupBox.TabStop = false;
            this.tiffSetting_groupBox.Text = "TIFF";
            // 
            // tiffJpegQuality_numericUpDown
            // 
            this.tiffJpegQuality_numericUpDown.Location = new System.Drawing.Point(112, 44);
            this.tiffJpegQuality_numericUpDown.Name = "tiffJpegQuality_numericUpDown";
            this.tiffJpegQuality_numericUpDown.Size = new System.Drawing.Size(48, 20);
            this.tiffJpegQuality_numericUpDown.TabIndex = 46;
            this.tiffJpegQuality_numericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Jpeg quality";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Compresion method";
            // 
            // tiffSettings_comboBox
            // 
            this.tiffSettings_comboBox.FormattingEnabled = true;
            this.tiffSettings_comboBox.Location = new System.Drawing.Point(112, 15);
            this.tiffSettings_comboBox.Name = "tiffSettings_comboBox";
            this.tiffSettings_comboBox.Size = new System.Drawing.Size(96, 21);
            this.tiffSettings_comboBox.TabIndex = 45;
            // 
            // ddsOutputSettings_groupBox
            // 
            this.ddsOutputSettings_groupBox.Controls.Add(this.label17);
            this.ddsOutputSettings_groupBox.Controls.Add(this.label16);
            this.ddsOutputSettings_groupBox.Controls.Add(this.label15);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsGenerateMipmaps_checkBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsCompresion_comboBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsFileFormat_comboBox);
            this.ddsOutputSettings_groupBox.Controls.Add(this.ddsTextureType_comboBox);
            this.ddsOutputSettings_groupBox.Location = new System.Drawing.Point(368, 17);
            this.ddsOutputSettings_groupBox.Name = "ddsOutputSettings_groupBox";
            this.ddsOutputSettings_groupBox.Size = new System.Drawing.Size(344, 139);
            this.ddsOutputSettings_groupBox.TabIndex = 42;
            this.ddsOutputSettings_groupBox.TabStop = false;
            this.ddsOutputSettings_groupBox.Text = "DDS output settings";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "BC7 Compression";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Compression";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Texture type";
            // 
            // ddsGenerateMipmaps_checkBox
            // 
            this.ddsGenerateMipmaps_checkBox.AutoSize = true;
            this.ddsGenerateMipmaps_checkBox.Checked = true;
            this.ddsGenerateMipmaps_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ddsGenerateMipmaps_checkBox.Location = new System.Drawing.Point(104, 110);
            this.ddsGenerateMipmaps_checkBox.Name = "ddsGenerateMipmaps_checkBox";
            this.ddsGenerateMipmaps_checkBox.Size = new System.Drawing.Size(114, 17);
            this.ddsGenerateMipmaps_checkBox.TabIndex = 1;
            this.ddsGenerateMipmaps_checkBox.Text = "Generate mipmaps";
            this.ddsGenerateMipmaps_checkBox.UseVisualStyleBackColor = true;
            // 
            // ddsCompresion_comboBox
            // 
            this.ddsCompresion_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsCompresion_comboBox.FormattingEnabled = true;
            this.ddsCompresion_comboBox.Location = new System.Drawing.Point(104, 83);
            this.ddsCompresion_comboBox.Name = "ddsCompresion_comboBox";
            this.ddsCompresion_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsCompresion_comboBox.TabIndex = 0;
            // 
            // ddsFileFormat_comboBox
            // 
            this.ddsFileFormat_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsFileFormat_comboBox.FormattingEnabled = true;
            this.ddsFileFormat_comboBox.Location = new System.Drawing.Point(104, 56);
            this.ddsFileFormat_comboBox.Name = "ddsFileFormat_comboBox";
            this.ddsFileFormat_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsFileFormat_comboBox.TabIndex = 0;
            // 
            // ddsTextureType_comboBox
            // 
            this.ddsTextureType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsTextureType_comboBox.FormattingEnabled = true;
            this.ddsTextureType_comboBox.Location = new System.Drawing.Point(104, 28);
            this.ddsTextureType_comboBox.Name = "ddsTextureType_comboBox";
            this.ddsTextureType_comboBox.Size = new System.Drawing.Size(222, 21);
            this.ddsTextureType_comboBox.TabIndex = 0;
            // 
            // advanced_tabPage
            // 
            this.advanced_tabPage.Controls.Add(this.imagePostprocess_groupBox);
            this.advanced_tabPage.Controls.Add(this.imagePreprocess_groupBox);
            this.advanced_tabPage.Controls.Add(this.changeModelsPath_button);
            this.advanced_tabPage.Controls.Add(this.upscaleSize_groupBox);
            this.advanced_tabPage.Controls.Add(this.changeOutputPath_button);
            this.advanced_tabPage.Controls.Add(this.filters_groupBox);
            this.advanced_tabPage.Controls.Add(this.label8);
            this.advanced_tabPage.Controls.Add(this.advancedSuffix_textBox);
            this.advanced_tabPage.Controls.Add(this.changeInputPath_button);
            this.advanced_tabPage.Controls.Add(this.advancedUseSuffix_checkBox);
            this.advanced_tabPage.Controls.Add(this.inputPath_textBox);
            this.advanced_tabPage.Controls.Add(this.outputPath_textBox);
            this.advanced_tabPage.Controls.Add(this.modelsPath_textBox);
            this.advanced_tabPage.Controls.Add(this.label7);
            this.advanced_tabPage.Controls.Add(this.label2);
            this.advanced_tabPage.Location = new System.Drawing.Point(4, 25);
            this.advanced_tabPage.Name = "advanced_tabPage";
            this.advanced_tabPage.Size = new System.Drawing.Size(770, 613);
            this.advanced_tabPage.TabIndex = 2;
            this.advanced_tabPage.Text = "Advanced";
            this.advanced_tabPage.UseVisualStyleBackColor = true;
            // 
            // imagePostprocess_groupBox
            // 
            this.imagePostprocess_groupBox.Controls.Add(this.label22);
            this.imagePostprocess_groupBox.Controls.Add(this.threshold_groupBox);
            this.imagePostprocess_groupBox.Controls.Add(this.label21);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterFilterType_comboBox);
            this.imagePostprocess_groupBox.Controls.Add(this.resizeImageAfterScaleFactor_comboBox);
            this.imagePostprocess_groupBox.Location = new System.Drawing.Point(442, 407);
            this.imagePostprocess_groupBox.Name = "imagePostprocess_groupBox";
            this.imagePostprocess_groupBox.Size = new System.Drawing.Size(269, 198);
            this.imagePostprocess_groupBox.TabIndex = 42;
            this.imagePostprocess_groupBox.TabStop = false;
            this.imagePostprocess_groupBox.Text = "Image postprocess";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(177, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "to";
            // 
            // threshold_groupBox
            // 
            this.threshold_groupBox.Controls.Add(this.thresholdBlack_numericUpDown);
            this.threshold_groupBox.Controls.Add(this.label13);
            this.threshold_groupBox.Controls.Add(this.thresholdEnabled_checkBox);
            this.threshold_groupBox.Controls.Add(this.label12);
            this.threshold_groupBox.Controls.Add(this.thresholdWhite_numericUpDown);
            this.threshold_groupBox.Location = new System.Drawing.Point(12, 22);
            this.threshold_groupBox.Name = "threshold_groupBox";
            this.threshold_groupBox.Size = new System.Drawing.Size(204, 88);
            this.threshold_groupBox.TabIndex = 3;
            this.threshold_groupBox.TabStop = false;
            this.threshold_groupBox.Text = "Threshold";
            // 
            // thresholdBlack_numericUpDown
            // 
            this.thresholdBlack_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdBlack_numericUpDown.Enabled = false;
            this.thresholdBlack_numericUpDown.Location = new System.Drawing.Point(91, 24);
            this.thresholdBlack_numericUpDown.Name = "thresholdBlack_numericUpDown";
            this.thresholdBlack_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.thresholdBlack_numericUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.thresholdBlack_numericUpDown, "Make all pixels darker than percentage true black");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(137, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "% White";
            // 
            // thresholdEnabled_checkBox
            // 
            this.thresholdEnabled_checkBox.AutoSize = true;
            this.thresholdEnabled_checkBox.Location = new System.Drawing.Point(12, 38);
            this.thresholdEnabled_checkBox.Name = "thresholdEnabled_checkBox";
            this.thresholdEnabled_checkBox.Size = new System.Drawing.Size(73, 17);
            this.thresholdEnabled_checkBox.TabIndex = 0;
            this.thresholdEnabled_checkBox.Text = "Threshold";
            this.thresholdEnabled_checkBox.UseVisualStyleBackColor = true;
            this.thresholdEnabled_checkBox.CheckedChanged += new System.EventHandler(this.thresholdEnabled_checkBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(137, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "% Black";
            // 
            // thresholdWhite_numericUpDown
            // 
            this.thresholdWhite_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdWhite_numericUpDown.Enabled = false;
            this.thresholdWhite_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.thresholdWhite_numericUpDown.Location = new System.Drawing.Point(91, 50);
            this.thresholdWhite_numericUpDown.Name = "thresholdWhite_numericUpDown";
            this.thresholdWhite_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.thresholdWhite_numericUpDown.TabIndex = 1;
            this.toolTip1.SetToolTip(this.thresholdWhite_numericUpDown, "Make all pixels brighter than percentage true white");
            this.thresholdWhite_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Resize with";
            // 
            // resizeImageAfterFilterType_comboBox
            // 
            this.resizeImageAfterFilterType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageAfterFilterType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageAfterFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageAfterFilterType_comboBox.Location = new System.Drawing.Point(68, 123);
            this.resizeImageAfterFilterType_comboBox.Name = "resizeImageAfterFilterType_comboBox";
            this.resizeImageAfterFilterType_comboBox.Size = new System.Drawing.Size(102, 21);
            this.resizeImageAfterFilterType_comboBox.TabIndex = 0;
            // 
            // resizeImageAfterScaleFactor_comboBox
            // 
            this.resizeImageAfterScaleFactor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageAfterScaleFactor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageAfterScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageAfterScaleFactor_comboBox.Location = new System.Drawing.Point(200, 123);
            this.resizeImageAfterScaleFactor_comboBox.Name = "resizeImageAfterScaleFactor_comboBox";
            this.resizeImageAfterScaleFactor_comboBox.Size = new System.Drawing.Size(60, 21);
            this.resizeImageAfterScaleFactor_comboBox.TabIndex = 0;
            // 
            // imagePreprocess_groupBox
            // 
            this.imagePreprocess_groupBox.Controls.Add(this.label20);
            this.imagePreprocess_groupBox.Controls.Add(this.label19);
            this.imagePreprocess_groupBox.Controls.Add(this.label14);
            this.imagePreprocess_groupBox.Controls.Add(this.resizeImageBeforeScaleFactor_comboBox);
            this.imagePreprocess_groupBox.Controls.Add(this.resizeImageBeforeFilterType_comboBox);
            this.imagePreprocess_groupBox.Controls.Add(this.noiseReductionType_comboBox);
            this.imagePreprocess_groupBox.Location = new System.Drawing.Point(7, 407);
            this.imagePreprocess_groupBox.Name = "imagePreprocess_groupBox";
            this.imagePreprocess_groupBox.Size = new System.Drawing.Size(429, 198);
            this.imagePreprocess_groupBox.TabIndex = 41;
            this.imagePreprocess_groupBox.TabStop = false;
            this.imagePreprocess_groupBox.Text = "Image preprocess";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(217, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "to";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Resize with";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Reduce noise";
            // 
            // resizeImageBeforeScaleFactor_comboBox
            // 
            this.resizeImageBeforeScaleFactor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageBeforeScaleFactor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageBeforeScaleFactor_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeScaleFactor_comboBox.Location = new System.Drawing.Point(239, 57);
            this.resizeImageBeforeScaleFactor_comboBox.Name = "resizeImageBeforeScaleFactor_comboBox";
            this.resizeImageBeforeScaleFactor_comboBox.Size = new System.Drawing.Size(60, 21);
            this.resizeImageBeforeScaleFactor_comboBox.TabIndex = 0;
            // 
            // resizeImageBeforeFilterType_comboBox
            // 
            this.resizeImageBeforeFilterType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeImageBeforeFilterType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resizeImageBeforeFilterType_comboBox.FormattingEnabled = true;
            this.resizeImageBeforeFilterType_comboBox.Location = new System.Drawing.Point(87, 57);
            this.resizeImageBeforeFilterType_comboBox.Name = "resizeImageBeforeFilterType_comboBox";
            this.resizeImageBeforeFilterType_comboBox.Size = new System.Drawing.Size(127, 21);
            this.resizeImageBeforeFilterType_comboBox.TabIndex = 0;
            // 
            // noiseReductionType_comboBox
            // 
            this.noiseReductionType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noiseReductionType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noiseReductionType_comboBox.FormattingEnabled = true;
            this.noiseReductionType_comboBox.Location = new System.Drawing.Point(87, 26);
            this.noiseReductionType_comboBox.Name = "noiseReductionType_comboBox";
            this.noiseReductionType_comboBox.Size = new System.Drawing.Size(127, 21);
            this.noiseReductionType_comboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.noiseReductionType_comboBox, "Try to remove image noise with specific ImageMagick method");
            // 
            // changeModelsPath_button
            // 
            this.changeModelsPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeModelsPath_button.Location = new System.Drawing.Point(591, 69);
            this.changeModelsPath_button.Name = "changeModelsPath_button";
            this.changeModelsPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeModelsPath_button.TabIndex = 29;
            this.changeModelsPath_button.Text = "...";
            this.changeModelsPath_button.UseVisualStyleBackColor = true;
            this.changeModelsPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // upscaleSize_groupBox
            // 
            this.upscaleSize_groupBox.Controls.Add(this.x1_radioButton);
            this.upscaleSize_groupBox.Controls.Add(this.x2_radioButton);
            this.upscaleSize_groupBox.Controls.Add(this.x4_radioButton);
            this.upscaleSize_groupBox.Location = new System.Drawing.Point(977, 618);
            this.upscaleSize_groupBox.Name = "upscaleSize_groupBox";
            this.upscaleSize_groupBox.Size = new System.Drawing.Size(129, 54);
            this.upscaleSize_groupBox.TabIndex = 39;
            this.upscaleSize_groupBox.TabStop = false;
            this.upscaleSize_groupBox.Text = "Upscale Size";
            this.upscaleSize_groupBox.Visible = false;
            // 
            // x1_radioButton
            // 
            this.x1_radioButton.AutoSize = true;
            this.x1_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1_radioButton.Location = new System.Drawing.Point(6, 23);
            this.x1_radioButton.Name = "x1_radioButton";
            this.x1_radioButton.Size = new System.Drawing.Size(35, 17);
            this.x1_radioButton.TabIndex = 12;
            this.x1_radioButton.Tag = "1";
            this.x1_radioButton.Text = "x1";
            this.x1_radioButton.UseVisualStyleBackColor = true;
            // 
            // x2_radioButton
            // 
            this.x2_radioButton.AutoSize = true;
            this.x2_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x2_radioButton.Location = new System.Drawing.Point(48, 23);
            this.x2_radioButton.Name = "x2_radioButton";
            this.x2_radioButton.Size = new System.Drawing.Size(35, 17);
            this.x2_radioButton.TabIndex = 10;
            this.x2_radioButton.Tag = "2";
            this.x2_radioButton.Text = "x2";
            this.x2_radioButton.UseVisualStyleBackColor = true;
            // 
            // x4_radioButton
            // 
            this.x4_radioButton.AutoSize = true;
            this.x4_radioButton.Checked = true;
            this.x4_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x4_radioButton.Location = new System.Drawing.Point(90, 23);
            this.x4_radioButton.Name = "x4_radioButton";
            this.x4_radioButton.Size = new System.Drawing.Size(35, 17);
            this.x4_radioButton.TabIndex = 11;
            this.x4_radioButton.TabStop = true;
            this.x4_radioButton.Tag = "4";
            this.x4_radioButton.Text = "x4";
            this.x4_radioButton.UseVisualStyleBackColor = true;
            // 
            // changeOutputPath_button
            // 
            this.changeOutputPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeOutputPath_button.Location = new System.Drawing.Point(591, 43);
            this.changeOutputPath_button.Name = "changeOutputPath_button";
            this.changeOutputPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeOutputPath_button.TabIndex = 29;
            this.changeOutputPath_button.Text = "...";
            this.changeOutputPath_button.UseVisualStyleBackColor = true;
            this.changeOutputPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // filters_groupBox
            // 
            this.filters_groupBox.Controls.Add(this.filterExtensions_checkedListBox);
            this.filters_groupBox.Controls.Add(this.filtersSize_groupBox);
            this.filters_groupBox.Controls.Add(this.filtersFilename_groupBox);
            this.filters_groupBox.Controls.Add(this.checkBox3);
            this.filters_groupBox.Controls.Add(this.filtersAlpha_groupBox);
            this.filters_groupBox.Location = new System.Drawing.Point(7, 131);
            this.filters_groupBox.Name = "filters_groupBox";
            this.filters_groupBox.Size = new System.Drawing.Size(704, 270);
            this.filters_groupBox.TabIndex = 32;
            this.filters_groupBox.TabStop = false;
            this.filters_groupBox.Text = "Filters";
            // 
            // filterExtensions_checkedListBox
            // 
            this.filterExtensions_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterExtensions_checkedListBox.FormattingEnabled = true;
            this.filterExtensions_checkedListBox.Location = new System.Drawing.Point(425, 38);
            this.filterExtensions_checkedListBox.Name = "filterExtensions_checkedListBox";
            this.filterExtensions_checkedListBox.Size = new System.Drawing.Size(120, 197);
            this.filterExtensions_checkedListBox.TabIndex = 10;
            this.filterExtensions_checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filterExtensions_checkedListBox_ItemCheck);
            // 
            // filtersSize_groupBox
            // 
            this.filtersSize_groupBox.Controls.Add(this.filtersSizeOn_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeWidth_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeHeight_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.label11);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeOr_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.label10);
            this.filtersSize_groupBox.Location = new System.Drawing.Point(181, 141);
            this.filtersSize_groupBox.Name = "filtersSize_groupBox";
            this.filtersSize_groupBox.Size = new System.Drawing.Size(227, 94);
            this.filtersSize_groupBox.TabIndex = 9;
            this.filtersSize_groupBox.TabStop = false;
            this.filtersSize_groupBox.Text = "Size";
            // 
            // filtersSizeOn_checkBox
            // 
            this.filtersSizeOn_checkBox.AutoSize = true;
            this.filtersSizeOn_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtersSizeOn_checkBox.Location = new System.Drawing.Point(7, 42);
            this.filtersSizeOn_checkBox.Name = "filtersSizeOn_checkBox";
            this.filtersSizeOn_checkBox.Size = new System.Drawing.Size(72, 17);
            this.filtersSizeOn_checkBox.TabIndex = 11;
            this.filtersSizeOn_checkBox.Text = "Not bigger";
            this.filtersSizeOn_checkBox.UseVisualStyleBackColor = true;
            this.filtersSizeOn_checkBox.CheckedChanged += new System.EventHandler(this.filtersSizeOn_checkBox_CheckedChanged);
            // 
            // filterSizeWidth_numericUpDown
            // 
            this.filterSizeWidth_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSizeWidth_numericUpDown.Enabled = false;
            this.filterSizeWidth_numericUpDown.Location = new System.Drawing.Point(79, 29);
            this.filterSizeWidth_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterSizeWidth_numericUpDown.Name = "filterSizeWidth_numericUpDown";
            this.filterSizeWidth_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.filterSizeWidth_numericUpDown.TabIndex = 3;
            this.filterSizeWidth_numericUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // filterSizeHeight_numericUpDown
            // 
            this.filterSizeHeight_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSizeHeight_numericUpDown.Enabled = false;
            this.filterSizeHeight_numericUpDown.Location = new System.Drawing.Point(79, 52);
            this.filterSizeHeight_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterSizeHeight_numericUpDown.Name = "filterSizeHeight_numericUpDown";
            this.filterSizeHeight_numericUpDown.Size = new System.Drawing.Size(55, 20);
            this.filterSizeHeight_numericUpDown.TabIndex = 3;
            this.filterSizeHeight_numericUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Height";
            // 
            // filterSizeOr_checkBox
            // 
            this.filterSizeOr_checkBox.AutoSize = true;
            this.filterSizeOr_checkBox.Enabled = false;
            this.filterSizeOr_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSizeOr_checkBox.Location = new System.Drawing.Point(174, 42);
            this.filterSizeOr_checkBox.Name = "filterSizeOr_checkBox";
            this.filterSizeOr_checkBox.Size = new System.Drawing.Size(39, 17);
            this.filterSizeOr_checkBox.TabIndex = 4;
            this.filterSizeOr_checkBox.Text = "OR";
            this.filterSizeOr_checkBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.filterSizeOr_checkBox.UseVisualStyleBackColor = true;
            this.filterSizeOr_checkBox.CheckedChanged += new System.EventHandler(this.filterSizeOr_checkBox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Width";
            // 
            // filtersFilename_groupBox
            // 
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameCaseSensitive_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_textBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_textBox);
            this.filtersFilename_groupBox.Location = new System.Drawing.Point(11, 34);
            this.filtersFilename_groupBox.Name = "filtersFilename_groupBox";
            this.filtersFilename_groupBox.Size = new System.Drawing.Size(397, 94);
            this.filtersFilename_groupBox.TabIndex = 8;
            this.filtersFilename_groupBox.TabStop = false;
            this.filtersFilename_groupBox.Text = "Filename";
            // 
            // filterFilenameCaseSensitive_checkBox
            // 
            this.filterFilenameCaseSensitive_checkBox.AutoSize = true;
            this.filterFilenameCaseSensitive_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFilenameCaseSensitive_checkBox.Location = new System.Drawing.Point(112, 15);
            this.filterFilenameCaseSensitive_checkBox.Name = "filterFilenameCaseSensitive_checkBox";
            this.filterFilenameCaseSensitive_checkBox.Size = new System.Drawing.Size(91, 17);
            this.filterFilenameCaseSensitive_checkBox.TabIndex = 3;
            this.filterFilenameCaseSensitive_checkBox.Text = "Case sensitive";
            this.filterFilenameCaseSensitive_checkBox.UseVisualStyleBackColor = true;
            // 
            // filterFilenameContains_checkBox
            // 
            this.filterFilenameContains_checkBox.AutoSize = true;
            this.filterFilenameContains_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFilenameContains_checkBox.Location = new System.Drawing.Point(9, 39);
            this.filterFilenameContains_checkBox.Name = "filterFilenameContains_checkBox";
            this.filterFilenameContains_checkBox.Size = new System.Drawing.Size(64, 17);
            this.filterFilenameContains_checkBox.TabIndex = 1;
            this.filterFilenameContains_checkBox.Text = "Contains";
            this.filterFilenameContains_checkBox.UseVisualStyleBackColor = true;
            this.filterFilenameContains_checkBox.CheckedChanged += new System.EventHandler(this.filterFilenameContains_checkBox_CheckedChanged);
            // 
            // filterFilenameContains_textBox
            // 
            this.filterFilenameContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFilenameContains_textBox.Location = new System.Drawing.Point(112, 38);
            this.filterFilenameContains_textBox.Name = "filterFilenameContains_textBox";
            this.filterFilenameContains_textBox.ReadOnly = true;
            this.filterFilenameContains_textBox.Size = new System.Drawing.Size(266, 20);
            this.filterFilenameContains_textBox.TabIndex = 2;
            // 
            // filterFilenameNotContains_checkBox
            // 
            this.filterFilenameNotContains_checkBox.AutoSize = true;
            this.filterFilenameNotContains_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFilenameNotContains_checkBox.Location = new System.Drawing.Point(9, 65);
            this.filterFilenameNotContains_checkBox.Name = "filterFilenameNotContains_checkBox";
            this.filterFilenameNotContains_checkBox.Size = new System.Drawing.Size(97, 17);
            this.filterFilenameNotContains_checkBox.TabIndex = 1;
            this.filterFilenameNotContains_checkBox.Text = "Doesn\'t contain";
            this.filterFilenameNotContains_checkBox.UseVisualStyleBackColor = true;
            this.filterFilenameNotContains_checkBox.CheckedChanged += new System.EventHandler(this.filterFilenameNotContains_checkBox_CheckedChanged);
            // 
            // filterFilenameNotContains_textBox
            // 
            this.filterFilenameNotContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFilenameNotContains_textBox.Location = new System.Drawing.Point(112, 64);
            this.filterFilenameNotContains_textBox.Name = "filterFilenameNotContains_textBox";
            this.filterFilenameNotContains_textBox.ReadOnly = true;
            this.filterFilenameNotContains_textBox.Size = new System.Drawing.Size(266, 20);
            this.filterFilenameNotContains_textBox.TabIndex = 2;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(855, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Already has result";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // filtersAlpha_groupBox
            // 
            this.filtersAlpha_groupBox.Controls.Add(this.filterAlpha_comboBox);
            this.filtersAlpha_groupBox.Location = new System.Drawing.Point(11, 141);
            this.filtersAlpha_groupBox.Name = "filtersAlpha_groupBox";
            this.filtersAlpha_groupBox.Size = new System.Drawing.Size(164, 94);
            this.filtersAlpha_groupBox.TabIndex = 0;
            this.filtersAlpha_groupBox.TabStop = false;
            this.filtersAlpha_groupBox.Text = "Alpha";
            // 
            // filterAlpha_comboBox
            // 
            this.filterAlpha_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.filterAlpha_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterAlpha_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterAlpha_comboBox.FormattingEnabled = true;
            this.filterAlpha_comboBox.Location = new System.Drawing.Point(9, 38);
            this.filterAlpha_comboBox.Name = "filterAlpha_comboBox";
            this.filterAlpha_comboBox.Size = new System.Drawing.Size(147, 21);
            this.filterAlpha_comboBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Models";
            // 
            // advancedSuffix_textBox
            // 
            this.advancedSuffix_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedSuffix_textBox.Location = new System.Drawing.Point(393, 96);
            this.advancedSuffix_textBox.Name = "advancedSuffix_textBox";
            this.advancedSuffix_textBox.ReadOnly = true;
            this.advancedSuffix_textBox.Size = new System.Drawing.Size(193, 20);
            this.advancedSuffix_textBox.TabIndex = 1;
            // 
            // changeInputPath_button
            // 
            this.changeInputPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInputPath_button.Location = new System.Drawing.Point(591, 17);
            this.changeInputPath_button.Name = "changeInputPath_button";
            this.changeInputPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeInputPath_button.TabIndex = 29;
            this.changeInputPath_button.Text = "...";
            this.changeInputPath_button.UseVisualStyleBackColor = true;
            this.changeInputPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // advancedUseSuffix_checkBox
            // 
            this.advancedUseSuffix_checkBox.AutoSize = true;
            this.advancedUseSuffix_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedUseSuffix_checkBox.Location = new System.Drawing.Point(273, 97);
            this.advancedUseSuffix_checkBox.Name = "advancedUseSuffix_checkBox";
            this.advancedUseSuffix_checkBox.Size = new System.Drawing.Size(117, 17);
            this.advancedUseSuffix_checkBox.TabIndex = 0;
            this.advancedUseSuffix_checkBox.Text = "Use suffix for results";
            this.advancedUseSuffix_checkBox.UseVisualStyleBackColor = true;
            this.advancedUseSuffix_checkBox.CheckedChanged += new System.EventHandler(this.advancedUseSuffix_checkBox_CheckedChanged);
            // 
            // inputPath_textBox
            // 
            this.inputPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPath_textBox.Location = new System.Drawing.Point(84, 18);
            this.inputPath_textBox.Name = "inputPath_textBox";
            this.inputPath_textBox.ReadOnly = true;
            this.inputPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.inputPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.inputPath_textBox, "ESRGAN input folder");
            // 
            // outputPath_textBox
            // 
            this.outputPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPath_textBox.Location = new System.Drawing.Point(84, 44);
            this.outputPath_textBox.Name = "outputPath_textBox";
            this.outputPath_textBox.ReadOnly = true;
            this.outputPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.outputPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.outputPath_textBox, "ESRGAN output folder");
            // 
            // modelsPath_textBox
            // 
            this.modelsPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelsPath_textBox.Location = new System.Drawing.Point(84, 70);
            this.modelsPath_textBox.Name = "modelsPath_textBox";
            this.modelsPath_textBox.ReadOnly = true;
            this.modelsPath_textBox.Size = new System.Drawing.Size(502, 20);
            this.modelsPath_textBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.modelsPath_textBox, "Folder with .pth files");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Output/results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Input/LR";
            // 
            // interpolation_tabPage
            // 
            this.interpolation_tabPage.Controls.Add(this.modelInterpolationAlpha_trackBar);
            this.interpolation_tabPage.Controls.Add(this.interpolationOutputModelName_textBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationStart_button);
            this.interpolation_tabPage.Controls.Add(this.modelInterpolationAlphaValue_textBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationModelTwo_comboBox);
            this.interpolation_tabPage.Controls.Add(this.interpolationModelOne_comboBox);
            this.interpolation_tabPage.Location = new System.Drawing.Point(4, 25);
            this.interpolation_tabPage.Name = "interpolation_tabPage";
            this.interpolation_tabPage.Size = new System.Drawing.Size(770, 613);
            this.interpolation_tabPage.TabIndex = 3;
            this.interpolation_tabPage.Text = "Models interpolation";
            this.interpolation_tabPage.UseVisualStyleBackColor = true;
            // 
            // modelInterpolationAlpha_trackBar
            // 
            this.modelInterpolationAlpha_trackBar.LargeChange = 10;
            this.modelInterpolationAlpha_trackBar.Location = new System.Drawing.Point(25, 135);
            this.modelInterpolationAlpha_trackBar.Maximum = 99;
            this.modelInterpolationAlpha_trackBar.Minimum = 1;
            this.modelInterpolationAlpha_trackBar.Name = "modelInterpolationAlpha_trackBar";
            this.modelInterpolationAlpha_trackBar.Size = new System.Drawing.Size(428, 45);
            this.modelInterpolationAlpha_trackBar.TabIndex = 4;
            this.modelInterpolationAlpha_trackBar.Value = 50;
            this.modelInterpolationAlpha_trackBar.Scroll += new System.EventHandler(this.ModelInterpolationAlpha_trackBar_Scroll);
            // 
            // interpolationOutputModelName_textBox
            // 
            this.interpolationOutputModelName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interpolationOutputModelName_textBox.Location = new System.Drawing.Point(25, 186);
            this.interpolationOutputModelName_textBox.Name = "interpolationOutputModelName_textBox";
            this.interpolationOutputModelName_textBox.Size = new System.Drawing.Size(428, 20);
            this.interpolationOutputModelName_textBox.TabIndex = 3;
            // 
            // interpolationStart_button
            // 
            this.interpolationStart_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationStart_button.Location = new System.Drawing.Point(25, 222);
            this.interpolationStart_button.Name = "interpolationStart_button";
            this.interpolationStart_button.Size = new System.Drawing.Size(428, 53);
            this.interpolationStart_button.TabIndex = 2;
            this.interpolationStart_button.Text = "INTERPOLATE";
            this.interpolationStart_button.UseVisualStyleBackColor = true;
            this.interpolationStart_button.Click += new System.EventHandler(this.interpolationStart_button_Click);
            // 
            // modelInterpolationAlphaValue_textBox
            // 
            this.modelInterpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelInterpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.modelInterpolationAlphaValue_textBox.Location = new System.Drawing.Point(459, 86);
            this.modelInterpolationAlphaValue_textBox.Name = "modelInterpolationAlphaValue_textBox";
            this.modelInterpolationAlphaValue_textBox.ReadOnly = true;
            this.modelInterpolationAlphaValue_textBox.Size = new System.Drawing.Size(63, 21);
            this.modelInterpolationAlphaValue_textBox.TabIndex = 1;
            this.modelInterpolationAlphaValue_textBox.Text = "0.5";
            this.modelInterpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelInterpolationAlphaValue_textBox.TextChanged += new System.EventHandler(this.InterpolationSettingsChanged);
            // 
            // interpolationModelTwo_comboBox
            // 
            this.interpolationModelTwo_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.interpolationModelTwo_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.interpolationModelTwo_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationModelTwo_comboBox.FormattingEnabled = true;
            this.interpolationModelTwo_comboBox.Location = new System.Drawing.Point(25, 108);
            this.interpolationModelTwo_comboBox.Name = "interpolationModelTwo_comboBox";
            this.interpolationModelTwo_comboBox.Size = new System.Drawing.Size(428, 21);
            this.interpolationModelTwo_comboBox.TabIndex = 0;
            this.interpolationModelTwo_comboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationModelsChanged);
            // 
            // interpolationModelOne_comboBox
            // 
            this.interpolationModelOne_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.interpolationModelOne_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.interpolationModelOne_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.interpolationModelOne_comboBox.FormattingEnabled = true;
            this.interpolationModelOne_comboBox.Location = new System.Drawing.Point(25, 68);
            this.interpolationModelOne_comboBox.Name = "interpolationModelOne_comboBox";
            this.interpolationModelOne_comboBox.Size = new System.Drawing.Size(428, 21);
            this.interpolationModelOne_comboBox.TabIndex = 0;
            this.interpolationModelOne_comboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationModelsChanged);
            // 
            // overlayResults_tabPage
            // 
            this.overlayResults_tabPage.Controls.Add(this.tableLayoutPanel4);
            this.overlayResults_tabPage.Location = new System.Drawing.Point(4, 25);
            this.overlayResults_tabPage.Name = "overlayResults_tabPage";
            this.overlayResults_tabPage.Size = new System.Drawing.Size(770, 613);
            this.overlayResults_tabPage.TabIndex = 6;
            this.overlayResults_tabPage.Text = "Image interpolation";
            this.overlayResults_tabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.overlayImages_button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.overlayFolders_button, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.imageInterpolationAlphaValue_textBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(770, 613);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // overlayImages_button
            // 
            this.overlayImages_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayImages_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overlayImages_button.Location = new System.Drawing.Point(673, 3);
            this.overlayImages_button.Name = "overlayImages_button";
            this.overlayImages_button.Size = new System.Drawing.Size(94, 382);
            this.overlayImages_button.TabIndex = 1;
            this.overlayImages_button.Text = "Interpolate";
            this.overlayImages_button.UseVisualStyleBackColor = true;
            this.overlayImages_button.Click += new System.EventHandler(this.OverlayImages_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(664, 382);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interpolate two images";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.overlayResultName_textBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(658, 363);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.imageB_panel);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(332, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(323, 329);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Image B";
            // 
            // imageB_panel
            // 
            this.imageB_panel.AllowDrop = true;
            this.imageB_panel.Controls.Add(this.imageB_pictureBox);
            this.imageB_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageB_panel.Location = new System.Drawing.Point(3, 16);
            this.imageB_panel.Name = "imageB_panel";
            this.imageB_panel.Size = new System.Drawing.Size(317, 310);
            this.imageB_panel.TabIndex = 5;
            this.imageB_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagePanel_DragDrop);
            this.imageB_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            // 
            // imageB_pictureBox
            // 
            this.imageB_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageB_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageB_pictureBox.Name = "imageB_pictureBox";
            this.imageB_pictureBox.Size = new System.Drawing.Size(317, 310);
            this.imageB_pictureBox.TabIndex = 0;
            this.imageB_pictureBox.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.imageA_panel);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 329);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Image A";
            // 
            // imageA_panel
            // 
            this.imageA_panel.AllowDrop = true;
            this.imageA_panel.Controls.Add(this.imageA_pictureBox);
            this.imageA_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageA_panel.Location = new System.Drawing.Point(3, 16);
            this.imageA_panel.Name = "imageA_panel";
            this.imageA_panel.Size = new System.Drawing.Size(317, 310);
            this.imageA_panel.TabIndex = 4;
            this.imageA_panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagePanel_DragDrop);
            this.imageA_panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.general_DragEnter);
            // 
            // imageA_pictureBox
            // 
            this.imageA_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageA_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageA_pictureBox.Name = "imageA_pictureBox";
            this.imageA_pictureBox.Size = new System.Drawing.Size(317, 310);
            this.imageA_pictureBox.TabIndex = 0;
            this.imageA_pictureBox.TabStop = false;
            // 
            // overlayResultName_textBox
            // 
            this.overlayResultName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel5.SetColumnSpan(this.overlayResultName_textBox, 2);
            this.overlayResultName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayResultName_textBox.Location = new System.Drawing.Point(3, 338);
            this.overlayResultName_textBox.Name = "overlayResultName_textBox";
            this.overlayResultName_textBox.Size = new System.Drawing.Size(652, 20);
            this.overlayResultName_textBox.TabIndex = 2;
            // 
            // overlayFolders_button
            // 
            this.overlayFolders_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayFolders_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overlayFolders_button.Location = new System.Drawing.Point(673, 441);
            this.overlayFolders_button.Name = "overlayFolders_button";
            this.overlayFolders_button.Size = new System.Drawing.Size(94, 169);
            this.overlayFolders_button.TabIndex = 1;
            this.overlayFolders_button.Text = "Interpolate";
            this.overlayFolders_button.UseVisualStyleBackColor = true;
            this.overlayFolders_button.Click += new System.EventHandler(this.OverlayFolders_button_Click);
            // 
            // imageInterpolationAlphaValue_textBox
            // 
            this.imageInterpolationAlphaValue_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageInterpolationAlphaValue_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInterpolationAlphaValue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.imageInterpolationAlphaValue_textBox.Location = new System.Drawing.Point(673, 400);
            this.imageInterpolationAlphaValue_textBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.imageInterpolationAlphaValue_textBox.Name = "imageInterpolationAlphaValue_textBox";
            this.imageInterpolationAlphaValue_textBox.ReadOnly = true;
            this.imageInterpolationAlphaValue_textBox.Size = new System.Drawing.Size(94, 21);
            this.imageInterpolationAlphaValue_textBox.TabIndex = 2;
            this.imageInterpolationAlphaValue_textBox.Text = "0.5";
            this.imageInterpolationAlphaValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.changeResultsDestinationPath_button);
            this.groupBox5.Controls.Add(this.originalImagesPath_textBox);
            this.groupBox5.Controls.Add(this.changeResultsBPath_button);
            this.groupBox5.Controls.Add(this.resultsAPath_textBox);
            this.groupBox5.Controls.Add(this.changeResultsAPath_button);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.changeOriginalImagesPath_button);
            this.groupBox5.Controls.Add(this.resultsBPath_textBox);
            this.groupBox5.Controls.Add(this.resultsDestinationPath_textBox);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Location = new System.Drawing.Point(3, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 169);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interpolate two folders";
            // 
            // changeResultsDestinationPath_button
            // 
            this.changeResultsDestinationPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsDestinationPath_button.Location = new System.Drawing.Point(616, 126);
            this.changeResultsDestinationPath_button.Name = "changeResultsDestinationPath_button";
            this.changeResultsDestinationPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsDestinationPath_button.TabIndex = 36;
            this.changeResultsDestinationPath_button.Text = "...";
            this.changeResultsDestinationPath_button.UseVisualStyleBackColor = true;
            this.changeResultsDestinationPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // originalImagesPath_textBox
            // 
            this.originalImagesPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImagesPath_textBox.Location = new System.Drawing.Point(57, 34);
            this.originalImagesPath_textBox.Name = "originalImagesPath_textBox";
            this.originalImagesPath_textBox.ReadOnly = true;
            this.originalImagesPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.originalImagesPath_textBox.TabIndex = 30;
            this.toolTip1.SetToolTip(this.originalImagesPath_textBox, "ESRGAN root folder");
            // 
            // changeResultsBPath_button
            // 
            this.changeResultsBPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsBPath_button.Location = new System.Drawing.Point(616, 86);
            this.changeResultsBPath_button.Name = "changeResultsBPath_button";
            this.changeResultsBPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsBPath_button.TabIndex = 36;
            this.changeResultsBPath_button.Text = "...";
            this.changeResultsBPath_button.UseVisualStyleBackColor = true;
            this.changeResultsBPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // resultsAPath_textBox
            // 
            this.resultsAPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsAPath_textBox.Location = new System.Drawing.Point(57, 60);
            this.resultsAPath_textBox.Name = "resultsAPath_textBox";
            this.resultsAPath_textBox.ReadOnly = true;
            this.resultsAPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.resultsAPath_textBox.TabIndex = 31;
            this.toolTip1.SetToolTip(this.resultsAPath_textBox, "IEU output folder");
            // 
            // changeResultsAPath_button
            // 
            this.changeResultsAPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeResultsAPath_button.Location = new System.Drawing.Point(616, 61);
            this.changeResultsAPath_button.Name = "changeResultsAPath_button";
            this.changeResultsAPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeResultsAPath_button.TabIndex = 37;
            this.changeResultsAPath_button.Text = "...";
            this.changeResultsAPath_button.UseVisualStyleBackColor = true;
            this.changeResultsAPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 38);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "Original";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 130);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Result";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "Result A";
            // 
            // changeOriginalImagesPath_button
            // 
            this.changeOriginalImagesPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeOriginalImagesPath_button.Location = new System.Drawing.Point(616, 35);
            this.changeOriginalImagesPath_button.Name = "changeOriginalImagesPath_button";
            this.changeOriginalImagesPath_button.Size = new System.Drawing.Size(39, 20);
            this.changeOriginalImagesPath_button.TabIndex = 38;
            this.changeOriginalImagesPath_button.Text = "...";
            this.changeOriginalImagesPath_button.UseVisualStyleBackColor = true;
            this.changeOriginalImagesPath_button.Click += new System.EventHandler(this.changePath_button_Click);
            // 
            // resultsBPath_textBox
            // 
            this.resultsBPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsBPath_textBox.Location = new System.Drawing.Point(57, 86);
            this.resultsBPath_textBox.Name = "resultsBPath_textBox";
            this.resultsBPath_textBox.ReadOnly = true;
            this.resultsBPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.resultsBPath_textBox.TabIndex = 34;
            this.toolTip1.SetToolTip(this.resultsBPath_textBox, "IEU input folder");
            // 
            // resultsDestinationPath_textBox
            // 
            this.resultsDestinationPath_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsDestinationPath_textBox.Location = new System.Drawing.Point(57, 126);
            this.resultsDestinationPath_textBox.Name = "resultsDestinationPath_textBox";
            this.resultsDestinationPath_textBox.ReadOnly = true;
            this.resultsDestinationPath_textBox.Size = new System.Drawing.Size(553, 20);
            this.resultsDestinationPath_textBox.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "Result B";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imageInterpolation_trackBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 44);
            this.panel3.TabIndex = 6;
            // 
            // imageInterpolation_trackBar
            // 
            this.imageInterpolation_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageInterpolation_trackBar.LargeChange = 10;
            this.imageInterpolation_trackBar.Location = new System.Drawing.Point(0, 0);
            this.imageInterpolation_trackBar.Maximum = 99;
            this.imageInterpolation_trackBar.Minimum = 1;
            this.imageInterpolation_trackBar.Name = "imageInterpolation_trackBar";
            this.imageInterpolation_trackBar.Size = new System.Drawing.Size(664, 44);
            this.imageInterpolation_trackBar.TabIndex = 5;
            this.imageInterpolation_trackBar.Value = 50;
            this.imageInterpolation_trackBar.Scroll += new System.EventHandler(this.ImageInterpolation_trackBar_Scroll);
            // 
            // treeView_contextMenuStrip
            // 
            this.treeView_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModelFolder});
            this.treeView_contextMenuStrip.Name = "treeView_contextMenuStrip";
            this.treeView_contextMenuStrip.Size = new System.Drawing.Size(175, 26);
            // 
            // openModelFolder
            // 
            this.openModelFolder.Name = "openModelFolder";
            this.openModelFolder.Size = new System.Drawing.Size(174, 22);
            this.openModelFolder.Text = "Open model folder";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 642);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(790, 676);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enhancing Utility";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.main_tabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.outputMode_groupBox.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.previewResult_tabPage.ResumeLayout(false);
            this.previewResult_tabPage.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.settings_tabPage.ResumeLayout(false);
            this.settings_tabPage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileHeight_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlapSize_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTileResolution_numericUpDown)).EndInit();
            this.settingsOutputFormat_tabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webpQuality_numericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngCompression_numericUpDown)).EndInit();
            this.tiffSetting_groupBox.ResumeLayout(false);
            this.tiffSetting_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiffJpegQuality_numericUpDown)).EndInit();
            this.ddsOutputSettings_groupBox.ResumeLayout(false);
            this.ddsOutputSettings_groupBox.PerformLayout();
            this.advanced_tabPage.ResumeLayout(false);
            this.advanced_tabPage.PerformLayout();
            this.imagePostprocess_groupBox.ResumeLayout(false);
            this.imagePostprocess_groupBox.PerformLayout();
            this.threshold_groupBox.ResumeLayout(false);
            this.threshold_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBlack_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdWhite_numericUpDown)).EndInit();
            this.imagePreprocess_groupBox.ResumeLayout(false);
            this.imagePreprocess_groupBox.PerformLayout();
            this.upscaleSize_groupBox.ResumeLayout(false);
            this.upscaleSize_groupBox.PerformLayout();
            this.filters_groupBox.ResumeLayout(false);
            this.filters_groupBox.PerformLayout();
            this.filtersSize_groupBox.ResumeLayout(false);
            this.filtersSize_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).EndInit();
            this.filtersFilename_groupBox.ResumeLayout(false);
            this.filtersFilename_groupBox.PerformLayout();
            this.filtersAlpha_groupBox.ResumeLayout(false);
            this.interpolation_tabPage.ResumeLayout(false);
            this.interpolation_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelInterpolationAlpha_trackBar)).EndInit();
            this.overlayResults_tabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.imageB_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageB_pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.imageA_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageA_pictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageInterpolation_trackBar)).EndInit();
            this.treeView_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button upscale_button;
        private System.Windows.Forms.TextBox esrganPath_textBox;
        private System.Windows.Forms.TextBox resultsMergedPath_textBox;
        private System.Windows.Forms.Button crop_button;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main_tabPage;
        private System.Windows.Forms.TabPage settings_tabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imgPath_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxTileResolution_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown overlapSize_numericUpDown;
        private System.Windows.Forms.CheckBox ignoreAlpha_checkBox;
        private System.Windows.Forms.CheckBox debugUpscale_checkBox;
        private System.Windows.Forms.Button changeInputImgPath_button;
        private System.Windows.Forms.Button changeEsrganPath_button;
        private System.Windows.Forms.Button changeMergedResultsPath_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox outputMode_groupBox;
        private System.Windows.Forms.TabPage advanced_tabPage;
        private System.Windows.Forms.Button runAll_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox preserveFormat_checkBox;
        private System.Windows.Forms.Button changeModelsPath_button;
        private System.Windows.Forms.Button changeOutputPath_button;
        private System.Windows.Forms.Button changeInputPath_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modelsPath_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputPath_textBox;
        private System.Windows.Forms.TextBox inputPath_textBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox advancedSuffix_textBox;
        private System.Windows.Forms.CheckBox advancedUseSuffix_checkBox;
        private System.Windows.Forms.GroupBox filters_groupBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox filterSizeOr_checkBox;
        private System.Windows.Forms.NumericUpDown filterSizeHeight_numericUpDown;
        private System.Windows.Forms.NumericUpDown filterSizeWidth_numericUpDown;
        private System.Windows.Forms.TextBox filterFilenameContains_textBox;
        private System.Windows.Forms.CheckBox filterFilenameContains_checkBox;
        private System.Windows.Forms.GroupBox filtersAlpha_groupBox;
        private System.Windows.Forms.CheckBox createMemoryImage_checkBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox filterFilenameNotContains_textBox;
        private System.Windows.Forms.CheckBox filterFilenameNotContains_checkBox;
        private System.Windows.Forms.GroupBox filtersSize_groupBox;
        private System.Windows.Forms.GroupBox filtersFilename_groupBox;
        private System.Windows.Forms.CheckBox filtersSizeOn_checkBox;
        private System.Windows.Forms.CheckBox filterFilenameCaseSensitive_checkBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label progressFiltered_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxTileHeight_numericUpDown;
        private System.Windows.Forms.NumericUpDown maxTileWidth_numericUpDown;
        private System.Windows.Forms.GroupBox upscaleSize_groupBox;
        private System.Windows.Forms.RadioButton x1_radioButton;
        private System.Windows.Forms.RadioButton x2_radioButton;
        private System.Windows.Forms.RadioButton x4_radioButton;
        private System.Windows.Forms.CheckBox deleteResults_checkBox;
        private System.Windows.Forms.CheckBox checkForUpdates_checkBox;
        private System.Windows.Forms.GroupBox imagePostprocess_groupBox;
        private System.Windows.Forms.GroupBox threshold_groupBox;
        private System.Windows.Forms.NumericUpDown thresholdBlack_numericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox thresholdEnabled_checkBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown thresholdWhite_numericUpDown;
        private System.Windows.Forms.GroupBox imagePreprocess_groupBox;
        private System.Windows.Forms.ComboBox noiseReductionType_comboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox ddsOutputSettings_groupBox;
        private System.Windows.Forms.ComboBox ddsFileFormat_comboBox;
        private System.Windows.Forms.ComboBox ddsTextureType_comboBox;
        private System.Windows.Forms.ComboBox ddsCompresion_comboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ddsGenerateMipmaps_checkBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown pngCompression_numericUpDown;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox outputDestinationMode_comboBox;
        private System.Windows.Forms.ComboBox overwriteMode_comboBox;
        private System.Windows.Forms.ComboBox filterAlpha_comboBox;
        private System.Windows.Forms.CheckedListBox filterExtensions_checkedListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel appCoreVersion_linkLabel;
        private System.Windows.Forms.LinkLabel appVersion_label;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox resizeImageBeforeFilterType_comboBox;
        private System.Windows.Forms.ComboBox resizeImageBeforeScaleFactor_comboBox;
        private System.Windows.Forms.CheckBox splitRGB_checkBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox resizeImageAfterFilterType_comboBox;
        private System.Windows.Forms.ComboBox resizeImageAfterScaleFactor_comboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage interpolation_tabPage;
        private System.Windows.Forms.Button interpolationStart_button;
        private System.Windows.Forms.TextBox modelInterpolationAlphaValue_textBox;
        private System.Windows.Forms.ComboBox interpolationModelTwo_comboBox;
        private System.Windows.Forms.ComboBox interpolationModelOne_comboBox;
        private System.Windows.Forms.TextBox interpolationOutputModelName_textBox;
        private System.Windows.Forms.ComboBox modelForAlpha_comboBox;
        private System.Windows.Forms.CheckBox useDifferentModelForAlpha_checkBox;
        private System.Windows.Forms.ComboBox outputFormat_comboBox;
        private System.Windows.Forms.TabPage settingsOutputFormat_tabPage;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ContextMenuStrip treeView_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openModelFolder;
        private System.Windows.Forms.CheckBox seamlessTextures_checkBox;
        private System.Windows.Forms.CheckBox useCPU_checkBox;
        private System.Windows.Forms.CheckBox ignoreSingleColorAlpha_checkBox;
        private System.Windows.Forms.CheckBox balanceAlphas_checkBox;
        private System.Windows.Forms.GroupBox tiffSetting_groupBox;
        private System.Windows.Forms.ComboBox tiffSettings_comboBox;
        private System.Windows.Forms.NumericUpDown tiffJpegQuality_numericUpDown;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox webpLossless_checkBox;
        private System.Windows.Forms.NumericUpDown webpQuality_numericUpDown;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox webpPreset_comboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox preciseTile_checkBox;
        private System.Windows.Forms.TabPage previewResult_tabPage;
        private Cyotek.Windows.Forms.ImageBox zoomImageBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openFromFileToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox zoomLevelsToolStripComboBox;
        private Cyotek.Windows.Forms.ImageBox previewImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox previewModels_comboBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button previewUpdate_button;
        private System.Windows.Forms.Button previewSave_button;
        private System.Windows.Forms.ProgressBar preview_progressBar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Cyotek.Windows.Forms.ImageBox miniMapImageBox;
        private System.Windows.Forms.Label imageSizeToolStripStatusLabel;
        private System.Windows.Forms.CheckBox useBasicSR_checkBox;
        private System.Windows.Forms.TabPage overlayResults_tabPage;
        private System.Windows.Forms.TextBox imageInterpolationAlphaValue_textBox;
        private System.Windows.Forms.Button overlayFolders_button;
        private System.Windows.Forms.Button overlayImages_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button changeResultsDestinationPath_button;
        private System.Windows.Forms.TextBox originalImagesPath_textBox;
        private System.Windows.Forms.Button changeResultsBPath_button;
        private System.Windows.Forms.TextBox resultsAPath_textBox;
        private System.Windows.Forms.Button changeResultsAPath_button;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button changeOriginalImagesPath_button;
        private System.Windows.Forms.TextBox resultsBPath_textBox;
        private System.Windows.Forms.TextBox resultsDestinationPath_textBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel imageB_panel;
        private System.Windows.Forms.PictureBox imageB_pictureBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel imageA_panel;
        private System.Windows.Forms.PictureBox imageA_pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox overlayResultName_textBox;
        private System.Windows.Forms.TrackBar modelInterpolationAlpha_trackBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar imageInterpolation_trackBar;
    }
}

