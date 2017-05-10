namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_contract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_contract
            // 
            this.Add_contract.Location = new System.Drawing.Point(12, 34);
            this.Add_contract.Name = "Add_contract";
            this.Add_contract.Size = new System.Drawing.Size(129, 23);
            this.Add_contract.TabIndex = 0;
            this.Add_contract.Text = "Новый контракт";
            this.Add_contract.UseVisualStyleBackColor = true;
            this.Add_contract.Click += new System.EventHandler(this.Add_contract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 275);
            this.Controls.Add(this.Add_contract);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_contract;
    }
}

