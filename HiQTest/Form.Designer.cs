
namespace HiQTest
{
    partial class form
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
            this.headingLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.roomTb = new System.Windows.Forms.TextBox();
            this.startposLbl = new System.Windows.Forms.Label();
            this.startposTb = new System.Windows.Forms.TextBox();
            this.commandTb = new System.Windows.Forms.TextBox();
            this.commandLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.roomErrorLbl = new System.Windows.Forms.Label();
            this.startposErrorLbl = new System.Windows.Forms.Label();
            this.commandErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLbl.Location = new System.Drawing.Point(9, 11);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(274, 45);
            this.headingLbl.TabIndex = 0;
            this.headingLbl.Text = "RC Cars Simulator";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Cursor = System.Windows.Forms.Cursors.No;
            this.roomLbl.Location = new System.Drawing.Point(9, 121);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(89, 25);
            this.roomLbl.TabIndex = 1;
            this.roomLbl.Text = "Roomsize";
            // 
            // roomTb
            // 
            this.roomTb.Location = new System.Drawing.Point(10, 150);
            this.roomTb.Name = "roomTb";
            this.roomTb.Size = new System.Drawing.Size(299, 31);
            this.roomTb.TabIndex = 2;
            // 
            // startposLbl
            // 
            this.startposLbl.AutoSize = true;
            this.startposLbl.Location = new System.Drawing.Point(9, 240);
            this.startposLbl.Name = "startposLbl";
            this.startposLbl.Size = new System.Drawing.Size(113, 25);
            this.startposLbl.TabIndex = 3;
            this.startposLbl.Text = "Startposition";
            // 
            // startposTb
            // 
            this.startposTb.Location = new System.Drawing.Point(9, 268);
            this.startposTb.Name = "startposTb";
            this.startposTb.Size = new System.Drawing.Size(299, 31);
            this.startposTb.TabIndex = 4;
            // 
            // commandTb
            // 
            this.commandTb.Location = new System.Drawing.Point(10, 398);
            this.commandTb.Name = "commandTb";
            this.commandTb.Size = new System.Drawing.Size(299, 31);
            this.commandTb.TabIndex = 5;
            // 
            // commandLbl
            // 
            this.commandLbl.AutoSize = true;
            this.commandLbl.Location = new System.Drawing.Point(10, 370);
            this.commandLbl.Name = "commandLbl";
            this.commandLbl.Size = new System.Drawing.Size(190, 25);
            this.commandLbl.TabIndex = 6;
            this.commandLbl.Text = "Commands to execute";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(375, 396);
            this.startBtn.Name = "startBtn";
            this.startBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startBtn.Size = new System.Drawing.Size(199, 34);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Start Simulation";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // roomErrorLbl
            // 
            this.roomErrorLbl.AutoSize = true;
            this.roomErrorLbl.Location = new System.Drawing.Point(9, 184);
            this.roomErrorLbl.Name = "roomErrorLbl";
            this.roomErrorLbl.Size = new System.Drawing.Size(0, 25);
            this.roomErrorLbl.TabIndex = 8;
            // 
            // startposErrorLbl
            // 
            this.startposErrorLbl.AutoSize = true;
            this.startposErrorLbl.Location = new System.Drawing.Point(9, 302);
            this.startposErrorLbl.Name = "startposErrorLbl";
            this.startposErrorLbl.Size = new System.Drawing.Size(0, 25);
            this.startposErrorLbl.TabIndex = 9;
            // 
            // commandErrorLbl
            // 
            this.commandErrorLbl.AutoSize = true;
            this.commandErrorLbl.Location = new System.Drawing.Point(10, 436);
            this.commandErrorLbl.Name = "commandErrorLbl";
            this.commandErrorLbl.Size = new System.Drawing.Size(0, 25);
            this.commandErrorLbl.TabIndex = 10;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.commandErrorLbl);
            this.Controls.Add(this.startposErrorLbl);
            this.Controls.Add(this.roomErrorLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.commandLbl);
            this.Controls.Add(this.commandTb);
            this.Controls.Add(this.startposTb);
            this.Controls.Add(this.startposLbl);
            this.Controls.Add(this.roomTb);
            this.Controls.Add(this.roomLbl);
            this.Controls.Add(this.headingLbl);
            this.Name = "form";
            this.Text = "RC Cars Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.TextBox roomTb;
        private System.Windows.Forms.Label roomErrorLbl;
        private System.Windows.Forms.Label startposLbl;
        private System.Windows.Forms.TextBox startposTb;
        private System.Windows.Forms.Label startposErrorLbl;
        private System.Windows.Forms.TextBox commandTb;
        private System.Windows.Forms.Label commandLbl;
        private System.Windows.Forms.Label commandErrorLbl;
        private System.Windows.Forms.Button startBtn;
    }
}

