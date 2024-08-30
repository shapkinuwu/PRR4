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
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            result = new TextBox();
            label6 = new Label();
            btn_Shell = new Button();
            btn_Sliyanie = new Button();
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
            menuStrip1.Size = new Size(770, 24);
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
            очиститьToolStripMenuItem.Size = new Size(126, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(126, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
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
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
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
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 43);
            groupBox1.Name = "Task";
            groupBox1.Size = new Size(667, 104);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(159, 49);
            label2.Name = "Task2";
            label2.Size = new Size(281, 21);
            label2.TabIndex = 1;
            label2.Text = "и один массив для сортировки Шелла";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(111, 28);
            label1.Name = "Task1";
            label1.Size = new Size(448, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите два одномерных массива для сортировки слиянием ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(str1);
            groupBox2.Controls.Add(str2);
            groupBox2.Location = new Point(58, 167);
            groupBox2.Name = "Arrayy";
            groupBox2.Size = new Size(277, 117);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Массивы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 73);
            label4.Name = "Array2";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Массив 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 25);
            label3.Name = "Array1";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Массив 1";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(result);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(404, 167);
            groupBox3.Name = "result";
            groupBox3.Size = new Size(273, 162);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат";
            // 
            // result
            // 
            result.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            result.Location = new Point(59, 47);
            result.MaximumSize = new Size(160, 100);
            result.MinimumSize = new Size(160, 70);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(160, 70);
            result.TabIndex = 4;
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
            // btn_Shell
            // 
            btn_Shell.Location = new Point(107, 300);
            btn_Shell.Name = "btn_Shell";
            btn_Shell.Size = new Size(106, 29);
            btn_Shell.TabIndex = 6;
            btn_Shell.Text = "Сорт. Шелла";
            btn_Shell.UseVisualStyleBackColor = true;
            btn_Shell.Click += btn_Shell_Click;
            // 
            // btn_Sliyanie
            // 
            btn_Sliyanie.Location = new Point(229, 300);
            btn_Sliyanie.Name = "btn_Sliyanie";
            btn_Sliyanie.Size = new Size(106, 29);
            btn_Sliyanie.TabIndex = 7;
            btn_Sliyanie.Text = "Сорт. Слиянием";
            btn_Sliyanie.UseVisualStyleBackColor = true;
            btn_Sliyanie.Click += btn_Sliyanie_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 385);
            Controls.Add(btn_Sliyanie);
            Controls.Add(btn_Shell);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(786, 424);
            MinimumSize = new Size(786, 424);
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
        private TextBox result;
        private Label label6;
        private Button btn_Shell;
        private Button btn_Sliyanie;
    }
}
