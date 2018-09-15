namespace MS_Paint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйРисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.рисованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карандашToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кистьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ластикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слоиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСлойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСлойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.LayersControl = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.changeColor = new System.Windows.Forms.ColorDialog();
            this.shangeColor = new System.Windows.Forms.ColorDialog();
            this.color1 = new System.Windows.Forms.Panel();
            this.color2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.рисованиеToolStripMenuItem,
            this.слоиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйРисунокToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "ФАЙЛ";
            // 
            // новыйРисунокToolStripMenuItem
            // 
            this.новыйРисунокToolStripMenuItem.Name = "новыйРисунокToolStripMenuItem";
            this.новыйРисунокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйРисунокToolStripMenuItem.Text = "Новый Рисунок";
            this.новыйРисунокToolStripMenuItem.Click += new System.EventHandler(this.новыйРисунокToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Открыть";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // рисованиеToolStripMenuItem
            // 
            this.рисованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.карандашToolStripMenuItem,
            this.кистьToolStripMenuItem,
            this.ластикToolStripMenuItem});
            this.рисованиеToolStripMenuItem.Name = "рисованиеToolStripMenuItem";
            this.рисованиеToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.рисованиеToolStripMenuItem.Text = "Рисование";
            // 
            // карандашToolStripMenuItem
            // 
            this.карандашToolStripMenuItem.Name = "карандашToolStripMenuItem";
            this.карандашToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.карандашToolStripMenuItem.Text = "Карандаш";
            this.карандашToolStripMenuItem.Click += new System.EventHandler(this.карандашToolStripMenuItem_Click);
            // 
            // кистьToolStripMenuItem
            // 
            this.кистьToolStripMenuItem.Name = "кистьToolStripMenuItem";
            this.кистьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.кистьToolStripMenuItem.Text = "Кисть";
            this.кистьToolStripMenuItem.Click += new System.EventHandler(this.кистьToolStripMenuItem_Click);
            // 
            // ластикToolStripMenuItem
            // 
            this.ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            this.ластикToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ластикToolStripMenuItem.Text = "Ластик";
            this.ластикToolStripMenuItem.Click += new System.EventHandler(this.ластикToolStripMenuItem_Click);
            // 
            // слоиToolStripMenuItem
            // 
            this.слоиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСлойToolStripMenuItem,
            this.удалитьСлойToolStripMenuItem});
            this.слоиToolStripMenuItem.Name = "слоиToolStripMenuItem";
            this.слоиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.слоиToolStripMenuItem.Text = "Слои";
            // 
            // добавитьСлойToolStripMenuItem
            // 
            this.добавитьСлойToolStripMenuItem.Name = "добавитьСлойToolStripMenuItem";
            this.добавитьСлойToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.добавитьСлойToolStripMenuItem.Text = "Добавить слой";
            // 
            // удалитьСлойToolStripMenuItem
            // 
            this.удалитьСлойToolStripMenuItem.Name = "удалитьСлойToolStripMenuItem";
            this.удалитьСлойToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.удалитьСлойToolStripMenuItem.Text = "Удалить слой";
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(0, 52);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(662, 386);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 2;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // LayersControl
            // 
            this.LayersControl.FormattingEnabled = true;
            this.LayersControl.Location = new System.Drawing.Point(668, 52);
            this.LayersControl.Name = "LayersControl";
            this.LayersControl.Size = new System.Drawing.Size(120, 274);
            this.LayersControl.TabIndex = 3;
            this.LayersControl.SelectedValueChanged += new System.EventHandler(this.LayersControl_SelectedValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Ластик";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color1.Location = new System.Drawing.Point(668, 332);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(49, 43);
            this.color1.TabIndex = 5;
            this.color1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color1_MouseClick_1);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Red;
            this.color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color2.Location = new System.Drawing.Point(723, 332);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(49, 43);
            this.color2.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(688, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Поменять";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LayersControl);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новыйРисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem рисованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карандашToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кистьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ластикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слоиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСлойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСлойToolStripMenuItem;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.CheckedListBox LayersControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.ColorDialog changeColor;
        private System.Windows.Forms.ColorDialog shangeColor;
        private System.Windows.Forms.Panel color1;
        private System.Windows.Forms.Panel color2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

