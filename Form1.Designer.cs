namespace Restaurante_pago
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
            montoconsumotxt = new TextBox();
            button1 = new Button();
            lbldescuento = new Label();
            lblimpuesto = new Label();
            lbltotaldescuento = new Label();
            lbltotalpagar = new Label();
            SuspendLayout();
            // 
            // montoconsumotxt
            // 
            montoconsumotxt.BackColor = Color.FromArgb(255, 255, 192);
            montoconsumotxt.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            montoconsumotxt.Location = new Point(49, 36);
            montoconsumotxt.Name = "montoconsumotxt";
            montoconsumotxt.Size = new Size(173, 45);
            montoconsumotxt.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(275, 36);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.BackColor = Color.FromArgb(192, 255, 192);
            lbldescuento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbldescuento.Location = new Point(49, 128);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(143, 37);
            lbldescuento.TabIndex = 2;
            lbldescuento.Text = "                  ";
            // 
            // lblimpuesto
            // 
            lblimpuesto.AutoSize = true;
            lblimpuesto.BackColor = Color.FromArgb(192, 255, 192);
            lblimpuesto.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblimpuesto.Location = new Point(49, 220);
            lblimpuesto.Name = "lblimpuesto";
            lblimpuesto.Size = new Size(143, 37);
            lblimpuesto.TabIndex = 3;
            lblimpuesto.Text = "                  ";
            // 
            // lbltotaldescuento
            // 
            lbltotaldescuento.AutoSize = true;
            lbltotaldescuento.BackColor = Color.FromArgb(192, 255, 192);
            lbltotaldescuento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbltotaldescuento.Location = new Point(326, 128);
            lbltotaldescuento.Name = "lbltotaldescuento";
            lbltotaldescuento.Size = new Size(143, 37);
            lbltotaldescuento.TabIndex = 4;
            lbltotaldescuento.Text = "                  ";
            // 
            // lbltotalpagar
            // 
            lbltotalpagar.AutoSize = true;
            lbltotalpagar.BackColor = Color.FromArgb(192, 255, 192);
            lbltotalpagar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbltotalpagar.Location = new Point(326, 220);
            lbltotalpagar.Name = "lbltotalpagar";
            lbltotalpagar.Size = new Size(143, 37);
            lbltotalpagar.TabIndex = 5;
            lbltotalpagar.Text = "                  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 287);
            Controls.Add(lbltotalpagar);
            Controls.Add(lbltotaldescuento);
            Controls.Add(lblimpuesto);
            Controls.Add(lbldescuento);
            Controls.Add(button1);
            Controls.Add(montoconsumotxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox montoconsumotxt;
        private Button button1;
        private Label lbldescuento;
        private Label lblimpuesto;
        private Label lbltotaldescuento;
        private Label lbltotalpagar;
    }
}