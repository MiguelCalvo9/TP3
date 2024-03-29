﻿
namespace TP3_Simulacion
{
    partial class PruebaDeBondad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdExponencialNegativa = new System.Windows.Forms.RadioButton();
            this.rdPoisson = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.rbUniforme = new System.Windows.Forms.RadioButton();
            this.Muestra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.grpUniforme = new System.Windows.Forms.GroupBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblLambda = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.grillaDatos = new System.Windows.Forms.DataGridView();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadIntervalos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grpUniforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdExponencialNegativa);
            this.panel1.Controls.Add(this.rdPoisson);
            this.panel1.Controls.Add(this.rdNormal);
            this.panel1.Controls.Add(this.rbUniforme);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 149);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Distribucion";
            // 
            // rdExponencialNegativa
            // 
            this.rdExponencialNegativa.AutoSize = true;
            this.rdExponencialNegativa.Location = new System.Drawing.Point(16, 112);
            this.rdExponencialNegativa.Name = "rdExponencialNegativa";
            this.rdExponencialNegativa.Size = new System.Drawing.Size(126, 17);
            this.rdExponencialNegativa.TabIndex = 3;
            this.rdExponencialNegativa.TabStop = true;
            this.rdExponencialNegativa.Text = "exponencial negativa";
            this.rdExponencialNegativa.UseVisualStyleBackColor = true;
            this.rdExponencialNegativa.CheckedChanged += new System.EventHandler(this.rdExponencialNegativa_CheckedChanged);
            // 
            // rdPoisson
            // 
            this.rdPoisson.AutoSize = true;
            this.rdPoisson.Location = new System.Drawing.Point(16, 89);
            this.rdPoisson.Name = "rdPoisson";
            this.rdPoisson.Size = new System.Drawing.Size(62, 17);
            this.rdPoisson.TabIndex = 2;
            this.rdPoisson.TabStop = true;
            this.rdPoisson.Text = "Poisson";
            this.rdPoisson.UseVisualStyleBackColor = true;
            this.rdPoisson.CheckedChanged += new System.EventHandler(this.rdPoisson_CheckedChanged);
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Location = new System.Drawing.Point(16, 66);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(58, 17);
            this.rdNormal.TabIndex = 1;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Normal";
            this.rdNormal.UseVisualStyleBackColor = true;
            this.rdNormal.CheckedChanged += new System.EventHandler(this.rdNormal_CheckedChanged);
            // 
            // rbUniforme
            // 
            this.rbUniforme.AutoSize = true;
            this.rbUniforme.Location = new System.Drawing.Point(16, 43);
            this.rbUniforme.Name = "rbUniforme";
            this.rbUniforme.Size = new System.Drawing.Size(67, 17);
            this.rbUniforme.TabIndex = 0;
            this.rbUniforme.TabStop = true;
            this.rbUniforme.Text = "Uniforme";
            this.rbUniforme.UseVisualStyleBackColor = true;
            this.rbUniforme.CheckedChanged += new System.EventHandler(this.rbUniforme_CheckedChanged);
            // 
            // Muestra
            // 
            this.Muestra.AutoSize = true;
            this.Muestra.Location = new System.Drawing.Point(212, 12);
            this.Muestra.Name = "Muestra";
            this.Muestra.Size = new System.Drawing.Size(87, 13);
            this.Muestra.TabIndex = 1;
            this.Muestra.Text = "Tamaño Muestra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maximo";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(316, 9);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(33, 20);
            this.txtN.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(59, 65);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(54, 20);
            this.txtMin.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(59, 36);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(54, 20);
            this.txtMax.TabIndex = 6;
            // 
            // grpUniforme
            // 
            this.grpUniforme.Controls.Add(this.txtMax);
            this.grpUniforme.Controls.Add(this.label2);
            this.grpUniforme.Controls.Add(this.txtMin);
            this.grpUniforme.Controls.Add(this.label3);
            this.grpUniforme.Location = new System.Drawing.Point(215, 41);
            this.grpUniforme.Name = "grpUniforme";
            this.grpUniforme.Size = new System.Drawing.Size(134, 120);
            this.grpUniforme.TabIndex = 7;
            this.grpUniforme.TabStop = false;
            this.grpUniforme.Text = "Uniforme";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Enabled = false;
            this.lblMedia.Location = new System.Drawing.Point(369, 77);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "Media";
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Enabled = false;
            this.lblLambda.Location = new System.Drawing.Point(369, 113);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(45, 13);
            this.lblLambda.TabIndex = 9;
            this.lblLambda.Text = "Lambda";
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(420, 70);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(33, 20);
            this.txtMedia.TabIndex = 10;
            // 
            // txtLambda
            // 
            this.txtLambda.Enabled = false;
            this.txtLambda.Location = new System.Drawing.Point(420, 109);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(33, 20);
            this.txtLambda.TabIndex = 11;
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(12, 196);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(120, 329);
            this.lstNumeros.TabIndex = 12;
            // 
            // grillaDatos
            // 
            this.grillaDatos.AllowUserToAddRows = false;
            this.grillaDatos.AllowUserToDeleteRows = false;
            this.grillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.Fo,
            this.Fe,
            this.C,
            this.Cacu});
            this.grillaDatos.Location = new System.Drawing.Point(156, 194);
            this.grillaDatos.Name = "grillaDatos";
            this.grillaDatos.ReadOnly = true;
            this.grillaDatos.Size = new System.Drawing.Size(543, 331);
            this.grillaDatos.TabIndex = 14;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.ReadOnly = true;
            // 
            // Fo
            // 
            this.Fo.HeaderText = "Fo";
            this.Fo.Name = "Fo";
            this.Fo.ReadOnly = true;
            // 
            // Fe
            // 
            this.Fe.HeaderText = "Fe";
            this.Fe.Name = "Fe";
            this.Fe.ReadOnly = true;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // Cacu
            // 
            this.Cacu.HeaderText = "Cacu";
            this.Cacu.Name = "Cacu";
            this.Cacu.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(490, 138);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 23);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(600, 138);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(99, 23);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad de Intervalos";
            // 
            // txtCantidadIntervalos
            // 
            this.txtCantidadIntervalos.Location = new System.Drawing.Point(609, 48);
            this.txtCantidadIntervalos.Name = "txtCantidadIntervalos";
            this.txtCantidadIntervalos.Size = new System.Drawing.Size(49, 20);
            this.txtCantidadIntervalos.TabIndex = 18;
            // 
            // PruebaDeBondad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 537);
            this.Controls.Add(this.txtCantidadIntervalos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grillaDatos);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblLambda);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.Muestra);
            this.Controls.Add(this.grpUniforme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtN);
            this.Name = "PruebaDeBondad";
            this.Text = "Prueba de Bondad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpUniforme.ResumeLayout(false);
            this.grpUniforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdExponencialNegativa;
        private System.Windows.Forms.RadioButton rdPoisson;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rbUniforme;
        private System.Windows.Forms.Label Muestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.GroupBox grpUniforme;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.DataGridView grillaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cacu;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadIntervalos;
    }
}

