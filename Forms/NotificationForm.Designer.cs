namespace CRUDA.Forms
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductRview_lbl = new System.Windows.Forms.Label();
            this.review_txt = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.okBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.12925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.87075F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.96227F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.03773F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(246, 59);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Review";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ProductRview_lbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.review_txt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.okBtn, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.7513F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.2487F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 212);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // ProductRview_lbl
            // 
            this.ProductRview_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductRview_lbl.AutoSize = true;
            this.ProductRview_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductRview_lbl.Location = new System.Drawing.Point(16, 25);
            this.ProductRview_lbl.Name = "ProductRview_lbl";
            this.ProductRview_lbl.Size = new System.Drawing.Size(213, 16);
            this.ProductRview_lbl.TabIndex = 0;
            this.ProductRview_lbl.Text = "You are Writing the review of Porduct";
            this.ProductRview_lbl.Click += new System.EventHandler(this.ProductRview_lbl_Click);
            // 
            // review_txt
            // 
            this.review_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.review_txt.Location = new System.Drawing.Point(3, 69);
            this.review_txt.Name = "review_txt";
            this.review_txt.Size = new System.Drawing.Size(240, 113);
            this.review_txt.TabIndex = 1;
            this.review_txt.Tag = "";
            this.review_txt.Text = "";
            this.review_txt.TextChanged += new System.EventHandler(this.review_txt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CRUDA.Properties.Resources.icons8_review_40;
            this.pictureBox1.Location = new System.Drawing.Point(184, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // okBtn
            // 
            this.okBtn.AllowAnimations = true;
            this.okBtn.AllowMouseEffects = true;
            this.okBtn.AllowToggling = false;
            this.okBtn.AnimationSpeed = 200;
            this.okBtn.AutoGenerateColors = false;
            this.okBtn.AutoRoundBorders = false;
            this.okBtn.AutoSizeLeftIcon = true;
            this.okBtn.AutoSizeRightIcon = true;
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.okBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okBtn.BackgroundImage")));
            this.okBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.ButtonText = "Add Review";
            this.okBtn.ButtonTextMarginLeft = 0;
            this.okBtn.ColorContrastOnClick = 45;
            this.okBtn.ColorContrastOnHover = 45;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.okBtn.CustomizableEdges = borderEdges1;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.okBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.okBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.okBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.okBtn.IconMarginLeft = 11;
            this.okBtn.IconPadding = 10;
            this.okBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.okBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.okBtn.IconSize = 25;
            this.okBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.okBtn.IdleBorderRadius = 1;
            this.okBtn.IdleBorderThickness = 1;
            this.okBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.okBtn.IdleIconLeftImage = null;
            this.okBtn.IdleIconRightImage = null;
            this.okBtn.IndicateFocus = false;
            this.okBtn.Location = new System.Drawing.Point(3, 188);
            this.okBtn.Name = "okBtn";
            this.okBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.okBtn.OnDisabledState.BorderRadius = 1;
            this.okBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.OnDisabledState.BorderThickness = 1;
            this.okBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.okBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.okBtn.OnDisabledState.IconLeftImage = null;
            this.okBtn.OnDisabledState.IconRightImage = null;
            this.okBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.okBtn.onHoverState.BorderRadius = 1;
            this.okBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.onHoverState.BorderThickness = 1;
            this.okBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.okBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.okBtn.onHoverState.IconLeftImage = null;
            this.okBtn.onHoverState.IconRightImage = null;
            this.okBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.okBtn.OnIdleState.BorderRadius = 1;
            this.okBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.OnIdleState.BorderThickness = 1;
            this.okBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.okBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.okBtn.OnIdleState.IconLeftImage = null;
            this.okBtn.OnIdleState.IconRightImage = null;
            this.okBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.okBtn.OnPressedState.BorderRadius = 1;
            this.okBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.OnPressedState.BorderThickness = 1;
            this.okBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.okBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.okBtn.OnPressedState.IconLeftImage = null;
            this.okBtn.OnPressedState.IconRightImage = null;
            this.okBtn.Size = new System.Drawing.Size(240, 21);
            this.okBtn.TabIndex = 2;
            this.okBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.okBtn.TextMarginLeft = 0;
            this.okBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.okBtn.UseDefaultRadiusAndThickness = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationForm";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ProductRview_lbl;
        private System.Windows.Forms.RichTextBox review_txt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton okBtn;
    }
}