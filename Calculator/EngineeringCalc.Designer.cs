namespace Calculator
{
    partial class EngineeringCalc
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
            this.ChildMenu = new System.Windows.Forms.MenuStrip();
            this.OrdinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_Stepen = new System.Windows.Forms.Button();
            this.btn_KvKoren = new System.Windows.Forms.Button();
            this.btn_KvadratChisla = new System.Windows.Forms.Button();
            this.btn_ObrZnachenie = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEquals = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStepen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipKvKoren = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipObrChislo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipKvChisla = new System.Windows.Forms.ToolTip(this.components);
            this.ChildMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildMenu
            // 
            this.ChildMenu.BackColor = System.Drawing.Color.Turquoise;
            this.ChildMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ChildMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ChildMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdinMenuItem,
            this.EngMenuItem});
            this.ChildMenu.Location = new System.Drawing.Point(0, 0);
            this.ChildMenu.Name = "ChildMenu";
            this.ChildMenu.Size = new System.Drawing.Size(458, 36);
            this.ChildMenu.TabIndex = 61;
            this.ChildMenu.Text = "menuStrip1";
            // 
            // OrdinMenuItem
            // 
            this.OrdinMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OrdinMenuItem.Name = "OrdinMenuItem";
            this.OrdinMenuItem.Size = new System.Drawing.Size(108, 32);
            this.OrdinMenuItem.Text = "&Обычный";
            this.OrdinMenuItem.Click += new System.EventHandler(this.OrdinMenuItem_Click);
            // 
            // EngMenuItem
            // 
            this.EngMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EngMenuItem.Name = "EngMenuItem";
            this.EngMenuItem.Size = new System.Drawing.Size(136, 32);
            this.EngMenuItem.Text = "&Инженерный";
            this.EngMenuItem.Click += new System.EventHandler(this.EngMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.BackColor = System.Drawing.Color.Aquamarine;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(30, 60);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(400, 35);
            this.txtOutput.TabIndex = 62;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Location = new System.Drawing.Point(331, 119);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(64, 117);
            this.btn_sbros.TabIndex = 63;
            this.btn_sbros.Text = "C";
            this.toolTipDelete.SetToolTip(this.btn_sbros, "Очистить поле ввода");
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.Location = new System.Drawing.Point(114, 295);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(64, 58);
            this.btnChangesign.TabIndex = 80;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.Location = new System.Drawing.Point(178, 295);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(64, 58);
            this.btnpoint.TabIndex = 79;
            this.btnpoint.Text = ",";
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.Location = new System.Drawing.Point(331, 236);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(64, 117);
            this.btn_ravno.TabIndex = 78;
            this.btn_ravno.Text = "=";
            this.toolTipEquals.SetToolTip(this.btn_ravno, "Получить ответ");
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_Stepen
            // 
            this.btn_Stepen.AccessibleName = "divide ";
            this.btn_Stepen.Location = new System.Drawing.Point(267, 119);
            this.btn_Stepen.Name = "btn_Stepen";
            this.btn_Stepen.Size = new System.Drawing.Size(64, 59);
            this.btn_Stepen.TabIndex = 77;
            this.btn_Stepen.Text = "x^y";
            this.toolTipStepen.SetToolTip(this.btn_Stepen, "Возвести число в степень");
            this.btn_Stepen.Click += new System.EventHandler(this.btn_Stepen_Click);
            // 
            // btn_KvKoren
            // 
            this.btn_KvKoren.AccessibleName = "multiply ";
            this.btn_KvKoren.Location = new System.Drawing.Point(267, 178);
            this.btn_KvKoren.Name = "btn_KvKoren";
            this.btn_KvKoren.Size = new System.Drawing.Size(64, 58);
            this.btn_KvKoren.TabIndex = 76;
            this.btn_KvKoren.Text = "√x";
            this.toolTipKvKoren.SetToolTip(this.btn_KvKoren, "Вычислить корень числа");
            this.btn_KvKoren.Click += new System.EventHandler(this.btn_KvKoren_Click);
            // 
            // btn_KvadratChisla
            // 
            this.btn_KvadratChisla.AccessibleName = "plus ";
            this.btn_KvadratChisla.Location = new System.Drawing.Point(267, 295);
            this.btn_KvadratChisla.Name = "btn_KvadratChisla";
            this.btn_KvadratChisla.Size = new System.Drawing.Size(64, 58);
            this.btn_KvadratChisla.TabIndex = 75;
            this.btn_KvadratChisla.Text = "x^2";
            this.toolTipKvChisla.SetToolTip(this.btn_KvadratChisla, "Определить квадрат числа");
            this.btn_KvadratChisla.Click += new System.EventHandler(this.btn_KvadratChisla_Click);
            // 
            // btn_ObrZnachenie
            // 
            this.btn_ObrZnachenie.AccessibleName = "minus ";
            this.btn_ObrZnachenie.Location = new System.Drawing.Point(267, 236);
            this.btn_ObrZnachenie.Name = "btn_ObrZnachenie";
            this.btn_ObrZnachenie.Size = new System.Drawing.Size(64, 59);
            this.btn_ObrZnachenie.TabIndex = 74;
            this.btn_ObrZnachenie.Text = "1/x";
            this.toolTipObrChislo.SetToolTip(this.btn_ObrZnachenie, "Расчитать обратное значение");
            this.btn_ObrZnachenie.Click += new System.EventHandler(this.btn_ObrZnachenie_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.Location = new System.Drawing.Point(50, 295);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 58);
            this.btn0.TabIndex = 73;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.Location = new System.Drawing.Point(178, 119);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 59);
            this.btn9.TabIndex = 72;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.Location = new System.Drawing.Point(114, 119);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 59);
            this.btn8.TabIndex = 71;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.Location = new System.Drawing.Point(50, 119);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 59);
            this.btn7.TabIndex = 70;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.Location = new System.Drawing.Point(178, 178);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 58);
            this.btn6.TabIndex = 69;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.Location = new System.Drawing.Point(114, 178);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 58);
            this.btn5.TabIndex = 68;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.Location = new System.Drawing.Point(50, 178);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 58);
            this.btn4.TabIndex = 67;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.Location = new System.Drawing.Point(178, 236);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 59);
            this.btn3.TabIndex = 66;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.Location = new System.Drawing.Point(114, 236);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 59);
            this.btn2.TabIndex = 65;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.Location = new System.Drawing.Point(50, 236);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 59);
            this.btn1.TabIndex = 64;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // toolTipDelete
            // 
            this.toolTipDelete.Tag = "";
            // 
            // EngineeringCalc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 379);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_Stepen);
            this.Controls.Add(this.btn_KvKoren);
            this.Controls.Add(this.btn_KvadratChisla);
            this.Controls.Add(this.btn_ObrZnachenie);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.ChildMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ChildMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EngineeringCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EngineeringCalc_Load);
            this.ChildMenu.ResumeLayout(false);
            this.ChildMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ChildMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OrdinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EngMenuItem;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btn_sbros;
        private System.Windows.Forms.Button btnChangesign;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn_ravno;
        private System.Windows.Forms.Button btn_Stepen;
        private System.Windows.Forms.Button btn_KvKoren;
        private System.Windows.Forms.Button btn_KvadratChisla;
        private System.Windows.Forms.Button btn_ObrZnachenie;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolTip toolTipEquals;
        private System.Windows.Forms.ToolTip toolTipStepen;
        private System.Windows.Forms.ToolTip toolTipKvKoren;
        private System.Windows.Forms.ToolTip toolTipObrChislo;
        private System.Windows.Forms.ToolTip toolTipKvChisla;
    }
}