
namespace WinGet_GUI
{
    partial class WinGetGui
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.AppName = new System.Windows.Forms.ColumnHeader();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Version = new System.Windows.Forms.ColumnHeader();
            this.Available = new System.Windows.Forms.ColumnHeader();
            this.Source = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AppName,
            this.Id,
            this.Version,
            this.Available,
            this.Source});
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 386);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AppName
            // 
            this.AppName.Text = "Name";
            // 
            // Id
            // 
            this.Id.DisplayIndex = 0;
            this.Id.Text = "Id";
            // 
            // Version
            // 
            this.Version.DisplayIndex = 1;
            this.Version.Text = "Version";
            // 
            // Available
            // 
            this.Available.DisplayIndex = 2;
            this.Available.Text = "Available";
            // 
            // Source
            // 
            this.Source.DisplayIndex = 3;
            this.Source.Text = "Source";
            // 
            // WinGetGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.listView1);
            this.Name = "WinGetGui";
            this.Text = "WinGet GUI";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader AppName;
    }
}

