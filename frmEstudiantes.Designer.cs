namespace PracticaExam
{
    partial class frmEstudiantes
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
            btnEp = new Button();
            btnEr = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(395, 112);
            label1.Name = "label1";
            label1.Size = new Size(1010, 50);
            label1.TabIndex = 0;
            label1.Text = "ELIGA EL TIPO DE ESTUDIANTE QUE DESEA CALCULAR:";
            // 
            // btnEp
            // 
            btnEp.Location = new Point(245, 314);
            btnEp.Name = "btnEp";
            btnEp.Size = new Size(594, 149);
            btnEp.TabIndex = 1;
            btnEp.Text = "Estudiante de Pregrado";
            btnEp.UseVisualStyleBackColor = true;
            btnEp.Click += btnEp_Click_1;
            // 
            // btnEr
            // 
            btnEr.Location = new Point(954, 314);
            btnEr.Name = "btnEr";
            btnEr.Size = new Size(594, 149);
            btnEr.TabIndex = 2;
            btnEr.Text = "Estudiante Regular";
            btnEr.UseVisualStyleBackColor = true;
            btnEr.Click += btnEr_Click;
            // 
            // frmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 675);
            Controls.Add(btnEr);
            Controls.Add(btnEp);
            Controls.Add(label1);
            Name = "frmEstudiantes";
            Text = "frmEstudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEp;
        private Button btnEr;
    }
}