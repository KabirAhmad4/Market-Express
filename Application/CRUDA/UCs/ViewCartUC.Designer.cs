namespace CRUDA.UCs
{
    partial class ViewCartUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCartUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordSignal = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ConfirmOrderBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1126, 279);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 372);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.76191F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1132, 30);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(455, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(220, 24);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblRecordSignal
            // 
            this.lblRecordSignal.AutoSize = true;
            this.lblRecordSignal.Location = new System.Drawing.Point(568, 463);
            this.lblRecordSignal.Name = "lblRecordSignal";
            this.lblRecordSignal.Size = new System.Drawing.Size(10, 13);
            this.lblRecordSignal.TabIndex = 33;
            this.lblRecordSignal.Text = " ";
            // 
            // lblSignUp
            // 
            this.lblSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSignUp.Location = new System.Drawing.Point(508, 8);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(116, 24);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Cart Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.19646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 405);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblSignUp, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1132, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ConfirmOrderBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.12658F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.87342F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1132, 316);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.tableLayoutPanel1);
            this.gbx.Controls.Add(this.lblRecordSignal);
            this.gbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx.Location = new System.Drawing.Point(0, 0);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(1144, 424);
            this.gbx.TabIndex = 7;
            this.gbx.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // ConfirmOrderBtn
            // 
            this.ConfirmOrderBtn.AllowAnimations = true;
            this.ConfirmOrderBtn.AllowMouseEffects = true;
            this.ConfirmOrderBtn.AllowToggling = false;
            this.ConfirmOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfirmOrderBtn.AnimationSpeed = 200;
            this.ConfirmOrderBtn.AutoGenerateColors = false;
            this.ConfirmOrderBtn.AutoRoundBorders = false;
            this.ConfirmOrderBtn.AutoSizeLeftIcon = true;
            this.ConfirmOrderBtn.AutoSizeRightIcon = true;
            this.ConfirmOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmOrderBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ConfirmOrderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmOrderBtn.BackgroundImage")));
            this.ConfirmOrderBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ConfirmOrderBtn.ButtonText = "Confirm Order";
            this.ConfirmOrderBtn.ButtonTextMarginLeft = 0;
            this.ConfirmOrderBtn.ColorContrastOnClick = 45;
            this.ConfirmOrderBtn.ColorContrastOnHover = 45;
            this.ConfirmOrderBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ConfirmOrderBtn.CustomizableEdges = borderEdges1;
            this.ConfirmOrderBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConfirmOrderBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ConfirmOrderBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ConfirmOrderBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ConfirmOrderBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ConfirmOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmOrderBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmOrderBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmOrderBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmOrderBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ConfirmOrderBtn.IconMarginLeft = 11;
            this.ConfirmOrderBtn.IconPadding = 10;
            this.ConfirmOrderBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmOrderBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmOrderBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ConfirmOrderBtn.IconSize = 25;
            this.ConfirmOrderBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmOrderBtn.IdleBorderRadius = 1;
            this.ConfirmOrderBtn.IdleBorderThickness = 1;
            this.ConfirmOrderBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmOrderBtn.IdleIconLeftImage = null;
            this.ConfirmOrderBtn.IdleIconRightImage = null;
            this.ConfirmOrderBtn.IndicateFocus = false;
            this.ConfirmOrderBtn.Location = new System.Drawing.Point(979, 3);
            this.ConfirmOrderBtn.Name = "ConfirmOrderBtn";
            this.ConfirmOrderBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ConfirmOrderBtn.OnDisabledState.BorderRadius = 1;
            this.ConfirmOrderBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ConfirmOrderBtn.OnDisabledState.BorderThickness = 1;
            this.ConfirmOrderBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ConfirmOrderBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ConfirmOrderBtn.OnDisabledState.IconLeftImage = null;
            this.ConfirmOrderBtn.OnDisabledState.IconRightImage = null;
            this.ConfirmOrderBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ConfirmOrderBtn.onHoverState.BorderRadius = 1;
            this.ConfirmOrderBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ConfirmOrderBtn.onHoverState.BorderThickness = 1;
            this.ConfirmOrderBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ConfirmOrderBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ConfirmOrderBtn.onHoverState.IconLeftImage = null;
            this.ConfirmOrderBtn.onHoverState.IconRightImage = null;
            this.ConfirmOrderBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmOrderBtn.OnIdleState.BorderRadius = 1;
            this.ConfirmOrderBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ConfirmOrderBtn.OnIdleState.BorderThickness = 1;
            this.ConfirmOrderBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmOrderBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ConfirmOrderBtn.OnIdleState.IconLeftImage = null;
            this.ConfirmOrderBtn.OnIdleState.IconRightImage = null;
            this.ConfirmOrderBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ConfirmOrderBtn.OnPressedState.BorderRadius = 1;
            this.ConfirmOrderBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ConfirmOrderBtn.OnPressedState.BorderThickness = 1;
            this.ConfirmOrderBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ConfirmOrderBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ConfirmOrderBtn.OnPressedState.IconLeftImage = null;
            this.ConfirmOrderBtn.OnPressedState.IconRightImage = null;
            this.ConfirmOrderBtn.Size = new System.Drawing.Size(150, 25);
            this.ConfirmOrderBtn.TabIndex = 1;
            this.ConfirmOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmOrderBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmOrderBtn.TextMarginLeft = 0;
            this.ConfirmOrderBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.ConfirmOrderBtn.UseDefaultRadiusAndThickness = true;
            this.ConfirmOrderBtn.Click += new System.EventHandler(this.ConfirmOrderBtn_Click);
            // 
            // ViewCartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx);
            this.Name = "ViewCartUC";
            this.Size = new System.Drawing.Size(1144, 424);
            this.Load += new System.EventHandler(this.ViewCartUC_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordSignal;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ConfirmOrderBtn;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Timer timer1;
    }
}
