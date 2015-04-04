namespace _PwSG__Lab3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.najlepszeWynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszGręToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajGręToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.najlepszeWynikiToolStripMenuItem,
            this.zapiszGręToolStripMenuItem,
            this.wczytajGręToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 435);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // najlepszeWynikiToolStripMenuItem
            // 
            this.najlepszeWynikiToolStripMenuItem.Name = "najlepszeWynikiToolStripMenuItem";
            this.najlepszeWynikiToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.najlepszeWynikiToolStripMenuItem.Text = "Najlepsze wyniki";
            this.najlepszeWynikiToolStripMenuItem.Click += new System.EventHandler(this.najlepszeWynikiToolStripMenuItem_Click);
            // 
            // zapiszGręToolStripMenuItem
            // 
            this.zapiszGręToolStripMenuItem.Name = "zapiszGręToolStripMenuItem";
            this.zapiszGręToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.zapiszGręToolStripMenuItem.Text = "Zapisz grę";
            this.zapiszGręToolStripMenuItem.Click += new System.EventHandler(this.zapiszGręToolStripMenuItem_Click);
            // 
            // wczytajGręToolStripMenuItem
            // 
            this.wczytajGręToolStripMenuItem.Name = "wczytajGręToolStripMenuItem";
            this.wczytajGręToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.wczytajGręToolStripMenuItem.Text = "Wczytaj grę";
            this.wczytajGręToolStripMenuItem.Click += new System.EventHandler(this.wczytajGręToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Saper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem najlepszeWynikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszGręToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajGręToolStripMenuItem;
    }
}

