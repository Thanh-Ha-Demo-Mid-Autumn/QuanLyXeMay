﻿
namespace QuanLy_CuaHang
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaXN = new Guna.UI.WinForms.GunaTextBox();
            this.btnConf = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(97, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(267, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mã xác nhận sẽ gửi tới mail bạn.";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(30, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(115, 25);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mã xác nhận:";
            // 
            // txtMaXN
            // 
            this.txtMaXN.BackColor = System.Drawing.Color.Transparent;
            this.txtMaXN.BaseColor = System.Drawing.Color.White;
            this.txtMaXN.BorderColor = System.Drawing.Color.Silver;
            this.txtMaXN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaXN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaXN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaXN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaXN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaXN.Location = new System.Drawing.Point(35, 126);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.PasswordChar = '\0';
            this.txtMaXN.Radius = 20;
            this.txtMaXN.Size = new System.Drawing.Size(379, 45);
            this.txtMaXN.TabIndex = 4;
            // 
            // btnConf
            // 
            this.btnConf.AnimationHoverSpeed = 0.07F;
            this.btnConf.AnimationSpeed = 0.03F;
            this.btnConf.BackColor = System.Drawing.Color.Transparent;
            this.btnConf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnConf.BorderColor = System.Drawing.Color.Black;
            this.btnConf.FocusedColor = System.Drawing.Color.Empty;
            this.btnConf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Image = ((System.Drawing.Image)(resources.GetObject("btnConf.Image")));
            this.btnConf.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConf.Location = new System.Drawing.Point(132, 203);
            this.btnConf.Name = "btnConf";
            this.btnConf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConf.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConf.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConf.OnHoverImage = null;
            this.btnConf.OnPressedColor = System.Drawing.Color.Black;
            this.btnConf.Radius = 20;
            this.btnConf.Size = new System.Drawing.Size(160, 50);
            this.btnConf.TabIndex = 7;
            this.btnConf.Text = "Cập Nhật";
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.txtMaXN);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "ForgetPass";
            this.Text = "ForgetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtMaXN;
        private Guna.UI.WinForms.GunaButton btnConf;
    }
}