﻿namespace wwdt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treyWorker = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьЖурнал = new System.Windows.Forms.ToolStripMenuItem();
            this.НачатьРаботу = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьпауза = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЗапись = new System.Windows.Forms.ToolStripMenuItem();
            this.выход = new System.Windows.Forms.ToolStripMenuItem();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treyWorker
            // 
            this.treyWorker.ContextMenuStrip = this.contextMenuStrip1;
            this.treyWorker.Icon = ((System.Drawing.Icon)(resources.GetObject("treyWorker.Icon")));
            this.treyWorker.Text = "Запись работы проекта";
            this.treyWorker.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьЖурнал,
            this.НачатьРаботу,
            this.остановитьпауза,
            this.сохранитьЗапись,
            this.выход});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 114);
            // 
            // открытьЖурнал
            // 
            this.открытьЖурнал.Image = global::wwdt.Properties.Resources.metrpic;
            this.открытьЖурнал.Name = "открытьЖурнал";
            this.открытьЖурнал.Size = new System.Drawing.Size(173, 22);
            this.открытьЖурнал.Text = "Открыть журнал";
            this.открытьЖурнал.Click += new System.EventHandler(this.открытьЖурналToolStripMenuItem_Click);
            // 
            // НачатьРаботу
            // 
            this.НачатьРаботу.Image = global::wwdt.Properties.Resources.start;
            this.НачатьРаботу.Name = "НачатьРаботу";
            this.НачатьРаботу.Size = new System.Drawing.Size(173, 22);
            this.НачатьРаботу.Text = "Начать работу";
            this.НачатьРаботу.Click += new System.EventHandler(this.Начать_работу);
            // 
            // остановитьпауза
            // 
            this.остановитьпауза.Image = global::wwdt.Properties.Resources.green_pause;
            this.остановитьпауза.Name = "остановитьпауза";
            this.остановитьпауза.Size = new System.Drawing.Size(173, 22);
            this.остановитьпауза.Text = "Остановить/пауза";
            this.остановитьпауза.Click += new System.EventHandler(this.остановитьпаузаToolStripMenuItem_Click);
            // 
            // сохранитьЗапись
            // 
            this.сохранитьЗапись.Image = global::wwdt.Properties.Resources.notepad;
            this.сохранитьЗапись.Name = "сохранитьЗапись";
            this.сохранитьЗапись.Size = new System.Drawing.Size(173, 22);
            this.сохранитьЗапись.Text = "Сохранить запись";
            this.сохранитьЗапись.Click += new System.EventHandler(this.сохранитьЗаписьToolStripMenuItem1_Click);
            // 
            // выход
            // 
            this.выход.Image = global::wwdt.Properties.Resources.cerrar;
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(173, 22);
            this.выход.Text = "Выход";
            this.выход.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTile1.Location = new System.Drawing.Point(302, 207);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(38, 61);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 56;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroTile1, "SaveChanges");
            this.metroTile1.UseSelectable = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggle1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(268, 0);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 19);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroToggle1.TabIndex = 55;
            this.metroToggle1.Text = "On";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.metroToggle1, "Свернуть в трей");
            this.metroToggle1.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroToggle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 19);
            this.panel1.TabIndex = 32;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTime.Enabled = false;
            this.labelTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(116, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 19);
            this.labelTime.TabIndex = 54;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Время работы:";
            // 
            // textNotes
            // 
            this.textNotes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNotes.Dock = System.Windows.Forms.DockStyle.Left;
            this.textNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNotes.Location = new System.Drawing.Point(0, 0);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(327, 61);
            this.textNotes.TabIndex = 48;
            this.textNotes.Text = "Описание действий";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(348, 310);
            this.metroTabControl1.TabIndex = 33;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(340, 268);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Журнал";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.dataGridView2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(340, 268);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Расходник";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 207);
            this.dataGridView1.TabIndex = 36;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(340, 268);
            this.dataGridView2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textNotes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 61);
            this.panel2.TabIndex = 37;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButton1.Location = new System.Drawing.Point(0, 236);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(340, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Save record";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroButton1, "Сохранить запись");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 329);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon treyWorker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьЖурнал;
        private System.Windows.Forms.ToolStripMenuItem НачатьРаботу;
        private System.Windows.Forms.ToolStripMenuItem остановитьпауза;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЗапись;
        private System.Windows.Forms.ToolStripMenuItem выход;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNotes;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

