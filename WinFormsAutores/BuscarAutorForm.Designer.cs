namespace WinFormsAutores
{
    partial class BuscarAutorForm
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
            txtBuscar = new TextBox();
            grillaAutores = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColEdad = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaAutores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            label1.Click += label1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(42, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(304, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyUp += txtBuscar_KeyUp;
            // 
            // grillaAutores
            // 
            grillaAutores.AllowUserToAddRows = false;
            grillaAutores.AllowUserToDeleteRows = false;
            grillaAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAutores.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColEdad });
            grillaAutores.Location = new Point(41, 83);
            grillaAutores.Name = "grillaAutores";
            grillaAutores.ReadOnly = true;
            grillaAutores.Size = new Size(347, 150);
            grillaAutores.TabIndex = 2;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "id";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColEdad
            // 
            ColEdad.DataPropertyName = "edad";
            ColEdad.HeaderText = "Edad";
            ColEdad.Name = "ColEdad";
            ColEdad.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(313, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(223, 281);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // BuscarAutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 316);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(grillaAutores);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BuscarAutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Autor";
            Load += BuscarAutorForm_Load;
            ((System.ComponentModel.ISupportInitialize)grillaAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private DataGridView grillaAutores;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColEdad;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}