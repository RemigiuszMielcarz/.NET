namespace Calendar_frontend
{
    partial class UserControlDays
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.lbevent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbdays.Location = new System.Drawing.Point(16, 18);
            this.lbdays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(28, 24);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // lbevent
            // 
            this.lbevent.Location = new System.Drawing.Point(20, 50);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(149, 50);
            this.lbevent.TabIndex = 1;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.lbdays);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(183, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label lbevent;
        private System.Windows.Forms.Timer timer1;
    }
}
