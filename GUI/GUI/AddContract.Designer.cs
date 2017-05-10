namespace GUI
{
    partial class AddContract
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label investorLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.investorComboBox = new System.Windows.Forms.ComboBox();
            this.investorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataBase = new GUI.BankDataBase();
            this.contractBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new GUI.BankDataBaseTableAdapters.ContractTableAdapter();
            this.investorTableAdapter = new GUI.BankDataBaseTableAdapters.InvestorTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GUI.BankDataBaseTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new GUI.BankDataBaseTableAdapters.TableAdapterManager();
            this.formTableAdapter = new GUI.BankDataBaseTableAdapters.FormTableAdapter();
            this.menagerTableAdapter = new GUI.BankDataBaseTableAdapters.MenagerTableAdapter();
            this.statusTableAdapter = new GUI.BankDataBaseTableAdapters.StatusTableAdapter();
            this.contractBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.manegerComboBox = new System.Windows.Forms.ComboBox();
            this.menagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formComboBox = new System.Windows.Forms.ComboBox();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_comand = new System.Windows.Forms.Button();
            this.name_add = new System.Windows.Forms.TextBox();
            investorLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.investorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // investorLabel
            // 
            investorLabel.AutoSize = true;
            investorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            investorLabel.Location = new System.Drawing.Point(17, 20);
            investorLabel.Name = "investorLabel";
            investorLabel.Size = new System.Drawing.Size(67, 16);
            investorLabel.TabIndex = 1;
            investorLabel.Text = "Investor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(32, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 16);
            label1.TabIndex = 3;
            label1.Text = "Client:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(11, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 16);
            label2.TabIndex = 5;
            label2.Text = "Maneger:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(37, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 16);
            label3.TabIndex = 7;
            label3.Text = "Form:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(29, 128);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 16);
            label4.TabIndex = 9;
            label4.Text = "Status:";
            // 
            // investorComboBox
            // 
            this.investorComboBox.DataSource = this.investorBindingSource;
            this.investorComboBox.DisplayMember = "Company";
            this.investorComboBox.FormattingEnabled = true;
            this.investorComboBox.Location = new System.Drawing.Point(92, 19);
            this.investorComboBox.Name = "investorComboBox";
            this.investorComboBox.Size = new System.Drawing.Size(121, 21);
            this.investorComboBox.TabIndex = 2;
            this.investorComboBox.ValueMember = "id";
            // 
            // investorBindingSource
            // 
            this.investorBindingSource.DataMember = "Investor";
            this.investorBindingSource.DataSource = this.bankDataBase;
            // 
            // bankDataBase
            // 
            this.bankDataBase.DataSetName = "BankDataBase";
            this.bankDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataBaseBindingSource
            // 
            this.bankDataBaseBindingSource.DataSource = this.bankDataBase;
            this.bankDataBaseBindingSource.Position = 0;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.bankDataBaseBindingSource;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // investorTableAdapter
            // 
            this.investorTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bankDataBase;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.FormTableAdapter = this.formTableAdapter;
            this.tableAdapterManager.InvestorTableAdapter = this.investorTableAdapter;
            this.tableAdapterManager.MenagerTableAdapter = this.menagerTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TipeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.BankDataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formTableAdapter
            // 
            this.formTableAdapter.ClearBeforeFill = true;
            // 
            // menagerTableAdapter
            // 
            this.menagerTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // contractBindingSource1
            // 
            this.contractBindingSource1.DataMember = "ClientContract";
            this.contractBindingSource1.DataSource = this.clientBindingSource;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.bankDataBase;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource2;
            this.clientComboBox.DisplayMember = "Name";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(92, 46);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(121, 21);
            this.clientComboBox.TabIndex = 4;
            this.clientComboBox.ValueMember = "id";
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "Client";
            this.clientBindingSource2.DataSource = this.bankDataBase;
            // 
            // manegerComboBox
            // 
            this.manegerComboBox.DataSource = this.menagerBindingSource;
            this.manegerComboBox.DisplayMember = "Name";
            this.manegerComboBox.FormattingEnabled = true;
            this.manegerComboBox.Location = new System.Drawing.Point(92, 73);
            this.manegerComboBox.Name = "manegerComboBox";
            this.manegerComboBox.Size = new System.Drawing.Size(121, 21);
            this.manegerComboBox.TabIndex = 6;
            this.manegerComboBox.ValueMember = "id";
            // 
            // menagerBindingSource
            // 
            this.menagerBindingSource.DataMember = "Menager";
            this.menagerBindingSource.DataSource = this.bankDataBase;
            // 
            // formComboBox
            // 
            this.formComboBox.DataSource = this.formBindingSource;
            this.formComboBox.DisplayMember = "Name_Form";
            this.formComboBox.FormattingEnabled = true;
            this.formComboBox.Location = new System.Drawing.Point(92, 100);
            this.formComboBox.Name = "formComboBox";
            this.formComboBox.Size = new System.Drawing.Size(121, 21);
            this.formComboBox.TabIndex = 8;
            this.formComboBox.ValueMember = "id";
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataMember = "Form";
            this.formBindingSource.DataSource = this.bankDataBase;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataSource = this.statusBindingSource;
            this.statusComboBox.DisplayMember = "State";
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(92, 127);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 10;
            this.statusComboBox.ValueMember = "id";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.bankDataBase;
            // 
            // add_comand
            // 
            this.add_comand.Location = new System.Drawing.Point(92, 194);
            this.add_comand.Name = "add_comand";
            this.add_comand.Size = new System.Drawing.Size(75, 23);
            this.add_comand.TabIndex = 11;
            this.add_comand.Text = "ADD";
            this.add_comand.UseVisualStyleBackColor = true;
            this.add_comand.Click += new System.EventHandler(this.add_comand_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(30, 156);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 16);
            label5.TabIndex = 12;
            label5.Text = "Name:";
            // 
            // name_add
            // 
            this.name_add.Location = new System.Drawing.Point(92, 155);
            this.name_add.Name = "name_add";
            this.name_add.Size = new System.Drawing.Size(121, 20);
            this.name_add.TabIndex = 13;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 220);
            this.Controls.Add(this.name_add);
            this.Controls.Add(label5);
            this.Controls.Add(this.add_comand);
            this.Controls.Add(label4);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.formComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.manegerComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(investorLabel);
            this.Controls.Add(this.investorComboBox);
            this.Name = "AddContract";
            this.Text = "AddContract";
            this.Load += new System.EventHandler(this.AddContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.investorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox investorComboBox;
        private System.Windows.Forms.BindingSource contractBindingSource3;
        private System.Windows.Forms.BindingSource bankDataBaseBindingSource;
        private BankDataBase bankDataBase;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private BankDataBaseTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.BindingSource investorBindingSource;
        private BankDataBaseTableAdapters.InvestorTableAdapter investorTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BankDataBaseTableAdapters.ClientTableAdapter clientTableAdapter;
        private BankDataBaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource contractBindingSource1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private BankDataBaseTableAdapters.MenagerTableAdapter menagerTableAdapter;
        private System.Windows.Forms.ComboBox manegerComboBox;
        private System.Windows.Forms.BindingSource menagerBindingSource;
        private System.Windows.Forms.ComboBox formComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private BankDataBaseTableAdapters.FormTableAdapter formTableAdapter;
        private System.Windows.Forms.BindingSource formBindingSource;
        private BankDataBaseTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Button add_comand;
        private System.Windows.Forms.TextBox name_add;
    }
}