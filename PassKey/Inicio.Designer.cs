namespace PassKey
{
    partial class Inicio
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
            txtWeb = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DGVPassword = new DataGridView();
            BtnGuardar = new Button();
            BtnEditar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVPassword).BeginInit();
            SuspendLayout();
            // 
            // txtWeb
            // 
            txtWeb.Location = new Point(235, 41);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(137, 23);
            txtWeb.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(433, 41);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(137, 23);
            txtCorreo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Sitio Web";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 23);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Correo\r\n";
            // 
            // DGVPassword
            // 
            DGVPassword.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPassword.Location = new Point(47, 143);
            DGVPassword.Name = "DGVPassword";
            DGVPassword.RowTemplate.Height = 25;
            DGVPassword.Size = new Size(575, 150);
            DGVPassword.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.ForestGreen;
            BtnGuardar.FlatStyle = FlatStyle.Popup;
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(53, 91);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(136, 23);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.SteelBlue;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(235, 91);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(136, 23);
            BtnEditar.TabIndex = 7;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(438, 91);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(53, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(137, 23);
            txtId.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 23);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 10;
            label3.Text = "id";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnGuardar);
            Controls.Add(DGVPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(txtWeb);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)DGVPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeb;
        private TextBox txtCorreo;
        private Label label1;
        private Label label2;
        private DataGridView DGVPassword;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button btnEliminar;
        private TextBox txtId;
        private Label label3;
    }
}