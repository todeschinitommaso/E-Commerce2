namespace Esercitazione
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
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.addproduct = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.empty = new System.Windows.Forms.Button();
            this.pricelabel = new System.Windows.Forms.Label();
            this.carrello = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CARRELLO";
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(12, 40);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(351, 360);
            this.lista.TabIndex = 2;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "LISTA PRODOTTI";
            // 
            // addproduct
            // 
            this.addproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addproduct.Location = new System.Drawing.Point(12, 406);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(100, 35);
            this.addproduct.TabIndex = 4;
            this.addproduct.Text = "AGGIUNGI";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove.Location = new System.Drawing.Point(437, 406);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(100, 35);
            this.remove.TabIndex = 6;
            this.remove.Text = "RIMUOVI";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // empty
            // 
            this.empty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empty.Location = new System.Drawing.Point(543, 406);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(100, 35);
            this.empty.TabIndex = 7;
            this.empty.Text = "SVUOTA";
            this.empty.UseVisualStyleBackColor = true;
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricelabel.Location = new System.Drawing.Point(687, 410);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(53, 25);
            this.pricelabel.TabIndex = 8;
            this.pricelabel.Text = "TOT: ";
            // 
            // carrello
            // 
            this.carrello.FormattingEnabled = true;
            this.carrello.ItemHeight = 15;
            this.carrello.Location = new System.Drawing.Point(437, 40);
            this.carrello.Name = "carrello";
            this.carrello.Size = new System.Drawing.Size(351, 349);
            this.carrello.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.carrello);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tommy Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ListView lista;
        private Label label2;
        private Button addproduct;
        private Button remove;
        private Button empty;
        private Label pricelabel;
        private ListBox carrello;
    }
}