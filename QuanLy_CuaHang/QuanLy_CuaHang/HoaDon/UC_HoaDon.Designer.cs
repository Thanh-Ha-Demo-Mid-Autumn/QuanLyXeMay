﻿
namespace QuanLy_CuaHang.HoaDon
{
    partial class UC_HoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_Ctr_HDBan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tab_Ctr_HDBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Ctr_HDBan
            // 
            this.tab_Ctr_HDBan.Controls.Add(this.tabPage1);
            this.tab_Ctr_HDBan.Controls.Add(this.tabPage2);
            this.tab_Ctr_HDBan.Controls.Add(this.tabPage3);
            this.tab_Ctr_HDBan.ItemSize = new System.Drawing.Size(58, 30);
            this.tab_Ctr_HDBan.Location = new System.Drawing.Point(0, 0);
            this.tab_Ctr_HDBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_Ctr_HDBan.Name = "tab_Ctr_HDBan";
            this.tab_Ctr_HDBan.SelectedIndex = 0;
            this.tab_Ctr_HDBan.Size = new System.Drawing.Size(1341, 863);
            this.tab_Ctr_HDBan.TabIndex = 1;
            this.tab_Ctr_HDBan.Click += new System.EventHandler(this.tab_Ctr_HDBan_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1333, 825);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn bán hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1333, 825);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa đơn dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1333, 825);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phiếu nhập";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tab_Ctr_HDBan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(1341, 863);
            this.tab_Ctr_HDBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Ctr_HDBan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
