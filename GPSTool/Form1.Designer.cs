namespace GPSTool {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainerBasis = new System.Windows.Forms.SplitContainer();
            this.tabControlBasis = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelLocal = new System.Windows.Forms.Panel();
            this.panelDevice = new System.Windows.Forms.Panel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tableLayoutPanelleft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasis)).BeginInit();
            this.splitContainerBasis.Panel1.SuspendLayout();
            this.splitContainerBasis.SuspendLayout();
            this.tabControlBasis.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelLocal.SuspendLayout();
            this.panelDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBasis
            // 
            this.splitContainerBasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBasis.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerBasis.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBasis.Name = "splitContainerBasis";
            this.splitContainerBasis.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBasis.Panel1
            // 
            this.splitContainerBasis.Panel1.Controls.Add(this.tabControlBasis);
            this.splitContainerBasis.Size = new System.Drawing.Size(765, 483);
            this.splitContainerBasis.SplitterDistance = 443;
            this.splitContainerBasis.TabIndex = 0;
            // 
            // tabControlBasis
            // 
            this.tabControlBasis.Controls.Add(this.tabPage1);
            this.tabControlBasis.Controls.Add(this.tabPage2);
            this.tabControlBasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBasis.Location = new System.Drawing.Point(0, 0);
            this.tabControlBasis.Name = "tabControlBasis";
            this.tabControlBasis.SelectedIndex = 0;
            this.tabControlBasis.Size = new System.Drawing.Size(765, 443);
            this.tabControlBasis.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMap);
            this.tabPage1.Controls.Add(this.panelDevice);
            this.tabPage1.Controls.Add(this.panelLocal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelLocal
            // 
            this.panelLocal.Controls.Add(this.tableLayoutPanelleft);
            this.panelLocal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLocal.Location = new System.Drawing.Point(3, 3);
            this.panelLocal.Name = "panelLocal";
            this.panelLocal.Size = new System.Drawing.Size(200, 411);
            this.panelLocal.TabIndex = 0;
            // 
            // panelDevice
            // 
            this.panelDevice.Controls.Add(this.tableLayoutPanelRight);
            this.panelDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDevice.Location = new System.Drawing.Point(554, 3);
            this.panelDevice.Name = "panelDevice";
            this.panelDevice.Size = new System.Drawing.Size(200, 411);
            this.panelDevice.TabIndex = 1;
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(203, 3);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(351, 411);
            this.panelMap.TabIndex = 2;
            // 
            // tableLayoutPanelleft
            // 
            this.tableLayoutPanelleft.ColumnCount = 1;
            this.tableLayoutPanelleft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelleft.Location = new System.Drawing.Point(5, 30);
            this.tableLayoutPanelleft.Name = "tableLayoutPanelleft";
            this.tableLayoutPanelleft.RowCount = 2;
            this.tableLayoutPanelleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelleft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelleft.Size = new System.Drawing.Size(175, 100);
            this.tableLayoutPanelleft.TabIndex = 0;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(19, 30);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 2;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(161, 100);
            this.tableLayoutPanelRight.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 483);
            this.Controls.Add(this.splitContainerBasis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerBasis.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasis)).EndInit();
            this.splitContainerBasis.ResumeLayout(false);
            this.tabControlBasis.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelLocal.ResumeLayout(false);
            this.panelDevice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBasis;
        private System.Windows.Forms.TabControl tabControlBasis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Panel panelDevice;
        private System.Windows.Forms.Panel panelLocal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelleft;
    }
}

