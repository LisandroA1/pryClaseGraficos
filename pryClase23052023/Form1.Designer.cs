
namespace pryClase23052023
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdAgregarcnVector = new System.Windows.Forms.Button();
            this.cmdAgregarConDosVectores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chtGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend1);
            this.chtGrafico.Location = new System.Drawing.Point(0, 0);
            this.chtGrafico.Name = "chtGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtGrafico.Series.Add(series1);
            this.chtGrafico.Size = new System.Drawing.Size(761, 370);
            this.chtGrafico.TabIndex = 0;
            this.chtGrafico.Text = "chart1";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(659, 389);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(102, 42);
            this.cmdBorrar.TabIndex = 1;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(532, 389);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(102, 42);
            this.cmdAgregar.TabIndex = 2;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdAgregarcnVector
            // 
            this.cmdAgregarcnVector.Location = new System.Drawing.Point(389, 389);
            this.cmdAgregarcnVector.Name = "cmdAgregarcnVector";
            this.cmdAgregarcnVector.Size = new System.Drawing.Size(102, 42);
            this.cmdAgregarcnVector.TabIndex = 3;
            this.cmdAgregarcnVector.Text = "Agregar con Vector";
            this.cmdAgregarcnVector.UseVisualStyleBackColor = true;
            this.cmdAgregarcnVector.Click += new System.EventHandler(this.cmdAgregarcnVector_Click);
            // 
            // cmdAgregarConDosVectores
            // 
            this.cmdAgregarConDosVectores.Location = new System.Drawing.Point(260, 389);
            this.cmdAgregarConDosVectores.Name = "cmdAgregarConDosVectores";
            this.cmdAgregarConDosVectores.Size = new System.Drawing.Size(102, 42);
            this.cmdAgregarConDosVectores.TabIndex = 4;
            this.cmdAgregarConDosVectores.Text = "Agregar con dos Vector";
            this.cmdAgregarConDosVectores.UseVisualStyleBackColor = true;
            this.cmdAgregarConDosVectores.Click += new System.EventHandler(this.cmdAgregarConDosVectores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 503);
            this.Controls.Add(this.cmdAgregarConDosVectores);
            this.Controls.Add(this.cmdAgregarcnVector);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.chtGrafico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdAgregarcnVector;
        private System.Windows.Forms.Button cmdAgregarConDosVectores;
    }
}

