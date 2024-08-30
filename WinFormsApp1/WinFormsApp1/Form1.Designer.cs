namespace WinFormsApp1
{
    partial class App
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
            menuStrip1 = new MenuStrip();
            приложениеToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            str1 = new TextBox();
            str2 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            textBox1 = new TextBox();
            Shell = new Button();
            Sliyanie = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { приложениеToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // приложениеToolStripMenuItem
            // 
            приложениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститьToolStripMenuItem, выходToolStripMenuItem });
            приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            приложениеToolStripMenuItem.Size = new Size(91, 20);
            приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(180, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(180, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // str1
            // 
            str1.Location = new Point(92, 22);
            str1.Name = "str1";
            str1.Size = new Size(100, 23);
            str1.TabIndex = 1;
            // 
            // str2
            // 
            str2.Location = new Point(92, 70);
            str2.Name = "str2";
            str2.Size = new Size(100, 23);
            str2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(65, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(111, 28);
            label1.Name = "label1";
            label1.Size = new Size(448, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите два одномерных массива для сортировки слиянием ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(159, 49);
            label2.Name = "label2";
            label2.Size = new Size(281, 21);
            label2.TabIndex = 1;
            label2.Text = "и один массив для сортировки Шелла";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(str1);
            groupBox2.Controls.Add(str2);
            groupBox2.Location = new Point(65, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 117);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Массивы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 25);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Массив 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 73);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Массив 2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(407, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 162);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Массивы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 25);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 3;
            label6.Text = "Результат сортировки";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(28, 43);
            textBox1.MaximumSize = new Size(160, 100);
            textBox1.MinimumSize = new Size(160, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 100);
            textBox1.TabIndex = 4;
            // 
            // Shell
            // 
            Shell.Location = new Point(45, 362);
            Shell.Name = "Shell";
            Shell.Size = new Size(106, 29);
            Shell.TabIndex = 6;
            Shell.Text = "Сорт Шелла";
            Shell.UseVisualStyleBackColor = true;
            // 
            // Sliyanie
            // 
            Sliyanie.Location = new Point(176, 362);
            Sliyanie.Name = "Sliyanie";
            Sliyanie.Size = new Size(106, 29);
            Sliyanie.TabIndex = 7;
            Sliyanie.Text = "Сорт Слиянием";
            Sliyanie.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sliyanie);
            Controls.Add(Shell);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "App";
            Text = "Приложение";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem приложениеToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private TextBox str1;
        private TextBox str2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label6;
        private Button Shell;
        private Button Sliyanie;
    }
}
