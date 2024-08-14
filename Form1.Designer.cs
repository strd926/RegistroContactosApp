namespace RegistroContactosApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            LabelNombre = new Label();
            LabelNumero = new Label();
            LabelEmail = new Label();
            textBoxName = new TextBox();
            textBoxNumero = new TextBox();
            textBoxEmail = new TextBox();
            buttonAgregar = new Button();
            buttonLimpiar = new Button();
            listBox = new ListBox();
            labelEstado = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(48, 45);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(67, 20);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre:";
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(45, 110);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(70, 20);
            LabelNumero.TabIndex = 1;
            LabelNumero.Text = "Teléfono:";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(48, 177);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(49, 20);
            LabelEmail.TabIndex = 2;
            LabelEmail.Text = "Email:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(48, 68);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(323, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(48, 133);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(323, 27);
            textBoxNumero.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(48, 200);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(323, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(48, 253);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(323, 37);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar Contacto";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(45, 311);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(323, 37);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar Campos";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(48, 426);
            listBox.Name = "listBox";
            listBox.Size = new Size(324, 84);
            listBox.TabIndex = 8;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(45, 366);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(54, 20);
            labelEstado.TabIndex = 9;
            labelEstado.Text = "Estado";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 566);
            Controls.Add(labelEstado);
            Controls.Add(listBox);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxName);
            Controls.Add(LabelEmail);
            Controls.Add(LabelNumero);
            Controls.Add(LabelNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNombre;
        private Label LabelNumero;
        private Label LabelEmail;
        private TextBox textBoxName;
        private TextBox textBoxNumero;
        private TextBox textBoxEmail;
        private Button buttonAgregar;
        private Button buttonLimpiar;
        private ListBox listBox;
        private Label labelEstado;
        private ContextMenuStrip contextMenuStrip1;
    }
}
