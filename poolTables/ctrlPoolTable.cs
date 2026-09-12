using poolTables.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poolTables
{
    public partial class ctrlPoolTable : UserControl
    {
        private int seconds = 0;

        private bool isPaused=false;
        private int rentSeconds = 0;
        private bool isOpenTime = false;
        private bool isStarted = false;

        private string _tableName = "table";

        private string _player = "player";

        [
           Category("Pool Table"),
           Description("Put The Name of the table")
       ]
        public string tableName
        {
            get
            {
                return _tableName;
            }
            set
            {
                _tableName = value;
                gbTable.Text = _tableName;

            }
        }

        private string _playerName = "player";
        [
           Category("Pool Table"),
           Description("Put The Name of the Person who rent the table")
       ]
        public string playerName { 
            get { 
                return _playerName;
            }
            set { 
                _playerName = value;
                lbPlayerName.Text = _playerName;
            }
        }

        private int _hourlyRate = 10;

        [
            Category("Pool Table"),
            Description("Put The rate of each hour in pounds")
        ]
        public int hourlyRate { 
            
            get { 
                return _hourlyRate;
            }

            set {

                if (value > 0)
                { 
                    _hourlyRate = value;
                }

            }
        }

        private SoundPlayer clickSound;
        public ctrlPoolTable()
        {
            InitializeComponent();
            clickSound = new SoundPlayer("Sounds/endTime.wav");
        }

        void useReturnedData(string plyerRentName,int hours,int minutes,bool isOpen)
        {
            this.playerName= plyerRentName;

            if(!isOpen)
            { 
                this.rentSeconds = (hours * 60 + minutes) * 60;
            }

            this.isOpenTime= isOpen;

            StartTime();
        }

        private void StartTime()
        {
            if (isStarted)
            {
                timer.Stop();
                isStarted = false;
                btnStart.Text = "Start";
            }
            else
            {
                timer.Start();
                isStarted = true;
                btnStart.Text = "Pause";
                isPaused=true;
            }

            btnEnd.Enabled = true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                frmRentDetails frmRentDetails = new frmRentDetails();
                frmRentDetails.returnFormData += useReturnedData;

                frmRentDetails.Show();
            }
            else
            {
                StartTime();
            }
           
            
            
        }

       
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (!isOpenTime)
            {
                if (seconds == rentSeconds)
                {


                   clickSound.Play();

                    btnEnd_Click(null,new EventArgs());
                }
            }
            update_lbTimer();
        }

        private void update_lbTimer()
        {

            int seconds = this.seconds;
            int minutes = seconds / 60;
            seconds %= 60;
            int hours = minutes / 60;
            minutes %= 60;

            lbTimer.Text = hours.ToString("00") + ':' + minutes.ToString("00") + ':' + seconds.ToString("00");

        }

        private void resetPoolTable()
        {
            timer.Stop();
            lbTimer.Text = "00:00:00";
            btnStart.Text = "Start";
            btnEnd.Enabled= false; 
            seconds= 0;
            isStarted = false;
            isPaused= false;

        }

        private double calcFees()
        {
            double timeInHours = seconds / 3600f;
            return timeInHours * _hourlyRate;
        }
        private class TableArgs : EventArgs
        {
            public int houreRate = 0;
            public int timeInSeconds = 0;

            public string tablePlayer="";
            public double fees = 0;
            public string tableName = "";
            public TableArgs(int houreRate, int timeInSeconds,string tableName,string tablePlayer,double fees)
            {

                this.houreRate= houreRate;
                this.timeInSeconds= timeInSeconds;
                this.tableName = tableName;
                this.fees= fees;
                this.tablePlayer= tablePlayer;
                   
            }
             
        }

        [
            Category("Pool Table Events")
            ]
        private event EventHandler<TableArgs> onEndTable;


        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer.Stop();
            onEndTable?.Invoke(this, new TableArgs(_hourlyRate, seconds,tableName,playerName,calcFees()));
            resetPoolTable();

        }

        private void ctrlPoolTable1_onEndTable(object sender, ctrlPoolTable.TableArgs e)
        {
            MessageBox.Show($"The Table \"{e.tableName}\" that rented by player \"{e.tablePlayer}\" fees is \"{e.fees.ToString("0.00")}\"$ for \"{e.timeInSeconds}\" seconds");
        }
        private void ctrlPoolTable_Load(object sender, EventArgs e)
        {
            onEndTable += ctrlPoolTable1_onEndTable;
            btnEnd.Enabled= false;
        }
    }
}
