using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddInvestor : Form
    {
        public AddInvestor()
        {
            InitializeComponent();
        }

        private void AddInvestor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Investor". При необходимости она может быть перемещена или удалена.
            this.investorTableAdapter.Fill(this.bankDataBase.Investor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Tipe". При необходимости она может быть перемещена или удалена.
            this.tipeTableAdapter.Fill(this.bankDataBase.Tipe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.bankDataBase.Country);

        }

        private void add_comand_Click(object sender, EventArgs e)
        {
            BankDataBase.InvestorRow addInv = bankDataBase.Investor.NewInvestorRow();

            addInv.Company = name_add.Text;
            addInv.Country = Convert.ToInt32(Country_comboBox.SelectedValue);
            addInv.Tipe = Convert.ToInt32(type_comboBox.SelectedValue);

            bankDataBase.Investor.Rows.Add(addInv);
            investorTableAdapter.Update(bankDataBase.Investor);

            this.Close();
        }
    }
}
