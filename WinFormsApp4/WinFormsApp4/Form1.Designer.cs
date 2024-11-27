namespace WinFormsApp4
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toplamaToolStripMenuItem = new ToolStripMenuItem();
            çıkarmaToolStripMenuItem = new ToolStripMenuItem();
            çarpmaToolStripMenuItem = new ToolStripMenuItem();
            bölmeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toplamaToolStripMenuItem1 = new ToolStripMenuItem();
            çıkartmaToolStripMenuItem = new ToolStripMenuItem();
            çarpmaToolStripMenuItem1 = new ToolStripMenuItem();
            bölmeToolStripMenuItem1 = new ToolStripMenuItem();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toplamaToolStripMenuItem, çıkarmaToolStripMenuItem, çarpmaToolStripMenuItem, bölmeToolStripMenuItem });
            contextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(120, 114);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(119, 22);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toplamaToolStripMenuItem
            // 
            toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            toplamaToolStripMenuItem.Size = new Size(119, 22);
            toplamaToolStripMenuItem.Text = "Toplama";
            // 
            // çıkarmaToolStripMenuItem
            // 
            çıkarmaToolStripMenuItem.Name = "çıkarmaToolStripMenuItem";
            çıkarmaToolStripMenuItem.Size = new Size(119, 22);
            çıkarmaToolStripMenuItem.Text = "Çıkarma";
            // 
            // çarpmaToolStripMenuItem
            // 
            çarpmaToolStripMenuItem.Name = "çarpmaToolStripMenuItem";
            çarpmaToolStripMenuItem.Size = new Size(119, 22);
            çarpmaToolStripMenuItem.Text = "Çarpma";
            // 
            // bölmeToolStripMenuItem
            // 
            bölmeToolStripMenuItem.Name = "bölmeToolStripMenuItem";
            bölmeToolStripMenuItem.Size = new Size(119, 22);
            bölmeToolStripMenuItem.Text = "Bölme";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toplamaToolStripMenuItem1, çıkartmaToolStripMenuItem, çarpmaToolStripMenuItem1, bölmeToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toplamaToolStripMenuItem1
            // 
            toplamaToolStripMenuItem1.Name = "toplamaToolStripMenuItem1";
            toplamaToolStripMenuItem1.Size = new Size(64, 20);
            toplamaToolStripMenuItem1.Text = "Toplama";
            toplamaToolStripMenuItem1.Click += toplamaToolStripMenuItem1_Click;
            // 
            // çıkartmaToolStripMenuItem
            // 
            çıkartmaToolStripMenuItem.Name = "çıkartmaToolStripMenuItem";
            çıkartmaToolStripMenuItem.Size = new Size(67, 20);
            çıkartmaToolStripMenuItem.Text = "Çıkartma";
            çıkartmaToolStripMenuItem.Click += çıkartmaToolStripMenuItem_Click;
            // 
            // çarpmaToolStripMenuItem1
            // 
            çarpmaToolStripMenuItem1.Name = "çarpmaToolStripMenuItem1";
            çarpmaToolStripMenuItem1.Size = new Size(61, 20);
            çarpmaToolStripMenuItem1.Text = "Çarpma";
            çarpmaToolStripMenuItem1.Click += çarpmaToolStripMenuItem1_Click;
            // 
            // bölmeToolStripMenuItem1
            // 
            bölmeToolStripMenuItem1.Name = "bölmeToolStripMenuItem1";
            bölmeToolStripMenuItem1.Size = new Size(53, 20);
            bölmeToolStripMenuItem1.Text = "Bölme";
            bölmeToolStripMenuItem1.Click += bölmeToolStripMenuItem1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(271, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 255);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "sonuç:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toplamaToolStripMenuItem;
        private ToolStripMenuItem çıkarmaToolStripMenuItem;
        private ToolStripMenuItem çarpmaToolStripMenuItem;
        private ToolStripMenuItem bölmeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toplamaToolStripMenuItem1;
        private ToolStripMenuItem çıkartmaToolStripMenuItem;
        private ToolStripMenuItem çarpmaToolStripMenuItem1;
        private ToolStripMenuItem bölmeToolStripMenuItem1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}
