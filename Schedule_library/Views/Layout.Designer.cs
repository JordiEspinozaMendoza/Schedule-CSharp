
namespace Schedule_library.Views
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.buttonAdd = new FontAwesome.Sharp.IconButton();
            this.buttonRegister = new FontAwesome.Sharp.IconButton();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 54);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(12, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 37);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.buttonAdd.IconColor = System.Drawing.Color.White;
            this.buttonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAdd.IconSize = 24;
            this.buttonAdd.Location = new System.Drawing.Point(50, 11);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(32, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonRegister.IconColor = System.Drawing.Color.White;
            this.buttonRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRegister.IconSize = 24;
            this.buttonRegister.Location = new System.Drawing.Point(355, 11);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(32, 37);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(0, 54);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(399, 484);
            this.panelChild.TabIndex = 1;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 538);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonAdd;
        private FontAwesome.Sharp.IconButton buttonRegister;
        private System.Windows.Forms.Panel panelChild;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}