namespace Lotto
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonLotto = new System.Windows.Forms.RadioButton();
            this.radioButtonMiniLotto = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiMulti = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRand = new System.Windows.Forms.Label();
            this.labelGoodLuck = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.labelSrt = new System.Windows.Forms.Label();
            this.labelSorted = new System.Windows.Forms.Label();
            this.labelOneSort = new System.Windows.Forms.Label();
            this.checkBoxPlus = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelHowMuch = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonLotto
            // 
            this.radioButtonLotto.AutoSize = true;
            this.radioButtonLotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonLotto.Location = new System.Drawing.Point(98, 108);
            this.radioButtonLotto.Name = "radioButtonLotto";
            this.radioButtonLotto.Size = new System.Drawing.Size(64, 24);
            this.radioButtonLotto.TabIndex = 0;
            this.radioButtonLotto.TabStop = true;
            this.radioButtonLotto.Text = "Lotto";
            this.radioButtonLotto.UseVisualStyleBackColor = true;
            this.radioButtonLotto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonMiniLotto
            // 
            this.radioButtonMiniLotto.AutoSize = true;
            this.radioButtonMiniLotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMiniLotto.Location = new System.Drawing.Point(212, 108);
            this.radioButtonMiniLotto.Name = "radioButtonMiniLotto";
            this.radioButtonMiniLotto.Size = new System.Drawing.Size(96, 24);
            this.radioButtonMiniLotto.TabIndex = 1;
            this.radioButtonMiniLotto.TabStop = true;
            this.radioButtonMiniLotto.Text = "Mini Lotto";
            this.radioButtonMiniLotto.UseVisualStyleBackColor = true;
            this.radioButtonMiniLotto.CheckedChanged += new System.EventHandler(this.radioButtonMiniLotto_CheckedChanged);
            // 
            // radioButtonMultiMulti
            // 
            this.radioButtonMultiMulti.AutoSize = true;
            this.radioButtonMultiMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMultiMulti.Location = new System.Drawing.Point(146, 138);
            this.radioButtonMultiMulti.Name = "radioButtonMultiMulti";
            this.radioButtonMultiMulti.Size = new System.Drawing.Size(97, 24);
            this.radioButtonMultiMulti.TabIndex = 2;
            this.radioButtonMultiMulti.TabStop = true;
            this.radioButtonMultiMulti.Text = "Multi Multi";
            this.radioButtonMultiMulti.UseVisualStyleBackColor = true;
            this.radioButtonMultiMulti.CheckedChanged += new System.EventHandler(this.radioButtonMultiMulti_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(136, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Losuj!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(98, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(132, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRand
            // 
            this.labelRand.AutoSize = true;
            this.labelRand.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRand.Location = new System.Drawing.Point(19, 280);
            this.labelRand.Name = "labelRand";
            this.labelRand.Size = new System.Drawing.Size(24, 32);
            this.labelRand.TabIndex = 6;
            this.labelRand.Text = " ";
            this.labelRand.Click += new System.EventHandler(this.labelRand_Click);
            // 
            // labelGoodLuck
            // 
            this.labelGoodLuck.AutoSize = true;
            this.labelGoodLuck.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoodLuck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelGoodLuck.Location = new System.Drawing.Point(4, 544);
            this.labelGoodLuck.Name = "labelGoodLuck";
            this.labelGoodLuck.Size = new System.Drawing.Size(413, 37);
            this.labelGoodLuck.TabIndex = 7;
            this.labelGoodLuck.Text = "Program życzy Wysokich Wygranych!";
            this.labelGoodLuck.Visible = false;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(43, 443);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(0, 13);
            this.labelSort.TabIndex = 9;
            // 
            // labelSrt
            // 
            this.labelSrt.AutoSize = true;
            this.labelSrt.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSrt.Location = new System.Drawing.Point(19, 424);
            this.labelSrt.Name = "labelSrt";
            this.labelSrt.Size = new System.Drawing.Size(107, 32);
            this.labelSrt.TabIndex = 10;
            this.labelSrt.Text = "label2";
            this.labelSrt.Visible = false;
            // 
            // labelSorted
            // 
            this.labelSorted.AutoSize = true;
            this.labelSorted.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSorted.Location = new System.Drawing.Point(18, 372);
            this.labelSorted.Name = "labelSorted";
            this.labelSorted.Size = new System.Drawing.Size(186, 38);
            this.labelSorted.TabIndex = 11;
            this.labelSorted.Text = "Posortowane:";
            this.labelSorted.Visible = false;
            // 
            // labelOneSort
            // 
            this.labelOneSort.AutoSize = true;
            this.labelOneSort.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOneSort.Location = new System.Drawing.Point(218, 233);
            this.labelOneSort.Name = "labelOneSort";
            this.labelOneSort.Size = new System.Drawing.Size(25, 34);
            this.labelOneSort.TabIndex = 12;
            this.labelOneSort.Text = ".";
            this.labelOneSort.Visible = false;
            // 
            // checkBoxPlus
            // 
            this.checkBoxPlus.AutoSize = true;
            this.checkBoxPlus.Location = new System.Drawing.Point(371, 149);
            this.checkBoxPlus.Name = "checkBoxPlus";
            this.checkBoxPlus.Size = new System.Drawing.Size(46, 17);
            this.checkBoxPlus.TabIndex = 13;
            this.checkBoxPlus.Text = "Plus";
            this.checkBoxPlus.UseVisualStyleBackColor = true;
            this.checkBoxPlus.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // labelHowMuch
            // 
            this.labelHowMuch.AutoSize = true;
            this.labelHowMuch.Location = new System.Drawing.Point(298, 149);
            this.labelHowMuch.Name = "labelHowMuch";
            this.labelHowMuch.Size = new System.Drawing.Size(58, 13);
            this.labelHowMuch.TabIndex = 15;
            this.labelHowMuch.Text = "od 1 do 10";
            this.labelHowMuch.Visible = false;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlus.Location = new System.Drawing.Point(20, 487);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(95, 29);
            this.labelPlus.TabIndex = 17;
            this.labelPlus.Text = "label3";
            this.labelPlus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 599);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.labelHowMuch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxPlus);
            this.Controls.Add(this.labelOneSort);
            this.Controls.Add(this.labelSorted);
            this.Controls.Add(this.labelSrt);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.labelGoodLuck);
            this.Controls.Add(this.labelRand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonMultiMulti);
            this.Controls.Add(this.radioButtonMiniLotto);
            this.Controls.Add(this.radioButtonLotto);
            this.Name = "Form1";
            this.Text = "Cicha Maszyna Losująca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLotto;
        private System.Windows.Forms.RadioButton radioButtonMiniLotto;
        private System.Windows.Forms.RadioButton radioButtonMultiMulti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRand;
        private System.Windows.Forms.Label labelGoodLuck;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label labelSrt;
        private System.Windows.Forms.Label labelSorted;
        private System.Windows.Forms.Label labelOneSort;
        private System.Windows.Forms.CheckBox checkBoxPlus;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelHowMuch;
        private System.Windows.Forms.Label labelPlus;
    }
}

