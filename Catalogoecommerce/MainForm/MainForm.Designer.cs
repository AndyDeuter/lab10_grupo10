namespace MainForm
{
    partial class MainForm
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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            labelName = new Label();
            labelDescription = new Label();
            labelPrice = new Label();
            labelStock = new Label();
            txtNombre = new TextBox();
            txtDescripción = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            dataGridViewProductos = new DataGridView();
            btnMostrar = new Button();
            labelCategoria = new Label();
            comboBoxCategorias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(194, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(294, 24);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(394, 24);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(100, 86);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Nombre";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(100, 132);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(87, 20);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Descripcion";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(100, 173);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(50, 20);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Precio";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(100, 221);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(45, 20);
            labelStock.TabIndex = 6;
            labelStock.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new Point(194, 132);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new Size(125, 27);
            txtDescripción.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(194, 173);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(194, 221);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 10;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(100, 323);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(388, 149);
            dataGridViewProductos.TabIndex = 11;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(503, 24);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(100, 266);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 13;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(194, 263);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(151, 28);
            comboBoxCategorias.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(comboBoxCategorias);
            Controls.Add(labelCategoria);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridViewProductos);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripción);
            Controls.Add(txtNombre);
            Controls.Add(labelStock);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label labelName;
        private Label labelDescription;
        private Label labelPrice;
        private Label labelStock;
        private TextBox txtNombre;
        private TextBox txtDescripción;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private DataGridView dataGridViewProductos;
        private Button btnMostrar;
        private Label labelCategoria;
        private ComboBox comboBoxCategorias;
    }
}