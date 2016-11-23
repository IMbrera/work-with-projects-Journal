using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace wwdt
{
    public partial class Form1 : Form
    {
              DateTime start;
        Timer timer = new Timer();
        private DataGridView dgv;
        private SqlConnection conn;
        private DataSet dataS;
        private SqlDataAdapter adap;
        SqlCommand command = new SqlCommand();
        public Form1()
        {

            InitializeComponent();

            //connect
            #region
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Desktop\Диплом\wwdt\wwdt\db.mdf;Integrated Security=True");
            adap = new SqlDataAdapter();
            dataS = new DataSet();
            //    dataGridView1.DataSource = tableBindingSource;
            adap.SelectCommand = new SqlCommand("select * from dbNET", conn);

            adap.InsertCommand = new SqlCommand("Insert into dbNET (Start, Описание, ВремяРаботы) values (@id, @dw, @sw)", conn);

            adap.InsertCommand.Parameters.Add("@id", SqlDbType.Char, 20, "Start");
            adap.InsertCommand.Parameters.Add("@dw", SqlDbType.Char, 100, "Описание");
            adap.InsertCommand.Parameters.Add("@sw", SqlDbType.Char, 10, "ВремяРаботы");


            adap.UpdateCommand = new SqlCommand("update dbNET set Start=@id, Описание=@dt, ВремяРаботы = @sw", conn);
            adap.UpdateCommand.Parameters.Add("@id", SqlDbType.Char, 20, "Start");
            adap.UpdateCommand.Parameters.Add("@dw", SqlDbType.Char, 100, "Описание");
            adap.UpdateCommand.Parameters.Add("@sw", SqlDbType.Char, 10, "ВремяРаботы");


            adap.DeleteCommand = new SqlCommand("delete from dbNET where Start=@id", conn);
            adap.DeleteCommand.Parameters.Add("@id", SqlDbType.Char, 20, "Start");
            adap.Fill(dataS, "dbNET");
            /*
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            // dataGridView1.DataSource = dataS.Tables[0];
            dgv = new DataGridView { Parent = this, Dock = DockStyle.Top, DataSource = dataS.Tables["dbNET"] };
            dataGridView1.DataSource = dataS.Tables["dbNET"];
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
            остановитьпауза.Enabled = false;
            сохранитьЗапись.Enabled = false;
        }
    


        private void StartTimer()
        {
            
            start = DateTime.Now;
            timer.Interval = 1000; //1 sec
            timer.Start();
            сохранитьЗапись.Enabled = false;
            остановитьпауза.Enabled = true;
            выход.Enabled = false;

        }

        void timer_Tick(object sender, EventArgs e)
        {

            TimeSpan time = (DateTime.Now - start).Duration();
            labelTime.Text = time.ToString(@"hh\:mm\:ss");
            // labelTime.Text = (++timeCoStarter).ToString();


        }



        private void addNotetoGrid()
        {
            dataS.Tables["dbNET"].Rows.Add(start.ToString("yyyy-MM-dd HH:mm"), textNotes.Text, labelTime.Text);


            /*
        int row = dataGridView1.Rows.Count;
        adap.UpdateCommand.Parameters.Add(start.ToString("yyyy-MM-dd HH:mm"));

        dataGridView1["ВремяРаботы", row].Value = labelTime.Text;
        dataGridView1["Описание", row].Value = textNotes.Text;
        */
        }

        private void endtime_Click(object sender, EventArgs e)
        {
            
            timer.Stop();
            addNotetoGrid();
            textNotes.Text = "";
            labelTime.Text = "00:00:00";

        }

        private void открытьЖурналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;           
            // form.Show();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == false)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                treyWorker.Visible = true;
            }
        }

           private void сохранитьЗаписьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adap.Update(dataS.Tables["dbNet"]);
            выход.Enabled = true;
            НачатьРаботу.Enabled = true;
            сохранитьЗапись.Enabled = false;
        }

        private void остановитьпаузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textNotes.Text=="")
            {
               if (DialogResult==DialogResult.Yes)
                
                    textNotes.Focus();
                

            }
            сохранитьЗапись.Enabled = true;
            НачатьРаботу.Enabled = false;
            выход.Enabled = false;
            timer.Stop();
            addNotetoGrid();
            textNotes.Text = "";
            labelTime.Text = "00:00:00";
            остановитьпауза.Enabled = false;
            НачатьРаботу.Enabled = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Начать_работу(object sender, EventArgs e)
        {
            StartTimer();
            НачатьРаботу.Enabled = false;
            textNotes.Text = "";
        }

      

        private void metroToggle1_CheckedChanged_2(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            adap.Update(dataS.Tables["dbNET"]);
            выход.Enabled = true;
        }
        
    }
}