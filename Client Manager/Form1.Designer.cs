
namespace Client_Manager
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
            this.dgvclients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.showclients = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.GroupBox();
            this.addclient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fninput = new System.Windows.Forms.TextBox();
            this.lninput = new System.Windows.Forms.TextBox();
            this.addressinput = new System.Windows.Forms.TextBox();
            this.cityinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bynDelete = new System.Windows.Forms.Button();
            this.modifybtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclients)).BeginInit();
            this.Operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvclients
            // 
            this.dgvclients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FName,
            this.LName,
            this.Address,
            this.City});
            this.dgvclients.Location = new System.Drawing.Point(117, 280);
            this.dgvclients.Name = "dgvclients";
            this.dgvclients.RowHeadersWidth = 51;
            this.dgvclients.RowTemplate.Height = 24;
            this.dgvclients.Size = new System.Drawing.Size(956, 309);
            this.dgvclients.TabIndex = 0;
            this.dgvclients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclients_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // FName
            // 
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            // 
            // LName
            // 
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients List";
            // 
            // showclients
            // 
            this.showclients.Location = new System.Drawing.Point(46, 35);
            this.showclients.Name = "showclients";
            this.showclients.Size = new System.Drawing.Size(119, 39);
            this.showclients.TabIndex = 2;
            this.showclients.Text = "Show Clients";
            this.showclients.UseVisualStyleBackColor = true;
            this.showclients.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operations
            // 
            this.Operations.Controls.Add(this.modifybtn);
            this.Operations.Controls.Add(this.bynDelete);
            this.Operations.Controls.Add(this.addclient);
            this.Operations.Controls.Add(this.showclients);
            this.Operations.Location = new System.Drawing.Point(766, 34);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(209, 231);
            this.Operations.TabIndex = 3;
            this.Operations.TabStop = false;
            this.Operations.Text = "Operations";
            // 
            // addclient
            // 
            this.addclient.Location = new System.Drawing.Point(46, 82);
            this.addclient.Name = "addclient";
            this.addclient.Size = new System.Drawing.Size(119, 39);
            this.addclient.TabIndex = 3;
            this.addclient.Text = "Add Client";
            this.addclient.UseVisualStyleBackColor = true;
            this.addclient.Click += new System.EventHandler(this.addclient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name :  *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name : *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "City : *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address : *";
            // 
            // fninput
            // 
            this.fninput.Location = new System.Drawing.Point(208, 34);
            this.fninput.Name = "fninput";
            this.fninput.Size = new System.Drawing.Size(161, 22);
            this.fninput.TabIndex = 9;
            // 
            // lninput
            // 
            this.lninput.Location = new System.Drawing.Point(208, 108);
            this.lninput.Name = "lninput";
            this.lninput.Size = new System.Drawing.Size(161, 22);
            this.lninput.TabIndex = 10;
            // 
            // addressinput
            // 
            this.addressinput.Location = new System.Drawing.Point(493, 34);
            this.addressinput.Name = "addressinput";
            this.addressinput.Size = new System.Drawing.Size(161, 22);
            this.addressinput.TabIndex = 11;
            // 
            // cityinput
            // 
            this.cityinput.Location = new System.Drawing.Point(493, 100);
            this.cityinput.Name = "cityinput";
            this.cityinput.Size = new System.Drawing.Size(161, 22);
            this.cityinput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "* : required fields";
            // 
            // bynDelete
            // 
            this.bynDelete.Location = new System.Drawing.Point(46, 127);
            this.bynDelete.Name = "bynDelete";
            this.bynDelete.Size = new System.Drawing.Size(119, 39);
            this.bynDelete.TabIndex = 4;
            this.bynDelete.Text = "Delete Client";
            this.bynDelete.UseVisualStyleBackColor = true;
            this.bynDelete.Click += new System.EventHandler(this.bynDelete_Click);
            // 
            // modifybtn
            // 
            this.modifybtn.Location = new System.Drawing.Point(46, 172);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(119, 39);
            this.modifybtn.TabIndex = 5;
            this.modifybtn.Text = "Modify Client";
            this.modifybtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityinput);
            this.Controls.Add(this.addressinput);
            this.Controls.Add(this.lninput);
            this.Controls.Add(this.fninput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvclients);
            this.Name = "Form1";
            this.Text = "                                  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclients)).EndInit();
            this.Operations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showclients;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.Button addclient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fninput;
        private System.Windows.Forms.TextBox lninput;
        private System.Windows.Forms.TextBox addressinput;
        private System.Windows.Forms.TextBox cityinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bynDelete;
        private System.Windows.Forms.Button modifybtn;
    }
}

