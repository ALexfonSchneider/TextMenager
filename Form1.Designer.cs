
namespace TextMenager
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
            this.components = new System.ComponentModel.Container();
            this.LstContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_deleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveRecordAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_selectDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerForList = new System.Windows.Forms.Timer(this.components);
            this.TimerForMenu = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstRecord = new System.Windows.Forms.ListBox();
            this.RC_box = new System.Windows.Forms.RichTextBox();
            this.LstContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstContextMenuStrip
            // 
            this.LstContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LstContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.inputToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.LstContextMenuStrip.Name = "contextMenuStrip1";
            this.LstContextMenuStrip.Size = new System.Drawing.Size(211, 104);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.inputToolStripMenuItem.Text = "Вставить";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_deleteRecord,
            this.menu_saveRecord,
            this.menu_saveRecordAs,
            this.menu_new_file});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menu_deleteRecord
            // 
            this.menu_deleteRecord.Name = "menu_deleteRecord";
            this.menu_deleteRecord.Size = new System.Drawing.Size(224, 26);
            this.menu_deleteRecord.Text = "Удалить";
            this.menu_deleteRecord.Click += new System.EventHandler(this.menu_deleteRecord_Click);
            // 
            // menu_saveRecord
            // 
            this.menu_saveRecord.Name = "menu_saveRecord";
            this.menu_saveRecord.Size = new System.Drawing.Size(224, 26);
            this.menu_saveRecord.Text = "Сохранить";
            this.menu_saveRecord.Click += new System.EventHandler(this.menu_saveRecord_Click);
            // 
            // menu_saveRecordAs
            // 
            this.menu_saveRecordAs.Name = "menu_saveRecordAs";
            this.menu_saveRecordAs.Size = new System.Drawing.Size(224, 26);
            this.menu_saveRecordAs.Text = "Сохранить как";
            this.menu_saveRecordAs.Click += new System.EventHandler(this.menu_saveRecordAs_Click);
            // 
            // menu_new_file
            // 
            this.menu_new_file.Name = "menu_new_file";
            this.menu_new_file.Size = new System.Drawing.Size(224, 26);
            this.menu_new_file.Text = "Новый файл";
            this.menu_new_file.Click += new System.EventHandler(this.menu_new_file_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_selectDirectory});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.toolStripMenuItem1.Text = "Настройки";
            // 
            // menu_selectDirectory
            // 
            this.menu_selectDirectory.Name = "menu_selectDirectory";
            this.menu_selectDirectory.Size = new System.Drawing.Size(137, 26);
            this.menu_selectDirectory.Text = "Обзор";
            this.menu_selectDirectory.Click += new System.EventHandler(this.menu_selectDirectory_Click);
            // 
            // TimerForList
            // 
            this.TimerForList.Enabled = true;
            this.TimerForList.Interval = 1500;
            this.TimerForList.Tick += new System.EventHandler(this.TimerForList_Tick);
            // 
            // TimerForMenu
            // 
            this.TimerForMenu.Enabled = true;
            this.TimerForMenu.Interval = 10;
            this.TimerForMenu.Tick += new System.EventHandler(this.TimerForMenu_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(633, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 422);
            this.panel2.TabIndex = 7;
            // 
            // lstRecord
            // 
            this.lstRecord.ContextMenuStrip = this.LstContextMenuStrip;
            this.lstRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecord.FormattingEnabled = true;
            this.lstRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstRecord.ItemHeight = 20;
            this.lstRecord.Location = new System.Drawing.Point(0, 0);
            this.lstRecord.Name = "lstRecord";
            this.lstRecord.Size = new System.Drawing.Size(167, 422);
            this.lstRecord.TabIndex = 1;
            this.lstRecord.SelectedIndexChanged += new System.EventHandler(this.lstRecord_SelectedIndexChanged);
            this.lstRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstRecord_MouseDown);
            // 
            // RC_box
            // 
            this.RC_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RC_box.Location = new System.Drawing.Point(0, 28);
            this.RC_box.Name = "RC_box";
            this.RC_box.Size = new System.Drawing.Size(800, 422);
            this.RC_box.TabIndex = 6;
            this.RC_box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RC_box);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LstContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_deleteRecord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_selectDirectory;
        private System.Windows.Forms.ToolStripMenuItem menu_saveRecord;
        private System.Windows.Forms.Timer TimerForList;
        private System.Windows.Forms.Timer TimerForMenu;
        private System.Windows.Forms.ToolStripMenuItem menu_new_file;
        private System.Windows.Forms.ToolStripMenuItem menu_saveRecordAs;
        private System.Windows.Forms.ContextMenuStrip LstContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstRecord;
        private System.Windows.Forms.RichTextBox RC_box;
    }
}

