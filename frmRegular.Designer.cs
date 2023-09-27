namespace PracticaExam
{
    partial class frmRegular
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            txtEva2 = new TextBox();
            txtNombre = new TextBox();
            txtActitudinal = new TextBox();
            txtEva3 = new TextBox();
            txtEva1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lvDetalles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            label7 = new Label();
            lbEstadisticas = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(417, 101);
            label1.Name = "label1";
            label1.Size = new Size(785, 45);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE EVALUACIONES-PROGRAMACION I";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtEva2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtActitudinal);
            groupBox1.Controls.Add(txtEva3);
            groupBox1.Controls.Add(txtEva1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(81, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1570, 289);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1230, 182);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(261, 71);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1230, 65);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(261, 71);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "NUEVO DATO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtEva2
            // 
            txtEva2.Location = new Point(640, 125);
            txtEva2.Name = "txtEva2";
            txtEva2.Size = new Size(78, 39);
            txtEva2.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(379, 39);
            txtNombre.TabIndex = 8;
            // 
            // txtActitudinal
            // 
            txtActitudinal.Location = new Point(1004, 125);
            txtActitudinal.Name = "txtActitudinal";
            txtActitudinal.Size = new Size(78, 39);
            txtActitudinal.TabIndex = 7;
            // 
            // txtEva3
            // 
            txtEva3.Location = new Point(817, 125);
            txtEva3.Name = "txtEva3";
            txtEva3.Size = new Size(78, 39);
            txtEva3.TabIndex = 6;
            // 
            // txtEva1
            // 
            txtEva1.Location = new Point(477, 125);
            txtEva1.Name = "txtEva1";
            txtEva1.Size = new Size(78, 39);
            txtEva1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1004, 65);
            label6.Name = "label6";
            label6.Size = new Size(159, 32);
            label6.TabIndex = 4;
            label6.Text = "ACTITUDINAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(817, 65);
            label5.Name = "label5";
            label5.Size = new Size(75, 32);
            label5.TabIndex = 3;
            label5.Text = "EVA 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 65);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 2;
            label4.Text = "EVA 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 65);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 1;
            label3.Text = "EVA 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 65);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 0;
            label2.Text = "ESTUDAINTE";
            // 
            // lvDetalles
            // 
            lvDetalles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvDetalles.GridLines = true;
            lvDetalles.Location = new Point(116, 556);
            lvDetalles.Name = "lvDetalles";
            lvDetalles.Size = new Size(1456, 244);
            lvDetalles.TabIndex = 2;
            lvDetalles.UseCompatibleStateImageBehavior = false;
            lvDetalles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ESTUDIANTE";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "EVA 1";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "EVA 2";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EVA 3";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ACTITUDINAL";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PROMEDIO";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "CONDICION";
            columnHeader7.Width = 250;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 874);
            label7.Name = "label7";
            label7.Size = new Size(163, 32);
            label7.TabIndex = 3;
            label7.Text = "ESTADISTICAS";
            // 
            // lbEstadisticas
            // 
            lbEstadisticas.FormattingEnabled = true;
            lbEstadisticas.ItemHeight = 32;
            lbEstadisticas.Location = new Point(116, 952);
            lbEstadisticas.Name = "lbEstadisticas";
            lbEstadisticas.Size = new Size(1456, 260);
            lbEstadisticas.TabIndex = 4;
            // 
            // frmRegular
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 1335);
            Controls.Add(lbEstadisticas);
            Controls.Add(label7);
            Controls.Add(lvDetalles);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmRegular";
            Text = "frmRegular";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtEva2;
        private TextBox txtNombre;
        private TextBox txtActitudinal;
        private TextBox txtEva3;
        private TextBox txtEva1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRegistrar;
        private Button btnNuevo;
        private ListView lvDetalles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label7;
        private ListBox lbEstadisticas;
    }
}