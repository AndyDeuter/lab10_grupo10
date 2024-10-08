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
            txtName = new TextBox();
            txtDescrption = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // txtName
            // 
            txtName.Location = new Point(194, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtDescrption
            // 
            txtDescrption.Location = new Point(194, 132);
            txtDescrption.Name = "txtDescrption";
            txtDescrption.Size = new Size(125, 27);
            txtDescrption.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(194, 173);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(194, 221);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(388, 149);
            dataGridView1.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtDescrption);
            Controls.Add(txtName);
            Controls.Add(labelStock);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtName;
        private TextBox txtDescrption;
        private TextBox txtPrice;
        private TextBox txtStock;
        private DataGridView dataGridView1;
    }
}