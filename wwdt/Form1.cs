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
using wwdt.Properties;
namespace wwdt
{
    public partial class Form1 : Form
    {
              DateTime start;
        Timer timer = new Timer();
        private SqlConnection conn;
        private DataSet dataS, dataSet;
        private SqlDataAdapter adap, adapter;
        SqlCommand command = new SqlCommand();
        public Form1()
        {

            InitializeComponent();

            //connect
            #region
            conn = new SqlConnection(Settings.Default.conn);

          //  conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Desktop\Диплом\wwdt\wwdt\db.mdf;Integrated Security=True");
            adap = new SqlDataAdapter();
            dataS = new DataSet();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter();
            //    dataGridView1.DataSource = tableBindingSource;
            //fill and work with first tab grid

            firstDB();
            secondDB();

            #endregion
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
            остановитьпауза.Enabled = false;
            сохранитьЗапись.Enabled = false;
     
        }
        private void firstDB()
        {
            #region
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
            dataGridView1.DataSource = dataS.Tables["dbNET"];

            #endregion
        }
        private void secondDB()
        {
            adapter.SelectCommand = new SqlCommand("select * from Objects", conn);

            adapter.InsertCommand = new SqlCommand("Insert into Objects (Name_product,Definition,Value) values (@name,@def ,@value)", conn);

            adapter.InsertCommand.Parameters.Add("@name", SqlDbType.Char, 20, "Name_product");
            adapter.InsertCommand.Parameters.Add("@def", SqlDbType.Char, 20, "Definition");
            adapter.InsertCommand.Parameters.Add("@value", SqlDbType.Int, 10000, "Value");



            adapter.UpdateCommand = new SqlCommand("update Objects set Name_product=@name, Value=@value", conn);
            adapter.UpdateCommand.Parameters.Add("@name", SqlDbType.Char, 20, "Name_product");
            adapter.UpdateCommand.Parameters.Add("@def", SqlDbType.Char, 20, "Definition");
            adapter.UpdateCommand.Parameters.Add("@value", SqlDbType.Int, 10000, "Value");

            adapter.DeleteCommand = new SqlCommand("delete from Objects where Name_product=@name", conn);
            adapter.DeleteCommand.Parameters.Add("@name", SqlDbType.Char, 20, "Name_product");
            adapter.Fill(dataSet, "Objects");
            dataGridView2.DataSource = dataSet.Tables["Objects"];
        }

        #region
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

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            adap.Update(dataS.Tables["dbNET"]);
            выход.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            adapter.Update(dataSet.Tables["Objects"]);
        }

        private void metroToggle1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secondDB();
        }
    }
}