namespace DNPopup
{
    partial class BaseForm
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
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainNotifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitCommandMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainNotifyIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.mainNotifyIconMenuStrip;
            this.mainNotifyIcon.Visible = true;
            // 
            // mainNotifyIconMenuStrip
            // 
            this.mainNotifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitCommandMenu});
            this.mainNotifyIconMenuStrip.Name = "mainNotifyIconMenuStrip";
            this.mainNotifyIconMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // exitCommandMenu
            // 
            this.exitCommandMenu.Name = "exitCommandMenu";
            this.exitCommandMenu.Size = new System.Drawing.Size(180, 22);
            this.exitCommandMenu.Text = "Exit(&X)";
            this.exitCommandMenu.Click += new System.EventHandler(this.exitCommandMenu_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BaseForm";
            this.mainNotifyIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip mainNotifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitCommandMenu;
    }
}