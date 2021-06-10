
namespace RealEstate__App
{
    partial class UserControlViewProperty
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
            this.label2 = new System.Windows.Forms.Label();
            this.filterComboBx = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfilterValue = new System.Windows.Forms.TextBox();
            this.propGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.propGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "View Property";
            // 
            // filterComboBx
            // 
            this.filterComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBx.FormattingEnabled = true;
            this.filterComboBx.Items.AddRange(new object[] {
            "Select to Filter Property:",
            "Property Type",
            "No Of Bathrooms",
            "No Of Bedrooms",
            "Square footage",
            "Price",
            "Neighbourhood"});
            this.filterComboBx.Location = new System.Drawing.Point(123, 64);
            this.filterComboBx.Name = "filterComboBx";
            this.filterComboBx.Size = new System.Drawing.Size(237, 37);
            this.filterComboBx.TabIndex = 3;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(23, 64);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(68, 29);
            this.filterLabel.TabIndex = 4;
            this.filterLabel.Text = "Filter";
            this.filterLabel.Click += new System.EventHandler(this.filterLabel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(409, 61);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 41);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Filter Property";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter Value";
            // 
            // txtfilterValue
            // 
            this.txtfilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilterValue.Location = new System.Drawing.Point(165, 114);
            this.txtfilterValue.Name = "txtfilterValue";
            this.txtfilterValue.Size = new System.Drawing.Size(195, 34);
            this.txtfilterValue.TabIndex = 15;
            // 
            // propGridView
            // 
            this.propGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propGridView.Location = new System.Drawing.Point(17, 178);
            this.propGridView.Name = "propGridView";
            this.propGridView.RowHeadersWidth = 51;
            this.propGridView.RowTemplate.Height = 24;
            this.propGridView.Size = new System.Drawing.Size(575, 221);
            this.propGridView.TabIndex = 19;
            // 
            // UserControlViewProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propGridView);
            this.Controls.Add(this.txtfilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterComboBx);
            this.Controls.Add(this.label2);
            this.Name = "UserControlViewProperty";
            this.Size = new System.Drawing.Size(631, 527);
            this.Load += new System.EventHandler(this.UserControlViewProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterComboBx;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfilterValue;
        private System.Windows.Forms.DataGridView propGridView;
    }
}
