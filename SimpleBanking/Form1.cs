namespace SimpleBanking
{
    public partial class Form1 : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account currentAccount;

        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            currentAccount = new Account(firstTB.Text, lastTB.Text, chequingBtn.Checked);
            accounts.Add(currentAccount);
            accountsLB.Items.Add(currentAccount);

            statusLbl.Text = "Account Created";
            statusStrip1.BackColor = Color.Green;
            accountsLB.SelectedIndex = 0;
            RefreshStatus();
        }

        private void accountsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RefreshStatus())
            {
                statusLbl.Text = "Account Selected";
                statusStrip1.BackColor = Color.Green;
            }
        }

        private bool RefreshStatus()
        {
            if (accountsLB.SelectedIndex != -1)
            {
                currentAccount = accountsLB.SelectedItem as Account;
                balanceTB.Text = currentAccount.Balance.ToString();
                overdraftTB.Text = currentAccount.OverdraftFee().ToString();
                interestTB.Text = currentAccount.InterestEarned().ToString();
                return true;
            }
            return false;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            bool result = currentAccount.Deposit(transactionNUD.Value);

            if (result)
            {
                statusLbl.Text = "Deposit Successful";
                statusStrip1.BackColor = Color.Green;
            }
            else
            {
                statusLbl.Text = "Deposit Failed";
                statusStrip1.BackColor = Color.Red;
            }
            RefreshStatus();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            bool result = currentAccount.Withdraw(transactionNUD.Value);

            if (result)
            {
                statusLbl.Text = "Withdrawal Successful";
                statusStrip1.BackColor = Color.Green;
            }
            else
            {
                statusLbl.Text = "Withdrawal Failed";
                statusStrip1.BackColor = Color.Red;
            }
            RefreshStatus();
        }
    }
}