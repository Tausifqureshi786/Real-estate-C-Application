
namespace RealEstate__App
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGetAddress = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.imageOpenFIleDialog = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BrokerBox = new System.Windows.Forms.GroupBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.AddPropertyBox = new System.Windows.Forms.GroupBox();
            this.txtNoOfBed = new System.Windows.Forms.TextBox();
            this.txtNoOfBath = new System.Windows.Forms.TextBox();
            this.txtSqFt = new System.Windows.Forms.TextBox();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.txtNeighbourhood = new System.Windows.Forms.TextBox();
            this.txtPropType = new System.Windows.Forms.TextBox();
            this.txtPropId = new System.Windows.Forms.TextBox();
            this.txtPropName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.BrokerBox.SuspendLayout();
            this.AddPropertyBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(378, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 72);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnGetAddress
            // 
            this.btnGetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAddress.Location = new System.Drawing.Point(674, 100);
            this.btnGetAddress.Name = "btnGetAddress";
            this.btnGetAddress.Size = new System.Drawing.Size(175, 41);
            this.btnGetAddress.TabIndex = 27;
            this.btnGetAddress.Text = "Get Address";
            this.btnGetAddress.UseVisualStyleBackColor = true;
            this.btnGetAddress.Click += new System.EventHandler(this.btnGetAddress_Click);
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(492, 17);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(195, 34);
            this.txtImage.TabIndex = 5;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(721, 25);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(140, 41);
            this.btnAddImage.TabIndex = 10;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(387, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 29);
            this.label16.TabIndex = 26;
            this.label16.Text = "Image2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Image1:";
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPropertyButton.Location = new System.Drawing.Point(258, 367);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(239, 41);
            this.addPropertyButton.TabIndex = 9;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // txtLon
            // 
            this.txtLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLon.Location = new System.Drawing.Point(532, 224);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(185, 34);
            this.txtLon.TabIndex = 24;
            // 
            // txtLat
            // 
            this.txtLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(523, 178);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(124, 34);
            this.txtLat.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(387, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 29);
            this.label14.TabIndex = 21;
            this.label14.Text = "Latitude: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(120, 319);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(592, 34);
            this.txtAddress.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(167, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Property";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1077, 41);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 41);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // imageOpenFIleDialog
            // 
            this.imageOpenFIleDialog.FileName = "openFileDialog1";
            this.imageOpenFIleDialog.Filter = "\"Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp\"";
            this.imageOpenFIleDialog.Multiselect = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(387, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 29);
            this.label15.TabIndex = 22;
            this.label15.Text = "Longitude:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "Address:";
            // 
            // BrokerBox
            // 
            this.BrokerBox.Controls.Add(this.gMap);
            this.BrokerBox.Controls.Add(this.AddPropertyBox);
            this.BrokerBox.Controls.Add(this.btnAdd);
            this.BrokerBox.Location = new System.Drawing.Point(18, 112);
            this.BrokerBox.Name = "BrokerBox";
            this.BrokerBox.Size = new System.Drawing.Size(1275, 502);
            this.BrokerBox.TabIndex = 14;
            this.BrokerBox.TabStop = false;
            this.BrokerBox.Text = "groupBox1";
            this.BrokerBox.Enter += new System.EventHandler(this.BrokerBox_Enter);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(895, 78);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(368, 403);
            this.gMap.TabIndex = 2;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // AddPropertyBox
            // 
            this.AddPropertyBox.Controls.Add(this.richTextBox1);
            this.AddPropertyBox.Controls.Add(this.btnGetAddress);
            this.AddPropertyBox.Controls.Add(this.txtImage);
            this.AddPropertyBox.Controls.Add(this.btnAddImage);
            this.AddPropertyBox.Controls.Add(this.label16);
            this.AddPropertyBox.Controls.Add(this.label8);
            this.AddPropertyBox.Controls.Add(this.addPropertyButton);
            this.AddPropertyBox.Controls.Add(this.txtLon);
            this.AddPropertyBox.Controls.Add(this.txtLat);
            this.AddPropertyBox.Controls.Add(this.label15);
            this.AddPropertyBox.Controls.Add(this.label14);
            this.AddPropertyBox.Controls.Add(this.txtAddress);
            this.AddPropertyBox.Controls.Add(this.label13);
            this.AddPropertyBox.Controls.Add(this.txtNoOfBed);
            this.AddPropertyBox.Controls.Add(this.txtNoOfBath);
            this.AddPropertyBox.Controls.Add(this.txtSqFt);
            this.AddPropertyBox.Controls.Add(this.txtListPrice);
            this.AddPropertyBox.Controls.Add(this.txtNeighbourhood);
            this.AddPropertyBox.Controls.Add(this.txtPropType);
            this.AddPropertyBox.Controls.Add(this.txtPropId);
            this.AddPropertyBox.Controls.Add(this.txtPropName);
            this.AddPropertyBox.Controls.Add(this.label12);
            this.AddPropertyBox.Controls.Add(this.label11);
            this.AddPropertyBox.Controls.Add(this.label10);
            this.AddPropertyBox.Controls.Add(this.label9);
            this.AddPropertyBox.Controls.Add(this.label7);
            this.AddPropertyBox.Controls.Add(this.label6);
            this.AddPropertyBox.Controls.Add(this.label5);
            this.AddPropertyBox.Controls.Add(this.label4);
            this.AddPropertyBox.Location = new System.Drawing.Point(6, 74);
            this.AddPropertyBox.Name = "AddPropertyBox";
            this.AddPropertyBox.Size = new System.Drawing.Size(872, 414);
            this.AddPropertyBox.TabIndex = 1;
            this.AddPropertyBox.TabStop = false;
            this.AddPropertyBox.Text = "groupBox1";
            // 
            // txtNoOfBed
            // 
            this.txtNoOfBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfBed.Location = new System.Drawing.Point(594, 273);
            this.txtNoOfBed.Name = "txtNoOfBed";
            this.txtNoOfBed.Size = new System.Drawing.Size(124, 34);
            this.txtNoOfBed.TabIndex = 18;
            // 
            // txtNoOfBath
            // 
            this.txtNoOfBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfBath.Location = new System.Drawing.Point(234, 276);
            this.txtNoOfBath.Name = "txtNoOfBath";
            this.txtNoOfBath.Size = new System.Drawing.Size(124, 34);
            this.txtNoOfBath.TabIndex = 17;
            // 
            // txtSqFt
            // 
            this.txtSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqFt.Location = new System.Drawing.Point(172, 236);
            this.txtSqFt.Name = "txtSqFt";
            this.txtSqFt.Size = new System.Drawing.Size(186, 34);
            this.txtSqFt.TabIndex = 16;
            // 
            // txtListPrice
            // 
            this.txtListPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListPrice.Location = new System.Drawing.Point(172, 191);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(186, 34);
            this.txtListPrice.TabIndex = 15;
            // 
            // txtNeighbourhood
            // 
            this.txtNeighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeighbourhood.Location = new System.Drawing.Point(211, 147);
            this.txtNeighbourhood.Name = "txtNeighbourhood";
            this.txtNeighbourhood.Size = new System.Drawing.Size(147, 34);
            this.txtNeighbourhood.TabIndex = 14;
            // 
            // txtPropType
            // 
            this.txtPropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropType.Location = new System.Drawing.Point(193, 107);
            this.txtPropType.Name = "txtPropType";
            this.txtPropType.Size = new System.Drawing.Size(165, 34);
            this.txtPropType.TabIndex = 13;
            // 
            // txtPropId
            // 
            this.txtPropId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropId.Location = new System.Drawing.Point(151, 67);
            this.txtPropId.Name = "txtPropId";
            this.txtPropId.Size = new System.Drawing.Size(189, 34);
            this.txtPropId.TabIndex = 12;
            // 
            // txtPropName
            // 
            this.txtPropName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropName.Location = new System.Drawing.Point(193, 20);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.Size = new System.Drawing.Size(147, 34);
            this.txtPropName.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(388, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 29);
            this.label12.TabIndex = 11;
            this.label12.Text = "No Of Bedrooms:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sq Footage:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "No Of Bathrooms:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Listing Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Property Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Property ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Neighbourhood:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Property Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "RealEstate App ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(194, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 66);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(461, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 34);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(167, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(147, 34);
            this.txtUsername.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(901, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 41);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 698);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.BrokerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BrokerBox.ResumeLayout(false);
            this.AddPropertyBox.ResumeLayout(false);
            this.AddPropertyBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGetAddress;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.OpenFileDialog imageOpenFIleDialog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox BrokerBox;
        private System.Windows.Forms.GroupBox AddPropertyBox;
        private System.Windows.Forms.TextBox txtNoOfBed;
        private System.Windows.Forms.TextBox txtNoOfBath;
        private System.Windows.Forms.TextBox txtSqFt;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.TextBox txtNeighbourhood;
        private System.Windows.Forms.TextBox txtPropType;
        private System.Windows.Forms.TextBox txtPropId;
        private System.Windows.Forms.TextBox txtPropName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private GMap.NET.WindowsForms.GMapControl gMap;
    }
}

