namespace Passport_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            txt_series.Clear();
            txt_fin.Clear();
            txt_username.Clear();
            txt_name.Clear();
            txt_dad_name.Clear();
            txt_sex.Clear();
            txt_birthday.Clear();
            txt_place_of_birth.Clear();
            txt_family_situation.Clear();
            txt_givedate.Clear();
            txt_reliability.Clear();
            txt_Issuing_organ.Clear();
        }

        private void txt_series_TextChanged(object sender, EventArgs e)
        {
            lbl_series.Text = txt_series.Text;
        }
        private void txt_fin_TextChanged(object sender, EventArgs e)
        {
            lbl_fin.Text = txt_fin.Text;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            lbl_username.Text = txt_username.Text;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            lbl_name.Text = txt_name.Text;
        }

        private void txt_dad_name_TextChanged(object sender, EventArgs e)
        {
            lbl_dad_name.Text = txt_dad_name.Text;
        }

        private void txt_sex_TextChanged(object sender, EventArgs e)
        {
            lbl_sex.Text = txt_sex.Text;
        }

        private void txt_birthday_TextChanged(object sender, EventArgs e)
        {
            lbl_birthday.Text = txt_birthday.Text;
        }

        private void txt_place_of_birthday_TextChanged(object sender, EventArgs e)
        {
            lbl_place_of_birth.Text = txt_place_of_birth.Text;
        }

        private void txt_family_situation_TextChanged(object sender, EventArgs e)
        {
            lbl_family_situation.Text = txt_family_situation.Text;
        }

        private void txt_givedate_TextChanged(object sender, EventArgs e)
        {
            lbl_give.Text = txt_givedate.Text;
        }

        private void txt_reliability_TextChanged(object sender, EventArgs e)
        {
            lbl_reliability.Text = txt_reliability.Text;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (string.IsNullOrEmpty(txt_series.Text) ||
                string.IsNullOrEmpty(txt_fin.Text) ||
                string.IsNullOrEmpty(txt_username.Text) ||
                string.IsNullOrEmpty(txt_name.Text) ||
                string.IsNullOrEmpty(txt_dad_name.Text) ||
                string.IsNullOrEmpty(txt_sex.Text) ||
                string.IsNullOrEmpty(txt_birthday.Text) ||
                string.IsNullOrEmpty(txt_place_of_birth.Text) ||
                string.IsNullOrEmpty(txt_family_situation.Text) ||
                string.IsNullOrEmpty(txt_givedate.Text) ||
                string.IsNullOrEmpty(txt_reliability.Text) ||
                string.IsNullOrEmpty(txt_Issuing_organ.Text))
            {
                progressBar1.Visible = true;
                MessageBox.Show("Xanalar tam doldurulmayıb", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                progressBar1.Visible = true;
                MessageBox.Show("Verilənlər yadda saxlandı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void progressBar1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Əməliyyat tamamlandı", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }

        private void dow_picture_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Ancaq jpg format *.jpg | *jpg";
            op.ShowDialog();
            pic_box.ImageLocation = op.FileName;
        }

        private void progressBar1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
