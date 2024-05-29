namespace AcademiaABM
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            tcUsuarios = new ToolStripContainer();
            tlAlumnos = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            btnActualizar = new Button();
            btnSalir = new Button();
            tlUsuarios = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditad = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            nombrecolumna = new DataGridViewTextBoxColumn();
            Cabecera = new DataGridViewTextBoxColumn();
            Origendedatos = new DataGridViewTextBoxColumn();
            tipocolumna = new DataGridViewTextBoxColumn();
            tcUsuarios.ContentPanel.SuspendLayout();
            tcUsuarios.TopToolStripPanel.SuspendLayout();
            tcUsuarios.SuspendLayout();
            tlAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tlUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            tcUsuarios.ContentPanel.Controls.Add(tlAlumnos);
            tcUsuarios.ContentPanel.Size = new Size(800, 400);
            tcUsuarios.Dock = DockStyle.Fill;
            tcUsuarios.Location = new Point(0, 0);
            tcUsuarios.Name = "tcUsuarios";
            tcUsuarios.Size = new Size(800, 450);
            tcUsuarios.TabIndex = 0;
            tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            tcUsuarios.TopToolStripPanel.Controls.Add(tlUsuarios);
            // 
            // tlAlumnos
            // 
            tlAlumnos.ColumnCount = 2;
            tlAlumnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlAlumnos.ColumnStyles.Add(new ColumnStyle());
            tlAlumnos.Controls.Add(dgvUsuarios, 0, 0);
            tlAlumnos.Controls.Add(btnActualizar, 0, 1);
            tlAlumnos.Controls.Add(btnSalir, 1, 1);
            tlAlumnos.Dock = DockStyle.Fill;
            tlAlumnos.Location = new Point(0, 0);
            tlAlumnos.Name = "tlAlumnos";
            tlAlumnos.RowCount = 2;
            tlAlumnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlAlumnos.RowStyles.Add(new RowStyle());
            tlAlumnos.Size = new Size(800, 400);
            tlAlumnos.TabIndex = 0;
            tlAlumnos.Paint += tlAlumnos_Paint;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { nombrecolumna, Cabecera, Origendedatos, tipocolumna });
            tlAlumnos.SetColumnSpan(dgvUsuarios, 2);
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.Size = new Size(794, 365);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(641, 374);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(722, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tlUsuarios
            // 
            tlUsuarios.Dock = DockStyle.None;
            tlUsuarios.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditad, tsbEliminar });
            tlUsuarios.Location = new Point(6, 0);
            tlUsuarios.Name = "tlUsuarios";
            tlUsuarios.Size = new Size(81, 25);
            tlUsuarios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(23, 22);
            tsbNuevo.Text = "toolStripButton1";
            tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tsbEditad
            // 
            tsbEditad.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditad.Image = (Image)resources.GetObject("tsbEditad.Image");
            tsbEditad.ImageTransparentColor = Color.Magenta;
            tsbEditad.Name = "tsbEditad";
            tsbEditad.Size = new Size(23, 22);
            tsbEditad.Text = "Editar";
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 22);
            tsbEliminar.Text = "Eliminar";
            // 
            // nombrecolumna
            // 
            nombrecolumna.HeaderText = "Nombre Columna";
            nombrecolumna.Name = "nombrecolumna";
            nombrecolumna.ReadOnly = true;
            // 
            // Cabecera
            // 
            Cabecera.HeaderText = "Cabecera";
            Cabecera.Name = "Cabecera";
            Cabecera.ReadOnly = true;
            // 
            // Origendedatos
            // 
            Origendedatos.HeaderText = "Origen de datos";
            Origendedatos.Name = "Origendedatos";
            Origendedatos.ReadOnly = true;
            // 
            // tipocolumna
            // 
            tipocolumna.HeaderText = "Tipo Columna";
            tipocolumna.Name = "tipocolumna";
            tipocolumna.ReadOnly = true;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcUsuarios);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            tcUsuarios.ContentPanel.ResumeLayout(false);
            tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            tcUsuarios.TopToolStripPanel.PerformLayout();
            tcUsuarios.ResumeLayout(false);
            tcUsuarios.PerformLayout();
            tlAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tlUsuarios.ResumeLayout(false);
            tlUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tcUsuarios;
        private ToolStrip tlUsuarios;
        private TableLayoutPanel tlAlumnos;
        private DataGridView dgvUsuarios;
        private Button btnActualizar;
        private Button btnSalir;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditad;
        private ToolStripButton tsbEliminar;
        private DataGridViewTextBoxColumn nombrecolumna;
        private DataGridViewTextBoxColumn Cabecera;
        private DataGridViewTextBoxColumn Origendedatos;
        private DataGridViewTextBoxColumn tipocolumna;
    }
}
