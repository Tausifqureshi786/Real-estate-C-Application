
namespace RealEstate__App
{
    partial class AgentForm
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
            this.btnLogoutAgent = new System.Windows.Forms.Button();
            this.btnViewProperty = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProperty = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnSellProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogoutAgent
            // 
            this.btnLogoutAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutAgent.Location = new System.Drawing.Point(646, 12);
            this.btnLogoutAgent.Name = "btnLogoutAgent";
            this.btnLogoutAgent.Size = new System.Drawing.Size(115, 41);
            this.btnLogoutAgent.TabIndex = 16;
            this.btnLogoutAgent.Text = "Logout";
            this.btnLogoutAgent.UseVisualStyleBackColor = true;
            this.btnLogoutAgent.Click += new System.EventHandler(this.btnLogoutAgent_Click);
            // 
            // btnViewProperty
            // 
            this.btnViewProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProperty.Location = new System.Drawing.Point(12, 103);
            this.btnViewProperty.Name = "btnViewProperty";
            this.btnViewProperty.Size = new System.Drawing.Size(192, 41);
            this.btnViewProperty.TabIndex = 17;
            this.btnViewProperty.Text = "All Properties";
            this.btnViewProperty.UseVisualStyleBackColor = true;
            this.btnViewProperty.Click += new System.EventHandler(this.btnViewProperty_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 287);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnProperty
            // 
            this.btnProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperty.Location = new System.Drawing.Point(12, 172);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(192, 41);
            this.btnProperty.TabIndex = 19;
            this.btnProperty.Text = "View Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.dataGridView1);
            this.menuPanel.Location = new System.Drawing.Point(261, 89);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1099, 520);
            this.menuPanel.TabIndex = 20;
            // 
            // btnSellProperty
            // 
            this.btnSellProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellProperty.Location = new System.Drawing.Point(12, 238);
            this.btnSellProperty.Name = "btnSellProperty";
            this.btnSellProperty.Size = new System.Drawing.Size(192, 41);
            this.btnSellProperty.TabIndex = 21;
            this.btnSellProperty.Text = "Sell Property ";
            this.btnSellProperty.UseVisualStyleBackColor = true;
            this.btnSellProperty.Click += new System.EventHandler(this.btnSellProperty_Click);
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 641);
            this.Controls.Add(this.btnSellProperty);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnViewProperty);
            this.Controls.Add(this.btnLogoutAgent);
            this.Name = "AgentForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogoutAgent;
        private System.Windows.Forms.Button btnViewProperty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnSellProperty;
    }
}