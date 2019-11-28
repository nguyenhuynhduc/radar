namespace TestRada1
{
    partial class frm_map
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
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.bingMapDataProvider2 = new DevExpress.XtraMap.BingMapDataProvider();
            this.miniMapImageTilesLayer1 = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            this.bingMapDataProvider2.BingKey = "YOUR BING MAPS KEY";
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(838, 590);
            this.mapControl1.TabIndex = 0;
            // 
            // frm_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 590);
            this.Controls.Add(this.mapControl1);
            this.Name = "frm_map";
            this.Text = "frm_map";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MiniMapImageTilesLayer miniMapImageTilesLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider2;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private DevExpress.XtraMap.MapControl mapControl1;
    }
}