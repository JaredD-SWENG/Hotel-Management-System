
namespace FinalProject
{
    partial class MainMenuForm
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
            this.viewReservation = new System.Windows.Forms.Button();
            this.createReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewReservation
            // 
            this.viewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservation.Location = new System.Drawing.Point(261, 53);
            this.viewReservation.Name = "viewReservation";
            this.viewReservation.Size = new System.Drawing.Size(159, 66);
            this.viewReservation.TabIndex = 0;
            this.viewReservation.Text = "View Reservation";
            this.viewReservation.UseVisualStyleBackColor = true;
            this.viewReservation.Click += new System.EventHandler(this.viewReservation_Click);
            // 
            // createReservation
            // 
            this.createReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReservation.Location = new System.Drawing.Point(43, 51);
            this.createReservation.Name = "createReservation";
            this.createReservation.Size = new System.Drawing.Size(158, 70);
            this.createReservation.TabIndex = 1;
            this.createReservation.Text = "Create Reservation";
            this.createReservation.UseVisualStyleBackColor = true;
            this.createReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 190);
            this.Controls.Add(this.createReservation);
            this.Controls.Add(this.viewReservation);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewReservation;
        private System.Windows.Forms.Button createReservation;
    }
}

