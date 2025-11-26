
namespace Ejercisio3
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
            label1 = new Label();
            TboxParrafo = new TextBox();
            BtnBuscar = new Button();
            TboxPalabra = new TextBox();
            label2 = new Label();
            LboxResultados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "parrafo";
            // 
            // TboxParrafo
            // 
            TboxParrafo.Location = new Point(174, 41);
            TboxParrafo.Name = "TboxParrafo";
            TboxParrafo.Size = new Size(251, 23);
            TboxParrafo.TabIndex = 1;
            TboxParrafo.TextChanged += TboxParrafo_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(603, 37);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(95, 29);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "BtnBuscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TboxPalabra
            // 
            TboxPalabra.Location = new Point(459, 43);
            TboxPalabra.Name = "TboxPalabra";
            TboxPalabra.Size = new Size(100, 23);
            TboxPalabra.TabIndex = 3;
            TboxPalabra.TextChanged += TboxPalabra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 25);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Para buscar palabra";
            // 
            // LboxResultados
            // 
            LboxResultados.FormattingEnabled = true;
            LboxResultados.ItemHeight = 15;
            LboxResultados.Location = new Point(230, 102);
            LboxResultados.Name = "LboxResultados";
            LboxResultados.Size = new Size(253, 259);
            LboxResultados.TabIndex = 5;
            LboxResultados.SelectedIndexChanged += LboxResultados_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LboxResultados);
            Controls.Add(label2);
            Controls.Add(TboxPalabra);
            Controls.Add(BtnBuscar);
            Controls.Add(TboxParrafo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            NewMethod();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            Load += Form1_Load;
        }

        #endregion

        private Label label1;
        private TextBox TboxParrafo;
        private Button BtnBuscar;
        private TextBox TboxPalabra;
        private Label label2;
        private ListBox LboxResultados;

        public EventHandler Form1_Load { get; private set; }
    }
}
