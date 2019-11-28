namespace TestRada1
{
    partial class Form2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phuongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.xStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buocNhay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtRandom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cl_mayBay = new DevExpress.XtraEditors.ColorEdit();
            this.cl_xe = new DevExpress.XtraEditors.ColorEdit();
            this.cl_Thuyen = new DevExpress.XtraEditors.ColorEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_mayBay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_xe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_Thuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 202);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem});
            this.gridControl1.Size = new System.Drawing.Size(1052, 251);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.phuongTien,
            this.xStart,
            this.yStart,
            this.xEnd,
            this.yEnd,
            this.buocNhay,
            this.time});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // phuongTien
            // 
            this.phuongTien.Caption = "Phương Tiện";
            this.phuongTien.ColumnEdit = this.repositoryItem;
            this.phuongTien.FieldName = "phuongTien";
            this.phuongTien.Name = "phuongTien";
            this.phuongTien.Visible = true;
            this.phuongTien.VisibleIndex = 0;
            // 
            // repositoryItem
            // 
            this.repositoryItem.AutoHeight = false;
            this.repositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItem.Items.AddRange(new object[] {
            "Máy Bay",
            "Thuyền",
            "Xe"});
            this.repositoryItem.Name = "repositoryItem";
            // 
            // xStart
            // 
            this.xStart.Caption = "X Bắt Đầu";
            this.xStart.FieldName = "xStart";
            this.xStart.Name = "xStart";
            this.xStart.Visible = true;
            this.xStart.VisibleIndex = 1;
            // 
            // yStart
            // 
            this.yStart.Caption = "Y Bắt Đầu";
            this.yStart.FieldName = "yStart";
            this.yStart.Name = "yStart";
            this.yStart.Visible = true;
            this.yStart.VisibleIndex = 2;
            // 
            // xEnd
            // 
            this.xEnd.Caption = "X Kết Thúc";
            this.xEnd.FieldName = "xEnd";
            this.xEnd.Name = "xEnd";
            this.xEnd.Visible = true;
            this.xEnd.VisibleIndex = 3;
            // 
            // yEnd
            // 
            this.yEnd.Caption = "Y Kết Thúc";
            this.yEnd.FieldName = "yEnd";
            this.yEnd.Name = "yEnd";
            this.yEnd.Visible = true;
            this.yEnd.VisibleIndex = 4;
            // 
            // buocNhay
            // 
            this.buocNhay.Caption = "Bước Nhảy";
            this.buocNhay.FieldName = "buocNhay";
            this.buocNhay.Name = "buocNhay";
            this.buocNhay.Visible = true;
            this.buocNhay.VisibleIndex = 5;
            // 
            // time
            // 
            this.time.Caption = "Thời Gian Bắt Đầu (s)";
            this.time.FieldName = "time";
            this.time.Name = "time";
            this.time.Visible = true;
            this.time.VisibleIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(440, 160);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Run";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(362, 12);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(108, 20);
            this.txtRandom.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(239, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Số Lượng phương Tiện";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(498, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(664, 9);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Clear";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Máy Bay";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(87, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Xe";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(84, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Thuyền";
            // 
            // cl_mayBay
            // 
            this.cl_mayBay.EditValue = System.Drawing.Color.Empty;
            this.cl_mayBay.Location = new System.Drawing.Point(140, 60);
            this.cl_mayBay.Name = "cl_mayBay";
            this.cl_mayBay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_mayBay.Size = new System.Drawing.Size(189, 20);
            this.cl_mayBay.TabIndex = 9;
            // 
            // cl_xe
            // 
            this.cl_xe.EditValue = System.Drawing.Color.Empty;
            this.cl_xe.Location = new System.Drawing.Point(140, 91);
            this.cl_xe.Name = "cl_xe";
            this.cl_xe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_xe.Size = new System.Drawing.Size(189, 20);
            this.cl_xe.TabIndex = 10;
            // 
            // cl_Thuyen
            // 
            this.cl_Thuyen.EditValue = System.Drawing.Color.Empty;
            this.cl_Thuyen.Location = new System.Drawing.Point(140, 117);
            this.cl_Thuyen.Name = "cl_Thuyen";
            this.cl_Thuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_Thuyen.Size = new System.Drawing.Size(189, 20);
            this.cl_Thuyen.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 453);
            this.Controls.Add(this.cl_Thuyen);
            this.Controls.Add(this.cl_xe);
            this.Controls.Add(this.cl_mayBay);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtRandom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_mayBay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_xe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_Thuyen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn phuongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItem;
        private DevExpress.XtraGrid.Columns.GridColumn xStart;
        private DevExpress.XtraGrid.Columns.GridColumn yStart;
        private DevExpress.XtraGrid.Columns.GridColumn xEnd;
        private DevExpress.XtraGrid.Columns.GridColumn yEnd;
        private DevExpress.XtraGrid.Columns.GridColumn buocNhay;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn time;
        private DevExpress.XtraEditors.TextEdit txtRandom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ColorEdit cl_mayBay;
        private DevExpress.XtraEditors.ColorEdit cl_xe;
        private DevExpress.XtraEditors.ColorEdit cl_Thuyen;
    }
}