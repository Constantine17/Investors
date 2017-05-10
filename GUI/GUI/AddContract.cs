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
    public partial class AddContract : Form
    {
        public AddContract()
        {
            InitializeComponent();
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.bankDataBase.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Form". При необходимости она может быть перемещена или удалена.
            this.formTableAdapter.Fill(this.bankDataBase.Form);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Menager". При необходимости она может быть перемещена или удалена.
            this.menagerTableAdapter.Fill(this.bankDataBase.Menager);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.bankDataBase.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Investor". При необходимости она может быть перемещена или удалена.
            this.investorTableAdapter.Fill(this.bankDataBase.Investor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataBase.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.bankDataBase.Contract);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_comand_Click(object sender, EventArgs e)
        {
            BankDataBase.ContractRow addCont = bankDataBase.Contract.NewContractRow();
            addCont.Investor = 14;
            addCont.Client = 1;
            addCont.Maneger = 1;
            addCont.Form = 3;
            addCont.Status = 1;
            addCont.Name_contract = "empty";
            bankDataBase.Contract.Rows.Add(addCont);
            this.Close();

        }
    }
}
