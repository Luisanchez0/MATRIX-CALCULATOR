
namespace MATRIX_CALCULATOR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.btnResize = new System.Windows.Forms.Button();
            this.numericUpDownScalar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMultiplyByScalar = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.lbMarizA = new System.Windows.Forms.Label();
            this.lbMarizB = new System.Windows.Forms.Label();
            this.lbMatrizResul = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(268, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(268, 200);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(470, 88);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 28;
            this.dataGridViewResult.Size = new System.Drawing.Size(268, 200);
            this.dataGridViewResult.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 501);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "SUMA";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(18, 554);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(96, 37);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "RESTA";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click_1);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(146, 501);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(164, 37);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "MULTIPLICACION";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click_1);
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(97, 41);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRows.TabIndex = 6;
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(97, 100);
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownColumns.TabIndex = 7;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(245, 64);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(94, 37);
            this.btnResize.TabIndex = 8;
            this.btnResize.Text = "Aplicar";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click_1);
            // 
            // numericUpDownScalar
            // 
            this.numericUpDownScalar.Location = new System.Drawing.Point(544, 526);
            this.numericUpDownScalar.Name = "numericUpDownScalar";
            this.numericUpDownScalar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownScalar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "MULT ESCALAR MATRIZ A";
            // 
            // btnMultiplyByScalar
            // 
            this.btnMultiplyByScalar.Location = new System.Drawing.Point(544, 559);
            this.btnMultiplyByScalar.Name = "btnMultiplyByScalar";
            this.btnMultiplyByScalar.Size = new System.Drawing.Size(143, 34);
            this.btnMultiplyByScalar.TabIndex = 11;
            this.btnMultiplyByScalar.Text = "Mult_Escalar";
            this.btnMultiplyByScalar.UseVisualStyleBackColor = true;
            this.btnMultiplyByScalar.Click += new System.EventHandler(this.btnMultiplyByScalar_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(146, 554);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(116, 37);
            this.btnInverse.TabIndex = 12;
            this.btnInverse.Text = "INVERSA";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnTranspose
            // 
            this.btnTranspose.Location = new System.Drawing.Point(350, 501);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(139, 37);
            this.btnTranspose.TabIndex = 13;
            this.btnTranspose.Text = "TRANSPUESTA";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // lbMarizA
            // 
            this.lbMarizA.AutoSize = true;
            this.lbMarizA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarizA.Location = new System.Drawing.Point(14, 9);
            this.lbMarizA.Name = "lbMarizA";
            this.lbMarizA.Size = new System.Drawing.Size(92, 20);
            this.lbMarizA.TabIndex = 14;
            this.lbMarizA.Text = "MATRIZ A";
            // 
            // lbMarizB
            // 
            this.lbMarizB.AutoSize = true;
            this.lbMarizB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarizB.Location = new System.Drawing.Point(14, 243);
            this.lbMarizB.Name = "lbMarizB";
            this.lbMarizB.Size = new System.Drawing.Size(92, 20);
            this.lbMarizB.TabIndex = 15;
            this.lbMarizB.Text = "MATRIZ B";
            // 
            // lbMatrizResul
            // 
            this.lbMatrizResul.AutoSize = true;
            this.lbMatrizResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatrizResul.Location = new System.Drawing.Point(479, 65);
            this.lbMatrizResul.Name = "lbMatrizResul";
            this.lbMatrizResul.Size = new System.Drawing.Size(196, 20);
            this.lbMatrizResul.TabIndex = 16;
            this.lbMatrizResul.Text = "MATRIZ RESULTANTE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownRows);
            this.groupBox1.Controls.Add(this.numericUpDownColumns);
            this.groupBox1.Controls.Add(this.btnResize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(470, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 136);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimension de la Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Columnas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1076, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMatrizResul);
            this.Controls.Add(this.lbMarizB);
            this.Controls.Add(this.lbMarizA);
            this.Controls.Add(this.btnTranspose);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnMultiplyByScalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownScalar);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Matrix Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.NumericUpDown numericUpDownScalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMultiplyByScalar;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.Label lbMarizA;
        private System.Windows.Forms.Label lbMarizB;
        private System.Windows.Forms.Label lbMatrizResul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

