namespace MetroUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtRefresh
            // 
            this.mtRefresh.Location = new System.Drawing.Point(37, 55);
            this.mtRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.Size = new System.Drawing.Size(91, 64);
            this.mtRefresh.TabIndex = 0;
            this.mtRefresh.Text = "Refresh";
            this.mtRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRefresh.TileImage")));
            this.mtRefresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRefresh.UseTileImage = true;
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(148, 55);
            this.mtAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(91, 64);
            this.mtAdd.TabIndex = 1;
            this.mtAdd.Text = "Add";
            this.mtAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAdd.TileImage")));
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(258, 55);
            this.mtEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(91, 64);
            this.mtEdit.TabIndex = 1;
            this.mtEdit.Text = "Edit";
            this.mtEdit.TileImage = global::MetroUI.Properties.Resources.icon_wand;
            this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEdit.UseTileImage = true;
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(368, 55);
            this.mtDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(91, 64);
            this.mtDelete.TabIndex = 1;
            this.mtDelete.Text = "Delete";
            this.mtDelete.TileImage = global::MetroUI.Properties.Resources.action_stop;
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.UseTileImage = true;
            // 
            // mtSave
            // 
            this.mtSave.BackColor = System.Drawing.Color.DarkOrange;
            this.mtSave.CustomBackground = true;
            this.mtSave.Location = new System.Drawing.Point(477, 55);
            this.mtSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(91, 64);
            this.mtSave.TabIndex = 1;
            this.mtSave.Text = "Save";
            this.mtSave.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSave.TileImage")));
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.UseTileImage = true;
            this.mtSave.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(887, 442);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.mtRefresh);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 36, 14, 12);
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private DataGridView dataGridView1;
    }
}