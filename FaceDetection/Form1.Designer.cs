namespace FaceDetection
{
    partial class Form1
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
            this.pctFace = new System.Windows.Forms.PictureBox();
            this.btnFaceDetection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFace)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFace
            // 
            this.pctFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctFace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFace.Location = new System.Drawing.Point(0, 0);
            this.pctFace.Name = "pctFace";
            this.pctFace.Size = new System.Drawing.Size(799, 391);
            this.pctFace.TabIndex = 0;
            this.pctFace.TabStop = false;
            // 
            // btnFaceDetection
            // 
            this.btnFaceDetection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFaceDetection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaceDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaceDetection.Location = new System.Drawing.Point(237, 409);
            this.btnFaceDetection.Name = "btnFaceDetection";
            this.btnFaceDetection.Size = new System.Drawing.Size(287, 29);
            this.btnFaceDetection.TabIndex = 1;
            this.btnFaceDetection.Text = "Yüzleri Bul";
            this.btnFaceDetection.UseVisualStyleBackColor = false;
            this.btnFaceDetection.Click += new System.EventHandler(this.btnFaceDetection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFaceDetection);
            this.Controls.Add(this.pctFace);
            this.Name = "Form1";
            this.Text = "Face Detection Application";
            ((System.ComponentModel.ISupportInitialize)(this.pctFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFace;
        private System.Windows.Forms.Button btnFaceDetection;
    }
}

