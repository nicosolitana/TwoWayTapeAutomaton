namespace TwoWayTapeAutomaton
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTwoTape = new System.Windows.Forms.Panel();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurState = new System.Windows.Forms.Label();
            this.lblNxtState = new System.Windows.Forms.Label();
            this.lblFormaDef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Two-Way Tape Automata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input string:";
            // 
            // txtInputStr
            // 
            this.txtInputStr.Font = new System.Drawing.Font("Product Sans", 12F);
            this.txtInputStr.Location = new System.Drawing.Point(36, 119);
            this.txtInputStr.Name = "txtInputStr";
            this.txtInputStr.Size = new System.Drawing.Size(654, 32);
            this.txtInputStr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label3.Location = new System.Drawing.Point(31, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Program:";
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Product Sans", 12F);
            this.txtProgram.Location = new System.Drawing.Point(36, 195);
            this.txtProgram.Multiline = true;
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(353, 246);
            this.txtProgram.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Product Sans", 12F);
            this.btnExecute.Location = new System.Drawing.Point(166, 610);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 41);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Product Sans", 12F);
            this.btnClear.Location = new System.Drawing.Point(528, 610);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 41);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label4.Location = new System.Drawing.Point(32, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Two-Way Tape Accepter";
            // 
            // pnlTwoTape
            // 
            this.pnlTwoTape.AutoScroll = true;
            this.pnlTwoTape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTwoTape.Location = new System.Drawing.Point(36, 490);
            this.pnlTwoTape.Name = "pnlTwoTape";
            this.pnlTwoTape.Size = new System.Drawing.Size(654, 98);
            this.pnlTwoTape.TabIndex = 8;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Font = new System.Drawing.Font("Product Sans", 12F);
            this.btnSimulate.Location = new System.Drawing.Point(347, 610);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(162, 41);
            this.btnSimulate.TabIndex = 9;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label5.Location = new System.Drawing.Point(402, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Formal Definition:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label6.Location = new System.Drawing.Point(402, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Previous State: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label7.Location = new System.Drawing.Point(402, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current State:";
            // 
            // lblCurState
            // 
            this.lblCurState.AutoSize = true;
            this.lblCurState.Font = new System.Drawing.Font("Product Sans", 12F);
            this.lblCurState.Location = new System.Drawing.Point(550, 388);
            this.lblCurState.Name = "lblCurState";
            this.lblCurState.Size = new System.Drawing.Size(16, 25);
            this.lblCurState.TabIndex = 14;
            this.lblCurState.Text = " ";
            // 
            // lblNxtState
            // 
            this.lblNxtState.AutoSize = true;
            this.lblNxtState.Font = new System.Drawing.Font("Product Sans", 12F);
            this.lblNxtState.Location = new System.Drawing.Point(550, 422);
            this.lblNxtState.Name = "lblNxtState";
            this.lblNxtState.Size = new System.Drawing.Size(16, 25);
            this.lblNxtState.TabIndex = 15;
            this.lblNxtState.Text = " ";
            // 
            // lblFormaDef
            // 
            this.lblFormaDef.AutoSize = true;
            this.lblFormaDef.Font = new System.Drawing.Font("Product Sans", 12F);
            this.lblFormaDef.Location = new System.Drawing.Point(402, 198);
            this.lblFormaDef.Name = "lblFormaDef";
            this.lblFormaDef.Size = new System.Drawing.Size(16, 25);
            this.lblFormaDef.TabIndex = 16;
            this.lblFormaDef.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 699);
            this.Controls.Add(this.lblFormaDef);
            this.Controls.Add(this.lblNxtState);
            this.Controls.Add(this.lblCurState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.pnlTwoTape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 746);
            this.MinimumSize = new System.Drawing.Size(621, 746);
            this.Name = "MainForm";
            this.Text = "Two-Way Tape Automata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTwoTape;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurState;
        private System.Windows.Forms.Label lblNxtState;
        private System.Windows.Forms.Label lblFormaDef;
    }
}

