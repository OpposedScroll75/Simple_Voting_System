namespace VotingSystem
{
    public partial class Form1 : Form
    {
        float totVotes = 0;
        float VoteCh1 = 0, VoteCh2 = 0, VoteCh3 = 0, VoteCh4 = 0, VoteCh5 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                totVotes++;
                VoteCh1++;

                label2.Text = "You voted for: " + checkBox1.Text;
            }

            else if (checkBox2.Checked)
            {

                totVotes++;
                VoteCh2++;

                label2.Text = "You voted for: " + checkBox2.Text;

            }

            else if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                totVotes++;
                VoteCh3++;

                label2.Text = "You voted for: " + checkBox3.Text;
            }

            else if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;

                totVotes++;
                VoteCh4++;

                label2.Text = "You voted for: " + checkBox4.Text;
            }

            else if (checkBox5.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

                totVotes++;
                VoteCh5++;

                label2.Text = "You voted for: " + checkBox5.Text;
            }
            else
            {
                MessageBox.Show("Please make a choice before submitting");
            }

            if(totVotes == 10)
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                button1.Visible = false;

                if(VoteCh1 > VoteCh2
                    && VoteCh1 > VoteCh3 
                    && VoteCh1 > VoteCh4 
                    && VoteCh1 > VoteCh5)
                {
                    label2.Text = checkBox1.Text + " won with " + VoteCh1.ToString() + " votes!";
                }

                if (VoteCh2 > VoteCh1
                   && VoteCh2 > VoteCh3
                   && VoteCh2 > VoteCh4
                   && VoteCh2 > VoteCh5)
                {
                    label2.Text = checkBox2.Text + " won with " + VoteCh2.ToString() + " votes!";
                }

                if (VoteCh3 > VoteCh1
                  && VoteCh3 > VoteCh2
                  && VoteCh3 > VoteCh4
                  && VoteCh3 > VoteCh5)
                {
                    label2.Text = checkBox3.Text + " won with " + VoteCh3.ToString() + " votes!";
                }

              if (VoteCh4 > VoteCh1
               && VoteCh4 > VoteCh2
               && VoteCh4 > VoteCh3
               && VoteCh4 > VoteCh5)
                {
                    label2.Text = checkBox4.Text + " won with " + VoteCh4.ToString() + " votes!";
                }

              if (VoteCh5 > VoteCh1
                && VoteCh5 > VoteCh2
                && VoteCh5 > VoteCh3
                && VoteCh5 > VoteCh4)
                {
                    label2.Text = checkBox5.Text + " won with " + VoteCh5.ToString() + " votes!";
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
