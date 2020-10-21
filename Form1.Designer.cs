namespace ProgramaProlog_VillaOsuna
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_boxeadores = new System.Windows.Forms.ListBox();
            this.combo_boxeadores = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_todos = new System.Windows.Forms.RadioButton();
            this.radio_mex = new System.Windows.Forms.RadioButton();
            this.radio_eua = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_boxeadores
            // 
            this.listBox_boxeadores.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_boxeadores.FormattingEnabled = true;
            this.listBox_boxeadores.ItemHeight = 17;
            this.listBox_boxeadores.Location = new System.Drawing.Point(165, 233);
            this.listBox_boxeadores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_boxeadores.Name = "listBox_boxeadores";
            this.listBox_boxeadores.Size = new System.Drawing.Size(243, 123);
            this.listBox_boxeadores.TabIndex = 0;
            // 
            // combo_boxeadores
            // 
            this.combo_boxeadores.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_boxeadores.FormattingEnabled = true;
            this.combo_boxeadores.Items.AddRange(new object[] {
            "Peso Welter",
            "Peso Medio",
            "Peso Pesado"});
            this.combo_boxeadores.Location = new System.Drawing.Point(203, 160);
            this.combo_boxeadores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_boxeadores.Name = "combo_boxeadores";
            this.combo_boxeadores.Size = new System.Drawing.Size(171, 25);
            this.combo_boxeadores.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(173, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_todos
            // 
            this.radio_todos.AutoSize = true;
            this.radio_todos.BackColor = System.Drawing.Color.Transparent;
            this.radio_todos.Checked = true;
            this.radio_todos.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_todos.Location = new System.Drawing.Point(439, 401);
            this.radio_todos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radio_todos.Name = "radio_todos";
            this.radio_todos.Size = new System.Drawing.Size(85, 24);
            this.radio_todos.TabIndex = 3;
            this.radio_todos.TabStop = true;
            this.radio_todos.Text = "Todos";
            this.radio_todos.UseVisualStyleBackColor = false;
            this.radio_todos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_mex
            // 
            this.radio_mex.AutoSize = true;
            this.radio_mex.BackColor = System.Drawing.Color.Transparent;
            this.radio_mex.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_mex.Location = new System.Drawing.Point(439, 439);
            this.radio_mex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radio_mex.Name = "radio_mex";
            this.radio_mex.Size = new System.Drawing.Size(96, 24);
            this.radio_mex.TabIndex = 4;
            this.radio_mex.Text = "México";
            this.radio_mex.UseVisualStyleBackColor = false;
            // 
            // radio_eua
            // 
            this.radio_eua.AutoSize = true;
            this.radio_eua.BackColor = System.Drawing.Color.Transparent;
            this.radio_eua.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_eua.Location = new System.Drawing.Point(439, 473);
            this.radio_eua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radio_eua.Name = "radio_eua";
            this.radio_eua.Size = new System.Drawing.Size(63, 24);
            this.radio_eua.TabIndex = 5;
            this.radio_eua.Text = "EUA";
            this.radio_eua.UseVisualStyleBackColor = false;
            this.radio_eua.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 84);
            this.label1.TabIndex = 6;
            this.label1.Text = "BOXEADORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(92, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "PESO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramaProlog_VillaOsuna.Properties.Resources.fondo_b_esc;
            this.ClientSize = new System.Drawing.Size(847, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_eua);
            this.Controls.Add(this.radio_mex);
            this.Controls.Add(this.radio_todos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_boxeadores);
            this.Controls.Add(this.listBox_boxeadores);
            this.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_boxeadores;
        private System.Windows.Forms.ComboBox combo_boxeadores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_todos;
        private System.Windows.Forms.RadioButton radio_mex;
        private System.Windows.Forms.RadioButton radio_eua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

