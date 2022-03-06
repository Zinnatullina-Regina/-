
namespace Вкладки
{
    partial class Dop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dop));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OnOff = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.butOkDop = new System.Windows.Forms.Button();
            this.butCancelDop = new System.Windows.Forms.Button();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.radioButton);
            this.groupBox1.Controls.Add(this.OnOff);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // OnOff
            // 
            resources.ApplyResources(this.OnOff, "OnOff");
            this.OnOff.Name = "OnOff";
            this.OnOff.UseVisualStyleBackColor = true;
            this.OnOff.CheckedChanged += new System.EventHandler(this.OnOff_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // butOkDop
            // 
            resources.ApplyResources(this.butOkDop, "butOkDop");
            this.butOkDop.Name = "butOkDop";
            this.butOkDop.UseVisualStyleBackColor = true;
            this.butOkDop.Click += new System.EventHandler(this.butOkDop_Click);
            // 
            // butCancelDop
            // 
            resources.ApplyResources(this.butCancelDop, "butCancelDop");
            this.butCancelDop.Name = "butCancelDop";
            this.butCancelDop.UseVisualStyleBackColor = true;
            this.butCancelDop.Click += new System.EventHandler(this.butCancelDop_Click);
            // 
            // radioButton
            // 
            resources.ApplyResources(this.radioButton, "radioButton");
            this.radioButton.Name = "radioButton";
            this.radioButton.TabStop = true;
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Dop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.butCancelDop);
            this.Controls.Add(this.butOkDop);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Dop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butOkDop;
        private System.Windows.Forms.Button butCancelDop;
        private System.Windows.Forms.RadioButton OnOff;
        private System.Windows.Forms.RadioButton radioButton;
    }
}