﻿namespace jogodavelha {
  partial class jogodavelha {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMsg = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(142, 76);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 80);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(264, 76);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 80);
      this.button2.TabIndex = 1;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(389, 76);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 80);
      this.button3.TabIndex = 2;
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(142, 196);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 80);
      this.button4.TabIndex = 3;
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(264, 196);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 80);
      this.button5.TabIndex = 4;
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(389, 196);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 80);
      this.button6.TabIndex = 5;
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(142, 312);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(75, 80);
      this.button7.TabIndex = 6;
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(264, 312);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(75, 80);
      this.button8.TabIndex = 7;
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(389, 312);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(75, 80);
      this.button9.TabIndex = 8;
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 20 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(142, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(135, 32);
      this.label1.TabIndex = 9;
      this.label1.Text = "Mensagem";
      // 
      // txtMsg
      // 
      this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMsg.Location = new System.Drawing.Point(284, 28);
      this.txtMsg.Name = "txtMsg";
      this.txtMsg.Size = new System.Drawing.Size(347, 30);
      this.txtMsg.TabIndex = 10;
      // 
      // jogodavelha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6 F, 13 F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtMsg);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "jogodavelha";
      this.Text = "Jogo da velha";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMsg;
  }
}